#include "StdAfx.h"
#include <sstream>
#include "IXConnFactory.h"
#include "IXProperties.h"
#include "IXConnection.h"
#include "HHttpClient.h"
#include "platform/win/WinHttpClient.h"
#include "IXWireClient.h"

namespace de { namespace elo { namespace ix { namespace client { 

  using namespace std;
  using namespace byps;
  using namespace byps::http;


  LPCWSTR IXConnFactory::PROP_URL = L"connection.url";
  LPCWSTR IXConnFactory::PROP_NB_OF_CNNS = L"connection.nbOfCnns";
  LPCWSTR IXConnFactory::PROP_TIMEOUT_SECONDS = L"connection.timeoutSeconds";
  LPCWSTR IXConnFactory::PROP_TEMP_DIR = L"connection.tempDir";
  LPCWSTR IXConnFactory::NB_OF_REVERSE_CNNS = L"serverR.nbOfCnns";

  IXConnFactory::IXConnFactory() {
  }

  void IXConnFactory::init(PIXProperties props, PIXProperties sessOpts) {

    // Formatierungsfunktion f�r Fehlermeldungen.
    BExceptionO::formatMessage = [] (int32_t code, const wstring& msg, const wstring& details, const exception& unused) -> wstring {
      std::wstringstream ss;
      ss << L"[ELOIX:" << code << L"][" << msg << L"][DETAILS:" << details << L"]";
      return ss.str();
    };

    defaultProps = PIXProperties(new IXProperties());
    defaultProps->setProperty(PROP_NB_OF_CNNS, L"2");
    defaultProps->setProperty(PROP_TIMEOUT_SECONDS, L"600");
    defaultProps->setProperty(NB_OF_REVERSE_CNNS, L"1");

    this->connProps = PIXProperties(new IXProperties(defaultProps));
    this->connProps->putAll(props);
    this->sessOpts = sessOpts;

    wstring url = connProps->getProperty(PROP_URL);
    int nbOfCnns = _wtoi(connProps->getProperty(PROP_NB_OF_CNNS).c_str());
    int timeoutSeconds = _wtoi(connProps->getProperty(PROP_TIMEOUT_SECONDS).c_str());

    wstring reverseConnsStr = connProps->getProperty(NB_OF_REVERSE_CNNS);
    int nbOfReverseConnections = _wtoi(reverseConnsStr.c_str());

    this->tpool = PThreadPool(BThreadPool::create(NULL, nbOfCnns + nbOfReverseConnections));
  }

  IXConnFactory::~IXConnFactory(void)
  {
    done();
  }

  void IXConnFactory::done()
  {
    if (this->tpool) {
      this->tpool->done();
      this->tpool = PThreadPool();
    }
  }

  PIXProperties IXConnFactory::createConnProperties(const wstring& url) {
    PIXProperties props = PIXProperties(new IXProperties());
    props->setProperty(PROP_URL, url);
    return props;
  }

  PIXProperties IXConnFactory::createConnProperties(const wstring& url, int nbOfCnns, int timeoutSeconds) {
    PIXProperties props = PIXProperties(new IXProperties());
    props->setProperty(PROP_URL, url);

    {
      wstringstream s; s << nbOfCnns;
      props->setProperty(PROP_NB_OF_CNNS, s.str());
    }

    {
      wstringstream s; s << timeoutSeconds;
      props->setProperty(PROP_TIMEOUT_SECONDS, s.str());
    }

    return props;
  }

  PIXProperties IXConnFactory::createSessionOptions(const wstring& appName, const wstring& appVersion) {
    PIXProperties props = PIXProperties(new IXProperties());
    props->setProperty(SessionOptionsC::CLIENT_APP_NAME, appName);
    props->setProperty(SessionOptionsC::CLIENT_APP_TYPE, SessionOptionsC::TYPE_PARTNER_APPLICATION);
    props->setProperty(SessionOptionsC::CLIENT_APP_VERSION, appVersion);
    return props;
  }

  PIXProperties IXConnFactory::getConnProperties() {
    return connProps;
  }

  PIXProperties IXConnFactory::getSessionOptions() {
    return sessOpts;
  }

  PIXServicePortC IXConnFactory::getCONST() {
    if (!CONSTVal) {

    }
    return CONSTVal;
  }

  PClientInfo IXConnFactory::makeDefaultClientInfo() {
    //Locale loc = Locale.getDefault();
    //TimeZone tz = TimeZone.getDefault();
    PClientInfo ci = PClientInfo(new ClientInfo());
    //ci.setLanguage(loc.getLanguage());
    //ci.setCountry(loc.getCountry());
    //ci.setTimeZone(tz.getID());
    ci->setTimeZone(L"UTC");
    return ci;
  }


