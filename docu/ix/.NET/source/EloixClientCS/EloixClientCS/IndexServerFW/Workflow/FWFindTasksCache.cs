using System;
using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.Workflow
{
  /// <summary>
  /// Represents a cache for user tasks.
  /// </summary>
  public class FWFindTasksCache : FindResultCache<FWUserTask, FindTasksInfo> 
  {
    /// <summary>
    /// Workflow interface object
    /// </summary>
    protected FWWorkflowInterface ifc;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="ifc">Workflow interface object</param>
    /// <param name="findInfo">Search criterias</param>
    public FWFindTasksCache(FWWorkflowInterface ifc, FindTasksInfo findInfo)
      : base(ifc.Conn.Ix, findInfo)
    {
      this.ifc = ifc;
    }
    /// <summary>
    /// Implements the abstract function FindResultCache.GetItemsFromResult.
    /// </summary>
    /// <param name="fr">FindResult object</param>
    /// <returns>UserTask array</returns>
    protected override FWUserTask[] GetItemsFromResult(FindResult fr)
    {
      FWUserTask[] arr = new FWUserTask[fr.tasks.Length];
      for (int i = 0; i < fr.tasks.Length; i++)
      {
        arr[i] = ifc.ClassFactory.NewUserTask(fr.tasks[i]);
      }
      return arr;
    }
    /// <summary>
    /// Calls the IndexServer function findFirstTasks.
    /// </summary>
    /// <param name="findInfo">Search criterias</param>
    /// <param name="max">Maximum number of objects to be returned</param>
    /// <returns>FindResult object</returns>
    protected override FindResult FindFirst(FindTasksInfo findInfo, int max)
    {
      return ifc.Conn.Ix.findFirstTasks(findInfo, max);
    }
    /// <summary>
    /// Calls the IndexServer function findNextTasks
    /// </summary>
    /// <param name="searchId">Search ID</param>
    /// <param name="idx">Return results starting at this index</param>
    /// <param name="max">Maximum number of objects to be returned</param>
    /// <returns>FindResult object</returns>
    protected override FindResult FindNext(String searchId, int idx, int max)
    {
      return ifc.Conn.Ix.findNextTasks(searchId, idx, max);
    }
  }
}
