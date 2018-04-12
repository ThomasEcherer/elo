#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WFNodeAssoc
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WFNodeAssoc::WFNodeAssoc() {
	done = false;
	nodeFrom = 0;
	nodeTo = 0;
	type = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WFNodeAssoc::WFNodeAssoc(bool done, int32_t nodeFrom, int32_t nodeTo, int32_t type)
	: done(done)
	, nodeFrom(nodeFrom)
	, nodeTo(nodeTo)
	, type(type)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WFNodeAssoc::BSerializable_getTypeId() {
	return 1042649178; 
}
void WFNodeAssoc::setDone(bool v) {
	done = v;
}
void WFNodeAssoc::setNodeFrom(int32_t v) {
	nodeFrom = v;
}
void WFNodeAssoc::setNodeTo(int32_t v) {
	nodeTo = v;
}
void WFNodeAssoc::setType(int32_t v) {
	type = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WFNodeAssoc::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->done;
	ar & this->nodeFrom;
	ar & this->nodeTo;
	ar & this->type;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1042649178(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WFNodeAssoc>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_715244239(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PWFNodeAssoc > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WFNodeC
// Generated from class byps.gen.cpp.GenApiClass

const PWFNodeZ WFNodeC::mbAll = PWFNodeZ(new WFNodeZ(
	140737488355327LL));

const ::std::wstring WFNodeC::DEACTIVATE_ALL_PREDS = std::wstring(L"All Preds");

// checkpoint byps.gen.cpp.GenApiClass:489
WFNodeC::WFNodeC() {
	lnName = 0;
	lnComment = 0;
	lnOnEnter = 0;
	lnOnExit = 0;
	lnYesNoCondition = 0;
	lnCondition = 0;
	lnProcessOnServerId = 0;
	lnFormSpec = 0;
	lnNameTranslationKey = 0;
	lnCommentTranslationKey = 0;
	lnLabel = 0;
	lnLabelTranslationKey = 0;
	lnProperties = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WFNodeC::WFNodeC(int64_t mbId, int64_t mbType, int64_t mbEnterDate, int64_t mbExitDate, int64_t mbInUseDate, int64_t mbName, int32_t lnName, int64_t mbUserId, int64_t mbNbOfDonesToExit, int64_t mbTimeLimit, int64_t mbComment, int32_t lnComment, int64_t mbPosX, int64_t mbPosY, int64_t mbLockId, int64_t mbOnEnter, int32_t lnOnEnter, int64_t mbOnExit, int32_t lnOnExit, int64_t mbFlags, int64_t mbIsNext, int64_t mbYesNoCondition, int32_t lnYesNoCondition, int64_t mbCondition, int32_t lnCondition, int64_t mbResult, int64_t mbUserTerminate, int64_t mbTag, int64_t mbDesignDepartment, int64_t mbMoveCyclePosX, int64_t mbDepartment2, int64_t mbDelayDays, int64_t mbDelayDate, int64_t mbUserDelayDate, int64_t mbProcessOnServerId, int32_t lnProcessOnServerId, int64_t mbTimeLimitEscalations, int64_t mbObjKeyNames, int64_t mbScriptNames, int64_t mbIconId, int64_t mbFormSpec, int32_t lnFormSpec, int64_t mbNameTranslationKey, int32_t lnNameTranslationKey, int64_t mbCommentTranslationKey, int32_t lnCommentTranslationKey, int64_t mbLabel, int32_t lnLabel, int32_t lnLabelTranslationKey, int64_t mbProperties, int32_t lnProperties, int64_t mbDepartmentGroup, int64_t mbSubFlowId, int64_t mbRetVal, int64_t mbSubTemplateName, int64_t mbSubTemplateId, int64_t mbLabelTranslationKey, int64_t mbReturnValue, int64_t mbPrio, int64_t mbEnterDateIso, int64_t mbExitDateIso, int64_t mbInUseDateIso, int64_t mbTimeLimitIso, int64_t mbUserName, int64_t mbDelayDateIso, int64_t mbUserDelayDateIso, int64_t mbAllMembers, const PWFNodeZ& mbAll, int32_t FLAG_ONE_SUCCESSOR, int32_t FLAG_ROOT_ADHOC, int32_t FLAG_NOT_VALID, int32_t FLAG_TERMINATE_USER, int32_t FLAG_RESET_CHILDREN, int32_t FLAG_CYCLE_END, int32_t FLAG_CYCLE_X, int32_t FLAG_COPY_CHILDREN, int32_t FLAG_WORKINGDAYS, int32_t FLAG_RESETADHOCNODE, int32_t FLAG_HIDDEN, int32_t FLAG_DO_NOT_START_MANUALLY, int32_t FLAG_DELEGATED, int32_t TYPE_NOTHING, int32_t TYPE_BEGINNODE, int32_t TYPE_PERSONNODE, int32_t TYPE_SPLITNODE, int32_t TYPE_IFNODE, int32_t TYPE_COLLECTNODE, int32_t TYPE_ENDNODE, int32_t TYPE_CYCLE, int32_t TYPE_SET_SERVER_ID, int32_t TYPE_CALL_SUB_WORKFLOW, int32_t USERID_OWNER, int32_t USERID_IGNORE, int32_t USERID_SUPERIOR, const ::std::wstring& DEACTIVATE_ALL_PREDS)
	: lnName(lnName)
	, lnComment(lnComment)
	, lnOnEnter(lnOnEnter)
	, lnOnExit(lnOnExit)
	, lnYesNoCondition(lnYesNoCondition)
	, lnCondition(lnCondition)
	, lnProcessOnServerId(lnProcessOnServerId)
	, lnFormSpec(lnFormSpec)
	, lnNameTranslationKey(lnNameTranslationKey)
	, lnCommentTranslationKey(lnCommentTranslationKey)
	, lnLabel(lnLabel)
	, lnLabelTranslationKey(lnLabelTranslationKey)
	, lnProperties(lnProperties)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WFNodeC::BSerializable_getTypeId() {
	return 1514069164; 
}
void WFNodeC::setLnName(int32_t v) {
	lnName = v;
}
void WFNodeC::setLnComment(int32_t v) {
	lnComment = v;
}
void WFNodeC::setLnOnEnter(int32_t v) {
	lnOnEnter = v;
}
void WFNodeC::setLnOnExit(int32_t v) {
	lnOnExit = v;
}
void WFNodeC::setLnYesNoCondition(int32_t v) {
	lnYesNoCondition = v;
}
void WFNodeC::setLnCondition(int32_t v) {
	lnCondition = v;
}
void WFNodeC::setLnProcessOnServerId(int32_t v) {
	lnProcessOnServerId = v;
}
void WFNodeC::setLnFormSpec(int32_t v) {
	lnFormSpec = v;
}
void WFNodeC::setLnNameTranslationKey(int32_t v) {
	lnNameTranslationKey = v;
}
void WFNodeC::setLnCommentTranslationKey(int32_t v) {
	lnCommentTranslationKey = v;
}
void WFNodeC::setLnLabel(int32_t v) {
	lnLabel = v;
}
void WFNodeC::setLnLabelTranslationKey(int32_t v) {
	lnLabelTranslationKey = v;
}
void WFNodeC::setLnProperties(int32_t v) {
	lnProperties = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WFNodeC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnComment;
	ar & this->lnCondition;
	ar & this->lnName;
	ar & this->lnOnEnter;
	ar & this->lnOnExit;
	ar & this->lnYesNoCondition;
	if (version >= 700000000000015) {
		ar & this->lnProcessOnServerId;
		if (version >= 900000000000029) {
			ar & this->lnFormSpec;
			if (version >= 900000018000007) {
				ar & this->lnCommentTranslationKey;
				ar & this->lnNameTranslationKey;
				if (version >= 900000022000019) {
					ar & this->lnLabel;
					if (version >= 900000030000021) {
						ar & this->lnLabelTranslationKey;
						if (version >= 900000050000004) {
							ar & this->lnProperties;
						}
					}
				}
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1514069164(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WFNodeC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WFNodeHistory
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WFNodeHistory::WFNodeHistory() {
	nodeId = 0;
	userId = 0;
	succ_0 = 0;
	succ_1 = 0;
	succ_2 = 0;
	succ_3 = 0;
	succ_4 = 0;
	succ_5 = 0;
	succ_6 = 0;
	succ_7 = 0;
	succ_8 = 0;
	succ_9 = 0;
	succ_10 = 0;
	succ_11 = 0;
	succ_12 = 0;
	succ_13 = 0;
	succ_14 = 0;
	succ_15 = 0;
	succ_16 = 0;
	succ_17 = 0;
	succ_18 = 0;
	succ_19 = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WFNodeHistory::WFNodeHistory(const ::std::wstring& histGuid, const ::std::wstring& flowGuid, int32_t nodeId, int32_t userId, const ::std::wstring& userName, const ::std::wstring& enterDateIso, const ::std::wstring& exitDateIso, int32_t succ_0, int32_t succ_1, int32_t succ_2, int32_t succ_3, int32_t succ_4, int32_t succ_5, int32_t succ_6, int32_t succ_7, int32_t succ_8, int32_t succ_9, int32_t succ_10, int32_t succ_11, int32_t succ_12, int32_t succ_13, int32_t succ_14, int32_t succ_15, int32_t succ_16, int32_t succ_17, int32_t succ_18, int32_t succ_19)
	: histGuid(histGuid)
	, flowGuid(flowGuid)
	, nodeId(nodeId)
	, userId(userId)
	, userName(userName)
	, enterDateIso(enterDateIso)
	, exitDateIso(exitDateIso)
	, succ_0(succ_0)
	, succ_1(succ_1)
	, succ_2(succ_2)
	, succ_3(succ_3)
	, succ_4(succ_4)
	, succ_5(succ_5)
	, succ_6(succ_6)
	, succ_7(succ_7)
	, succ_8(succ_8)
	, succ_9(succ_9)
	, succ_10(succ_10)
	, succ_11(succ_11)
	, succ_12(succ_12)
	, succ_13(succ_13)
	, succ_14(succ_14)
	, succ_15(succ_15)
	, succ_16(succ_16)
	, succ_17(succ_17)
	, succ_18(succ_18)
	, succ_19(succ_19)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WFNodeHistory::BSerializable_getTypeId() {
	return 784568809; 
}
void WFNodeHistory::setHistGuid(::std::wstring v) {
	histGuid = v;
	setChangedMember(WFNodeHistoryC::mbHistGuid);
}
void WFNodeHistory::setFlowGuid(::std::wstring v) {
	flowGuid = v;
	setChangedMember(WFNodeHistoryC::mbFlowGuid);
}
void WFNodeHistory::setNodeId(int32_t v) {
	nodeId = v;
	setChangedMember(WFNodeHistoryC::mbNodeId);
}
void WFNodeHistory::setUserId(int32_t v) {
	userId = v;
	setChangedMember(WFNodeHistoryC::mbUserId);
}
void WFNodeHistory::setUserName(::std::wstring v) {
	userName = v;
	setChangedMember(WFNodeHistoryC::mbUserName);
}
void WFNodeHistory::setEnterDateIso(::std::wstring v) {
	enterDateIso = v;
}
void WFNodeHistory::setExitDateIso(::std::wstring v) {
	exitDateIso = v;
}
void WFNodeHistory::setSucc_0(int32_t v) {
	succ_0 = v;
	setChangedMember(WFNodeHistoryC::mbSucc_0);
}
void WFNodeHistory::setSucc_1(int32_t v) {
	succ_1 = v;
	setChangedMember(WFNodeHistoryC::mbSucc_1);
}
void WFNodeHistory::setSucc_2(int32_t v) {
	succ_2 = v;
	setChangedMember(WFNodeHistoryC::mbSucc_2);
}
void WFNodeHistory::setSucc_3(int32_t v) {
	succ_3 = v;
	setChangedMember(WFNodeHistoryC::mbSucc_3);
}
void WFNodeHistory::setSucc_4(int32_t v) {
	succ_4 = v;
	setChangedMember(WFNodeHistoryC::mbSucc_4);
}
void WFNodeHistory::setSucc_5(int32_t v) {
	succ_5 = v;
	setChangedMember(WFNodeHistoryC::mbSucc_5);
}
void WFNodeHistory::setSucc_6(int32_t v) {
	succ_6 = v;
	setChangedMember(WFNodeHistoryC::mbSucc_6);
}
void WFNodeHistory::setSucc_7(int32_t v) {
	succ_7 = v;
	setChangedMember(WFNodeHistoryC::mbSucc_7);
}
void WFNodeHistory::setSucc_8(int32_t v) {
	succ_8 = v;
	setChangedMember(WFNodeHistoryC::mbSucc_8);
}
void WFNodeHistory::setSucc_9(int32_t v) {
	succ_9 = v;
	setChangedMember(WFNodeHistoryC::mbSucc_9);
}
void WFNodeHistory::setSucc_10(int32_t v) {
	succ_10 = v;
	setChangedMember(WFNodeHistoryC::mbSucc_10);
}
void WFNodeHistory::setSucc_11(int32_t v) {
	succ_11 = v;
	setChangedMember(WFNodeHistoryC::mbSucc_11);
}
void WFNodeHistory::setSucc_12(int32_t v) {
	succ_12 = v;
	setChangedMember(WFNodeHistoryC::mbSucc_12);
}
void WFNodeHistory::setSucc_13(int32_t v) {
	succ_13 = v;
	setChangedMember(WFNodeHistoryC::mbSucc_13);
}
void WFNodeHistory::setSucc_14(int32_t v) {
	succ_14 = v;
	setChangedMember(WFNodeHistoryC::mbSucc_14);
}
void WFNodeHistory::setSucc_15(int32_t v) {
	succ_15 = v;
	setChangedMember(WFNodeHistoryC::mbSucc_15);
}
void WFNodeHistory::setSucc_16(int32_t v) {
	succ_16 = v;
	setChangedMember(WFNodeHistoryC::mbSucc_16);
}
void WFNodeHistory::setSucc_17(int32_t v) {
	succ_17 = v;
	setChangedMember(WFNodeHistoryC::mbSucc_17);
}
void WFNodeHistory::setSucc_18(int32_t v) {
	succ_18 = v;
	setChangedMember(WFNodeHistoryC::mbSucc_18);
}
void WFNodeHistory::setSucc_19(int32_t v) {
	succ_19 = v;
	setChangedMember(WFNodeHistoryC::mbSucc_19);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WFNodeHistory::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->enterDateIso;
	ar & this->exitDateIso;
	ar & this->flowGuid;
	ar & this->histGuid;
	ar & this->nodeId;
	ar & this->succ_0;
	ar & this->succ_1;
	ar & this->succ_10;
	ar & this->succ_11;
	ar & this->succ_12;
	ar & this->succ_13;
	ar & this->succ_14;
	ar & this->succ_15;
	ar & this->succ_16;
	ar & this->succ_17;
	ar & this->succ_18;
	ar & this->succ_19;
	ar & this->succ_2;
	ar & this->succ_3;
	ar & this->succ_4;
	ar & this->succ_5;
	ar & this->succ_6;
	ar & this->succ_7;
	ar & this->succ_8;
	ar & this->succ_9;
	ar & this->userId;
	ar & this->userName;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_784568809(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WFNodeHistory>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WFNodeHistoryC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WFNodeHistoryC::WFNodeHistoryC() {
	lnHistGuid = 0;
	lnFlowGuid = 0;
	lnUserName = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WFNodeHistoryC::WFNodeHistoryC(int64_t mbHistGuid, int32_t lnHistGuid, int64_t mbFlowGuid, int32_t lnFlowGuid, int64_t mbNodeId, int64_t mbActivate, int64_t mbTerminate, int64_t mbUserId, int64_t mbUserName, int32_t lnUserName, int64_t mbSucc_0, int64_t mbSucc_1, int64_t mbSucc_2, int64_t mbSucc_3, int64_t mbSucc_4, int64_t mbSucc_5, int64_t mbSucc_6, int64_t mbSucc_7, int64_t mbSucc_8, int64_t mbSucc_9, int64_t mbSucc_10, int64_t mbSucc_11, int64_t mbSucc_12, int64_t mbSucc_13, int64_t mbSucc_14, int64_t mbSucc_15, int64_t mbSucc_16, int64_t mbSucc_17, int64_t mbSucc_18, int64_t mbSucc_19, int64_t mbAllMembers)
	: lnHistGuid(lnHistGuid)
	, lnFlowGuid(lnFlowGuid)
	, lnUserName(lnUserName)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WFNodeHistoryC::BSerializable_getTypeId() {
	return 1457412372; 
}
void WFNodeHistoryC::setLnHistGuid(int32_t v) {
	lnHistGuid = v;
}
void WFNodeHistoryC::setLnFlowGuid(int32_t v) {
	lnFlowGuid = v;
}
void WFNodeHistoryC::setLnUserName(int32_t v) {
	lnUserName = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WFNodeHistoryC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnFlowGuid;
	ar & this->lnUserName;
	if (version >= 900000030000018) {
		ar & this->lnHistGuid;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1457412372(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WFNodeHistoryC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WFNodeMatrix
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WFNodeMatrix::WFNodeMatrix() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WFNodeMatrix::WFNodeMatrix(const PArrayWFNodeAssoc& assocs)
	: assocs(assocs)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WFNodeMatrix::BSerializable_getTypeId() {
	return 425879495; 
}
void WFNodeMatrix::setAssocs(PArrayWFNodeAssoc v) {
	assocs = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WFNodeMatrix::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->assocs;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_425879495(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WFNodeMatrix>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WFNodeMatrixC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WFNodeMatrixC::WFNodeMatrixC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WFNodeMatrixC::BSerializable_getTypeId() {
	return 171864975; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WFNodeMatrixC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_171864975(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WFNodeMatrixC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WFNodeZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WFNodeZ::WFNodeZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WFNodeZ::WFNodeZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WFNodeZ::BSerializable_getTypeId() {
	return 226200225; 
}
void WFNodeZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WFNodeZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_226200225(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WFNodeZ>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1457843286(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PWFNode > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WFTakeNodeC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WFTakeNodeC::WFTakeNodeC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WFTakeNodeC::BSerializable_getTypeId() {
	return 1164251184; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WFTakeNodeC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1164251184(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WFTakeNodeC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WFTimeLimit
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WFTimeLimit::WFTimeLimit() {
	timeLimit = 0;
	userId = 0;
	overTimeLimit = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WFTimeLimit::WFTimeLimit(int32_t timeLimit, int32_t userId, const ::std::wstring& userName, const ::std::wstring& timeLimitIso, bool overTimeLimit)
	: timeLimit(timeLimit)
	, userId(userId)
	, userName(userName)
	, timeLimitIso(timeLimitIso)
	, overTimeLimit(overTimeLimit)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WFTimeLimit::BSerializable_getTypeId() {
	return 633363356; 
}
void WFTimeLimit::setTimeLimit(int32_t v) {
	timeLimit = v;
}
void WFTimeLimit::setUserId(int32_t v) {
	userId = v;
}
void WFTimeLimit::setUserName(::std::wstring v) {
	userName = v;
}
void WFTimeLimit::setTimeLimitIso(::std::wstring v) {
	timeLimitIso = v;
}
void WFTimeLimit::setOverTimeLimit(bool v) {
	overTimeLimit = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WFTimeLimit::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->timeLimit;
	ar & this->timeLimitIso;
	ar & this->userId;
	ar & this->userName;
	if (version >= 700000000000017) {
		ar & this->overTimeLimit;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_633363356(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WFTimeLimit>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1495941578(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PWFTimeLimit > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WFTypeC
// Generated from class byps.gen.cpp.GenApiClass

const PWFTypeZ WFTypeC::ACTIVE = PWFTypeZ(new WFTypeZ(
	0LL));

const PWFTypeZ WFTypeC::FINISHED = PWFTypeZ(new WFTypeZ(
	1LL));

const PWFTypeZ WFTypeC::TEMPLATE = PWFTypeZ(new WFTypeZ(
	2LL));

// checkpoint byps.gen.cpp.GenApiClass:489
WFTypeC::WFTypeC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WFTypeC::BSerializable_getTypeId() {
	return 1842783874; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WFTypeC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1842783874(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WFTypeC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WFTypeZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WFTypeZ::WFTypeZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WFTypeZ::WFTypeZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WFTypeZ::BSerializable_getTypeId() {
	return 927083544; 
}
void WFTypeZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WFTypeZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_927083544(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WFTypeZ>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WFVersion
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WFVersion::WFVersion() {
	id = 0;
	userId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WFVersion::WFVersion(int32_t id, const ::std::wstring& comment, int32_t userId, const ::std::wstring& userName, const ::std::wstring& version, const ::std::wstring& createDateIso)
	: id(id)
	, comment(comment)
	, userId(userId)
	, userName(userName)
	, version(version)
	, createDateIso(createDateIso)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WFVersion::BSerializable_getTypeId() {
	return 914434915; 
}
void WFVersion::setId(int32_t v) {
	id = v;
}
void WFVersion::setComment(::std::wstring v) {
	comment = v;
}
void WFVersion::setUserId(int32_t v) {
	userId = v;
}
void WFVersion::setUserName(::std::wstring v) {
	userName = v;
}
void WFVersion::setVersion(::std::wstring v) {
	version = v;
}
void WFVersion::setCreateDateIso(::std::wstring v) {
	createDateIso = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WFVersion::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->comment;
	ar & this->id;
	if (version >= 700000000000018) {
		ar & this->createDateIso;
		ar & this->userId;
		ar & this->userName;
		ar & this->version;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_914434915(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WFVersion>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WFVersionC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WFVersionC::WFVersionC() {
	lnComment = 0;
	lnVersion = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WFVersionC::WFVersionC(int32_t lnComment, int32_t lnVersion)
	: lnComment(lnComment)
	, lnVersion(lnVersion)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WFVersionC::BSerializable_getTypeId() {
	return 1378592156; 
}
void WFVersionC::setLnComment(int32_t v) {
	lnComment = v;
}
void WFVersionC::setLnVersion(int32_t v) {
	lnVersion = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WFVersionC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnComment;
	if (version >= 700000000000018) {
		ar & this->lnVersion;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1378592156(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WFVersionC>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1768472140(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PWFVersion > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WorkFlowActiveDoc
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WorkFlowActiveDoc::WorkFlowActiveDoc() {
	flowId = 0;
	nodeId = 0;
	nodeType = 0;
	succType = 0;
	department = 0;
	alertTo = 0;
	alertFromBegin = 0;
	alertWait = 0;
	succ_0 = 0;
	succ_1 = 0;
	succ_2 = 0;
	succ_3 = 0;
	succ_4 = 0;
	succ_5 = 0;
	succ_6 = 0;
	succ_7 = 0;
	succ_8 = 0;
	succ_9 = 0;
	succ_10 = 0;
	succ_11 = 0;
	succ_12 = 0;
	succ_13 = 0;
	succ_14 = 0;
	succ_15 = 0;
	succ_16 = 0;
	succ_17 = 0;
	succ_18 = 0;
	succ_19 = 0;
	locked = 0;
	posX = 0;
	posY = 0;
	nodeFlags = 0;
	eloObjId = 0;
	lockId = 0;
	isNext = 0;
	activate = 0;
	terminate = 0;
	inUseDate = 0;
	completionDate = 0;
	templateId = 0;
	tag = 0;
	designDepartment = 0;
	moveCyclePosX = 0;
	department2 = 0;
	delayDays = 0;
	delayDate = 0;
	deleted = 0;
	prio = 0;
	userDelayDate = 0;
	versionId = 0;
	alertTo2 = 0;
	alertWait2 = 0;
	alertTo3 = 0;
	alertWait3 = 0;
	versionUserId = 0;
	versionCreateDate = 0;
	departmentGroup = 0;
	retVal = 0;
	subWorkflow = 0;
	subWorkflowTemplate = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WorkFlowActiveDoc::WorkFlowActiveDoc(int32_t flowId, int32_t nodeId, const ::std::wstring& flowName, const ::std::wstring& name, int32_t nodeType, int32_t succType, int32_t department, int32_t alertTo, int32_t alertFromBegin, int32_t alertWait, const ::std::wstring& yNCondition, const ::std::wstring& condition, const ::std::wstring& comment, int32_t succ_0, int32_t succ_1, int32_t succ_2, int32_t succ_3, int32_t succ_4, int32_t succ_5, int32_t succ_6, int32_t succ_7, int32_t succ_8, int32_t succ_9, int32_t succ_10, int32_t succ_11, int32_t succ_12, int32_t succ_13, int32_t succ_14, int32_t succ_15, int32_t succ_16, int32_t succ_17, int32_t succ_18, int32_t succ_19, int32_t locked, int32_t posX, int32_t posY, const ::std::wstring& onActivate, const ::std::wstring& onTerminate, int32_t nodeFlags, int32_t eloObjId, int32_t lockId, int32_t isNext, int32_t activate, int32_t terminate, int32_t inUseDate, int32_t completionDate, int32_t templateId, const ::std::wstring& userTerminate, int32_t tag, int32_t designDepartment, int32_t moveCyclePosX, int32_t department2, int32_t delayDays, int32_t delayDate, int32_t deleted, int32_t prio, int32_t userDelayDate, int32_t versionId, const ::std::wstring& versionName, int32_t alertTo2, int32_t alertWait2, int32_t alertTo3, int32_t alertWait3, const ::std::wstring& nextServerId, const ::std::wstring& versionTag, int32_t versionUserId, int32_t versionCreateDate, const ::std::wstring& iconId, const ::std::wstring& formSpec, const ::std::wstring& flowNameTranslationKey, const ::std::wstring& nameTranslationKey, const ::std::wstring& commentTranslationKey, const ::std::wstring& label, const ::std::wstring& properties, int32_t departmentGroup, int32_t retVal, const ::std::wstring& returnValue, int32_t subWorkflow, const ::std::wstring& labelTranslationKey, int32_t subWorkflowTemplate)
	: flowId(flowId)
	, nodeId(nodeId)
	, flowName(flowName)
	, name(name)
	, nodeType(nodeType)
	, succType(succType)
	, department(department)
	, alertTo(alertTo)
	, alertFromBegin(alertFromBegin)
	, alertWait(alertWait)
	, yNCondition(yNCondition)
	, condition(condition)
	, comment(comment)
	, succ_0(succ_0)
	, succ_1(succ_1)
	, succ_2(succ_2)
	, succ_3(succ_3)
	, succ_4(succ_4)
	, succ_5(succ_5)
	, succ_6(succ_6)
	, succ_7(succ_7)
	, succ_8(succ_8)
	, succ_9(succ_9)
	, succ_10(succ_10)
	, succ_11(succ_11)
	, succ_12(succ_12)
	, succ_13(succ_13)
	, succ_14(succ_14)
	, succ_15(succ_15)
	, succ_16(succ_16)
	, succ_17(succ_17)
	, succ_18(succ_18)
	, succ_19(succ_19)
	, locked(locked)
	, posX(posX)
	, posY(posY)
	, onActivate(onActivate)
	, onTerminate(onTerminate)
	, nodeFlags(nodeFlags)
	, eloObjId(eloObjId)
	, lockId(lockId)
	, isNext(isNext)
	, activate(activate)
	, terminate(terminate)
	, inUseDate(inUseDate)
	, completionDate(completionDate)
	, templateId(templateId)
	, userTerminate(userTerminate)
	, tag(tag)
	, designDepartment(designDepartment)
	, moveCyclePosX(moveCyclePosX)
	, department2(department2)
	, delayDays(delayDays)
	, delayDate(delayDate)
	, deleted(deleted)
	, prio(prio)
	, userDelayDate(userDelayDate)
	, versionId(versionId)
	, versionName(versionName)
	, alertTo2(alertTo2)
	, alertWait2(alertWait2)
	, alertTo3(alertTo3)
	, alertWait3(alertWait3)
	, nextServerId(nextServerId)
	, versionTag(versionTag)
	, versionUserId(versionUserId)
	, versionCreateDate(versionCreateDate)
	, iconId(iconId)
	, formSpec(formSpec)
	, flowNameTranslationKey(flowNameTranslationKey)
	, nameTranslationKey(nameTranslationKey)
	, commentTranslationKey(commentTranslationKey)
	, label(label)
	, properties(properties)
	, departmentGroup(departmentGroup)
	, retVal(retVal)
	, returnValue(returnValue)
	, subWorkflow(subWorkflow)
	, labelTranslationKey(labelTranslationKey)
	, subWorkflowTemplate(subWorkflowTemplate)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WorkFlowActiveDoc::BSerializable_getTypeId() {
	return 1807635378; 
}
void WorkFlowActiveDoc::setFlowId(int32_t v) {
	flowId = v;
	setChangedMember(WorkFlowActiveDocC::mbFlowId);
}
void WorkFlowActiveDoc::setNodeId(int32_t v) {
	nodeId = v;
	setChangedMember(WorkFlowActiveDocC::mbNodeId);
}
void WorkFlowActiveDoc::setFlowName(::std::wstring v) {
	flowName = v;
	setChangedMember(WorkFlowActiveDocC::mbFlowName);
}
void WorkFlowActiveDoc::setName(::std::wstring v) {
	name = v;
	setChangedMember(WorkFlowActiveDocC::mbName);
}
void WorkFlowActiveDoc::setNodeType(int32_t v) {
	nodeType = v;
	setChangedMember(WorkFlowActiveDocC::mbNodeType);
}
void WorkFlowActiveDoc::setSuccType(int32_t v) {
	succType = v;
}
void WorkFlowActiveDoc::setDepartment(int32_t v) {
	department = v;
	setChangedMember(WorkFlowActiveDocC::mbDepartment);
}
void WorkFlowActiveDoc::setAlertTo(int32_t v) {
	alertTo = v;
	setChangedMember(WorkFlowActiveDocC::mbAlertTo);
}
void WorkFlowActiveDoc::setAlertFromBegin(int32_t v) {
	alertFromBegin = v;
	setChangedMember(WorkFlowActiveDocC::mbAlertFromBegin);
}
void WorkFlowActiveDoc::setAlertWait(int32_t v) {
	alertWait = v;
	setChangedMember(WorkFlowActiveDocC::mbAlertWait);
}
void WorkFlowActiveDoc::setYNCondition(::std::wstring v) {
	yNCondition = v;
	setChangedMember(WorkFlowActiveDocC::mbYNCondition);
}
void WorkFlowActiveDoc::setCondition(::std::wstring v) {
	condition = v;
	setChangedMember(WorkFlowActiveDocC::mbCondition);
}
void WorkFlowActiveDoc::setComment(::std::wstring v) {
	comment = v;
	setChangedMember(WorkFlowActiveDocC::mbComment);
}
void WorkFlowActiveDoc::setSucc_0(int32_t v) {
	succ_0 = v;
}
void WorkFlowActiveDoc::setSucc_1(int32_t v) {
	succ_1 = v;
}
void WorkFlowActiveDoc::setSucc_2(int32_t v) {
	succ_2 = v;
}
void WorkFlowActiveDoc::setSucc_3(int32_t v) {
	succ_3 = v;
}
void WorkFlowActiveDoc::setSucc_4(int32_t v) {
	succ_4 = v;
}
void WorkFlowActiveDoc::setSucc_5(int32_t v) {
	succ_5 = v;
}
void WorkFlowActiveDoc::setSucc_6(int32_t v) {
	succ_6 = v;
}
void WorkFlowActiveDoc::setSucc_7(int32_t v) {
	succ_7 = v;
}
void WorkFlowActiveDoc::setSucc_8(int32_t v) {
	succ_8 = v;
}
void WorkFlowActiveDoc::setSucc_9(int32_t v) {
	succ_9 = v;
}
void WorkFlowActiveDoc::setSucc_10(int32_t v) {
	succ_10 = v;
}
void WorkFlowActiveDoc::setSucc_11(int32_t v) {
	succ_11 = v;
}
void WorkFlowActiveDoc::setSucc_12(int32_t v) {
	succ_12 = v;
}
void WorkFlowActiveDoc::setSucc_13(int32_t v) {
	succ_13 = v;
}
void WorkFlowActiveDoc::setSucc_14(int32_t v) {
	succ_14 = v;
}
void WorkFlowActiveDoc::setSucc_15(int32_t v) {
	succ_15 = v;
}
void WorkFlowActiveDoc::setSucc_16(int32_t v) {
	succ_16 = v;
}
void WorkFlowActiveDoc::setSucc_17(int32_t v) {
	succ_17 = v;
}
void WorkFlowActiveDoc::setSucc_18(int32_t v) {
	succ_18 = v;
}
void WorkFlowActiveDoc::setSucc_19(int32_t v) {
	succ_19 = v;
}
void WorkFlowActiveDoc::setLocked(int32_t v) {
	locked = v;
	setChangedMember(WorkFlowActiveDocC::mbLocked);
}
void WorkFlowActiveDoc::setPosX(int32_t v) {
	posX = v;
	setChangedMember(WorkFlowActiveDocC::mbPosX);
}
void WorkFlowActiveDoc::setPosY(int32_t v) {
	posY = v;
	setChangedMember(WorkFlowActiveDocC::mbPosY);
}
void WorkFlowActiveDoc::setOnActivate(::std::wstring v) {
	onActivate = v;
	setChangedMember(WorkFlowActiveDocC::mbOnActivate);
}
void WorkFlowActiveDoc::setOnTerminate(::std::wstring v) {
	onTerminate = v;
	setChangedMember(WorkFlowActiveDocC::mbOnTerminate);
}
void WorkFlowActiveDoc::setNodeFlags(int32_t v) {
	nodeFlags = v;
	setChangedMember(WorkFlowActiveDocC::mbNodeFlags);
}
void WorkFlowActiveDoc::setEloObjId(int32_t v) {
	eloObjId = v;
	setChangedMember(WorkFlowActiveDocC::mbEloObjId);
}
void WorkFlowActiveDoc::setLockId(int32_t v) {
	lockId = v;
	setChangedMember(WorkFlowActiveDocC::mbLockId);
}
void WorkFlowActiveDoc::setIsNext(int32_t v) {
	isNext = v;
	setChangedMember(WorkFlowActiveDocC::mbIsNext);
}
void WorkFlowActiveDoc::setActivate(int32_t v) {
	activate = v;
	setChangedMember(WorkFlowActiveDocC::mbActivate);
}
void WorkFlowActiveDoc::setTerminate(int32_t v) {
	terminate = v;
	setChangedMember(WorkFlowActiveDocC::mbTerminate);
}
void WorkFlowActiveDoc::setInUseDate(int32_t v) {
	inUseDate = v;
	setChangedMember(WorkFlowActiveDocC::mbInUseDate);
}
void WorkFlowActiveDoc::setCompletionDate(int32_t v) {
	completionDate = v;
	setChangedMember(WorkFlowActiveDocC::mbCompletionDate);
}
void WorkFlowActiveDoc::setTemplateId(int32_t v) {
	templateId = v;
	setChangedMember(WorkFlowActiveDocC::mbTemplateId);
}
void WorkFlowActiveDoc::setUserTerminate(::std::wstring v) {
	userTerminate = v;
	setChangedMember(WorkFlowActiveDocC::mbUserTerminate);
}
void WorkFlowActiveDoc::setTag(int32_t v) {
	tag = v;
	setChangedMember(WorkFlowActiveDocC::mbTag);
}
void WorkFlowActiveDoc::setDesignDepartment(int32_t v) {
	designDepartment = v;
	setChangedMember(WorkFlowActiveDocC::mbDesignDepartment);
}
void WorkFlowActiveDoc::setMoveCyclePosX(int32_t v) {
	moveCyclePosX = v;
	setChangedMember(WorkFlowActiveDocC::mbMoveCyclePosX);
}
void WorkFlowActiveDoc::setDepartment2(int32_t v) {
	department2 = v;
	setChangedMember(WorkFlowActiveDocC::mbDepartment2);
}
void WorkFlowActiveDoc::setDelayDays(int32_t v) {
	delayDays = v;
	setChangedMember(WorkFlowActiveDocC::mbDelayDays);
}
void WorkFlowActiveDoc::setDelayDate(int32_t v) {
	delayDate = v;
	setChangedMember(WorkFlowActiveDocC::mbDelayDate);
}
void WorkFlowActiveDoc::setDeleted(int32_t v) {
	deleted = v;
	setChangedMember(WorkFlowActiveDocC::mbDeleted);
}
void WorkFlowActiveDoc::setPrio(int32_t v) {
	prio = v;
	setChangedMember(WorkFlowActiveDocC::mbPrio);
}
void WorkFlowActiveDoc::setUserDelayDate(int32_t v) {
	userDelayDate = v;
	setChangedMember(WorkFlowActiveDocC::mbUserDelayDate);
}
void WorkFlowActiveDoc::setVersionId(int32_t v) {
	versionId = v;
	setChangedMember(WorkFlowActiveDocC::mbVersionId);
}
void WorkFlowActiveDoc::setVersionName(::std::wstring v) {
	versionName = v;
	setChangedMember(WorkFlowActiveDocC::mbVersionName);
}
void WorkFlowActiveDoc::setAlertTo2(int32_t v) {
	alertTo2 = v;
	setChangedMember(WorkFlowActiveDocC::mbAlertTo2);
}
void WorkFlowActiveDoc::setAlertWait2(int32_t v) {
	alertWait2 = v;
	setChangedMember(WorkFlowActiveDocC::mbAlertWait2);
}
void WorkFlowActiveDoc::setAlertTo3(int32_t v) {
	alertTo3 = v;
	setChangedMember(WorkFlowActiveDocC::mbAlertTo3);
}
void WorkFlowActiveDoc::setAlertWait3(int32_t v) {
	alertWait3 = v;
	setChangedMember(WorkFlowActiveDocC::mbAlertWait3);
}
void WorkFlowActiveDoc::setNextServerId(::std::wstring v) {
	nextServerId = v;
	setChangedMember(WorkFlowActiveDocC::mbNextServerId);
}
void WorkFlowActiveDoc::setVersionTag(::std::wstring v) {
	versionTag = v;
	setChangedMember(WorkFlowActiveDocC::mbVersionTag);
}
void WorkFlowActiveDoc::setVersionUserId(int32_t v) {
	versionUserId = v;
	setChangedMember(WorkFlowActiveDocC::mbVersionUserId);
}
void WorkFlowActiveDoc::setVersionCreateDate(int32_t v) {
	versionCreateDate = v;
	setChangedMember(WorkFlowActiveDocC::mbVersionCreateDate);
}
void WorkFlowActiveDoc::setIconId(::std::wstring v) {
	iconId = v;
	setChangedMember(WorkFlowActiveDocC::mbIconId);
}
void WorkFlowActiveDoc::setFormSpec(::std::wstring v) {
	formSpec = v;
	setChangedMember(WorkFlowActiveDocC::mbFormSpec);
}
void WorkFlowActiveDoc::setFlowNameTranslationKey(::std::wstring v) {
	flowNameTranslationKey = v;
	setChangedMember(WorkFlowActiveDocC::mbFlowNameTranslationKey);
}
void WorkFlowActiveDoc::setNameTranslationKey(::std::wstring v) {
	nameTranslationKey = v;
	setChangedMember(WorkFlowActiveDocC::mbNameTranslationKey);
}
void WorkFlowActiveDoc::setCommentTranslationKey(::std::wstring v) {
	commentTranslationKey = v;
	setChangedMember(WorkFlowActiveDocC::mbCommentTranslationKey);
}
void WorkFlowActiveDoc::setLabel(::std::wstring v) {
	label = v;
	setChangedMember(WorkFlowActiveDocC::mbLabel);
}
void WorkFlowActiveDoc::setProperties(::std::wstring v) {
	properties = v;
	setChangedMember(WorkFlowActiveDocC::mbProperties);
}
void WorkFlowActiveDoc::setDepartmentGroup(int32_t v) {
	departmentGroup = v;
	setChangedMember(WorkFlowActiveDocC::mbDepartmentGroup);
}
void WorkFlowActiveDoc::setRetVal(int32_t v) {
	retVal = v;
	setChangedMember(WorkFlowActiveDocC::mbRetVal);
}
void WorkFlowActiveDoc::setReturnValue(::std::wstring v) {
	returnValue = v;
	setChangedMember(WorkFlowActiveDocC::mbReturnValue);
}
void WorkFlowActiveDoc::setSubWorkflow(int32_t v) {
	subWorkflow = v;
	setChangedMember(WorkFlowActiveDocC::mbSubWorkflow);
}
void WorkFlowActiveDoc::setLabelTranslationKey(::std::wstring v) {
	labelTranslationKey = v;
	setChangedMember(WorkFlowActiveDocC::mbLabelTranslationKey);
}
void WorkFlowActiveDoc::setSubWorkflowTemplate(int32_t v) {
	subWorkflowTemplate = v;
	setChangedMember(WorkFlowActiveDocC::mbSubWorkflowTemplate);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WorkFlowActiveDoc::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->activate;
	ar & this->alertFromBegin;
	ar & this->alertTo;
	ar & this->alertWait;
	ar & this->comment;
	ar & this->completionDate;
	ar & this->condition;
	ar & this->delayDate;
	ar & this->delayDays;
	ar & this->deleted;
	ar & this->department;
	ar & this->department2;
	ar & this->designDepartment;
	ar & this->eloObjId;
	ar & this->flowId;
	ar & this->flowName;
	ar & this->inUseDate;
	ar & this->isNext;
	ar & this->labelTranslationKey;
	ar & this->lockId;
	ar & this->locked;
	ar & this->moveCyclePosX;
	ar & this->name;
	ar & this->nodeFlags;
	ar & this->nodeId;
	ar & this->nodeType;
	ar & this->onActivate;
	ar & this->onTerminate;
	ar & this->posX;
	ar & this->posY;
	ar & this->prio;
	ar & this->succType;
	ar & this->succ_0;
	ar & this->succ_1;
	ar & this->succ_10;
	ar & this->succ_11;
	ar & this->succ_12;
	ar & this->succ_13;
	ar & this->succ_14;
	ar & this->succ_15;
	ar & this->succ_16;
	ar & this->succ_17;
	ar & this->succ_18;
	ar & this->succ_19;
	ar & this->succ_2;
	ar & this->succ_3;
	ar & this->succ_4;
	ar & this->succ_5;
	ar & this->succ_6;
	ar & this->succ_7;
	ar & this->succ_8;
	ar & this->succ_9;
	ar & this->tag;
	ar & this->templateId;
	ar & this->terminate;
	ar & this->userTerminate;
	ar & this->yNCondition;
	if (version >= 700000000000000) {
		ar & this->userDelayDate;
		if (version >= 700000000000008) {
			ar & this->versionId;
			ar & this->versionName;
			if (version >= 700000000000014) {
				ar & this->alertTo2;
				ar & this->alertTo3;
				ar & this->alertWait2;
				ar & this->alertWait3;
				ar & this->nextServerId;
				if (version >= 700000000000018) {
					ar & this->versionCreateDate;
					ar & this->versionTag;
					ar & this->versionUserId;
					if (version >= 700000040000012) {
						ar & this->formSpec;
						ar & this->iconId;
						if (version >= 900000018000005) {
							ar & this->commentTranslationKey;
							ar & this->flowNameTranslationKey;
							ar & this->nameTranslationKey;
							if (version >= 900000022000019) {
								ar & this->label;
								ar & this->properties;
								if (version >= 900000030000006) {
									ar & this->departmentGroup;
									if (version >= 900000030000022) {
										ar & this->retVal;
										ar & this->subWorkflow;
										if (version >= 900990009000003) {
											ar & this->returnValue;
											if (version >= 900990009000004) {
												ar & this->subWorkflowTemplate;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1807635378(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WorkFlowActiveDoc>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WorkFlowActiveDocC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WorkFlowActiveDocC::WorkFlowActiveDocC() {
	lnFlowName = 0;
	lnName = 0;
	lnYNCondition = 0;
	lnCondition = 0;
	lnComment = 0;
	lnOnActivate = 0;
	lnOnTerminate = 0;
	lnUserTerminate = 0;
	lnVersionName = 0;
	lnNextServerId = 0;
	lnVersionTag = 0;
	lnIconId = 0;
	lnFormSpec = 0;
	lnFlowNameTranslationKey = 0;
	lnNameTranslationKey = 0;
	lnCommentTranslationKey = 0;
	lnLabel = 0;
	lnProperties = 0;
	lnReturnValue = 0;
	lnLabelTranslationKey = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WorkFlowActiveDocC::WorkFlowActiveDocC(int64_t mbFlowId, int64_t mbNodeId, int64_t mbFlowName, int32_t lnFlowName, int64_t mbName, int32_t lnName, int64_t mbNodeType, int64_t mbDepartment, int64_t mbAlertTo, int64_t mbAlertFromBegin, int64_t mbAlertWait, int64_t mbYNCondition, int32_t lnYNCondition, int64_t mbCondition, int32_t lnCondition, int64_t mbComment, int32_t lnComment, int64_t mbLocked, int64_t mbPosX, int64_t mbPosY, int64_t mbOnActivate, int32_t lnOnActivate, int64_t mbOnTerminate, int32_t lnOnTerminate, int64_t mbNodeFlags, int64_t mbEloObjId, int64_t mbLockId, int64_t mbIsNext, int64_t mbActivate, int64_t mbTerminate, int64_t mbInUseDate, int64_t mbCompletionDate, int64_t mbTemplateId, int64_t mbUserTerminate, int32_t lnUserTerminate, int64_t mbTag, int64_t mbDesignDepartment, int64_t mbMoveCyclePosX, int64_t mbDepartment2, int64_t mbDelayDays, int64_t mbDelayDate, int64_t mbDeleted, int64_t mbPrio, int64_t mbUserDelayDate, int64_t mbVersionId, int64_t mbVersionName, int32_t lnVersionName, int64_t mbAlertTo2, int64_t mbAlertWait2, int64_t mbAlertTo3, int64_t mbAlertWait3, int64_t mbNextServerId, int32_t lnNextServerId, int64_t mbVersionTag, int32_t lnVersionTag, int64_t mbVersionUserId, int64_t mbVersionCreateDate, int64_t mbIconId, int32_t lnIconId, int64_t mbFormSpec, int32_t lnFormSpec, int64_t mbFlowNameTranslationKey, int32_t lnFlowNameTranslationKey, int64_t mbNameTranslationKey, int32_t lnNameTranslationKey, int64_t mbCommentTranslationKey, int32_t lnCommentTranslationKey, int64_t mbLabel, int32_t lnLabel, int64_t mbProperties, int32_t lnProperties, int64_t mbDepartmentGroup, int64_t mbRetVal, int64_t mbReturnValue, int32_t lnReturnValue, int64_t mbSubWorkflow, int64_t mbLabelTranslationKey, int32_t lnLabelTranslationKey, int64_t mbSubWorkflowTemplate, int64_t mbAllMembers)
	: lnFlowName(lnFlowName)
	, lnName(lnName)
	, lnYNCondition(lnYNCondition)
	, lnCondition(lnCondition)
	, lnComment(lnComment)
	, lnOnActivate(lnOnActivate)
	, lnOnTerminate(lnOnTerminate)
	, lnUserTerminate(lnUserTerminate)
	, lnVersionName(lnVersionName)
	, lnNextServerId(lnNextServerId)
	, lnVersionTag(lnVersionTag)
	, lnIconId(lnIconId)
	, lnFormSpec(lnFormSpec)
	, lnFlowNameTranslationKey(lnFlowNameTranslationKey)
	, lnNameTranslationKey(lnNameTranslationKey)
	, lnCommentTranslationKey(lnCommentTranslationKey)
	, lnLabel(lnLabel)
	, lnProperties(lnProperties)
	, lnReturnValue(lnReturnValue)
	, lnLabelTranslationKey(lnLabelTranslationKey)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WorkFlowActiveDocC::BSerializable_getTypeId() {
	return 509854692; 
}
void WorkFlowActiveDocC::setLnFlowName(int32_t v) {
	lnFlowName = v;
}
void WorkFlowActiveDocC::setLnName(int32_t v) {
	lnName = v;
}
void WorkFlowActiveDocC::setLnYNCondition(int32_t v) {
	lnYNCondition = v;
}
void WorkFlowActiveDocC::setLnCondition(int32_t v) {
	lnCondition = v;
}
void WorkFlowActiveDocC::setLnComment(int32_t v) {
	lnComment = v;
}
void WorkFlowActiveDocC::setLnOnActivate(int32_t v) {
	lnOnActivate = v;
}
void WorkFlowActiveDocC::setLnOnTerminate(int32_t v) {
	lnOnTerminate = v;
}
void WorkFlowActiveDocC::setLnUserTerminate(int32_t v) {
	lnUserTerminate = v;
}
void WorkFlowActiveDocC::setLnVersionName(int32_t v) {
	lnVersionName = v;
}
void WorkFlowActiveDocC::setLnNextServerId(int32_t v) {
	lnNextServerId = v;
}
void WorkFlowActiveDocC::setLnVersionTag(int32_t v) {
	lnVersionTag = v;
}
void WorkFlowActiveDocC::setLnIconId(int32_t v) {
	lnIconId = v;
}
void WorkFlowActiveDocC::setLnFormSpec(int32_t v) {
	lnFormSpec = v;
}
void WorkFlowActiveDocC::setLnFlowNameTranslationKey(int32_t v) {
	lnFlowNameTranslationKey = v;
}
void WorkFlowActiveDocC::setLnNameTranslationKey(int32_t v) {
	lnNameTranslationKey = v;
}
void WorkFlowActiveDocC::setLnCommentTranslationKey(int32_t v) {
	lnCommentTranslationKey = v;
}
void WorkFlowActiveDocC::setLnLabel(int32_t v) {
	lnLabel = v;
}
void WorkFlowActiveDocC::setLnProperties(int32_t v) {
	lnProperties = v;
}
void WorkFlowActiveDocC::setLnReturnValue(int32_t v) {
	lnReturnValue = v;
}
void WorkFlowActiveDocC::setLnLabelTranslationKey(int32_t v) {
	lnLabelTranslationKey = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WorkFlowActiveDocC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnComment;
	ar & this->lnCondition;
	ar & this->lnFlowName;
	ar & this->lnLabelTranslationKey;
	ar & this->lnName;
	ar & this->lnOnActivate;
	ar & this->lnOnTerminate;
	ar & this->lnUserTerminate;
	ar & this->lnYNCondition;
	if (version >= 700000000000008) {
		ar & this->lnVersionName;
		if (version >= 700000000000014) {
			ar & this->lnNextServerId;
			if (version >= 700000000000018) {
				ar & this->lnVersionTag;
				if (version >= 700000040000012) {
					ar & this->lnFormSpec;
					ar & this->lnIconId;
					if (version >= 900000018000005) {
						ar & this->lnCommentTranslationKey;
						ar & this->lnFlowNameTranslationKey;
						ar & this->lnNameTranslationKey;
						if (version >= 900000022000019) {
							ar & this->lnLabel;
							ar & this->lnProperties;
							if (version >= 900990009000003) {
								ar & this->lnReturnValue;
							}
						}
					}
				}
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_509854692(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WorkFlowActiveDocC>(bio, pObj, pObjS, pBase);	
}
}}}}
