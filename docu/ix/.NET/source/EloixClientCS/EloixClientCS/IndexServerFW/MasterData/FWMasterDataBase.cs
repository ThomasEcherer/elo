
namespace EloixClient.IndexServerFW.MasterData
{
  /// <summary>
  /// The purpose of this class is to provide a back-pointer to 
  /// the interface object of this package.
  /// </summary>
  public class FWMasterDataBase
  {
    /// <summary>
    /// Back-pointer to the interface object of this package.
    /// </summary>
    protected FWMasterDataInterface ifc;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="ifc">Interface object of this package</param>
    public FWMasterDataBase(FWMasterDataInterface ifc)
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
    public FWMasterDataClassFactory ClassFactory
    {
      get { return ifc.ClassFactory; }
    }
  }
}
