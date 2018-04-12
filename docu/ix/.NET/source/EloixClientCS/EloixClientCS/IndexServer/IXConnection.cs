using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using byps;
using EloixClient.IndexServer.feed;

namespace EloixClient.IndexServer
{
    public class IXConnection : IXConnectionBase, IDisposable
    {
        private IXConnFactory iXConnFactory;
        public BClient_Indexserver bclient; // FIXME
        private IXAuthentication auth;
        private string url;
        private IXProperties connPropsVal;
        private IXProperties sessionOptionsVal;
        private IXCachedConnIXServicePortIF ixVal;
        private IXServicePortC constVal;
        private EventBusApi eventBusApiVal;
        private Boolean disposed;

        public IXConnection(IXConnFactory iXConnFactory, 
            BClient_Indexserver bclient, IXAuthentication auth, string url, 
            IXProperties connProps, IXProperties sessOpts)
        {
            this.iXConnFactory = iXConnFactory;
            this.bclient = bclient;
            this.auth = auth;
            this.url = url;
            this.connPropsVal = connProps;
            this.sessionOptionsVal = sessOpts;
            this.ixVal = new IXCachedConnIXServicePortIF(bclient.getTransport(), connProps);
            this.disposed = false;
        }

        /// <summary>
        /// Get IndexServer interface object.
        /// </summary>
        public virtual IXConnIXServicePortIF_2 Ix
        {
            get { return ixVal; }
        }

        /// <summary>
        /// Get the IXConnLogin object.
        /// </summary>
        /// <returns>IXConnLogin object.</returns>
        public virtual LoginResult LoginResult
        {
            get
            {
                return auth.getLoginResult();
            }
        }

        /// <summary>
        /// Get the user ID
        /// </summary>
        public virtual int UserId
        {
            get
            {
                return LoginResult.user.id;
            }
        }

        /// <summary>
        /// Get the user name.
        /// </summary>
        public virtual String UserName
        {
            get
            {
                return LoginResult.user.name;
            }
        }

        /// <summary>
        /// Get the connection properties.
        /// </summary>
        public virtual IXProperties ConnProperties
        {
            get { return connPropsVal; }
        }

        /// <summary>
        /// Indexerver URL
        /// </summary>
        public virtual String EndpointUrl
        {
            get { return url; }
        }

        /// <summary>
        /// Get the session options.
        /// </summary>
        public virtual IXProperties SessionOptions
        {
            get { return sessionOptionsVal; }
        }

        /// <summary>
        /// Get IndexServer version number.
        /// </summary>
        public virtual String Version
        {
            get { return IXConnFactory.readStatusPage(this.url, "Version"); }
        }

        /// <summary>
        /// Get IndexServer version and build number.
        /// </summary>
        public String ImplVersion
        {
            get { return Version + "." + IXConnFactory.readStatusPage(this.url, "Build"); }
        }

        /// <summary>
        /// Get IndexServer SOAP interface version.
        /// </summary>
        public String InterfaceVersion
        {
            get { return IXConnFactory.readStatusPage(this.url, "InterfaceVersion"); }
        }

        /// <summary>
        /// Return the negotiated stream version.
        /// </summary>
        public String StreamVersion
        {
            get { return Version_longToString(bclient.getTransport().getProtocol().negotiatedVersion); }
        }

        /// <summary>
        /// Get version of this client library.
        /// </summary>
        public String ClientVersion
        {
            get { return IXServicePortC.STREAM_VERSION; }
        }

        /// <summary>
        /// Get the current time of the server (local timezone).
        /// </summary>
        public DateTime ServerTime
        {
            get
            {
                String localIso = IXConnFactory.readStatusPage(this.url, "Current.time");

                int p = localIso.IndexOf("+");
                int utcDiff = 0;
                if (p >= 0)
                {
                    String s = localIso.Substring(p, 3);
                    utcDiff = Convert.ToInt32(s);
                    localIso = localIso.Substring(0, p);
                }

                DateTime dt = DateTime.Parse(localIso);
                dt = dt.AddHours(-utcDiff);

                dt = dt.ToLocalTime();
                return dt;
            }
        }

