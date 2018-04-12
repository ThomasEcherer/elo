#pragma once

#include "IXAPI.h"

namespace de { namespace elo { namespace ix { namespace client { 

using namespace byps;
using namespace byps::http;
using namespace std;

class IXConnIXServicePortIF;
class IXProperties;

typedef byps_ptr<IXConnIXServicePortIF> PIXConnIXServicePortIF;
typedef byps_ptr<IXProperties> PIXProperties;

class IXConnection : public byps_enable_shared_from_this<IXConnection>
{
  friend class EventBusApi;
  friend class IXConnectionLoginCallback;

protected:
  PIXConnFactory connFact;
  PClient_Indexserver bclient;
  PIXAuthentication auth;
  wstring url;
  PIXProperties connProps;
  PIXProperties sessOpts;
  PIXConnIXServicePortIF ixVal;
  PEventBusApi eventBusApi;

  wstring databaseEngine;
  wstring implVersion;

public:
  IXConnection(PIXConnFactory connFact, PClient_Indexserver bclient, PIXAuthentication auth, const wstring& url, PIXProperties connProps, PIXProperties sessOpts);
  virtual ~IXConnection(void);
  virtual PIXServicePortIFAuth ix();
  virtual PLoginResult getLoginResult();
  virtual int getUserId();
  virtual wstring getUserName();
  virtual wstring getUrl();
  virtual PIXProperties getConnProperties();
  virtual PIXProperties getSessionOptions();
  virtual wstring getVersion();
  virtual wstring getImplVersion();
  virtual wstring getInterfaceVersion();
  virtual wstring getClientVersion();
  virtual PIXServicePortC getCONST();
  virtual wstring upload(const wstring& url, const wstring& fileName);
  virtual void download(const wstring& url, const wstring& fileName);
  virtual wstring upload(const wstring& url, PContentStream stream);
  virtual PContentStream download(const wstring& url);
  virtual wstring encryptPassword(const wstring& s);
  virtual void logout();
  virtual wstring getFileExt(const wstring fileName);
  virtual wstring truncate(const wstring& s, int max);
  virtual wstring getDatabaseEngine();

  virtual SYSTEMTIME isoToDate(const wstring& s);
  virtual wstring dateToIso(SYSTEMTIME& ft);

  virtual PEventBusApi getEventBusApi();
  virtual de::elo::ix::client::feed::PFeedServiceAuth getFeedService();
};

}}}}