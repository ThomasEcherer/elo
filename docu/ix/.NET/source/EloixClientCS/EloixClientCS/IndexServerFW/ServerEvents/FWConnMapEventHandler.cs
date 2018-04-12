using System;
using System.Collections.Generic;
using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.ServerEvents
{
  /// <summary>
  /// This class provides a map for re-using IndexServer connections.
  /// </summary>
  public class FWConnMapEventHandler
  {
    /// <summary>
    /// Maps IndexServer URL to connection factory.
    /// </summary>
    protected Dictionary<String, FWConnFactoryEventHandler> mapFacts = new Dictionary<string, FWConnFactoryEventHandler>();
    /// <summary>
    /// Application name, used when a new connection factory is created.
    /// </summary>
    protected String appName;
    /// <summary>
    /// Application version, used when a new connection factory is created.
    /// </summary>
    protected String appVersion;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="appName">Application name</param>
    /// <param name="appVersion">Application version</param>
    public FWConnMapEventHandler(String appName, String appVersion)
    {
      this.appName = appName;
      this.appVersion = appVersion;
    }

    /// <summary>
    /// Gets or creates an IndexServer connection.
    /// </summary>
    /// <param name="ec">Execution context object passed to an event handler.</param>
    /// <returns></returns>
    public FWConnection getConn(IXServerEventsContext ec)
    {
      if (ec.url == null || ec.url.Length == 0)
      {
        throw new ArgumentException("Missing IndexServer URL");
      }

      FWConnection conn = null;
      lock (this)
      {
        FWConnFactoryEventHandler fact = null;
        if (!mapFacts.TryGetValue(ec.url, out fact))
        {
          fact = new FWConnFactoryEventHandler(ec.url, appName, appVersion);
          mapFacts[ec.url] = fact;
        }

        conn = fact.CreateConnForEventHandler(ec.ci);
      }

      return conn;
    }
  }
}
