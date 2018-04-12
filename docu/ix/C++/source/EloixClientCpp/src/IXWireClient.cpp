#include "stdafx.h"

#include "IXWireClient.h"

using namespace byps;
using namespace byps::http;
using namespace std;

namespace de { namespace elo { namespace ix { namespace client { 

BLogger IXWireClient::log("IXWireClient");

IXWireClient::IXWireClient(const wstring& url, int32_t flags, int32_t timeoutSeconds, PThreadPool tpool) 
  : HWireClient(NULL, url, flags, timeoutSeconds, tpool) {
}

IXWireClient::~IXWireClient() {
}

PIXWireClient IXWireClient::create(const std::wstring& url, int32_t flags, int32_t timeoutSeconds, PThreadPool tpool) {
  l_debug << L"create(" << url << L", flags=" << flags << L", timeoutSeconds=" << timeoutSeconds;
  IXWireClient* pThis = new IXWireClient(url, flags, timeoutSeconds, tpool);
	pThis->init();
  PIXWireClient ret = PIXWireClient(pThis);
  l_debug << L")create=" << pThis;
  return ret;
}

std::wstring IXWireClient::getServletPathForNegotiationAndAuthentication() {
	return L"/byps";
}

std::wstring IXWireClient::getUrlForAuthentication() {
	wstring authUrl = url;
  size_t p = authUrl.find_last_of(L'/');
  if (p != wstring::npos) {
    authUrl = authUrl.substr(0, p);
  }
  authUrl += L"/bypsauth/auth";
  return authUrl;
}

PHttpClient IXWireClient::getHttpClient() {
  return httpClient;
}

}}}}