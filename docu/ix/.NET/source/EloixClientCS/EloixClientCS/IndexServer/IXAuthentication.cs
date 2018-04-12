using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using byps;

namespace EloixClient.IndexServer
{
    public abstract class IXAuthentication : BAuthentication
    {
        private LoginResult loginResult;
        private readonly IXProperties sessOpts;
        private readonly IXProperties encrPasswords;
        private RSAParameters publicKey;
        private String databaseEngine;
        private List<IXAuthenticationListener> listeners = new List<IXAuthenticationListener>();
        protected long ticketBestBefore;
        protected long ticketBestBeforeAlive;
        internal readonly EAuthenticationType authType;

        public IXAuthentication(ClientInfo clientInfo, IXProperties sessOpts, EAuthenticationType authType)
        {
            this.loginResult = new LoginResult();
            this.loginResult.clientInfo = clientInfo;
            this.loginResult.user = new UserInfo();
            this.sessOpts = sessOpts;
            this.encrPasswords = new IXProperties();
            this.authType = authType;
        }

        protected abstract void internalAuthenticate(BClient_Indexserver client, BAsyncResult<bool> asyncResult);

        public LoginResult getLoginResult()
        {
            lock (this)
            {
                return loginResult;
            }
        }

        public void setLoginResult(LoginResult lr)
        {
            lock (this)
            {
                loginResult = lr;
                setTicketValid();
            }
        }

        internal IXProperties getEncrPasswords()
        {
            return encrPasswords;
        }

        public virtual void authenticate(BClient client1, BAsyncResult<Boolean> asyncResult)
        {
            BClient_Indexserver client = (BClient_Indexserver)client1;

            BAsyncResult<bool> listenerResult = (ignored, e) => 
            {
                notifyListeners(client, e);
                asyncResult(ignored, e);
            };

            BAsyncResult<bool> outerResult = (ignored, e) =>
            {
                if (e != null)
                {
                    asyncResult(ignored, e);
                }
                else
                {
                    invokeInternalAuthenticateThenSetGetServerInfo(client, listenerResult);
                }
            };

            providePublicEncrKey(client, outerResult);
        }

        private void providePublicEncrKey(BClient_Indexserver client, BAsyncResult<bool> asyncResult)
        {
            BAsyncResult<LoginResult> asyncLogin = (lr, e) =>
                {
                    if (e != null)
                    {
                        asyncResult(false, e);
                    }
                    else
                    {
                        publicKey = publicKeyFromString(lr.clientInfo.ticket);
                        asyncResult(true, null);
                    }
                };

            client.IXServicePortIF.login("PUBLIC_ENCR_KEY", null, null, null, asyncLogin);
        }

        private void invokeInternalAuthenticateThenSetGetServerInfo(BClient_Indexserver client, BAsyncResult<bool> asyncResult)
        {
            BAsyncResult<bool> outerResult = (ignored, e) =>
                {
                    if (e != null)
                    {
                        asyncResult(false, e);
                    }
                    else
                    {
                        invokeGetServerinfoThenSetSessionOptions(client, asyncResult);
                    }
                };

            internalAuthenticate(client, outerResult);
        }

        private void invokeGetServerinfoThenSetSessionOptions(BClient_Indexserver client, BAsyncResult<bool> asyncResult)
        {
            BAsyncResult<ServerInfo> outerResult = (serverInfo, e) =>
            {
                if (e != null)
                {
                    asyncResult(false, e);
                }
                else
                {
                    databaseEngine = serverInfo.databaseEngine;
                    invokeSetSessionOptionsThenProvidePasswords(client, asyncResult);
                }
            };

            client.IXServicePortIF.getServerInfo(outerResult);
        }

        private void invokeSetSessionOptionsThenProvidePasswords(BClient_Indexserver client, BAsyncResult<bool> asyncResult)
        {
            BAsyncResult<Object> outerResult = (result, e) =>
            {
                if (e != null)
                {
                    asyncResult(false, e);
                }
                else
                {
                    IEnumerator<String> itpwd = encrPasswords.Keys.GetEnumerator();
                    provideEncrPasswords(client, itpwd, asyncResult);
                }
            };

            SessionOptions opts = makeSessOptsObj();
            client.IXServicePortIF.setSessionOptions(opts, outerResult);
        }

        private void provideEncrPasswords(BClient_Indexserver client, IEnumerator<String> itpwd, BAsyncResult<bool> asyncResult)
        {
            if (itpwd.MoveNext())
            {
                try
                {
                    String cryptId = itpwd.Current;
                    String pwd = encrPasswords[cryptId];
                    String pwdEncr = encryptPassword(pwd);

                    BAsyncResult<Object> outerResult = (ignored, e) =>
                    {
                        if (e != null)
                        {
                            asyncResult(false, e);
                        }
                        else
                        {
                            provideEncrPasswords(client, itpwd, asyncResult);
                        }
                    };

                    client.IXServicePortIF.provideCryptPassword(cryptId, pwdEncr, outerResult);
                }
                catch (Exception e)
                {
                    asyncResult(false, e);
                }
            }
            else
            {
                asyncResult(false, null);
            }
        }

