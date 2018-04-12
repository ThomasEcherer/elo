using System;
using System.Collections.Generic;
using System.IO;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW.Utils;
using EloixClient.Common;

namespace EloixClient.IndexServerFW.Content
{
  /// <summary>
  /// This class provides functions used to access the content
  /// of an ELO archive. 
  /// </summary>
  public class FWContentInterface : ICleanupEvent
  {
      /// <summary>
      /// The class factory creates all objects of the classes in this package.
      /// </summary>
      protected FWContentClassFactory classFactoryVal;

    /// <summary>
    /// IndexServer connection
    /// </summary>
    protected FWConnection connVal;
    /// <summary>
    /// Default subdirectory name under the temporary directory.
    /// </summary>
    private static String TEMP_SUBDIR = "EloixClientCS";
    /// <summary>
    /// Temporary directory used by the document cache.
    /// </summary>
    protected String tempDirVal;

    /// <summary>
    /// Contains path to root directory.
    /// </summary>
    protected string rootDirVal;

    /// <summary>
    /// Temporary directory used for checked out documents.
    /// </summary>
    protected string checkoutDirVal;

    /// <summary>
    /// Download manager.
    /// </summary>
    protected FWDownloadManager downloadManagerVal;

    /// <summary>
    /// Checkedout documents manager.
    /// </summary>
    protected FWCheckedOutDocumentsManager checkedOutDocumentsManagerVal;

    /// <summary>
    /// Element selector for reading or searching Sord objects with 
    /// checkoutSord, findFirstSords etc.
    /// </summary>
    protected SordZ sordZVal;
    /// <summary>
    /// Element selector for checkoutSord or checkoutDoc.
    /// </summary>
    protected EditInfoZ editZVal;

    /// <summary>
    /// Constructor
    /// </summary>
    public FWContentInterface()
    {
    }

    /// <summary>
    /// Gets current class factory.
    /// </summary>
    public virtual FWContentClassFactory ClassFactory
    {
      get { return classFactoryVal; }
    }

    /// <summary>
    /// Gets the IndexServer connection.
    /// </summary>
    public FWConnection Conn
    {
      get { return connVal; }
    }
    /// <summary>
    /// This directory is used to cache document files.
    /// </summary>
    public virtual String TempDir
    {
      get { return tempDirVal; }
      set { tempDirVal = value; }
    }
    /// <summary>
    /// Returns root directory of all other sub directories that contain archive data like temporary or checked out files.
    /// </summary>
    public virtual string RootDir
    {
        get { return rootDirVal; }
    }
    /// <summary>
    /// Download manager.
    /// </summary>
    public IFWDownloadManager DownloadManager
    {
      get { return downloadManagerVal; }
    }

    /// <summary>
    /// Checkedout documents manager.
    /// </summary>
      public IFWCheckedOutDocumentsManager CheckedOutDocumentsManager
    {
        get { return checkedOutDocumentsManagerVal; }
    }

    /// <summary>
    /// Get the archive folder.
    /// </summary>
    /// <returns></returns>
    public virtual FWFolder RootFolder
    {
      get { return GetFolder("1"); }
    }

    /// <summary>
    /// Try to read a Sord object.
    /// </summary>
    /// <param name="objId">Object ID</param>
    /// <param name="accessMode">A combination of the FWAccessMode constants.</param>
    /// <returns>Sord object or null, if the object does not exist and accessMode does not include MustExist.</returns>
    /// <exception>IOException: object already locked, access denied, etc.</exception>
    public virtual FWSord TryGetSord(String objId, FWAccessModes accessMode)
    {
        return TryGetSord(objId, accessMode, DocAction.EditOnlyIndexData);
    }

