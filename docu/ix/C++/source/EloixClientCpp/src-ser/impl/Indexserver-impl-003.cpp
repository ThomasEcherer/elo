#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onBeforeCheckinSord
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onBeforeCheckinSord::BRequest_IXServerEvents_onBeforeCheckinSord() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinSord::BRequest_IXServerEvents_onBeforeCheckinSord(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PSordZ& sordZ, const PLockZ& unlockZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, sord(sord)
	, sordDB(sordDB)
	, parentSord(parentSord)
	, sordZ(sordZ)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinSord::BSerializable_getTypeId() {
	return 1702478812; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onBeforeCheckinSord::serialize(BIO& ar, const BVERSION version) {
	ar & this->ec;
	ar & this->parentSord;
	ar & this->sord;
	ar & this->sordDB;
	ar & this->sordZ;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinSord::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onBeforeCheckinSord(ec, sord, sordDB, parentSord, sordZ, unlockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void BSerializer_1702478812(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinSord>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onBeforeCheckinUsers
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onBeforeCheckinUsers::BRequest_IXServerEvents_onBeforeCheckinUsers() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinUsers::BRequest_IXServerEvents_onBeforeCheckinUsers(const PIXServerEventsContext& ec, const PArrayUserInfo& userInfos, const PCheckinUsersZ& checkinUsersZ, const PLockZ& unlockZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, userInfos(userInfos)
	, checkinUsersZ(checkinUsersZ)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinUsers::BSerializable_getTypeId() {
	return 1235281358; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onBeforeCheckinUsers::serialize(BIO& ar, const BVERSION version) {
	ar & this->checkinUsersZ;
	ar & this->ec;
	ar & this->unlockZ;
	ar & this->userInfos;
}
void de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinUsers::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onBeforeCheckinUsers(ec, userInfos, checkinUsersZ, unlockZ, [__byps__asyncResult](PArrayUserInfo __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1132956238(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1235281358(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinUsers>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onBeforeDeleteMap
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onBeforeDeleteMap::BRequest_IXServerEvents_onBeforeDeleteMap() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onBeforeDeleteMap::BRequest_IXServerEvents_onBeforeDeleteMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, const PArrayString& keyNames, const PLockZ& unlockZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, domainName(domainName)
	, id(id)
	, keyNames(keyNames)
	, unlockZ(unlockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onBeforeDeleteMap::BSerializable_getTypeId() {
	return 393231686; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onBeforeDeleteMap::serialize(BIO& ar, const BVERSION version) {
	ar & this->domainName;
	ar & this->id;
	ar & this->ec;
	ar & this->keyNames;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onBeforeDeleteMap::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onBeforeDeleteMap(ec, domainName, id, keyNames, unlockZ, [__byps__asyncResult](PArrayString __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1888107655(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_393231686(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onBeforeDeleteMap>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onBeforeDeleteSord
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onBeforeDeleteSord::BRequest_IXServerEvents_onBeforeDeleteSord() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onBeforeDeleteSord::BRequest_IXServerEvents_onBeforeDeleteSord(const PIXServerEventsContext& ec, const PSord& parentSord, const PSord& sord, const PLockZ& unlockZ, const PDeleteOptions& delOpts)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, parentSord(parentSord)
	, sord(sord)
	, unlockZ(unlockZ)
	, delOpts(delOpts)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onBeforeDeleteSord::BSerializable_getTypeId() {
	return 694911984; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onBeforeDeleteSord::serialize(BIO& ar, const BVERSION version) {
	ar & this->delOpts;
	ar & this->ec;
	ar & this->parentSord;
	ar & this->sord;
	ar & this->unlockZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onBeforeDeleteSord::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onBeforeDeleteSord(ec, parentSord, sord, unlockZ, delOpts, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void BSerializer_694911984(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onBeforeDeleteSord>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onBeforeFindSords
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onBeforeFindSords::BRequest_IXServerEvents_onBeforeFindSords() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onBeforeFindSords::BRequest_IXServerEvents_onBeforeFindSords(const PIXServerEventsContext& ec, const PFindInfo& findInfo, const PSordZ& sordZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, findInfo(findInfo)
	, sordZ(sordZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onBeforeFindSords::BSerializable_getTypeId() {
	return 384369013; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onBeforeFindSords::serialize(BIO& ar, const BVERSION version) {
	ar & this->ec;
	ar & this->findInfo;
	ar & this->sordZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onBeforeFindSords::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onBeforeFindSords(ec, findInfo, sordZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void BSerializer_384369013(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onBeforeFindSords>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onBeforeFindSordsInternalSQL
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onBeforeFindSordsInternalSQL::BRequest_IXServerEvents_onBeforeFindSordsInternalSQL() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onBeforeFindSordsInternalSQL::BRequest_IXServerEvents_onBeforeFindSordsInternalSQL(const PIXServerEventsContext& ec, const PFindInfo& findInfo, const PSordZ& sordZ, const PFindInfoAsInternalSQL& findSql)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, findInfo(findInfo)
	, sordZ(sordZ)
	, findSql(findSql)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onBeforeFindSordsInternalSQL::BSerializable_getTypeId() {
	return 894418660; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onBeforeFindSordsInternalSQL::serialize(BIO& ar, const BVERSION version) {
	ar & this->ec;
	ar & this->findInfo;
	ar & this->findSql;
	ar & this->sordZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onBeforeFindSordsInternalSQL::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onBeforeFindSordsInternalSQL(ec, findInfo, sordZ, findSql, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void BSerializer_894418660(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onBeforeFindSordsInternalSQL>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onBeforeLogin
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onBeforeLogin::BRequest_IXServerEvents_onBeforeLogin() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onBeforeLogin::BRequest_IXServerEvents_onBeforeLogin(const PIXServerEventsContext& ec, const ::std::wstring& userName, const PLoginScriptOptions& opts)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, userName(userName)
	, opts(opts)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onBeforeLogin::BSerializable_getTypeId() {
	return 2101716238; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onBeforeLogin::serialize(BIO& ar, const BVERSION version) {
	ar & this->userName;
	ar & this->ec;
	ar & this->opts;
}
void de::elo::ix::client::BRequest_IXServerEvents_onBeforeLogin::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onBeforeLogin(ec, userName, opts, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void BSerializer_2101716238(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onBeforeLogin>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onBeforeRefSord
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onBeforeRefSord::BRequest_IXServerEvents_onBeforeRefSord() : BMethodRequest(1938363825) {
	manSortIndex = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onBeforeRefSord::BRequest_IXServerEvents_onBeforeRefSord(const PIXServerEventsContext& ec, const PSord& parentSordOld, const PSord& parentSordNew, const PSord& sord, int32_t manSortIndex)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, parentSordOld(parentSordOld)
	, parentSordNew(parentSordNew)
	, sord(sord)
	, manSortIndex(manSortIndex)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onBeforeRefSord::BSerializable_getTypeId() {
	return 372486646; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onBeforeRefSord::serialize(BIO& ar, const BVERSION version) {
	ar & this->manSortIndex;
	ar & this->ec;
	ar & this->parentSordNew;
	ar & this->parentSordOld;
	ar & this->sord;
}
void de::elo::ix::client::BRequest_IXServerEvents_onBeforeRefSord::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onBeforeRefSord(ec, parentSordOld, parentSordNew, sord, manSortIndex, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void BSerializer_372486646(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onBeforeRefSord>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onBeforeStartWorkFlow
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onBeforeStartWorkFlow::BRequest_IXServerEvents_onBeforeStartWorkFlow() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onBeforeStartWorkFlow::BRequest_IXServerEvents_onBeforeStartWorkFlow(const PIXServerEventsContext& ec, const PWFDiagram& workflow, const PSord& sord, const PSordZ& sordZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, workflow(workflow)
	, sord(sord)
	, sordZ(sordZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onBeforeStartWorkFlow::BSerializable_getTypeId() {
	return 1522940694; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onBeforeStartWorkFlow::serialize(BIO& ar, const BVERSION version) {
	ar & this->ec;
	ar & this->sord;
	ar & this->sordZ;
	ar & this->workflow;
}
void de::elo::ix::client::BRequest_IXServerEvents_onBeforeStartWorkFlow::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onBeforeStartWorkFlow(ec, workflow, sord, sordZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void BSerializer_1522940694(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onBeforeStartWorkFlow>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onBeforeTakeWorkFlowNode
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onBeforeTakeWorkFlowNode::BRequest_IXServerEvents_onBeforeTakeWorkFlowNode() : BMethodRequest(1938363825) {
	flags = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onBeforeTakeWorkFlowNode::BRequest_IXServerEvents_onBeforeTakeWorkFlowNode(const PIXServerEventsContext& ec, const PWFDiagram& workflow, const PWFNode& node, const PUserInfo& user, int32_t flags, const PLockZ& lockZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, workflow(workflow)
	, node(node)
	, user(user)
	, flags(flags)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onBeforeTakeWorkFlowNode::BSerializable_getTypeId() {
	return 727945599; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onBeforeTakeWorkFlowNode::serialize(BIO& ar, const BVERSION version) {
	ar & this->flags;
	ar & this->ec;
	ar & this->lockZ;
	ar & this->node;
	ar & this->user;
	ar & this->workflow;
}
void de::elo::ix::client::BRequest_IXServerEvents_onBeforeTakeWorkFlowNode::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onBeforeTakeWorkFlowNode(ec, workflow, node, user, flags, lockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void BSerializer_727945599(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onBeforeTakeWorkFlowNode>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onCheckSordAccess
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onCheckSordAccess::BRequest_IXServerEvents_onCheckSordAccess() : BMethodRequest(1938363825) {
	lur = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onCheckSordAccess::BRequest_IXServerEvents_onCheckSordAccess(const PIXServerEventsContext& ec, const PSord& sord, const PSordZ& sordZ, int32_t lur, const PCheckAccessOptions& opts)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, sord(sord)
	, sordZ(sordZ)
	, lur(lur)
	, opts(opts)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onCheckSordAccess::BSerializable_getTypeId() {
	return 1507824766; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onCheckSordAccess::serialize(BIO& ar, const BVERSION version) {
	ar & this->lur;
	ar & this->ec;
	ar & this->opts;
	ar & this->sord;
	ar & this->sordZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onCheckSordAccess::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onCheckSordAccess(ec, sord, sordZ, lur, opts, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void BSerializer_1507824766(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onCheckSordAccess>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onCreateDoc
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onCreateDoc::BRequest_IXServerEvents_onCreateDoc() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onCreateDoc::BRequest_IXServerEvents_onCreateDoc(const PIXServerEventsContext& ec, const ::std::wstring& parentId, const ::std::wstring& maskId, const ::std::wstring& docTemplate, const PEditInfoZ& editInfoZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, parentId(parentId)
	, maskId(maskId)
	, docTemplate(docTemplate)
	, editInfoZ(editInfoZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onCreateDoc::BSerializable_getTypeId() {
	return 1029500828; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onCreateDoc::serialize(BIO& ar, const BVERSION version) {
	ar & this->docTemplate;
	ar & this->maskId;
	ar & this->parentId;
	ar & this->ec;
	ar & this->editInfoZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onCreateDoc::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onCreateDoc(ec, parentId, maskId, docTemplate, editInfoZ, [__byps__asyncResult](PEditInfo __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_820228328(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1029500828(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onCreateDoc>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onCreateSord
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onCreateSord::BRequest_IXServerEvents_onCreateSord() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onCreateSord::BRequest_IXServerEvents_onCreateSord(const PIXServerEventsContext& ec, const ::std::wstring& parentId, const ::std::wstring& maskId, const PEditInfoZ& editZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, parentId(parentId)
	, maskId(maskId)
	, editZ(editZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onCreateSord::BSerializable_getTypeId() {
	return 1849307166; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onCreateSord::serialize(BIO& ar, const BVERSION version) {
	ar & this->maskId;
	ar & this->parentId;
	ar & this->ec;
	ar & this->editZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onCreateSord::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onCreateSord(ec, parentId, maskId, editZ, [__byps__asyncResult](PEditInfo __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_820228328(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1849307166(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onCreateSord>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onFileUploadBuildResponse
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onFileUploadBuildResponse::BRequest_IXServerEvents_onFileUploadBuildResponse() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onFileUploadBuildResponse::BRequest_IXServerEvents_onFileUploadBuildResponse(const PIXServerEventsContext& ec, const PDocVersion& dv, const ::std::wstring& fileName, const PHttpRequestInfo& requestInfo, const PHttpResponseInfo& responseInfo)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, dv(dv)
	, fileName(fileName)
	, requestInfo(requestInfo)
	, responseInfo(responseInfo)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onFileUploadBuildResponse::BSerializable_getTypeId() {
	return 2105244922; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onFileUploadBuildResponse::serialize(BIO& ar, const BVERSION version) {
	ar & this->fileName;
	ar & this->dv;
	ar & this->ec;
	ar & this->requestInfo;
	ar & this->responseInfo;
}
void de::elo::ix::client::BRequest_IXServerEvents_onFileUploadBuildResponse::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onFileUploadBuildResponse(ec, dv, fileName, requestInfo, responseInfo, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void BSerializer_2105244922(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onFileUploadBuildResponse>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onFindClose
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onFindClose::BRequest_IXServerEvents_onFindClose() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onFindClose::BRequest_IXServerEvents_onFindClose(const PIXServerEventsContext& ec, const PSerializable& findInfo)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, findInfo(findInfo)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onFindClose::BSerializable_getTypeId() {
	return 1223837305; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onFindClose::serialize(BIO& ar, const BVERSION version) {
	ar & this->ec;
	ar & this->findInfo;
}
void de::elo::ix::client::BRequest_IXServerEvents_onFindClose::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onFindClose(ec, findInfo, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void BSerializer_1223837305(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onFindClose>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onFindSordsResult
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onFindSordsResult::BRequest_IXServerEvents_onFindSordsResult() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onFindSordsResult::BRequest_IXServerEvents_onFindSordsResult(const PIXServerEventsContext& ec, const PFindInfo& findInfo, const PSordZ& sordZ, const PFindResult& findResult)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, findInfo(findInfo)
	, sordZ(sordZ)
	, findResult(findResult)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onFindSordsResult::BSerializable_getTypeId() {
	return 127227249; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onFindSordsResult::serialize(BIO& ar, const BVERSION version) {
	ar & this->ec;
	ar & this->findInfo;
	ar & this->findResult;
	ar & this->sordZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onFindSordsResult::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onFindSordsResult(ec, findInfo, sordZ, findResult, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void BSerializer_127227249(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onFindSordsResult>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onInheritKeywording
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onInheritKeywording::BRequest_IXServerEvents_onInheritKeywording() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onInheritKeywording::BRequest_IXServerEvents_onInheritKeywording(const PIXServerEventsContext& ec, const PSord& sord, const PSord& parentSord, const PArrayString& okeyNames, const PSerializable& reserved)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, sord(sord)
	, parentSord(parentSord)
	, okeyNames(okeyNames)
	, reserved(reserved)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onInheritKeywording::BSerializable_getTypeId() {
	return 53854844; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onInheritKeywording::serialize(BIO& ar, const BVERSION version) {
	ar & this->ec;
	ar & this->okeyNames;
	ar & this->parentSord;
	ar & this->reserved;
	ar & this->sord;
}
void de::elo::ix::client::BRequest_IXServerEvents_onInheritKeywording::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onInheritKeywording(ec, sord, parentSord, okeyNames, reserved, [__byps__asyncResult](InheritKeywordingResult __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_892356058(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_53854844(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onInheritKeywording>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServerEvents_onReadSord
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServerEvents_onReadSord::BRequest_IXServerEvents_onReadSord() : BMethodRequest(1938363825) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServerEvents_onReadSord::BRequest_IXServerEvents_onReadSord(const PIXServerEventsContext& ec, const PSord& sord, const PSordZ& sordZ, const PDocument& doc, const PLockZ& lockZ)
	: BMethodRequest(1938363825) 
	, ec(ec)
	, sord(sord)
	, sordZ(sordZ)
	, doc(doc)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServerEvents_onReadSord::BSerializable_getTypeId() {
	return 227337860; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServerEvents_onReadSord::serialize(BIO& ar, const BVERSION version) {
	ar & this->doc;
	ar & this->ec;
	ar & this->lockZ;
	ar & this->sord;
	ar & this->sordZ;
}
void de::elo::ix::client::BRequest_IXServerEvents_onReadSord::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServerEvents __byps__remoteT = byps_ptr_cast<IXServerEvents>(__byps__remote);
	__byps__remoteT->onReadSord(ec, sord, sordZ, doc, lockZ, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void BSerializer_227337860(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServerEvents_onReadSord>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_addUrlParams
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_addUrlParams::BRequest_IXServicePortIF_addUrlParams() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_addUrlParams::BRequest_IXServicePortIF_addUrlParams(const ::std::wstring& url, const PUrlParams& params)
	: BMethodRequest(1795705954) 
	, url(url)
	, params(params)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_addUrlParams::BSerializable_getTypeId() {
	return 177992598; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_addUrlParams::serialize(BIO& ar, const BVERSION version) {
	ar & this->url;
	ar & this->ci;
	ar & this->params;
}
void de::elo::ix::client::BRequest_IXServicePortIF_addUrlParams::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->addUrlParams(ci, url, params, [__byps__asyncResult](::std::wstring __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_10(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_addUrlParams::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_177992598(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_addUrlParams>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_adminMode
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_adminMode::BRequest_IXServicePortIF_adminMode() : BMethodRequest(1795705954) {
	mode = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_adminMode::BRequest_IXServicePortIF_adminMode(int32_t mode)
	: BMethodRequest(1795705954) 
	, mode(mode)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_adminMode::BSerializable_getTypeId() {
	return 1311037156; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_adminMode::serialize(BIO& ar, const BVERSION version) {
	ar & this->mode;
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_adminMode::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->adminMode(ci, mode, [__byps__asyncResult](int32_t __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_5(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_adminMode::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1311037156(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_adminMode>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_alive
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_alive::BRequest_IXServicePortIF_alive() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_alive::BSerializable_getTypeId() {
	return 1536711337; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_alive::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
}
void de::elo::ix::client::BRequest_IXServicePortIF_alive::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->alive(ci, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::BRequest_IXServicePortIF_alive::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1536711337(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_alive>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_applyForNotifications
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_applyForNotifications::BRequest_IXServicePortIF_applyForNotifications() : BMethodRequest(1795705954) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_applyForNotifications::BRequest_IXServicePortIF_applyForNotifications(const PApplyForNotificationsInfo& info)
	: BMethodRequest(1795705954) 
	, info(info)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_applyForNotifications::BSerializable_getTypeId() {
	return 1849289399; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_applyForNotifications::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->info;
}
void de::elo::ix::client::BRequest_IXServicePortIF_applyForNotifications::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->applyForNotifications(ci, info, [__byps__asyncResult](PApplyForNotificationsInfo __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_77743605(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_applyForNotifications::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1849289399(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_applyForNotifications>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class BRequest_IXServicePortIF_beginEditWorkFlowNode
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_IXServicePortIF_beginEditWorkFlowNode::BRequest_IXServicePortIF_beginEditWorkFlowNode() : BMethodRequest(1795705954) {
	nFlowId = 0;
	nNodeId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::BRequest_IXServicePortIF_beginEditWorkFlowNode::BRequest_IXServicePortIF_beginEditWorkFlowNode(int32_t nFlowId, int32_t nNodeId, const PLockZ& lockZ)
	: BMethodRequest(1795705954) 
	, nFlowId(nFlowId)
	, nNodeId(nNodeId)
	, lockZ(lockZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BRequest_IXServicePortIF_beginEditWorkFlowNode::BSerializable_getTypeId() {
	return 626823938; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_IXServicePortIF_beginEditWorkFlowNode::serialize(BIO& ar, const BVERSION version) {
	ar & this->nFlowId;
	ar & this->nNodeId;
	ar & this->ci;
	ar & this->lockZ;
}
void de::elo::ix::client::BRequest_IXServicePortIF_beginEditWorkFlowNode::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PIXServicePortIF __byps__remoteT = byps_ptr_cast<IXServicePortIF>(__byps__remote);
	__byps__remoteT->beginEditWorkFlowNode(ci, nFlowId, nNodeId, lockZ, [__byps__asyncResult](PWFEditNode __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1822579866(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::BRequest_IXServicePortIF_beginEditWorkFlowNode::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_626823938(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::BRequest_IXServicePortIF_beginEditWorkFlowNode>(bio, pObj, pObjS, pBase);	
}
}}}}
