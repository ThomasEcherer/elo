#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CheckinDocOptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
CheckinDocOptions::CheckinDocOptions() {
	keepIds = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::CheckinDocOptions::CheckinDocOptions(bool keepIds)
	: keepIds(keepIds)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CheckinDocOptions::BSerializable_getTypeId() {
	return 1433031299; 
}
void CheckinDocOptions::setKeepIds(bool v) {
	keepIds = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CheckinDocOptions::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->keepIds;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1433031299(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CheckinDocOptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CheckinOrgUnitInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
CheckinOrgUnitInfo::CheckinOrgUnitInfo() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CheckinOrgUnitInfo::BSerializable_getTypeId() {
	return 740959052; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CheckinOrgUnitInfo::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_740959052(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CheckinOrgUnitInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CheckinReportInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
CheckinReportInfo::CheckinReportInfo() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CheckinReportInfo::BSerializable_getTypeId() {
	return 279483092; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CheckinReportInfo::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_279483092(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CheckinReportInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CheckinUsersC
// Generated from class byps.gen.cpp.GenApiClass

const PCheckinUsersZ CheckinUsersC::NOTHING = PCheckinUsersZ(new CheckinUsersZ(
	0LL));

const PCheckinUsersZ CheckinUsersC::PASSWORD = PCheckinUsersZ(new CheckinUsersZ(
	2LL));

const PCheckinUsersZ CheckinUsersC::NEW_USER = PCheckinUsersZ(new CheckinUsersZ(
	5LL));

const PCheckinUsersZ CheckinUsersC::WRITE = PCheckinUsersZ(new CheckinUsersZ(
	1LL));

const PCheckinUsersZ CheckinUsersC::WRITE_PASSWORD = PCheckinUsersZ(new CheckinUsersZ(
	3LL));

// checkpoint byps.gen.cpp.GenApiClass:489
CheckinUsersC::CheckinUsersC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CheckinUsersC::BSerializable_getTypeId() {
	return 1602486374; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CheckinUsersC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1602486374(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CheckinUsersC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CheckinUsersZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
CheckinUsersZ::CheckinUsersZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::CheckinUsersZ::CheckinUsersZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CheckinUsersZ::BSerializable_getTypeId() {
	return 403687865; 
}
void CheckinUsersZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CheckinUsersZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_403687865(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CheckinUsersZ>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CheckoutOrgUnitInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
CheckoutOrgUnitInfo::CheckoutOrgUnitInfo() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CheckoutOrgUnitInfo::BSerializable_getTypeId() {
	return 948431844; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CheckoutOrgUnitInfo::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_948431844(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CheckoutOrgUnitInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CheckoutSordPathInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
CheckoutSordPathInfo::CheckoutSordPathInfo() {
	inclRefPaths = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::CheckoutSordPathInfo::CheckoutSordPathInfo(bool inclRefPaths)
	: inclRefPaths(inclRefPaths)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CheckoutSordPathInfo::BSerializable_getTypeId() {
	return 730679282; 
}
void CheckoutSordPathInfo::setInclRefPaths(bool v) {
	inclRefPaths = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CheckoutSordPathInfo::serialize(BIO& ar, const BVERSION version) {
	ar & this->inclRefPaths;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_730679282(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CheckoutSordPathInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CheckoutUsersC
// Generated from class byps.gen.cpp.GenApiClass

const PCheckoutUsersZ CheckoutUsersC::NOTHING = PCheckoutUsersZ(new CheckoutUsersZ(
	0LL));

const PCheckoutUsersZ CheckoutUsersC::BY_IDS = PCheckoutUsersZ(new CheckoutUsersZ(
	513LL));

const PCheckoutUsersZ CheckoutUsersC::BY_IDS_RAW = PCheckoutUsersZ(new CheckoutUsersZ(
	1LL));

const PCheckoutUsersZ CheckoutUsersC::ALL_USERS = PCheckoutUsersZ(new CheckoutUsersZ(
	514LL));

const PCheckoutUsersZ CheckoutUsersC::ALL_USERS_RAW = PCheckoutUsersZ(new CheckoutUsersZ(
	2LL));

const PCheckoutUsersZ CheckoutUsersC::ALL_GROUPS = PCheckoutUsersZ(new CheckoutUsersZ(
	515LL));

const PCheckoutUsersZ CheckoutUsersC::ALL_GROUPS_RAW = PCheckoutUsersZ(new CheckoutUsersZ(
	3LL));

const PCheckoutUsersZ CheckoutUsersC::ALL_USERS_AND_GROUPS = PCheckoutUsersZ(new CheckoutUsersZ(
	516LL));

const PCheckoutUsersZ CheckoutUsersC::ALL_USERS_AND_GROUPS_RAW = PCheckoutUsersZ(new CheckoutUsersZ(
	4LL));

const PCheckoutUsersZ CheckoutUsersC::MEMBERS_OF_GROUP = PCheckoutUsersZ(new CheckoutUsersZ(
	517LL));

const PCheckoutUsersZ CheckoutUsersC::MEMBERS_OF_GROUP_RAW = PCheckoutUsersZ(new CheckoutUsersZ(
	5LL));

const PCheckoutUsersZ CheckoutUsersC::USERS_OF_GROUP = PCheckoutUsersZ(new CheckoutUsersZ(
	518LL));

const PCheckoutUsersZ CheckoutUsersC::USERS_OF_GROUP_RAW = PCheckoutUsersZ(new CheckoutUsersZ(
	6LL));

const PCheckoutUsersZ CheckoutUsersC::MEMBERS_OF_GROUP_RECURSIVE = PCheckoutUsersZ(new CheckoutUsersZ(
	519LL));

const PCheckoutUsersZ CheckoutUsersC::MEMBERS_OF_GROUP_RECURSIVE_RAW = PCheckoutUsersZ(new CheckoutUsersZ(
	7LL));

const PCheckoutUsersZ CheckoutUsersC::USERS_OF_GROUP_RECURSIVE = PCheckoutUsersZ(new CheckoutUsersZ(
	520LL));

const PCheckoutUsersZ CheckoutUsersC::USERS_OF_GROUP_RECURSIVE_RAW = PCheckoutUsersZ(new CheckoutUsersZ(
	8LL));

const PCheckoutUsersZ CheckoutUsersC::GROUPS_OF_MEMBER = PCheckoutUsersZ(new CheckoutUsersZ(
	521LL));

const PCheckoutUsersZ CheckoutUsersC::GROUPS_OF_MEMBER_RAW = PCheckoutUsersZ(new CheckoutUsersZ(
	9LL));

const PCheckoutUsersZ CheckoutUsersC::GROUPS_OF_MEMBER_RECURSIVE = PCheckoutUsersZ(new CheckoutUsersZ(
	522LL));

const PCheckoutUsersZ CheckoutUsersC::GROUPS_OF_MEMBER_RECURSIVE_RAW = PCheckoutUsersZ(new CheckoutUsersZ(
	10LL));

const PCheckoutUsersZ CheckoutUsersC::SESSION_USERS = PCheckoutUsersZ(new CheckoutUsersZ(
	523LL));

const PCheckoutUsersZ CheckoutUsersC::SESSION_USERS_RAW = PCheckoutUsersZ(new CheckoutUsersZ(
	11LL));

const PCheckoutUsersZ CheckoutUsersC::SUBADMINS = PCheckoutUsersZ(new CheckoutUsersZ(
	524LL));

const PCheckoutUsersZ CheckoutUsersC::MEMBERS_OF_ORGUNIT = PCheckoutUsersZ(new CheckoutUsersZ(
	13LL));

const PCheckoutUsersZ CheckoutUsersC::USERS_OF_SUBADMIN = PCheckoutUsersZ(new CheckoutUsersZ(
	526LL));

// checkpoint byps.gen.cpp.GenApiClass:489
CheckoutUsersC::CheckoutUsersC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CheckoutUsersC::BSerializable_getTypeId() {
	return 531758278; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CheckoutUsersC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_531758278(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CheckoutUsersC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CheckoutUsersZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
CheckoutUsersZ::CheckoutUsersZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::CheckoutUsersZ::CheckoutUsersZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CheckoutUsersZ::BSerializable_getTypeId() {
	return 1897433533; 
}
void CheckoutUsersZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CheckoutUsersZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1897433533(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CheckoutUsersZ>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CheckoutWorkflowHistoryParams
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
CheckoutWorkflowHistoryParams::CheckoutWorkflowHistoryParams() {
	nodeId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::CheckoutWorkflowHistoryParams::CheckoutWorkflowHistoryParams(const ::std::wstring& flowId, int32_t nodeId)
	: flowId(flowId)
	, nodeId(nodeId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CheckoutWorkflowHistoryParams::BSerializable_getTypeId() {
	return 299426984; 
}
void CheckoutWorkflowHistoryParams::setFlowId(::std::wstring v) {
	flowId = v;
}
void CheckoutWorkflowHistoryParams::setNodeId(int32_t v) {
	nodeId = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CheckoutWorkflowHistoryParams::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->flowId;
	ar & this->nodeId;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_299426984(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CheckoutWorkflowHistoryParams>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CheckoutWorkflowHistoryResult
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
CheckoutWorkflowHistoryResult::CheckoutWorkflowHistoryResult() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::CheckoutWorkflowHistoryResult::CheckoutWorkflowHistoryResult(const byps_ptr< ::std::map< int32_t , PVectorWFNodeHistory > >& nodeHistories)
	: nodeHistories(nodeHistories)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CheckoutWorkflowHistoryResult::BSerializable_getTypeId() {
	return 1754570852; 
}
void CheckoutWorkflowHistoryResult::setNodeHistories(byps_ptr< ::std::map< int32_t , PVectorWFNodeHistory > > v) {
	nodeHistories = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CheckoutWorkflowHistoryResult::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->nodeHistories;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1754570852(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CheckoutWorkflowHistoryResult>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ClientInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ClientInfo::ClientInfo() {
	options = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ClientInfo::ClientInfo(const ::std::wstring& callId, const ::std::wstring& country, const ::std::wstring& language, const ::std::wstring& ticket, const ::std::wstring& timeZone, int32_t options)
	: callId(callId)
	, country(country)
	, language(language)
	, ticket(ticket)
	, timeZone(timeZone)
	, options(options)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ClientInfo::BSerializable_getTypeId() {
	return 1258190913; 
}
void ClientInfo::setCallId(::std::wstring v) {
	callId = v;
}
void ClientInfo::setCountry(::std::wstring v) {
	country = v;
}
void ClientInfo::setLanguage(::std::wstring v) {
	language = v;
}
void ClientInfo::setTicket(::std::wstring v) {
	ticket = v;
}
void ClientInfo::setTimeZone(::std::wstring v) {
	timeZone = v;
}
void ClientInfo::setOptions(int32_t v) {
	options = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ClientInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->callId;
	ar & this->country;
	ar & this->language;
	ar & this->ticket;
	ar & this->timeZone;
	if (version >= 800000010000000) {
		ar & this->options;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1258190913(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ClientInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ClientInfoC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ClientInfoC::ClientInfoC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ClientInfoC::BSerializable_getTypeId() {
	return 847449421; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ClientInfoC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_847449421(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ClientInfoC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ColorData
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ColorData::ColorData() {
	RGB = 0;
	id = 0;
	deleted = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ColorData::ColorData(int32_t RGB, int32_t id, const ::std::wstring& name, const ::std::wstring& guid, const ::std::wstring& TStamp, bool deleted, const ::std::wstring& TStampSync)
	: RGB(RGB)
	, id(id)
	, name(name)
	, guid(guid)
	, TStamp(TStamp)
	, deleted(deleted)
	, TStampSync(TStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ColorData::BSerializable_getTypeId() {
	return 1735048729; 
}
void ColorData::setRGB(int32_t v) {
	RGB = v;
	setChangedMember(ColorDataC::mbRGB);
}
void ColorData::setId(int32_t v) {
	id = v;
	setChangedMember(ColorDataC::mbId);
}
void ColorData::setName(::std::wstring v) {
	name = v;
	setChangedMember(ColorDataC::mbName);
}
void ColorData::setGuid(::std::wstring v) {
	guid = v;
	setChangedMember(ColorDataC::mbGuid);
}
void ColorData::setTStamp(::std::wstring v) {
	TStamp = v;
	setChangedMember(ColorDataC::mbTStamp);
}
void ColorData::setDeleted(bool v) {
	deleted = v;
	setChangedMember(ColorDataC::mbDeleted);
}
void ColorData::setTStampSync(::std::wstring v) {
	TStampSync = v;
	setChangedMember(ColorDataC::mbTStampSync);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ColorData::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->RGB;
	ar & this->id;
	ar & this->name;
	if (version >= 700000000000003) {
		ar & this->TStamp;
		ar & this->deleted;
		ar & this->guid;
		if (version >= 900990009000001) {
			ar & this->TStampSync;
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1735048729(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ColorData>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ColorDataInternC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ColorDataInternC::ColorDataInternC() {
	lnName = 0;
	lnGuid = 0;
	lnTStamp = 0;
	lnTStampSync = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ColorDataInternC::ColorDataInternC(int64_t mbId, int64_t mbName, int32_t lnName, int64_t mbRGB, int64_t mbStatus, int64_t mbGuid, int32_t lnGuid, int64_t mbTStamp, int32_t lnTStamp, int64_t mbTStampSync, int32_t lnTStampSync, int64_t mbAllMembers)
	: lnName(lnName)
	, lnGuid(lnGuid)
	, lnTStamp(lnTStamp)
	, lnTStampSync(lnTStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ColorDataInternC::BSerializable_getTypeId() {
	return 1208511866; 
}
void ColorDataInternC::setLnName(int32_t v) {
	lnName = v;
}
void ColorDataInternC::setLnGuid(int32_t v) {
	lnGuid = v;
}
void ColorDataInternC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
void ColorDataInternC::setLnTStampSync(int32_t v) {
	lnTStampSync = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ColorDataInternC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnName;
	if (version >= 700000000000003) {
		ar & this->lnGuid;
		ar & this->lnTStamp;
		if (version >= 900990009000001) {
			ar & this->lnTStampSync;
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1208511866(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ColorDataInternC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ColorDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ColorDataC::ColorDataC() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ColorDataC::ColorDataC(const ::std::wstring& GUID_SYSTEM, const ::std::wstring& GUID_RED, const ::std::wstring& GUID_GREEN, const ::std::wstring& GUID_BLUE, int64_t mbDeleted)
	: GUID_SYSTEM(GUID_SYSTEM)
	, GUID_RED(GUID_RED)
	, GUID_GREEN(GUID_GREEN)
	, GUID_BLUE(GUID_BLUE)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ColorDataC::BSerializable_getTypeId() {
	return 881975137; 
}
void ColorDataC::setGUID_SYSTEM(::std::wstring v) {
	GUID_SYSTEM = v;
}
void ColorDataC::setGUID_RED(::std::wstring v) {
	GUID_RED = v;
}
void ColorDataC::setGUID_GREEN(::std::wstring v) {
	GUID_GREEN = v;
}
void ColorDataC::setGUID_BLUE(::std::wstring v) {
	GUID_BLUE = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ColorDataC::serialize(BIO& ar, const BVERSION version) {
	ColorDataInternC::serialize(ar, version);
	if (version >= 700000000000003) {
		ar & this->GUID_BLUE;
		ar & this->GUID_GREEN;
		ar & this->GUID_RED;
		ar & this->GUID_SYSTEM;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_881975137(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ColorDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1870182600(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PColorData > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CombineAclOptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
CombineAclOptions::CombineAclOptions() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::CombineAclOptions::CombineAclOptions(const ::std::wstring& lhsAclStr, const ::std::wstring& rhsAclStr)
	: lhsAclStr(lhsAclStr)
	, rhsAclStr(rhsAclStr)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CombineAclOptions::BSerializable_getTypeId() {
	return 66519402; 
}
void CombineAclOptions::setLhsAclStr(::std::wstring v) {
	lhsAclStr = v;
}
void CombineAclOptions::setRhsAclStr(::std::wstring v) {
	rhsAclStr = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CombineAclOptions::serialize(BIO& ar, const BVERSION version) {
	if (version >= 700000020000005) {
		ar & this->lhsAclStr;
		ar & this->rhsAclStr;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_66519402(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CombineAclOptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CombineAclResult
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
CombineAclResult::CombineAclResult() {
	compareCode = 0;
	compareIgnoreAccessCode = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::CombineAclResult::CombineAclResult(int32_t compareCode, int32_t compareIgnoreAccessCode, const PArrayAclItem& intersection, const ::std::wstring& intersectionAclStr, const PArrayAclItem& sum, const ::std::wstring& sumAclStr, const PArrayAclItem& difference, const ::std::wstring& differenceAclStr, const PArrayAclItem& inverseDifference, const ::std::wstring& inverseDifferenceAclStr)
	: compareCode(compareCode)
	, compareIgnoreAccessCode(compareIgnoreAccessCode)
	, intersection(intersection)
	, intersectionAclStr(intersectionAclStr)
	, sum(sum)
	, sumAclStr(sumAclStr)
	, difference(difference)
	, differenceAclStr(differenceAclStr)
	, inverseDifference(inverseDifference)
	, inverseDifferenceAclStr(inverseDifferenceAclStr)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CombineAclResult::BSerializable_getTypeId() {
	return 1034263904; 
}
void CombineAclResult::setCompareCode(int32_t v) {
	compareCode = v;
}
void CombineAclResult::setCompareIgnoreAccessCode(int32_t v) {
	compareIgnoreAccessCode = v;
}
void CombineAclResult::setIntersection(PArrayAclItem v) {
	intersection = v;
}
void CombineAclResult::setIntersectionAclStr(::std::wstring v) {
	intersectionAclStr = v;
}
void CombineAclResult::setSum(PArrayAclItem v) {
	sum = v;
}
void CombineAclResult::setSumAclStr(::std::wstring v) {
	sumAclStr = v;
}
void CombineAclResult::setDifference(PArrayAclItem v) {
	difference = v;
}
void CombineAclResult::setDifferenceAclStr(::std::wstring v) {
	differenceAclStr = v;
}
void CombineAclResult::setInverseDifference(PArrayAclItem v) {
	inverseDifference = v;
}
void CombineAclResult::setInverseDifferenceAclStr(::std::wstring v) {
	inverseDifferenceAclStr = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CombineAclResult::serialize(BIO& ar, const BVERSION version) {
	ar & this->compareCode;
	ar & this->compareIgnoreAccessCode;
	if (version >= 700000020000005) {
		ar & this->differenceAclStr;
		ar & this->intersectionAclStr;
		ar & this->inverseDifferenceAclStr;
		ar & this->sumAclStr;
	}
	ar & this->difference;
	ar & this->intersection;
	ar & this->inverseDifference;
	ar & this->sum;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1034263904(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CombineAclResult>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ConfigFile
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ConfigFile::ConfigFile() {
	isDirectory = false;
	size = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ConfigFile::ConfigFile(const ::std::wstring& dir, const PFileData& fileData, bool isDirectory, const ::std::wstring& lastModifiedISO, const ::std::wstring& name, int64_t size, const ::std::wstring& uploadResult, const ::std::wstring& url)
	: dir(dir)
	, fileData(fileData)
	, isDirectory(isDirectory)
	, lastModifiedISO(lastModifiedISO)
	, name(name)
	, size(size)
	, uploadResult(uploadResult)
	, url(url)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ConfigFile::BSerializable_getTypeId() {
	return 582012382; 
}
void ConfigFile::setDir(::std::wstring v) {
	dir = v;
}
void ConfigFile::setFileData(PFileData v) {
	fileData = v;
	setChangedMember(ConfigFileC::mbFileData);
}
void ConfigFile::setIsDirectory(bool v) {
	isDirectory = v;
}
void ConfigFile::setLastModifiedISO(::std::wstring v) {
	lastModifiedISO = v;
}
void ConfigFile::setName(::std::wstring v) {
	name = v;
	setChangedMember(ConfigFileC::mbName);
}
void ConfigFile::setSize(int64_t v) {
	size = v;
	setChangedMember(ConfigFileC::mbSize);
}
void ConfigFile::setUploadResult(::std::wstring v) {
	uploadResult = v;
}
void ConfigFile::setUrl(::std::wstring v) {
	url = v;
	setChangedMember(ConfigFileC::mbUrl);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ConfigFile::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->dir;
	ar & this->isDirectory;
	ar & this->lastModifiedISO;
	ar & this->name;
	ar & this->size;
	ar & this->uploadResult;
	ar & this->url;
	ar & this->fileData;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_582012382(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ConfigFile>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ConfigFileC
// Generated from class byps.gen.cpp.GenApiClass

const ::std::wstring ConfigFileC::COLD = std::wstring(L"cold");

const ::std::wstring ConfigFileC::ELO_SCRIPTS = std::wstring(L"eloscripts");

const ::std::wstring ConfigFileC::INIT_DATA = std::wstring(L"initdata");

const ::std::wstring ConfigFileC::POSTBOX = std::wstring(L"postbox");

const ::std::wstring ConfigFileC::CHECKOUT = std::wstring(L"checkout");

const ::std::wstring ConfigFileC::TEMPLATE = std::wstring(L"template");

const ::std::wstring ConfigFileC::VIEWER_POSTBOX = std::wstring(L"viewerpostbox");

const PConfigFileZ ConfigFileC::mbAll = PConfigFileZ(new ConfigFileZ(
	31LL));

const PConfigFileZ ConfigFileC::mbNoFileData = PConfigFileZ(new ConfigFileZ(
	29LL));

// checkpoint byps.gen.cpp.GenApiClass:489
ConfigFileC::ConfigFileC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ConfigFileC::BSerializable_getTypeId() {
	return 2098566124; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ConfigFileC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2098566124(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ConfigFileC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ConfigFileZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ConfigFileZ::ConfigFileZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ConfigFileZ::ConfigFileZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ConfigFileZ::BSerializable_getTypeId() {
	return 821574897; 
}
void ConfigFileZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ConfigFileZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_821574897(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ConfigFileZ>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1737266313(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PConfigFile > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ContextTerm
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ContextTerm::ContextTerm() {
	docNum = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ContextTerm::ContextTerm(const ::std::wstring& term, int32_t docNum)
	: term(term)
	, docNum(docNum)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ContextTerm::BSerializable_getTypeId() {
	return 1464223403; 
}
void ContextTerm::setTerm(::std::wstring v) {
	term = v;
}
void ContextTerm::setDocNum(int32_t v) {
	docNum = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ContextTerm::serialize(BIO& ar, const BVERSION version) {
	ar & this->docNum;
	ar & this->term;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1464223403(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ContextTerm>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1005790586(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PContextTerm > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ControlBackupInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ControlBackupInfo::ControlBackupInfo() {
	mode = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ControlBackupInfo::ControlBackupInfo(int32_t mode)
	: mode(mode)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ControlBackupInfo::BSerializable_getTypeId() {
	return 1738666671; 
}
void ControlBackupInfo::setMode(int32_t v) {
	mode = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ControlBackupInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->mode;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1738666671(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ControlBackupInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ControlBackupInfoC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ControlBackupInfoC::ControlBackupInfoC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ControlBackupInfoC::BSerializable_getTypeId() {
	return 1165618755; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ControlBackupInfoC::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1165618755(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ControlBackupInfoC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CopyInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
CopyInfo::CopyInfo() {
	depth = 0;
	manSortIdx = 0;
	adjustAclDifference = false;
	adjustAclOverwrite = false;
	adjustAclIgnoreFolders = false;
	adjustAclIgnoreDocuments = false;
	adjustAclInBackground = false;
	checkRecursion = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::CopyInfo::CopyInfo(int32_t depth, int32_t manSortIdx, const ::std::wstring& name, bool adjustAclDifference, bool adjustAclOverwrite, bool adjustAclIgnoreFolders, bool adjustAclIgnoreDocuments, bool adjustAclInBackground, bool checkRecursion, const ::std::wstring& oldParentId)
	: depth(depth)
	, manSortIdx(manSortIdx)
	, name(name)
	, adjustAclDifference(adjustAclDifference)
	, adjustAclOverwrite(adjustAclOverwrite)
	, adjustAclIgnoreFolders(adjustAclIgnoreFolders)
	, adjustAclIgnoreDocuments(adjustAclIgnoreDocuments)
	, adjustAclInBackground(adjustAclInBackground)
	, checkRecursion(checkRecursion)
	, oldParentId(oldParentId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CopyInfo::BSerializable_getTypeId() {
	return 2138439536; 
}
void CopyInfo::setDepth(int32_t v) {
	depth = v;
}
void CopyInfo::setManSortIdx(int32_t v) {
	manSortIdx = v;
}
void CopyInfo::setName(::std::wstring v) {
	name = v;
}
void CopyInfo::setAdjustAclDifference(bool v) {
	adjustAclDifference = v;
}
void CopyInfo::setAdjustAclOverwrite(bool v) {
	adjustAclOverwrite = v;
}
void CopyInfo::setAdjustAclIgnoreFolders(bool v) {
	adjustAclIgnoreFolders = v;
}
void CopyInfo::setAdjustAclIgnoreDocuments(bool v) {
	adjustAclIgnoreDocuments = v;
}
void CopyInfo::setAdjustAclInBackground(bool v) {
	adjustAclInBackground = v;
}
void CopyInfo::setCheckRecursion(bool v) {
	checkRecursion = v;
}
void CopyInfo::setOldParentId(::std::wstring v) {
	oldParentId = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CopyInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->depth;
	ar & this->manSortIdx;
	ar & this->name;
	if (version >= 700000020000010) {
		ar & this->adjustAclDifference;
		ar & this->adjustAclIgnoreDocuments;
		ar & this->adjustAclIgnoreFolders;
		ar & this->adjustAclInBackground;
		ar & this->adjustAclOverwrite;
		if (version >= 800000020000005) {
			ar & this->checkRecursion;
			if (version >= 800000030000001) {
				ar & this->oldParentId;
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2138439536(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CopyInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CopyOptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
CopyOptions::CopyOptions() {
	newParentId = 0;
	copyOnlyBaseElement = false;
	copyStructuresAndDocuments = false;
	copyOnlyWorkAttachment = false;
	keepOriginalOwner = false;
	keepCurrentNotes = false;
	inclAttachments = false;
	keepOriginalPermissions = false;
	takeTargetPermissions = false;
	acceptChanges = false;
	keepReferences = false;
	copyOnlyWorkversion = false;
	moveOnly = false;
	adjustAclDifference = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::CopyOptions::CopyOptions(const ::std::wstring& targetName, int32_t newParentId, bool copyOnlyBaseElement, bool copyStructuresAndDocuments, bool copyOnlyWorkAttachment, bool keepOriginalOwner, bool keepCurrentNotes, bool inclAttachments, bool keepOriginalPermissions, bool takeTargetPermissions, bool acceptChanges, bool keepReferences, bool copyOnlyWorkversion, bool moveOnly, bool adjustAclDifference)
	: targetName(targetName)
	, newParentId(newParentId)
	, copyOnlyBaseElement(copyOnlyBaseElement)
	, copyStructuresAndDocuments(copyStructuresAndDocuments)
	, copyOnlyWorkAttachment(copyOnlyWorkAttachment)
	, keepOriginalOwner(keepOriginalOwner)
	, keepCurrentNotes(keepCurrentNotes)
	, inclAttachments(inclAttachments)
	, keepOriginalPermissions(keepOriginalPermissions)
	, takeTargetPermissions(takeTargetPermissions)
	, acceptChanges(acceptChanges)
	, keepReferences(keepReferences)
	, copyOnlyWorkversion(copyOnlyWorkversion)
	, moveOnly(moveOnly)
	, adjustAclDifference(adjustAclDifference)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CopyOptions::BSerializable_getTypeId() {
	return 1427182574; 
}
void CopyOptions::setTargetName(::std::wstring v) {
	targetName = v;
}
void CopyOptions::setNewParentId(int32_t v) {
	newParentId = v;
}
void CopyOptions::setCopyOnlyBaseElement(bool v) {
	copyOnlyBaseElement = v;
}
void CopyOptions::setCopyStructuresAndDocuments(bool v) {
	copyStructuresAndDocuments = v;
}
void CopyOptions::setCopyOnlyWorkAttachment(bool v) {
	copyOnlyWorkAttachment = v;
}
void CopyOptions::setKeepOriginalOwner(bool v) {
	keepOriginalOwner = v;
}
void CopyOptions::setKeepCurrentNotes(bool v) {
	keepCurrentNotes = v;
}
void CopyOptions::setInclAttachments(bool v) {
	inclAttachments = v;
}
void CopyOptions::setKeepOriginalPermissions(bool v) {
	keepOriginalPermissions = v;
}
void CopyOptions::setTakeTargetPermissions(bool v) {
	takeTargetPermissions = v;
}
void CopyOptions::setAcceptChanges(bool v) {
	acceptChanges = v;
}
void CopyOptions::setKeepReferences(bool v) {
	keepReferences = v;
}
void CopyOptions::setCopyOnlyWorkversion(bool v) {
	copyOnlyWorkversion = v;
}
void CopyOptions::setMoveOnly(bool v) {
	moveOnly = v;
}
void CopyOptions::setAdjustAclDifference(bool v) {
	adjustAclDifference = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CopyOptions::serialize(BIO& ar, const BVERSION version) {
	ar & this->copyOnlyBaseElement;
	ar & this->copyStructuresAndDocuments;
	ar & this->keepCurrentNotes;
	ar & this->keepOriginalOwner;
	ar & this->newParentId;
	ar & this->targetName;
	if (version >= 800000000000004) {
		ar & this->keepReferences;
		if (version >= 800000032000003) {
			ar & this->copyOnlyWorkversion;
			if (version >= 800000032000005) {
				ar & this->acceptChanges;
				ar & this->keepOriginalPermissions;
				ar & this->takeTargetPermissions;
				if (version >= 800000032000008) {
					ar & this->copyOnlyWorkAttachment;
					ar & this->inclAttachments;
					if (version >= 900000000000006) {
						ar & this->adjustAclDifference;
						ar & this->moveOnly;
					}
				}
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1427182574(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CopyOptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CopyResult
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
CopyResult::CopyResult() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::CopyResult::CopyResult(const byps::PMapIntegerInteger& mapIdsSource2Copy, const byps::PMapStringString& mapGuidsSource2Copy)
	: mapIdsSource2Copy(mapIdsSource2Copy)
	, mapGuidsSource2Copy(mapGuidsSource2Copy)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CopyResult::BSerializable_getTypeId() {
	return 1904597264; 
}
void CopyResult::setMapIdsSource2Copy(byps::PMapIntegerInteger v) {
	mapIdsSource2Copy = v;
}
void CopyResult::setMapGuidsSource2Copy(byps::PMapStringString v) {
	mapGuidsSource2Copy = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CopyResult::serialize(BIO& ar, const BVERSION version) {
	ar & this->mapGuidsSource2Copy;
	ar & this->mapIdsSource2Copy;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1904597264(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CopyResult>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CopySordC
// Generated from class byps.gen.cpp.GenApiClass

const PCopySordZ CopySordC::COPY = PCopySordZ(new CopySordZ(
	4LL));

const PCopySordZ CopySordC::MOVE = PCopySordZ(new CopySordZ(
	1LL));

const PCopySordZ CopySordC::REFERENCE = PCopySordZ(new CopySordZ(
	2LL));

// checkpoint byps.gen.cpp.GenApiClass:489
CopySordC::CopySordC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CopySordC::BSerializable_getTypeId() {
	return 1616091412; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CopySordC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1616091412(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CopySordC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CopySordZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
CopySordZ::CopySordZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::CopySordZ::CopySordZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CopySordZ::BSerializable_getTypeId() {
	return 2059126408; 
}
void CopySordZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CopySordZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2059126408(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CopySordZ>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class CountResult
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
CountResult::CountResult() {
	docCount = 0;
	structCount = 0;
	docAttachCount = 0;
	docVersionsCount = 0;
	otherAttachVersionsCount = 0;
	docBytesCount = 0;
	otherDocVersBytesCount = 0;
	attBytesCount = 0;
	otherAttVersBytesCount = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::CountResult::CountResult(int32_t docCount, int32_t structCount, int32_t docAttachCount, int32_t docVersionsCount, int32_t otherAttachVersionsCount, int64_t docBytesCount, int64_t otherDocVersBytesCount, int64_t attBytesCount, int64_t otherAttVersBytesCount)
	: docCount(docCount)
	, structCount(structCount)
	, docAttachCount(docAttachCount)
	, docVersionsCount(docVersionsCount)
	, otherAttachVersionsCount(otherAttachVersionsCount)
	, docBytesCount(docBytesCount)
	, otherDocVersBytesCount(otherDocVersBytesCount)
	, attBytesCount(attBytesCount)
	, otherAttVersBytesCount(otherAttVersBytesCount)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::CountResult::BSerializable_getTypeId() {
	return 1581335066; 
}
void CountResult::setDocCount(int32_t v) {
	docCount = v;
}
void CountResult::setStructCount(int32_t v) {
	structCount = v;
}
void CountResult::setDocAttachCount(int32_t v) {
	docAttachCount = v;
}
void CountResult::setDocVersionsCount(int32_t v) {
	docVersionsCount = v;
}
void CountResult::setOtherAttachVersionsCount(int32_t v) {
	otherAttachVersionsCount = v;
}
void CountResult::setDocBytesCount(int64_t v) {
	docBytesCount = v;
}
void CountResult::setOtherDocVersBytesCount(int64_t v) {
	otherDocVersBytesCount = v;
}
void CountResult::setAttBytesCount(int64_t v) {
	attBytesCount = v;
}
void CountResult::setOtherAttVersBytesCount(int64_t v) {
	otherAttVersBytesCount = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void CountResult::serialize(BIO& ar, const BVERSION version) {
	ar & this->attBytesCount;
	ar & this->docAttachCount;
	ar & this->docBytesCount;
	ar & this->docCount;
	ar & this->docVersionsCount;
	ar & this->structCount;
	if (version >= 700000000000002) {
		ar & this->otherAttVersBytesCount;
		ar & this->otherAttachVersionsCount;
		ar & this->otherDocVersBytesCount;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1581335066(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::CountResult>(bio, pObj, pObjS, pBase);	
}
}}}}
