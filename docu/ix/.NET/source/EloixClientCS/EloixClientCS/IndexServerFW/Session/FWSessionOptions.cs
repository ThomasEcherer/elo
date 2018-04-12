using System;
using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.Session
{
  /// <summary>
  /// This class helps to get and set the session options.
  /// </summary>
  public class FWSessionOptions : FWSessionBase
  {
    /// <summary>
    /// Notes, wether the object was modified.
    /// </summary>
    protected bool modified;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="ifc">Session nterface object</param>
    public FWSessionOptions(FWSessionInterface ifc) : base(ifc)
    {
    }
    /// <summary>
    /// Gets/sets a session option.
    /// </summary>
    /// <param name="key">One of the predefined session option keys, see SessionOptionsC</param>
    /// <returns>Session option value</returns>
    /// <seealso cref="EloixClient.IndexServer.SessionOptionsC"/>
    public String this[String key]
    {
      get
      {
        return Conn.internalConnection.SessionOptions[key];
      }
      set
      {
        Conn.internalConnection.SessionOptions[key] = value;
        modified = true;
      }
    }

    /// <summary>
    /// Store changes.
    /// </summary>
    public virtual void Checkin()
    {
      modified = false;
      SessionOptions opts = IXSessionOptions.makeSessOptsObj(Conn.internalConnection.SessionOptions);
      Conn.internalConnection.Ix.setSessionOptions(opts);
    }
  }
}