  void IXConnFactory::internalCreateConnection(PIXAuthentication auth, function<void (PIXConnection, BException)> asyncResult) {

    // Check version
    int majorVersion = getMajorVersion();
    if (majorVersion < 9) {
      BException ex(BExceptionC::CONNECTION_TO_SERVER_FAILED,
        L"Received server version " + getVersion() + L". At least server version 9.00.000 is required.");
      asyncResult(PIXConnection(), ex);
      return;
    }

    // IX-URL, e.g. http://localhost:8084/ix-elo80/ix
    wstring url = connProps->getProperty(PROP_URL, L"");

    // BYPS-URL, e.g. http://localhost:8084/ix-elo80/byps
    wstring bypsUrl = url;
    size_t pos = bypsUrl.rfind(L"/ix");
    if (pos != wstring::npos) {
      bypsUrl = bypsUrl.substr(0, pos) + L"/byps";
      if (pos + 3 < url.size()) {
        bypsUrl += url.substr(pos+3);
      }
    }

    // timeout
    wstring timeoutSecondsStr = connProps->getProperty(PROP_TIMEOUT_SECONDS, L"120");
    int timeoutSeconds = _wtoi(timeoutSecondsStr.c_str());

    // #reverse connections
    wstring reverseConnsStr = connProps->getProperty(NB_OF_REVERSE_CNNS, L"1");
    int nbOfReverseConnections = _wtoi(reverseConnsStr.c_str());

    // Wire, transport, client
    PIXWireClient wire(IXWireClient::create(bypsUrl, 0, timeoutSeconds, tpool));
    PTransportFactory transportFactory(new HTransportFactoryClient(BApiDescriptor_Indexserver::instance(), wire, nbOfReverseConnections));
    PClient_Indexserver bclient = BClient_Indexserver::createClient(transportFactory);

    // Authentication
    bclient->setAuthentication(auth);

    // IXConnection
    PIXConnection conn = internalCreateIXConnectionObject(shared_from_this(), bclient, auth, url, connProps, sessOpts);

    auto outerResult = [this, conn, bclient, asyncResult](bool, BException ex) {
      if (ex) {
        asyncResult(conn, ex);
      }
      else if (this->CONSTVal) {
        asyncResult(conn, ex);
      }
      else {

        // Lese Konstantent Objekt
        auto constResult = [this, conn, asyncResult](PIXServicePortC constVal, BException ex) {
          this->CONSTVal = constVal;
          asyncResult(conn, ex);
        };
        bclient->getIXServicePortIF()->getConstants(constResult);
      }
    };

    // Starte client
    bclient->start(outerResult, false);

  }

  PIXConnection IXConnFactory::internalCreateIXConnectionObject(PIXConnFactory connFact, PClient_Indexserver bclient, PIXAuthentication auth, const wstring& url, PIXProperties connProps, PIXProperties sessOpts) {
    return PIXConnection(new IXConnection(shared_from_this(), bclient, auth, url, connProps, sessOpts));
  }

  wstring IXConnFactory::getVersion() {
    wstring url = connProps->getProperty(PROP_URL);
    return readStatusPage(url, L"Version");
  }

  int IXConnFactory::getMajorVersion() {
	  int ret = 0;
	  wstring ver = getVersion();
	  size_t p = ver.find(L'.');
	  if (p != wstring::npos) {
		  wstringstream wss;
		  wss << ver.substr(0, p);
		  wss >> ret;
	  }
	  return ret;
  }

  wstring IXConnFactory::readStatusPage(const wstring& url, const wstring& paramName) {
    PIXProperties props;
    PHttpClient http = HttpClient_create(NULL);
    http->init(url);

    PHttpGet httpget = http->get(url + L"?cmd=status&mode=txt");

    BSyncResultT<PBytes>* recvBytes = new BSyncResultT<PBytes>();
    PAsyncResult asyncResult(recvBytes);
    httpget->send(asyncResult);

    PBytes bytes = recvBytes->getResult();

    props = PIXProperties(new IXProperties());
    props->read(bytes);

    return props->getProperty(paramName);
  }



  ///////////////////////////////////////////////////////////////////////////////////////////////////
  // Authentifizierung mit Name/Kennwort
  //
  //



  class IXAuthentication_NameOrRunAsReportAs : public IXAuthentication {
    wstring userName;
    wstring userPwd;
    wstring computerName;
    wstring runAs;
    bool reportAs;

  public:
    IXAuthentication_NameOrRunAsReportAs(PClientInfo clientInfo, PIXProperties sessOpts, EAuthenticationType authType,
      const wstring& userName, const wstring& userPwd, const wstring& computerName, const wstring& runAs, bool reportAs) 
      : IXAuthentication(clientInfo, sessOpts, authType)
      , userName(userName)
      , userPwd(userPwd)
      , computerName(computerName)
      , runAs(runAs)
      , reportAs(reportAs) {
    }

