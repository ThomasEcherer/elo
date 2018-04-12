#pragma once

#include "IXAPI.h"

namespace de { namespace elo { namespace ix { namespace client { 

using namespace std;
using namespace byps;

/**
 * <p>
 * This object is used to create IXConnection objects that represent sessions
 * to IndexServer. Use one of the create methods to instanciate an IXConnection 
 * object.
 * </p><p>
 * The connection to the IndexServer is internally hold by an IXClient object. 
 * Its initial parameters are supplied by a Properties collection given in the
 * constructor of IXConnFactory. A reference to the IXClient object is passed
 * to each IXConnection object created by one of the create functions. 
 * </p>
 */
class IXConnFactory : public byps_enable_shared_from_this<IXConnFactory>
{
  public: virtual ~IXConnFactory(void);

  public: virtual void done();

  /**
   * Property name for IndexServer URL: &qt;connection.url&qt;. 
   * This value is required. Example: <code>http://server:8080/ix-Archive/ix</code>.
   */
  public: static LPCWSTR PROP_URL;
  /**
   * Property name for the number of connections to IndexServer used in the 
   * connection pool: &qt;connection.nbOfCnns&qt;. This value should be 2 for 
   * applications that use only one session to IndexServer. It should be set
   * to the estimated number of concurrent calls for applications that use
   * more sessions simultanously. This value is optional and defaults to 2.
   */
  public: static LPCWSTR PROP_NB_OF_CNNS;
  /**
   * Property name for connection timeout: &qt;connection.timeoutSeconds&qt; in 
   * seconds.
   * This value is optional and defaults to 120 seconds.
   */
  public: static LPCWSTR PROP_TIMEOUT_SECONDS;
  /**
   * Property name for a temporary directory: &qt;connection.tempDir&qt;. 
   * This value is optional and is currently not used.
   */
  public: static LPCWSTR PROP_TEMP_DIR;
  /**
   * Number of reverse connections.
   * This is the number of long-polls opened to the server in order to receive events.
   */
  public: static LPCWSTR NB_OF_REVERSE_CNNS;

  /**
   * Connection properties.
   */
  protected: PIXProperties connProps;
  /**
   * Default connection properties.
   */
  protected: PIXProperties defaultProps;
  /**
   * Session options.
   * @see SessionOptions SessionOptions
   */
  protected: PIXProperties sessOpts;
  /**
   * Thread pool used to send requests.
   */
  protected: PThreadPool tpool;
  /**
   * Indexserver constants
   */
  protected: PIXServicePortC CONSTVal;

  /**
   * Constructor. The supplied connection properties are used to create the 
   * internal IXClient object. They are passed to each IXConnection object 
   * created by one of the create function. The given session options are passed
   * to the IXConnLogin objects instanciated in the create functions. The 
   * functions <code>createConnProperties</code> and <code>createSessionOptions</code> 
   * can help to create the properties collections.
   * @param props Connection properties. 
   * @param sessOpts Session options. 
   * @see #createConnProps createConnProps
   * @see #createSessionOptions createSessionOptions
   */
  public: IXConnFactory();
  public: virtual void init(PIXProperties props, PIXProperties sessOpts);

  /**
   * Create a connection properties object. 
   * @param url URL to IndexServer
   * @return Properties object.
   * @see #PROP_URL PROP_URL
   */
  public: static PIXProperties createConnProperties(const wstring&  url);

  /**
   * Create a connection properties object.
   * @param url URL to IndexServer
   * @param nbOfCnns Size of connection pool with connections to IndexServer.
   * @param timeoutSeconds 
   * @return Properties object.
   * @see #PROP_URL PROP_URL
   * @see #PROP_NB_OF_CNNS PROP_NB_OF_CNNS
   * @see #PROP_TIMEOUT_SECONDS PROP_TIMEOUT_SECONDS
   */
  public: static PIXProperties createConnProperties(const wstring&  url, int nbOfCnns, int timeoutSeconds);

  /**
   * Creates a property collection that contains session options. The client
   * application type property (<code>SessionOptionsC.CLIENT_APP_TYPE</code>)
   * is set to <code>SessionOptionsC.TYPE_PARTNER_APPLICATION</code>.
   * @param appName Application name.
   * @param appVersion Application version.
   * @return Properties object.
   * @see SessionOptions SessionOptions
   */
  public: static PIXProperties createSessionOptions(const wstring&  appName, const wstring&  appVersion);
  /**
   * Get connection properties.
   * @return Connection properties.
   */
  public: virtual PIXProperties getConnProperties();
  /**
   * Get session options.
   * @return Session options.
   */
  public: virtual PIXProperties getSessionOptions();
  /**
   * Returns the constants object.
   * @return Constants object.
   * @throws java.rmi.RemoteException
   */
  public: virtual PIXServicePortC getCONST();
  /**
   * Creates a ClientInfo object and assigns the language, country and timezone
   * from the default values of the Java VM.
   * @return ClientInfo object.
   */
  public: virtual PClientInfo makeDefaultClientInfo();
  /**
   * Create a connection for the given user. The required ClientInfo object 
   * with language, country and timezone is created by 
   * <code>makeDefaultClientInfo</code>.
   * @param userName User name.
   * @param userPwd Plain text user password.
   * @param computerName Computer name.
   * @param runAs User name or ID if this should be a run-as connection.
   * @return IXConnection object.
   * @throws java.rmi.RemoteException
   */
  public: virtual PIXConnection create(const wstring&  userName, const wstring&  userPwd, 
          const wstring&  computerName, const wstring&  runAs);
  /**
   * Create aconnection for the given user.
   * @param ci ClientInfo object with language, country and timezone
   * @param userName User name.
   * @param userPwd Plain text user password.
   * @param computerName Computer name.
   * @param runAs User name or ID if this should be a run-as connection.
   * @return IXConnection object.
   * @throws java.rmi.RemoteException
   */
  public: virtual PIXConnection create(PClientInfo ci, const wstring&  userName, const wstring&  userPwd, 
          const wstring&  computerName, const wstring&  runAs);

  /**
   * Create a connection for the current Windows user by using HTTP authentication
   * @param ci ClientInfo object with language, country and timezone
   * @param computerName Computer name.
   */
  public: virtual PIXConnection createSso(PClientInfo ci, const wstring& computerName);
  public: virtual PIXConnection createSso(const wstring& computerName);

  public: virtual PIXConnection createFromTicket(PClientInfo ci);


  public: virtual wstring getVersion();
  public: virtual int getMajorVersion();
  
  protected: virtual void internalCreateConnection(PIXAuthentication auth, function<void (PIXConnection, BException)> asyncResult);

  protected: static wstring IXConnFactory::readStatusPage(const wstring& url, const wstring& paramName);

  /**
   * Create IXConnection object.
   * Can be overloaded in subclasses to create a customized connection object.
   * @param connFact
   * @param bclient
   * @param auth
   * @param url
   * @param connProps
   * @param sessOpts
   * @return IXConnection object
   */
  protected: virtual PIXConnection internalCreateIXConnectionObject(PIXConnFactory connFact, PClient_Indexserver bclient, PIXAuthentication auth, const wstring& url, PIXProperties connProps, PIXProperties sessOpts);

  friend class IXConnection;
};

}}}}