        /// <summary>
        /// Get constants object.
        /// </summary>
        public virtual IXServicePortC CONST
        {
            get
            {
                if (constVal == null)
                {
                    constVal = bclient.IXServicePortIF.getConstants();
                }
                return constVal;
            }
        }

        internal virtual void getCONST(BAsyncResult<IXServicePortC> constResult)
        {
            if (constVal == null)
            {
                BAsyncResult<IXServicePortC> outerResult = (cval, ex) =>
                {
                    if (ex == null) this.constVal = cval;
                    constResult(cval, ex);
                };

                ixVal.getConstants(outerResult);
            }
            else
            {
                constResult(constVal, null);
            }
        }

        /// <summary>
        /// Convert ISO time into DateTime object.
        /// </summary>
        /// <param name="isoDate"></param>
        /// <returns>Localized DateTime object</returns>
        /// <seealso cref="StaticIsoToDate"/>
        public virtual DateTime IsoToDate(String isoDate)
        {
            String tz = LoginResult.clientInfo.timeZone;
            bool isUTC = tz != null && (tz.Equals("UTC") || tz.Equals("GMT"));
            return StaticIsoToDate(isoDate, isUTC);
        }

        /// <summary>
        /// Convert ISO time into DateTime object. 
        /// </summary>
        /// <param name="isoDate">ISO date</param>
        /// <param name="isUtc">If true, ISO date is assumed to be an UTC date, 
        /// convert it into the local time zone before returning the date object.</param>
        /// <returns>Localized DateTime object</returns>
        /// <remarks>
        /// .NET 2.0 programs should supply UTC in the ClientInfo object.
        /// There is no way to get a Java compatible timezone ID. 
        /// </remarks>
        public static DateTime StaticIsoToDate(String isoDate, bool isUtc)
        {
            if (isoDate == null || isoDate.Length == 0) return new DateTime(0);

            isoDate = isoDate.Replace(" ", "");
            isoDate = isoDate.Replace(".", "");
            isoDate = isoDate.Replace("-", "");
            isoDate = isoDate.Replace(":", "");

            int y = isoDate.Length >= 4 ? Convert.ToInt32(isoDate.Substring(0, 4)) : 0;
            int m = isoDate.Length >= 6 ? Convert.ToInt32(isoDate.Substring(4, 2)) : 0;
            int d = isoDate.Length >= 8 ? Convert.ToInt32(isoDate.Substring(6, 2)) : 0;
            int h = isoDate.Length >= 10 ? Convert.ToInt32(isoDate.Substring(8, 2)) : 0;
            int i = isoDate.Length >= 12 ? Convert.ToInt32(isoDate.Substring(10, 2)) : 0;
            int s = isoDate.Length >= 14 ? Convert.ToInt32(isoDate.Substring(12, 2)) : 0;
            DateTime dt = new DateTime(y, m, d, h, i, s);

            if (isUtc) dt = dt.ToLocalTime();
            return dt;
        }

        /// <summary>
        /// Convert DateTime object into ISO date.
        /// </summary>
        /// <param name="dt1">DateTime object in local timezone</param>
        /// <returns>ISO date in UTC timezone</returns>
        /// <seealso cref="StaticDateToIso"/>
        public virtual String DateToIso(DateTime dt1)
        {
            String tz = LoginResult.clientInfo.timeZone;
            bool isUTC = tz != null && (tz.Equals("UTC") || tz.Equals("GMT"));
            return StaticDateToIso(dt1, isUTC);
        }

        /// <summary>
        /// Convert DateTime object into ISO date.
        /// </summary>
        /// <param name="dt1">DateTime object</param>
        /// <param name="toUtc">True, if DateTime object is in the local time zone 
        /// and has to be converted to UTC before formatting as ISO date.</param>
        /// <returns>ISO date in UTC timezone</returns>
        public static String StaticDateToIso(DateTime dt1, bool toUtc)
        {
            DateTime dt = toUtc ? dt1.ToUniversalTime() : dt1;
            String s = "";
            if (dt.Ticks != 0)
            {
                s = dt.ToString("yyyyMMddHHmmss");
            }
            return s;
        }

