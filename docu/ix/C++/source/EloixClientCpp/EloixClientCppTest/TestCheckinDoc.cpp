#include "stdafx.h"
#include "IXAPI.h"
#include "AllTests.h"

using namespace de::elo::test;
using namespace de::elo::ix::client;

class TestCheckinDoc : public TestBase {
	static BLogger log;


public:
	TestCheckinDoc() : TestBase() {
  }

  virtual void init() {
    ADD_TEST(testCheckinDownload);
  }

  void testCheckinDownload() {
    l_info << L"testCheckinDownload(";

    PEditInfo ed = conn->ix()->createDoc(L"1", L"", L"", EditInfoC::mbSordDocAtt);
    PSord sord = ed->getSord();
    sord->setName(L"hallo c++");
    
    PDocument doc = ed->getDocument();
    vector<PDocVersion> docs;
    PDocVersion dv(new DocVersion());
    docs.push_back(dv);

    dv->setExt(L"txt");
    doc->setDocs(byps_ptr<BArray1<PDocVersion> > (new BArray1<PDocVersion>(docs)));

    doc = conn->ix()->checkinDocBegin(doc);
    dv = doc->getDocs()->at(0);

	//wstring tempFile = L"f:\\kreschi\\0_Physikunterricht für die Sekundarstufe I im Spieg - Kopie.pdf";
	//
 //   HANDLE hfile = ::CreateFile(tempFile.c_str(), GENERIC_READ, 0, NULL, OPEN_EXISTING, 0, NULL);
 //   __int64 fsize2 = ::GetFileSize(hfile, NULL);
 //   ::CloseHandle(hfile);

    

	wstring tempFile = createTestFile();
	__int64 fsize = BFile(tempFile).size();

    wstring uploadResult = conn->upload(dv->getUrl(), tempFile);
    dv->setUploadResult(uploadResult);

    doc = conn->ix()->checkinDocEnd(sord, SordC::mbAll, doc, LockC::NO);

    ed = conn->ix()->checkoutDoc(doc->getObjId(), L"", EditInfoC::mbAll, LockC::NO);
    doc = ed->getDocument();
    sord = ed->getSord();

    dv = doc->getDocs()->at(0);
    wstring fileName = getTempFileName();
    conn->download(dv->getUrl(), fileName);

    wstring md5 = dv->getMd5();
    ed = conn->ix()->checkoutDoc(L"MD5:" + md5, L"", EditInfoC::mbAll, LockC::NO);

    PDeleteOptions opts(new DeleteOptions());
    conn->ix()->deleteSord(L"", sord->getGuid(), LockC::FORCE, opts);
    opts->setDeleteFinally(true);
    conn->ix()->deleteSord(L"", sord->getGuid(), LockC::FORCE, opts);

    l_info << L")testCheckinDownload";
  }

};

BLogger TestCheckinDoc::log("TestCheckinDoc");

TestCase* TestCheckinDoc_create(void* app) {
	return new TestCheckinDoc();
}
