using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using byps;

namespace EloixClient.IndexServer
{
  /// <summary>
  /// Base class for IndexServer connection factories.
  /// </summary>
    public abstract class IXConnFactoryBase
    {
        /// <summary>
        /// Property name for IndexServer URL: &gt;connection.url&gt;. 
        /// This value is required. Example: http://server:8080/ix-Archive/ix.
        /// </summary>
        public static readonly String PROP_URL = "connection.url";

        /// <summary>
        /// Property name for the number of connections to IndexServer used in the 
        /// connection pool: &gt;connection.nbOfCnns&gt;. This value should be 2 for 
        /// applications that use only one session to IndexServer. It should be set
        /// to the estimated number of concurrent calls for applications that use
        /// more sessions simultanously. This value is optional and defaults to 2.
        /// </summary>
        public static readonly String PROP_NB_OF_CNNS = "connection.nbOfCnns";

        /// <summary>
        /// Property name for connection timeout: &gt;connection.timeoutSeconds&gt; in 
        /// seconds.
        /// This value is optional and defaults to 120 seconds.
        /// </summary>
        public static readonly String PROP_TIMEOUT_SECONDS = "connection.timeoutSeconds";

        /// <summary>
        /// Property name for a temporary directory: &gt;connection.tempDir&gt;. 
        /// This value is optional.
        /// </summary>
        public static readonly String PROP_TEMP_DIR = "connection.tempDir";

        /// <summary>
        /// Property name for the cache lifetime of master data objects.
        /// </summary>
        /// <remarks>The default value is 600 (10 minutes).</remarks>
        public static readonly String PROP_CACHE_MASTERDATA_LIFETIME_SECONDS = "connection.cache.masterdata.lifetimeSeconds";
        /// <summary>
        /// Property name for the cache lifetime of content objects (e.g. indexing information).
        /// </summary>
        /// <remarks>The default value is 0, which means that no caching is made for indexing information.</remarks>
        public static readonly String PROP_CACHE_CONTENT_LIFETIME_SECONDS = "connection.cache.content.lifetimeSeconds";

        /// <summary>
        /// Number of reverse connections.
        /// </summary>
        /// <remarks>This is the number of long-polls opened to the server in order to receive events.</remarks>
        public static readonly String NB_OF_REVERSE_CNNS = "serverR.nbOfCnns";

        /// <summary>
        /// Connection properties.
        /// </summary>
        protected IXProperties connProps;

        /// <summary>
        /// Default connection properties.
        /// </summary>
        protected static IXProperties defaultProps;

        /// <summary>
        /// Session options.
        /// <see>SessionOptions SessionOptions</see>
        /// </summary>
        protected IXProperties sessOpts;

        /// <summary>
        /// Timer object used to trigger the OnCleanup events
        /// </summary>
        protected Timer timer;

        protected IXServicePortC CONSTVal;

        /// <summary>
        /// If true, a new IXClient object is created for a new connection.
        /// </summary>
        protected bool[] createNewIxClient = new bool[] { false };

        /// <summary>
        /// Initialize default connection properties.
        /// </summary>
        protected static void InitializeStatic()
        {
            if (defaultProps != null) return;
            IXProperties props = new IXProperties();
            props[PROP_NB_OF_CNNS] = "100";
            props[PROP_TIMEOUT_SECONDS] = "600";
            defaultProps = props;
        }

