#include "Stdafx.h"
#include "TestUtilHttp.h"
#include "TestAssert.h"
#include <string.h>
#include <algorithm>

#undef min

namespace de { namespace elo { namespace test {

  using namespace de::elo::ix::client;
  using namespace std;

static std::wstring url = L"http://localhost:8084/ix-elo100/ix";
//static std::wstring url = L"http://srvtdev03:6020/ix-elo90/ix";

using namespace byps;
using namespace byps::http;

PIXConnection TestUtilHttp::createConnection(const wchar_t* computerName, const wchar_t* runAs) {

  PIXConnFactory connFact = createConnFactory();

  wstring version = connFact->getVersion();

  PIXConnection conn = connFact->create(L"Administrator", L"elo", 
    computerName ? computerName : L"c++ testprog",
    runAs ? runAs : L"");

  return conn;
}

PIXConnFactory TestUtilHttp::createConnFactory() {
  PIXConnFactory connFact(new IXConnFactory());
  PIXProperties connProps = IXConnFactory::createConnProperties(url, 10, 120);
  PIXProperties sessOpts = IXConnFactory::createSessionOptions(L"ixcpp", L"1.0");
  connFact->init(connProps, sessOpts);
  return connFact;
}

class MyContentStreamBytes : public BContentStream {
	int64_t nbOfBytes;
	std::wstring contentType;
	int64_t pos;
	bool chunked;
	int v;
public:
    MyContentStreamBytes(int64_t nbOfBytes, bool chunked) : nbOfBytes(nbOfBytes), pos(0), chunked(chunked) {
		std::wstringstream wss;
		wss << L"application/byps-" << (nbOfBytes%3);
		contentType = wss.str();
	}
	
	virtual std::wstring getContentType() const { 
		return contentType;
	}
	
	virtual int64_t getContentLength() const { 
		return chunked ? -1 : nbOfBytes; 
	}

	virtual int32_t read(char* buf, int32_t offs, int32_t len) {
		if (pos == nbOfBytes) {
			return -1;
		}
		else {
			len = (int32_t)std::min(nbOfBytes - pos, (int64_t)len);
			for (int32_t i = 0; i < len; i++) {
				buf[offs + i] = (char)(pos++ & 0xFF);
			}
			return len;
		}
	}
};

const int INCOMING_STREAM_BUFFER = 1000 * 1000;
	
byps_ptr<std::vector<PContentStream> > TestUtilHttp::makeTestStreams() {
	byps_ptr<std::vector<PContentStream> > ret(new std::vector<PContentStream>());
	ret->push_back(PContentStream(new MyContentStreamBytes(0, false)));
	ret->push_back(PContentStream(new MyContentStreamBytes(1, false)));
	ret->push_back(PContentStream(new MyContentStreamBytes(INCOMING_STREAM_BUFFER-1, false)));
	ret->push_back(PContentStream(new MyContentStreamBytes(INCOMING_STREAM_BUFFER, false)));
	ret->push_back(PContentStream(new MyContentStreamBytes(INCOMING_STREAM_BUFFER+1, false)));
	ret->push_back(PContentStream(new MyContentStreamBytes(INCOMING_STREAM_BUFFER*2, false)));

#ifdef TEST_LARGE_STREAMS
	ret->push_back(PContentStream(new MyContentStreamBytes(0x100000000, false)));
#endif

	return ret;
}



}}}