        /// <summary>
        /// Upload file to given URL.
        /// </summary>
        /// <param name="url">Destination URL.</param>
        /// <param name="fileName">Source file.</param>
        /// <returns></returns>
        public virtual String Upload(String url, String fileName)
        {
            FileInfo fileInfo = new FileInfo(fileName);
            return this.Upload(url, new FileStream(fileName, FileMode.Open, FileAccess.Read), "", fileInfo.Length);
        }

        /// <summary>
        /// Upload stream to given URL.
        /// </summary>
        /// <param name="url">Destination URL</param>
        /// <param name="fstream">Stream</param>
        /// <param name="contentType">Content type</param>
        /// <param name="contentLength">Content length</param>
        /// <returns></returns>
        public virtual String Upload(String url, Stream fstrm, String contentType, long contentLength)
        {
            String[] params1 = makeRawStreamServiceParamsFromUrl(url);
            BContentStream cs = new BContentStreamWrapper(fstrm, contentType, contentLength);
            String ret = bclient.RawStreamService.upload(params1, cs);
            return ret;
        }

        /// <summary>
        /// Download file from given URL.
        /// </summary>
        /// <param name="url">Source URL.</param>
        /// <param name="file">Destination file.</param>
        public virtual void Download(String url, String file)
        {
            Download(url, 0, -1, file);
        }

        /// <summary>
        /// Download file from given URL.
        /// </summary>
        /// <param name="url">Source URL.</param>
        /// <param name="offset">Start download from byte offset.</param>
        /// <param name="length">Download this number of bytes. Set as -1 to download entire file.</param>
        /// <param name="file">Destination file.</param>
        public virtual void Download(String url, int offset, long length, String file)
        {
            Stream istrm = null;
            Stream fstrm = null;
            try
            {
                istrm = Download(url, offset, length);
                fstrm = new FileStream(file, FileMode.CreateNew, FileAccess.Write);
                byte[] buf = new byte[10 * 1000];
                int len = 0;
                while ((len = istrm.Read(buf, 0, buf.Length)) != 0)
                {
                    fstrm.Write(buf, 0, len);
                }
            }
            finally
            {
                if (istrm != null) istrm.Close();
                if (fstrm != null) fstrm.Close();
            }
        }

        /// <summary>
        /// Download a stream from the given URL
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="offset">Start download from byte offset.</param>
        /// <param name="length">Download this number of bytes. Set as -1 to download entire file.</param>
        /// <returns></returns>
        public virtual Stream Download(String url, int offset, long length)
        {
            if (offset != 0) url += "&offset=" + offset;
            if (length != -1) url += "&length=" + length;
            String[] params1 = makeRawStreamServiceParamsFromUrl(url);
            return bclient.RawStreamService.download(params1);
        }

        /// <summary>
        /// Encrypt the given string. 
        /// </summary>
        /// <param name="s">String to encrypt.</param>
        /// <returns>RSA-encrypted string.</returns>
        public virtual String EncryptPassword(String s)
        {
            return auth.encryptPassword(s);
        }

        /// <summary>
        /// Logout
        /// </summary>
        public virtual void Logout()
        {
            try
            {
                if (AuthenticationType != EAuthenticationType.FROM_TICKET)
                {
                    try
                    {
                        bclient.IXServicePortIF.logout();
                    }
                    catch (Exception)
                    {
                    }
                }
                bclient.done();

                LoginResult.clientInfo.ticket = "";
            }
            catch (Exception) { }

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                Logout();
                iXConnFactory = null;
                auth = null;
                url = null;
                connPropsVal = null;
                sessionOptionsVal = null;
                ixVal = null;
                constVal = null;
                eventBusApiVal = null;
                bclient = null;
            }
            disposed = true;
        }

        /// <summary>
        /// Destructor, cleans unmanaged objects
        /// </summary>
        ~IXConnection()
        {
            Dispose(false);
        }

        /// <summary>
        /// Extracts the file extension from the given file name.
        /// </summary>
        /// <param name="fileName">File name.</param>
        /// <returns>Extension without dot.</returns>
        public String GetFileExt(String fileName)
        {
            String ext = "";
            bool existsFile = (!string.IsNullOrEmpty(fileName));

            if (existsFile)
            {
                int p = fileName.LastIndexOf(".");
                if (p >= 0) ext = fileName.Substring(p + 1, fileName.Length - p - 1);
            }

            return ext;
        }