        /// <summary>
        /// Constructor. The supplied connection properties are used to create the 
        /// internal IXClient object. They are passed to each IXConnection object 
        /// created by one of the create function. The given session options are passed
        /// to the IXConnLogin objects instanciated in the create functions. The 
        /// functions createConnProperties and createSessionOptions. 
        /// can help to create the properties collections.
        /// <param name="props"> Connection properties. </param>
        /// <param name="sessOpts"> Session options. </param>
        /// <see>#createConnProps createConnProps</see>
        /// <see>#createSessionOptions createSessionOptions</see>
        /// </summary>
        public IXConnFactoryBase(IXProperties props, IXProperties sessOpts)
        {
            this.connProps = props;
            this.sessOpts = sessOpts;
            init();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="url">IndexServer URL</param>
        /// <param name="appName"></param>
        /// <param name="appVersion"></param>
        public IXConnFactoryBase(String url, String appName, String appVersion)
        {
            this.connProps = CreateConnProperties(url);
            this.sessOpts = CreateSessionOptions(appName, appVersion);
            init();
        }

        /// <summary>
        /// Create a connection properties object. 
        /// <param name="url"> URL to IndexServer</param>
        /// <returns>Properties object.</returns>
        /// <see>#PROP_URL PROP_URL</see>
        /// </summary>
        public static IXProperties CreateConnProperties(String url)
        {
            IXProperties props = new IXProperties();
            props[PROP_URL] = url;
            return props;
        }

        /// <summary>
        /// Create a connection properties object.
        /// <param name="url"> URL to IndexServer</param>
        /// <param name="nbOfCnns"> Size of connection pool with connections to IndexServer.</param>
        /// <param name="timeoutSeconds"> </param>
        /// <returns>Properties object.</returns>
        /// <see>#PROP_URL PROP_URL</see>
        /// <see>#PROP_NB_OF_CNNS PROP_NB_OF_CNNS</see>
        /// <see>#PROP_TIMEOUT_SECONDS PROP_TIMEOUT_SECONDS</see>
        /// </summary>
        public static IXProperties CreateConnProperties(String url, int nbOfCnns, int timeoutSeconds)
        {
            IXProperties props = new IXProperties();
            props[PROP_URL] = url;
            props[PROP_NB_OF_CNNS] = Convert.ToString(nbOfCnns);
            props[PROP_TIMEOUT_SECONDS] = Convert.ToString(timeoutSeconds);
            return props;
        }

        /// <summary>
        /// Creates a property collection that contains session options. The client
        /// application type property (SessionOptionsC.CLIENT_APP_TYPE)
        /// is set to SessionOptionsC.TYPE_PARTNER_APPLICATION.
        /// <param name="appName">Application name.</param>
        /// <param name="appVersion">Application version.</param>
        /// <returns>Properties object.</returns>
        /// <see>SessionOptions SessionOptions</see>
        /// </summary>
        public static IXProperties CreateSessionOptions(String appName, String appVersion)
        {
            IXProperties props = new IXProperties();
            props[SessionOptionsC.CLIENT_APP_NAME] = appName;
            props[SessionOptionsC.CLIENT_APP_TYPE] = SessionOptionsC.TYPE_PARTNER_APPLICATION;
            props[SessionOptionsC.CLIENT_APP_VERSION] = appVersion;
            return props;
        }
        /// <summary>
        /// Connection properties.
        /// </summary>
        public virtual IXProperties ConnProperties
        {
            get { return connProps; }
        }
        /// <summary>
        /// Session options.
        /// </summary>
        public virtual IXProperties SessionOptions
        {
            get { return sessOpts; }
        }

        /// <summary>
        /// Returns the constants object.
        /// </summary>
        public virtual IXServicePortC CONST
        {
            get
            {
                if (CONSTVal == null)
                {
                    //IXConnection conn = createForConstants();
                    //CONSTVal = conn.getConst();
                }
                return CONSTVal;
            }
        }

        /// <summary>
        /// Creates a ClientInfo object and assigns the language, country 
        /// from the platform environment. The timezone is set to UTC.
        /// <returns>ClientInfo object.</returns>
        /// </summary>
        public virtual ClientInfo MakeDefaultClientInfo()
        {
            String l2c2 = CultureInfo.CurrentCulture.Name;     // e.g. "de-DE"
            ClientInfo ci = new ClientInfo();
            ci.language = l2c2.Substring(0, 2);                // e.g. "de"
            ci.country = l2c2.Substring(l2c2.Length - 2, 2);   // e.g. "DE"

            ci.timeZone = "GMT";

            return ci;
        }

        protected void init()
        {
            // Formatierungsfunktion für Fehlermeldungen
            BExceptionO.FormatMessage = formatMessage;

            // #connections (messages + streams)
            String nbConnsStr = connProps[PROP_NB_OF_CNNS];
            int nbConns = Convert.ToInt32(nbConnsStr != null && nbConnsStr.Length != 0 ? nbConnsStr : "100");

            // #reverse connections (Longpolls)
            String reverseConnsStr = connProps[NB_OF_REVERSE_CNNS];
            int nbOfReverseConnections = Convert.ToInt32(reverseConnsStr != null && reverseConnsStr.Length != 0 ? reverseConnsStr : "1");

            int totalConns = nbConns + nbOfReverseConnections;
            if (System.Net.ServicePointManager.DefaultConnectionLimit < totalConns)
            {
                System.Net.ServicePointManager.DefaultConnectionLimit = totalConns;
            }
        }

        private string formatMessage(int code, string msg, string details, Exception cause)
        {
            return "[ELOIX:" + code + "]" + "[" + msg + "]" + "[DETAILS:" + details + "]";
        }

        /// <summary>
        /// Release allocated resources.
        /// </summary>
        public void Done()
        {
        }
    }

}
