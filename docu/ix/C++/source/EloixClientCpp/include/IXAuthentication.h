#pragma once

#include "IXAPI.h"
#include "IXProperties.h"

namespace de { namespace elo { namespace ix { namespace client { 

using namespace byps;
using namespace std;

enum EAuthenticationType 
{
    /**
     * IXConnection created for reading constants.
     * @see IXConnFactory#getCONST() 
     */
    NOT_AUTHENTICATED,
    /**
     * Session created with user name and password.
     * @see IXConnFactory#create(String, String, String, String) 
     */
    NAME_PASSWORD, 
    
    /**
     * Session created with user name and password and run-as-user.
     * @see IXConnFactory#create(String, String, String, String) 
     */
    RUN_AS, 
    /**
     * Session created with user name and password and report-as-user.
     * @see IXConnFactory#createAdmin(String, String, String, String) 
     */
    REPORT_AS,
    /**
     * Session created with SSO.
     * @see IXConnFactory#createSso(String)
     */
    SSO, 
    /**
     * Session create with Kerberos login.
     * @see IXConnFactory#createKrb(ClientInfo, String, String, String, String)
     */
    KERBEROS, 
    /**
     * Session created from a foreign ticket.
     * @see IXConnFactory#createFromTicket(ClientInfo) 
     */
    FROM_TICKET, 
};

class IXAuthentication : public BAuthentication, public byps_enable_shared_from_this<IXAuthentication>
{
protected:
	PLoginResult loginResult;
	PIXProperties sessOpts;
	PIXProperties encrPasswords;
	string publicKey;
	wstring databaseEngine;
	vector<PIXAuthenticationListener> listeners;
	time_t ticketBestBefore;
	time_t ticketBestBeforeAlive;
	EAuthenticationType authType;
  byps_atomic<int64_t> callCounter;

	virtual void internalAuthenticate(PClient_Indexserver client, function<void (bool, BException)> asyncResult) = 0;

	void notifyListeners(PClient_Indexserver client, BException e);
	void providePublicEncrKey(PClient_Indexserver client, function<void (bool, BException)> asyncResult);
	void invokeInternalAuthenticateThenGetServerinfo(PClient_Indexserver client, function<void (bool, BException)> asyncResult);
	void invokeGetServerInfoThenSetSessionOptions(PClient_Indexserver client, function<void (bool, BException)> asyncResult);
	void invokeSetSessionOptionsThenProvidePasswords(PClient_Indexserver client, function<void (bool, BException)> asyncResult);
	void provideEncrPasswords(PClient_Indexserver client, IXProperties::MAP::iterator it, function<void (bool, BException)> asyncResult);
	PSessionOptions makeSessionOptsObj();
	bool needAlive();
	bool isExpired();
	void setTicketValid();
	virtual void setLoginResult(PLoginResult lr);

public:
	IXAuthentication(PClientInfo clientinfo, PIXProperties sessOpts, EAuthenticationType authType);
	virtual ~IXAuthentication(void);

	virtual void authenticate(PClient client, function<void (bool, BException)> asyncResult);
	virtual void getSession(PClient client, BTYPEID typeId, function<void (PSerializable, BException)> asyncResult);
	virtual bool isReloginException(PClient client, BException ex, BTYPEID typeId);

  EAuthenticationType getAuthenticationType();
  PLoginResult getLoginResult();
	wstring encryptPassword(const wstring& pwd);
  void applyCallCounter(PClientInfo ci);
};

}}}}