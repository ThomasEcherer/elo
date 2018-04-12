using System;
using System.Collections;
using System.Collections.Generic;
using EloixClient.IndexServerFW.Utils;

namespace EloixClient.IndexServer
{
  /// <summary>
  /// Event arguments for IResultCache events
  /// </summary>
  public class ResultCacheEventArgs : EventArgs
  {
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="startIndex">Start index</param>
    /// <param name="max">Maximum of entries to be returned</param>
    public ResultCacheEventArgs(int startIndex, int max)
    {
      this.StartIndex = startIndex;
      this.Max = max;
    }
    /// <summary>
    /// Start index
    /// </summary>
    public int StartIndex;
    /// <summary>
    /// Maximum entries
    /// </summary>
    public int Max;
  }

  /// <summary>
  /// This interface summarizes the functionality of a cache that 
  /// manages objects returned as FindResult from the findFirst* and findNext* functions.
  /// </summary>
  public interface IResultCache : IEnumerable, IDisposable
  {
    /// <summary>
    /// Get the object at the given index.
    /// </summary>
    /// <param name="idx">Index</param>
    /// <returns>Cached object.</returns>
    /// <remarks>The object is read from the server, if it is not in the cache.</remarks>
    Object this[int idx] { get; }
    /// <summary>
    /// Sort cached objects.
    /// </summary>
    /// <param name="comp">Comparer</param>
    void Sort(IComparer comp);
    /// <summary>
    /// Reads all objects into the cache and returns the number of objects.
    /// </summary>
    /// <returns></returns>
    int Count { get; }
    /// <summary>
    /// Returns the number of result items. If the FindOptions do not demand to 
    /// evaluate the number of result items, the returned value is an estimated value. 
    /// Only when a findFirst or findNext call reaches the end of the 
    /// result list, the value is correct.
    /// </summary>
    /// <seealso cref="FindOptions.evalCount"/>
    /// <seealso cref="FindOptions.totalCount"/>
    int CountEstimated { get; set;  }
    /// <summary>
    /// The search was interrupted due to a timeout.
    /// </summary>
    bool BreakTimeout { get; }
    /// <summary>
    /// The search was interrupted because the number of total results reached.
    /// </summary>
    /// <seealso cref="FindOptions.totalCount"/>
    bool BreakTotalCount { get; }
    /// <summary>
    /// Clears the cached objects. 
    /// Subsequent opterations will perform the find operation again.
    /// </summary>
    void Clear();
    /// <summary>
    /// This event is fired, when the cache begins to read from the IndexServer
    /// </summary>
    event EventHandler BeginRead;
    /// <summary>
    /// This event is fired, when the cache has received the results from the IndexServer
    /// </summary>
    event EventHandler EndRead;
  }

  /// <summary>
  /// This interface summarizes the functionality of a cache that 
  /// manages objects returned as FindResult from the findFirst* and findNext* functions.
  /// </summary>
  /// <typeparam name="T">Cached object type</typeparam>
  public interface IResultCache<T> : IEnumerable<T>, IResultCache
  {
    /// <summary>
    /// Returns the result object at the given index.
    /// </summary>
    /// <param name="idx">Index</param>
    /// <returns>Object at position idx. If idx is larger than the maximum number of objects, a null reference is returned.</returns>
    new T this[int idx] { get; }
    /// <summary>
    /// Sort results by the given comparer.
    /// </summary>
    /// <param name="comparer"></param>
    void Sort(IComparer<T> comparer);
  }