    /// <summary>
    /// Try to read a Sord object.
    /// </summary>
    /// <param name="objId">Object ID</param>
    /// <param name="accessMode">A combination of the FWAccessMode constants.</param>
    /// <param name="docAction">DocAction. 
    /// If the Sord object is a <c>FWDocument</c> and the parameter is set to <c>DocAction.EditDocument</c> and FWAccessMode.Lock is set, the document will copied to the checkout-directory.
    /// Th eparameter will be ignored, if the Sord object is a <c>FWFolder</c>.
    /// </param>
    /// <returns>Sord object or null, if the object does not exist and accessMode does not include MustExist.</returns>
    /// <exception>IOException: object already locked, access denied, etc.</exception>
      public virtual FWSord TryGetSord(string objId, FWAccessModes accessMode, DocAction docAction)
    {
        FWSord xsord = null;

        bool exceptionOccured = false;
        FWSord tmpSord = null;

        try
        {
            //GetSord(objId);
            LockZ lockZ = FWLockMode.MakeLockZ(FWAccessModes.MustExist);
            Sord sord = Conn.Ix.checkoutDoc(objId, null, EditZ, lockZ).sord;
            sord.changedMembers = EditZ.bset;
            if (sord.id == 1 || sord.type < SordC.LBT_DOCUMENT)
            {
                tmpSord = ClassFactory.NewFolder(sord);
            }
            else
            {
                tmpSord = ClassFactory.NewDocument(sord);
            }
        }
        catch (Exception e) 
        {
            exceptionOccured = true;
            if ((accessMode & FWAccessModes.MustExist) != 0) throw e;
            if (e.Message.IndexOf("[ELOIX:" + IXExceptionC.NOT_FOUND) < 0) throw e;
        }

        if (tmpSord != null && tmpSord.IsDocument() && docAction == DocAction.EditDocument)
        {
            CheckoutResult result = checkedOutDocumentsManagerVal.Checkout(tmpSord as FWDocument);
            if (result.Success)
            {
                xsord = result.FWDocument;
            }
        }
        else if (!exceptionOccured)
        {
            try
            {
                LockZ lockZ = FWLockMode.MakeLockZ(accessMode);

                Sord sord = Conn.Ix.checkoutDoc(objId, null, EditZ, lockZ).sord;
                sord.changedMembers = EditZ.bset;
                if (sord.id == 1 || sord.type < SordC.LBT_DOCUMENT)
                {
                    xsord = ClassFactory.NewFolder(sord);
                }
                else
                {
                    xsord = ClassFactory.NewDocument(sord);
                }
            }
            catch (Exception e)
            {
                if ((accessMode & FWAccessModes.MustExist) != 0) throw e;
                if (e.Message.IndexOf("[ELOIX:" + IXExceptionC.NOT_FOUND) < 0) throw e;
            }
        }
        return xsord;
    }

    /// <summary>
    /// Try to read a folder object. 
    /// </summary>
    /// <remarks>This function calls internally <see cref="TryGetSord"/>. 
    /// An Exception is thrown, if the returned object is not a folder object.</remarks>
    /// <param name="objId"><see cref="TryGetSord"/></param>
    /// <param name="accessMode"><see cref="TryGetSord"/></param>
    /// <returns><see cref="TryGetSord"/></returns>
    /// <exception>IOException: <see cref="TryGetSord"/></exception>
    /// <exception>InvalidOperationException: object is not a folder.</exception>
    public virtual FWFolder TryGetFolder(String objId, FWAccessModes accessMode)
    {
        FWSord xsord = TryGetSord(objId, accessMode);
        if (xsord != null)
        {
            if (!(xsord is FWFolder))
            {
                throw new InvalidOperationException("Object " + objId + " is not a folder.");
            }
        }
        return (FWFolder)xsord;
    }

    /// <summary>
    /// Try to read a document object. 
    /// </summary>
    /// <remarks>This function calls internally <see cref="TryGetSord"/>. 
    /// An Exception is thrown, if the returned object is not a document object.</remarks>
    /// <param name="objId"><see cref="TryGetSord"/></param>
    /// <param name="accessMode"><see cref="TryGetSord"/></param>
    /// <returns><see cref="TryGetSord"/></returns>
    /// <exception>IOException: <see cref="TryGetSord"/></exception>
    /// <exception>InvalidOperationException: object is not a document.</exception>
    public virtual FWDocument TryGetDocument(String objId, FWAccessModes accessMode)
    {
        return TryGetDocument(objId, accessMode, DocAction.EditOnlyIndexData);
    }

    /// <summary>
    /// Try to read a document object. 
    /// </summary>
    /// <remarks>This function calls internally <see cref="TryGetSord"/>. 
    /// An Exception is thrown, if the returned object is not a document object.</remarks>
    /// <param name="objId"><see cref="TryGetSord"/></param>
    /// <param name="accessMode"><see cref="TryGetSord"/></param>
    /// <param name="docAction">DocAction. If set to <c>DocAction.EditDocument</c> and AccessModes.Lock, the document will copied to the checkout-directory.</param>
    /// <returns><see cref="TryGetSord"/></returns>
    /// <exception>IOException: <see cref="TryGetSord"/></exception>
    /// <exception>InvalidOperationException: object is not a document.</exception>
      public virtual FWDocument TryGetDocument(string objId, FWAccessModes accessMode, DocAction docAction)
    {
        FWSord xsord = TryGetSord(objId, accessMode);
        if (xsord != null)
        {
            if (!(xsord is FWDocument))
            {
                throw new InvalidOperationException("Object " + objId + " is not a document.");
            }
        }
        return (FWDocument)xsord;
    }

