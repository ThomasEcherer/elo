using System;
using System.Windows.Forms;

namespace EloixClientUI.Utils
{
  /// <summary>
  /// This class is intended to be used in a using statement to display 
  /// a wait cursor.
  /// <code>
  /// using(new Hourglass())
  /// {
  ///   // some time consuming operation
  /// }
  /// </code>
  /// </summary>
  public class Hourglass : IDisposable
  {
    private Cursor saved = null;
    /// <summary>
    /// Constructor
    /// </summary>
    public Hourglass()
    {
      saved = Cursor.Current;
      Cursor.Current = Cursors.WaitCursor;
    }
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="showWaitCursor">true: display a wait cursor; false: the cursor is not changed.</param>
    public Hourglass(bool showWaitCursor)
    {
      if (showWaitCursor)
      {
        saved = Cursor.Current;
        Cursor.Current = Cursors.WaitCursor;
      }
    }
    /// <summary>
    /// Resets the cursor.
    /// </summary>
    public void Dispose()
    {
      if (saved != null)
      {
        Cursor.Current = saved;
      }
    }

    private int showCount;

    public void Show()
    {
      if (showCount++ == 0)
      {
        saved = Cursor.Current;
        Cursor.Current = Cursors.WaitCursor;
      }
    }

    public void Hide() 
    {
      if (--showCount == 0)
      {
        Cursor.Current = saved;
      }
    }
  }
}
