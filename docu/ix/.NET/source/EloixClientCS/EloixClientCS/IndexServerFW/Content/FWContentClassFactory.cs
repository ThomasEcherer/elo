using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.Content
{
  /// <summary>
  /// This class creates objects of classes of this package 
  /// inside virtual functions. It can be overloaded to create 
  /// objects of inherited classes.
  /// </summary>
  public class FWContentClassFactory
  {
    /// <summary>
    /// Back-pointer to interface object.
    /// </summary>
    protected FWContentInterface ifc;

    /// <summary>
    /// Constructor
    /// </summary>
    public FWContentClassFactory(FWContentInterface ifc)
    {
      this.ifc = ifc;
    }    
    /// <summary>
    /// Create new FWFolder object.
    /// </summary>
    /// <param name="sord">Sord object</param>
    /// <returns>FWFolder object</returns>
    public virtual FWFolder NewFolder(Sord sord) 
    {
      return new FWFolder(ifc, sord);
    }
    /// <summary>
    /// Create new FWFindChildrenCache object.
    /// </summary>
    /// <param name="parentFolder">Parent folder object</param>
    /// <param name="inclFolders">Child cache includes folders</param>
    /// <param name="inclDocs">Child cache includes documents</param>
    /// <returns>FWFolders object</returns>
    public virtual FWFindChildrenCache<T> NewFindChildrenCache<T>(FWFolder parentFolder, bool inclFolders, bool inclDocs) where T : FWSord
    {
      return new FWFindChildrenCache<T>(ifc, parentFolder, inclFolders, inclDocs);
    }
    /// <summary>
    /// Create new FWDoc object.
    /// </summary>
    /// <param name="sord">Sord object</param>
    /// <returns>FWDoc object</returns>
    public virtual FWDocument NewDocument(Sord sord) 
    {
      return new FWDocument(ifc, sord);
    }
    /// <summary>
    /// Create new FWDocVersion object.
    /// </summary>
    /// <param name="dv">DocVersion object</param>
    /// <param name="sord">Sord object.</param>
    /// <param name="type">Type of version object: version, attachment, etc.</param>
    /// <returns>FWDocVersion object</returns>
    public virtual FWDocVersion NewDocVersion(DocVersion dv, FWSord sord, FWDocVersionType type)
    {
      return new FWDocVersion(ifc, dv, sord, type);
    }
    /// <summary>
    /// Create a FWDocVersions object.
    /// </summary>
    /// <param name="docs">Array of DocVersion objects</param>
    /// <param name="sord">Sord object.</param>
    /// <param name="type">Type of version object: version, attachment, etc.</param>
    /// <returns>FWDocVersions object</returns>
    public virtual FWDocVersions NewDocVersions(DocVersion[] docs, FWSord sord, FWDocVersionType type) 
    {
      return new FWDocVersions(ifc, docs, sord, type);
    }

    /// <summary>
    /// Create a FwDownloadManager object
    /// </summary>
    /// <param name="workDir">Working directory</param>
    /// <param name="lifetimeSeconds">Lifetime of non-modified files in the working directory.</param>
    /// <returns></returns>
    public virtual FWDownloadManager NewDownloadManager(string workDir, int lifetimeSeconds)
    {
      return new FWDownloadManager(ifc, workDir, lifetimeSeconds);
    }

      /// <summary>
      /// Creates an object of component, that offerst functionallity for management of checked out documents in
      /// checkout directory.
      /// </summary>
      /// <param name="checkoutDir">Path to the directory with checked out documents.</param>
      /// <returns>
      /// Reference to an object that implements interface IFWCheckedOutDocumentsManager.
      /// </returns>
      public virtual FWCheckedOutDocumentsManager NewCheckedOutDocumentsManager(string checkoutDir)
    {
        return new FWCheckedOutDocumentsManager(ifc, checkoutDir);
    }
  }
}
