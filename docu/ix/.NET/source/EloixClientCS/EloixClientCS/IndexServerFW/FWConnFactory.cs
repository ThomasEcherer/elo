using System;
using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW
{
  /// <summary>
  /// Creates FWConnection objects.
  /// </summary>
  public class FWConnFactory : IXConnFactoryBase, IDisposable
  {
    /// <summary>
    /// Property name for the cache lifetime of document files.
    /// </summary>
    public static String PROP_CACHE_DOCUMENT_LIFETIME_SECONDS = "fwconnection.cache.document.lifetimeSeconds";
    /// <summary>
    /// Default lifetime of documents in the document cache
    /// </summary>
    public static int PROP_CACHE_DOCUMENT_LIFETIME_DEFAULT = 120;

    private IXConnFactory innerFact;

    /// <summary>
    /// Constructor for simplest initialization.
    /// </summary>
    /// <param name="url">URL to IndexServer, e.g. http://server:8080/ix-Archive1/ix </param>
    /// <param name="appName">Your application name</param>
    /// <param name="appVersion">Your application version</param>
    public FWConnFactory(String url, String appName, String appVersion)
      : base(url, appName, appVersion)
    {
        innerFact = new IXConnFactory(url, appName, appVersion);
    }

    /// <summary>
    /// Constructor using initial values from the given property maps.
    /// </summary>
    /// <param name="props">
    /// Connection properties. Possible properties are PROP_* in FWConnFactory and IXConnFactory.
    /// </param>
    /// <param name="sessOpts">Session options. See class SessionOptionsC for possible values.</param>
    public FWConnFactory(IXProperties props, IXProperties sessOpts) 
      : base(props, sessOpts) 
    {
        innerFact = new IXConnFactory(props, sessOpts);
    }


    #region IDisposable Members

    /// <summary>
    /// Releases all by the instance used resources.
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
    }

    #endregion

    /// <summary>
    /// Gets value indicating if resources of component are realeased or not.
    /// </summary>
    public bool IsDisposed
    {
        get;
        private set;
    }

    /// <summary>
    /// Releases all used resources by the <see cref="FWConnFactory"/> component.
    /// </summary>
    /// <param name="isDisposing">False if resources are released by Carbage Collector otherwise true.</param>
    private void Dispose(bool isDisposing)
    {
        if (isDisposing)
        {
            if (!IsDisposed)
            {
                if (timer != null)
                {
                    timer.Dispose();
                    timer = null;
                }
            }
        }

        IsDisposed = true;
    }

    /// <summary>
    /// Create a connection to IndexServer.
    /// </summary>
    /// <param name="ci">ClientInfo object with language and timezone. 
    /// ci.timeZone can be either unset or set to "GMT". The former value 
    /// denotes that the client application is in the same timezone as the server. 
    /// </param>
    /// <param name="userName">Login user name</param>
    /// <param name="userPwd">Login user password</param>
    /// <param name="computerName">Local computer name</param>
    /// <param name="runAs">User name or ID if the session should be constrained to the rights of this user. 
    /// For using this parameter, the parameter userName must have main administration rights.</param>
    /// <returns>FWConnection object</returns>
    public FWConnection Create(ClientInfo ci, String userName, String userPwd, String computerName, String runAs)
    {
        IXConnection conn = innerFact.Create(ci, userName, userPwd, computerName, runAs);
      return new FWConnection(conn);
    }

      /// <summary>
    /// Create connection for the current user of the operating system.
    /// </summary>
    /// <param name="ci">ClientInfo</param>
    /// <param name="computerName">Client computer name</param>
    /// <returns>Connection object</returns>
    /// <remarks>
    /// A HTTP-GET request is sent to the server ixlogin.
    /// The current credentials from CredentialsCache are supplied to the 
    /// request. The server has to check the credentials. 
    /// </remarks>
    public virtual FWConnection CreateSso(ClientInfo ci, String computerName)
    {
        IXConnection conn = innerFact.CreateSso(ci, computerName);
        return new FWConnection(conn);
    }

    /// <summary>
    /// Create connection for the current user of the operating system.
    /// </summary>
    /// <param name="computerName">Client computer name</param>
    /// <returns>Connection object</returns>
    /// <remarks>
    /// The ClientInfo object is created by MakeDefaultClientInfo.
    /// </remarks>
    public virtual FWConnection CreateSso(String computerName)
    {
        IXConnection conn = innerFact.CreateSso(computerName);
        return new FWConnection(conn);
    }
  }
}
