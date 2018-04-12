using System;
using System.Collections;
using System.Collections.Generic;

namespace EloixClient.IndexServerFW.Utils
{
  /// <summary>
  /// Wraps a non-parameterized IComparer into a parameterized IComparer&lt;T&gt;.
  /// </summary>
  /// <typeparam name="T">Type</typeparam>
  /// <remarks>
  /// This stuff is nessesary because user interface components 
  /// cannnot be generic types. The Visual Studio designer does not find
  /// ressources for parameterized components.
  /// The VirtualListView class of the EloixClientUI project
  /// should be a parameterized type to be able to display a 
  /// parameterized IResultCache. 
  /// </remarks>
  public class CastComparer<T> : IComparer<T>
  {
    private IComparer innerComp;
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="innerComp">Comparer object to be wrapped.</param>
    public CastComparer(IComparer innerComp)
    {
      this.innerComp = innerComp;
    }
    /// <summary>
    /// Compare function
    /// </summary>
    /// <param name="o1">First object</param>
    /// <param name="o2">Second object</param>
    /// <returns></returns>
    public int Compare(T o1, T o2)
    {
      return innerComp.Compare(o1, o2);
    }
  }
  /// <summary>
  /// Wraps a non-parameterized IEnumerator object.
  /// </summary>
  /// <typeparam name="T">Type</typeparam>
  public class CastEnumerator<T> : IEnumerator<T>
  {
    private IEnumerator innerEnum;
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="innerEnum">This object is beeing wrapped.</param>
    public CastEnumerator(IEnumerator innerEnum)
    {
      this.innerEnum = innerEnum;
    }

    object IEnumerator.Current { get { return innerEnum.Current; } }
    bool IEnumerator.MoveNext() { return innerEnum.MoveNext(); }
    void IEnumerator.Reset() { innerEnum.Reset(); }
    T IEnumerator<T>.Current { get { return (T)innerEnum.Current; } }
    void IDisposable.Dispose() { }
  }

  /// <summary>
  /// Wraps a non-parameterized IEnumerable object.
  /// </summary>
  /// <typeparam name="T">Type</typeparam>
  public class CastEnumerable<T> : IEnumerable<T>
  {
    IEnumerable innerEnumerable;
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="innerEnumerable">This object is beeing wrapped.</param>
    public CastEnumerable(IEnumerable innerEnumerable)
    {
      this.innerEnumerable = innerEnumerable;
    }
    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
      return new CastEnumerator<T>(innerEnumerable.GetEnumerator());
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return innerEnumerable.GetEnumerator();
    }
  }

}