        private static MD5CryptoServiceProvider _MD5Service = new MD5CryptoServiceProvider();
        private static char[] HEXCHARS = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        /// <summary>
        /// Computes the MD5 hash of the given file.
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <returns>MD5 hash as String</returns>
        public virtual String GetFileMd5(String fileName)
        {
            System.IO.FileInfo testFile = new System.IO.FileInfo(fileName);
            System.IO.FileStream fstrm = null;
            try
            {
                fstrm = testFile.OpenRead();
                byte[] md5 = _MD5Service.ComputeHash(fstrm);
                char[] s = new char[32];
                for (int i = 0; i < md5.Length; i++)
                {
                    int b = (int)md5[i];
                    s[2 * i] = HEXCHARS[(b >> 4) & 0x0F];
                    s[2 * i + 1] = HEXCHARS[b & 0x0F];
                }
                return new String(s);
            }
            finally
            {
                if (fstrm != null)
                {
                    fstrm.Close();
                }
            }
        }

        /// <summary>
        /// Get the name of the database engine (MSSQL, ORACLE, DB2, UNKNOWN)
        /// </summary>
        public String DatabaseEngine
        {
            get
            {
                return auth.getDatabaseEngine();
            }
        }

        /// <summary>
        /// This function truncates s to the length of max.
        /// </summary>
        /// <param name="s">String to be truncated.</param>
        /// <param name="max">Database column width from a member length value of a constant class.</param>
        /// <returns>Truncated String or s.</returns>
        /// <remarks>
        /// <para>
        /// If the String s is not truncated, the return value is s itself. 
        /// Thus, checking s == truncate(s) is sufficient to check, wether the 
        /// s can be stored - the String.Equals function need not to be called.  
        /// </para><para>
        /// Example:<br>
        /// <code>
        /// IXConnection conn = ...
        /// Sord sord = ...
        /// boolean canStore = sord.name == conn.Truncate(sord.name, ix.CONST.SORD.lnName);
        /// </code>
        /// </para>
        /// </remarks>
        public String Truncate(String s, int max)
        {
            if (s != null && s.Length != 0)
            {
                if (s.Length > max)
                {
                    s = s.Substring(0, max);
                }
                if (DatabaseEngine.Equals("DB2"))
                {
                    // IX-Versions befor 8.0 returned byte length / 2
                    if (Version.CompareTo("8.0") < 0)
                    {
                        max *= 2;
                    }
                    s = truncateUtf8(s, max);
                }
            }
            return s;
        }

        private static String truncateUtf8(String s, int max)
        {
            if (s.Length > (max / 4))
            { // maximal 4 Bytes pro Zeichen.
                byte[] utf8 = Encoding.UTF8.GetBytes(s);
                if (utf8.Length > max)
                {
                    int i = max - 1;

                    // 0xxxxxxx
                    // 110xxxxx 10xxxxxx
                    // 1110xxxx 10xxxxxx 10xxxxxx
                    // 11110xxx 10xxxxxx 10xxxxxx 10xxxxxx

                    if ((utf8[i] & 0x80) != 0)
                    { // != 0xxxxxxx
                        while ((utf8[i] & 0xC0) == 0x80) i--; // 10xxxxxx Folge-Bytes
                        i--; // sollte ein Start-Byte sein: 110xxxxx oder 1110xxxx oder 11110xxx
                    }

                    s = Encoding.UTF8.GetString(utf8, 0, i + 1);
                }
            }
            return s;
        }

        public EventBusApi EventBusApi
        {
            get
            {
                if (eventBusApiVal == null)
                {
                    eventBusApiVal = new EventBusApi(this, this.bclient);

                    auth.addListener((client, e) =>
                    {
                        if (e == null)
                        {
                            eventBusApiVal.onRelogin();
                        }
                    });

                    bclient.startR();
                }
                return eventBusApiVal;
            }
        }

