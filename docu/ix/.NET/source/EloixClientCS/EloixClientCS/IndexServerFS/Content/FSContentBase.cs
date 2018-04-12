using EloixClient.IndexServerFW;

namespace EloixClient.IndexServerFS.Content
{
  /// <summary>
  /// The purpose of this class is to provide a back-pointer to 
  /// the interface object of this package.
  /// </summary>
  public class FSContentBase {

    /// <summary>
    /// Back-pointer to the interface object of this package.
    /// </summary>
    protected FSContentInterface ifc;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="ifc">Interface object of this package</param>
    public FSContentBase(FSContentInterface ifc)
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
    public FSContentClassFactory ClassFactory
    {
      get { return (FSContentClassFactory)ifc.ClassFactory; }
    }
  }
}
