using System;
using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.ServerEvents
{
  /// <summary>
  /// Connection factory class that can be used to create a connection
  /// in an event handler.
  /// </summary>
  /// <seealso cref="EloixClient.IndexServer.IXServerEvents"/>
  public class FWConnFactoryEventHandler : FWConnFactory
  {
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="url">IndexServer URL, can be obtained from IXServerEvents.url</param>
    /// <param name="appName">Application name</param>
    /// <param name="appVersion">Application version</param>
    public FWConnFactoryEventHandler(String url, String appName, String appVersion) 
      : base(url, appName, appVersion)
    {
    }

    /// <summary>
    /// Create connection to IndexServer using the given ClientInfo.
    /// </summary>
    /// <param name="ci">ClientInfo object</param>
    /// <returns>Connection object</returns>
    public FWConnection CreateConnForEventHandler(ClientInfo ci)
    {
      return (FWConnection)InternalCreate(ci, null, null, null, null, null, false);
    }

    /// <summary>
    /// Creates an object that provides the relogin mechanism.
    /// </summary>
    /// <param name="ixClient">IXClient object</param>
    /// <param name="ci">ClientInfo object</param>
    /// <param name="userName">User name</param>
    /// <param name="userPwd">User password</param>
    /// <param name="computerName">Computer name</param>
    /// <param name="runAs">Run as user</param>
    /// <param name="reportAs">Report as user</param>
    /// <param name="sessOpts">Session options</param>
    /// <param name="sso">Use Single Sign On supplied by ixlogin servlet.</param>
    /// <returns>Login object</returns>
    protected override IXConnLogin InternalCreateLoginObject(IXClient ixClient, ClientInfo ci,
      String userName, String userPwd, String computerName, String runAs, String reportAs,
      IXProperties sessOpts, bool sso)
    {
      IXConnLogin ixsl = new FWConnLoginEventHandler(ixClientVal, ci);
      return ixsl;
    }

  }
}