    /// <summary>
    /// Gets the Sord object with the given numeric object ID. 
    /// The Sord must exist.
    /// </summary>
    /// <param name="objId">Object-ID</param>
    /// <returns>Sord object</returns>
    public virtual FWSord GetSord(int objId)
    {
      return GetSord(Convert.ToString(objId));
    }

    /// <summary>
    /// Gets the Sord object with the given ID, GUID, ARCPATH etc. 
    /// The Sord must exist.
    /// </summary>
    /// <param name="objId">Object-ID</param>
    /// <returns>Sord object</returns>
    public virtual FWSord GetSord(String objId)
    {
      return TryGetSord(objId, FWAccessModes.MustExist);
    }

    /// <summary>
    /// Locks the Sord object with the given numeric object ID.
    /// The Sord must exist.
    /// </summary>
    /// <param name="objId">Object-ID</param>
    /// <returns>Sord object</returns>
    public virtual FWSord LockSord(int objId)
    {
      return LockSord(objId, DocAction.EditOnlyIndexData);
    }

    /// <summary>
    /// Locks the Sord object with the given numeric object ID.
    /// The document must exist.
    /// </summary>
    /// <param name="objId">Object-ID</param>
    /// <param name="docAction">DocAction. 
    /// If the Sord object is a <c>FWDocument</c> and the parameter is set to <c>DocAction.EditDocument</c> the document will copied to the checkout-directory.
    /// Th eparameter will be ignored, if the Sord object is a <c>FWFolder</c>.
    /// </param>
    /// <returns>Document object</returns>
      public virtual FWSord LockSord(int objId, DocAction docAction)
    {
        return LockSord(Convert.ToString(objId), docAction);
    }

    /// <summary>
    /// Locks Sord Sord object with the given object ID, GUID, ARCPATH etc.
    /// The document must exist.
    /// </summary>
    /// <param name="objId">Object-ID</param>
    /// <returns>Sord object</returns>
    public virtual FWSord LockSord(String objId)
    {
        return LockSord(objId, DocAction.EditOnlyIndexData);
    }

    /// <summary>
    /// Locks the Sord object with the given object ID, GUID, ARCPATH etc.
    /// The document must exist.
    /// </summary>
    /// <param name="objId">Object-ID</param>
    /// <param name="docAction">DocAction. 
    /// If the Sord object is a <c>FWDocument</c> and the parameter is set to <c>DocAction.EditDocument</c> the document will copied to the checkout-directory.
    /// Th eparameter will be ignored, if the Sord object is a <c>FWFolder</c>.
    /// </param>
    /// <returns>Document object</returns>
      public virtual FWSord LockSord(string objId, DocAction docAction)
    {
        return TryGetSord(objId, FWAccessModes.MustExist | FWAccessModes.Lock);
    }

    /// <summary>
    /// Gets the folder object with the given numeric object ID. 
    /// The folder must exist.
    /// </summary>
    /// <param name="objId">Object-ID</param>
    /// <returns>Folder object</returns>
    public virtual FWFolder GetFolder(int objId)
    {
      return GetFolder(Convert.ToString(objId));
    }

    /// <summary>
    /// Gets the folder object with the given ID, GUID, ARCPATH etc. 
    /// The folder must exist.
    /// </summary>
    /// <param name="objId">Object-ID</param>
    /// <returns>Folder object</returns>
    public virtual FWFolder GetFolder(String objId)
    {
      return TryGetFolder(objId, FWAccessModes.MustExist);
    }

    /// <summary>
    /// Locks the folder object with the given numeric object ID.
    /// The folder must exist.
    /// </summary>
    /// <param name="objId">Object-ID</param>
    /// <returns>Folder object</returns>
    public virtual FWFolder LockFolder(int objId)
    {
      return LockFolder(Convert.ToString(objId));
    }

