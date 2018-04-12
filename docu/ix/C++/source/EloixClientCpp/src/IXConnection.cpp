#include "StdAfx.h"
#include "IXConnection.h"
#include "EventBusApi.h"
#include <time.h>
#include <iomanip>

namespace de { namespace elo { namespace ix { namespace client { 

  using namespace byps;
  using namespace byps::http;
  using namespace std;

//class IXConnectionLoginCallback : public IXConnLoginCallback {
//  IXConnection* conn;
//public:
//  IXConnectionLoginCallback(IXConnection* conn) : conn(conn) {}
//
//  virtual void onLogin() {
//    if (conn->eventBusApi) {
//      conn->eventBusApi->onLogin();
//    }
//  }
//};

IXConnection::IXConnection(PIXConnFactory connFact, PClient_Indexserver bclient, PIXAuthentication auth, const wstring& url, PIXProperties connProps, PIXProperties sessOpts)
  :connFact(connFact), bclient(bclient), auth(auth), url(url), connProps(connProps), sessOpts(sessOpts)
{
}

IXConnection::~IXConnection(void)
{
}

PIXServicePortIFAuth IXConnection::ix() {
  return bclient->getIXServicePortIF();
}

PLoginResult IXConnection::getLoginResult() {
  return auth->getLoginResult();
}

int IXConnection::getUserId() {
  PLoginResult lr = getLoginResult();
  PUserInfo user = lr->getUser();
  int id = user->getId();
  return id;
}

std::wstring IXConnection::getUserName() {
  return getLoginResult()->getUser()->getName();
}

PIXProperties IXConnection::getConnProperties() {
  return connProps;
}

PIXProperties IXConnection::getSessionOptions() {
  return sessOpts;
}

std::wstring IXConnection::getVersion() {
  return connFact->getVersion();
}

std::wstring IXConnection::getImplVersion() {
  return getVersion() + wstring(L".") + IXConnFactory::readStatusPage(url, L"Build");
}

std::wstring IXConnection::getInterfaceVersion() {
  return IXConnFactory::readStatusPage(url, L"InterfaceVersion");
}

std::wstring IXConnection::getClientVersion() {
  return IXServicePortC::STREAM_VERSION;
}

PIXServicePortC IXConnection::getCONST() {
  return connFact->getCONST();
}

static wchar_t valueFromHex(wchar_t h1) {
  wchar_t c = 0;
  if (h1 >= L'0' && h1 <= L'9') c = h1 - L'0';
  else if (h1 >= L'A' && h1 <= L'F') c = h1 - L'A';
  else if (h1 >= L'a' && h1 <= L'f') c = h1 - L'a';
  return c & 0xFF;
}

static wstring decodeUri(const wchar_t* s) {
  wstringstream wss;
  size_t i = 0;

  while (s[i]) {

    wchar_t c = s[i];
    if (c == L'%') {
      wchar_t h1 = s[++i];
      wchar_t h2 = s[++i];
  
      c = (valueFromHex(h1) >> 4) | valueFromHex(h2);
    }
    
    wss << c;
    i++;
  }
  return wss.str();
}

static byps_ptr<BArray1<wstring> > makeRawStreamServiceParamsFromUrl(const wstring& url) {
  vector<wstring> vec;
  size_t p = url.find('?');
  wchar_t sz[2000] = {0};
  wcscpy_s(sz, p != wstring::npos ? url.substr(p+1).c_str() : url.c_str());
  wchar_t *context = NULL;
  wchar_t *elm = wcstok_s(sz, L"&", &context);
  while (elm) {
    wstring decodedElm = decodeUri(elm);
    vec.push_back(decodedElm);
    elm = wcstok_s(NULL, L"&", &context);
  }
  
  byps_ptr<BArray1<wstring> > arr(new BArray1<wstring>(vec));
  return arr;
}


wstring IXConnection::upload(const wstring& url, PContentStream stream) {
  byps_ptr<BArray1<wstring> > params = makeRawStreamServiceParamsFromUrl(url);
  return bclient->getRawStreamService()->upload(params, stream);
}

PContentStream IXConnection::download(const wstring& url) {
  byps_ptr<BArray1<wstring> > params = makeRawStreamServiceParamsFromUrl(url);
  return bclient->getRawStreamService()->download(params);
}


std::wstring IXConnection::upload(const std::wstring& url, const std::wstring& fileName) {
  PContentStreamWrapper stream(new BContentStreamWrapper(fileName));
  return upload(url, stream);
}

void IXConnection::download(const std::wstring& url, const std::wstring& fileName) {
  PContentStream stream = download(url);
  fstream file(fileName, std::fstream::out|std::fstream::binary);
  char buf[1000];
  int32_t len = 0;
  while ((len = stream->read(buf, 0, sizeof(buf))) != -1) {
    file.write(buf, (size_t)len);
  }
}

std::wstring IXConnection::encryptPassword(const std::wstring& s) {
  return auth->encryptPassword(s);
}

void IXConnection::logout() {
  if (auth->getAuthenticationType() != EAuthenticationType::FROM_TICKET) {
    bclient->getIXServicePortIF()->logout();
  }
  bclient->done();
}

std::wstring IXConnection::getFileExt(const std::wstring fileName) {
  size_t p = fileName.find_last_of(L'.');
  return p != wstring::npos ? fileName.substr(p+1) : wstring();
}

static std::wstring truncateToUtf8(const std::wstring& s, size_t max) {
  std::wstring r = s;
  if (max != 0) {
    if (s.size() * 4 > max) { // maximal 4 Bytes pro Zeichen.
      std::string utf8 = toUtf8(s);
      if (utf8.size() > max) {

        // 0xxxxxxx
        // 110xxxxx 10xxxxxx
        // 1110xxxx 10xxxxxx 10xxxxxx
        // 11110xxx 10xxxxxx 10xxxxxx 10xxxxxx
          
        if ((utf8[max] & 0x80) != 0) { // != 0xxxxxxx

          int i = (int)max;
          while ((utf8[i] & 0xC0) == 0x80) i--; // 10xxxxxx Folge-Bytes

          // utf8[i] muss jetzt ein Start-Byte sein: 110xxxxx oder 1110xxxx oder 11110xxx
          r = fromUtf8(utf8.substr(0, i));

        }
        else {
          r = fromUtf8(utf8.substr(0, max));
        }
      }
    }
  }
  else {
    r = L"";
  }
  return r;
}

std::wstring IXConnection::truncate(const std::wstring& s1, int max) {
  std::wstring s = s1;
  size_t m = (size_t)max;

  if (s.size() > m) {
    s = s.substr( 0, m );
  }

  if ( getDatabaseEngine() == L"DB2" ) {
    // IX-Versions befor 8.0 returned byte length / 2
    if (getVersion() < L"8.0") {
      m *= 2;
    }

    s = truncateToUtf8(s, m);
  }
  return s;
}


std::wstring IXConnection::getDatabaseEngine() {
  return databaseEngine;
}

SYSTEMTIME IXConnection::isoToDate(const std::wstring& s) {

  SYSTEMTIME tm = {0};

  std::wstring r; r.reserve(s.size());
  for (unsigned i = 0; i < s.size(); i++) {
    wchar_t c = s[i];
    if (c >= '0' && c <= '9') r += c;
  }

  if (r.size() >= 4) {
    tm.wYear = (WORD)_wtoi(r.substr(0,4).c_str());
    if (r.size() >= 6) {
      tm.wMonth = (WORD)_wtoi(r.substr(4,2).c_str());
      if (r.size() >= 8) {
        tm.wDay = (WORD)_wtoi(r.substr(6,2).c_str());
        if (r.size() >= 10) {
          tm.wHour = (WORD)_wtoi(r.substr(8,2).c_str());
          if (r.size() >= 12) {
            tm.wMinute = (WORD)_wtoi(r.substr(10,2).c_str());
            if (r.size() >= 14) {
              tm.wSecond = (WORD)_wtoi(r.substr(12,2).c_str());
  }}}}}}

  return tm;
}

std::wstring IXConnection::dateToIso(SYSTEMTIME& tm) {

  std::wstringstream wss;
  wss.fill(L'0');
  wss << std::setw(2) << tm.wYear 
    << std::setw(2) << tm.wMonth 
    << std::setw(2) << tm.wDay 
    << std::setw(2) << tm.wHour 
    << std::setw(2) << tm.wMinute 
    << std::setw(2) << tm.wSecond;

  return wss.str();
}

std::wstring IXConnection::getUrl() {
  return connProps->getProperty(L"connection.url");
}

PEventBusApi IXConnection::getEventBusApi() {
  if (!eventBusApi) {
    eventBusApi = EventBusApi_create(shared_from_this(), bclient);
	bclient->startR();
  }
  return eventBusApi;
}

de::elo::ix::client::feed::PFeedServiceAuth IXConnection::getFeedService()
{
   return bclient->getFeedService();
}

}}}}