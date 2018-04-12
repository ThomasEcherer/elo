using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using byps;
using System.Web;

namespace EloixClient.IndexServer
{
    /// <summary>
    /// <p>
    /// This object is used to create IXConnection objects that represent sessions
    /// to IndexServer. Use one of the create methods to instanciate an IXConnection 
    /// object.
    /// </p><p>
    /// The connection to the IndexServer is internally hold by an IXClient object. 
    /// Its initial parameters are supplied by a Properties collection given in the
    /// constructor of IXConnFactory. A reference to the IXClient object is passed
    /// to each IXConnection object created by one of the create functions. 
    /// </p>
    /// </summary>
    public class IXConnFactory : IXConnFactoryBase
    {
        /// <summary>
        /// <see cref="IXConnFactoryBase"/>
        /// </summary>
        /// <param name="props">Connection properties</param>
        /// <param name="sessOpts">Session options</param>
        public IXConnFactory(IXProperties props, IXProperties sessOpts)
            : base(props, sessOpts)
        {
        }

        /// <summary>
        /// <see cref="IXConnFactoryBase"/>
        /// </summary>
        /// <param name="url">IndexServer URL</param>
        /// <param name="appName">Application name</param>
        /// <param name="appVersion">Application version</param>
        public IXConnFactory(String url, String appName, String appVersion)
            : base(url, appName, appVersion)
        {
        }

        private void internalCreateConnection(IXAuthentication auth, BAsyncResult<IXConnection> asyncResult)
        {
            // Check version
            if (MajorVersion < 9)
            {
                BException ex = new BException(BExceptionC.CONNECTION_TO_SERVER_FAILED,
                        "Received server version " + Version + ". At least server version 9.00.000 is required.");
                asyncResult(null, ex);
                return;
            }

            // IX-URL, e.g. http://localhost:8084/ix-elo80/ix
            String url = connProps[PROP_URL];

            // BYPS-URL, e.g. http://localhost:8084/ix-elo80/byps
            String bypsUrl = url;
            int pos = bypsUrl.LastIndexOf("/ix");
            if (pos >= 0)
            {
                bypsUrl = bypsUrl.Substring(0, pos) + "/byps";
                if (pos + 3 < url.Length)
                {
                    bypsUrl += url.Substring(pos + 3);
                }
            }

            // timeout
            String timeoutSecondsStr = connProps[PROP_TIMEOUT_SECONDS];
            int timeoutSeconds = Convert.ToInt32(timeoutSecondsStr != null && timeoutSecondsStr.Length != 0 ? timeoutSecondsStr : "120");

            // #reverse connections
            String reverseConnsStr = connProps[NB_OF_REVERSE_CNNS];
            int nbOfReverseConnections = Convert.ToInt32(reverseConnsStr != null && reverseConnsStr.Length != 0 ? reverseConnsStr : "1");

            // Wire, transport, client
            IXWireClient wire = new IXWireClient(bypsUrl, 0, timeoutSeconds);
            BTransportFactory transportFactory = new HTransportFactoryClient(BApiDescriptor_Indexserver.instance, wire, nbOfReverseConnections);
            BClient_Indexserver bclient = BClient_Indexserver.createClient(transportFactory);

            // Authentication
            bclient.setAuthentication(auth);

            // IXConnection
            IXConnection conn = new IXConnection(this, bclient, auth, url, connProps, sessOpts);

            BAsyncResult<bool> outerResult = (ignored, e) =>
            {
                if (e != null)
                {
                    asyncResult(conn, e);
                }
                else if (this.CONST != null)
                {
                    asyncResult(conn, e);
                }
                else
                {
                    // Read constants
                    BAsyncResult<IXServicePortC> constResult = (CONST, ex) =>
                    {
                        this.CONSTVal = CONST;
                        asyncResult(conn, ex);
                    };

                    conn.getCONST(constResult);
                }
            };

            // Start client
            bclient.start(outerResult, false);
        }

        /// <summary>
        /// Create a connection for the given user. The required ClientInfo object 
        /// with language, country and timezone is created by 
        /// makeDefaultClientInfo.
        /// <param name="userName"> User name.</param>
        /// <param name="userPwd"> Plain text user password.</param>
        /// <param name="computerName"> Computer name.</param>
        /// <param name="runAs"> User name or ID if this should be a run-as connection.</param>
        /// <returns>IXConnection object.</returns>
        /// @throws java.rmi.RemoteException
        /// </summary>
        public IXConnection Create(String userName, String userPwd,
                String computerName, String runAs)
        {
            ClientInfo ci = MakeDefaultClientInfo();
            return Create(ci, userName, userPwd, computerName, runAs);
        }

