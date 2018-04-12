using de.elo.ix.client;
using EloixClient.IndexServerFW.Content;

namespace EloixClient.IndexServerFS.Content
{
  /// <summary>
  /// This class creates objects of classes used to access the ELOFS.
  /// </summary>
  public class FSContentClassFactory : EloixClient.IndexServerFW.Content.FWContentClassFactory
  {
    /// <summary>
    /// Constructs a class factory object. 
    /// Modifies the default element selectors. 
    /// </summary>
    public FSContentClassFactory(FSContentInterface ifc) : base(ifc)
    {
    }

    /// <summary>
    /// Create new FWDocVersion object.
    /// </summary>
    /// <param name="dv">DocVersion object</param>
    /// <param name="sord">Sord object.</param>
    /// <param name="type">Type of version object: version, attachment, etc.</param>
    /// <returns>FWDocVersion object</returns>
    public override FWDocVersion NewDocVersion(DocVersion dv, FWSord sord, FWDocVersionType type)
    {
      return new FSDocVersion((FSContentInterface)ifc, dv, sord, type);
    }

    /// <summary>
    /// Create new FWDoc object.
    /// </summary>
    /// <param name="sord">Sord object</param>
    /// <returns>FWDoc object</returns>
    public override FWDocument NewDocument(Sord sord)
    {
      return new FSDocument((FSContentInterface)ifc, sord);
    }
  
    /// <summary>
    /// Create a FSDownloadManager object
    /// </summary>
    /// <param name="workDir">Working directory</param>
    /// <param name="lifetimeSeconds">Lifetime of non-modified files in the working directory.</param>
    /// <returns></returns>
    public override FWDownloadManager NewDownloadManager(string workDir, int lifetimeSeconds)
    {
      return new FSDownloadManager((FSContentInterface)ifc, workDir, lifetimeSeconds);
    }
  }
}