    /// <summary>
    /// Locks the folder object with the given object ID, GUID, ARCPATH etc.
    /// The document must exist.
    /// </summary>
    /// <param name="objId">Object-ID</param>
    /// <returns>Folder object</returns>
    public virtual FWFolder LockFolder(String objId)
    {
        return TryGetFolder(objId, FWAccessModes.MustExist | FWAccessModes.Lock);
    }

    /// <summary>
    /// Gets the document object with the given numeric object ID.
    /// The document must exist.
    /// </summary>
    /// <param name="objId">Object-ID</param>
    /// <returns>Document object</returns>
    public virtual FWDocument GetDocument(int objId)
    {
      return GetDocument(Convert.ToString(objId));
    }

    /// <summary>
    /// Gets the document object with the given ID, GUID, ARCPATH etc. 
    /// The folder must exist.
    /// </summary>
    /// <param name="objId">Object-ID</param>
    /// <returns>Document object</returns>
    public virtual FWDocument GetDocument(String objId)
    {
      return TryGetDocument(objId, FWAccessModes.MustExist);
    }

    /// <summary>
    /// Locks the document object with the given numeric object ID.
    /// The document must exist.
    /// </summary>
    /// <param name="objId">Object-ID</param>
    /// <returns>Document object</returns>
    public virtual FWDocument LockDocument(int objId)
    {
      return LockDocument(objId, DocAction.EditOnlyIndexData);
    }

    /// <summary>
    /// Locks the document object with the given numeric object ID.
    /// The document must exist.
    /// </summary>
    /// <param name="objId">Object-ID</param>
    /// <param name="docAction">DocAction. If set to <c>DocAction.EditDocument</c> the document will copied to the checkout-directory.</param>
    /// <returns>Document object</returns>
      public virtual FWDocument LockDocument(int objId, DocAction docAction)
    {
        return LockDocument(Convert.ToString(objId), docAction);
    }

    /// <summary>
    /// Locks the document object with the given ID, GUID, ARCPATH etc. 
    /// The folder must exist.
    /// </summary>
    /// <param name="objId">Object-ID</param>
    /// <returns>Document object</returns>
    public virtual FWDocument LockDocument(String objId)
    {
        return LockDocument(objId, DocAction.EditOnlyIndexData);
    }

    /// <summary>
    /// Locks the document object with the given ID, GUID, ARCPATH etc.
    /// The document must exist.
    /// </summary>
    /// <param name="objId">Object-ID</param>
    /// <param name="docAction">DocAction. If set to <c>DocAction.EditDocument</c> the document will copied to the checkout-directory.</param>
    /// <returns>Document object</returns>
      public virtual FWDocument LockDocument(string objId, DocAction docAction)
    {
        return TryGetDocument(objId, FWAccessModes.MustExist | FWAccessModes.Lock);
    }

    /// <summary>
    /// Checks wether the object with the given numeric ID exists in the archive.
    /// </summary>
    /// <param name="objId">Object-ID</param>
    /// <returns>True, if the object exists.</returns>
    public virtual bool Exists(int objId)
    {
      return Exists(Convert.ToString(objId));
    }

    /// <summary>
    /// Checks wether the object with the given given ID, GUID, ARCPATH etc. in the archive.
    /// </summary>
    /// <param name="objId">Object-ID</param>
    /// <returns>True, if the object exists.</returns>
    public virtual bool Exists(String objId)
    {
      try
      {
        Conn.Ix.checkoutSord(objId, EditInfoC.mbOnlyId, LockC.NO);
        return true;
      }
      catch (Exception e)
      {
        if (e.Message.IndexOf("[ELOIX:" + IXExceptionC.NOT_FOUND) < 0) throw e;
      }
      return false;
    }

    /// <summary>
    /// Creates an archive path, if it does not exist.
    /// </summary>
    /// <param name="arcPath">Archive path to be created. First character is used as path delimiter.</param>
    /// <returns>Folder object of the last path segment.</returns>
    public virtual FWFolder MakeArcPath(String arcPath)
    {
      String delim = arcPath.Substring(0, 1);
      List<Sord> sords = new List<Sord>();
      String[] toks = arcPath.Substring(1).Split(delim[0]);
      for (int i = 0; i < toks.Length; i++)
      {
        Sord sord = new Sord();
        sord.name = toks[i];
        sords.Add(sord);
      }
      if (sords.Count == 0) return RootFolder;
      int[] ids = Conn.Ix.checkinSordPath("1", sords.ToArray(), new SordZ(SordC.mbName));
      FWFolder f = GetFolder(Convert.ToString(ids[ids.Length - 1]));
      return f;
    }