        /// <summary>
        /// Creates new connection for a "run as" user, running on the already existent ticket.
        /// </summary>
        /// <param name="runAsName">User name for which the connection is created</param>
        /// <returns>Connection object</returns>
        public IXConnection createConnectionForUser(String runAsName)
        {
            return iXConnFactory.Create(LoginResult.clientInfo, runAsName);
        }

        /// <summary>
        /// Cache of DocMask objects - Keywording forms.
        /// </summary>
        public DocMaskCache DocMaskCache
        {
            get { return ixVal.docMaskCache; }
        }

        /// <summary>
        /// Cache of Keyword objects
        /// </summary>
        public KeywordCache KeywordCache
        {
            get { return ((IXCachedConnIXServicePortIF)ixVal).keywordCache; }
        }

        /// <summary>
        /// Cache of SordType objects
        /// </summary>
        public SordTypeCache SordTypeCache
        {
            get { return ((IXCachedConnIXServicePortIF)ixVal).sordTypeCache; }
        }

        /// <summary>
        /// Cache of ColorData objects
        /// </summary>
        public ColorDataCache ColorDataCache
        {
            get { return ((IXCachedConnIXServicePortIF)ixVal).colorCache; }
        }

        public CounterInfoCache CounterInfoCache
        {
            get { return ((IXCachedConnIXServicePortIF)ixVal).counterCache; }
        }

        /// <summary>
        /// Returns true, if a login was successfully and the ticket is still valid.
        /// </summary>
        public override bool Valid
        {
            get { return !auth.isExpired(); }
        }

        /// <summary>
        /// This function is called by a timer thread to cleanup internal caches.
        /// </summary>
        public override void OnCleanup()
        {
            ixVal.OnCleanup();
        }

        /// <summary>
        /// Get the map of encrypted passwords for the document encryption.
        /// </summary>
        public virtual IXProperties EncrPasswords
        {
            get { return auth.getEncrPasswords(); }
        }

        /// <summary>
        /// Authentication type.
        /// </summary>
        public EAuthenticationType AuthenticationType 
        {
            get { return auth.authType; }
        }

        /**
         * Convert a version number in integer representation into a string.
         * @param nver
         * @return
         */
        protected static String Version_longToString(long nver)
        {
            long[] arr = new long[4];
            for (int i = 0; i < 4; i++)
            {
                int ndigits = (i == 0) ? 1000000 : 10000;
                int pver = (int)(nver % ndigits);
                arr[i] = pver;
                nver /= ndigits;
            }

            String s = arr[3].ToString() 
                + "." + arr[2].ToString("D2")
                + "." + arr[1].ToString("D3")
                + "." + arr[0].ToString("D3");
            return s;
        }

        private String[] makeRawStreamServiceParamsFromUrl(String url)
        {
            int p = url.IndexOf('?') + 1;
            String[] params1 = url.Substring(p).Split(new char[] { '&' });
            for (int i = 0; i < params1.Length; i++)
            {
                params1[i] = HttpUtility.UrlDecode(params1[i], Encoding.UTF8);
            }
            return params1;
        }

        /// <summary>
        /// Add callback interface that is called if authentication is renewed.
        /// </summary>
        /// <param name="lsn">Listener object to be called, when re-login is performed.</param>
        public void addAuthenticationListener(IXAuthenticationListener lsn)
        {
            auth.addListener(lsn);
        }

        /// <summary>
        /// Remove callback interface for authentication. Remove callback interface for authentication. 
        /// </summary>
        /// <param name="lsn">Listener object to be called, when re-login is performed.</param>
        public void removeAuthenticationListener(IXAuthenticationListener lsn)
        {
            auth.removeListener(lsn);
        }


        /// <summary>
        /// Feed service interface.
        /// Read-only.
        /// </summary>
        public FeedServiceAuth FeedService
        {
            get
            {
                return bclient.FeedService;
            }
        }

        /// <summary>
        /// Set notification callback interface for document feed events. 
        /// </summary>
        /// <param name="feedNotification">Serivce interface</param>
        public void setFeedNotification(BSkeleton_FeedNotification feedNotification)
        {
            EventBusApi dummy = EventBusApi;
            bclient.addRemote(feedNotification);
        }
    }
}
