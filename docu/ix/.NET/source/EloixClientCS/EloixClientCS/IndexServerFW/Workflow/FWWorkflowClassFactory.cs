using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.Workflow
{
  /// <summary>
  /// This class creates objects of classes of this package 
  /// inside virtual functions. It can be overloaded to create 
  /// objects of inherited classes.
  /// </summary>
  public class FWWorkflowClassFactory
  {
    /// <summary>
    /// Back-pointer to interface object.
    /// </summary>
    FWWorkflowInterface ifc;
    /// <summary>
    /// Constructor
    /// </summary>
    public FWWorkflowClassFactory(FWWorkflowInterface ifc)
    {
      this.ifc = ifc;
    }
    /// <summary>
    /// Create a new user task object
    /// </summary>
    /// <param name="ut">UserTask object from IndexServer API</param>
    /// <returns>Wrapper object</returns>
    public virtual FWUserTask NewUserTask(UserTask ut)
    {
      return new FWUserTask(ifc, ut);
    }
  }
}
