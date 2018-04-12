using System;
using System.ComponentModel;
using EloixClient.IndexServerFW.Content;
using EloixClientUI.Utils;

namespace EloixClientUI.Common
{
  /// <summary>
  /// Helper class to open a file
  /// </summary>
  public class OpenDocumentHandler
  {
    /// <summary>
    /// Opens the file with the associated application. 
    /// </summary>
    /// <param name="fileName"></param>
    /// <remarks>If the application is not found, the file is opend by the Internet Explorer.</remarks>
    public virtual void OpenFile(String fileName)
    {
      if (fileName != null && fileName.Length != 0)
      {
        try
        {
          System.Diagnostics.Process.Start(fileName);
          //Process myProcess = new Process();
          //myProcess.StartInfo.FileName = fileName;
          //myProcess.StartInfo.UseShellExecute = true;
          //myProcess.StartInfo.RedirectStandardOutput = false;
          //myProcess.Start();
        }
        catch (Win32Exception)
        {
          System.Diagnostics.Process.Start("explorer.exe", fileName);
        }
      }
    }
    
    /// <summary>
    /// Opens the document file.
    /// </summary>
    /// <param name="doc">Document object</param>
    /// <seealso cref="OpenFile"/>
    public virtual void Open(FWDocument doc)
    {
        string file = FWSordUtils.GetDocumentFile(doc);
        if (null != file)
            OpenFile(file);
    }
  }
}
