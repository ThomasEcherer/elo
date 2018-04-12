
namespace EloixClient.IndexServerFW.Workflow
{
  /// <summary>
  /// The purpose of this class is to provide a back-pointer to 
  /// the interface object of this package.
  /// </summary>
  public class FWWorkflowBase
  {
    /// <summary>
    /// Back-pointer to the interface object of this package.
    /// </summary>
    protected FWWorkflowInterface ifc;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="ifc">Interface object of this package</param>
    public FWWorkflowBase(FWWorkflowInterface ifc)
    {
      this.ifc = ifc;
    }
    /// <summary>
    /// Gets the connection object.
    /// </summary>
    public FWConnection Conn
    {
      get { return ifc.Conn; }
    }
    /// <summary>
    /// Gets the class factory object of this package.
    /// </summary>
    public FWWorkflowClassFactory ClassFactory
    {
      get { return ifc.ClassFactory; }
    }
  }
}
