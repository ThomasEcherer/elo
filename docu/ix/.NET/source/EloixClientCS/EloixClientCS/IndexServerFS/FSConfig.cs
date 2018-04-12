using System;
using System.Collections.Generic;
using System.Text;
using de.elo.ix.client;
using Microsoft.Win32;
using System.IO;
using System.Text.RegularExpressions;

namespace EloixClient.IndexServerFS
{
  /// <summary>
  /// This class provides read access to the configuration properties of ELOFS.
  /// </summary>
  public class FSConfig
  {

    private IXProperties props;
    private string[] tempFileFilters;

    /// <summary>
    /// Constructor. 
    /// </summary>
    /// <remarks>Reads the ELOFS properties from the conf.properties file.</remarks>
    /// <exception cref="NotSupportedException">If ELO File System configuration cannot be found in installation directory or application data directory.</exception>
    public FSConfig()
    {
      props = ReadConfigProperties();
      if (props == null)
      {
        throw new System.NotSupportedException("Cannot find ELO File System configuration");
      }
      InitTempFileFilters();
    }

    /// <summary>
    /// Drive letter (including :)
    /// </summary>
    public String Drive
    {
      get
      {
        String s = "";
        if (props != null)
        {
          s = props.Get("Install.drive", "");
          if (!s.EndsWith(":")) s += ":";
        }
        return s;
      }
    }

    public bool IsTempFile(FileInfo file)
    {
      bool succ = false;
      foreach (string f in tempFileFilters)
      {
        if (Regex.IsMatch(file.Name, f, RegexOptions.IgnoreCase))
        {
          succ = true;
          break;
        }
      }
      return succ;
    }

    private static String GetElofsInstDirFromRegistry()
    {
      String instDir = "";
      RegistryKey rkey = Registry.LocalMachine.OpenSubKey("Software\\ELO Digital\\ELOFS");
      if (rkey != null)
      {
        instDir = (String)rkey.GetValue("InstDir");
        rkey.Close();
      }
      return instDir;
    }

    private static String GetAppdataDir()
    {
      String dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
      if (dir.Length != 0)
      {
        dir = Path.Combine(dir, "ELO File System");
      }
      return dir;
    }

    private static IXProperties ReadConfigPropertiesInDir(String dir)
    {
      IXProperties props = null;
      if (dir.Length != 0 && Directory.Exists(dir))
      {
        String confFile = Path.Combine(dir, "conf.properties");
        if (File.Exists(confFile))
        {
          props = new IXProperties();
          props.Read(confFile);
          String localFile = Path.Combine(dir, "local.properties");
          if (File.Exists(localFile))
          {
            props.Read(localFile);
          }
        }
      }
      return props;
    }

    private static IXProperties ReadConfigProperties()
    {
      IXProperties props = null;

      String appDir = GetAppdataDir();
      props = ReadConfigPropertiesInDir(appDir);

      if (props == null)
      {
        String instDir = GetElofsInstDirFromRegistry();
        props = ReadConfigPropertiesInDir(instDir);
      }

      return props;
    }

    private void InitTempFileFilters()
    {
      string s = props.Get("FileSystem.tempFiles", ""); 
      if (s.Length != 0)
      {
        tempFileFilters = s.Split(new char[] { ',', ' ' });
        for (int i = 0; i < tempFileFilters.Length; i++)
        {
          string f = tempFileFilters[i];
          f = f.Replace('*', ':').Replace('?', '/');
          f = Regex.Escape(f);
          f = f.Replace(":", ".+").Replace('/', '.');
          tempFileFilters[i] = "^" + f + "$";
        }
      }
    }

  }
}
