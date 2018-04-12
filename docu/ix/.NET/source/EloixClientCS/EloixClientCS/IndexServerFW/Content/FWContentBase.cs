using System;


namespace EloixClient.IndexServerFW.Content
{
  /// <summary>
  /// The purpose of this class is to provide a back-pointer to 
  /// the interface object of this package.
  /// </summary>
  public class FWContentBase {

    /// <summary>
    /// Back-pointer to the interface object of this package.
    /// </summary>
    protected FWContentInterface ifc;
    
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="ifc">Interface object of this package</param>
    public FWContentBase(FWContentInterface ifc) {
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
    public FWContentClassFactory ClassFactory
    {
      get { return ifc.ClassFactory; }
    }
  }
}
