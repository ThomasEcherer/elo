#include "stdafx.h"
#include "IXAPI.h"
#include "AllTests.h"

using namespace de::elo::test;
using namespace de::elo::ix::client;
using namespace std;

class TestEventBus : public TestBase {
  static BLogger log;
public:

  byps_mutex mutex;
  byps_condition_variable waitForResult;
  
  vector<wstring> results;

  TestEventBus() : TestBase() {
  }

  virtual void init() {
    ADD_TEST(testBus);
  }

  void testBus();

};



class IXEventBusHandlerImpl : public BSkeleton_IXEventBusHandler {
  int connId;
  TestEventBus* dlg;
  static BLogger log;

public:
  IXEventBusHandlerImpl(int connId, TestEventBus* dlg) : connId(connId), dlg(dlg) {
  }

  virtual void processEventBusEvents(int64_t subsId, const byps_ptr< BArray1< PEvent > >& events) {
    byps_unique_lock lock(dlg->mutex);

    for (size_t i = 0; i < events->length(); i++) {
      PEvent e = events->at(i);

      std::wstringstream wss;
      wss << L"conn" << connId << L": [" << e->getType() << L", " << e->getAny()->getStringValue() << L"]" ;
      l_info << wss.str();

      dlg->results.push_back(wss.str());
    }
  }
};

BLogger IXEventBusHandlerImpl::log("IXEventBusHandlerImpl");

static void sendString(EventBusApi::PBus bus, int64_t eventId, const std::wstring& str) {
  PAny any(new Any());
  any->setType(AnyC::TYPE_STRING);
  any->setStringValue(str);
  bus->send(eventId, any);
}

void TestEventBus::testBus() {
  
  PIXConnection conn1;
  PIXConnection conn2;
  INT64 myEventId = EventBusC::BUSID_MAX_SYSTEM + 1;

  try {

    conn1 = TestUtilHttp::createConnection();
    conn2 = TestUtilHttp::createConnection();

    conn1->getEventBusApi()->addHandler(PSkeleton_IXEventBusHandler(new IXEventBusHandlerImpl(1, this)));
    conn2->getEventBusApi()->addHandler(PSkeleton_IXEventBusHandler(new IXEventBusHandlerImpl(2, this)));

    EventBusApi::PBus bus1 = conn1->getEventBusApi()->openEventBusChannel(L"CppTestApp");
    EventBusApi::PBus bus2 = conn2->getEventBusApi()->openEventBusChannel(L"CppTestApp");

    bus1->addListener(myEventId);
    bus2->addListener(myEventId);

    for (int i = 0; i < 3; i++) {

      {
        wstringstream wss;
        wss << L"Hello conn2 - " << i;
        sendString(bus1, myEventId, wss.str());
      }

      {
        std::wstringstream wss;
        wss << L"Hello conn1 - " << i;
        sendString(bus2, myEventId, wss.str());
      }
    }

    size_t nbOfExpectedMessages = 6;

    unsigned waitSeconds = 10;
    while (--waitSeconds >= 0) {
      Sleep(1000);

      {
        byps_unique_lock lock(mutex);
        if (results.size() >= nbOfExpectedMessages) break;
      }

    }

    tassert(__FILE__, __LINE__, L"#messages", nbOfExpectedMessages, results.size());

  }
  catch (BException& ex) {
    l_error << L"TestEventBus::testBus failed" << ex;
  }

  if (conn1) {
    conn1->logout();
  }
  if (conn2) {
    conn2->logout();
  }
}


BLogger TestEventBus::log("TestEventBus");

TestCase* TestEventBus_create(void* app) {
  return new TestEventBus();
}
