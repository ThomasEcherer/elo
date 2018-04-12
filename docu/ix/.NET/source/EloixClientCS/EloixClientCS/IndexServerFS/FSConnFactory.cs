using System;
using System.Collections.Generic;
using System.IO;
using de.elo.ix.client;
using Microsoft.Win32;

namespace EloixClient.IndexServerFS
{
  /// <summary>
  /// This connection factory creates connection objects that uses the 
  /// session tickets from the ELO File System.
  /// </summary>
  public class FSConnFactory
  {
    /// <summary>
    /// ELOFS Configuration
    /// </summary>
    protected FSConfig config;

    /// <summary>
    /// Maps archive names to connection objects.
    /// </summary>
    protected Dictionary<String, FSConnection> mapConns = new Dictionary<string, FSConnection>();

    /// <summary>
    /// Number of connections to IndexServer
    /// </summary>
    protected int nbOfConnections = 2;
    /// <summary>
    /// Timeout for requests to IndexServer
    /// </summary>
    protected int timeoutSeconds = 120;

    /// <summary>
    /// Prefix of internal directories of ELOFS
    /// </summary>
    public const String INTERNAL_PATH_PREFIX = "-i-";

    /// <summary>
    /// Constructor
    /// </summary>
    /// <exception cref="NotSupportedException">If ELO File System configuration cannot be found in installation directory or application data directory.</exception>
    /// <see cref="Avail"/>
    public FSConnFactory()
    {
      config = new FSConfig();
    }

    /// <summary>
    /// Returns true, if ELOFS is installed.
    /// </summary>
    public static bool Avail
    {
      get
      {
        bool succ = false;
        try
        {
          new FSConnFactory();
          succ = true;
        }
        catch (System.NotSupportedException)
        {
        }
        return succ;
      }
    }

    /// <summary>
    /// Archive names provided by ELOFS. 
    /// Subdirectories of the drive letter.
    /// </summary>
    public String[] ArcNames
    {
      get
      {
        List<String> ret = new List<String>();
        DirectoryInfo fiDrive = new DirectoryInfo(config.Drive + "\\");
        DirectoryInfo[] dirs = fiDrive.GetDirectories();
        foreach (DirectoryInfo dir in dirs)
        {
          if (!dir.Name.StartsWith(INTERNAL_PATH_PREFIX))
          {
            ret.Add(dir.Name);
          }
        }
        return ret.ToArray();
      }
    }

    /// <summary>
    /// Makes the path of login.properties for the given archive name.
    /// </summary>
    /// <param name="arcName">Archive name</param>
    /// <returns>Path to login.properties</returns>
    protected String getLoginPropertiesFileName(String arcName)
    {
      String login_properties = config.Drive + "\\" + arcName + "\\login.properties";
      return login_properties;
    }

    /// <summary>
    /// Returns the connection for the given archive name. 
    /// If no connection object already exists, a new object ist created.
    /// </summary>
    /// <param name="arcName">Archive name</param>
    /// <returns>Connection</returns>
    /// <exception>System.IO.IOException</exception>
    public virtual FSConnection GetConnection(String arcName)
    {
      lock (mapConns)
      {
        FSConnection conn = null;
        if (!mapConns.TryGetValue(arcName, out conn))
        {
          mapConns[arcName] = conn = CreateConnection(arcName);
        }
        return conn;
      }
    }

    /// <summary>
    /// Creates a connection to IndexServer that is initialized by the 
    /// session ticket of ELOFS.
    /// </summary>
    /// <param name="arcName">Archive name</param>
    /// <returns>Connection to IndexServer</returns>
    protected virtual FSConnection CreateConnection(String arcName)
    {
      String login_properties = getLoginPropertiesFileName(arcName);
      IXProperties lprops = new IXProperties();
      lprops.Read(login_properties);

      String url = lprops["url"];
      IXClient ixClient = new IXClient(url, nbOfConnections, timeoutSeconds);

      FSConnLogin connLogin = new FSConnLogin(ixClient, login_properties);

      IXProperties connProps = new IXProperties();

      FSConnection conn = new FSConnection(config, arcName, new IXConnection(ixClient, connLogin, connProps) );
      return conn;
    }

  }
}
