using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

using de.elo.ix.client;
using EloixClient.IndexServerFW.Content;

namespace EloixClient.IndexServerFS.Content
{
  /// <summary>
  /// Download Manager for ELOFS connections.
  /// </summary>
  public class FSDownloadManager : FWDownloadManager
  {

    FSCheckoutFolder checkoutFolder;

   

    #region Initialization
    /// <summary>
    /// Construct Download manager for ELOFS connections.
    /// </summary>
    /// <param name="ifc">Content interface </param>
    /// <param name="workDir">Working directory</param>
    /// <param name="lifetimeSeconds">Lifetime of non-modified files</param>
    public FSDownloadManager(FSContentInterface ifc, String workDir, int lifetimeSeconds)
      : base(ifc, workDir, lifetimeSeconds, false)
    {
      checkoutFolder = new FSCheckoutFolder(ifc);
    }
    #endregion

   

    /// <summary>
    /// Returns true, if the given file is controlled by the download manager.
    /// </summary>
    /// <param name="filePath">File name to be checked.</param>
    /// <remarks>A file is controlled by the download manager, if it resides in the download managers working directory.</remarks>
    /// <returns>see summary</returns>
    public override bool IsControlledFile(string filePath)
    {
        if (null == filePath || filePath.Length == 0) return false;

        bool succ = InternalIsControlledFile(filePath);
        if (!succ)
        {
        succ = base.IsControlledFile(filePath);
        }
        return succ;
    }

    private bool InternalIsControlledFile(string filePath)
    {
        FSConnection conn = (FSConnection)ifc.Conn;
        string driveAndArc = conn.Config.Drive + "\\" + conn.ArcName;
        bool succ = filePath.StartsWith(driveAndArc, StringComparison.OrdinalIgnoreCase);
        return succ;
    }

    public override bool GetIdFromFileName(string fileName, out string objId, out string docId)
    {
      throw new System.NotImplementedException("GetIdFromFileName");
    }

    public override string TempDir
    {
      get 
      {
          return base.TempDir;
      }
    }

    /// <summary>
    /// Return a FWDocument for the given file.
    /// </summary>
    /// <param name="file">Controlled file</param>
    /// <returns>FWDocument object</returns>
    public override FWDocument GetFWDocumentFromFile(string file)
    {
      FWDocument doc = null;
      try
      {
          if (IsControlledFile(file))
          {

              FSConnection conn = (FSConnection)ifc.Conn;
              string driveAndArc = conn.Config.Drive + "\\" + conn.ArcName;
              if (file.Length >= driveAndArc.Length)
              {
                  string arcPath = file.Substring(driveAndArc.Length);
                  string objId = "FSPATH:" + arcPath;
                  try
                  {
                      doc = ifc.Conn.Content.GetDocument(objId);
                  }
                  catch (Exception e)
                  {
                      if (ifc.Conn.Ix.parseException(e.Message).exceptionType != IXExceptionC.NOT_FOUND) throw e;
                      String dir = System.IO.Path.GetDirectoryName(file);
                      if (dir.Length >= driveAndArc.Length)
                      {
                          string arcDir = dir.Substring(driveAndArc.Length);
                          doc = ifc.Conn.Content.CreateDocument("FSPATH:" + arcDir, "");
                      }
                  }
              }
          }
      }
      catch { }

      return doc;
    }

    public override string makeWritableFile(string filePath)
    {
        // Wenn's eine x:\archiv\... ist...
        if (InternalIsControlledFile(filePath))
        {
            // Ist Datei read-only? Dann kann ich sie nicht einfach beschreibbar setzen. Dies würde ein Auschecken im ELOFS auslösen.
            FileAttributes attrs = File.GetAttributes(filePath);
            if ((attrs & FileAttributes.ReadOnly) != 0)
            {
                // Erstelle eine Kopie im temp. Verzeichnis
                string filePath2 = Path.Combine(workDir, Path.GetFileNameWithoutExtension(filePath) + "-2" + Path.GetExtension(filePath));

                // Wenn's die Kopie schon gibt...
                if (File.Exists(filePath2))
                {
                    // Ist die Kopie read-only, dann hat der DownloadManager sie noch nicht gelöscht.
                    FileAttributes attrs2 = File.GetAttributes(filePath2);
                    if ((attrs2 & FileAttributes.ReadOnly) != 0)
                    {
                        // Lösch sie jetzt
                        File.SetAttributes(filePath2, attrs2 & ~FileAttributes.ReadOnly);

                        // Erstelle Kopie der Archivdatei
                        File.Delete(filePath2);
                        File.Copy(filePath, filePath2);
                    }
                }
                else
                {
                    // Kopiere Archivdatei
                    File.Copy(filePath, filePath2);
                }

                filePath = filePath2;

                File.SetAttributes(filePath, attrs & ~FileAttributes.ReadOnly);
            }
        }
        else
        {
            filePath = base.makeWritableFile(filePath);
        }
        return filePath;
    }

    public override void InvalidateFile(string filePath)
    {
      base.InvalidateFile(filePath);
    }

    public override String makeTempFilePath(String name, String ext, string id, string documentId)
    {
        // todo: x:\\ + archiv + dir + name + ext
        throw new NotImplementedException();
    }

    public override string makeTempFilePath(FWDocument document)
    {
        throw new NotImplementedException();
    }

    public override string AttachNewDocumentWorkFile(string sourceFile, string destArcPath, string destName, string objId, string documentId)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Prooves if work directory of downloadmanager contains file, whose name consists of values passed by
    /// the three parameters. If file exists a whole path will be returned back.
    /// </summary>
    /// <param name="name">Name of document.</param>
    /// <param name="id">Id of entry.</param>
    /// <param name="documentId">Id of document.</param>
    /// <returns>
    /// Whole path to file, whose name consists of values passed by the parameters or null if no file was found.
    /// </returns>
    public override string GetExistingFileForDocument(string name, string id, string documentId)
    {
        throw new NotImplementedException();
    }
  }
}
