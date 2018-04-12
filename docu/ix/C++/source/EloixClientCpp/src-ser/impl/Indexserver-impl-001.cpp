#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;


namespace de { namespace elo { namespace ix { namespace client { namespace search { 

void operator & (BIO& ar, SearchIndexerStatus& e) {
	int32_t v = static_cast<int32_t>(e);
	ar & v;
	if (ar.is_loading) e = static_cast<SearchIndexerStatus>(v);
}

}}}}}


namespace de { namespace elo { namespace ix { namespace client { namespace notify { 

void operator & (BIO& ar, TaskNotifyType& e) {
	int32_t v = static_cast<int32_t>(e);
	ar & v;
	if (ar.is_loading) e = static_cast<TaskNotifyType>(v);
}

}}}}}


namespace de { namespace elo { namespace ix { namespace client { namespace health { 

void operator & (BIO& ar, HealthCheckValueOperation& e) {
	int32_t v = static_cast<int32_t>(e);
	ar & v;
	if (ar.is_loading) e = static_cast<HealthCheckValueOperation>(v);
}

}}}}}


namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

void operator & (BIO& ar, EActionType& e) {
	int32_t v = static_cast<int32_t>(e);
	ar & v;
	if (ar.is_loading) e = static_cast<EActionType>(v);
}

}}}}}


namespace de { namespace elo { namespace ix { namespace client { 

void operator & (BIO& ar, InheritKeywordingResult& e) {
	int32_t v = static_cast<int32_t>(e);
	ar & v;
	if (ar.is_loading) e = static_cast<InheritKeywordingResult>(v);
}

}}}}