    /// <summary>
    /// Creates a folder object initialized by the values of the given parent and keywording form.
    /// The object is created in memory and not created in the archive.
    /// </summary>
    /// <param name="parentId">Numeric parent object ID</param>
    /// <param name="maskId">Numeric keywording form ID (DocMask)</param>
    /// <returns>Folder object</returns>
    public virtual FWFolder CreateFolder(int parentId, int maskId)
    {
      return CreateFolder( Convert.ToString(parentId), Convert.ToString(maskId) );
    }

    /// <summary>
    /// Creates a folder object initialized by the values of the given parent and keywording form.
    /// The object is created in memory and not created in the archive.
    /// </summary>
    /// <param name="parentId">Parent ID, GUID, ARCPATH etc.</param>
    /// <param name="maskId">Keywording form ID, GUID, name</param>
    /// <returns>Folder object</returns>
    public virtual FWFolder CreateFolder(String parentId, String maskId)
    {
      Sord sord = Conn.Ix.createSord(parentId, maskId, EditInfoC.mbSordLean).sord;
      return ClassFactory.NewFolder(sord);
    }

    /// <summary>
    /// Creates a document object initialized by the values of the given parent and keywording form.
    /// The object is created in memory and not created in the archive.
    /// </summary>
    /// <param name="parentId">Numeric parent object ID</param>
    /// <param name="maskId">Numeric keywording form ID (DocMask)</param>
    /// <returns>Document object</returns>
    public virtual FWDocument CreateDocument(int parentId, int maskId)
    {
      return CreateDocument(Convert.ToString(parentId), Convert.ToString(maskId));
    }

    /// <summary>
    /// Creates a document object initialized by the values of the given parent and keywording form.
    /// The object is created in memory and not created in the archive.
    /// </summary>
    /// <param name="parentId">Parent ID, GUID, ARCPATH etc.</param>
    /// <param name="maskId">Keywording form ID, GUID, name</param>
    /// <returns>Document object</returns>
    public virtual FWDocument CreateDocument(String parentId, String maskId)
    {
      Sord sord = Conn.Ix.createDoc(parentId, maskId, null, EditInfoC.mbSordLean).sord;
      return ClassFactory.NewDocument(sord);
    }

    /// <summary>
    /// This function locks the document <code>doc</code> and assigns the document file from <code>templ</code>.
    /// </summary>
    /// <param name="doc">Document</param>
    /// <param name="templ">Template document</param>
    /// <returns></returns>
    public virtual FWDocument ApplyDocumentTemplate(FWDocument doc, FWDocument templ)
    {
        // Dokumenteintrag im Archiv sperren
        if (doc.LockId == -1)
        {
            doc = LockDocument(doc.Id);
        }

        // Vorlagedatei
        String templFile = templ.File;

        // Vorlagedatei ins Arbeitsverzeichnis kopieren
        // und über den Dateienamen an das Dokument binden.
        string destFile = DownloadManager.AttachNewDocumentWorkFile(templFile, "", doc.Name, doc.Id.ToString(), doc.Version.Id.ToString());

        doc.Version.File = destFile;

        return doc;
    }

    /// <summary>
    /// Search for archive content.
    /// </summary>
    /// <param name="findInfo">FindInfo object that describes the search.</param>
    /// <returns>Result cache object.</returns>
    public virtual FWFindSordsCache<FWSord> FindSords(FindInfo findInfo)
    {
        return FindSords(findInfo, SordZ);
    }

    /// <summary>
    /// Search for archive content.
    /// </summary>
    /// <param name="findInfo">FindInfo object that describes the search.</param>
    /// <param name="sordZ">Members to be returned.</param>
    /// <returns>Result cache object.</returns>
    public virtual FWFindSordsCache<FWSord> FindSords(FindInfo findInfo, SordZ sordZ)
    {
        return new FWFindSordsCache<FWSord>(this, findInfo, sordZ);
    }

    /// <summary>
    /// Gets the default element selector for checkoutDoc, checkoutSord.
    /// </summary>
    public virtual EditInfoZ EditZ
    {
      get { return editZVal; }
      set { editZVal = new EditInfoZ(value); }
    }

