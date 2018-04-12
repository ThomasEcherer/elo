/* USE THIS FILE ACCORDING TO THE COPYRIGHT RULES IN LICENSE.TXT WHICH IS PART OF THE SOURCE CODE PACKAGE */
#ifndef TESTBASE_H_
#define TESTBASE_H_

#include "Byps.h"
#include "testfw.h"
#include "BLogger.h"
#include "AssertException.h"
#include "IXAPI.h"

namespace de { namespace elo { namespace test {

using namespace de::elo::ix::client;
using namespace std;

class TestBase : public TestCase {
	static byps::BLogger log;
protected:
	void* app;
public:
	TestBase();
	virtual ~TestBase();
	virtual void beforeCase();
	virtual void afterCase();
	virtual void onError(const std::exception& ex);
	virtual void onError(const TestFunction& tfunc, const std::exception& ex);
	virtual void onFailed(const TestFunction& tfunc, const AssertException& ex);
	virtual void beforeFunction(const TestFunction& tfunc);
	virtual void onSuccess(const TestFunction& tfunc);
  virtual void afterFunction(const TestFunction& tfunc);
	
protected:

  wstring getTempFileName();
  wstring createTestFile();
  PIXConnection createConnection(const wchar_t* computerName = NULL, const wchar_t* runAs = NULL);

  vector<wstring> tempFiles;
  vector<PIXConnection> conns;
  PIXConnection conn;
};

}}}

#endif
