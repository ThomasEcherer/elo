using System;
using de.elo.ix.client;
using EloixClient.IndexServerFW;

namespace EloixClient.IndexServerFS
{
  /// <summary>
  /// This class represents a connection to IndexServer that 
  /// is initialized from the session information of ELOFS.
  /// </summary>
  public class FSConnection : FWConnection
  {
    /// <summary>
    /// ELOFS configuration
    /// </summary>
    protected FSConfig configVal;

    /// <summary>
    /// Archive name.
    /// </summary>
    protected string arcNameVal;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="config">ELOFS configuration</param>
    /// <param name="arcName">Archive name</param>
    /// <param name="innerConn">IXConnection object</param>
    public FSConnection(FSConfig config, string arcName, IXConnection innerConn)
      : base(innerConn)
    {
      this.configVal = config;
      this.arcNameVal = arcName;
      base.contentInterfaceVal = new Content.FSContentInterface();
      base.contentInterfaceVal.Init(this, arcName, innerConn.ConnProperties);
    }

    /// <summary>
    /// ELOFS configuration
    /// </summary>
    public FSConfig Config
    {
      get
      {
        return configVal;
      }
    }

    /// <summary>
    /// Archive name.
    /// </summary>
    public override string ArcName
    {
      get
      {
        return arcNameVal;
      }
    }

  }
}
