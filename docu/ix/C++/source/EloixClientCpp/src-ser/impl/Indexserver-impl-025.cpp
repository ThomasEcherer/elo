#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ObjChangeC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ObjChangeC::ObjChangeC() {
	lnObjId = 0;
	lnTStamp = 0;
	lnParam2 = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ObjChangeC::ObjChangeC(int64_t mbObjId, int32_t lnObjId, int64_t mbTStamp, int32_t lnTStamp, int64_t mbCode, int64_t mbParam, int64_t mbParam2, int32_t lnParam2, int64_t mbUser, int64_t mbAllMembers)
	: lnObjId(lnObjId)
	, lnTStamp(lnTStamp)
	, lnParam2(lnParam2)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ObjChangeC::BSerializable_getTypeId() {
	return 1100272528; 
}
void ObjChangeC::setLnObjId(int32_t v) {
	lnObjId = v;
}
void ObjChangeC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
void ObjChangeC::setLnParam2(int32_t v) {
	lnParam2 = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ObjChangeC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnObjId;
	ar & this->lnParam2;
	ar & this->lnTStamp;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1100272528(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ObjChangeC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ObjDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ObjDataC::ObjDataC() {
	lnGuid = 0;
	lnName = 0;
	lnSReg = 0;
	lnInternalDesc = 0;
	lnAcl = 0;
	lnTStamp = 0;
	lnSName = 0;
	lnSDesc = 0;
	lnTStampSync = 0;
	lnTStampAcl = 0;
	lnTStampAclSync = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ObjDataC::ObjDataC(int64_t mbId, int64_t mbGuid, int32_t lnGuid, int64_t mbParentId, int64_t mbType, int64_t mbFlags, int64_t mbName, int32_t lnName, int64_t mbSReg, int32_t lnSReg, int64_t mbIDate, int64_t mbXDate, int64_t mbKey, int64_t mbKind, int64_t mbPath, int64_t mbInfo, int64_t mbMask, int64_t mbDoc, int64_t mbSig, int64_t mbAtt, int64_t mbOwnerId, int64_t mbLockId, int64_t mbStatus, int64_t mbHistCount, int64_t mbInternalDesc, int32_t lnInternalDesc, int64_t mbChildCount, int64_t mbDelDate, int64_t mbSyncDateLoc, int64_t mbSyncDateRem, int64_t mbVtRep, int64_t mbAcl, int32_t lnAcl, int64_t mbTStamp, int32_t lnTStamp, int64_t mbSName, int32_t lnSName, int64_t mbSDesc, int32_t lnSDesc, int64_t mbDeleteDate, int64_t mbLockIdSord, int64_t mbLockIdDoc, int64_t mbTStampSync, int32_t lnTStampSync, int64_t mbTStampAcl, int32_t lnTStampAcl, int64_t mbTStampAclSync, int32_t lnTStampAclSync, int64_t mbDeleteUser, int64_t mbAllMembers)
	: lnGuid(lnGuid)
	, lnName(lnName)
	, lnSReg(lnSReg)
	, lnInternalDesc(lnInternalDesc)
	, lnAcl(lnAcl)
	, lnTStamp(lnTStamp)
	, lnSName(lnSName)
	, lnSDesc(lnSDesc)
	, lnTStampSync(lnTStampSync)
	, lnTStampAcl(lnTStampAcl)
	, lnTStampAclSync(lnTStampAclSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ObjDataC::BSerializable_getTypeId() {
	return 1521332903; 
}
void ObjDataC::setLnGuid(int32_t v) {
	lnGuid = v;
}
void ObjDataC::setLnName(int32_t v) {
	lnName = v;
}
void ObjDataC::setLnSReg(int32_t v) {
	lnSReg = v;
}
void ObjDataC::setLnInternalDesc(int32_t v) {
	lnInternalDesc = v;
}
void ObjDataC::setLnAcl(int32_t v) {
	lnAcl = v;
}
void ObjDataC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
void ObjDataC::setLnSName(int32_t v) {
	lnSName = v;
}
void ObjDataC::setLnSDesc(int32_t v) {
	lnSDesc = v;
}
void ObjDataC::setLnTStampSync(int32_t v) {
	lnTStampSync = v;
}
void ObjDataC::setLnTStampAcl(int32_t v) {
	lnTStampAcl = v;
}
void ObjDataC::setLnTStampAclSync(int32_t v) {
	lnTStampAclSync = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ObjDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnAcl;
	ar & this->lnGuid;
	ar & this->lnInternalDesc;
	ar & this->lnName;
	ar & this->lnSDesc;
	ar & this->lnSName;
	ar & this->lnSReg;
	ar & this->lnTStamp;
	if (version >= 900990009000001) {
		ar & this->lnTStampAcl;
		ar & this->lnTStampAclSync;
		ar & this->lnTStampSync;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1521332903(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ObjDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ObjHistC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ObjHistC::ObjHistC() {
	lnHistGuid = 0;
	lnTimeStampUTC = 0;
	lnObjGuid = 0;
	lnUserName = 0;
	lnTimeStampLocal = 0;
	lnWorkStation = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ObjHistC::ObjHistC(int64_t mbHistGuid, int32_t lnHistGuid, int64_t mbTimeStampUTC, int32_t lnTimeStampUTC, int64_t mbObjGuid, int32_t lnObjGuid, int64_t mbUserNo, int64_t mbUserName, int32_t lnUserName, int64_t mbHistSource, int64_t mbTimeStampLocal, int32_t lnTimeStampLocal, int64_t mbWorkStation, int32_t lnWorkStation, int64_t mbAllMembers)
	: lnHistGuid(lnHistGuid)
	, lnTimeStampUTC(lnTimeStampUTC)
	, lnObjGuid(lnObjGuid)
	, lnUserName(lnUserName)
	, lnTimeStampLocal(lnTimeStampLocal)
	, lnWorkStation(lnWorkStation)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ObjHistC::BSerializable_getTypeId() {
	return 1015803641; 
}
void ObjHistC::setLnHistGuid(int32_t v) {
	lnHistGuid = v;
}
void ObjHistC::setLnTimeStampUTC(int32_t v) {
	lnTimeStampUTC = v;
}
void ObjHistC::setLnObjGuid(int32_t v) {
	lnObjGuid = v;
}
void ObjHistC::setLnUserName(int32_t v) {
	lnUserName = v;
}
void ObjHistC::setLnTimeStampLocal(int32_t v) {
	lnTimeStampLocal = v;
}
void ObjHistC::setLnWorkStation(int32_t v) {
	lnWorkStation = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ObjHistC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnHistGuid;
	ar & this->lnObjGuid;
	ar & this->lnTimeStampLocal;
	ar & this->lnTimeStampUTC;
	ar & this->lnUserName;
	ar & this->lnWorkStation;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1015803641(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ObjHistC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ObjHistKeyC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ObjHistKeyC::ObjHistKeyC() {
	lnHistGuid = 0;
	lnKeyName = 0;
	lnKeyData = 0;
	lnKeyDataDesc = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ObjHistKeyC::ObjHistKeyC(int64_t mbHistGuid, int32_t lnHistGuid, int64_t mbKeyNo, int64_t mbKeyName, int32_t lnKeyName, int64_t mbKeyData, int32_t lnKeyData, int64_t mbKeyDataDesc, int32_t lnKeyDataDesc, int64_t mbAllMembers)
	: lnHistGuid(lnHistGuid)
	, lnKeyName(lnKeyName)
	, lnKeyData(lnKeyData)
	, lnKeyDataDesc(lnKeyDataDesc)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ObjHistKeyC::BSerializable_getTypeId() {
	return 1013854536; 
}
void ObjHistKeyC::setLnHistGuid(int32_t v) {
	lnHistGuid = v;
}
void ObjHistKeyC::setLnKeyName(int32_t v) {
	lnKeyName = v;
}
void ObjHistKeyC::setLnKeyData(int32_t v) {
	lnKeyData = v;
}
void ObjHistKeyC::setLnKeyDataDesc(int32_t v) {
	lnKeyDataDesc = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ObjHistKeyC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnHistGuid;
	ar & this->lnKeyData;
	ar & this->lnKeyName;
	if (version >= 700000000000018) {
		ar & this->lnKeyDataDesc;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1013854536(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ObjHistKeyC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ObjKey
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ObjKey::ObjKey() {
	id = 0;
	objId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ObjKey::ObjKey(const PArrayString& data, int32_t id, const ::std::wstring& name, int32_t objId)
	: data(data)
	, id(id)
	, name(name)
	, objId(objId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ObjKey::BSerializable_getTypeId() {
	return 237417996; 
}
void ObjKey::setData(PArrayString v) {
	data = v;
	setChangedMember(ObjKeyC::mbData);
}
void ObjKey::setId(int32_t v) {
	id = v;
	setChangedMember(ObjKeyC::mbId);
}
void ObjKey::setName(::std::wstring v) {
	name = v;
	setChangedMember(ObjKeyC::mbName);
}
void ObjKey::setObjId(int32_t v) {
	objId = v;
	setChangedMember(ObjKeyC::mbObjId);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ObjKey::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->id;
	ar & this->name;
	ar & this->objId;
	ar & this->data;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_237417996(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ObjKey>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ObjKeyDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ObjKeyDataC::ObjKeyDataC() {
	lnName = 0;
	lnData = 0;
	lnUdata = 0;
	lnSdata = 0;
	lnOdouble = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ObjKeyDataC::ObjKeyDataC(int64_t mbObjId, int64_t mbId, int64_t mbName, int32_t lnName, int64_t mbData, int32_t lnData, int64_t mbUdata, int32_t lnUdata, int64_t mbSdata, int32_t lnSdata, int64_t mbOdouble, int32_t lnOdouble, int64_t mbAllMembers)
	: lnName(lnName)
	, lnData(lnData)
	, lnUdata(lnUdata)
	, lnSdata(lnSdata)
	, lnOdouble(lnOdouble)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ObjKeyDataC::BSerializable_getTypeId() {
	return 2463451; 
}
void ObjKeyDataC::setLnName(int32_t v) {
	lnName = v;
}
void ObjKeyDataC::setLnData(int32_t v) {
	lnData = v;
}
void ObjKeyDataC::setLnUdata(int32_t v) {
	lnUdata = v;
}
void ObjKeyDataC::setLnSdata(int32_t v) {
	lnSdata = v;
}
void ObjKeyDataC::setLnOdouble(int32_t v) {
	lnOdouble = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ObjKeyDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnData;
	ar & this->lnName;
	ar & this->lnSdata;
	ar & this->lnUdata;
	if (version >= 900000000000021) {
		ar & this->lnOdouble;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2463451(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ObjKeyDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ObjKeyC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ObjKeyC::ObjKeyC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ObjKeyC::BSerializable_getTypeId() {
	return 711473895; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ObjKeyC::serialize(BIO& ar, const BVERSION version) {
	ObjKeyDataC::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_711473895(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ObjKeyC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ObjKeyData
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ObjKeyData::ObjKeyData() {
	objId = 0;
	id = 0;
	odouble = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ObjKeyData::ObjKeyData(int32_t objId, int32_t id, const ::std::wstring& name, const ::std::wstring& data, const ::std::wstring& udata, const ::std::wstring& sdata, double odouble)
	: objId(objId)
	, id(id)
	, name(name)
	, data(data)
	, udata(udata)
	, sdata(sdata)
	, odouble(odouble)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ObjKeyData::BSerializable_getTypeId() {
	return 1508164560; 
}
void ObjKeyData::setObjId(int32_t v) {
	objId = v;
	setChangedMember(ObjKeyDataC::mbObjId);
}
void ObjKeyData::setId(int32_t v) {
	id = v;
	setChangedMember(ObjKeyDataC::mbId);
}
void ObjKeyData::setName(::std::wstring v) {
	name = v;
	setChangedMember(ObjKeyDataC::mbName);
}
void ObjKeyData::setData(::std::wstring v) {
	data = v;
	setChangedMember(ObjKeyDataC::mbData);
}
void ObjKeyData::setUdata(::std::wstring v) {
	udata = v;
	setChangedMember(ObjKeyDataC::mbUdata);
}
void ObjKeyData::setSdata(::std::wstring v) {
	sdata = v;
	setChangedMember(ObjKeyDataC::mbSdata);
}
void ObjKeyData::setOdouble(double v) {
	odouble = v;
	setChangedMember(ObjKeyDataC::mbOdouble);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ObjKeyData::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->data;
	ar & this->id;
	ar & this->name;
	ar & this->objId;
	ar & this->sdata;
	ar & this->udata;
	if (version >= 900000000000021) {
		ar & this->odouble;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1508164560(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ObjKeyData>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1628260993(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PObjKey > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ObjLinkC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ObjLinkC::ObjLinkC() {
	lnParentId = 0;
	lnId = 0;
	lnLinkId = 0;
	lnTStamp = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ObjLinkC::ObjLinkC(int64_t mbParentId, int32_t lnParentId, int64_t mbId, int32_t lnId, int64_t mbLinkId, int32_t lnLinkId, int64_t mbTStamp, int32_t lnTStamp, int64_t mbFlags, int64_t mbAllMembers)
	: lnParentId(lnParentId)
	, lnId(lnId)
	, lnLinkId(lnLinkId)
	, lnTStamp(lnTStamp)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ObjLinkC::BSerializable_getTypeId() {
	return 1015668161; 
}
void ObjLinkC::setLnParentId(int32_t v) {
	lnParentId = v;
}
void ObjLinkC::setLnId(int32_t v) {
	lnId = v;
}
void ObjLinkC::setLnLinkId(int32_t v) {
	lnLinkId = v;
}
void ObjLinkC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ObjLinkC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnId;
	ar & this->lnLinkId;
	ar & this->lnParentId;
	ar & this->lnTStamp;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1015668161(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ObjLinkC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class OcrInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
OcrInfo::OcrInfo() {
	busId = 0;
	eventId = 0;
	messagesLanguage = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::OcrInfo::OcrInfo(int64_t busId, int64_t eventId, int32_t messagesLanguage, const POcrInfoRecognizeFile& recognizeFile, const POcrInfoQueryLanguages& queryLanguages)
	: busId(busId)
	, eventId(eventId)
	, messagesLanguage(messagesLanguage)
	, recognizeFile(recognizeFile)
	, queryLanguages(queryLanguages)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::OcrInfo::BSerializable_getTypeId() {
	return 1803060225; 
}
void OcrInfo::setBusId(int64_t v) {
	busId = v;
}
void OcrInfo::setEventId(int64_t v) {
	eventId = v;
}
void OcrInfo::setMessagesLanguage(int32_t v) {
	messagesLanguage = v;
}
void OcrInfo::setRecognizeFile(POcrInfoRecognizeFile v) {
	recognizeFile = v;
}
void OcrInfo::setQueryLanguages(POcrInfoQueryLanguages v) {
	queryLanguages = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void OcrInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->busId;
	ar & this->eventId;
	ar & this->messagesLanguage;
	ar & this->queryLanguages;
	ar & this->recognizeFile;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1803060225(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::OcrInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class OcrInfoC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
OcrInfoC::OcrInfoC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::OcrInfoC::BSerializable_getTypeId() {
	return 1068350778; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void OcrInfoC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1068350778(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::OcrInfoC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class OcrInfoQueryLanguages
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
OcrInfoQueryLanguages::OcrInfoQueryLanguages() {
	ctrl = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::OcrInfoQueryLanguages::OcrInfoQueryLanguages(int32_t ctrl)
	: ctrl(ctrl)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::OcrInfoQueryLanguages::BSerializable_getTypeId() {
	return 648095775; 
}
void OcrInfoQueryLanguages::setCtrl(int32_t v) {
	ctrl = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void OcrInfoQueryLanguages::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->ctrl;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_648095775(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::OcrInfoQueryLanguages>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class OcrInfoRecognizeFile
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
OcrInfoRecognizeFile::OcrInfoRecognizeFile() {
	pageNo = 0;
	rectUnit = 0;
	timeoutSeconds = 0;
	pageTimeout = 0;
	minCharConfidence = 0;
	replaceChar = 0;
	accuracy = 0;
	singleColumnMode = false;
	spaces = 0;
	encoding = 0;
	outputFormat = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::OcrInfoRecognizeFile::OcrInfoRecognizeFile(const PFileData& imageData, const ::std::wstring& objId, int32_t pageNo, const PArrayInt& pageNumbers, const PArrayString& recognizeLangs, const PArrayOcrRect& recognizeRects, int32_t rectUnit, int32_t timeoutSeconds, int32_t pageTimeout, int32_t minCharConfidence, int32_t replaceChar, int32_t accuracy, bool singleColumnMode, int32_t spaces, int32_t encoding, int32_t outputFormat)
	: imageData(imageData)
	, objId(objId)
	, pageNo(pageNo)
	, pageNumbers(pageNumbers)
	, recognizeLangs(recognizeLangs)
	, recognizeRects(recognizeRects)
	, rectUnit(rectUnit)
	, timeoutSeconds(timeoutSeconds)
	, pageTimeout(pageTimeout)
	, minCharConfidence(minCharConfidence)
	, replaceChar(replaceChar)
	, accuracy(accuracy)
	, singleColumnMode(singleColumnMode)
	, spaces(spaces)
	, encoding(encoding)
	, outputFormat(outputFormat)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::OcrInfoRecognizeFile::BSerializable_getTypeId() {
	return 701419851; 
}
void OcrInfoRecognizeFile::setImageData(PFileData v) {
	imageData = v;
}
void OcrInfoRecognizeFile::setObjId(::std::wstring v) {
	objId = v;
}
void OcrInfoRecognizeFile::setPageNo(int32_t v) {
	pageNo = v;
}
void OcrInfoRecognizeFile::setPageNumbers(PArrayInt v) {
	pageNumbers = v;
}
void OcrInfoRecognizeFile::setRecognizeLangs(PArrayString v) {
	recognizeLangs = v;
}
void OcrInfoRecognizeFile::setRecognizeRects(PArrayOcrRect v) {
	recognizeRects = v;
}
void OcrInfoRecognizeFile::setRectUnit(int32_t v) {
	rectUnit = v;
}
void OcrInfoRecognizeFile::setTimeoutSeconds(int32_t v) {
	timeoutSeconds = v;
}
void OcrInfoRecognizeFile::setPageTimeout(int32_t v) {
	pageTimeout = v;
}
void OcrInfoRecognizeFile::setMinCharConfidence(int32_t v) {
	minCharConfidence = v;
}
void OcrInfoRecognizeFile::setReplaceChar(int32_t v) {
	replaceChar = v;
}
void OcrInfoRecognizeFile::setAccuracy(int32_t v) {
	accuracy = v;
}
void OcrInfoRecognizeFile::setSingleColumnMode(bool v) {
	singleColumnMode = v;
}
void OcrInfoRecognizeFile::setSpaces(int32_t v) {
	spaces = v;
}
void OcrInfoRecognizeFile::setEncoding(int32_t v) {
	encoding = v;
}
void OcrInfoRecognizeFile::setOutputFormat(int32_t v) {
	outputFormat = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void OcrInfoRecognizeFile::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->accuracy;
	ar & this->minCharConfidence;
	ar & this->objId;
	ar & this->outputFormat;
	ar & this->pageNo;
	ar & this->rectUnit;
	ar & this->replaceChar;
	ar & this->singleColumnMode;
	ar & this->timeoutSeconds;
	if (version >= 900000030000028) {
		ar & this->pageTimeout;
		if (version >= 1000170069000001) {
			ar & this->spaces;
			if (version >= 1000170080000003) {
				ar & this->encoding;
			}
		}
	}
	ar & this->imageData;
	ar & this->recognizeLangs;
	ar & this->recognizeRects;
	if (version >= 900000030000027) {
		ar & this->pageNumbers;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_701419851(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::OcrInfoRecognizeFile>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class OcrRect
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
OcrRect::OcrRect() {
	left = 0;
	top = 0;
	right = 0;
	bottom = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::OcrRect::OcrRect(int32_t left, int32_t top, int32_t right, int32_t bottom)
	: left(left)
	, top(top)
	, right(right)
	, bottom(bottom)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::OcrRect::BSerializable_getTypeId() {
	return 1044855049; 
}
void OcrRect::setLeft(int32_t v) {
	left = v;
}
void OcrRect::setTop(int32_t v) {
	top = v;
}
void OcrRect::setRight(int32_t v) {
	right = v;
}
void OcrRect::setBottom(int32_t v) {
	bottom = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void OcrRect::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bottom;
	ar & this->left;
	ar & this->right;
	ar & this->top;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1044855049(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::OcrRect>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_610838867(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::POcrRect > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class OcrResult
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
OcrResult::OcrResult() {
	eventId = 0;
	exceptionID = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::OcrResult::OcrResult(int64_t eventId, const ::std::wstring& exception, int32_t exceptionID, const POcrResultRecognizeFile& recognizeFile, const POcrResultQueryLanguages& queryLanguages)
	: eventId(eventId)
	, exception(exception)
	, exceptionID(exceptionID)
	, recognizeFile(recognizeFile)
	, queryLanguages(queryLanguages)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::OcrResult::BSerializable_getTypeId() {
	return 998509414; 
}
void OcrResult::setEventId(int64_t v) {
	eventId = v;
}
void OcrResult::setException(::std::wstring v) {
	exception = v;
}
void OcrResult::setExceptionID(int32_t v) {
	exceptionID = v;
}
void OcrResult::setRecognizeFile(POcrResultRecognizeFile v) {
	recognizeFile = v;
}
void OcrResult::setQueryLanguages(POcrResultQueryLanguages v) {
	queryLanguages = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void OcrResult::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->eventId;
	ar & this->exception;
	if (version >= 900000040000004) {
		ar & this->exceptionID;
	}
	ar & this->queryLanguages;
	ar & this->recognizeFile;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_998509414(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::OcrResult>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class OcrResultQueryLanguages
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
OcrResultQueryLanguages::OcrResultQueryLanguages() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::OcrResultQueryLanguages::OcrResultQueryLanguages(const PArrayString& externalLangs, const PArrayString& internalLangs)
	: externalLangs(externalLangs)
	, internalLangs(internalLangs)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::OcrResultQueryLanguages::BSerializable_getTypeId() {
	return 916614291; 
}
void OcrResultQueryLanguages::setExternalLangs(PArrayString v) {
	externalLangs = v;
}
void OcrResultQueryLanguages::setInternalLangs(PArrayString v) {
	internalLangs = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void OcrResultQueryLanguages::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->externalLangs;
	ar & this->internalLangs;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_916614291(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::OcrResultQueryLanguages>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class OcrResultRecognizeFile
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
OcrResultRecognizeFile::OcrResultRecognizeFile() {
	skewAngle = 0;
	width = 0;
	height = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::OcrResultRecognizeFile::OcrResultRecognizeFile(const PFileData& textData, const ::std::wstring& text, double skewAngle, int32_t width, int32_t height)
	: textData(textData)
	, text(text)
	, skewAngle(skewAngle)
	, width(width)
	, height(height)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::OcrResultRecognizeFile::BSerializable_getTypeId() {
	return 1533562699; 
}
void OcrResultRecognizeFile::setTextData(PFileData v) {
	textData = v;
}
void OcrResultRecognizeFile::setText(::std::wstring v) {
	text = v;
}
void OcrResultRecognizeFile::setSkewAngle(double v) {
	skewAngle = v;
}
void OcrResultRecognizeFile::setWidth(int32_t v) {
	width = v;
}
void OcrResultRecognizeFile::setHeight(int32_t v) {
	height = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void OcrResultRecognizeFile::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->height;
	ar & this->skewAngle;
	ar & this->text;
	ar & this->width;
	ar & this->textData;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1533562699(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::OcrResultRecognizeFile>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class OcrWorker
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
OcrWorker::OcrWorker() {
	busId = 0;
	subsId = 0;
	state = 0;
	lastUsed = 0;
	reserved = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::OcrWorker::OcrWorker(int64_t busId, int64_t subsId, int32_t state, int64_t lastUsed, int64_t reserved)
	: busId(busId)
	, subsId(subsId)
	, state(state)
	, lastUsed(lastUsed)
	, reserved(reserved)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::OcrWorker::BSerializable_getTypeId() {
	return 730157667; 
}
void OcrWorker::setBusId(int64_t v) {
	busId = v;
}
void OcrWorker::setSubsId(int64_t v) {
	subsId = v;
}
void OcrWorker::setState(int32_t v) {
	state = v;
}
void OcrWorker::setLastUsed(int64_t v) {
	lastUsed = v;
}
void OcrWorker::setReserved(int64_t v) {
	reserved = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void OcrWorker::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->busId;
	ar & this->lastUsed;
	ar & this->state;
	ar & this->subsId;
	if (version >= 1000170010000006) {
		ar & this->reserved;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_730157667(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::OcrWorker>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class OcrWorkerC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
OcrWorkerC::OcrWorkerC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::OcrWorkerC::BSerializable_getTypeId() {
	return 45899817; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void OcrWorkerC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_45899817(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::OcrWorkerC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class OrgUnitInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
OrgUnitInfo::OrgUnitInfo() {
	id = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::OrgUnitInfo::OrgUnitInfo(int32_t id, const ::std::wstring& name, const ::std::wstring& desc, const PArrayString& ouProps, const ::std::wstring& tStamp, const ::std::wstring& guid)
	: id(id)
	, name(name)
	, desc(desc)
	, ouProps(ouProps)
	, tStamp(tStamp)
	, guid(guid)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::OrgUnitInfo::BSerializable_getTypeId() {
	return 413918850; 
}
void OrgUnitInfo::setId(int32_t v) {
	id = v;
}
void OrgUnitInfo::setName(::std::wstring v) {
	name = v;
}
void OrgUnitInfo::setDesc(::std::wstring v) {
	desc = v;
}
void OrgUnitInfo::setOuProps(PArrayString v) {
	ouProps = v;
}
void OrgUnitInfo::setTStamp(::std::wstring v) {
	tStamp = v;
}
void OrgUnitInfo::setGuid(::std::wstring v) {
	guid = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void OrgUnitInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->desc;
	ar & this->guid;
	ar & this->id;
	ar & this->name;
	ar & this->tStamp;
	ar & this->ouProps;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_413918850(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::OrgUnitInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class OrgUnitInfoC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
OrgUnitInfoC::OrgUnitInfoC() {
	lnName = 0;
	lnDesc = 0;
	lnOuProp = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::OrgUnitInfoC::OrgUnitInfoC(int32_t MAX_OU_PROP, int32_t MAX_ORG_UNITS, int32_t lnName, int32_t lnDesc, int32_t lnOuProp)
	: lnName(lnName)
	, lnDesc(lnDesc)
	, lnOuProp(lnOuProp)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::OrgUnitInfoC::BSerializable_getTypeId() {
	return 864257789; 
}
void OrgUnitInfoC::setLnName(int32_t v) {
	lnName = v;
}
void OrgUnitInfoC::setLnDesc(int32_t v) {
	lnDesc = v;
}
void OrgUnitInfoC::setLnOuProp(int32_t v) {
	lnOuProp = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void OrgUnitInfoC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnDesc;
	ar & this->lnName;
	ar & this->lnOuProp;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_864257789(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::OrgUnitInfoC>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1879760993(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::POrgUnitInfo > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class OrgUnitName
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
OrgUnitName::OrgUnitName() {
	id = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::OrgUnitName::OrgUnitName(int32_t id, const ::std::wstring& name)
	: id(id)
	, name(name)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::OrgUnitName::BSerializable_getTypeId() {
	return 427676481; 
}
void OrgUnitName::setId(int32_t v) {
	id = v;
}
void OrgUnitName::setName(::std::wstring v) {
	name = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void OrgUnitName::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->id;
	ar & this->name;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_427676481(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::OrgUnitName>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class PhysDel
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
PhysDel::PhysDel() {
	type = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::PhysDel::PhysDel(const ::std::wstring& guid, int32_t type, const ::std::wstring& TStamp, const ::std::wstring& TStampSync)
	: guid(guid)
	, type(type)
	, TStamp(TStamp)
	, TStampSync(TStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::PhysDel::BSerializable_getTypeId() {
	return 124345500; 
}
void PhysDel::setGuid(::std::wstring v) {
	guid = v;
	setChangedMember(PhysDelC::mbGuid);
}
void PhysDel::setType(int32_t v) {
	type = v;
	setChangedMember(PhysDelC::mbType);
}
void PhysDel::setTStamp(::std::wstring v) {
	TStamp = v;
	setChangedMember(PhysDelC::mbTStamp);
}
void PhysDel::setTStampSync(::std::wstring v) {
	TStampSync = v;
	setChangedMember(PhysDelC::mbTStampSync);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void PhysDel::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->TStamp;
	ar & this->guid;
	ar & this->type;
	if (version >= 900990009000001) {
		ar & this->TStampSync;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_124345500(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::PhysDel>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class PhysDelDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
PhysDelDataC::PhysDelDataC() {
	lnGuid = 0;
	lnTStamp = 0;
	lnTStampSync = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::PhysDelDataC::PhysDelDataC(int64_t mbGuid, int32_t lnGuid, int64_t mbType, int64_t mbTStamp, int32_t lnTStamp, int64_t mbTStampSync, int32_t lnTStampSync, int64_t mbAllMembers)
	: lnGuid(lnGuid)
	, lnTStamp(lnTStamp)
	, lnTStampSync(lnTStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::PhysDelDataC::BSerializable_getTypeId() {
	return 448931954; 
}
void PhysDelDataC::setLnGuid(int32_t v) {
	lnGuid = v;
}
void PhysDelDataC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
void PhysDelDataC::setLnTStampSync(int32_t v) {
	lnTStampSync = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void PhysDelDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnGuid;
	ar & this->lnTStamp;
	if (version >= 900990009000001) {
		ar & this->lnTStampSync;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_448931954(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::PhysDelDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class PhysDelC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
PhysDelC::PhysDelC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::PhysDelC::BSerializable_getTypeId() {
	return 278631137; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void PhysDelC::serialize(BIO& ar, const BVERSION version) {
	PhysDelDataC::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_278631137(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::PhysDelC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class PhysDelDocs
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
PhysDelDocs::PhysDelDocs() {
	objId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::PhysDelDocs::PhysDelDocs(int32_t objId)
	: objId(objId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::PhysDelDocs::BSerializable_getTypeId() {
	return 855528761; 
}
void PhysDelDocs::setObjId(int32_t v) {
	objId = v;
	setChangedMember(PhysDelDocsC::mbObjId);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void PhysDelDocs::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->objId;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_855528761(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::PhysDelDocs>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class PhysDelDocsC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
PhysDelDocsC::PhysDelDocsC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::PhysDelDocsC::BSerializable_getTypeId() {
	return 434896477; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void PhysDelDocsC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_434896477(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::PhysDelDocsC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class PointInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
PointInfo::PointInfo() {
	x = 0;
	y = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::PointInfo::PointInfo(int32_t x, int32_t y)
	: x(x)
	, y(y)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::PointInfo::BSerializable_getTypeId() {
	return 1225068828; 
}
void PointInfo::setX(int32_t v) {
	x = v;
}
void PointInfo::setY(int32_t v) {
	y = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void PointInfo::serialize(BIO& ar, const BVERSION version) {
	ar & this->x;
	ar & this->y;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1225068828(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::PointInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1853594537(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PPointInfo > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class PreviewImageInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
PreviewImageInfo::PreviewImageInfo() {
	startPage = 0;
	endPage = 0;
	previewSize = 0;
	processDocument = false;
	renderAnnotations = false;
	renderAnnotationsOnly = false;
	renderAnnotationsData = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::PreviewImageInfo::PreviewImageInfo(const ::std::wstring& objectId, const ::std::wstring& documentId, int32_t startPage, int32_t endPage, int32_t previewSize, bool processDocument, bool renderAnnotations, bool renderAnnotationsOnly, bool renderAnnotationsData)
	: objectId(objectId)
	, documentId(documentId)
	, startPage(startPage)
	, endPage(endPage)
	, previewSize(previewSize)
	, processDocument(processDocument)
	, renderAnnotations(renderAnnotations)
	, renderAnnotationsOnly(renderAnnotationsOnly)
	, renderAnnotationsData(renderAnnotationsData)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::PreviewImageInfo::BSerializable_getTypeId() {
	return 1006046685; 
}
void PreviewImageInfo::setObjectId(::std::wstring v) {
	objectId = v;
}
void PreviewImageInfo::setDocumentId(::std::wstring v) {
	documentId = v;
}
void PreviewImageInfo::setStartPage(int32_t v) {
	startPage = v;
}
void PreviewImageInfo::setEndPage(int32_t v) {
	endPage = v;
}
void PreviewImageInfo::setPreviewSize(int32_t v) {
	previewSize = v;
}
void PreviewImageInfo::setProcessDocument(bool v) {
	processDocument = v;
}
void PreviewImageInfo::setRenderAnnotations(bool v) {
	renderAnnotations = v;
}
void PreviewImageInfo::setRenderAnnotationsOnly(bool v) {
	renderAnnotationsOnly = v;
}
void PreviewImageInfo::setRenderAnnotationsData(bool v) {
	renderAnnotationsData = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void PreviewImageInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->documentId;
	ar & this->endPage;
	ar & this->objectId;
	ar & this->previewSize;
	ar & this->processDocument;
	ar & this->renderAnnotations;
	ar & this->renderAnnotationsData;
	ar & this->renderAnnotationsOnly;
	ar & this->startPage;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1006046685(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::PreviewImageInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class PreviewImageInfoC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
PreviewImageInfoC::PreviewImageInfoC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::PreviewImageInfoC::BSerializable_getTypeId() {
	return 407268655; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void PreviewImageInfoC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_407268655(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::PreviewImageInfoC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class PreviewImageResult
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
PreviewImageResult::PreviewImageResult() {
	dpi = 0;
	dimensionWidth = 0;
	dimensionHeight = 0;
	progress = 0;
	progressMax = 0;
	pages = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::PreviewImageResult::PreviewImageResult(const byps::PVectorString& urls, int32_t dpi, int32_t dimensionWidth, int32_t dimensionHeight, int32_t progress, int32_t progressMax, const ::std::wstring& statusMessage, int32_t pages)
	: urls(urls)
	, dpi(dpi)
	, dimensionWidth(dimensionWidth)
	, dimensionHeight(dimensionHeight)
	, progress(progress)
	, progressMax(progressMax)
	, statusMessage(statusMessage)
	, pages(pages)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::PreviewImageResult::BSerializable_getTypeId() {
	return 661820173; 
}
void PreviewImageResult::setUrls(byps::PVectorString v) {
	urls = v;
}
void PreviewImageResult::setDpi(int32_t v) {
	dpi = v;
}
void PreviewImageResult::setDimensionWidth(int32_t v) {
	dimensionWidth = v;
}
void PreviewImageResult::setDimensionHeight(int32_t v) {
	dimensionHeight = v;
}
void PreviewImageResult::setProgress(int32_t v) {
	progress = v;
}
void PreviewImageResult::setProgressMax(int32_t v) {
	progressMax = v;
}
void PreviewImageResult::setStatusMessage(::std::wstring v) {
	statusMessage = v;
}
void PreviewImageResult::setPages(int32_t v) {
	pages = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void PreviewImageResult::serialize(BIO& ar, const BVERSION version) {
	ar & this->dimensionHeight;
	ar & this->dimensionWidth;
	ar & this->dpi;
	ar & this->pages;
	ar & this->progress;
	ar & this->progressMax;
	ar & this->statusMessage;
	ar & this->urls;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_661820173(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::PreviewImageResult>(bio, pObj, pObjS, pBase);	
}
}}}}