  /// <summary>
  /// This class helps to collect results from the findFirst and findNext functions.
  /// </summary>
  /// <typeparam name="T">Object type</typeparam>
  /// <typeparam name="TFindInfo">FindInfo type</typeparam>
  public abstract class FindResultCache<T, TFindInfo> : IResultCache<T>, ICleanupEvent
  {
    /// <summary>
    /// IndexServer connection
    /// </summary>
      protected IXConnIXServicePortIF_2 ix;
    /// <summary>
    /// True, if there are more results available
    /// </summary>
    private bool moreResults;
    /// <summary>
    /// True, if a timeout occured
    /// </summary>
    private bool breakTimeoutVal;
    /// <summary>
    /// True, if the total count exceeded
    /// </summary>
    private bool breakTotalCountVal;
    /// <summary>
    /// Search-ID
    /// </summary>
    private String searchId;
    /// <summary>
    /// List of result objects
    /// </summary>
    private List<T> objs;
    /// <summary>
    /// This value contains the estimated number of result items. 
    /// </summary>
    /// <seealso cref="FindOptions.evalCount"/>
    private int countEstimatedVal;
    /// <summary>
    /// FindInfo object
    /// </summary>
    private TFindInfo findInfoValue;
    /// <summary>
    /// Start value for property Count
    /// </summary>
    public const int MAX_SORDS_DEFAULT = 10 * 1000;
    /// <summary>
    /// Maximum number of objects to be returned by findFirst and findNext 
    /// </summary>
    public const int DEFAULT_READ_GRANULARITY = 500;

    /// <summary>
    /// 
    /// </summary>
    private int readGranularityVal;
    
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="ix">IndexServer interface</param>
    /// <param name="findInfo">FindInfo</param>
    protected FindResultCache(IXConnIXServicePortIF_2 ix, TFindInfo findInfo)
    {
      this.ix = ix;
      this.findInfoValue = findInfo;
      Clear();
    }

    /// <summary>
    /// Clears all internally stored results.
    /// </summary>
    public void Clear()
    {
      InternalDispose();
      breakTimeoutVal = breakTotalCountVal = false;
      moreResults = true;
      searchId = null;
      objs = new List<T>();
      countEstimatedVal = 0;
      readGranularityVal = DEFAULT_READ_GRANULARITY;
    }

    /// <summary>
    /// Release the temporary objects stored on the server by calling findClose.
    /// </summary>
    void IDisposable.Dispose()
    {
      InternalDispose();
    }
    /// <summary>
    /// <see cref="IResultCache.CountEstimated"/>
    /// </summary>
    public int CountEstimated
    {
      get
      {
        T x = this[0];
        return countEstimatedVal;
      }
      set
      {
        countEstimatedVal = value;
      }
    }

    /// <summary>
    /// Number of results. Causes all results to be read.
    /// </summary>
    public int Count
    {
      get
      {
        ReadAll();
        return countEstimatedVal;
      }
    }

    /// <summary>
    /// <see cref="IResultCache.BreakTimeout"/>
    /// </summary>
    public bool BreakTimeout 
    {
      get
      {
        return breakTimeoutVal;
      }
    }

    /// <summary>
    /// <see cref="IResultCache.BreakTotalCount"/>
    /// </summary>
    public bool BreakTotalCount
    {
      get
      {
        return breakTotalCountVal;
      }
    }

    /// <summary>
    /// Read results beginning at the given index from IndexServer.
    /// </summary>
    /// <param name="blockIdx">Index</param>
    protected virtual void ReadResultBlock(int blockIdx)
    {
      FindResult fr = null;

      ResultCacheEventArgs args = null;
      try
      {
        // call BeginRead event
        if (beginReadVal != null)
        {
          if (args == null) args = new ResultCacheEventArgs(blockIdx, readGranularityVal);
          beginReadVal(this, args);
        }
      
        // Read from server
        if (blockIdx == 0)
        {
          fr = FindFirst(findInfoValue, readGranularityVal);
        }
        else if (searchId != null)
        {
          fr = FindNext(searchId, blockIdx, readGranularityVal);
        }
      }
      finally
      {
        // call EndRead event
        if (endReadVal != null)
        {
          if (args == null) args = new ResultCacheEventArgs(blockIdx, readGranularityVal);
          endReadVal(this, args);
        }
      }

      if (fr != null)
      {
        int readCount = UpdateValues(blockIdx, fr);

        // If there are less than readGranularityVal objects returned,
        // we are either at the end of the result list or the IndexServer
        // reads the results so slowly, that nothing was returned from the
        // prior call to FindNext.
        while (readCount < readGranularityVal && QueryFindNext())
        {
          int idx = blockIdx + readCount;
          fr = FindNext(searchId, idx, readGranularityVal - readCount);
          readCount += UpdateValues(idx, fr);
        }

        if (!QueryFindNext())
        {
          bool allObjsRead = true;
          foreach (T t in objs)
          {
            if (t != null) continue;
            allObjsRead = false;
            break;
          }
          if (allObjsRead)
          {
            InternalDispose();
          }
        }
      }
    }


