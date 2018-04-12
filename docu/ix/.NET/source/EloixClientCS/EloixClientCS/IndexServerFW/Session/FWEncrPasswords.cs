using System;

namespace EloixClient.IndexServerFW.Session
{
  /// <summary>
  /// This class helps to get and set the session options.
  /// </summary>
  public class FWEncrPasswords : FWSessionBase
  {
    /// <summary>
    /// Notes, wether the object was modified.
    /// </summary>
    protected bool modified;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="ifc">Session nterface object</param>
    public FWEncrPasswords(FWSessionInterface ifc)
      : base(ifc)
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
        return Conn.internalConnection.EncrPasswords[key];
      }
      set
      {
        Conn.internalConnection.EncrPasswords[key] = value;
        modified = true;
      }
    }

    /// <summary>
    /// Store changes.
    /// </summary>
    public void Checkin()
    {
      modified = false;

      foreach (String cryptId in Conn.internalConnection.EncrPasswords.Keys)
      {
        String pwd = Conn.internalConnection.EncrPasswords[cryptId];
        String pwdEncr = Conn.internalConnection.EncryptPassword(pwd);
        Conn.Ix.provideCryptPassword(cryptId, pwdEncr);
      }
    }
  }
}
