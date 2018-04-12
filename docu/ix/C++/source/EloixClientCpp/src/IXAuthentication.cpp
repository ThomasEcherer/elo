#include "stdafx.h"
#include "IXAPI.h"
#include "RsaEncryption.h"

namespace de { namespace elo { namespace ix { namespace client { 

#define IX_ENCR_PWD_PREFIX L"##RSA##"

static LPCWSTR RELOGIN_ERRORS[] = {
    L"[ELOIX:2001]", // session expired
};


IXAuthentication::IXAuthentication(PClientInfo clientInfo, PIXProperties sessOpts, EAuthenticationType authType)
	: loginResult(new LoginResult())
	, sessOpts(sessOpts)
	, encrPasswords(new IXProperties())
	, ticketBestBefore(0)
	, ticketBestBeforeAlive()
	, authType(authType)
{
	loginResult->setClientInfo(clientInfo);
	loginResult->setUser(PUserInfo(new UserInfo()));
}

IXAuthentication::~IXAuthentication(void)
{
}

void IXAuthentication::authenticate(PClient client1, function<void (bool, BException)> asyncResult) {

	PClient_Indexserver client = byps_ptr_cast<BClient_Indexserver>(client1);

	auto listenerResult = [this, client, asyncResult](bool ignored, BException e) {
		notifyListeners(client, e);
		asyncResult(ignored, e);
	};

	auto outerResult = [this, client, listenerResult](bool ignored, BException e) {
		if (e) {
			listenerResult(ignored, e);
		}
		else {
			invokeInternalAuthenticateThenGetServerinfo(client, listenerResult);
		}
	};

	providePublicEncrKey(client, outerResult);
}

void IXAuthentication::providePublicEncrKey(PClient_Indexserver client, function<void (bool, BException)> asyncResult) {

	auto asyncLogin = [this, client, asyncResult](PLoginResult loginResult, BException e) {
		if (e) {
			asyncResult(false, e);
		}
		else {
			wstring ticket = loginResult->getClientInfo()->getTicket();
			this->publicKey = toUtf8(ticket);
      asyncResult(true, e);
		}
	};

	client->getIXServicePortIF()->login(L"PUBLIC_ENCR_KEY", L"", L"", L"", asyncLogin);
}

void IXAuthentication::invokeInternalAuthenticateThenGetServerinfo(PClient_Indexserver client, function<void (bool, BException)> asyncResult) {

	auto outerResult = [this, client, asyncResult](bool ignored, BException e) {
		if (e) {
			asyncResult(ignored, e);
		}
		else {
			invokeGetServerInfoThenSetSessionOptions(client, asyncResult);
		}
	};

	internalAuthenticate(client, outerResult);
}

void IXAuthentication::invokeGetServerInfoThenSetSessionOptions(PClient_Indexserver client, function<void (bool, BException)> asyncResult) {

	auto outerResult = [this, client, asyncResult](PServerInfo result, BException e) {
		if (e) {
			asyncResult(false, e);
		}
		else {
			this->databaseEngine = result->getDatabaseEngine();
			invokeSetSessionOptionsThenProvidePasswords(client, asyncResult);
		}
	};

	 client->getIXServicePortIF()->getServerInfo(outerResult);
}

void IXAuthentication::invokeSetSessionOptionsThenProvidePasswords(PClient_Indexserver client, function<void (bool, BException)> asyncResult) {

	auto outerResult = [this, client, asyncResult](bool ignored, BException e) {
		if (e) {
			asyncResult(ignored, e);
		}
		else {
			IXProperties::MAP::iterator itpwd = encrPasswords->map().begin();
			provideEncrPasswords(client, itpwd, asyncResult);
		}
	};

	PSessionOptions opts = makeSessionOptsObj();
	client->getIXServicePortIF()->setSessionOptions(opts, outerResult);
}

void IXAuthentication::provideEncrPasswords(PClient_Indexserver client, IXProperties::MAP::iterator itpwd, function<void (bool, BException)> asyncResult) {

	if (itpwd != encrPasswords->map().end()) {

		wstring cryptId = (*itpwd).first;
		wstring pwd = (*itpwd).second;
		wstring pwdEncr = encryptPassword(pwd);
		itpwd++;

		auto outerResult = [this, client, itpwd, asyncResult](bool ignored, BException e) {
			if (e) {
				asyncResult(ignored, e);
			}
			else {
				provideEncrPasswords(client, itpwd, asyncResult);
			}
		};

		client->getIXServicePortIF()->provideCryptPassword(cryptId, pwdEncr, asyncResult);
	}
	else {
		asyncResult(false, BException());
	}
}

PSessionOptions IXAuthentication::makeSessionOptsObj() {
	PSessionOptions opts(new SessionOptions());
	vector<PKeyValue> vec;
	for (IXProperties::MAP::iterator it = sessOpts->map().begin(); it != sessOpts->map().end(); it++) {
		PKeyValue kv(new KeyValue((*it).first, (*it).second));
		vec.push_back(kv);
	}
	opts->setOptions(byps_ptr< BArray1<PKeyValue> >(new BArray1<PKeyValue>(vec)));
	return opts;	
}

wstring IXAuthentication::encryptPassword(const wstring& pwd) {
	string pwd8 = toUtf8(pwd);

	RsaEncryption rsa;
	rsa.SetPublicKey(publicKey.c_str());
	string encrPwd8 = rsa.Encrypt(pwd8.c_str());

	wstringstream ss;
	ss << IX_ENCR_PWD_PREFIX << fromUtf8(encrPwd8);
	
	return ss.str();
}

bool IXAuthentication::needAlive() {
	return !isExpired() && ticketBestBeforeAlive != 0 && ticketBestBeforeAlive < time(NULL);
}

bool IXAuthentication::isExpired() {
	return ticketBestBefore < time(NULL);
}

void IXAuthentication::applyCallCounter(PClientInfo ci) {
  wstringstream wss;
  wss << L"T" << GetCurrentThreadId() << L":" << (++callCounter);
  ci->setCallId(wss.str());
}

void IXAuthentication::getSession(PClient client1, BTYPEID typeId, function<void (PSerializable, BException)> asyncResult) {
	if (needAlive()) {
		ticketBestBeforeAlive = 0;

		auto aliveResult = [this, asyncResult](bool ignored, BException e) {
			if (!e) {
				setTicketValid();
			}

      PLoginResult lr = loginResult;
      PClientInfo ci = lr ? lr->getClientInfo() : PClientInfo();
      if (!lr && e) {
        e = BException(BExceptionC::INTERNAL, L"Missing login result, invalid authentication status.");
      }

      applyCallCounter(ci);
			asyncResult(ci, e);
		};

		PClient_Indexserver client = byps_ptr_cast<BClient_Indexserver>(client1);
    client->getIXServicePortIF()->alive(aliveResult);

	}
	else {
		PClientInfo ci = loginResult ? loginResult->getClientInfo() : PClientInfo();
    applyCallCounter(ci);
		asyncResult(ci, BException());
	}
}

void IXAuthentication::setLoginResult(PLoginResult lr) {
	loginResult = lr;
	if (lr) {
		setTicketValid();
	}
}

void IXAuthentication::setTicketValid() {
	if (loginResult) {
		ticketBestBefore = time(NULL) + loginResult->getTicketLifetime();
		ticketBestBeforeAlive = time(NULL) + loginResult->getTicketLifetime() / 2;
	}
}

bool IXAuthentication::isReloginException(PClient client, BException ex, BTYPEID typeId) {

	// Diese Requests führen das Relogin selbst durch, weil mit der neuen
    // Anmeldung
    // auch eine neue Teilnehmer-ID für den Ereignisbus erstellt wurde.
    if (typeId == 1721831543L // BRequest_IXServicePortIF_sendEvents.serialVersionUID 
		|| 
		typeId == 563568172L // BRequest_IXServicePortIF_createEventBusListener.serialVersionUID
		) {
      return false;
    }

	if (client->getTransport()->isReloginException(ex, typeId)) return true;

	wstring msg = ex.toString();
	for (size_t i = 0; i < ARRAYSIZE(RELOGIN_ERRORS); i++) {
		if (msg.find(RELOGIN_ERRORS[i]) != wstring::npos) {
			return true;
		}
	}

	return false;
}

void IXAuthentication::notifyListeners(PClient_Indexserver client, BException e) {
	for (auto lsn = listeners.begin(); lsn != listeners.end(); lsn++) {
		(*lsn)->setAsyncResult(client, e);
	}
}

EAuthenticationType IXAuthentication::getAuthenticationType() {
  return authType;
}

PLoginResult IXAuthentication::getLoginResult() {
  return loginResult;
}

}}}}