    /// <summary>
    /// Returns true, if there are more results and neither BreakTimeout
    /// nor BreakTotalCount has occured.
    /// </summary>
    /// <returns>True, if FindNext can be called.</returns>
    protected virtual bool QueryFindNext()
    {
      return moreResults;
    }

    /// <summary>
    /// Calls findClose to release the server resources attached to the search ID.
    /// </summary>
    protected virtual void InternalDispose()
    {
      try
      {
        if (ix != null && searchId != null && searchId.Length != 0)
        {
          ix.findClose(searchId);
          searchId = null;
        }
      }
      catch (Exception) { }
    }

    /// <summary>
    /// Updates the internal values for searchId, moreResults etc. after a
    /// call to findFirst or findNext.
    /// </summary>
    /// <param name="startIdx">Results have been read starting from this index</param>
    /// <param name="fr">FindResult object</param>
    /// <returns>Number of result objects in fr</returns>
    protected virtual int UpdateValues(int startIdx, FindResult fr)
    {
      searchId = fr.searchId;
      moreResults = fr.moreResults;
      breakTimeoutVal = fr.breakTimeout;
      breakTotalCountVal = fr.breakTotalCount;
      
      T[] items = GetItemsFromResult(fr);
      int n = (items != null) ? items.Length : 0;
      if (n != 0)
      {
        while (objs.Count < startIdx + n)
        {
          objs.Add(default(T));
        }

        for (int i = 0; i < n; i++)
        {
          objs[startIdx + i] = items[i];
        }

        countEstimatedVal = Math.Max(startIdx + n, countEstimatedVal);
      }

      return n;
    }

    /// <summary>
    /// Returns the result object at the given index.
    /// </summary>
    /// <param name="idx">Index</param>
    /// <returns>Object</returns>
    public virtual T this[int idx]
    {
      get {  return InternalGetObject(idx); }
    }
    /// <summary>
    /// Get the object at the given index.
    /// </summary>
    /// <param name="idx">Index</param>
    /// <returns>Object</returns>
    /// <remarks>If the object is not found in the cache, it is read from the server.</remarks>
    protected T InternalGetObject(int idx)
    {
      T ret = default(T);

      if ((idx >= objs.Count && moreResults) || // Wenn das gewünschte Objekt hinter den bisher gelesenen liegt und noch welche im Archiv vorhanden sind
          (idx < objs.Count && objs[idx] == null)) // Wenn das gewünschte Objekt innerhalb der Ergebnismenge liegt aber noch nicht gelesen wurde (wahlfreier Zugriff) 
      {
        int blockIdx = idx / readGranularityVal;
        int startIdx = blockIdx * readGranularityVal;
        if (startIdx >= objs.Count || objs[startIdx] == null)
        {
          ReadResultBlock(startIdx);
        }
      }
      if (idx < objs.Count)
      {
        ret = objs[idx];
      }

      return ret;
    }

