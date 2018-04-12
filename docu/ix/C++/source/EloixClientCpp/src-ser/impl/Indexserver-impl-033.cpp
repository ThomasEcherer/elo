#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class BRequest_FeedService_createAction
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_FeedService_createAction::BRequest_FeedService_createAction() : BMethodRequest(1670701039) {
	type = de::elo::ix::client::feed::EActionType::Undefined;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::BRequest_FeedService_createAction::BRequest_FeedService_createAction(EActionType type, const ::std::wstring& parentGuid)
	: BMethodRequest(1670701039) 
	, type(type)
	, parentGuid(parentGuid)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::BRequest_FeedService_createAction::BSerializable_getTypeId() {
	return 643943187; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_FeedService_createAction::serialize(BIO& ar, const BVERSION version) {
	ar & this->parentGuid;
	ar & this->type;
	ar & this->ci;
}
void de::elo::ix::client::feed::BRequest_FeedService_createAction::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PFeedService __byps__remoteT = byps_ptr_cast<FeedService>(__byps__remote);
	__byps__remoteT->createAction(ci, type, parentGuid, [__byps__asyncResult](PAction __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_736351635(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::feed::BRequest_FeedService_createAction::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_643943187(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::BRequest_FeedService_createAction>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class BRequest_FeedService_createHashTagSubscription
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_FeedService_createHashTagSubscription::BRequest_FeedService_createHashTagSubscription() : BMethodRequest(1670701039) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::BRequest_FeedService_createHashTagSubscription::BRequest_FeedService_createHashTagSubscription(const ::std::wstring& hashtagGuidOrName, const ::std::wstring& userGuidOrId)
	: BMethodRequest(1670701039) 
	, hashtagGuidOrName(hashtagGuidOrName)
	, userGuidOrId(userGuidOrId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::BRequest_FeedService_createHashTagSubscription::BSerializable_getTypeId() {
	return 1471082196; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_FeedService_createHashTagSubscription::serialize(BIO& ar, const BVERSION version) {
	ar & this->hashtagGuidOrName;
	ar & this->userGuidOrId;
	ar & this->ci;
}
void de::elo::ix::client::feed::BRequest_FeedService_createHashTagSubscription::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PFeedService __byps__remoteT = byps_ptr_cast<FeedService>(__byps__remote);
	__byps__remoteT->createHashTagSubscription(ci, hashtagGuidOrName, userGuidOrId, [__byps__asyncResult](de::elo::ix::client::PSubscription __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_323351719(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::feed::BRequest_FeedService_createHashTagSubscription::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1471082196(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::BRequest_FeedService_createHashTagSubscription>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class BRequest_FeedService_findFirstActions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_FeedService_findFirstActions::BRequest_FeedService_findFirstActions() : BMethodRequest(1670701039) {
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::BRequest_FeedService_findFirstActions::BRequest_FeedService_findFirstActions(const PFindActionsInfo& findInfo, int32_t max, const PActionZ& actionZ)
	: BMethodRequest(1670701039) 
	, findInfo(findInfo)
	, max(max)
	, actionZ(actionZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::BRequest_FeedService_findFirstActions::BSerializable_getTypeId() {
	return 334710983; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_FeedService_findFirstActions::serialize(BIO& ar, const BVERSION version) {
	ar & this->max;
	ar & this->actionZ;
	ar & this->ci;
	ar & this->findInfo;
}
void de::elo::ix::client::feed::BRequest_FeedService_findFirstActions::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PFeedService __byps__remoteT = byps_ptr_cast<FeedService>(__byps__remote);
	__byps__remoteT->findFirstActions(ci, findInfo, max, actionZ, [__byps__asyncResult](de::elo::ix::client::PFindResult __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::feed::BRequest_FeedService_findFirstActions::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_334710983(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::BRequest_FeedService_findFirstActions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class BRequest_FeedService_findFirstHashTagRelation
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_FeedService_findFirstHashTagRelation::BRequest_FeedService_findFirstHashTagRelation() : BMethodRequest(1670701039) {
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::BRequest_FeedService_findFirstHashTagRelation::BRequest_FeedService_findFirstHashTagRelation(const PFindHashTagInfo& findInfo, int32_t max, const PHashTagZ& hashTagZ)
	: BMethodRequest(1670701039) 
	, findInfo(findInfo)
	, max(max)
	, hashTagZ(hashTagZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::BRequest_FeedService_findFirstHashTagRelation::BSerializable_getTypeId() {
	return 2144547950; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_FeedService_findFirstHashTagRelation::serialize(BIO& ar, const BVERSION version) {
	ar & this->max;
	ar & this->ci;
	ar & this->findInfo;
	ar & this->hashTagZ;
}
void de::elo::ix::client::feed::BRequest_FeedService_findFirstHashTagRelation::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PFeedService __byps__remoteT = byps_ptr_cast<FeedService>(__byps__remote);
	__byps__remoteT->findFirstHashTagRelation(ci, findInfo, max, hashTagZ, [__byps__asyncResult](de::elo::ix::client::PFindResult __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::feed::BRequest_FeedService_findFirstHashTagRelation::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2144547950(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::BRequest_FeedService_findFirstHashTagRelation>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class BRequest_FeedService_findFirstNotification
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_FeedService_findFirstNotification::BRequest_FeedService_findFirstNotification() : BMethodRequest(1670701039) {
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::BRequest_FeedService_findFirstNotification::BRequest_FeedService_findFirstNotification(const PFindNotificationInfo& findInfo, int32_t max)
	: BMethodRequest(1670701039) 
	, findInfo(findInfo)
	, max(max)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::BRequest_FeedService_findFirstNotification::BSerializable_getTypeId() {
	return 906090337; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_FeedService_findFirstNotification::serialize(BIO& ar, const BVERSION version) {
	ar & this->max;
	ar & this->ci;
	ar & this->findInfo;
}
void de::elo::ix::client::feed::BRequest_FeedService_findFirstNotification::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PFeedService __byps__remoteT = byps_ptr_cast<FeedService>(__byps__remote);
	__byps__remoteT->findFirstNotification(ci, findInfo, max, [__byps__asyncResult](de::elo::ix::client::PFindResult __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::feed::BRequest_FeedService_findFirstNotification::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_906090337(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::BRequest_FeedService_findFirstNotification>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class BRequest_FeedService_findHashTagByActions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_FeedService_findHashTagByActions::BRequest_FeedService_findHashTagByActions() : BMethodRequest(1670701039) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::BRequest_FeedService_findHashTagByActions::BRequest_FeedService_findHashTagByActions(const PArrayString& actionGuids, const PHashTagZ& hashTagZ)
	: BMethodRequest(1670701039) 
	, actionGuids(actionGuids)
	, hashTagZ(hashTagZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::BRequest_FeedService_findHashTagByActions::BSerializable_getTypeId() {
	return 421489164; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_FeedService_findHashTagByActions::serialize(BIO& ar, const BVERSION version) {
	ar & this->actionGuids;
	ar & this->ci;
	ar & this->hashTagZ;
}
void de::elo::ix::client::feed::BRequest_FeedService_findHashTagByActions::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PFeedService __byps__remoteT = byps_ptr_cast<FeedService>(__byps__remote);
	__byps__remoteT->findHashTagByActions(ci, actionGuids, hashTagZ, [__byps__asyncResult](byps_ptr< ::std::set< PHashTag > > __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1535847981(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::feed::BRequest_FeedService_findHashTagByActions::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_421489164(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::BRequest_FeedService_findHashTagByActions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class BRequest_FeedService_findHashTags
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_FeedService_findHashTags::BRequest_FeedService_findHashTags() : BMethodRequest(1670701039) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::BRequest_FeedService_findHashTags::BRequest_FeedService_findHashTags(const PFindHashTagInfo& findInfo)
	: BMethodRequest(1670701039) 
	, findInfo(findInfo)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::BRequest_FeedService_findHashTags::BSerializable_getTypeId() {
	return 66310175; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_FeedService_findHashTags::serialize(BIO& ar, const BVERSION version) {
	ar & this->ci;
	ar & this->findInfo;
}
void de::elo::ix::client::feed::BRequest_FeedService_findHashTags::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PFeedService __byps__remoteT = byps_ptr_cast<FeedService>(__byps__remote);
	__byps__remoteT->findHashTags(ci, findInfo, [__byps__asyncResult](PMapStringHashTag __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_1556767716(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::feed::BRequest_FeedService_findHashTags::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_66310175(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::BRequest_FeedService_findHashTags>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class BRequest_FeedService_findNextActions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_FeedService_findNextActions::BRequest_FeedService_findNextActions() : BMethodRequest(1670701039) {
	idx = 0;
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::BRequest_FeedService_findNextActions::BRequest_FeedService_findNextActions(const ::std::wstring& searchId, int32_t idx, int32_t max, const PActionZ& actionZ)
	: BMethodRequest(1670701039) 
	, searchId(searchId)
	, idx(idx)
	, max(max)
	, actionZ(actionZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::BRequest_FeedService_findNextActions::BSerializable_getTypeId() {
	return 933597872; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_FeedService_findNextActions::serialize(BIO& ar, const BVERSION version) {
	ar & this->idx;
	ar & this->max;
	ar & this->searchId;
	ar & this->actionZ;
	ar & this->ci;
}
void de::elo::ix::client::feed::BRequest_FeedService_findNextActions::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PFeedService __byps__remoteT = byps_ptr_cast<FeedService>(__byps__remote);
	__byps__remoteT->findNextActions(ci, searchId, idx, max, actionZ, [__byps__asyncResult](de::elo::ix::client::PFindResult __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::feed::BRequest_FeedService_findNextActions::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_933597872(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::BRequest_FeedService_findNextActions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class BRequest_FeedService_findNextHashTagRelation
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_FeedService_findNextHashTagRelation::BRequest_FeedService_findNextHashTagRelation() : BMethodRequest(1670701039) {
	idx = 0;
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::BRequest_FeedService_findNextHashTagRelation::BRequest_FeedService_findNextHashTagRelation(const ::std::wstring& searchId, int32_t idx, int32_t max, const PHashTagZ& hashTagZ)
	: BMethodRequest(1670701039) 
	, searchId(searchId)
	, idx(idx)
	, max(max)
	, hashTagZ(hashTagZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::BRequest_FeedService_findNextHashTagRelation::BSerializable_getTypeId() {
	return 1204755579; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_FeedService_findNextHashTagRelation::serialize(BIO& ar, const BVERSION version) {
	ar & this->idx;
	ar & this->max;
	ar & this->searchId;
	ar & this->ci;
	ar & this->hashTagZ;
}
void de::elo::ix::client::feed::BRequest_FeedService_findNextHashTagRelation::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PFeedService __byps__remoteT = byps_ptr_cast<FeedService>(__byps__remote);
	__byps__remoteT->findNextHashTagRelation(ci, searchId, idx, max, hashTagZ, [__byps__asyncResult](de::elo::ix::client::PFindResult __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::feed::BRequest_FeedService_findNextHashTagRelation::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1204755579(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::BRequest_FeedService_findNextHashTagRelation>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class BRequest_FeedService_findNextNotification
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_FeedService_findNextNotification::BRequest_FeedService_findNextNotification() : BMethodRequest(1670701039) {
	idx = 0;
	max = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::BRequest_FeedService_findNextNotification::BRequest_FeedService_findNextNotification(const ::std::wstring& searchId, int32_t idx, int32_t max)
	: BMethodRequest(1670701039) 
	, searchId(searchId)
	, idx(idx)
	, max(max)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::BRequest_FeedService_findNextNotification::BSerializable_getTypeId() {
	return 1326557416; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_FeedService_findNextNotification::serialize(BIO& ar, const BVERSION version) {
	ar & this->idx;
	ar & this->max;
	ar & this->searchId;
	ar & this->ci;
}
void de::elo::ix::client::feed::BRequest_FeedService_findNextNotification::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PFeedService __byps__remoteT = byps_ptr_cast<FeedService>(__byps__remote);
	__byps__remoteT->findNextNotification(ci, searchId, idx, max, [__byps__asyncResult](de::elo::ix::client::PFindResult __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::feed::BRequest_FeedService_findNextNotification::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1326557416(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::BRequest_FeedService_findNextNotification>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class BRequest_FeedService_internalInsertSystemAction
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_FeedService_internalInsertSystemAction::BRequest_FeedService_internalInsertSystemAction() : BMethodRequest(1670701039) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::BRequest_FeedService_internalInsertSystemAction::BRequest_FeedService_internalInsertSystemAction(const PAction& action)
	: BMethodRequest(1670701039) 
	, action(action)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::BRequest_FeedService_internalInsertSystemAction::BSerializable_getTypeId() {
	return 1637137212; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_FeedService_internalInsertSystemAction::serialize(BIO& ar, const BVERSION version) {
	ar & this->action;
	ar & this->ci;
}
void de::elo::ix::client::feed::BRequest_FeedService_internalInsertSystemAction::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PFeedService __byps__remoteT = byps_ptr_cast<FeedService>(__byps__remote);
	__byps__remoteT->internalInsertSystemAction(ci, action, [__byps__asyncResult](PAction __byps__result, const BException& __byps__ex) {
		if (__byps__ex) {
			__byps__asyncResult->setAsyncResult(BVariant(__byps__ex));
		}
		else {
			PSerializable __byps__methodResult(new BResult_736351635(__byps__result));
			__byps__asyncResult->setAsyncResult(BVariant(__byps__methodResult));
		}
	});
}
// checkpoint byps.gen.cpp.GenApiClass:844
void de::elo::ix::client::feed::BRequest_FeedService_internalInsertSystemAction::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1637137212(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::BRequest_FeedService_internalInsertSystemAction>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class BRequest_FeedService_registerNotify
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_FeedService_registerNotify::BRequest_FeedService_registerNotify() : BMethodRequest(1670701039) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::BRequest_FeedService_registerNotify::BRequest_FeedService_registerNotify(const ::std::wstring& feedGuid, const PFeedNotification& notify)
	: BMethodRequest(1670701039) 
	, feedGuid(feedGuid)
	, notify(notify)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::BRequest_FeedService_registerNotify::BSerializable_getTypeId() {
	return 458959949; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_FeedService_registerNotify::serialize(BIO& ar, const BVERSION version) {
	ar & this->feedGuid;
	ar & this->ci;
	ar & this->notify;
}
void de::elo::ix::client::feed::BRequest_FeedService_registerNotify::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PFeedService __byps__remoteT = byps_ptr_cast<FeedService>(__byps__remote);
	__byps__remoteT->registerNotify(ci, feedGuid, notify, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::feed::BRequest_FeedService_registerNotify::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_458959949(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::BRequest_FeedService_registerNotify>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class BRequest_FeedService_unregisterNotify
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
BRequest_FeedService_unregisterNotify::BRequest_FeedService_unregisterNotify() : BMethodRequest(1670701039) {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::BRequest_FeedService_unregisterNotify::BRequest_FeedService_unregisterNotify(const ::std::wstring& feedGuid)
	: BMethodRequest(1670701039) 
	, feedGuid(feedGuid)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::BRequest_FeedService_unregisterNotify::BSerializable_getTypeId() {
	return 285270298; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void BRequest_FeedService_unregisterNotify::serialize(BIO& ar, const BVERSION version) {
	ar & this->feedGuid;
	ar & this->ci;
}
void de::elo::ix::client::feed::BRequest_FeedService_unregisterNotify::execute(const PRemote& __byps__remote, PAsyncResult __byps__asyncResult) {
	PFeedService __byps__remoteT = byps_ptr_cast<FeedService>(__byps__remote);
	__byps__remoteT->unregisterNotify(ci, feedGuid, [__byps__asyncResult](bool __byps__result, const BException& __byps__ex) {
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
void de::elo::ix::client::feed::BRequest_FeedService_unregisterNotify::setSession(const PSerializable& __byps__sess) {
	ci = byps_ptr_cast<de::elo::ix::client::ClientInfo>(__byps__sess);
}

}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_285270298(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::BRequest_FeedService_unregisterNotify>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class Feed
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
Feed::Feed() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::Feed::Feed(const ::std::wstring& guid, const ::std::wstring& createDateIso, const ::std::wstring& tStamp, const ::std::wstring& objGuid, const ::std::wstring& TStampSync)
	: guid(guid)
	, createDateIso(createDateIso)
	, tStamp(tStamp)
	, objGuid(objGuid)
	, TStampSync(TStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::Feed::BSerializable_getTypeId() {
	return 556531185; 
}
void Feed::setGuid(::std::wstring v) {
	guid = v;
	setChangedMember(FeedC::mbGuid);
}
void Feed::setCreateDateIso(::std::wstring v) {
	createDateIso = v;
	setChangedMember(FeedC::mbCreateDateIso);
}
void Feed::setTStamp(::std::wstring v) {
	tStamp = v;
	setChangedMember(FeedC::mbTStamp);
}
void Feed::setObjGuid(::std::wstring v) {
	objGuid = v;
	setChangedMember(FeedC::mbObjGuid);
}
void Feed::setTStampSync(::std::wstring v) {
	TStampSync = v;
	setChangedMember(FeedC::mbTStampSync);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void Feed::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->createDateIso;
	ar & this->guid;
	ar & this->objGuid;
	ar & this->tStamp;
	if (version >= 900990009000001) {
		ar & this->TStampSync;
	}
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_556531185(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::Feed>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class FeedDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FeedDataC::FeedDataC() {
	lnGuid = 0;
	lnCreateDateIso = 0;
	lnTStamp = 0;
	lnObjGuid = 0;
	lnTStampSync = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::FeedDataC::FeedDataC(int64_t mbGuid, int32_t lnGuid, int64_t mbCreateDateIso, int32_t lnCreateDateIso, int64_t mbTStamp, int32_t lnTStamp, int64_t mbObjGuid, int32_t lnObjGuid, int64_t mbTStampSync, int32_t lnTStampSync, int64_t mbAllMembers)
	: lnGuid(lnGuid)
	, lnCreateDateIso(lnCreateDateIso)
	, lnTStamp(lnTStamp)
	, lnObjGuid(lnObjGuid)
	, lnTStampSync(lnTStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::FeedDataC::BSerializable_getTypeId() {
	return 1837685365; 
}
void FeedDataC::setLnGuid(int32_t v) {
	lnGuid = v;
}
void FeedDataC::setLnCreateDateIso(int32_t v) {
	lnCreateDateIso = v;
}
void FeedDataC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
void FeedDataC::setLnObjGuid(int32_t v) {
	lnObjGuid = v;
}
void FeedDataC::setLnTStampSync(int32_t v) {
	lnTStampSync = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FeedDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnCreateDateIso;
	ar & this->lnGuid;
	ar & this->lnObjGuid;
	ar & this->lnTStamp;
	if (version >= 900990009000001) {
		ar & this->lnTStampSync;
	}
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1837685365(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::FeedDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class FeedC
// Generated from class byps.gen.cpp.GenApiClass

const PFeedZ FeedC::mbAll = PFeedZ(new FeedZ(
	31LL));

// checkpoint byps.gen.cpp.GenApiClass:489
FeedC::FeedC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::FeedC::BSerializable_getTypeId() {
	return 1754071588; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FeedC::serialize(BIO& ar, const BVERSION version) {
	FeedDataC::serialize(ar, version);
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1754071588(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::FeedC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class FeedZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FeedZ::FeedZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::FeedZ::FeedZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::FeedZ::BSerializable_getTypeId() {
	return 126672288; 
}
void FeedZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FeedZ::serialize(BIO& ar, const BVERSION version) {
	ar & this->bset;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_126672288(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::FeedZ>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class FindActionsInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindActionsInfo::FindActionsInfo() {
	findNotifications = false;
	findHashTags = false;
	findSubscriptions = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::FindActionsInfo::FindActionsInfo(const ::std::wstring& objId, const ::std::wstring& userId, const ::std::wstring& createDateIso, const PVectorEActionType& actionTypes, bool findNotifications, bool findHashTags, bool findSubscriptions, const de::elo::ix::client::PSordZ& sordZ)
	: objId(objId)
	, userId(userId)
	, createDateIso(createDateIso)
	, actionTypes(actionTypes)
	, findNotifications(findNotifications)
	, findHashTags(findHashTags)
	, findSubscriptions(findSubscriptions)
	, sordZ(sordZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::FindActionsInfo::BSerializable_getTypeId() {
	return 1747180074; 
}
void FindActionsInfo::setObjId(::std::wstring v) {
	objId = v;
}
void FindActionsInfo::setUserId(::std::wstring v) {
	userId = v;
}
void FindActionsInfo::setCreateDateIso(::std::wstring v) {
	createDateIso = v;
}
void FindActionsInfo::setActionTypes(PVectorEActionType v) {
	actionTypes = v;
}
void FindActionsInfo::setFindNotifications(bool v) {
	findNotifications = v;
}
void FindActionsInfo::setFindHashTags(bool v) {
	findHashTags = v;
}
void FindActionsInfo::setFindSubscriptions(bool v) {
	findSubscriptions = v;
}
void FindActionsInfo::setSordZ(de::elo::ix::client::PSordZ v) {
	sordZ = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindActionsInfo::serialize(BIO& ar, const BVERSION version) {
	ar & this->createDateIso;
	ar & this->objId;
	ar & this->userId;
	if (version >= 900000014000003) {
		ar & this->findNotifications;
		if (version >= 900000022000016) {
			ar & this->findHashTags;
			if (version >= 900000030000016) {
				ar & this->findSubscriptions;
			}
		}
	}
	if (version >= 900000012000001) {
		ar & this->actionTypes;
		if (version >= 900000014000003) {
			ar & this->sordZ;
		}
	}
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1747180074(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::FindActionsInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class FindActionsInfoC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindActionsInfoC::FindActionsInfoC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::FindActionsInfoC::BSerializable_getTypeId() {
	return 815857210; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindActionsInfoC::serialize(BIO& ar, const BVERSION version) {
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_815857210(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::FindActionsInfoC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class FindHashTagInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindHashTagInfo::FindHashTagInfo() {
	minCount = 0;
	findFeeds = false;
	findHashTags = false;
	findSubscriptions = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::FindHashTagInfo::FindHashTagInfo(const ::std::wstring& hashtagGuidOrName, const ::std::wstring& createDateIso, const ::std::wstring& lastUsedIso, int32_t minCount, const PActionZ& actionZ, const de::elo::ix::client::PSordZ& sordZ, bool findFeeds, bool findHashTags, bool findSubscriptions)
	: hashtagGuidOrName(hashtagGuidOrName)
	, createDateIso(createDateIso)
	, lastUsedIso(lastUsedIso)
	, minCount(minCount)
	, actionZ(actionZ)
	, sordZ(sordZ)
	, findFeeds(findFeeds)
	, findHashTags(findHashTags)
	, findSubscriptions(findSubscriptions)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::FindHashTagInfo::BSerializable_getTypeId() {
	return 256103952; 
}
void FindHashTagInfo::setHashtagGuidOrName(::std::wstring v) {
	hashtagGuidOrName = v;
}
void FindHashTagInfo::setCreateDateIso(::std::wstring v) {
	createDateIso = v;
}
void FindHashTagInfo::setLastUsedIso(::std::wstring v) {
	lastUsedIso = v;
}
void FindHashTagInfo::setMinCount(int32_t v) {
	minCount = v;
}
void FindHashTagInfo::setActionZ(PActionZ v) {
	actionZ = v;
}
void FindHashTagInfo::setSordZ(de::elo::ix::client::PSordZ v) {
	sordZ = v;
}
void FindHashTagInfo::setFindFeeds(bool v) {
	findFeeds = v;
}
void FindHashTagInfo::setFindHashTags(bool v) {
	findHashTags = v;
}
void FindHashTagInfo::setFindSubscriptions(bool v) {
	findSubscriptions = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindHashTagInfo::serialize(BIO& ar, const BVERSION version) {
	ar & this->createDateIso;
	ar & this->hashtagGuidOrName;
	ar & this->lastUsedIso;
	if (version >= 900000030000004) {
		ar & this->minCount;
		if (version >= 900000030000007) {
			ar & this->findFeeds;
			if (version >= 900000030000016) {
				ar & this->findSubscriptions;
				if (version >= 900000030000020) {
					ar & this->findHashTags;
				}
			}
		}
	}
	if (version >= 900000030000007) {
		ar & this->actionZ;
		ar & this->sordZ;
	}
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_256103952(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::FindHashTagInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class FindNotificationInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindNotificationInfo::FindNotificationInfo() {
	what = 0;
	inclImportant = false;
	findFeeds = false;
	findHashTags = false;
	findSubscriptions = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::FindNotificationInfo::FindNotificationInfo(const ::std::wstring& userGuidOrID, int32_t what, const ::std::wstring& createDateIso, bool inclImportant, const de::elo::ix::client::PSordZ& sordZ, const PActionZ& actionZ, bool findFeeds, bool findHashTags, bool findSubscriptions)
	: userGuidOrID(userGuidOrID)
	, what(what)
	, createDateIso(createDateIso)
	, inclImportant(inclImportant)
	, sordZ(sordZ)
	, actionZ(actionZ)
	, findFeeds(findFeeds)
	, findHashTags(findHashTags)
	, findSubscriptions(findSubscriptions)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::FindNotificationInfo::BSerializable_getTypeId() {
	return 432579435; 
}
void FindNotificationInfo::setUserGuidOrID(::std::wstring v) {
	userGuidOrID = v;
}
void FindNotificationInfo::setWhat(int32_t v) {
	what = v;
}
void FindNotificationInfo::setCreateDateIso(::std::wstring v) {
	createDateIso = v;
}
void FindNotificationInfo::setInclImportant(bool v) {
	inclImportant = v;
}
void FindNotificationInfo::setSordZ(de::elo::ix::client::PSordZ v) {
	sordZ = v;
}
void FindNotificationInfo::setActionZ(PActionZ v) {
	actionZ = v;
}
void FindNotificationInfo::setFindFeeds(bool v) {
	findFeeds = v;
}
void FindNotificationInfo::setFindHashTags(bool v) {
	findHashTags = v;
}
void FindNotificationInfo::setFindSubscriptions(bool v) {
	findSubscriptions = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindNotificationInfo::serialize(BIO& ar, const BVERSION version) {
	ar & this->createDateIso;
	ar & this->inclImportant;
	ar & this->userGuidOrID;
	ar & this->what;
	if (version >= 900000030000007) {
		ar & this->findFeeds;
		ar & this->findHashTags;
		if (version >= 900000030000016) {
			ar & this->findSubscriptions;
		}
	}
	ar & this->sordZ;
	if (version >= 900000030000007) {
		ar & this->actionZ;
	}
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_432579435(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::FindNotificationInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class HashTag
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
HashTag::HashTag() {
	counter = 0;
	status = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::HashTag::HashTag(const ::std::wstring& hstgGuid, const ::std::wstring& hstgName, const ::std::wstring& createDateIso, const ::std::wstring& lastUsedIso, int32_t counter, const ::std::wstring& tStamp, int32_t status)
	: hstgGuid(hstgGuid)
	, hstgName(hstgName)
	, createDateIso(createDateIso)
	, lastUsedIso(lastUsedIso)
	, counter(counter)
	, tStamp(tStamp)
	, status(status)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::HashTag::BSerializable_getTypeId() {
	return 1143177929; 
}
void HashTag::setHstgGuid(::std::wstring v) {
	hstgGuid = v;
	setChangedMember(HashTagC::mbHstgGuid);
}
void HashTag::setHstgName(::std::wstring v) {
	hstgName = v;
	setChangedMember(HashTagC::mbHstgName);
}
void HashTag::setCreateDateIso(::std::wstring v) {
	createDateIso = v;
	setChangedMember(HashTagC::mbCreateDateIso);
}
void HashTag::setLastUsedIso(::std::wstring v) {
	lastUsedIso = v;
	setChangedMember(HashTagC::mbLastUsedIso);
}
void HashTag::setCounter(int32_t v) {
	counter = v;
}
void HashTag::setTStamp(::std::wstring v) {
	tStamp = v;
	setChangedMember(HashTagC::mbTStamp);
}
void HashTag::setStatus(int32_t v) {
	status = v;
	setChangedMember(HashTagC::mbStatus);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void HashTag::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->counter;
	ar & this->createDateIso;
	ar & this->hstgGuid;
	ar & this->hstgName;
	ar & this->lastUsedIso;
	ar & this->status;
	ar & this->tStamp;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1143177929(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::HashTag>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class HashTagDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
HashTagDataC::HashTagDataC() {
	lnHstgGuid = 0;
	lnHstgName = 0;
	lnCreateDateIso = 0;
	lnLastUsedIso = 0;
	lnTStamp = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::feed::HashTagDataC::HashTagDataC(int64_t mbHstgGuid, int32_t lnHstgGuid, int64_t mbHstgName, int32_t lnHstgName, int64_t mbCreateDateIso, int32_t lnCreateDateIso, int64_t mbLastUsedIso, int32_t lnLastUsedIso, int64_t mbTStamp, int32_t lnTStamp, int64_t mbStatus, int64_t mbAllMembers)
	: lnHstgGuid(lnHstgGuid)
	, lnHstgName(lnHstgName)
	, lnCreateDateIso(lnCreateDateIso)
	, lnLastUsedIso(lnLastUsedIso)
	, lnTStamp(lnTStamp)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::HashTagDataC::BSerializable_getTypeId() {
	return 513648569; 
}
void HashTagDataC::setLnHstgGuid(int32_t v) {
	lnHstgGuid = v;
}
void HashTagDataC::setLnHstgName(int32_t v) {
	lnHstgName = v;
}
void HashTagDataC::setLnCreateDateIso(int32_t v) {
	lnCreateDateIso = v;
}
void HashTagDataC::setLnLastUsedIso(int32_t v) {
	lnLastUsedIso = v;
}
void HashTagDataC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void HashTagDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnCreateDateIso;
	ar & this->lnHstgGuid;
	ar & this->lnHstgName;
	ar & this->lnLastUsedIso;
	ar & this->lnTStamp;
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_513648569(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::HashTagDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

//-------------------------------------------------
// Implementation of class HashTagC
// Generated from class byps.gen.cpp.GenApiClass

const PHashTagZ HashTagC::mbAll = PHashTagZ(new HashTagZ(
	63LL));

const PHashTagZ HashTagC::mbGuid = PHashTagZ(new HashTagZ(
	1LL));

const PHashTagZ HashTagC::mbLastUsed = PHashTagZ(new HashTagZ(
	9LL));

// checkpoint byps.gen.cpp.GenApiClass:489
HashTagC::HashTagC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::HashTagC::BSerializable_getTypeId() {
	return 250741620; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void HashTagC::serialize(BIO& ar, const BVERSION version) {
	HashTagDataC::serialize(ar, version);
}
}}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_250741620(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::feed::HashTagC>(bio, pObj, pObjS, pBase);	
}
}}}}