    /// <summary>
    /// Gets the default element selector for checkoutDoc, findFirstSords etc.
    /// </summary>
    public virtual SordZ SordZ
    {
      get { return sordZVal; }
      set { sordZVal = new SordZ(value); }
    }

    private String makeTempDir(String tmpDir, String arcName)
    {
        // add the subdirectory TEMP_SUBDIR
        String dir = Path.Combine(tmpDir, TEMP_SUBDIR);
        rootDirVal    = dir;

        // add the archive name
        dir = Path.Combine(dir, arcName);

        // Create directory, if it does not exist
        if (File.Exists(dir))
        {
            if ((File.GetAttributes(dir) & FileAttributes.Directory) == 0)
            {
                throw new InvalidOperationException("Temp dir=" + dir + " is not a directory.");
            }
        }
        else
        {
            Directory.CreateDirectory(dir);
        }

        return dir;
    }

    /// <summary>
    /// Initialize
    /// </summary>
    /// <param name="conn">Connection object</param>
    /// <param name="arcName">Archive name</param>
    /// <param name="connProps">Connection properties</param>
    /// <returns></returns>
    public virtual void Init(FWConnection conn, string arcName, IXProperties connProps)
    {
      this.connVal = conn;
      this.classFactoryVal = new FWContentClassFactory(this);
      this.sordZVal = new SordZ(SordC.mbLeanMembers | SordC.mbDocVersionMembers);
      this.editZVal = new EditInfoZ(EditInfoC.mbDocumentMembers | EditInfoC.mbSignatureMembers | EditInfoC.mbAttachmentMembers, sordZVal);

      // try to get the temporary directory from the connection properties
      String tmpDir = (connProps != null) ? connProps[FWConnFactory.PROP_TEMP_DIR] : null;
      if (tmpDir != null && tmpDir.Length != 0)
      {
         tempDirVal = makeTempDir(tmpDir, Path.Combine(arcName, "Temp"));
         checkoutDirVal = makeTempDir(tmpDir, Path.Combine(arcName, "Checkout"));
      }
      else
      {
          try
          {
              // not found: use the users APPDATA directory
              tempDirVal = makeTempDir(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ELO Digital Office"), Path.Combine(arcName, "Temp"));
              checkoutDirVal = makeTempDir(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ELO Digital Office"), Path.Combine(arcName, "Checkout"));
          }
          catch (Exception)
          {
              try
              {
                  tempDirVal = makeTempDir(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ELO Digital Office"), Path.Combine(arcName, "Temp"));
                  checkoutDirVal = makeTempDir(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ELO Digital Office"), Path.Combine(arcName, "Checkout"));
              }
              catch (Exception)
              {
                  // Konto "Local System" unter Windows 2003 kann nicht auf APPDATA zugreifen.

                  tempDirVal = makeTempDir(Path.Combine(Path.GetTempPath(), "ELO Digital Office"), Path.Combine(arcName, "Temp"));
                  checkoutDirVal = makeTempDir(Path.Combine(Path.GetTempPath(), "ELO Digital Office"), Path.Combine(arcName, "Checkout"));
              }
          }
      }


      // Initialize the FWDownloadManager object
      downloadManagerVal = ClassFactory.NewDownloadManager(
        tempDirVal,
        connProps.Get(FWConnFactory.PROP_CACHE_DOCUMENT_LIFETIME_SECONDS,
        FWConnFactory.PROP_CACHE_DOCUMENT_LIFETIME_DEFAULT));

      checkedOutDocumentsManagerVal = ClassFactory.NewCheckedOutDocumentsManager(checkoutDirVal);

    }

    /// <summary>
    /// Upload file to given URL.
    /// </summary>
    /// <param name="url">Destination URL.</param>
    /// <param name="file">Source file.</param>
    /// <returns></returns>
    public virtual String Upload(String url, String file)
    {
      return Conn.internalConnection.Upload(url, file);
    }

    /// <summary>
    /// Download file from given URL.
    /// </summary>
    /// <param name="url">Source URL.</param>
    /// <param name="file">Destination file.</param>
    public virtual void Download(String url, String file)
    {
      Conn.internalConnection.Download(url, file);
    }

    /// <summary>
    /// Cleanup the download managers cache directory.
    /// </summary>
    public void OnCleanup()
    {
      downloadManagerVal.Cleanup();
      checkedOutDocumentsManagerVal.Cleanup();
    }
  }
}
