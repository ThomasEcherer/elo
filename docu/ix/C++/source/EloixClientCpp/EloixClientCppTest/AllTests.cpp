#include "stdafx.h"
#include "AllTests.h"


#include "testfw.hpp"
#include "BLogger.hpp"
#include "Byps.hpp"
#include "Bypshttp.hpp"

LOGGER_IMPL

  using namespace byps;

void AllTests_run(void *app) {
  //    BLogger::init("/home/wolfgang/log/cppclient.txt", BLogLevel::Debug, false);
  BLogger::init("d:\\temp\\log\\cppclient.txt", BLogLevel::Info, false);

  BLogger log("AllTests");
  log.debug() << L"AllTest_run(";

  for (int i = 0; i < 1; i++) {
    cout << "loop " << (i+1) << endl;
    TestSuite suite;
	suite.add(TestFeed_create(app));
    suite.add(TestCheckinDoc_create(app));
    //suite.add(TestEventBus_create(app));

    suite.run();
  }


  l_info << "test suite finished";

  log.debug() << L")AllTest_run";
  BLogger::done();

  //l_info << "press 1 and return";
  //char ret;
  //std::cin >> ret;
}
