using System;
using System.IO;
using de.elo.ix.client;
using EloixClient.IndexServerFW.Content;
using EloixClient.IndexServerFW.Utils;
using EloixClient.IndexServerFW;

namespace EloixClient.IndexServerFS.Content
{
  /// <summary>
  /// This class provides functions used to access the content
  /// of an ELO archive. The documents are displayed using paths to ELOFS.
  /// </summary>
  public class FSContentInterface : EloixClient.IndexServerFW.Content.FWContentInterface
  {
    /// <summary>
    /// Constructor
    /// </summary>
    public FSContentInterface()
    {
    }

    /// <summary>
    /// Initializes this object
    /// </summary>
    /// <param name="conn">Connection object</param>
    /// <param name="arcName">Archive name</param>
    /// <param name="connProps">Connection properties</param>
    public override void Init(FWConnection conn, string arcName, IXProperties connProps)
    {
      base.Init(conn, arcName, connProps);

      // read more members than the base class:
      // e.g. the archive path is required to build ELOFS paths
      base.sordZVal = new SordZ(SordC.mbLeanMembers | SordC.mbDocVersionMembers | SordC.mbRefPaths);
      base.editZVal = new EditInfoZ(EditInfoC.mbDocumentMembers | EditInfoC.mbSignatureMembers | EditInfoC.mbAttachmentMembers, sordZVal);
    }

    /// <summary>
    /// Makes a file system path in ELOFS for the given Sord object.
    /// </summary>
    /// <param name="sord">Sord object with valid sord.refPaths</param>
    /// <returns>File system path</returns>
    public String GetFileSystemPath(Sord sord, DocVersion dv)
    {
      FSConnection fsConn = (FSConnection)Conn;
      String winPath = fsConn.Config.Drive + "\\" + FSFileHelper.EscapeFileName(fsConn.ArcName);

      IdName[] arcPathObjs = sord.refPaths[0].path;
      for (int i = 0; i < arcPathObjs.Length; i++)
      {
        winPath += "\\" + FSFileHelper.EscapeFileName(arcPathObjs[i].name);
      }

      winPath += "\\" + FSFileHelper.EscapeFileName(sord.name);

      if (dv != null)
      {
        winPath += ".";
        winPath += dv.ext;
      }

      return winPath;
    }

    /// <summary>
    /// Try to read a document.
    /// </summary>
    /// <param name="objId">Object ID</param>
    /// <param name="accessMode">A combination of the FWAccessMode constants.</param>
    /// <returns>Null, if throwEx=false and the document does not exist. 
    /// Otherwise a FWDocument object is returned.</returns>
    public override FWDocument TryGetDocument(String objId, FWAccessModes accessMode)
    {
      FWDocument xdoc = null;

      if (FWLockMode.HasLock(accessMode))
      {
        try
        {
          // The document must be checked out via ELOFS. 
          // Thus we have to find out the file system path of the document first.

          // call checkoutDoc to read the archive path
          Sord sord = Conn.Ix.checkoutDoc(objId, null,
            new EditInfoZ(0L, new SordZ(SordC.mbId | SordC.mbType | SordC.mbLockId | SordC.mbRefPaths | SordC.mbDocVersionMembers)),
            LockC.NO).sord;

          if (sord.id == 1 || sord.type < SordC.LBT_DOCUMENT)
          {
            throw new InvalidOperationException("Object " + objId + " is not a document.");
          }

          // checkout: set file attribute archive, reset file attribute read-only
          String winPath = GetFileSystemPath(sord, sord.docVersion);
          FileAttributes attrs = File.GetAttributes(winPath);
          attrs |= FileAttributes.Archive;
          attrs &= ~FileAttributes.ReadOnly;
          File.SetAttributes(winPath, attrs);

          // get all required values
          xdoc = base.TryGetDocument(objId, FWAccessModes.Nothing);
        }
        catch (Exception e)
        {
          if ((accessMode & FWAccessModes.MustExist) != 0) throw e;
          if (e.Message.IndexOf("[ELOIX:" + IXExceptionC.NOT_FOUND) < 0) throw e;
        }

      }
      else
      {
        xdoc = base.TryGetDocument(objId, accessMode);
      }

      return xdoc;
    }

    public override FWContentClassFactory ClassFactory
    {
      get
      {
        return new FSContentClassFactory(this);
      }
    }

    public override FWDocument ApplyDocumentTemplate(FWDocument doc, FWDocument templ)
    {
        throw new NotImplementedException();
    }

  }
}
