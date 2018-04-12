
namespace EloixClient.IndexServerFW.Session
{
  /// <summary>
  /// The purpose of this class is to provide a back-pointer to 
  /// the interface object of this package.
  /// </summary>
  public class FWSessionBase
  {
    /// <summary>
    /// Back-pointer to the interface object of this package.
    /// </summary>
    protected FWSessionInterface ifc;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="ifc">Interface object of this package</param>
    public FWSessionBase(FWSessionInterface ifc)
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
    public FWSessionClassFactory ClassFactory
    {
      get { return ifc.ClassFactory; }
    }
  }
}