// checkpoint byps.gen.cpp.GenApiClass:901
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1374008726(BIO& bio, POBJECT& pObj, PSerializable&, void* ){
	PBytes p = byps_static_ptr_cast<BBytes>(pObj);
	if (bio.is_loading) {
		if (p) return;
		bio.serialize(p);
		pObj = p;
	}
	else {
		bio.serialize(p);
	}
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class AccessC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
AccessC::AccessC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::AccessC::BSerializable_getTypeId() {
	return 384025970; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void AccessC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_384025970(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::AccessC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class AclAccessInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
AclAccessInfo::AclAccessInfo() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::AclAccessInfo::AclAccessInfo(const ::std::wstring& acl, const PArrayAclItem& aclItems, const ::std::wstring& objId, const ::std::wstring& parentId)
	: acl(acl)
	, aclItems(aclItems)
	, objId(objId)
	, parentId(parentId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::AclAccessInfo::BSerializable_getTypeId() {
	return 11569337; 
}
void AclAccessInfo::setAcl(::std::wstring v) {
	acl = v;
}
void AclAccessInfo::setAclItems(PArrayAclItem v) {
	aclItems = v;
}
void AclAccessInfo::setObjId(::std::wstring v) {
	objId = v;
}
void AclAccessInfo::setParentId(::std::wstring v) {
	parentId = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void AclAccessInfo::serialize(BIO& ar, const BVERSION version) {
	ar & this->acl;
	ar & this->objId;
	if (version >= 800000032000010) {
		ar & this->parentId;
	}
	ar & this->aclItems;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_11569337(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::AclAccessInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class AclAccessResult
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
AclAccessResult::AclAccessResult() {
	access = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::AclAccessResult::AclAccessResult(int32_t access)
	: access(access)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::AclAccessResult::BSerializable_getTypeId() {
	return 200528028; 
}
void AclAccessResult::setAccess(int32_t v) {
	access = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void AclAccessResult::serialize(BIO& ar, const BVERSION version) {
	ar & this->access;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_200528028(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::AclAccessResult>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ValueClass
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ValueClass::ValueClass() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ValueClass::BSerializable_getTypeId() {
	return 175726414; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ValueClass::serialize(BIO& ar, const BVERSION version) {
	BValueClass::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_175726414(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ValueClass>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class AclItem
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
AclItem::AclItem() {
	access = 0;
	id = 0;
	type = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::AclItem::AclItem(int32_t access, int32_t id, const ::std::wstring& name, int32_t type, const PArrayIdName& andGroups)
	: access(access)
	, id(id)
	, name(name)
	, type(type)
	, andGroups(andGroups)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::AclItem::BSerializable_getTypeId() {
	return 1255072841; 
}
void AclItem::setAccess(int32_t v) {
	access = v;
}
void AclItem::setId(int32_t v) {
	id = v;
}
void AclItem::setName(::std::wstring v) {
	name = v;
}
void AclItem::setType(int32_t v) {
	type = v;
}
void AclItem::setAndGroups(PArrayIdName v) {
	andGroups = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void AclItem::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->access;
	ar & this->id;
	ar & this->name;
	ar & this->type;
	if (version >= 700000000000005) {
		ar & this->andGroups;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1255072841(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::AclItem>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class AclItemC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
AclItemC::AclItemC() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::AclItemC::AclItemC(int32_t TYPE_GROUP, int32_t TYPE_USER, int32_t TYPE_KEY, int32_t TYPE_INHERIT, int32_t TYPE_OWNER, const ::std::wstring& ACL_EVERYONE_RAW, const PArrayAclItem& ACL_EVERYONE)
	: ACL_EVERYONE_RAW(ACL_EVERYONE_RAW)
	, ACL_EVERYONE(ACL_EVERYONE)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::AclItemC::BSerializable_getTypeId() {
	return 1507233874; 
}
void AclItemC::setACL_EVERYONE_RAW(::std::wstring v) {
	ACL_EVERYONE_RAW = v;
}
void AclItemC::setACL_EVERYONE(PArrayAclItem v) {
	ACL_EVERYONE = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void AclItemC::serialize(BIO& ar, const BVERSION version) {
	if (version >= 700000000000013) {
		ar & this->ACL_EVERYONE_RAW;
	}
	if (version >= 700000000000013) {
		ar & this->ACL_EVERYONE;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1507233874(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::AclItemC>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1944875656(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PAclItem > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class Activity
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
Activity::Activity() {
	prio = 0;
	receiverId = 0;
	senderId = 0;
	objId = 0;
	objType = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::Activity::Activity(const ::std::wstring& TStamp, const ::std::wstring& backAt, const ::std::wstring& backMode, const ::std::wstring& comment, const ::std::wstring& destination, const ::std::wstring& dueDateIso, const ::std::wstring& fileName, const ::std::wstring& guid, const ::std::wstring& name, const ::std::wstring& objGuid, int32_t prio, const ::std::wstring& project, int32_t receiverId, const ::std::wstring& revVers, int32_t senderId, const ::std::wstring& sentAtIso, const ::std::wstring& sentMode, const ::std::wstring& ud0, const ::std::wstring& ud1, const ::std::wstring& ud2, const ::std::wstring& ud3, const ::std::wstring& ud4, const ::std::wstring& ud5, const ::std::wstring& ud6, const ::std::wstring& ud7, const ::std::wstring& ud8, const ::std::wstring& ud9, const ::std::wstring& receiverName, const ::std::wstring& senderName, const ::std::wstring& transId, int32_t objId, int32_t objType, const ::std::wstring& TStampSync)
	: TStamp(TStamp)
	, backAt(backAt)
	, backMode(backMode)
	, comment(comment)
	, destination(destination)
	, dueDateIso(dueDateIso)
	, fileName(fileName)
	, guid(guid)
	, name(name)
	, objGuid(objGuid)
	, prio(prio)
	, project(project)
	, receiverId(receiverId)
	, revVers(revVers)
	, senderId(senderId)
	, sentAtIso(sentAtIso)
	, sentMode(sentMode)
	, ud0(ud0)
	, ud1(ud1)
	, ud2(ud2)
	, ud3(ud3)
	, ud4(ud4)
	, ud5(ud5)
	, ud6(ud6)
	, ud7(ud7)
	, ud8(ud8)
	, ud9(ud9)
	, receiverName(receiverName)
	, senderName(senderName)
	, transId(transId)
	, objId(objId)
	, objType(objType)
	, TStampSync(TStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::Activity::BSerializable_getTypeId() {
	return 460199434; 
}
void Activity::setTStamp(::std::wstring v) {
	TStamp = v;
	setChangedMember(ActivityC::mbTStamp);
}
void Activity::setBackAt(::std::wstring v) {
	backAt = v;
	setChangedMember(ActivityC::mbBackAt);
}
void Activity::setBackMode(::std::wstring v) {
	backMode = v;
	setChangedMember(ActivityC::mbBackMode);
}
void Activity::setComment(::std::wstring v) {
	comment = v;
	setChangedMember(ActivityC::mbComment);
}
void Activity::setDestination(::std::wstring v) {
	destination = v;
	setChangedMember(ActivityC::mbDestination);
}
void Activity::setDueDateIso(::std::wstring v) {
	dueDateIso = v;
	setChangedMember(ActivityC::mbDueDateIso);
}
void Activity::setFileName(::std::wstring v) {
	fileName = v;
	setChangedMember(ActivityC::mbFileName);
}
void Activity::setGuid(::std::wstring v) {
	guid = v;
	setChangedMember(ActivityC::mbGuid);
}
void Activity::setName(::std::wstring v) {
	name = v;
	setChangedMember(ActivityC::mbName);
}
void Activity::setObjGuid(::std::wstring v) {
	objGuid = v;
	setChangedMember(ActivityC::mbObjGuid);
}
void Activity::setPrio(int32_t v) {
	prio = v;
	setChangedMember(ActivityC::mbPrio);
}
void Activity::setProject(::std::wstring v) {
	project = v;
	setChangedMember(ActivityC::mbProject);
}
void Activity::setReceiverId(int32_t v) {
	receiverId = v;
	setChangedMember(ActivityC::mbReceiverId);
}
void Activity::setRevVers(::std::wstring v) {
	revVers = v;
	setChangedMember(ActivityC::mbRevVers);
}
void Activity::setSenderId(int32_t v) {
	senderId = v;
	setChangedMember(ActivityC::mbSenderId);
}
void Activity::setSentAtIso(::std::wstring v) {
	sentAtIso = v;
	setChangedMember(ActivityC::mbSentAtIso);
}
void Activity::setSentMode(::std::wstring v) {
	sentMode = v;
	setChangedMember(ActivityC::mbSentMode);
}
void Activity::setUd0(::std::wstring v) {
	ud0 = v;
	setChangedMember(ActivityC::mbUd0);
}
void Activity::setUd1(::std::wstring v) {
	ud1 = v;
	setChangedMember(ActivityC::mbUd1);
}
void Activity::setUd2(::std::wstring v) {
	ud2 = v;
	setChangedMember(ActivityC::mbUd2);
}
void Activity::setUd3(::std::wstring v) {
	ud3 = v;
	setChangedMember(ActivityC::mbUd3);
}
void Activity::setUd4(::std::wstring v) {
	ud4 = v;
	setChangedMember(ActivityC::mbUd4);
}
void Activity::setUd5(::std::wstring v) {
	ud5 = v;
	setChangedMember(ActivityC::mbUd5);
}
void Activity::setUd6(::std::wstring v) {
	ud6 = v;
	setChangedMember(ActivityC::mbUd6);
}
void Activity::setUd7(::std::wstring v) {
	ud7 = v;
	setChangedMember(ActivityC::mbUd7);
}
void Activity::setUd8(::std::wstring v) {
	ud8 = v;
	setChangedMember(ActivityC::mbUd8);
}
void Activity::setUd9(::std::wstring v) {
	ud9 = v;
	setChangedMember(ActivityC::mbUd9);
}
void Activity::setReceiverName(::std::wstring v) {
	receiverName = v;
}
void Activity::setSenderName(::std::wstring v) {
	senderName = v;
}
void Activity::setTransId(::std::wstring v) {
	transId = v;
	setChangedMember(ActivityC::mbTransId);
}
void Activity::setObjId(int32_t v) {
	objId = v;
	setChangedMember(ActivityC::mbObjId);
}
void Activity::setObjType(int32_t v) {
	objType = v;
	setChangedMember(ActivityC::mbObjType);
}
void Activity::setTStampSync(::std::wstring v) {
	TStampSync = v;
	setChangedMember(ActivityC::mbTStampSync);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void Activity::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->TStamp;
	ar & this->backAt;
	ar & this->backMode;
	ar & this->comment;
	ar & this->destination;
	ar & this->dueDateIso;
	ar & this->fileName;
	ar & this->guid;
	ar & this->name;
	ar & this->objGuid;
	ar & this->prio;
	ar & this->project;
	ar & this->receiverId;
	ar & this->receiverName;
	ar & this->revVers;
	ar & this->senderId;
	ar & this->senderName;
	ar & this->sentAtIso;
	ar & this->sentMode;
	ar & this->ud0;
	ar & this->ud1;
	ar & this->ud2;
	ar & this->ud3;
	ar & this->ud4;
	ar & this->ud5;
	ar & this->ud6;
	ar & this->ud7;
	ar & this->ud8;
	ar & this->ud9;
	if (version >= 800000012000001) {
		ar & this->transId;
		if (version >= 800000018000001) {
			ar & this->objId;
			ar & this->objType;
			if (version >= 900990009000001) {
				ar & this->TStampSync;
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_460199434(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::Activity>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ActivityDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ActivityDataC::ActivityDataC() {
	lnGuid = 0;
	lnObjGuid = 0;
	lnTStamp = 0;
	lnProject = 0;
	lnRevVers = 0;
	lnName = 0;
	lnDestination = 0;
	lnSentAtIso = 0;
	lnSentMode = 0;
	lnDueDateIso = 0;
	lnBackAt = 0;
	lnBackMode = 0;
	lnComment = 0;
	lnFileName = 0;
	lnUd0 = 0;
	lnUd1 = 0;
	lnUd2 = 0;
	lnUd3 = 0;
	lnUd4 = 0;
	lnUd5 = 0;
	lnUd6 = 0;
	lnUd7 = 0;
	lnUd8 = 0;
	lnUd9 = 0;
	lnTransId = 0;
	lnTStampSync = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ActivityDataC::ActivityDataC(int64_t mbGuid, int32_t lnGuid, int64_t mbObjGuid, int32_t lnObjGuid, int64_t mbTStamp, int32_t lnTStamp, int64_t mbProject, int32_t lnProject, int64_t mbRevVers, int32_t lnRevVers, int64_t mbReceiverId, int64_t mbSenderId, int64_t mbPrio, int64_t mbName, int32_t lnName, int64_t mbDestination, int32_t lnDestination, int64_t mbSentAtIso, int32_t lnSentAtIso, int64_t mbSentMode, int32_t lnSentMode, int64_t mbDueDateIso, int32_t lnDueDateIso, int64_t mbBackAt, int32_t lnBackAt, int64_t mbBackMode, int32_t lnBackMode, int64_t mbComment, int32_t lnComment, int64_t mbFileName, int32_t lnFileName, int64_t mbUd0, int32_t lnUd0, int64_t mbUd1, int32_t lnUd1, int64_t mbUd2, int32_t lnUd2, int64_t mbUd3, int32_t lnUd3, int64_t mbUd4, int32_t lnUd4, int64_t mbUd5, int32_t lnUd5, int64_t mbUd6, int32_t lnUd6, int64_t mbUd7, int32_t lnUd7, int64_t mbUd8, int32_t lnUd8, int64_t mbUd9, int32_t lnUd9, int64_t mbTransId, int32_t lnTransId, int64_t mbObjId, int64_t mbObjType, int64_t mbTStampSync, int32_t lnTStampSync, int64_t mbAllMembers)
	: lnGuid(lnGuid)
	, lnObjGuid(lnObjGuid)
	, lnTStamp(lnTStamp)
	, lnProject(lnProject)
	, lnRevVers(lnRevVers)
	, lnName(lnName)
	, lnDestination(lnDestination)
	, lnSentAtIso(lnSentAtIso)
	, lnSentMode(lnSentMode)
	, lnDueDateIso(lnDueDateIso)
	, lnBackAt(lnBackAt)
	, lnBackMode(lnBackMode)
	, lnComment(lnComment)
	, lnFileName(lnFileName)
	, lnUd0(lnUd0)
	, lnUd1(lnUd1)
	, lnUd2(lnUd2)
	, lnUd3(lnUd3)
	, lnUd4(lnUd4)
	, lnUd5(lnUd5)
	, lnUd6(lnUd6)
	, lnUd7(lnUd7)
	, lnUd8(lnUd8)
	, lnUd9(lnUd9)
	, lnTransId(lnTransId)
	, lnTStampSync(lnTStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ActivityDataC::BSerializable_getTypeId() {
	return 72578008; 
}
void ActivityDataC::setLnGuid(int32_t v) {
	lnGuid = v;
}
void ActivityDataC::setLnObjGuid(int32_t v) {
	lnObjGuid = v;
}
void ActivityDataC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
void ActivityDataC::setLnProject(int32_t v) {
	lnProject = v;
}
void ActivityDataC::setLnRevVers(int32_t v) {
	lnRevVers = v;
}
void ActivityDataC::setLnName(int32_t v) {
	lnName = v;
}
void ActivityDataC::setLnDestination(int32_t v) {
	lnDestination = v;
}
void ActivityDataC::setLnSentAtIso(int32_t v) {
	lnSentAtIso = v;
}
void ActivityDataC::setLnSentMode(int32_t v) {
	lnSentMode = v;
}
void ActivityDataC::setLnDueDateIso(int32_t v) {
	lnDueDateIso = v;
}
void ActivityDataC::setLnBackAt(int32_t v) {
	lnBackAt = v;
}
void ActivityDataC::setLnBackMode(int32_t v) {
	lnBackMode = v;
}
void ActivityDataC::setLnComment(int32_t v) {
	lnComment = v;
}
void ActivityDataC::setLnFileName(int32_t v) {
	lnFileName = v;
}
void ActivityDataC::setLnUd0(int32_t v) {
	lnUd0 = v;
}
void ActivityDataC::setLnUd1(int32_t v) {
	lnUd1 = v;
}
void ActivityDataC::setLnUd2(int32_t v) {
	lnUd2 = v;
}
void ActivityDataC::setLnUd3(int32_t v) {
	lnUd3 = v;
}
void ActivityDataC::setLnUd4(int32_t v) {
	lnUd4 = v;
}
void ActivityDataC::setLnUd5(int32_t v) {
	lnUd5 = v;
}
void ActivityDataC::setLnUd6(int32_t v) {
	lnUd6 = v;
}
void ActivityDataC::setLnUd7(int32_t v) {
	lnUd7 = v;
}
void ActivityDataC::setLnUd8(int32_t v) {
	lnUd8 = v;
}
void ActivityDataC::setLnUd9(int32_t v) {
	lnUd9 = v;
}
void ActivityDataC::setLnTransId(int32_t v) {
	lnTransId = v;
}
void ActivityDataC::setLnTStampSync(int32_t v) {
	lnTStampSync = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ActivityDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnBackAt;
	ar & this->lnBackMode;
	ar & this->lnComment;
	ar & this->lnDestination;
	ar & this->lnDueDateIso;
	ar & this->lnFileName;
	ar & this->lnGuid;
	ar & this->lnName;
	ar & this->lnObjGuid;
	ar & this->lnProject;
	ar & this->lnRevVers;
	ar & this->lnSentAtIso;
	ar & this->lnSentMode;
	ar & this->lnTStamp;
	ar & this->lnUd0;
	ar & this->lnUd1;
	ar & this->lnUd2;
	ar & this->lnUd3;
	ar & this->lnUd4;
	ar & this->lnUd5;
	ar & this->lnUd6;
	ar & this->lnUd7;
	ar & this->lnUd8;
	ar & this->lnUd9;
	if (version >= 800000012000001) {
		ar & this->lnTransId;
		if (version >= 900990009000001) {
			ar & this->lnTStampSync;
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_72578008(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ActivityDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ActivityC
// Generated from class byps.gen.cpp.GenApiClass

const PActivityZ ActivityC::mbOnlyGuid = PActivityZ(new ActivityZ(
	1LL));

const PActivityZ ActivityC::mbActivityAndObjectGuid = PActivityZ(new ActivityZ(
	3LL));

const PActivityZ ActivityC::mbAll = PActivityZ(new ActivityZ(
	2147483647LL));

// checkpoint byps.gen.cpp.GenApiClass:489
ActivityC::ActivityC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ActivityC::BSerializable_getTypeId() {
	return 1091363488; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ActivityC::serialize(BIO& ar, const BVERSION version) {
	ActivityDataC::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1091363488(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ActivityC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ActivityOption
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ActivityOption::ActivityOption() {
	id = 0;
	onlyKeyword = false;
	readOnly = false;
	sorted = false;
	stamp = false;
	mandatory = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ActivityOption::ActivityOption(int32_t id, const ::std::wstring& name, bool onlyKeyword, bool readOnly, bool sorted, bool stamp, bool mandatory, const PArrayString& keywords)
	: id(id)
	, name(name)
	, onlyKeyword(onlyKeyword)
	, readOnly(readOnly)
	, sorted(sorted)
	, stamp(stamp)
	, mandatory(mandatory)
	, keywords(keywords)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ActivityOption::BSerializable_getTypeId() {
	return 595132669; 
}
void ActivityOption::setId(int32_t v) {
	id = v;
}
void ActivityOption::setName(::std::wstring v) {
	name = v;
}
void ActivityOption::setOnlyKeyword(bool v) {
	onlyKeyword = v;
}
void ActivityOption::setReadOnly(bool v) {
	readOnly = v;
}
void ActivityOption::setSorted(bool v) {
	sorted = v;
}
void ActivityOption::setStamp(bool v) {
	stamp = v;
}
void ActivityOption::setMandatory(bool v) {
	mandatory = v;
}
void ActivityOption::setKeywords(PArrayString v) {
	keywords = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ActivityOption::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->id;
	ar & this->mandatory;
	ar & this->name;
	ar & this->onlyKeyword;
	ar & this->readOnly;
	ar & this->sorted;
	ar & this->stamp;
	ar & this->keywords;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_595132669(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ActivityOption>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ActivityOptionC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ActivityOptionC::ActivityOptionC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ActivityOptionC::BSerializable_getTypeId() {
	return 1364827052; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ActivityOptionC::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1364827052(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ActivityOptionC>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1831677187(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PActivityOption > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ActivityProject
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ActivityProject::ActivityProject() {
	major = 0;
	minor = 0;
	protectedProject = false;
	lockedWhenFinished = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ActivityProject::ActivityProject(const ::std::wstring& project, int32_t major, int32_t minor, const ::std::wstring& optValue, const PArrayActivityOption& options, bool protectedProject, bool lockedWhenFinished)
	: project(project)
	, major(major)
	, minor(minor)
	, optValue(optValue)
	, options(options)
	, protectedProject(protectedProject)
	, lockedWhenFinished(lockedWhenFinished)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ActivityProject::BSerializable_getTypeId() {
	return 2121298555; 
}
void ActivityProject::setProject(::std::wstring v) {
	project = v;
	setChangedMember(ActivityProjectC::mbProject);
}
void ActivityProject::setMajor(int32_t v) {
	major = v;
	setChangedMember(ActivityProjectC::mbMajor);
}
void ActivityProject::setMinor(int32_t v) {
	minor = v;
	setChangedMember(ActivityProjectC::mbMinor);
}
void ActivityProject::setOptValue(::std::wstring v) {
	optValue = v;
	setChangedMember(ActivityProjectC::mbOptValue);
}
void ActivityProject::setOptions(PArrayActivityOption v) {
	options = v;
	setChangedMember(ActivityProjectC::mbOptions);
}
void ActivityProject::setProtectedProject(bool v) {
	protectedProject = v;
}
void ActivityProject::setLockedWhenFinished(bool v) {
	lockedWhenFinished = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ActivityProject::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->major;
	ar & this->minor;
	ar & this->optValue;
	ar & this->project;
	if (version >= 800000012000001) {
		ar & this->lockedWhenFinished;
		ar & this->protectedProject;
	}
	if (version >= 800000012000001) {
		ar & this->options;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2121298555(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ActivityProject>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ActivityProjectDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ActivityProjectDataC::ActivityProjectDataC() {
	lnProject = 0;
	lnOptValue = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ActivityProjectDataC::ActivityProjectDataC(int64_t mbProject, int32_t lnProject, int64_t mbMajor, int64_t mbMinor, int64_t mbOptValue, int32_t lnOptValue, int64_t mbAllMembers)
	: lnProject(lnProject)
	, lnOptValue(lnOptValue)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ActivityProjectDataC::BSerializable_getTypeId() {
	return 1946995741; 
}
void ActivityProjectDataC::setLnProject(int32_t v) {
	lnProject = v;
}
void ActivityProjectDataC::setLnOptValue(int32_t v) {
	lnOptValue = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ActivityProjectDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnOptValue;
	ar & this->lnProject;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1946995741(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ActivityProjectDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ActivityProjectC
// Generated from class byps.gen.cpp.GenApiClass

const ::std::wstring ActivityProjectC::SYSTEM = std::wstring(L"ELO_SYSTEM");

const ::std::wstring ActivityProjectC::DEFAULT = std::wstring(L"ELO");

const ::std::wstring ActivityProjectC::REQUEST = std::wstring(L"ELO_REQ");

const ::std::wstring ActivityProjectC::NOTIFY = std::wstring(L"ELO_NOTIFY");

// checkpoint byps.gen.cpp.GenApiClass:489
ActivityProjectC::ActivityProjectC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ActivityProjectC::BSerializable_getTypeId() {
	return 1697907147; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ActivityProjectC::serialize(BIO& ar, const BVERSION version) {
	ActivityProjectDataC::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1697907147(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ActivityProjectC>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_607287445(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PActivityProject > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ActivityZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ActivityZ::ActivityZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ActivityZ::ActivityZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ActivityZ::BSerializable_getTypeId() {
	return 730005706; 
}
void ActivityZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ActivityZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_730005706(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ActivityZ>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class AdminModeC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
AdminModeC::AdminModeC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::AdminModeC::BSerializable_getTypeId() {
	return 1820929375; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void AdminModeC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1820929375(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::AdminModeC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class Alert
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
Alert::Alert() {
	dest = 0;
	source = 0;
	type = 0;
	objId = 0;
	extra1 = 0;
	extra2 = 0;
	time = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::Alert::Alert(int32_t dest, const ::std::wstring& destName, int32_t source, const ::std::wstring& sourceName, int32_t type, int32_t objId, int32_t extra1, int32_t extra2, const ::std::wstring& memo, int32_t time, const ::std::wstring& timeIso)
	: dest(dest)
	, destName(destName)
	, source(source)
	, sourceName(sourceName)
	, type(type)
	, objId(objId)
	, extra1(extra1)
	, extra2(extra2)
	, memo(memo)
	, time(time)
	, timeIso(timeIso)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::Alert::BSerializable_getTypeId() {
	return 280775671; 
}
void Alert::setDest(int32_t v) {
	dest = v;
	setChangedMember(AlertC::mbDest);
}
void Alert::setDestName(::std::wstring v) {
	destName = v;
}
void Alert::setSource(int32_t v) {
	source = v;
	setChangedMember(AlertC::mbSource);
}
void Alert::setSourceName(::std::wstring v) {
	sourceName = v;
}
void Alert::setType(int32_t v) {
	type = v;
	setChangedMember(AlertC::mbType);
}
void Alert::setObjId(int32_t v) {
	objId = v;
	setChangedMember(AlertC::mbObjId);
}
void Alert::setExtra1(int32_t v) {
	extra1 = v;
	setChangedMember(AlertC::mbExtra1);
}
void Alert::setExtra2(int32_t v) {
	extra2 = v;
	setChangedMember(AlertC::mbExtra2);
}
void Alert::setMemo(::std::wstring v) {
	memo = v;
	setChangedMember(AlertC::mbMemo);
}
void Alert::setTime(int32_t v) {
	time = v;
	setChangedMember(AlertC::mbTime);
}
void Alert::setTimeIso(::std::wstring v) {
	timeIso = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void Alert::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->dest;
	ar & this->extra1;
	ar & this->extra2;
	ar & this->memo;
	ar & this->objId;
	ar & this->source;
	ar & this->time;
	ar & this->type;
	if (version >= 600000099000000) {
		ar & this->destName;
		ar & this->sourceName;
		ar & this->timeIso;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_280775671(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::Alert>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class AlertDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
AlertDataC::AlertDataC() {
	lnMemo = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::AlertDataC::AlertDataC(int64_t mbDest, int64_t mbSource, int64_t mbType, int64_t mbObjId, int64_t mbExtra1, int64_t mbExtra2, int64_t mbMemo, int32_t lnMemo, int64_t mbTime, int64_t mbAllMembers)
	: lnMemo(lnMemo)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::AlertDataC::BSerializable_getTypeId() {
	return 1498169909; 
}
void AlertDataC::setLnMemo(int32_t v) {
	lnMemo = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void AlertDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnMemo;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1498169909(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::AlertDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class AlertC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
AlertC::AlertC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::AlertC::BSerializable_getTypeId() {
	return 1426544289; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void AlertC::serialize(BIO& ar, const BVERSION version) {
	AlertDataC::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1426544289(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::AlertC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class Any
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
Any::Any() {
	type = 0;
	booleanValue = false;
	intValue = 0;
	longValue = 0;
	doubleValue = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::Any::Any(int32_t type, bool booleanValue, int32_t intValue, int64_t longValue, double doubleValue, const ::std::wstring& stringValue, const PValueClass& objectValue, const PBytes& byteArray, const PArrayAny& anyArray)
	: type(type)
	, booleanValue(booleanValue)
	, intValue(intValue)
	, longValue(longValue)
	, doubleValue(doubleValue)
	, stringValue(stringValue)
	, objectValue(objectValue)
	, byteArray(byteArray)
	, anyArray(anyArray)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::Any::BSerializable_getTypeId() {
	return 1191976387; 
}
void Any::setType(int32_t v) {
	type = v;
}
void Any::setBooleanValue(bool v) {
	booleanValue = v;
}
void Any::setIntValue(int32_t v) {
	intValue = v;
}
void Any::setLongValue(int64_t v) {
	longValue = v;
}
void Any::setDoubleValue(double v) {
	doubleValue = v;
}
void Any::setStringValue(::std::wstring v) {
	stringValue = v;
}
void Any::setObjectValue(PValueClass v) {
	objectValue = v;
}
void Any::setByteArray(PBytes v) {
	byteArray = v;
}
void Any::setAnyArray(PArrayAny v) {
	anyArray = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void Any::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->booleanValue;
	ar & this->doubleValue;
	ar & this->intValue;
	ar & this->longValue;
	ar & this->stringValue;
	ar & this->type;
	ar & this->anyArray;
	ar & this->byteArray;
	ar & this->objectValue;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1191976387(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::Any>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class AnyC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
AnyC::AnyC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::AnyC::BSerializable_getTypeId() {
	return 908393697; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void AnyC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_908393697(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::AnyC>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1233910153(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PAny > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ApplyForNotificationsInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ApplyForNotificationsInfo::ApplyForNotificationsInfo() {
	adminMode = false;
	userTask = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ApplyForNotificationsInfo::ApplyForNotificationsInfo(bool adminMode, bool userTask)
	: adminMode(adminMode)
	, userTask(userTask)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ApplyForNotificationsInfo::BSerializable_getTypeId() {
	return 77743605; 
}
void ApplyForNotificationsInfo::setAdminMode(bool v) {
	adminMode = v;
}
void ApplyForNotificationsInfo::setUserTask(bool v) {
	userTask = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ApplyForNotificationsInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->adminMode;
	ar & this->userTask;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_77743605(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ApplyForNotificationsInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ArcPath
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ArcPath::ArcPath() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ArcPath::ArcPath(const PArrayIdName& path, const ::std::wstring& pathAsString)
	: path(path)
	, pathAsString(pathAsString)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ArcPath::BSerializable_getTypeId() {
	return 945258954; 
}
void ArcPath::setPath(PArrayIdName v) {
	path = v;
}
void ArcPath::setPathAsString(::std::wstring v) {
	pathAsString = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ArcPath::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	if (version >= 700000000000028) {
		ar & this->pathAsString;
	}
	ar & this->path;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_945258954(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ArcPath>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1192039710(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PArcPath > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ArchiveStatistics
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ArchiveStatistics::ArchiveStatistics() {
	maxDocId = 0;
	maxObjId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ArchiveStatistics::ArchiveStatistics(int32_t maxDocId, int32_t maxObjId)
	: maxDocId(maxDocId)
	, maxObjId(maxObjId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ArchiveStatistics::BSerializable_getTypeId() {
	return 2056457945; 
}
void ArchiveStatistics::setMaxDocId(int32_t v) {
	maxDocId = v;
}
void ArchiveStatistics::setMaxObjId(int32_t v) {
	maxObjId = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ArchiveStatistics::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->maxDocId;
	ar & this->maxObjId;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2056457945(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ArchiveStatistics>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ArchiveStatisticsOptionsC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ArchiveStatisticsOptionsC::ArchiveStatisticsOptionsC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ArchiveStatisticsOptionsC::BSerializable_getTypeId() {
	return 276716257; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ArchiveStatisticsOptionsC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_276716257(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ArchiveStatisticsOptionsC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ArchivingModeC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ArchivingModeC::ArchivingModeC() {
	dummy = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ArchivingModeC::ArchivingModeC(int32_t READWRITE, int32_t VERSION, int32_t READONLY, int32_t DEFAULT, int32_t NONE, int32_t dummy)
	: dummy(dummy)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ArchivingModeC::BSerializable_getTypeId() {
	return 1464718703; 
}
void ArchivingModeC::setDummy(int32_t v) {
	dummy = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ArchivingModeC::serialize(BIO& ar, const BVERSION version) {
	ar & this->dummy;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1464718703(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ArchivingModeC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class AutoFilingOptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
AutoFilingOptions::AutoFilingOptions() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::AutoFilingOptions::AutoFilingOptions(const ::std::wstring& autoFilingDefinition)
	: autoFilingDefinition(autoFilingDefinition)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::AutoFilingOptions::BSerializable_getTypeId() {
	return 225606439; 
}
void AutoFilingOptions::setAutoFilingDefinition(::std::wstring v) {
	autoFilingDefinition = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void AutoFilingOptions::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	if (version >= 900000018000001) {
		ar & this->autoFilingDefinition;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_225606439(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::AutoFilingOptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class AutoFilingResult
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
AutoFilingResult::AutoFilingResult() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::AutoFilingResult::AutoFilingResult(const PArrayString& pathsAsString, const PArrayInt& parentIds)
	: pathsAsString(pathsAsString)
	, parentIds(parentIds)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::AutoFilingResult::BSerializable_getTypeId() {
	return 1881161566; 
}
void AutoFilingResult::setPathsAsString(PArrayString v) {
	pathsAsString = v;
}
void AutoFilingResult::setParentIds(PArrayInt v) {
	parentIds = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void AutoFilingResult::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->parentIds;
	ar & this->pathsAsString;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1881161566(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::AutoFilingResult>(bio, pObj, pObjS, pBase);	
}
}}}}
