
#ifndef TESTUTILHTTP_H_
#define TESTUTILHTTP_H_

#include "Byps.h"
#include "Bypshttp.h"
#include "testfw.h"
#include "IXAPI.h"

namespace de { namespace elo { namespace test {

  using namespace de::elo::ix::client;
  using namespace std;

class TestUtilHttp {
public:
	static PIXConnection createConnection(const wchar_t* computerName = NULL, const wchar_t* runAs = NULL);
  static PIXConnFactory createConnFactory();


	static byps_ptr<vector<byps::PContentStream> > makeTestStreams();
};

}}}

#endif