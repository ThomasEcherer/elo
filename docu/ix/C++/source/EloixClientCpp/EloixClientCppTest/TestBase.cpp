#include "Stdafx.h"
#include "TestBase.h"
#include "TestUtilHttp.h"
#include <thread>

namespace de { namespace elo { namespace test {

  using namespace de::elo::ix::client;
  using namespace std;
  using namespace byps;

  BLogger TestBase::log("TestBase");

  TestBase::TestBase() 
    : app(NULL) {
      log.debug() << L"ctor()";
  }
  TestBase::~TestBase() {
    log.debug() << L"dtor()";
  }

  PIXConnection TestBase::createConnection(const wchar_t* computerName, const wchar_t* runAs) {
    PIXConnection c = TestUtilHttp::createConnection(computerName, runAs);
    conns.push_back(c);
    return c;
  }

  void TestBase::beforeCase() {
    log.debug() << L"beforeCase(";
    conn = createConnection();
    log.debug() << L")beforeCase";
  }

  void TestBase::afterCase() {
    log.debug() << L"afterCase(";

    conn.reset();

    for (auto it = conns.begin(); it != conns.end(); it++) {
      PIXConnection c = *it;
      c->logout();
    }

    //   assert(client.use_count() == 1);
    //   PTransport transport = client->transport;
    //   client.reset();
    //   rc = transport.use_count();
    //   assert(rc == 1);
    //   transport.reset();

    log.debug() << L")afterCase";
  }

  void TestBase::onError(const std::exception& ex) {
    const char* p = ex.what();
    std::wstringstream ws;
    ws << p;
    l_error << ws.str();
    TestCase::onError(ex);
  }

  void TestBase::onError(const TestFunction& tfunc, const std::exception& ex) {
    l_error << tfunc.name << L" error: " << ex.what();
    TestCase::onError(ex);
  }

  void TestBase::onFailed(const TestFunction& tfunc, const AssertException& ex) {
    l_error << tfunc.name << L" failed: " << ex;
    TestCase::onFailed(tfunc, ex);
  }

  void TestBase::beforeFunction(const TestCase::TestFunction& tfunc) {
    TestCase::beforeFunction(tfunc);
    l_info << tfunc.name << "... ";
    tempFiles.clear();
  }  

  void TestBase::afterFunction(const TestCase::TestFunction& tfunc) {
    for (auto it = tempFiles.begin(); it != tempFiles.end(); it++) {
      ::DeleteFile((*it).c_str());
    }
    TestCase::afterFunction(tfunc);
  }

  void TestBase::onSuccess(const TestCase::TestFunction& tfunc) {
    TestCase::onSuccess(tfunc);
    l_info << "OK";
  }

  wstring TestBase::getTempFileName() {
    wchar_t tempDir[MAX_PATH], tempFile[MAX_PATH];
    ::GetTempPath(MAX_PATH, tempDir);
    ::GetTempFileName(tempDir, L"ixüöß", 0, tempFile);
    wstring s = tempFile;
    tempFiles.push_back(s);
    return s;
  }

  wstring TestBase::createTestFile() {
    wstring tempFile = getTempFileName();
    HANDLE file = ::CreateFile(tempFile.c_str(), GENERIC_WRITE, 0, NULL, CREATE_ALWAYS, FILE_ATTRIBUTE_NORMAL, NULL);
    BYTE bom[] = {0xFF, 0xFE};
    DWORD bytesWritten = 0;
    ::WriteFile(file, bom, 2, &bytesWritten, NULL);
    ::WriteFile(file, tempFile.c_str(), (DWORD)(tempFile.length() * 2), &bytesWritten, NULL);
    ::CloseHandle(file);
    return tempFile;
  }

}}}