        internal string encryptPassword(string s)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();

            RSA.ImportParameters(publicKey);

            byte[] plainText = Encoding.UTF8.GetBytes(s);
            byte[] encrText = RSA.Encrypt(plainText, false);

            String ret = "##RSA##" + Convert.ToBase64String(encrText);
            return ret;
        }

        private SessionOptions makeSessOptsObj()
        {
            SessionOptions opts = new SessionOptions();
            KeyValue[] kvs = opts.options = new KeyValue[sessOpts.Count];
            int i = 0;
            foreach (String key in sessOpts.Keys)
            {
                KeyValue kv = kvs[i++] = new KeyValue();
                kv.key = key;
                kv.value = sessOpts[key];
            }
            return opts;
        }

        protected readonly static String[] RELOGIN_ERRORS = new String[] 
        { 
            // session expired
            "[ELOIX:" + IXExceptionC.INVALID_SESSION + "]", 
        };

        public virtual bool isReloginException(BClient client, Exception ex, int typeId)
        {
            if (typeId == BRequest_IXServicePortIF_sendEvents.serialVersionUID ||
                typeId == BRequest_IXServicePortIF_createEventBusListener.serialVersionUID)
            {
                return false;
            }

            if (client.getTransport().isReloginException(ex, BRegistry.TYPEID_VOID))
            {
                return true;
            }

            String msg = ex.ToString();
            for (int i = 0; i < RELOGIN_ERRORS.Length; i++)
            {
                if (msg.IndexOf(RELOGIN_ERRORS[i]) >= 0)
                {
                    return true;
                }
            }

            return false;
        }

        public virtual void getSession(BClient client, int typeId, BAsyncResult<Object> asyncResult)
        {
            if (needAlive())
            {
                ticketBestBeforeAlive = 0L;
                BAsyncResult<Object> aliveResult = (ignored, e) =>
                {
                    if (e == null)
                    {
                        setTicketValid();
                    }
                    asyncResult(loginResult.clientInfo, e);
                };
                ((BClient_Indexserver)client).IXServicePortIF.alive(aliveResult);
            }
            else
            {
                asyncResult(loginResult.clientInfo, null);
            }
        }

        private void notifyListeners(BClient client, Exception e)
        {
            foreach (IXAuthenticationListener lsn in listeners)
            {
                lsn(client, e);
            }
        }

        public void addListener(IXAuthenticationListener lsn)
        {
            listeners.Add(lsn);
        }

        public void removeListener(IXAuthenticationListener lsn)
        {
            listeners.Remove(lsn);
        }

        private static byte[] stripLeadingZeros(byte[] a)
        {
            int firstByte = 0;
            for (; firstByte < a.Length && a[firstByte] == 0; firstByte++) { }

            if (firstByte == 0) return a;

            byte[] result = new byte[a.Length - firstByte];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = a[firstByte + i];
            }
            return result;
        }

        private static RSAParameters publicKeyFromString(string s)
        {
            int p = s.IndexOf(" ");
            if (p < 0) throw new InvalidOperationException("Invalid format.");
            string mod = s.Substring(0, p);
            string exp = s.Substring(p);
            RSAParameters keyInfo = new RSAParameters();

            byte[] modBytes = Convert.FromBase64String(mod);
            keyInfo.Modulus = stripLeadingZeros(modBytes);
            keyInfo.Exponent = Convert.FromBase64String(exp);
            return keyInfo;
        }

        private void setTicketValid()
        {
            if (loginResult != null)
            {
                // 1 Sekunde = 10.000.000 Ticks
                ticketBestBefore = DateTime.Now.Ticks + ((long)loginResult.ticketLifetime * 1000 * 1000 * 10);
                ticketBestBeforeAlive = DateTime.Now.Ticks + ((long)loginResult.ticketLifetime * 500 * 1000 * 10);
            }
        }

        public bool isExpired()
        {
            return loginResult != null && loginResult.clientInfo != null && 
                !String.IsNullOrEmpty(loginResult.clientInfo.ticket) &&
                ticketBestBefore < DateTime.Now.Ticks;
        }

        public bool needAlive()
        {
            return !isExpired() && ticketBestBeforeAlive != 0 && ticketBestBeforeAlive < DateTime.Now.Ticks;
        }

        internal string getDatabaseEngine()
        {
            return databaseEngine;
        }
    }
}
