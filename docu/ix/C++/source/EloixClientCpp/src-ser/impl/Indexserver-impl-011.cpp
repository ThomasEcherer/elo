#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findFirstNotes
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findFirstNotes::BRequest_IXServicePortIF_findFirstNotes() : BMethodRequest(1795705954) {
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findFirstNotes::BRequest_IXServicePortIF_findFirstNotes(const PFindInfo& findInfo, int32_t max, const PNoteZ& noteZ)
	: BMethodRequest(1795705954) 
	, findInfo(findInfo)
	, max(max)
	, noteZ(noteZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findFirstNotes::BSerializable_getTypeId() {
	return 299362112; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findFirstNotes::serialize(BIO& ar, const BVERSION version) {
	ar & this->max;
	ar & this->ci;
	ar & this->findInfo;
	ar & this->noteZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findFirstNotes::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findFirstNotes(ci, findInfo, max, noteZ, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findFirstNotes::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_299362112(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findFirstNotes>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findFirstReportInfos
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findFirstReportInfos::BRequest_IXServicePortIF_findFirstReportInfos() : BMethodRequest(1795705954) {
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findFirstReportInfos::BRequest_IXServicePortIF_findFirstReportInfos(const PFindReportInfo& opts, int32_t max)
	: BMethodRequest(1795705954) 
	, opts(opts)
	, max(max)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findFirstReportInfos::BSerializable_getTypeId() {
	return 693111280; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findFirstReportInfos::serialize(BIO& ar, const BVERSION version) {
	ar & this->max;
	ar & this->ci;
	ar & this->opts;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findFirstReportInfos::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findFirstReportInfos(ci, opts, max, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findFirstReportInfos::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_693111280(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findFirstReportInfos>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findFirstSords
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findFirstSords::BRequest_IXServicePortIF_findFirstSords() : BMethodRequest(1795705954) {
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findFirstSords::BRequest_IXServicePortIF_findFirstSords(const PFindInfo& findInfo, int32_t max, const PSordZ& sordZ)
	: BMethodRequest(1795705954) 
	, findInfo(findInfo)
	, max(max)
	, sordZ(sordZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findFirstSords::BSerializable_getTypeId() {
	return 303977764; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findFirstSords::serialize(BIO& ar, const BVERSION version) {
	ar & this->max;
	ar & this->ci;
	ar & this->findInfo;
	ar & this->sordZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findFirstSords::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findFirstSords(ci, findInfo, max, sordZ, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findFirstSords::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_303977764(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findFirstSords>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findFirstSubscriptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findFirstSubscriptions::BRequest_IXServicePortIF_findFirstSubscriptions() : BMethodRequest(1795705954) {
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findFirstSubscriptions::BRequest_IXServicePortIF_findFirstSubscriptions(const PFindSubscriptionInfo& findInfo, int32_t max, const PSubscriptionZ& subsZ)
	: BMethodRequest(1795705954) 
	, findInfo(findInfo)
	, max(max)
	, subsZ(subsZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findFirstSubscriptions::BSerializable_getTypeId() {
	return 1290105973; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findFirstSubscriptions::serialize(BIO& ar, const BVERSION version) {
	ar & this->max;
	ar & this->ci;
	ar & this->findInfo;
	ar & this->subsZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findFirstSubscriptions::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findFirstSubscriptions(ci, findInfo, max, subsZ, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findFirstSubscriptions::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1290105973(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findFirstSubscriptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findFirstTasks
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findFirstTasks::BRequest_IXServicePortIF_findFirstTasks() : BMethodRequest(1795705954) {
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findFirstTasks::BRequest_IXServicePortIF_findFirstTasks(const PFindTasksInfo& findInfo, int32_t max)
	: BMethodRequest(1795705954) 
	, findInfo(findInfo)
	, max(max)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findFirstTasks::BSerializable_getTypeId() {
	return 304485389; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findFirstTasks::serialize(BIO& ar, const BVERSION version) {
	ar & this->max;
	ar & this->ci;
	ar & this->findInfo;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findFirstTasks::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findFirstTasks(ci, findInfo, max, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findFirstTasks::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_304485389(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findFirstTasks>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findFirstTranslateTerms
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findFirstTranslateTerms::BRequest_IXServicePortIF_findFirstTranslateTerms() : BMethodRequest(1795705954) {
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findFirstTranslateTerms::BRequest_IXServicePortIF_findFirstTranslateTerms(const PFindTranslateTermInfo& findInfo, int32_t max)
	: BMethodRequest(1795705954) 
	, findInfo(findInfo)
	, max(max)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findFirstTranslateTerms::BSerializable_getTypeId() {
	return 1162113222; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findFirstTranslateTerms::serialize(BIO& ar, const BVERSION version) {
	ar & this->max;
	ar & this->ci;
	ar & this->findInfo;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findFirstTranslateTerms::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findFirstTranslateTerms(ci, findInfo, max, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findFirstTranslateTerms::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1162113222(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findFirstTranslateTerms>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findFirstUsers
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findFirstUsers::BRequest_IXServicePortIF_findFirstUsers() : BMethodRequest(1795705954) {
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findFirstUsers::BRequest_IXServicePortIF_findFirstUsers(const PFindUserInfo& findUserInfo, int32_t max)
	: BMethodRequest(1795705954) 
	, findUserInfo(findUserInfo)
	, max(max)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findFirstUsers::BSerializable_getTypeId() {
	return 305931911; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findFirstUsers::serialize(BIO& ar, const BVERSION version) {
	ar & this->max;
	ar & this->ci;
	ar & this->findUserInfo;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findFirstUsers::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findFirstUsers(ci, findUserInfo, max, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findFirstUsers::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_305931911(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findFirstUsers>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findFirstWorkflows
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findFirstWorkflows::BRequest_IXServicePortIF_findFirstWorkflows() : BMethodRequest(1795705954) {
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findFirstWorkflows::BRequest_IXServicePortIF_findFirstWorkflows(const PFindWorkflowInfo& findInfo, int32_t max, const PWFDiagramZ& wfDiagramZ)
	: BMethodRequest(1795705954) 
	, findInfo(findInfo)
	, max(max)
	, wfDiagramZ(wfDiagramZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findFirstWorkflows::BSerializable_getTypeId() {
	return 546938477; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findFirstWorkflows::serialize(BIO& ar, const BVERSION version) {
	ar & this->max;
	ar & this->ci;
	ar & this->findInfo;
	ar & this->wfDiagramZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findFirstWorkflows::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findFirstWorkflows(ci, findInfo, max, wfDiagramZ, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findFirstWorkflows::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_546938477(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findFirstWorkflows>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findNextActivities
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findNextActivities::BRequest_IXServicePortIF_findNextActivities() : BMethodRequest(1795705954) {
	idx = 0;
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findNextActivities::BRequest_IXServicePortIF_findNextActivities(const ::std::wstring& searchId, int32_t idx, int32_t max, const PActivityZ& activityZ)
	: BMethodRequest(1795705954) 
	, searchId(searchId)
	, idx(idx)
	, max(max)
	, activityZ(activityZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findNextActivities::BSerializable_getTypeId() {
	return 2116795663; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findNextActivities::serialize(BIO& ar, const BVERSION version) {
	ar & this->idx;
	ar & this->max;
	ar & this->searchId;
	ar & this->activityZ;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findNextActivities::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findNextActivities(ci, searchId, idx, max, activityZ, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findNextActivities::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2116795663(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findNextActivities>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findNextConfigFiles
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findNextConfigFiles::BRequest_IXServicePortIF_findNextConfigFiles() : BMethodRequest(1795705954) {
	idx = 0;
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findNextConfigFiles::BRequest_IXServicePortIF_findNextConfigFiles(const ::std::wstring& searchId, int32_t idx, int32_t max, const PConfigFileZ& configFileZ)
	: BMethodRequest(1795705954) 
	, searchId(searchId)
	, idx(idx)
	, max(max)
	, configFileZ(configFileZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findNextConfigFiles::BSerializable_getTypeId() {
	return 2108007283; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findNextConfigFiles::serialize(BIO& ar, const BVERSION version) {
	ar & this->idx;
	ar & this->max;
	ar & this->searchId;
	ar & this->ci;
	ar & this->configFileZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findNextConfigFiles::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findNextConfigFiles(ci, searchId, idx, max, configFileZ, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findNextConfigFiles::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2108007283(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findNextConfigFiles>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findNextNotes
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findNextNotes::BRequest_IXServicePortIF_findNextNotes() : BMethodRequest(1795705954) {
	idx = 0;
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findNextNotes::BRequest_IXServicePortIF_findNextNotes(const ::std::wstring& searchId, int32_t idx, int32_t max, const PNoteZ& noteZ)
	: BMethodRequest(1795705954) 
	, searchId(searchId)
	, idx(idx)
	, max(max)
	, noteZ(noteZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findNextNotes::BSerializable_getTypeId() {
	return 1493835871; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findNextNotes::serialize(BIO& ar, const BVERSION version) {
	ar & this->idx;
	ar & this->max;
	ar & this->searchId;
	ar & this->ci;
	ar & this->noteZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findNextNotes::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findNextNotes(ci, searchId, idx, max, noteZ, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findNextNotes::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1493835871(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findNextNotes>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findNextReportInfos
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findNextReportInfos::BRequest_IXServicePortIF_findNextReportInfos() : BMethodRequest(1795705954) {
	idx = 0;
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findNextReportInfos::BRequest_IXServicePortIF_findNextReportInfos(const ::std::wstring& searchId, int32_t idx, int32_t max)
	: BMethodRequest(1795705954) 
	, searchId(searchId)
	, idx(idx)
	, max(max)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findNextReportInfos::BSerializable_getTypeId() {
	return 1846849487; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findNextReportInfos::serialize(BIO& ar, const BVERSION version) {
	ar & this->idx;
	ar & this->max;
	ar & this->searchId;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findNextReportInfos::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findNextReportInfos(ci, searchId, idx, max, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findNextReportInfos::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1846849487(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findNextReportInfos>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findNextSords
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findNextSords::BRequest_IXServicePortIF_findNextSords() : BMethodRequest(1795705954) {
	idx = 0;
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findNextSords::BRequest_IXServicePortIF_findNextSords(const ::std::wstring& searchId, int32_t idx, int32_t max, const PSordZ& sordZ)
	: BMethodRequest(1795705954) 
	, searchId(searchId)
	, idx(idx)
	, max(max)
	, sordZ(sordZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findNextSords::BSerializable_getTypeId() {
	return 1498451523; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findNextSords::serialize(BIO& ar, const BVERSION version) {
	ar & this->idx;
	ar & this->max;
	ar & this->searchId;
	ar & this->ci;
	ar & this->sordZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findNextSords::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findNextSords(ci, searchId, idx, max, sordZ, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findNextSords::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1498451523(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findNextSords>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findNextSubscriptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findNextSubscriptions::BRequest_IXServicePortIF_findNextSubscriptions() : BMethodRequest(1795705954) {
	idx = 0;
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findNextSubscriptions::BRequest_IXServicePortIF_findNextSubscriptions(const ::std::wstring& searchId, int32_t idx, int32_t max, const PSubscriptionZ& subsZ)
	: BMethodRequest(1795705954) 
	, searchId(searchId)
	, idx(idx)
	, max(max)
	, subsZ(subsZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findNextSubscriptions::BSerializable_getTypeId() {
	return 1930960532; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findNextSubscriptions::serialize(BIO& ar, const BVERSION version) {
	ar & this->idx;
	ar & this->max;
	ar & this->searchId;
	ar & this->ci;
	ar & this->subsZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findNextSubscriptions::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findNextSubscriptions(ci, searchId, idx, max, subsZ, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findNextSubscriptions::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1930960532(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findNextSubscriptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findNextTasks
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findNextTasks::BRequest_IXServicePortIF_findNextTasks() : BMethodRequest(1795705954) {
	idx = 0;
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findNextTasks::BRequest_IXServicePortIF_findNextTasks(const ::std::wstring& searchId, int32_t idx, int32_t max)
	: BMethodRequest(1795705954) 
	, searchId(searchId)
	, idx(idx)
	, max(max)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findNextTasks::BSerializable_getTypeId() {
	return 1498959148; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findNextTasks::serialize(BIO& ar, const BVERSION version) {
	ar & this->idx;
	ar & this->max;
	ar & this->searchId;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findNextTasks::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findNextTasks(ci, searchId, idx, max, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findNextTasks::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1498959148(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findNextTasks>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findNextTranslateTerms
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findNextTranslateTerms::BRequest_IXServicePortIF_findNextTranslateTerms() : BMethodRequest(1795705954) {
	idx = 0;
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findNextTranslateTerms::BRequest_IXServicePortIF_findNextTranslateTerms(const ::std::wstring& searchId, int32_t idx, int32_t max)
	: BMethodRequest(1795705954) 
	, searchId(searchId)
	, idx(idx)
	, max(max)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findNextTranslateTerms::BSerializable_getTypeId() {
	return 1524508923; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findNextTranslateTerms::serialize(BIO& ar, const BVERSION version) {
	ar & this->idx;
	ar & this->max;
	ar & this->searchId;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findNextTranslateTerms::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findNextTranslateTerms(ci, searchId, idx, max, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findNextTranslateTerms::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1524508923(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findNextTranslateTerms>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findNextUsers
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findNextUsers::BRequest_IXServicePortIF_findNextUsers() : BMethodRequest(1795705954) {
	idx = 0;
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findNextUsers::BRequest_IXServicePortIF_findNextUsers(const ::std::wstring& searchId, int32_t idx, int32_t max)
	: BMethodRequest(1795705954) 
	, searchId(searchId)
	, idx(idx)
	, max(max)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findNextUsers::BSerializable_getTypeId() {
	return 1500405670; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findNextUsers::serialize(BIO& ar, const BVERSION version) {
	ar & this->idx;
	ar & this->max;
	ar & this->searchId;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findNextUsers::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findNextUsers(ci, searchId, idx, max, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findNextUsers::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1500405670(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findNextUsers>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_findNextWorkflows
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_findNextWorkflows::BRequest_IXServicePortIF_findNextWorkflows() : BMethodRequest(1795705954) {
	index = 0;
	maxResults = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_findNextWorkflows::BRequest_IXServicePortIF_findNextWorkflows(const ::std::wstring& searchId, int32_t index, int32_t maxResults)
	: BMethodRequest(1795705954) 
	, searchId(searchId)
	, index(index)
	, maxResults(maxResults)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_findNextWorkflows::BSerializable_getTypeId() {
	return 1653142322; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_findNextWorkflows::serialize(BIO& ar, const BVERSION version) {
	ar & this->index;
	ar & this->maxResults;
	ar & this->searchId;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_findNextWorkflows::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->findNextWorkflows(ci, searchId, index, maxResults, [__byps__asyncResult](PFindResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1301335819(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_findNextWorkflows::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1653142322(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_findNextWorkflows>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_finishExport
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_finishExport::BRequest_IXServicePortIF_finishExport() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_finishExport::BRequest_IXServicePortIF_finishExport(const ::std::wstring& exportId)
	: BMethodRequest(1795705954) 
	, exportId(exportId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_finishExport::BSerializable_getTypeId() {
	return 1487849891; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_finishExport::serialize(BIO& ar, const BVERSION version) {
	ar & this->exportId;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_finishExport::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->finishExport(ci, exportId, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_finishExport::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1487849891(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_finishExport>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_forwardWorkflowNode
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_forwardWorkflowNode::BRequest_IXServicePortIF_forwardWorkflowNode() : BMethodRequest(1795705954) {
	flowId = 0;
	nodeId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_forwardWorkflowNode::BRequest_IXServicePortIF_forwardWorkflowNode(int32_t flowId, int32_t nodeId, const PForwardWorkflowNodeInfo& fwdInfo, const PLockZ& unlockZ)
	: BMethodRequest(1795705954) 
	, flowId(flowId)
	, nodeId(nodeId)
	, fwdInfo(fwdInfo)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_forwardWorkflowNode::BSerializable_getTypeId() {
	return 572079312; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_forwardWorkflowNode::serialize(BIO& ar, const BVERSION version) {
	ar & this->flowId;
	ar & this->nodeId;
	ar & this->ci;
	ar & this->fwdInfo;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_forwardWorkflowNode::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->forwardWorkflowNode(ci, flowId, nodeId, fwdInfo, unlockZ, [__byps__asyncResult](PForwardWorkflowNodeResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1699606509(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_forwardWorkflowNode::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_572079312(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_forwardWorkflowNode>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_getAclAccess
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_getAclAccess::BRequest_IXServicePortIF_getAclAccess() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_getAclAccess::BRequest_IXServicePortIF_getAclAccess(const PAclAccessInfo& aai)
	: BMethodRequest(1795705954) 
	, aai(aai)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_getAclAccess::BSerializable_getTypeId() {
	return 939270158; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_getAclAccess::serialize(BIO& ar, const BVERSION version) {
	ar & this->aai;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_getAclAccess::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->getAclAccess(ci, aai, [__byps__asyncResult](PAclAccessResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_200528028(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_getAclAccess::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_939270158(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_getAclAccess>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_getArchiveStatistics
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_getArchiveStatistics::BRequest_IXServicePortIF_getArchiveStatistics() : BMethodRequest(1795705954) {
	opts = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_getArchiveStatistics::BRequest_IXServicePortIF_getArchiveStatistics(int64_t opts)
	: BMethodRequest(1795705954) 
	, opts(opts)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_getArchiveStatistics::BSerializable_getTypeId() {
	return 538085115; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_getArchiveStatistics::serialize(BIO& ar, const BVERSION version) {
	ar & this->opts;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_getArchiveStatistics::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->getArchiveStatistics(ci, opts, [__byps__asyncResult](PArchiveStatistics __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_2056457945(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_getArchiveStatistics::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_538085115(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_getArchiveStatistics>(bio, pObj, pObjS, pBase);	
}
}}}}