        /// <summary>
        /// Create aconnection for the given user.
        /// <param name="ci"> ClientInfo object with language, country and timezone</param>
        /// <param name="userName"> User name.</param>
        /// <param name="userPwd"> Plain text user password.</param>
        /// <param name="computerName"> Computer name.</param>
        /// <param name="runAs"> User name or ID if this should be a run-as connection.</param>
        /// <returns>IXConnection object.</returns>
        /// @throws java.rmi.RemoteException
        /// </summary>
        public virtual IXConnection Create(ClientInfo ci, String userName, String userPwd,
                String computerName, String runAs)
        {
            if (ci == null) ci = MakeDefaultClientInfo();

            EAuthenticationType authType = runAs != null && runAs.Length != 0 ?
                EAuthenticationType.RUN_AS : EAuthenticationType.NAME_PASSWORD;

            IXAuthentication auth = new IXAuthentication_NameOrRunAsReportAs(ci, sessOpts, authType,
                userName, userPwd, computerName, runAs, false);

            BSyncResult<IXConnection> asyncResult = new BSyncResult<IXConnection>();
            internalCreateConnection(auth, BAsyncResultHelper.ToDelegate(asyncResult));
            return asyncResult.GetResult();
        }

        public virtual IXConnection Create(ClientInfo ciAdmin, String runAs)
        {
            EAuthenticationType authType = EAuthenticationType.RUN_AS;

            IXAuthentication auth = new IXAuthentication_RunAsFromTicket(ciAdmin, sessOpts, authType, runAs);

            BSyncResult<IXConnection> asyncResult = new BSyncResult<IXConnection>();
            internalCreateConnection(auth, BAsyncResultHelper.ToDelegate(asyncResult));
            return asyncResult.GetResult();
        }

        public virtual IXConnection CreateAdmin(String userName, String userPwd, String computerName, String reportAs)
        {
            return CreateAdmin(null, userName, userPwd, computerName, reportAs);
        }

        public virtual IXConnection CreateAdmin(ClientInfo ci, String userName, String userPwd, String computerName, String reportAs)
        {
            if (ci == null) ci = MakeDefaultClientInfo();

            EAuthenticationType authType = EAuthenticationType.REPORT_AS;

            IXAuthentication auth = new IXAuthentication_NameOrRunAsReportAs(ci, sessOpts, authType,
                userName, userPwd, computerName, reportAs, true);

            BSyncResult<IXConnection> asyncResult = new BSyncResult<IXConnection>();
            internalCreateConnection(auth, BAsyncResultHelper.ToDelegate(asyncResult));
            return asyncResult.GetResult();
        }

        public virtual IXConnection CreateSso(String computerName)
        {
            return CreateSso(null, computerName);
        }

        public virtual IXConnection CreateSso(ClientInfo ci, String computerName)
        {
            if (ci == null) ci = MakeDefaultClientInfo();

            EAuthenticationType authType = EAuthenticationType.SSO;

            IXAuthentication auth = new IXAuthentication_SSO(ci, sessOpts, authType, computerName);

            BSyncResult<IXConnection> asyncResult = new BSyncResult<IXConnection>();
            internalCreateConnection(auth, BAsyncResultHelper.ToDelegate(asyncResult));
            return asyncResult.GetResult();
        }

        public virtual IXConnection CreateFromTicket(ClientInfo ci)
        {
            EAuthenticationType authType = EAuthenticationType.FROM_TICKET;

            IXAuthentication auth = new IXAuthentication_FromTicket(ci, sessOpts, authType);

            BSyncResult<IXConnection> asyncResult = new BSyncResult<IXConnection>();
            internalCreateConnection(auth, BAsyncResultHelper.ToDelegate(asyncResult));
            return asyncResult.GetResult();

        }

        public String Version
        {
            get
            {
                if (versionValue == null)
                {
                    versionValue = readStatusPage(connProps[PROP_URL], "Version");
                }
                return versionValue;
            }
        }

        public int MajorVersion
        {
            get
            {
                if (majorVersionValue == 0)
                {
                    String version = Version;
                    if (version != null)
                    {
                        int p = version.IndexOf('.');
                        majorVersionValue = p >= 0 ? Convert.ToInt32(version.Substring(0, p)) : 0;
                    }
                }
                return majorVersionValue;
            }
        }

        private int majorVersionValue;

        private String versionValue;

