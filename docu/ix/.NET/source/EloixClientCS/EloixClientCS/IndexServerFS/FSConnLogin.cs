using System;
using System.Threading;
using de.elo.ix.client;

namespace EloixClient.IndexServerFS
{
  /// <summary>
  /// Re-login class for ELOFS.
  /// Objects of this class read login.properties on re-login.
  /// </summary>
  internal class FSConnLogin : IXConnLogin
  {
    /// <summary>
    /// Path of login.properties
    /// </summary>
    String loginProperties; 

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="ix">IndexServer interface object</param>
    /// <param name="loginProperties">Path of login.properties</param>
    public FSConnLogin(IXClient ix, String loginProperties)
      : base(ix, new ClientInfo(), "", new IXProperties(), new IXProperties())
    {
      this.loginProperties = loginProperties;
      login();
    }

    /// <summary>
    /// Read LoginResult object from login.properties.
    /// </summary>
    /// <param name="lprops">Map that contains login.properties</param>
    /// <returns>LoginResult object</returns>
    protected static LoginResult readLoginResult(IXProperties lprops)
    {
      LoginResult loginResult = new LoginResult();
      loginResult.clientInfo = new ClientInfo();
      loginResult.clientInfo.ticket = lprops["loginResult.clientInfo.ticket"];
      loginResult.clientInfo.language = lprops["loginResult.clientInfo.language"];
      loginResult.clientInfo.country = lprops["loginResult.clientInfo.country"];
      loginResult.ticketLifetime = lprops.Get("loginResult.ticketLifetime", 120);
      loginResult.user = new UserInfo();
      loginResult.user.id = lprops.Get("loginResult.user.id", -1);
      loginResult.user.name = lprops["loginResult.user.name"];
      loginResult.user.flags = lprops.Get("loginResult.user.flags", 0);
      return loginResult;
    }
    
    /// <summary>
    /// If the given error is a session timeout error, this function reads the 
    /// login.properties to retrieve the new ticket.
    /// </summary>
    /// <param name="prevLoginCount">Login count before the function was called</param>
    /// <param name="loopCount">Login count that was incremented in the outer loop</param>
    /// <param name="e">Exception</param>
    /// <returns>Login count incremented by 1</returns>
    public override int reloginOrThrow(int prevLoginCount, int loopCount, Exception e)
    {
      if (loopCount >= DEFAULT_LOOP_MAX) throw e;
      if (!isReloginError(e)) throw e;

      lock (this)
      {
        Thread.Sleep(100 * loopCount);
        if (loginCount == prevLoginCount)
        {
          login();

          ticketBestBefore = DateTime.Now.AddSeconds((lrVal.ticketLifetime * 8) / 10);

          // Do not set session options. 
          // The session belongs to the file system service.

          loginCount++;
          return loginCount;
        }
      }

      throw e;
    }

    /// <summary>
    /// Read the login.properties file to receive the session ticket.
    /// </summary>
    public override void login()
    {
      IXProperties lprops = new IXProperties();
      lprops.Read(loginProperties);
      lrVal = readLoginResult(lprops);
    }
  }
}
