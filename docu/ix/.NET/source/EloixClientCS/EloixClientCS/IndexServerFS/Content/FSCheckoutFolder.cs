using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using de.elo.ix.client;

namespace EloixClient.IndexServerFS.Content
{
  public class FSCheckoutFolder
  {
    private DirectoryInfo checkoutDir;
    private FSConnection conn;
    private List<string> checkoutFiles = new List<string>();
    private List<string> deletedFiles = new List<string>();
    private FSContentInterface ifc;

    public FSCheckoutFolder(FSContentInterface ifc)
    {
      this.ifc = ifc;
      conn = (FSConnection)ifc.Conn;
      checkoutDir = new DirectoryInfo(conn.Config.Drive + "\\-i-" + conn.ArcName + "\\Chk");
    }

    public List<string> DeletedFiles
    {
      get 
      {
        return deletedFiles; 
      }
    }

    public List<string> CheckoutFiles
    {
      get
      {
        return checkoutFiles;
      }
    }

    /// <summary>
    /// Gets path to the directory of checked out documents.
    /// </summary>
    internal string CheckOutDirPath
    {
        get
        {
            string path = string.Empty;
            if (checkoutDir != null)
                path = checkoutDir.FullName;
            return path;
        }
    }

    public void Refresh()
    {
      checkoutFiles.Clear();
      deletedFiles.Clear();
      findFiles(checkoutFiles, deletedFiles);
      makeArcFileNames(checkoutFiles);
      makeArcFileNames(deletedFiles);
    }

    private string makeArcFileName(string checkoutFileName)
    {
      /*
        string[] pathArray = checkoutFileName.Split('\\');
        
        StringBuilder newPath = new StringBuilder();
        newPath.Append(conn.Config.Drive).Append("\\").Append(conn.ArcName);

        int idx = 3; // skip drive\Archive\Chk
        for (; idx < pathArray.Length; idx++) 
        {
            newPath.Append('\\');
            newPath.Append(pathArray[idx]);
        }

        return newPath.ToString();
       * */

      return FSFileHelper.MakeWinFileName(checkoutFileName);
    }

    private void makeArcFileNames(List<string> checkoutFileNames)
    {
      for (int i = 0; i < checkoutFileNames.Count; i++)
      {
        checkoutFileNames[i] = makeArcFileName(checkoutFileNames[i]);
      }
    }

    private void findFiles(List<string> checkoutFiles, List<string> deletedFiles)
    {
      // Sammle alle Dateien im Checkout-Verzeichnis
      findFilesInDir(checkoutDir, checkoutFiles);

      // Hole aus checkoutobjs.properties die aktuell ausgecheckten Dokumente und
      // lese sie in map ein.
      IXProperties checkoutMap = new IXProperties();
      checkoutMap.Read(Path.Combine(checkoutDir.FullName, "checkoutobjs.properties"));

      // Gelöschte Dateien sind diejenigen, die in der checkoutMap aber nicht in checkoutFiles enthalten sind.
      findDeletedFiles(checkoutMap, checkoutFiles, deletedFiles);
    }

    private void findDeletedFiles(IXProperties checkoutMap, List<string> checkoutFiles, List<string> deletedFiles)
    {
      Dictionary<string, string> mapCheckoutFiles = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
      foreach (string f in checkoutFiles)
      {
        mapCheckoutFiles.Add(f, f);
      }

      foreach (string key in checkoutMap.Keys)
      {
        if (key.StartsWith("LM_") || key.StartsWith("MD5_")) continue;
        try { Convert.ToInt32(key); } catch (Exception) { continue; }
        string f = checkoutMap[key];
        if (f.StartsWith("\\")) f = f.Substring(1);
        f = Path.Combine(checkoutDir.FullName, f);
        if (!mapCheckoutFiles.ContainsKey(f))
        {
          deletedFiles.Add(f);
        }
      }
    }

    private void findFilesInDir(DirectoryInfo dir, List<string> files)
    {
      DirectoryInfo[] subdirs = dir.GetDirectories();
      FileInfo[] subfiles = dir.GetFiles();

      foreach (DirectoryInfo subdir in subdirs)
      {
        if (subdir.Name != "." && subdir.Name != "..")
        {
          findFilesInDir(subdir, files);
        }
      }

      foreach (FileInfo subfile in subfiles)
      {
        FileAttributes attrs = subfile.Attributes;
        if ((attrs & FileAttributes.Archive) != 0 && (attrs & FileAttributes.Hidden) == 0)
        {
          if (!conn.Config.IsTempFile(subfile))
          {
            files.Add(subfile.FullName);
          }
        }
      }
    }

  }
}
