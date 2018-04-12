using System;
using System.IO;
using System.Text;

namespace EloixClient.IndexServerFS.Content
{
  /// <summary>
  /// This helper class contains some utility functions related to 
  /// file names and paths.
  /// </summary>
  public class FSFileHelper
  {
    /// <summary>
    /// This character is used to replace a forbidden character in a file name.
    /// </summary>
    public static String FS_FORBIDDEN_REPLACE_PREFIX = "^";
    /// <summary>
    /// This characters are forbidden for file names (in ELOFS).
    /// </summary>
    public static String FS_FORBIDDEN_CHARS = "\\/:\"|*?<>" + FS_FORBIDDEN_REPLACE_PREFIX;
    /// <summary>
    /// This characters are forbidden for file names (in ELOFS).
    /// </summary>
    public static char[] FS_FORBIDDEN_CHAR_ARRAY = FS_FORBIDDEN_CHARS.ToCharArray();
    /// <summary>
    /// File attribute used to mark checked out files that are deleted.
    /// </summary>
    internal static FileAttributes MY_FILE_ATTRIBUTE_DELETED = FileAttributes.Temporary;
    
    /// <summary>
    /// Replace forbidden characters with prefix + character.
    /// </summary>
    /// <param name="rawName">Raw file name.</param>
    /// <returns>File name that is valid for the file system.</returns>
    public static String EscapeFileName(String rawName) {

      String ret = rawName;

      int startIdx = 0;
      int idx = rawName.IndexOfAny(FS_FORBIDDEN_CHAR_ARRAY, startIdx);

      if (idx >= 0)
      {
        StringBuilder buf = new StringBuilder();

        while (idx >= 0)
        {
          buf.Append(rawName.Substring(startIdx, idx - startIdx));

          char forbiddenChar = rawName[idx];
          int forbiddenCharIdx = FS_FORBIDDEN_CHARS.IndexOf(forbiddenChar);

          char replaceChar = (char)('A' + forbiddenCharIdx);
          buf.Append(FS_FORBIDDEN_REPLACE_PREFIX).Append(replaceChar);

          startIdx = idx + 1;
          idx = rawName.IndexOfAny(FS_FORBIDDEN_CHAR_ARRAY, startIdx);
        }

        buf.Append(rawName.Substring(startIdx));

        ret = buf.ToString();
      }

      return ret;
    }

    internal static String makeCheckoutCtrlFileName(String winPath)
    {
      String coFileName = MakeCheckoutFileName(winPath);
      coFileName += FSCheckinDocInfo.FS_CHECKOUT_SORD_INFO_EXT;
      return coFileName;
    }

    internal static void CheckinFile(String winPath, String verNo, String verDesc,
      int maskId, int pathId, int encrSet)
    {
      FileInfo fi = new FileInfo(winPath);
      bool isDeleted = !fi.Exists; //(fi.Attributes & MY_FILE_ATTRIBUTE_DELETED) != 0;

      FSCheckinDocInfo co = new FSCheckinDocInfo();

      co.command = isDeleted ? FSCheckinDocInfo.COMMAND_DELETE : FSCheckinDocInfo.COMMAND_CHECKIN;
      co.verNo = verNo;
      co.verDesc = verDesc;
      co.maskId = maskId;
      co.pathId = pathId;
      co.encrSet = encrSet;

      String infoFileName = makeCheckoutCtrlFileName(winPath);
      co.Write(infoFileName);

      if (isDeleted)
      {
        fi = new FileInfo(infoFileName);
      }

      System.IO.FileAttributes attrs = fi.Attributes;
      attrs &= ~System.IO.FileAttributes.Archive;
      attrs |= System.IO.FileAttributes.ReadOnly;

      // Checkin
      File.SetAttributes(winPath, attrs);
    }

    internal static void RestoreFile(string winPath)
    {
        FSCheckinDocInfo co = new FSCheckinDocInfo();
        co.command = FSCheckinDocInfo.COMMAND_RESTORE;

        String infoFileName = makeCheckoutCtrlFileName(winPath);
        co.Write(infoFileName);

        // Checkin
        System.IO.FileAttributes attrs = System.IO.FileAttributes.ReadOnly | System.IO.FileAttributes.Hidden;
        File.SetAttributes(infoFileName, attrs);
    }

    internal static void CheckoutFile(string winPath)
    {
        System.IO.FileAttributes attrs = File.GetAttributes(winPath);

        attrs &= ~System.IO.FileAttributes.ReadOnly;
        attrs |= System.IO.FileAttributes.Archive;

        File.SetAttributes(winPath, attrs);
    }

    internal static string MakeCheckoutFileName(string winPath)
    {
      string[] pathArray = winPath.Split('\\');

      StringBuilder newPath = new StringBuilder();

      int idx = 0; 

      // drive
      if (pathArray.Length > 0)
      {
        newPath.Append(pathArray[idx++]);
      }

      // Archive name
      if (pathArray.Length > 0)
      {
        string arcName = pathArray[idx++];
        if (arcName.StartsWith("-i-"))
        {
          // is already a file name in the checkout directory
          return winPath; 
        }

        newPath.Append("\\-i-");
        newPath.Append(arcName);
        newPath.Append("\\Chk");
      }
      
      for (; idx < pathArray.Length; idx++)
      {
        newPath.Append('\\');
        newPath.Append(pathArray[idx]);
      }

      return newPath.ToString();
    }

    internal static string MakeArcPathFromFileName(string fname)
    {
        string[] pathArray = fname.Split('\\');

        StringBuilder newPath = new StringBuilder();

        int idx = 0; // skip drive\Archive\

        // drive
        if (pathArray.Length > 0)
        {
            idx++;
        }

        // Archive name
        if (pathArray.Length > 1)
        {
            idx++;
        }

        for (; idx < pathArray.Length; idx++)
        {
            newPath.Append('\\');
            newPath.Append(pathArray[idx]);
        }

        return newPath.ToString();
    }

    internal static string MakeWinFileName(string coFileName)
    {
      string[] pathArray = coFileName.Split('\\');

      StringBuilder newPath = new StringBuilder();

      int idx = 0; // skip drive\Archive\Chk

      // drive
      if (pathArray.Length > 0)
      {
        newPath.Append(pathArray[idx++]);
      }

      // Archive name
      if (pathArray.Length > 1)
      {
        string arcName = pathArray[idx++];
        if (!arcName.StartsWith("-i-"))
        {
          // is already a file name in the ELOFS directory
          return coFileName;
        }

        newPath.Append("\\");
        newPath.Append(arcName.Substring(3));

        string chk = pathArray[idx++];
        if (chk != "Chk") throw new System.ArgumentException("Missing \"Chk\" in checkout file name=" + coFileName);
      }

      for (; idx < pathArray.Length; idx++)
      {
        newPath.Append('\\');
        newPath.Append(pathArray[idx]);
      }

      return newPath.ToString();
    }
  }
}
