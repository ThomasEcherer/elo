using EloixClient.IndexServerFW.Utils;

namespace EloixClient.IndexServerFW.Workflow
{
  /// <summary>
  /// Compares FWUserTask objects by type (workflow, reminder, activity)
  /// </summary>
  public class FWCompareUserTaskByType : FWCompareObject<FWUserTask> 
  {
    /// <summary>
    /// Compare objects ascending.
    /// </summary>
    /// <param name="o1">First object</param>
    /// <param name="o2">Second object</param>
    /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
    protected override int internalCompare(FWUserTask o1, FWUserTask o2)
    {
      return o1.Type - o2.Type;
    }

  }

  /// <summary>
  /// Compares FWUserTask objects by priority
  /// </summary>
  public class FWCompareUserTaskByPriority : FWCompareObject<FWUserTask>
  {
    /// <summary>
    /// Compare objects ascending.
    /// </summary>
    /// <param name="o1">First object</param>
    /// <param name="o2">Second object</param>
    /// <returns>0, if o1 equal o2, greater 0 if o1 is greater than o2, less than 0 if o1 is less than o2.</returns>
    protected override int internalCompare(FWUserTask o1, FWUserTask o2)
    {
      return o2.Priority - o1.Priority;
    }

  }

  /// <summary>
  /// Compares FWUserTask objects by name (short description)
  /// </summary>
  public class FWCompareUserTaskByName : FWCompareObject<FWUserTask>
  {
    /// <summary>
    /// Compare objects ascending.
    /// </summary>
    /// <param name="o1">First object</param>
    /// <param name="o2">Second object</param>
    /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
    protected override int internalCompare(FWUserTask o1, FWUserTask o2)
    {
      return o1.Name.CompareTo(o2.Name);
    }

  }

  /// <summary>
  /// Compares FWUserTask objects by date
  /// </summary>
  public class FWCompareUserTaskByDate : FWCompareObject<FWUserTask>
  {
    /// <summary>
    /// Compare objects ascending.
    /// </summary>
    /// <param name="o1">First object</param>
    /// <param name="o2">Second object</param>
    /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
    protected override int internalCompare(FWUserTask o1, FWUserTask o2)
    {
      return o1.Date.CompareTo(o2.Date);
    }

  }

  /// <summary>
  /// Compares FWUserTask objects by receiver
  /// </summary>
  public class FWCompareUserTaskByReceiverName : FWCompareObject<FWUserTask>
  {
    /// <summary>
    /// Compare objects ascending.
    /// </summary>
    /// <param name="o1">First object</param>
    /// <param name="o2">Second object</param>
    /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
    protected override int internalCompare(FWUserTask o1, FWUserTask o2)
    {
      return o1.ReceiverName.CompareTo(o2.ReceiverName);
    }

  }

  /// <summary>
  /// Compares FWUserTask objects by memo
  /// </summary>
  public class FWCompareUserTaskByDesc : FWCompareObject<FWUserTask>
  {
    /// <summary>
    /// Compare objects ascending.
    /// </summary>
    /// <param name="o1">First object</param>
    /// <param name="o2">Second object</param>
    /// <returns>0, if o1 equal o2, 1 if o1 is greater than o2, -1 if o1 is less than o2.</returns>
    protected override int internalCompare(FWUserTask o1, FWUserTask o2)
    {
      return o1.Desc.CompareTo(o2.Desc);
    }

  }
}