    virtual ~IXAuthentication_NameOrRunAsReportAs(void) {
    }

  protected:
    virtual void internalAuthenticate(PClient_Indexserver client, function<void (bool, BException)> asyncResult) {

      auto outerResult = [this, asyncResult](PLoginResult loginResult, BException ex) {
        this->setLoginResult(loginResult);
        asyncResult(false, ex);
      };

      try {
        wstring encrPwd = encryptPassword(userPwd);
        if (reportAs) {
          client->getIXServicePortIF()->loginAdmin(userName, encrPwd, computerName, runAs, outerResult);
        }
        else {
          client->getIXServicePortIF()->login(userName, encrPwd, computerName, runAs, outerResult);
        }
      }
      catch (BException& ex) {
        asyncResult(false, ex);
      }

    }

  };

  PIXConnection IXConnFactory::create(const wstring& userName, const wstring& userPwd, 
    const wstring& computerName, const wstring& runAs) {
      PClientInfo ci = makeDefaultClientInfo();
      return create(ci, userName, userPwd, computerName, runAs);
  }

  PIXConnection IXConnFactory::create(PClientInfo ci, const wstring& userName, const wstring& userPwd, 
    const wstring& computerName, const wstring& runAs) {

      if (!ci) ci = makeDefaultClientInfo();

      EAuthenticationType authType = runAs.length() ? EAuthenticationType::RUN_AS : EAuthenticationType::NAME_PASSWORD;

      PIXAuthentication auth(new IXAuthentication_NameOrRunAsReportAs(ci, sessOpts, authType,
        userName, userPwd, computerName, runAs, false));

      byps_ptr<BSyncResultT<PIXConnection> > syncConn(new BSyncResultT<PIXConnection>());

      internalCreateConnection(auth, [syncConn](PIXConnection conn, BException ex) {
        syncConn->setAsyncResult(conn, ex);
      });

      return syncConn->getResult();
  }



  ///////////////////////////////////////////////////////////////////////////////////////////////////
  // Authentifizierung mit SSO
  //
  //



  class IXAuthentication_SSO_AsyncResult : public BAsyncResult {
    PClient client;
    function<void (bool, BException)> innerResult;
  public:
    IXAuthentication_SSO_AsyncResult(PClient client, function<void (bool, BException)> innerResult);
    virtual ~IXAuthentication_SSO_AsyncResult();
    virtual void setAsyncResult(const BVariant& result);
  };

  class IXAuthentication_SSO : public IXAuthentication {
    wstring computerName;
  public:
    IXAuthentication_SSO(PClientInfo clientInfo, PIXProperties sessOpts, EAuthenticationType authType, const wstring& computerName);
    virtual ~IXAuthentication_SSO(void);
    virtual void setLoginResult(PLoginResult lr); // setLoginResult muss public sein, damit ich in IXAuthentication_SSO_AsyncResult drankomme
  protected:
    virtual void internalAuthenticate(PClient_Indexserver client, function<void (bool, BException)> asyncResult);
  };

  IXAuthentication_SSO_AsyncResult::IXAuthentication_SSO_AsyncResult(PClient client, function<void (bool, BException)> innerResult) 
    : client(client), innerResult(innerResult) {
  }

  IXAuthentication_SSO_AsyncResult::~IXAuthentication_SSO_AsyncResult() {
  }

  void IXAuthentication_SSO_AsyncResult::setAsyncResult(const BVariant& result) { 
    if (result.isException()) {
      innerResult(false, result.getException());
    }
    else {

      try {
        PBytes bytes;
        result.get(bytes);
        if (!bytes) throw BException(BExceptionC::INTERNAL, L"Missing response bytes");

        BBuffer buf(BBinaryModel::MEDIUM(), bytes, BBIG_ENDIAN);
        BMessageHeader header;
        header.read(buf);

        // Neue Sitzungs-ID �bernehmen
        if (!header.targetId.isZero())
        {
          client->getTransport()->setTargetId(header.targetId);
          client->getTransport()->setSessionId(header.sessionId);
        }

        PInput inp = client->getTransport()->getInput(header, bytes);
        PSerializable ser = inp->load();
        PLoginResult lr = byps_ptr_cast<LoginResult>(ser); 
        if (!lr) throw BException(BExceptionC::INTERNAL, L"Cannot cast response to LoginResult");

        byps_ptr<IXAuthentication_SSO> auth = byps_ptr_cast<IXAuthentication_SSO>(client->getAuthentication());
        auth->setLoginResult(lr);

        innerResult(true, BException());
      }
      catch (BException& ex) {
        innerResult(false, ex);
      }
    }

    delete this; 
  }

