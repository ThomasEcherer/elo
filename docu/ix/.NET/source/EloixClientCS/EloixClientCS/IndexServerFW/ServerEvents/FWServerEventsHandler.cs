using System;
using System.Collections.Generic;
using EloixClient.IndexServer;
using System.Web;
using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.ServerEvents
{
  /// <summary>
  /// This class helps to provide an ASP.NET IHttpHandler 
  /// (Generic Handler) that implements the IXServerEvents 
  /// interface.
  /// Your project should inherit from this class and implement
  /// the IXServerEvents methods. Each implmented method has 
  /// to be added to the collection implementedMethods:
  /// <code>implementedMethods["onAfterCheckinSord"] = true;</code>
  /// </summary>
  public abstract class FWServerEventsHttpHandler : IXServerEvents
  {
    /// <summary>
    /// Application name, used in IXServerEvents.getAppInfo
    /// </summary>
    protected String appName;
    /// <summary>
    /// Application version, used in IXServerEvents.getAppInfo
    /// </summary>
    protected String appVersion;
    /// <summary>
    /// Collection of IndexServer connections.
    /// </summary>
    protected FWConnMapEventHandler connMap;
    /// <summary>
    /// Collection of implemented methods.
    /// </summary>
    protected Dictionary<String, bool> implementedMethods = new Dictionary<String, bool>();

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="appName">Application name</param>
    /// <param name="appVersion">Application version</param>
    public FWServerEventsHttpHandler(String appName, String appVersion)
    {
      this.appName = appName;
      this.appVersion = appVersion;

      // This collection object creates IndexServer connections 
      // upon the ClientInfo object supplied in the event functions. 
      connMap = new FWConnMapEventHandler(appName, appVersion);

      // Subclasses have to register the implemented methods.
      // IXServerEvents.hasMethod uses this collection.
      // implementedMethods["onAfterCheckinSord"] = true;
    }

    /// <summary>
    /// .NET HTTP request handler function.
    /// IndexServer sends the function calls without any request URL parameter.
    /// For protocol negotiation, the request parameter cmd=negotiate is send.
    /// The protocol version is given in the request header IXDATASTREAM.
    /// </summary>
    /// <param name="context">Context</param>
    public virtual void ProcessRequest(HttpContext context)
    {
      // check for request parameter cmd
      System.Collections.Specialized.NameValueCollection requestParams = context.Request.Params;
      String cmd = requestParams["cmd"];

      // print status?
      if (cmd != null && cmd.Equals("status"))
      {
        context.Response.ContentType = "text/plain";
        context.Response.Write(appName + " " + appVersion);
      }
      else
      {
        // The header IXDATASTREAM is always send and contains the
        // stream verision of the server or the negotiated stream version.
        String ixStreamVersion = context.Request.Headers["IXDATASTREAM"];

        // Create the helper object for:
        // - reading event methods and parameters from the HTTP input stream
        // - executing the methods on the target eventHandler, which is a IXServerEvents implementation
        // - writing method results to the HTTP output stream
        IxDataStreamServer strmServer = new IxDataStreamServer(this, IXServerEventsC.STREAM_VERSION, IxDataStreamRegistry.getRegistry());

        // Use the lowest version
        String negotiatedStreamVersion = strmServer.negotiate(ixStreamVersion);

        // Just return the negotiated stream version?
        if (cmd != null && cmd.Equals("negotiate"))
        {
          // Write the negotiated stream version formatted as name-value pair into the response buffer.
          context.Response.ContentType = "text/plain";
          context.Response.Write("IXDATASTREAM=" + negotiatedStreamVersion);

          // IX normally uses the request headers for exchanging 
          // the stream version. But accessing the header might throw an Exception, see:
          // s. http://msdn.microsoft.com/de-de/library/system.web.httpresponse.headers.aspx
          // context.Response.Headers["IXDATASTREAM"] = streamVersion;
        
        }
        else
        {
          /////////////////////////////////////////////////////
          // Process the event

          strmServer.processRequest(negotiatedStreamVersion,
            context.Request.InputStream,
            context.Response.OutputStream);

        }

      }

    }

    /// <summary>
    /// see MSDN
    /// </summary>
    public virtual bool IsReusable
    {
      get
      {
        return true;
      }
    }


    #region IXServerEvents Members

    /// <summary>
    /// Returns appName and appVersion
    /// </summary>
    /// <param name="ec">Execution context</param>
    /// <returns></returns>
    public string getAppInfo(IXServerEventsContext ec)
    {
      return appName + " " + appVersion;
    }

    /// <summary>
    /// Returns true, if this class implements the specified method.
    /// It looks up the name in the collection implementedMethods.
    /// </summary>
    /// <param name="ec">Execution context</param>
    /// <param name="methodName">Method name, e. g. onAfterCheckinSord</param>
    /// <returns></returns>
    public bool hasMethod(IXServerEventsContext ec, string methodName)
    {
      bool v = true;
      return implementedMethods.TryGetValue(methodName, out v) && v;
    }

    /*
     * Example: start workflow for new document
    public override void onAfterCheckinSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ)
    {
      // new sord?
      if (sordDB == null && sord.type >= SordC.LBT_DOCUMENT)
      {
        FWConnection conn = connMap.getConn(ec);
        conn.Ix.startWorkFlow("myHttpHandlerWorkflow", sord.name + "-workflow", sord.guid);
      }
    }
    */

    ///<summary>See IX documentation</summary>
    ///<param name="ec">See IX documentation</param>
    ///<param name="sord">See IX documentation</param>
    ///<param name="sordDB">See IX documentation</param>
    ///<param name="parentSord">See IX documentation</param>
    ///<param name="sordZ">See IX documentation</param>
    ///<param name="unlockZ">See IX documentation</param>
    public abstract void onBeforeCheckinSord(IXServerEventsContext ec, Sord sord, Sord sordDB, Sord parentSord, SordZ sordZ, LockZ unlockZ);

    ///<summary>See IX documentation</summary>
    ///<param name="ec">See IX documentation</param>
    ///<param name="sord">See IX documentation</param>
    ///<param name="sordDB">See IX documentation</param>
    ///<param name="parentSord">See IX documentation</param>
    ///<param name="sordZ">See IX documentation</param>
    ///<param name="unlockZ">See IX documentation</param>
    public abstract void onAfterCheckinSord(IXServerEventsContext ec, Sord sord, Sord sordDB, Sord parentSord, SordZ sordZ, LockZ unlockZ);

    ///<summary>See IX documentation</summary>
    ///<param name="ec">See IX documentation</param>
    ///<param name="sord">See IX documentation</param>
    ///<param name="sordDB">See IX documentation</param>
    ///<param name="parentSord">See IX documentation</param>
    ///<param name="doc">See IX documentation</param>
    ///<param name="sordZ">See IX documentation</param>
    ///<param name="unlockZ">See IX documentation</param>
    public abstract void onBeforeCheckinDocEnd(IXServerEventsContext ec, Sord sord, Sord sordDB, Sord parentSord, Document doc, SordZ sordZ, LockZ unlockZ);

    ///<summary>See IX documentation</summary>
    ///<param name="ec">See IX documentation</param>
    ///<param name="sord">See IX documentation</param>
    ///<param name="sordDB">See IX documentation</param>
    ///<param name="parentSord">See IX documentation</param>
    ///<param name="doc">See IX documentation</param>
    ///<param name="sordZ">See IX documentation</param>
    ///<param name="unlockZ">See IX documentation</param>
    public abstract void onAfterCheckinDocEnd(IXServerEventsContext ec, Sord sord, Sord sordDB, Sord parentSord, Document doc, SordZ sordZ, LockZ unlockZ);

    ///<summary>See IX documentation</summary>
    ///<param name="ec">See IX documentation</param>
    ///<param name="parentSord">See IX documentation</param>
    ///<param name="sord">See IX documentation</param>
    ///<param name="unlockZ">See IX documentation</param>
    ///<param name="delOpts">See IX documentation</param>
    public abstract void onBeforeDeleteSord(IXServerEventsContext ec, Sord parentSord, Sord sord, LockZ unlockZ, DeleteOptions delOpts);

    ///<summary>See IX documentation</summary>
    ///<param name="ec">See IX documentation</param>
    ///<param name="parentSord">See IX documentation</param>
    ///<param name="sord">See IX documentation</param>
    ///<param name="unlockZ">See IX documentation</param>
    ///<param name="delOpts">See IX documentation</param>
    ///<param name="ret">See IX documentation</param>
    public abstract void onAfterDeleteSord(IXServerEventsContext ec, Sord parentSord, Sord sord, LockZ unlockZ, DeleteOptions delOpts, bool ret);

    ///<summary>See IX documentation</summary>
    ///<param name="ec">See IX documentation</param>
    ///<param name="parentSordOld">See IX documentation</param>
    ///<param name="parentSordNew">See IX documentation</param>
    ///<param name="sord">See IX documentation</param>
    ///<param name="manSortIndex">See IX documentation</param>
    public abstract void onBeforeRefSord(IXServerEventsContext ec, Sord parentSordOld, Sord parentSordNew, Sord sord, int manSortIndex);

    ///<summary>See IX documentation</summary>
    ///<param name="ec">See IX documentation</param>
    ///<param name="parentSordOld">See IX documentation</param>
    ///<param name="parentSordNew">See IX documentation</param>
    ///<param name="sord">See IX documentation</param>
    ///<param name="manSortIndex">See IX documentation</param>
    public abstract void onAfterRefSord(IXServerEventsContext ec, Sord parentSordOld, Sord parentSordNew, Sord sord, int manSortIndex);

    public abstract Any executeRegisteredFunction(IXServerEventsContext ec, String functionName, Any any);

    public abstract void onAfterEndEditWorkFlowNode(IXServerEventsContext ec, WFDiagram workflow, int nodeId, Sord sord, SordZ sordZ);

    public abstract void onAfterStartWorkFlow(IXServerEventsContext ec, WFDiagram workflow, Sord sord, SordZ sordZ);

    public abstract void onAfterCheckinReminder(IXServerEventsContext ec, Reminder[] remiArray, Sord sord, SordZ sordZ, LockZ unlockZ);

    public abstract void onBeforeCheckinActivity(IXServerEventsContext ec, Activity act, bool isNew, Sord sord, SordZ sordZ, LockZ unlockZ);

    public abstract void onAfterCheckinActivity(IXServerEventsContext ec, Activity act, bool isNew, Sord sord, SordZ sordZ, LockZ unlockZ);

    public abstract void onFileUploadBuildResponse(IXServerEventsContext ec, DocVersion dv, String fileName, HttpRequestInfo requestInfo, HttpResponseInfo responseInfo);

    public abstract UserName[] getUserNames(IXServerEventsContext ec, string[] ids, CheckoutUsersZ checkoutZ);

    public abstract void onReadSord(IXServerEventsContext ec, Sord sord, SordZ sordZ, Document doc, LockZ lockZ);

    public abstract bool onCheckSordAccess(IXServerEventsContext ec, Sord sord, SordZ sordZ, int lur, CheckAccessOptions opts);

    #endregion
  }
}
