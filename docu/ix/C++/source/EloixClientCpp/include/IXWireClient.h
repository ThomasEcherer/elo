#pragma once

#include "IXAPI.h"

namespace de { namespace elo { namespace ix { namespace client { 
  
using namespace byps;
using namespace byps::http;
using namespace std;

class IXWireClient;
typedef byps_ptr<IXWireClient> PIXWireClient;

class IXWireClient : public HWireClient {
    static BLogger log;

public:
  virtual ~IXWireClient();

  static PIXWireClient create(const std::wstring& url, int32_t flags, int32_t timeoutSeconds, PThreadPool tpool);

  virtual std::wstring getUrlForAuthentication();

  virtual PHttpClient getHttpClient();

protected:
  IXWireClient(const wstring& url, int32_t flags, int32_t timeoutSeconds, PThreadPool tpool);

  virtual std::wstring getServletPathForNegotiationAndAuthentication();
};



}}}}