  IXAuthentication_SSO::IXAuthentication_SSO(PClientInfo clientInfo, PIXProperties sessOpts, EAuthenticationType authType, const wstring& computerName) 
    : IXAuthentication(clientInfo, sessOpts, authType)
    , computerName(computerName) {
  }

  IXAuthentication_SSO::~IXAuthentication_SSO(void) {
  }

  void IXAuthentication_SSO::setLoginResult(PLoginResult lr) { // setLoginResult muss public sein, damit ich in IXAuthentication_SSO_AsyncResult drankomme
    IXAuthentication::setLoginResult(lr);
  }

  void IXAuthentication_SSO::internalAuthenticate(PClient_Indexserver client, function<void (bool, BException)> asyncResult) {

    PClientInfo ci = getLoginResult()->getClientInfo();
    PIXWireClient wire = byps_ptr_cast<IXWireClient>(client->getTransport()->getWire());

    wstringstream loginServletUrl;
    loginServletUrl << wire->getUrlForAuthentication();

	// Schreibe diese 9er Version für die Verbindung zu IX 9.0.
	// Weil bei ELO 9 ein String-Vergleich gemacht wird, wäre sonst die Version 10 kleiner als die Version 9
	loginServletUrl << L"?streamversion=" << BVersioning::stringToLong(wstring(L"9.99.0.0"));

	loginServletUrl << L"&bstreamversion=" << BVersioning::stringToLong(IXServicePortC::STREAM_VERSION);
    loginServletUrl << L"&responseformat=byps-binary";
    loginServletUrl << L"&language=" + ci->getLanguage();
    loginServletUrl << L"&timezone=" + ci->getTimeZone();
    loginServletUrl << L"&country=" + ci->getCountry();
    loginServletUrl << L"&callid=" + ci->getCallId();
    loginServletUrl << L"&computerName=" + computerName;

    PHttpGet req = wire->getHttpClient()->get(loginServletUrl.str());

    PAsyncResult asyncResultBytes(new IXAuthentication_SSO_AsyncResult(client, asyncResult));
    req->send(asyncResultBytes);
  }

  PIXConnection IXConnFactory::createSso(PClientInfo ci, const wstring& computerName) {

    if (!ci) ci = makeDefaultClientInfo();

    EAuthenticationType authType = EAuthenticationType::SSO;

    PIXAuthentication auth(new IXAuthentication_SSO(ci, sessOpts, authType, computerName));

    byps_ptr<BSyncResultT<PIXConnection> > syncConn(new BSyncResultT<PIXConnection>());

    internalCreateConnection(auth, [syncConn](PIXConnection conn, BException ex) {
      syncConn->setAsyncResult(conn, ex);
    });

    return syncConn->getResult();
  }

  PIXConnection IXConnFactory::createSso(const wstring& computerName) {
    return createSso(makeDefaultClientInfo(), computerName);
  }




  ///////////////////////////////////////////////////////////////////////////////////////////////////
  // Authentifizierung "from ticket"
  //
  //

  class IXAuthentication_FromTicket : public IXAuthentication {
  public:
    IXAuthentication_FromTicket(PClientInfo clientInfo, PIXProperties sessOpts, EAuthenticationType authType);
    virtual ~IXAuthentication_FromTicket(void);
  protected:
    virtual void internalAuthenticate(PClient_Indexserver client, function<void (bool, BException)> asyncResult);
  };

  IXAuthentication_FromTicket::IXAuthentication_FromTicket(PClientInfo clientInfo, PIXProperties sessOpts, EAuthenticationType authType) 
    : IXAuthentication(clientInfo, sessOpts, authType) {
  }

  IXAuthentication_FromTicket::~IXAuthentication_FromTicket(void) {
  }

  void IXAuthentication_FromTicket::internalAuthenticate(PClient_Indexserver client, function<void (bool, BException)> asyncResult) {

    auto outerResult = [this, asyncResult] (PLoginResult loginResult, BException ex) {
      this->setLoginResult(loginResult);
      asyncResult(false, ex);
    };

    client->getIXServicePortIF()->getSessionFromTicket(SessionOptionsC::SESSION_FROM_AM_ADD, outerResult);
  }


  PIXConnection IXConnFactory::createFromTicket(PClientInfo ci) {

    if (!ci) ci = makeDefaultClientInfo();

    EAuthenticationType authType = EAuthenticationType::FROM_TICKET;

    PIXAuthentication auth(new IXAuthentication_FromTicket(ci, sessOpts, authType));

    byps_ptr<BSyncResultT<PIXConnection> > syncConn(new BSyncResultT<PIXConnection>());

    internalCreateConnection(auth, [syncConn](PIXConnection conn, BException ex) {
      syncConn->setAsyncResult(conn, ex);
    });

    return syncConn->getResult();
  }



}}}} // namespace