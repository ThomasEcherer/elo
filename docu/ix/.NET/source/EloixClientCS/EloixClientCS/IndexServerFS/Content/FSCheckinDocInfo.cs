using System;
using System.IO;

namespace EloixClient.IndexServerFS.Content
{
  internal class FSCheckinDocInfo
  {
    internal const String FS_CHECKOUT_SORD_INFO_EXT = ".¶co";

    internal const String COMMAND_DELETE = "delete";
    internal const String COMMAND_CHECKIN = "checkin";
    internal const String COMMAND_RESTORE = "restore";

    internal String command;
    internal String verNo;
    internal String verDesc;
    internal int maskId;
    internal int pathId;
    internal int encrSet;

    internal FSCheckinDocInfo()
    {
      command = "checkin";
    }

    internal void Write(String fname)
    {

      FileInfo f = new FileInfo(fname);
      if (f.Exists)
      {
        f.Delete();
      }

      StreamWriter sw = null;
      try
      {
        sw = new StreamWriter(fname, false, System.Text.Encoding.Unicode);

        sw.WriteLine("command=" + this.command);
        sw.WriteLine("verNo=" + this.verNo);
        sw.WriteLine("verDesc=" + this.verDesc);
        sw.WriteLine("pathId=" + this.pathId);
        sw.WriteLine("encrSet=" + this.encrSet);
        sw.WriteLine("maskId=" + this.maskId);

      }
      finally
      {
        if (sw != null)
        {
          sw.Close();

          f.Refresh();
          f.Attributes |= FileAttributes.Hidden;
        }
      }
    }
  }
}
