#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ReplSet
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ReplSet::ReplSet() {
	objId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ReplSet::ReplSet(const PArrayInt& dw, int32_t objId, const ::std::wstring& TStamp, const ::std::wstring& TStampSync)
	: dw(dw)
	, objId(objId)
	, TStamp(TStamp)
	, TStampSync(TStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ReplSet::BSerializable_getTypeId() {
	return 1124529321; 
}
void ReplSet::setDw(PArrayInt v) {
	dw = v;
}
void ReplSet::setObjId(int32_t v) {
	objId = v;
}
void ReplSet::setTStamp(::std::wstring v) {
	TStamp = v;
}
void ReplSet::setTStampSync(::std::wstring v) {
	TStampSync = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ReplSet::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->objId;
	if (version >= 900990009000001) {
		ar & this->TStamp;
		ar & this->TStampSync;
	}
	ar & this->dw;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1124529321(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ReplSet>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ReplSetCombination
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ReplSetCombination::ReplSetCombination() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ReplSetCombination::ReplSetCombination(const ::std::wstring& guid, const PBytes& combi)
	: guid(guid)
	, combi(combi)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ReplSetCombination::BSerializable_getTypeId() {
	return 2078338937; 
}
void ReplSetCombination::setGuid(::std::wstring v) {
	guid = v;
}
void ReplSetCombination::setCombi(PBytes v) {
	combi = v;
	setChangedMember(ReplSetCombinationC::mbCombiGuid);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ReplSetCombination::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->guid;
	ar & this->combi;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2078338937(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ReplSetCombination>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ReplSetCombinationC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ReplSetCombinationC::ReplSetCombinationC() {
	lnCombiGuid = 0;
	lnCombi = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ReplSetCombinationC::ReplSetCombinationC(int64_t mbCombiGuid, int32_t lnCombiGuid, int64_t mbCombi, int32_t lnCombi, int64_t mbAllMembers)
	: lnCombiGuid(lnCombiGuid)
	, lnCombi(lnCombi)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ReplSetCombinationC::BSerializable_getTypeId() {
	return 897151349; 
}
void ReplSetCombinationC::setLnCombiGuid(int32_t v) {
	lnCombiGuid = v;
}
void ReplSetCombinationC::setLnCombi(int32_t v) {
	lnCombi = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ReplSetCombinationC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnCombi;
	if (version >= 900990009000001) {
		ar & this->lnCombiGuid;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_897151349(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ReplSetCombinationC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ReplSetName
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ReplSetName::ReplSetName() {
	id = 0;
	image = 0;
	mobile = 0;
	priority = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ReplSetName::ReplSetName(const ::std::wstring& TStamp, const ::std::wstring& desc, int32_t id, int32_t image, int32_t mobile, const ::std::wstring& name, const ::std::wstring& TStampSync, int32_t priority)
	: TStamp(TStamp)
	, desc(desc)
	, id(id)
	, image(image)
	, mobile(mobile)
	, name(name)
	, TStampSync(TStampSync)
	, priority(priority)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ReplSetName::BSerializable_getTypeId() {
	return 755067340; 
}
void ReplSetName::setTStamp(::std::wstring v) {
	TStamp = v;
	setChangedMember(ReplSetNameC::mbTStamp);
}
void ReplSetName::setDesc(::std::wstring v) {
	desc = v;
	setChangedMember(ReplSetNameC::mbDesc);
}
void ReplSetName::setId(int32_t v) {
	id = v;
	setChangedMember(ReplSetNameC::mbId);
}
void ReplSetName::setImage(int32_t v) {
	image = v;
	setChangedMember(ReplSetNameC::mbImage);
}
void ReplSetName::setMobile(int32_t v) {
	mobile = v;
	setChangedMember(ReplSetNameC::mbMobile);
}
void ReplSetName::setName(::std::wstring v) {
	name = v;
	setChangedMember(ReplSetNameC::mbName);
}
void ReplSetName::setTStampSync(::std::wstring v) {
	TStampSync = v;
	setChangedMember(ReplSetNameC::mbTStampSync);
}
void ReplSetName::setPriority(int32_t v) {
	priority = v;
	setChangedMember(ReplSetNameC::mbPriority);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ReplSetName::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->TStamp;
	ar & this->desc;
	ar & this->id;
	ar & this->image;
	ar & this->mobile;
	ar & this->name;
	if (version >= 900990009000001) {
		ar & this->TStampSync;
		ar & this->priority;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_755067340(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ReplSetName>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ReplSetNameC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ReplSetNameC::ReplSetNameC() {
	lnName = 0;
	lnDesc = 0;
	lnTStamp = 0;
	lnTStampSync = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ReplSetNameC::ReplSetNameC(int64_t mbId, int64_t mbImage, int64_t mbName, int32_t lnName, int64_t mbDesc, int32_t lnDesc, int64_t mbTStamp, int32_t lnTStamp, int64_t mbMobile, int64_t mbTStampSync, int32_t lnTStampSync, int64_t mbPriority, int64_t mbAllMembers)
	: lnName(lnName)
	, lnDesc(lnDesc)
	, lnTStamp(lnTStamp)
	, lnTStampSync(lnTStampSync)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ReplSetNameC::BSerializable_getTypeId() {
	return 969246601; 
}
void ReplSetNameC::setLnName(int32_t v) {
	lnName = v;
}
void ReplSetNameC::setLnDesc(int32_t v) {
	lnDesc = v;
}
void ReplSetNameC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
void ReplSetNameC::setLnTStampSync(int32_t v) {
	lnTStampSync = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ReplSetNameC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnDesc;
	ar & this->lnName;
	ar & this->lnTStamp;
	if (version >= 900990009000001) {
		ar & this->lnTStampSync;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_969246601(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ReplSetNameC>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_884364631(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PReplSetName > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class RepliHist
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
RepliHist::RepliHist() {
	id = 0;
	imEx = 0;
	succ = 0;
	arcPriorityLocal = 0;
	arcPriorityRemote = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::RepliHist::RepliHist(int32_t id, const ::std::wstring& tSDate, int32_t imEx, int32_t succ, const ::std::wstring& arcGuid, const ::std::wstring& arcShort, const ::std::wstring& arcDesc, const ::std::wstring& tSBegin, const ::std::wstring& tSEnd, int32_t arcPriorityLocal, int32_t arcPriorityRemote)
	: id(id)
	, tSDate(tSDate)
	, imEx(imEx)
	, succ(succ)
	, arcGuid(arcGuid)
	, arcShort(arcShort)
	, arcDesc(arcDesc)
	, tSBegin(tSBegin)
	, tSEnd(tSEnd)
	, arcPriorityLocal(arcPriorityLocal)
	, arcPriorityRemote(arcPriorityRemote)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::RepliHist::BSerializable_getTypeId() {
	return 899503054; 
}
void RepliHist::setId(int32_t v) {
	id = v;
	setChangedMember(RepliHistC::mbId);
}
void RepliHist::setTSDate(::std::wstring v) {
	tSDate = v;
	setChangedMember(RepliHistC::mbTSDate);
}
void RepliHist::setImEx(int32_t v) {
	imEx = v;
	setChangedMember(RepliHistC::mbImEx);
}
void RepliHist::setSucc(int32_t v) {
	succ = v;
	setChangedMember(RepliHistC::mbSucc);
}
void RepliHist::setArcGuid(::std::wstring v) {
	arcGuid = v;
	setChangedMember(RepliHistC::mbArcGuid);
}
void RepliHist::setArcShort(::std::wstring v) {
	arcShort = v;
	setChangedMember(RepliHistC::mbArcShort);
}
void RepliHist::setArcDesc(::std::wstring v) {
	arcDesc = v;
	setChangedMember(RepliHistC::mbArcDesc);
}
void RepliHist::setTSBegin(::std::wstring v) {
	tSBegin = v;
	setChangedMember(RepliHistC::mbTSBegin);
}
void RepliHist::setTSEnd(::std::wstring v) {
	tSEnd = v;
	setChangedMember(RepliHistC::mbTSEnd);
}
void RepliHist::setArcPriorityLocal(int32_t v) {
	arcPriorityLocal = v;
	setChangedMember(RepliHistC::mbArcPriorityLocal);
}
void RepliHist::setArcPriorityRemote(int32_t v) {
	arcPriorityRemote = v;
	setChangedMember(RepliHistC::mbArcPriorityRemote);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void RepliHist::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->arcDesc;
	ar & this->arcGuid;
	ar & this->arcShort;
	ar & this->id;
	ar & this->imEx;
	ar & this->succ;
	ar & this->tSBegin;
	ar & this->tSDate;
	ar & this->tSEnd;
	if (version >= 900990009000001) {
		ar & this->arcPriorityLocal;
		ar & this->arcPriorityRemote;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_899503054(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::RepliHist>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class RepliHistC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
RepliHistC::RepliHistC() {
	lnTSDate = 0;
	lnArcGuid = 0;
	lnArcShort = 0;
	lnArcDesc = 0;
	lnTSBegin = 0;
	lnTSEnd = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::RepliHistC::RepliHistC(int64_t mbId, int64_t mbTSDate, int32_t lnTSDate, int64_t mbImEx, int64_t mbSucc, int64_t mbArcGuid, int32_t lnArcGuid, int64_t mbArcShort, int32_t lnArcShort, int64_t mbArcDesc, int32_t lnArcDesc, int64_t mbTSBegin, int32_t lnTSBegin, int64_t mbTSEnd, int32_t lnTSEnd, int64_t mbArcPriorityLocal, int64_t mbArcPriorityRemote, int64_t mbAllMembers)
	: lnTSDate(lnTSDate)
	, lnArcGuid(lnArcGuid)
	, lnArcShort(lnArcShort)
	, lnArcDesc(lnArcDesc)
	, lnTSBegin(lnTSBegin)
	, lnTSEnd(lnTSEnd)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::RepliHistC::BSerializable_getTypeId() {
	return 104551413; 
}
void RepliHistC::setLnTSDate(int32_t v) {
	lnTSDate = v;
}
void RepliHistC::setLnArcGuid(int32_t v) {
	lnArcGuid = v;
}
void RepliHistC::setLnArcShort(int32_t v) {
	lnArcShort = v;
}
void RepliHistC::setLnArcDesc(int32_t v) {
	lnArcDesc = v;
}
void RepliHistC::setLnTSBegin(int32_t v) {
	lnTSBegin = v;
}
void RepliHistC::setLnTSEnd(int32_t v) {
	lnTSEnd = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void RepliHistC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnArcDesc;
	ar & this->lnArcGuid;
	ar & this->lnArcShort;
	ar & this->lnTSBegin;
	ar & this->lnTSDate;
	ar & this->lnTSEnd;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_104551413(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::RepliHistC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ReportC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ReportC::ReportC() {
	lnId = 0;
	lnText = 0;
	lnExtra3 = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ReportC::ReportC(int64_t mbId, int32_t lnId, int64_t mbActionNo, int64_t mbUserId, int64_t mbActTime, int64_t mbObjId, int64_t mbExtra1, int64_t mbExtra2, int64_t mbSessionNo, int64_t mbText, int32_t lnText, int64_t mbExtra3, int32_t lnExtra3, int64_t mbAllMembers)
	: lnId(lnId)
	, lnText(lnText)
	, lnExtra3(lnExtra3)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ReportC::BSerializable_getTypeId() {
	return 1285453013; 
}
void ReportC::setLnId(int32_t v) {
	lnId = v;
}
void ReportC::setLnText(int32_t v) {
	lnText = v;
}
void ReportC::setLnExtra3(int32_t v) {
	lnExtra3 = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ReportC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnId;
	ar & this->lnText;
	if (version >= 900000016000001) {
		ar & this->lnExtra3;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1285453013(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ReportC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ReportErpCode
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ReportErpCode::ReportErpCode() {
	id = 0;
	limited = false;
	verbose = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ReportErpCode::ReportErpCode(int32_t id, bool limited, const ::std::wstring& name, bool verbose)
	: id(id)
	, limited(limited)
	, name(name)
	, verbose(verbose)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ReportErpCode::BSerializable_getTypeId() {
	return 508806040; 
}
void ReportErpCode::setId(int32_t v) {
	id = v;
}
void ReportErpCode::setLimited(bool v) {
	limited = v;
}
void ReportErpCode::setName(::std::wstring v) {
	name = v;
}
void ReportErpCode::setVerbose(bool v) {
	verbose = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ReportErpCode::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->id;
	ar & this->limited;
	ar & this->name;
	ar & this->verbose;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_508806040(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ReportErpCode>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1004870809(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PReportErpCode > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ReportInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ReportInfo::ReportInfo() {
	actTime = 0;
	actionNo = 0;
	extra1 = 0;
	extra2 = 0;
	objId = 0;
	sessionNo = 0;
	userId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ReportInfo::ReportInfo(int32_t actTime, int32_t actionNo, int32_t extra1, int32_t extra2, const ::std::wstring& id, int32_t objId, int32_t sessionNo, const ::std::wstring& text, int32_t userId, const ::std::wstring& actTimeISO, const ::std::wstring& action, const ::std::wstring& comment, const ::std::wstring& userName, const ::std::wstring& extra3, const PSerializable& extraInfo)
	: actTime(actTime)
	, actionNo(actionNo)
	, extra1(extra1)
	, extra2(extra2)
	, id(id)
	, objId(objId)
	, sessionNo(sessionNo)
	, text(text)
	, userId(userId)
	, actTimeISO(actTimeISO)
	, action(action)
	, comment(comment)
	, userName(userName)
	, extra3(extra3)
	, extraInfo(extraInfo)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ReportInfo::BSerializable_getTypeId() {
	return 1280848136; 
}
void ReportInfo::setActTime(int32_t v) {
	actTime = v;
	setChangedMember(ReportInfoC::mbActTimeISO);
}
void ReportInfo::setActionNo(int32_t v) {
	actionNo = v;
	setChangedMember(ReportInfoC::mbActionNo);
}
void ReportInfo::setExtra1(int32_t v) {
	extra1 = v;
	setChangedMember(ReportInfoC::mbExtra1);
}
void ReportInfo::setExtra2(int32_t v) {
	extra2 = v;
	setChangedMember(ReportInfoC::mbExtra2);
}
void ReportInfo::setId(::std::wstring v) {
	id = v;
	setChangedMember(ReportInfoC::mbId);
}
void ReportInfo::setObjId(int32_t v) {
	objId = v;
	setChangedMember(ReportInfoC::mbObjId);
}
void ReportInfo::setSessionNo(int32_t v) {
	sessionNo = v;
	setChangedMember(ReportInfoC::mbSessionNo);
}
void ReportInfo::setText(::std::wstring v) {
	text = v;
	setChangedMember(ReportInfoC::mbText);
}
void ReportInfo::setUserId(int32_t v) {
	userId = v;
	setChangedMember(ReportInfoC::mbUserId);
}
void ReportInfo::setActTimeISO(::std::wstring v) {
	actTimeISO = v;
	setChangedMember(ReportInfoC::mbActTimeISO);
}
void ReportInfo::setAction(::std::wstring v) {
	action = v;
	setChangedMember(ReportInfoC::mbAction);
}
void ReportInfo::setComment(::std::wstring v) {
	comment = v;
	setChangedMember(ReportInfoC::mbComment);
}
void ReportInfo::setUserName(::std::wstring v) {
	userName = v;
	setChangedMember(ReportInfoC::mbUserName);
}
void ReportInfo::setExtra3(::std::wstring v) {
	extra3 = v;
	setChangedMember(ReportInfoC::mbExtra3);
}
void ReportInfo::setExtraInfo(PSerializable v) {
	extraInfo = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ReportInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->actTime;
	ar & this->actTimeISO;
	ar & this->action;
	ar & this->actionNo;
	ar & this->comment;
	ar & this->extra1;
	ar & this->extra2;
	ar & this->id;
	ar & this->objId;
	ar & this->sessionNo;
	ar & this->text;
	ar & this->userId;
	ar & this->userName;
	if (version >= 900000016000001) {
		ar & this->extra3;
	}
	if (version >= 900000016000001) {
		ar & this->extraInfo;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1280848136(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ReportInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ReportInfoC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ReportInfoC::ReportInfoC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ReportInfoC::BSerializable_getTypeId() {
	return 1071192839; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ReportInfoC::serialize(BIO& ar, const BVERSION version) {
	ReportC::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1071192839(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ReportInfoC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ReportInfoUserModified
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ReportInfoUserModified::ReportInfoUserModified() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ReportInfoUserModified::ReportInfoUserModified(const PReportInfoUserProps& newProps, const PReportInfoUserProps& oldProps)
	: newProps(newProps)
	, oldProps(oldProps)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ReportInfoUserModified::BSerializable_getTypeId() {
	return 1649121955; 
}
void ReportInfoUserModified::setNewProps(PReportInfoUserProps v) {
	newProps = v;
}
void ReportInfoUserModified::setOldProps(PReportInfoUserProps v) {
	oldProps = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ReportInfoUserModified::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->newProps;
	ar & this->oldProps;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1649121955(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ReportInfoUserModified>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ReportInfoUserProps
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ReportInfoUserProps::ReportInfoUserProps() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ReportInfoUserProps::ReportInfoUserProps(const PUserInfo& userInfo, const PUserInfo& userInfoEff, const PVectorSubsInfo& subsInfos, const byps::PMapIntegerString& idsToNames)
	: userInfo(userInfo)
	, userInfoEff(userInfoEff)
	, subsInfos(subsInfos)
	, idsToNames(idsToNames)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ReportInfoUserProps::BSerializable_getTypeId() {
	return 2088129978; 
}
void ReportInfoUserProps::setUserInfo(PUserInfo v) {
	userInfo = v;
}
void ReportInfoUserProps::setUserInfoEff(PUserInfo v) {
	userInfoEff = v;
}
void ReportInfoUserProps::setSubsInfos(PVectorSubsInfo v) {
	subsInfos = v;
}
void ReportInfoUserProps::setIdsToNames(byps::PMapIntegerString v) {
	idsToNames = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ReportInfoUserProps::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->idsToNames;
	ar & this->subsInfos;
	ar & this->userInfo;
	ar & this->userInfoEff;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2088129978(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ReportInfoUserProps>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1243223397(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PReportInfo > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ReportModeC
// Generated from class byps.gen.cpp.GenApiClass

const PReportModeZ ReportModeC::NO = PReportModeZ(new ReportModeZ(
	0LL));

const PReportModeZ ReportModeC::LIMITED = PReportModeZ(new ReportModeZ(
	1LL));

const PReportModeZ ReportModeC::VERBOSE = PReportModeZ(new ReportModeZ(
	2LL));

const PReportModeZ ReportModeC::FULL = PReportModeZ(new ReportModeZ(
	3LL));

// checkpoint byps.gen.cpp.GenApiClass:489
ReportModeC::ReportModeC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ReportModeC::BSerializable_getTypeId() {
	return 1594659914; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ReportModeC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1594659914(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ReportModeC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ReportModeZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ReportModeZ::ReportModeZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ReportModeZ::ReportModeZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ReportModeZ::BSerializable_getTypeId() {
	return 1248158950; 
}
void ReportModeZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ReportModeZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1248158950(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ReportModeZ>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ReportOptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ReportOptions::ReportOptions() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ReportOptions::ReportOptions(const PArrayReportErpCode& erpCodes, const PReportModeZ& mode)
	: erpCodes(erpCodes)
	, mode(mode)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ReportOptions::BSerializable_getTypeId() {
	return 1057373949; 
}
void ReportOptions::setErpCodes(PArrayReportErpCode v) {
	erpCodes = v;
}
void ReportOptions::setMode(PReportModeZ v) {
	mode = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ReportOptions::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->erpCodes;
	ar & this->mode;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1057373949(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ReportOptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ReportOptionsC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ReportOptionsC::ReportOptionsC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ReportOptionsC::BSerializable_getTypeId() {
	return 2081332891; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ReportOptionsC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2081332891(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ReportOptionsC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ResolveRightsInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ResolveRightsInfo::ResolveRightsInfo() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ResolveRightsInfo::BSerializable_getTypeId() {
	return 1631708942; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ResolveRightsInfo::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1631708942(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ResolveRightsInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ResolveRightsResult
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ResolveRightsResult::ResolveRightsResult() {
	right = 0;
	right2 = 0;
	type = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ResolveRightsResult::ResolveRightsResult(int32_t right, int32_t right2, int32_t type, const byps::PVectorString& members)
	: right(right)
	, right2(right2)
	, type(type)
	, members(members)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ResolveRightsResult::BSerializable_getTypeId() {
	return 973279163; 
}
void ResolveRightsResult::setRight(int32_t v) {
	right = v;
}
void ResolveRightsResult::setRight2(int32_t v) {
	right2 = v;
}
void ResolveRightsResult::setType(int32_t v) {
	type = v;
}
void ResolveRightsResult::setMembers(byps::PVectorString v) {
	members = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ResolveRightsResult::serialize(BIO& ar, const BVERSION version) {
	ar & this->right;
	ar & this->right2;
	ar & this->type;
	ar & this->members;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_973279163(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ResolveRightsResult>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ResolveRightsResultC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ResolveRightsResultC::ResolveRightsResultC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ResolveRightsResultC::BSerializable_getTypeId() {
	return 1322441656; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ResolveRightsResultC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1322441656(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ResolveRightsResultC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class RestoreOptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
RestoreOptions::RestoreOptions() {
	singleObject = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::RestoreOptions::RestoreOptions(const ::std::wstring& minIDate, bool singleObject, const ::std::wstring& minDeleteDate, const ::std::wstring& parentId)
	: minIDate(minIDate)
	, singleObject(singleObject)
	, minDeleteDate(minDeleteDate)
	, parentId(parentId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::RestoreOptions::BSerializable_getTypeId() {
	return 378110234; 
}
void RestoreOptions::setMinIDate(::std::wstring v) {
	minIDate = v;
}
void RestoreOptions::setSingleObject(bool v) {
	singleObject = v;
}
void RestoreOptions::setMinDeleteDate(::std::wstring v) {
	minDeleteDate = v;
}
void RestoreOptions::setParentId(::std::wstring v) {
	parentId = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void RestoreOptions::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->minIDate;
	ar & this->singleObject;
	if (version >= 900000000000000) {
		ar & this->minDeleteDate;
		if (version >= 900000000000002) {
			ar & this->parentId;
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_378110234(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::RestoreOptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SearchModeC
// Generated from class byps.gen.cpp.GenApiClass

const PSearchModeZ SearchModeC::AND = PSearchModeZ(new SearchModeZ(
	0LL));

const PSearchModeZ SearchModeC::OR = PSearchModeZ(new SearchModeZ(
	1LL));

const PSearchModeZ SearchModeC::ONE_TERM = PSearchModeZ(new SearchModeZ(
	2LL));

const PSearchModeZ SearchModeC::EXPRESSION = PSearchModeZ(new SearchModeZ(
	3LL));

// checkpoint byps.gen.cpp.GenApiClass:489
SearchModeC::SearchModeC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SearchModeC::BSerializable_getTypeId() {
	return 1758444419; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SearchModeC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1758444419(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SearchModeC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SearchModeZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SearchModeZ::SearchModeZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::SearchModeZ::SearchModeZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SearchModeZ::BSerializable_getTypeId() {
	return 424689505; 
}
void SearchModeZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SearchModeZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_424689505(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SearchModeZ>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SearchTermsC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SearchTermsC::SearchTermsC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SearchTermsC::BSerializable_getTypeId() {
	return 334358315; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SearchTermsC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_334358315(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SearchTermsC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ServerInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ServerInfo::ServerInfo() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ServerInfo::ServerInfo(const PArrayIndexServerForArchive& indexServers, const PLicense& license, const ::std::wstring& version, const ::std::wstring& replProcessOnServerId, const ::std::wstring& databaseEngine, const ::std::wstring& instanceName)
	: indexServers(indexServers)
	, license(license)
	, version(version)
	, replProcessOnServerId(replProcessOnServerId)
	, databaseEngine(databaseEngine)
	, instanceName(instanceName)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ServerInfo::BSerializable_getTypeId() {
	return 1701204890; 
}
void ServerInfo::setIndexServers(PArrayIndexServerForArchive v) {
	indexServers = v;
}
void ServerInfo::setLicense(PLicense v) {
	license = v;
}
void ServerInfo::setVersion(::std::wstring v) {
	version = v;
}
void ServerInfo::setReplProcessOnServerId(::std::wstring v) {
	replProcessOnServerId = v;
}
void ServerInfo::setDatabaseEngine(::std::wstring v) {
	databaseEngine = v;
}
void ServerInfo::setInstanceName(::std::wstring v) {
	instanceName = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ServerInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->version;
	if (version >= 700000000000015) {
		ar & this->replProcessOnServerId;
		if (version >= 800000000000002) {
			ar & this->databaseEngine;
			if (version >= 800000012000004) {
				ar & this->instanceName;
			}
		}
	}
	ar & this->indexServers;
	ar & this->license;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1701204890(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ServerInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ServerInfoDM
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ServerInfoDM::ServerInfoDM() {
	restoreStoreId = 0;
	storeMode = 0;
	proxyMode = 0;
	blackeningEnabled = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ServerInfoDM::ServerInfoDM(const PArrayInt& basisStoreIds, const PArrayInt& backupStoreIds, int32_t restoreStoreId, int32_t storeMode, int32_t proxyMode, bool blackeningEnabled)
	: basisStoreIds(basisStoreIds)
	, backupStoreIds(backupStoreIds)
	, restoreStoreId(restoreStoreId)
	, storeMode(storeMode)
	, proxyMode(proxyMode)
	, blackeningEnabled(blackeningEnabled)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ServerInfoDM::BSerializable_getTypeId() {
	return 1425760760; 
}
void ServerInfoDM::setBasisStoreIds(PArrayInt v) {
	basisStoreIds = v;
}
void ServerInfoDM::setBackupStoreIds(PArrayInt v) {
	backupStoreIds = v;
}
void ServerInfoDM::setRestoreStoreId(int32_t v) {
	restoreStoreId = v;
}
void ServerInfoDM::setStoreMode(int32_t v) {
	storeMode = v;
}
void ServerInfoDM::setProxyMode(int32_t v) {
	proxyMode = v;
}
void ServerInfoDM::setBlackeningEnabled(bool v) {
	blackeningEnabled = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ServerInfoDM::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->blackeningEnabled;
	ar & this->proxyMode;
	ar & this->restoreStoreId;
	ar & this->storeMode;
	ar & this->backupStoreIds;
	ar & this->basisStoreIds;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1425760760(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ServerInfoDM>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ServerInfoDMC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ServerInfoDMC::ServerInfoDMC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ServerInfoDMC::BSerializable_getTypeId() {
	return 287365821; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ServerInfoDMC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_287365821(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ServerInfoDMC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ServerState
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ServerState::ServerState() {
	actionId = 0;
	subKey = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ServerState::ServerState(int32_t actionId, int32_t subKey, const ::std::wstring& action)
	: actionId(actionId)
	, subKey(subKey)
	, action(action)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ServerState::BSerializable_getTypeId() {
	return 1076606418; 
}
void ServerState::setActionId(int32_t v) {
	actionId = v;
	setChangedMember(ServerStateC::mbActionId);
}
void ServerState::setSubKey(int32_t v) {
	subKey = v;
	setChangedMember(ServerStateC::mbSubKey);
}
void ServerState::setAction(::std::wstring v) {
	action = v;
	setChangedMember(ServerStateC::mbActionId);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ServerState::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->action;
	ar & this->actionId;
	ar & this->subKey;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1076606418(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ServerState>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ServerStateC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ServerStateC::ServerStateC() {
	lnAction = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ServerStateC::ServerStateC(int64_t mbActionId, int64_t mbSubKey, int64_t mbAction, int32_t lnAction, int64_t mbAllMembers)
	: lnAction(lnAction)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ServerStateC::BSerializable_getTypeId() {
	return 1862501863; 
}
void ServerStateC::setLnAction(int32_t v) {
	lnAction = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ServerStateC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnAction;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1862501863(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ServerStateC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SessionInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SessionInfo::SessionInfo() {
	userId = 0;
	validSeconds = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::SessionInfo::SessionInfo(const ::std::wstring& clientComputer, int32_t userId, int32_t validSeconds, const ::std::wstring& ticket, const ::std::wstring& userName, const ::std::wstring& loginName, const ::std::wstring& bestBefore, const ::std::wstring& appName, const ::std::wstring& appVersion, const ::std::wstring& appType, const ::std::wstring& runAs)
	: clientComputer(clientComputer)
	, userId(userId)
	, validSeconds(validSeconds)
	, ticket(ticket)
	, userName(userName)
	, loginName(loginName)
	, bestBefore(bestBefore)
	, appName(appName)
	, appVersion(appVersion)
	, appType(appType)
	, runAs(runAs)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SessionInfo::BSerializable_getTypeId() {
	return 866689803; 
}
void SessionInfo::setClientComputer(::std::wstring v) {
	clientComputer = v;
}
void SessionInfo::setUserId(int32_t v) {
	userId = v;
}
void SessionInfo::setValidSeconds(int32_t v) {
	validSeconds = v;
}
void SessionInfo::setTicket(::std::wstring v) {
	ticket = v;
}
void SessionInfo::setUserName(::std::wstring v) {
	userName = v;
}
void SessionInfo::setLoginName(::std::wstring v) {
	loginName = v;
}
void SessionInfo::setBestBefore(::std::wstring v) {
	bestBefore = v;
}
void SessionInfo::setAppName(::std::wstring v) {
	appName = v;
}
void SessionInfo::setAppVersion(::std::wstring v) {
	appVersion = v;
}
void SessionInfo::setAppType(::std::wstring v) {
	appType = v;
}
void SessionInfo::setRunAs(::std::wstring v) {
	runAs = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SessionInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->clientComputer;
	ar & this->userId;
	ar & this->validSeconds;
	if (version >= 800000032000006) {
		ar & this->appName;
		ar & this->appType;
		ar & this->appVersion;
		ar & this->bestBefore;
		ar & this->runAs;
		ar & this->ticket;
		ar & this->userName;
		if (version >= 900000022000005) {
			ar & this->loginName;
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_866689803(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SessionInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SessionInfoParams
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SessionInfoParams::SessionInfoParams() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SessionInfoParams::BSerializable_getTypeId() {
	return 2013576169; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SessionInfoParams::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2013576169(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SessionInfoParams>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1376733713(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PSessionInfo > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class SessionOptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
SessionOptions::SessionOptions() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::SessionOptions::SessionOptions(const PArrayKeyValue& options)
	: options(options)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::SessionOptions::BSerializable_getTypeId() {
	return 1197100286; 
}
void SessionOptions::setOptions(PArrayKeyValue v) {
	options = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void SessionOptions::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->options;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1197100286(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::SessionOptions>(bio, pObj, pObjS, pBase);	
}
}}}}
