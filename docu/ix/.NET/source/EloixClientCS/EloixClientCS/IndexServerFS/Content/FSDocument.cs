using System;
using de.elo.ix.client;
using EloixClient.IndexServerFW.Content;
using System.IO;

namespace EloixClient.IndexServerFS.Content
{
  /// <summary>
  /// Helper class to access an archive document
  /// </summary>
  public class FSDocument : FWDocument
  {
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="ifc">Content interface object</param>
    /// <param name="sord">Sord object</param>
    public FSDocument(FSContentInterface ifc, Sord sord)
      : base(ifc, sord)
    {
    }

    /// <summary>
    /// Checkin the modified file and Sord data into the archive. 
    /// </summary>
    public override void Checkin()
    {
      if (sordVal.deleted)
      {
        String winPath = File;
        if (winPath != null)
        {
          if (sordVal.lockId != Conn.Session.User.id)
          {
            // if not locked by me, checkout first
            Version.FileModified = true;
          }

          // delete file via ELOFS
          System.IO.File.Delete(File);
          FSFileHelper.CheckinFile(winPath, "", "", 0, 0, 0);
        }
        else
        {
          base.Checkin();
        }
      }
      else
      {
        if (Version.FileModified)
        {
            if (!isFileInArchiveFolder(File))
            {
                // Die zuzuweisende Datei darf nicht schreibgeschützt sein, sonst 
                // wird das ELOFS sie mglw. gleich einchecken, wenn sie unten kopiert wird.
                {
                    FileAttributes attrs = System.IO.File.GetAttributes(File);
                    if ((attrs & FileAttributes.ReadOnly) != 0)
                    {
                        System.IO.File.SetAttributes(File, attrs & ~FileAttributes.ReadOnly);
                    }
                }

                // Wenn neues Dokument, oder noch keine Version zugewiesen...
                if (Version.Id == 0)
                {
                    // Dateiendung in DocVersion setzen, damit unten GetFileSystemPath 
                    // eine Endung zuweisen kann.
                    string ext = Path.GetExtension(File);
                    Version.Core.ext = ext;

                    // Sicherstellen, dass DocVersion objekt auch im Sord eingetragen ist.
                    sordVal.docVersion = Version.Core;
                }

                // Ensure RefPaths are read
                string s = ArcPathString;
                string orgFilePath = ((FSContentInterface)ifc).GetFileSystemPath(Core, Version.Core);

                if (System.IO.File.Exists(orgFilePath))
                {
                    // sollte bereits ausgecheckt sein. wenn nicht, dann jetzt auschecken
                    FileAttributes attrs = System.IO.File.GetAttributes(orgFilePath);
                    if ((attrs & FileAttributes.ReadOnly) != 0)
                    {
                        FSFileHelper.CheckoutFile(orgFilePath);
                    }

                    // nochmal zur Sicherheit prüfen, dass die Datei ausgecheckt ist
                    attrs = System.IO.File.GetAttributes(orgFilePath);
                    if ((attrs & FileAttributes.ReadOnly) != 0)
                    {
                        throw new System.InvalidOperationException("File " + orgFilePath + " expected to be writable.");
                    }

                    // Originaldatei löschen (wird nicht im Archiv gelöscht)
                    System.IO.File.Delete(orgFilePath);
                }

                // Arbeitsdatei drüberkopieren
                System.IO.File.Copy(File, orgFilePath);

                File = orgFilePath;
            }

            Version.prepareCheckinDocBegin(Core);

            String verNo = mysubstring(Version.Version, Conn.CONST.DOC_VERSION.lnVersion);
            String verDesc = mysubstring(Version.Comment, Conn.CONST.DOC_VERSION.lnComment);

            FSFileHelper.CheckinFile(File, verNo, verDesc, Core.mask, 
            Version.Core.pathId, Version.Core.encryptionSet);

            if (sordVal.id == -1)
            {
                string arcPath = FSFileHelper.MakeArcPathFromFileName(File);
                Sord sordDB = ifc.Conn.Ix.checkoutSord("FSPATH:" + arcPath, EditInfoC.mbOnlyId, LockC.NO).sord; 
                sordVal.id = sordDB.id;
                sordVal.guid = sordDB.guid;
                sordVal.doc = sordDB.doc;

                FWSord fwsordDB = new FWSord(ifc, sordDB);
                OriginalFileName = fwsordDB.OriginalFileName;
            }

            Version.Modified = false;
        }

        Document doc = uploadAllModifiedVersions();

        SordZ sordZ = new SordZ(sordVal.changedMembers);
        doc = Conn.Ix.checkinDocEnd(sordVal, sordZ, doc, LockC.YES);

        sordVal.id = Convert.ToInt32(doc.objId);
      }
    }

    public override void Unlock()
    {
        string winPath = File;
        if (!isFileInArchiveFolder(winPath))
        {
            // Ensure RefPaths are read
            string s = ArcPathString;
            winPath = ((FSContentInterface)ifc).GetFileSystemPath(Core, Version.Core);
        }        
        FSFileHelper.RestoreFile(winPath);
        base.Unlock();
    }

    private static String mysubstring(String s, int max)
    {
      if (s.Length < max) return s;
      return s.Substring(0, max);
    }

    private bool isFileInArchiveFolder(String winPath)
    {
      FSConnection fsConn = (FSConnection)Conn;
      String winPathStart = fsConn.Config.Drive + "\\" + FSFileHelper.EscapeFileName(fsConn.ArcName);
      String winPath2 = winPath;
      if (winPath2.Length > winPathStart.Length) winPath2 = winPath2.Substring(0, winPathStart.Length);
      return String.Compare(winPathStart, winPath2, false) == 0;
    }      
  }
}