    /// <summary>
    /// Helper class to implement an enumerator
    /// </summary>
    /// <typeparam name="T1">Object type</typeparam>
    protected class MyEnumerator<T1> : IEnumerator<T1>
    {
      /// <summary>
      /// The outer result cache object
      /// </summary>
      FindResultCache<T1, TFindInfo> cache;
      /// <summary>
      /// Current index
      /// </summary>
      int idx;
      /// <summary>
      /// Current object
      /// </summary>
      T1 currentObj;

      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="cache">Result cache object</param>
      internal MyEnumerator(FindResultCache<T1, TFindInfo> cache)
      {
        this.cache = cache;
        this.idx = -1;
        this.currentObj = default(T1);
      }
      /// <summary>
      /// Returns current object
      /// </summary>
      object IEnumerator.Current
      {
        get
        {
          return this.Current;
        }
      }
      /// <summary>
      /// Returns current object 
      /// </summary>
      public T1 Current
      {
        get
        {
          return currentObj;
        }
      }
      /// <summary>
      /// Resets the iterator
      /// </summary>
      void IEnumerator.Reset()
      {
        idx = -1;
      }
      /// <summary>
      /// Moves to the next object
      /// </summary>
      /// <returns></returns>
      bool IEnumerator.MoveNext()
      {
        idx++;
        currentObj = cache[idx];
        return currentObj != null;
      }
      /// <summary>
      /// Release resource
      /// </summary>
      void IDisposable.Dispose()
      {
      }
    };
    /// <summary>
    /// Returns an enumerator to iterate over the result objects
    /// </summary>
    /// <returns></returns>
    IEnumerator IEnumerable.GetEnumerator()
    {
      return new MyEnumerator<T>(this);
    }
    /// <summary>
    /// Returns an enumerator to iterate over the result objects
    /// </summary>
    /// <returns></returns>
    public IEnumerator<T> GetEnumerator()
    {
      return GetEnumeratorT();
    }
    /// <summary>
    /// Returns an enumerator to iterate over the result objects
    /// </summary>
    /// <returns></returns>
    public IEnumerator<T> GetEnumeratorT()
    {
      return new MyEnumerator<T>(this);
    }
    /// <summary>
    /// Returns the result items from the result list. 
    /// Sub classes have to implement this function.
    /// </summary>
    /// <param name="fr">FindResult</param>
    /// <returns>Array of items</returns>
    protected abstract T[] GetItemsFromResult(FindResult fr);
    /// <summary>
    /// Sub class implementation calls one of the findFirst functions of the IndexServer.
    /// </summary>
    /// <param name="findInfo">FindInfo</param>
    /// <param name="max"></param>
    /// <returns></returns>
    protected abstract FindResult FindFirst(TFindInfo findInfo, int max);
    /// <summary>
    /// Sub class implementation calls one of the findNext functions of the IndexServer
    /// </summary>
    /// <param name="searchId">Search-ID</param>
    /// <param name="idx">Index to be read from</param>
    /// <param name="max">Maximum number of items to be returned</param>
    /// <returns></returns>
    protected abstract FindResult FindNext(String searchId, int idx, int max);

    /// <summary>
    /// Empty implementation of ICleanupEvent.
    /// </summary>
    /// <seealso cref="ICleanupEvent"/>
    public void OnCleanup()
    {
    }

    /// <summary>
    /// Number of objects to be read from the server, 
    /// if a requerst to read at least one object is nessesary.
    /// </summary>
    public int ReadGranularity
    {
      get
      {
        return readGranularityVal;
      }
      set
      {
        readGranularityVal = value;
      }
    }

    /// <summary>
    /// Return the find information.
    /// </summary>
    public TFindInfo FindInfo
    {
      get
      {
        return findInfoValue;
      }
    }

    /// <summary>
    /// Reads all object immediately into the cache
    /// </summary>
    public void ReadAll()
    {
      if (moreResults)
      {
        foreach (T t in this) ;
      }
    }

    /// <summary>
    /// Sorts the objects by the given comparer object.
    /// </summary>
    /// <param name="comp">Comparer object</param>
    /// <remarks>This function ensures that all objects are read from the server.</remarks>
    public virtual void Sort(IComparer<T> comp)
    {
      ReadAll();
      objs.Sort(comp);
    }

    Object IResultCache.this[int idx]
    {
      get { return InternalGetObject(idx); }
    }

    void IResultCache.Sort(IComparer comp)
    {
      Sort(new CastComparer<T>(comp));
    }

    private event EventHandler beginReadVal;
    private event EventHandler endReadVal;

    event EventHandler IResultCache.BeginRead
    {
      add
      {
        if (beginReadVal != null)
        {
          beginReadVal += value;
        }
        else
        {
          beginReadVal = new EventHandler(value);
        }
      }
      remove
      {
        if (beginReadVal != null)
        {
          beginReadVal -= value;
        }
      }
    }

    event EventHandler IResultCache.EndRead
    {
      add
      {
        if (endReadVal != null)
        {
          endReadVal += value;
        }
        else
        {
          endReadVal = new EventHandler(value);
        }
      }
      remove
      {
        if (endReadVal != null)
        {
          endReadVal -= value;
        }
      }
    }

  }
}