        internal static String readStatusPage(String url, String key)
        {
            String urlStatus = url + "?cmd=status&mode=txt";
            Stream strm = null;
            StreamReader rd = null;
            HttpWebRequest req = null;
            HttpWebResponse resp = null;
            Dictionary<String, String> map = new Dictionary<String, String>(20);

            if (WebRequest.DefaultWebProxy != null)
            {
                WebRequest.DefaultWebProxy.Credentials = CredentialCache.DefaultCredentials;
            }

            try
            {
                req = (HttpWebRequest)HttpWebRequest.Create(urlStatus);
                req.Credentials = CredentialCache.DefaultCredentials;

                resp = (HttpWebResponse)req.GetResponse();

                strm = resp.GetResponseStream();

                rd = new StreamReader(strm);
                String line = null;
                while ((line = rd.ReadLine()) != null)
                {
                    String[] nv = line.Split(new char[] { '=' });
                    if (nv.Length != 2) continue;
                    map.Add(nv[0], nv[1]);
                }
            }
            finally
            {
                if (rd != null) rd.Close();
                if (strm != null) strm.Close();
                if (resp != null) resp.Close();
            }

            String ret = null;
            map.TryGetValue(key, out ret);
            return ret;
        }

    }

    internal class IXAuthentication_NameOrRunAsReportAs : IXAuthentication
    {
        private readonly String userName;
        private readonly String userPwd;
        private readonly String computerName;
        private readonly String runAs;
        private readonly bool reportAs;

        internal IXAuthentication_NameOrRunAsReportAs(
            ClientInfo clientInfo, IXProperties sessOpts, EAuthenticationType authType,
            String userName, String userPwd, String computerName, String runAs, bool reportAs)
            : base(clientInfo, sessOpts, authType)
        {
            this.userName = userName;
            this.userPwd = userPwd;
            this.computerName = computerName;
            this.runAs = runAs;
            this.reportAs = reportAs;
        }

        protected override void internalAuthenticate(BClient_Indexserver client, BAsyncResult<bool> asyncResult)
        {
            BAsyncResult<LoginResult> outerResult = (loginResult, ex) =>
                {
                    this.setLoginResult(loginResult);
                    asyncResult(false, ex);
                };

            try
            {
                String encrPwd = encryptPassword(userPwd);
                if (reportAs)
                {
                    client.IXServicePortIF.loginAdmin(userName, encrPwd, computerName, runAs, outerResult);
                }
                else
                {
                    client.IXServicePortIF.login(userName, encrPwd, computerName, runAs, outerResult);
                }
            }
            catch (Exception e)
            {
                asyncResult(false, e);
            }

        }
    }

    internal class IXAuthentication_RunAsFromTicket : IXAuthentication
    {
        private readonly ClientInfo ciAdmin;
        private readonly String runAs;

        internal IXAuthentication_RunAsFromTicket(
            ClientInfo clientInfo, IXProperties sessOpts, EAuthenticationType authType, String runAs)
            : base(clientInfo, sessOpts, authType)
        {
            ciAdmin = new ClientInfo();
            ciAdmin.ticket = clientInfo.ticket;
            ciAdmin.language = clientInfo.language;
            ciAdmin.country = clientInfo.country;
            ciAdmin.timeZone = clientInfo.timeZone;
            this.runAs = runAs;
        }

        protected override void internalAuthenticate(BClient_Indexserver client, BAsyncResult<bool> asyncResult)
        {
            client.IXServicePortIF.login("", "", "", runAs,
                (loginResult, ex) =>
                {
                    this.setLoginResult(loginResult);
                    asyncResult(false, ex);
                });
        }
    }

    internal class IXAuthentication_FromTicket : IXAuthentication
    {
        internal IXAuthentication_FromTicket(
            ClientInfo clientInfo, IXProperties sessOpts, EAuthenticationType authType)
            : base(clientInfo, sessOpts, authType)
        {
        }

        protected override void internalAuthenticate(BClient_Indexserver client, BAsyncResult<bool> asyncResult)
        {
            // Do not use the session properties initialized in the constructor of IXConnFactory.
            // The options set by the application that created the ticked should not be overwritten. 
            // Especially, the options ixUrlBase and docUrlBase must not be changed to a relative URL.

            IXProperties sessOpts2 = new IXProperties();

            client.IXServicePortIF.getSessionFromTicket(SessionOptionsC.SESSION_FROM_AM_ADD,
                (loginResult, ex) =>
                {
                    this.setLoginResult(loginResult);
                    asyncResult(false, ex);
                });
        }

