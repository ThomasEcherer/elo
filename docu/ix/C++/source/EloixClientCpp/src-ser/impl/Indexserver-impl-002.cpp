#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXEventBusHandler_processEventBusEvents
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXEventBusHandler_processEventBusEvents::BRequest_IXEventBusHandler_processEventBusEvents() : BMethodRequest(627994447) {
	subsId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXEventBusHandler_processEventBusEvents::BRequest_IXEventBusHandler_processEventBusEvents(int64_t subsId, const PArrayEvent& events)
	: BMethodRequest(627994447) 
	, subsId(subsId)
	, events(events)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXEventBusHandler_processEventBusEvents::BSerializable_getTypeId() {
	return 1736645961; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXEventBusHandler_processEventBusEvents::serialize(BIO& ar, const BVERSION version) {
	ar & this->subsId;
	ar & this->events;
}
void de::elo::ix::client::BRequest_IXEventBusHandler_processEventBusEvents::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXEventBusHandler __byps__remoteT = byps_ptr_cast<IXEventBusHandler>(__byps__remote);
	__byps__remoteT->processEventBusEvents(subsId, events, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1736645961(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXEventBusHandler_processEventBusEvents>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_executeRegisteredFunction
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_executeRegisteredFunction::BRequest_IXServerEvents_executeRegisteredFunction() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_executeRegisteredFunction::BRequest_IXServerEvents_executeRegisteredFunction(const PIXServerEventsContext& ec, const ::std::wstring& functionName, const PAny& any)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, functionName(functionName)
	, any(any)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_executeRegisteredFunction::BSerializable_getTypeId() {
	return 1363890826; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_executeRegisteredFunction::serialize(BIO& ar, const BVERSION version) {
	ar & this->functionName;
	ar & this->any;
	ar & this->ec;
}
void de::elo::ix::client::BRequest_IXServerEvents_executeRegisteredFunction::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->executeRegisteredFunction(ec, functionName, any, [__byps__asyncResult](PAny __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1191976387(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1363890826(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_executeRegisteredFunction>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_executeRegisteredFunctionString
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_executeRegisteredFunctionString::BRequest_IXServerEvents_executeRegisteredFunctionString() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_executeRegisteredFunctionString::BRequest_IXServerEvents_executeRegisteredFunctionString(const PIXServerEventsContext& ec, const ::std::wstring& functionName, const ::std::wstring& args)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, functionName(functionName)
	, args(args)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_executeRegisteredFunctionString::BSerializable_getTypeId() {
	return 1679329575; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_executeRegisteredFunctionString::serialize(BIO& ar, const BVERSION version) {
	ar & this->args;
	ar & this->functionName;
	ar & this->ec;
}
void de::elo::ix::client::BRequest_IXServerEvents_executeRegisteredFunctionString::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->executeRegisteredFunctionString(ec, functionName, args, [__byps__asyncResult](::std::wstring __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_10(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1679329575(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_executeRegisteredFunctionString>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_getAppInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_getAppInfo::BRequest_IXServerEvents_getAppInfo() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_getAppInfo::BRequest_IXServerEvents_getAppInfo(const PIXServerEventsContext& ec)
	: BMethodRequest(1938363825) 
	, ec(ec)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_getAppInfo::BSerializable_getTypeId() {
	return 1887140750; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_getAppInfo::serialize(BIO& ar, const BVERSION version) {
	ar & this->ec;
}
void de::elo::ix::client::BRequest_IXServerEvents_getAppInfo::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->getAppInfo(ec, [__byps__asyncResult](::std::wstring __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_10(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1887140750(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_getAppInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_getUserNames
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_getUserNames::BRequest_IXServerEvents_getUserNames() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_getUserNames::BRequest_IXServerEvents_getUserNames(const PIXServerEventsContext& ec, const PArrayString& ids, const PCheckoutUsersZ& checkoutUsersZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, ids(ids)
	, checkoutUsersZ(checkoutUsersZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_getUserNames::BSerializable_getTypeId() {
	return 1950460032; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_getUserNames::serialize(BIO& ar, const BVERSION version) {
	ar & this->checkoutUsersZ;
	ar & this->ec;
	ar & this->ids;
}
void de::elo::ix::client::BRequest_IXServerEvents_getUserNames::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->getUserNames(ec, ids, checkoutUsersZ, [__byps__asyncResult](PArrayUserName __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1001617329(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1950460032(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_getUserNames>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_hasMethod
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_hasMethod::BRequest_IXServerEvents_hasMethod() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_hasMethod::BRequest_IXServerEvents_hasMethod(const PIXServerEventsContext& ec, const ::std::wstring& methodName)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, methodName(methodName)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_hasMethod::BSerializable_getTypeId() {
	return 110863678; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_hasMethod::serialize(BIO& ar, const BVERSION version) {
	ar & this->methodName;
	ar & this->ec;
}
void de::elo::ix::client::BRequest_IXServerEvents_hasMethod::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->hasMethod(ec, methodName, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_110863678(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_hasMethod>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onAfterCheckinActivity
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onAfterCheckinActivity::BRequest_IXServerEvents_onAfterCheckinActivity() : BMethodRequest(1938363825) {
	isNew = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinActivity::BRequest_IXServerEvents_onAfterCheckinActivity(const PIXServerEventsContext& ec, const PActivity& act, bool isNew, const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, act(act)
	, isNew(isNew)
	, sord(sord)
	, sordZ(sordZ)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinActivity::BSerializable_getTypeId() {
	return 1027171864; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onAfterCheckinActivity::serialize(BIO& ar, const BVERSION version) {
	ar & this->isNew;
	ar & this->act;
	ar & this->ec;
	ar & this->sord;
	ar & this->sordZ;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinActivity::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onAfterCheckinActivity(ec, act, isNew, sord, sordZ, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1027171864(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinActivity>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onAfterCheckinDocEnd
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onAfterCheckinDocEnd::BRequest_IXServerEvents_onAfterCheckinDocEnd() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinDocEnd::BRequest_IXServerEvents_onAfterCheckinDocEnd(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PDocument& doc, const PSordZ& sordZ, const PLockZ& unlockZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, sord(sord)
	, sordDB(sordDB)
	, parentSord(parentSord)
	, doc(doc)
	, sordZ(sordZ)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinDocEnd::BSerializable_getTypeId() {
	return 1920958924; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onAfterCheckinDocEnd::serialize(BIO& ar, const BVERSION version) {
	ar & this->doc;
	ar & this->ec;
	ar & this->parentSord;
	ar & this->sord;
	ar & this->sordDB;
	ar & this->sordZ;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinDocEnd::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onAfterCheckinDocEnd(ec, sord, sordDB, parentSord, doc, sordZ, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1920958924(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinDocEnd>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onAfterCheckinMap
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onAfterCheckinMap::BRequest_IXServerEvents_onAfterCheckinMap() : BMethodRequest(1938363825) {
	objId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinMap::BRequest_IXServerEvents_onAfterCheckinMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, int32_t objId, const PArrayKeyValue& data, const PLockZ& unlockZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, domainName(domainName)
	, id(id)
	, objId(objId)
	, data(data)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinMap::BSerializable_getTypeId() {
	return 1002917709; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onAfterCheckinMap::serialize(BIO& ar, const BVERSION version) {
	ar & this->domainName;
	ar & this->id;
	ar & this->objId;
	ar & this->data;
	ar & this->ec;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinMap::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onAfterCheckinMap(ec, domainName, id, objId, data, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1002917709(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinMap>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onAfterCheckinNotes
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onAfterCheckinNotes::BRequest_IXServerEvents_onAfterCheckinNotes() : BMethodRequest(1938363825) {
	noteC = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinNotes::BRequest_IXServerEvents_onAfterCheckinNotes(const PIXServerEventsContext& ec, const PArrayNote& notes, const PArraySord& sords, int64_t noteC, const PLockZ& unlockZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, notes(notes)
	, sords(sords)
	, noteC(noteC)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinNotes::BSerializable_getTypeId() {
	return 1729896360; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onAfterCheckinNotes::serialize(BIO& ar, const BVERSION version) {
	ar & this->noteC;
	ar & this->ec;
	ar & this->notes;
	ar & this->sords;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinNotes::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onAfterCheckinNotes(ec, notes, sords, noteC, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1729896360(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinNotes>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onAfterCheckinReminder
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onAfterCheckinReminder::BRequest_IXServerEvents_onAfterCheckinReminder() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinReminder::BRequest_IXServerEvents_onAfterCheckinReminder(const PIXServerEventsContext& ec, const PArrayReminder& remiArray, const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, remiArray(remiArray)
	, sord(sord)
	, sordZ(sordZ)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinReminder::BSerializable_getTypeId() {
	return 2130431109; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onAfterCheckinReminder::serialize(BIO& ar, const BVERSION version) {
	ar & this->ec;
	ar & this->remiArray;
	ar & this->sord;
	ar & this->sordZ;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinReminder::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onAfterCheckinReminder(ec, remiArray, sord, sordZ, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2130431109(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinReminder>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onAfterCheckinSord
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onAfterCheckinSord::BRequest_IXServerEvents_onAfterCheckinSord() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinSord::BRequest_IXServerEvents_onAfterCheckinSord(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PSordZ& sordZ, const PLockZ& unlockZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, sord(sord)
	, sordDB(sordDB)
	, parentSord(parentSord)
	, sordZ(sordZ)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinSord::BSerializable_getTypeId() {
	return 1025485545; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onAfterCheckinSord::serialize(BIO& ar, const BVERSION version) {
	ar & this->ec;
	ar & this->parentSord;
	ar & this->sord;
	ar & this->sordDB;
	ar & this->sordZ;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinSord::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onAfterCheckinSord(ec, sord, sordDB, parentSord, sordZ, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1025485545(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinSord>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onAfterCheckinUsers
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onAfterCheckinUsers::BRequest_IXServerEvents_onAfterCheckinUsers() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinUsers::BRequest_IXServerEvents_onAfterCheckinUsers(const PIXServerEventsContext& ec, const PArrayUserInfo& userInfos, const PCheckinUsersZ& checkinUsersZ, const PLockZ& unlockZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, userInfos(userInfos)
	, checkinUsersZ(checkinUsersZ)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinUsers::BSerializable_getTypeId() {
	return 1723326561; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onAfterCheckinUsers::serialize(BIO& ar, const BVERSION version) {
	ar & this->checkinUsersZ;
	ar & this->ec;
	ar & this->unlockZ;
	ar & this->userInfos;
}
void de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinUsers::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onAfterCheckinUsers(ec, userInfos, checkinUsersZ, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1723326561(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinUsers>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onAfterDeleteMap
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onAfterDeleteMap::BRequest_IXServerEvents_onAfterDeleteMap() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onAfterDeleteMap::BRequest_IXServerEvents_onAfterDeleteMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, const PArrayString& keyNames, const PLockZ& unlockZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, domainName(domainName)
	, id(id)
	, keyNames(keyNames)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onAfterDeleteMap::BSerializable_getTypeId() {
	return 40991853; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onAfterDeleteMap::serialize(BIO& ar, const BVERSION version) {
	ar & this->domainName;
	ar & this->id;
	ar & this->ec;
	ar & this->keyNames;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onAfterDeleteMap::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onAfterDeleteMap(ec, domainName, id, keyNames, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_40991853(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onAfterDeleteMap>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onAfterDeleteSord
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onAfterDeleteSord::BRequest_IXServerEvents_onAfterDeleteSord() : BMethodRequest(1938363825) {
	ret = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onAfterDeleteSord::BRequest_IXServerEvents_onAfterDeleteSord(const PIXServerEventsContext& ec, const PSord& parentSord, const PSord& sord, const PLockZ& unlockZ, const PDeleteOptions& delOpts, bool ret)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, parentSord(parentSord)
	, sord(sord)
	, unlockZ(unlockZ)
	, delOpts(delOpts)
	, ret(ret)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onAfterDeleteSord::BSerializable_getTypeId() {
	return 1270939805; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onAfterDeleteSord::serialize(BIO& ar, const BVERSION version) {
	ar & this->ret;
	ar & this->delOpts;
	ar & this->ec;
	ar & this->parentSord;
	ar & this->sord;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onAfterDeleteSord::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onAfterDeleteSord(ec, parentSord, sord, unlockZ, delOpts, ret, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1270939805(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onAfterDeleteSord>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onAfterEndEditWorkFlowNode
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onAfterEndEditWorkFlowNode::BRequest_IXServerEvents_onAfterEndEditWorkFlowNode() : BMethodRequest(1938363825) {
	nodeId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onAfterEndEditWorkFlowNode::BRequest_IXServerEvents_onAfterEndEditWorkFlowNode(const PIXServerEventsContext& ec, const PWFDiagram& workflow, int32_t nodeId, const PSord& sord, const PSordZ& sordZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, workflow(workflow)
	, nodeId(nodeId)
	, sord(sord)
	, sordZ(sordZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onAfterEndEditWorkFlowNode::BSerializable_getTypeId() {
	return 812031586; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onAfterEndEditWorkFlowNode::serialize(BIO& ar, const BVERSION version) {
	ar & this->nodeId;
	ar & this->ec;
	ar & this->sord;
	ar & this->sordZ;
	ar & this->workflow;
}
void de::elo::ix::client::BRequest_IXServerEvents_onAfterEndEditWorkFlowNode::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onAfterEndEditWorkFlowNode(ec, workflow, nodeId, sord, sordZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_812031586(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onAfterEndEditWorkFlowNode>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onAfterLogin
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onAfterLogin::BRequest_IXServerEvents_onAfterLogin() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onAfterLogin::BRequest_IXServerEvents_onAfterLogin(const PIXServerEventsContext& ec, const ::std::wstring& userName, const PLoginScriptOptions& opts)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, userName(userName)
	, opts(opts)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onAfterLogin::BSerializable_getTypeId() {
	return 1693784539; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onAfterLogin::serialize(BIO& ar, const BVERSION version) {
	ar & this->userName;
	ar & this->ec;
	ar & this->opts;
}
void de::elo::ix::client::BRequest_IXServerEvents_onAfterLogin::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onAfterLogin(ec, userName, opts, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1693784539(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onAfterLogin>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onAfterRefSord
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onAfterRefSord::BRequest_IXServerEvents_onAfterRefSord() : BMethodRequest(1938363825) {
	manSortIndex = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onAfterRefSord::BRequest_IXServerEvents_onAfterRefSord(const PIXServerEventsContext& ec, const PSord& parentSordOld, const PSord& parentSordNew, const PSord& sord, int32_t manSortIndex)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, parentSordOld(parentSordOld)
	, parentSordNew(parentSordNew)
	, sord(sord)
	, manSortIndex(manSortIndex)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onAfterRefSord::BSerializable_getTypeId() {
	return 807852157; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onAfterRefSord::serialize(BIO& ar, const BVERSION version) {
	ar & this->manSortIndex;
	ar & this->ec;
	ar & this->parentSordNew;
	ar & this->parentSordOld;
	ar & this->sord;
}
void de::elo::ix::client::BRequest_IXServerEvents_onAfterRefSord::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onAfterRefSord(ec, parentSordOld, parentSordNew, sord, manSortIndex, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_807852157(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onAfterRefSord>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onAfterStartWorkFlow
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onAfterStartWorkFlow::BRequest_IXServerEvents_onAfterStartWorkFlow() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onAfterStartWorkFlow::BRequest_IXServerEvents_onAfterStartWorkFlow(const PIXServerEventsContext& ec, const PWFDiagram& workflow, const PSord& sord, const PSordZ& sordZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, workflow(workflow)
	, sord(sord)
	, sordZ(sordZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onAfterStartWorkFlow::BSerializable_getTypeId() {
	return 527527197; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onAfterStartWorkFlow::serialize(BIO& ar, const BVERSION version) {
	ar & this->ec;
	ar & this->sord;
	ar & this->sordZ;
	ar & this->workflow;
}
void de::elo::ix::client::BRequest_IXServerEvents_onAfterStartWorkFlow::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onAfterStartWorkFlow(ec, workflow, sord, sordZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_527527197(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onAfterStartWorkFlow>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onBeforeCheckinActivity
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onBeforeCheckinActivity::BRequest_IXServerEvents_onBeforeCheckinActivity() : BMethodRequest(1938363825) {
	isNew = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinActivity::BRequest_IXServerEvents_onBeforeCheckinActivity(const PIXServerEventsContext& ec, const PActivity& act, bool isNew, const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, act(act)
	, isNew(isNew)
	, sord(sord)
	, sordZ(sordZ)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinActivity::BSerializable_getTypeId() {
	return 1917517477; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onBeforeCheckinActivity::serialize(BIO& ar, const BVERSION version) {
	ar & this->isNew;
	ar & this->act;
	ar & this->ec;
	ar & this->sord;
	ar & this->sordZ;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinActivity::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onBeforeCheckinActivity(ec, act, isNew, sord, sordZ, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1917517477(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinActivity>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onBeforeCheckinDocEnd
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onBeforeCheckinDocEnd::BRequest_IXServerEvents_onBeforeCheckinDocEnd() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinDocEnd::BRequest_IXServerEvents_onBeforeCheckinDocEnd(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PDocument& doc, const PSordZ& sordZ, const PLockZ& unlockZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, sord(sord)
	, sordDB(sordDB)
	, parentSord(parentSord)
	, doc(doc)
	, sordZ(sordZ)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinDocEnd::BSerializable_getTypeId() {
	return 129508967; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onBeforeCheckinDocEnd::serialize(BIO& ar, const BVERSION version) {
	ar & this->doc;
	ar & this->ec;
	ar & this->parentSord;
	ar & this->sord;
	ar & this->sordDB;
	ar & this->sordZ;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinDocEnd::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onBeforeCheckinDocEnd(ec, sord, sordDB, parentSord, doc, sordZ, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_129508967(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinDocEnd>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onBeforeCheckinMap
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onBeforeCheckinMap::BRequest_IXServerEvents_onBeforeCheckinMap() : BMethodRequest(1938363825) {
	objId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinMap::BRequest_IXServerEvents_onBeforeCheckinMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, int32_t objId, const PArrayKeyValue& data, const PLockZ& unlockZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, domainName(domainName)
	, id(id)
	, objId(objId)
	, data(data)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinMap::BSerializable_getTypeId() {
	return 1578945530; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onBeforeCheckinMap::serialize(BIO& ar, const BVERSION version) {
	ar & this->domainName;
	ar & this->id;
	ar & this->objId;
	ar & this->data;
	ar & this->ec;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinMap::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onBeforeCheckinMap(ec, domainName, id, objId, data, unlockZ, [__byps__asyncResult](PArrayKeyValue __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1826370901(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1578945530(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinMap>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onBeforeCheckinNotes
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onBeforeCheckinNotes::BRequest_IXServerEvents_onBeforeCheckinNotes() : BMethodRequest(1938363825) {
	noteC = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinNotes::BRequest_IXServerEvents_onBeforeCheckinNotes(const PIXServerEventsContext& ec, const PArrayNote& notes, const PArraySord& sords, int64_t noteC, const PLockZ& unlockZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, notes(notes)
	, sords(sords)
	, noteC(noteC)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinNotes::BSerializable_getTypeId() {
	return 1241851157; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onBeforeCheckinNotes::serialize(BIO& ar, const BVERSION version) {
	ar & this->noteC;
	ar & this->ec;
	ar & this->notes;
	ar & this->sords;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinNotes::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onBeforeCheckinNotes(ec, notes, sords, noteC, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_19(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1241851157(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinNotes>(bio, pObj, pObjS, pBase);	
}
}}}}
