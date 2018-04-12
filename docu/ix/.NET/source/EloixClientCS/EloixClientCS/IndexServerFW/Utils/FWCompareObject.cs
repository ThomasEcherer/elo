using System;
using System.Collections;
using System.Collections.Generic;

namespace EloixClient.IndexServerFW.Utils
{
  /// <summary>
  /// Compare objects ascending or descending.
  /// </summary>
  public abstract class FWCompareObject : IComparer
  {
    private bool ascendingVal = true;

    /// <summary>
    /// Ascending or descending sort order. 
    /// </summary>
    public bool Ascending
    {
      get
      {
        return ascendingVal;
      }
      set
      {
        ascendingVal = value;
      }
    }
    /// <summary>
    /// Compare objects ascending.
    /// </summary>
    /// <param name="o1">First object</param>
    /// <param name="o2">Second object</param>
    /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
    protected abstract int internalCompare(Object o1, Object o2);

    /// <summary>
    /// Compare objects.
    /// </summary>
    /// <param name="o1">First object</param>
    /// <param name="o2">Second object</param>
    /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
    /// <remarks>Calls internalCompare and swaps the signum on descending order.</remarks>
    public virtual int Compare(Object o1, Object o2)
    {
      int c = internalCompare(o1, o2);
      return Ascending ? c : -c;
    }
    /// <summary>
    /// Helper function to compare strings that can be null.
    /// </summary>
    /// <param name="s1">First string</param>
    /// <param name="s2">Second string</param>
    /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
    /// <remarks>A null or empty string is less than any other non-empty string.</remarks>
    public static int CompareString(String s1, String s2)
    {
      bool b1 = s1 != null && s1.Length != 0;
      bool b2 = s2 != null && s2.Length != 0;
      if (b1 && b2)
      {
        return String.Compare(s1, s2);
      }
      if (b1 && !b2)
      {
        return -1;
      }
      if (!b1 && b2)
      {
        return 1;
      }
      return 0;
    }
  }

  /// <summary>
  /// Compare objects ascending/descending
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public abstract class FWCompareObject<T> : FWCompareObject, IComparer<T> 
  {
    /// <summary>
    /// Compare objects ascending.
    /// </summary>
    /// <param name="o1">First object</param>
    /// <param name="o2">Second object</param>
    /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
    protected abstract int internalCompare(T o1, T o2);
    /// <summary>
    /// Overrides the interhited method and calls internally 
    /// the internalCompare with the template parameters.
    /// </summary>
    /// <param name="o1">First object</param>
    /// <param name="o2">Second object</param>
    /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
    protected override int internalCompare(Object o1, Object o2)
    {
      return internalCompare((T)o1, (T)o2);
    }
    
    /// <summary>
    /// Compare objects.
    /// </summary>
    /// <param name="o1">First object</param>
    /// <param name="o2">Second object</param>
    /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
    /// <remarks>Calls internalCompare and swaps the signum on descending order.</remarks>
    public virtual int Compare(T o1, T o2)
    {
      return base.Compare(o1, o2);
    }

  }

  /// <summary>
  /// This class compares FWSord objects by several comparers. 
  /// </summary>
  public class FWCompareObjectByComparers: FWCompareObject, IComparer
  {
    /// <summary>
    /// List of comparer objects.
    /// </summary>
    protected List<FWCompareObject> comparersVal = new List<FWCompareObject>();

    /// <summary>
    /// Constructor
    /// </summary>
    public FWCompareObjectByComparers()
    {
    }

    /// <summary>
    /// List of comparers.
    /// </summary>
    public List<FWCompareObject> Comparers
    {
      get
      {
        return comparersVal;
      }
      set
      {
        comparersVal = value;
      }
    }

    /// <summary>
    /// The most significant comparer.
    /// </summary>
    /// <remarks>
    /// Assing one of the comparers to this property to reorder
    /// the comparer list. The new FirstComparer is removed from its 
    /// current position to the first position. 
    /// </remarks>
    public FWCompareObject FirstComparer
    {
      get
      {
        return comparersVal[0];
      }
      set
      {
        for (int i = 0; i < comparersVal.Count; i++)
        {
          if (comparersVal[i].Equals(value))
          {
            if (i != 0)
            {
              comparersVal.RemoveAt(i);
              comparersVal.Insert(0, value);
            }
            break;
          }
        }
      }
    }

    /// <summary>
    /// Add a comparer to the internal list.
    /// </summary>
    /// <param name="comparer"></param>
    /// <returns></returns>
    public FWCompareObject Add(FWCompareObject comparer)
    {
      comparersVal.Add(comparer);
      return comparer;
    }

    /// <summary>
    /// Implements the abstract function of FWCompareSord.
    /// </summary>
    /// <param name="o1">First object</param>
    /// <param name="o2">Second object</param>
    /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
    protected override int internalCompare(Object o1, Object o2)
    {
      foreach (FWCompareObject comp in comparersVal)
      {
        int c = comp.Compare(o1, o2);
        if (c != 0) return c;
      }
      return 0;
    }
  }

}