        public override bool isReloginException(BClient client, Exception e, int typeId)
        {
            if (e.ToString().IndexOf("[ELOIX:" + IXExceptionC.INVALID_SESSION) >= 0)
            {
                // Wenn das Ticket nicht mehr gültig ist, dann kann ich es durch ein re-login nicht erneuern. 
                // Denn Name/Passwort sind unbekannt. 
                return false;
            }
            else {
                return base.isReloginException(client, e, typeId);
            }
        }
    }

    internal class IXAuthentication_SSO : IXAuthentication
    {
        private readonly String computerName;

        internal IXAuthentication_SSO(ClientInfo clientInfo, IXProperties sessOpts, EAuthenticationType authType, String computerName)
            : base(clientInfo, sessOpts, authType)
        {
            this.computerName = computerName;
        }

        protected override void internalAuthenticate(BClient_Indexserver client, BAsyncResult<bool> asyncResult)
        {
            // Aktuelle ClientInfo bereitstellen, wg. Landessprache, Zeitzone usw.
            ClientInfo ci = getLoginResult().clientInfo;

            // Verbindungsobjekt für GET-Request
            IXWireClient wire = (IXWireClient)client.getTransport().getWire();

            HttpWebResponse resp = null;

            try
            {
                String loginServletUrl = wire.getUrlForAuthentication();

                long negotiatedVersion = client.getTransport().getProtocol().negotiatedVersion;
                long negotiatedBypsVersion = client.getTransport().getProtocol().negotiatedBypsVersion;

                // Schreibe diese 9er Version für die Verbindung zu IX 9.0.
                // Weil bei ELO 9 ein String-Vergleich gemacht wird, wäre sonst die Version 10 kleiner als die Version 9
                loginServletUrl += "?streamversion=" + BVersioning.stringToLong("9.99.0.0");

                loginServletUrl += "&bstreamversion=" + BVersioning.longToString(negotiatedVersion);
                loginServletUrl += "&bversion=" + negotiatedBypsVersion;

                loginServletUrl += "&responseformat=byps-binary";
                if (ci.language != null)
                {
                    loginServletUrl += "&language=" + ci.language;
                }
                if (ci.timeZone != null)
                {
                    loginServletUrl += "&timezone=" + HttpUtility.UrlEncode(ci.timeZone);
                }
                if (ci.country != null)
                {
                    loginServletUrl += "&country=" + ci.country;
                }
                if (ci.callId != null)
                {
                    loginServletUrl += "&callid=" + HttpUtility.UrlEncode(ci.callId);
                }
                if (computerName != null)
                {
                    loginServletUrl += "&computerName=" + HttpUtility.UrlEncode(computerName);
                }

                // Sitzungskennung übergeben.
                // Sie wird direkt verworfen und es wird eine neue erstellt. 
                loginServletUrl += "&sessionid=" + HttpUtility.UrlEncode(client.getTransport().getSessionId());

                if (WebRequest.DefaultWebProxy != null)
                {
                    WebRequest.DefaultWebProxy.Credentials = CredentialCache.DefaultCredentials;
                }

                HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(loginServletUrl);
                req.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                req.Credentials = CredentialCache.DefaultCredentials;

                //http://blogs.msdn.com/buckh/archive/2004/07/28/199706.aspx

                //CredentialCache credCache = new CredentialCache();
                //credCache.Add(new Uri(loginServletUrl), "NTLM",
                //              CredentialCache.DefaultNetworkCredentials);
                //req.Credentials = credCache;

                resp = (HttpWebResponse)req.GetResponse();

                if (resp.StatusCode != HttpStatusCode.OK)
                {
                    asyncResult(false, new BException((int)resp.StatusCode, "HTTP Status " + resp.StatusCode));
                }

                Stream responseStream = resp.GetResponseStream();
                ByteBuffer buf = BWire.bufferFromStream(responseStream, false);

                BMessageHeader header = new BMessageHeader();
                header.read(buf);

                // Neue Sitzungs-ID übernehmen
                if (!header.targetId.isZero())
                {
                    client.getTransport().setTargetId(header.targetId);
                    client.getTransport().setSessionId(header.sessionId);
                }

                BInput bin = client.getTransport().getInput(header, buf);
                LoginResult loginResult = (LoginResult)bin.load();

                this.setLoginResult(loginResult);
                asyncResult(false, null);
            }
            catch (Exception e)
            {
                asyncResult(false, e);
            }
            finally
            {
                if (resp != null) resp.Close();
            }
        }
    }


}
