#include "stdafx.h"
#include "IXAPI.h"
#include "AllTests.h"

using namespace de::elo::test;
using namespace de::elo::ix::client;
using namespace de::elo::ix::client::feed;

class TestFeed : public TestBase {
	static BLogger log;


public:
	TestFeed() : TestBase() {
	}

	virtual void init() {
		ADD_TEST(testInternalInsertSystemAction);
	}

	void testInternalInsertSystemAction() {
		l_info << L"testInternalInsertSystemAction(";

		PEditInfo ed = conn->ix()->createDoc(L"1", L"", L"", EditInfoC::mbSordDocAtt);
		PSord sord = ed->getSord();
		sord->setName(L"hallo feed");

		PDocument doc = ed->getDocument();
		vector<PDocVersion> docs;
		PDocVersion dv(new DocVersion());
		docs.push_back(dv);
		doc->setDocs(byps_ptr<BArray1<PDocVersion> >(new BArray1<PDocVersion>(docs)));

		dv->setExt(L"txt");

		PFileData fileData(new FileData());
		PBytes bytes(BBytes::create('A', 'B', 'C'));
		fileData->setData(bytes);
		dv->setFileData(fileData);

		doc = conn->ix()->checkinDocEnd(sord, SordC::mbAll, doc, LockC::NO);

		dv = doc->getDocs()->at(0);
		wstring docGuid = dv->getGuid();



		PFeedServiceAuth feed_service = conn->getFeedService();
		PAction  feed_action(new Action());
		feed_action->setType(EActionType::VersionCreated);
		feed_action->setDocVersionGuid(docGuid);
		feed_action = feed_service->internalInsertSystemAction(feed_action);


		l_info << L")testInternalInsertSystemAction";
	}
};

BLogger TestFeed::log("TestFeed");

TestCase* TestFeed_create(void* app) {
	return new TestFeed();
}
