#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class UserProfileC
// Generated from class byps.gen.cpp.GenApiClass

const ::std::wstring UserProfileC::DATE_FORMAT = std::wstring(L"DateFormat");

const ::std::wstring UserProfileC::SORD_DATE_FORMAT = std::wstring(L"DateFormat:Sord");

const ::std::wstring UserProfileC::SORD_IDATE_FORMAT = std::wstring(L"DateFormat:Sord:IDate");

const ::std::wstring UserProfileC::SORD_XDATE_FORMAT = std::wstring(L"DateFormat:Sord:XDate");

const ::std::wstring UserProfileC::SORD_DELDATE_FORMAT = std::wstring(L"DateFormat:Sord:DelDate");

const ::std::wstring UserProfileC::DOC_VERSION_DATE_FORMAT = std::wstring(L"DateFormat:DocVersion");

const ::std::wstring UserProfileC::DOC_VERSION_CREATE_FORMAT = std::wstring(L"DateFormat:DocVersion:createDate");

const ::std::wstring UserProfileC::DOC_VERSION_ACCESS_FORMAT = std::wstring(L"DateFormat:DocVersion:accessDate");

const ::std::wstring UserProfileC::DOC_VERSION_UPDATE_FORMAT = std::wstring(L"DateFormat:DocVersion:updateDate");

const ::std::wstring UserProfileC::USERID_ALL = std::wstring(L"2147483647");

const ::std::wstring UserProfileC::KEY_EXTEND_DOCUMENT_ACCESS_IN_WORKFLOW = std::wstring(L"Client.1386.2.0.Options.ExpandWfRights.");

const ::std::wstring UserProfileC::KEY_PASSWORD_RULES = std::wstring(L"Client.1235.1.0.Options.MinPassword.");

const ::std::wstring UserProfileC::KEY_PASSWORD_VALID_DAYS = std::wstring(L"Client.1215.2.0.Options.PasswordValidInDays.");

const ::std::wstring UserProfileC::KEY_ARCHIVE_LANGUAGE = std::wstring(L"Elo.Search.archivelang");

const ::std::wstring UserProfileC::KEY_FEED_SUBSCRIBE_MYDOC = std::wstring(L"Elo.Feed.subscribe.mydoc");

const ::std::wstring UserProfileC::KEY_FEED_SUBSCRIBE_MYFOLDER = std::wstring(L"Elo.Feed.subscribe.myfolder");

const ::std::wstring UserProfileC::KEY_FEED_SUBSCRIBE_NEWVERSION = std::wstring(L"Elo.Feed.subscribe.newversion");

const ::std::wstring UserProfileC::KEY_FEED_SUBSCRIBE_NEWCOMMENT = std::wstring(L"Elo.Feed.subscribe.newcomment");

const ::std::wstring UserProfileC::KEY_PREFIX_FULLTEXT_SEARCH_OPTIONS = std::wstring(L"Elo.Search.");

// checkpoint byps.gen.cpp.GenApiClass:489
UserProfileC::UserProfileC() {
	lnKey = 0;
	lnValue = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::UserProfileC::UserProfileC(const ::std::wstring& DATE_FORMAT, const ::std::wstring& SORD_DATE_FORMAT, const ::std::wstring& SORD_IDATE_FORMAT, const ::std::wstring& SORD_XDATE_FORMAT, const ::std::wstring& SORD_DELDATE_FORMAT, const ::std::wstring& DOC_VERSION_DATE_FORMAT, const ::std::wstring& DOC_VERSION_CREATE_FORMAT, const ::std::wstring& DOC_VERSION_ACCESS_FORMAT, const ::std::wstring& DOC_VERSION_UPDATE_FORMAT, const ::std::wstring& USERID_ALL, const ::std::wstring& KEY_EXTEND_DOCUMENT_ACCESS_IN_WORKFLOW, const ::std::wstring& KEY_PASSWORD_RULES, const ::std::wstring& KEY_PASSWORD_VALID_DAYS, const ::std::wstring& KEY_ARCHIVE_LANGUAGE, const ::std::wstring& KEY_FEED_SUBSCRIBE_MYDOC, const ::std::wstring& KEY_FEED_SUBSCRIBE_MYFOLDER, const ::std::wstring& KEY_FEED_SUBSCRIBE_NEWVERSION, const ::std::wstring& KEY_FEED_SUBSCRIBE_NEWCOMMENT, const ::std::wstring& KEY_PREFIX_FULLTEXT_SEARCH_OPTIONS, int32_t lnKey, int32_t lnValue)
	: lnKey(lnKey)
	, lnValue(lnValue)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::UserProfileC::BSerializable_getTypeId() {
	return 1968434410; 
}
void UserProfileC::setLnKey(int32_t v) {
	lnKey = v;
}
void UserProfileC::setLnValue(int32_t v) {
	lnValue = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void UserProfileC::serialize(BIO& ar, const BVERSION version) {
	if (version >= 700000000000036) {
		ar & this->lnKey;
		ar & this->lnValue;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1968434410(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::UserProfileC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class UserProfileData
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
UserProfileData::UserProfileData() {
	user = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::UserProfileData::UserProfileData(int32_t user, const ::std::wstring& key, const ::std::wstring& value)
	: user(user)
	, key(key)
	, value(value)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::UserProfileData::BSerializable_getTypeId() {
	return 2015395180; 
}
void UserProfileData::setUser(int32_t v) {
	user = v;
	setChangedMember(UserProfileDataC::mbUser);
}
void UserProfileData::setKey(::std::wstring v) {
	key = v;
	setChangedMember(UserProfileDataC::mbKey);
}
void UserProfileData::setValue(::std::wstring v) {
	value = v;
	setChangedMember(UserProfileDataC::mbValue);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void UserProfileData::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->key;
	ar & this->user;
	ar & this->value;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2015395180(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::UserProfileData>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class UserProfileDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
UserProfileDataC::UserProfileDataC() {
	lnKey = 0;
	lnValue = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::UserProfileDataC::UserProfileDataC(int64_t mbUser, int64_t mbKey, int32_t lnKey, int64_t mbValue, int32_t lnValue, int64_t mbAllMembers)
	: lnKey(lnKey)
	, lnValue(lnValue)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::UserProfileDataC::BSerializable_getTypeId() {
	return 466121473; 
}
void UserProfileDataC::setLnKey(int32_t v) {
	lnKey = v;
}
void UserProfileDataC::setLnValue(int32_t v) {
	lnValue = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void UserProfileDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnKey;
	ar & this->lnValue;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_466121473(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::UserProfileDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class UserTask
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
UserTask::UserTask() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::UserTask::UserTask(const PActivity& activity, const PReminder& reminder, const PWFCollectNode& wfNode, const PSord& sord)
	: activity(activity)
	, reminder(reminder)
	, wfNode(wfNode)
	, sord(sord)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::UserTask::BSerializable_getTypeId() {
	return 1484696239; 
}
void UserTask::setActivity(PActivity v) {
	activity = v;
}
void UserTask::setReminder(PReminder v) {
	reminder = v;
}
void UserTask::setWfNode(PWFCollectNode v) {
	wfNode = v;
}
void UserTask::setSord(PSord v) {
	sord = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void UserTask::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->activity;
	ar & this->reminder;
	ar & this->wfNode;
	if (version >= 800000020000004) {
		ar & this->sord;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1484696239(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::UserTask>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class UserTaskPriorityC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
UserTaskPriorityC::UserTaskPriorityC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::UserTaskPriorityC::BSerializable_getTypeId() {
	return 260320342; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void UserTaskPriorityC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_260320342(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::UserTaskPriorityC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class UserTaskSortOrderC
// Generated from class byps.gen.cpp.GenApiClass

const PUserTaskSortOrderZ UserTaskSortOrderC::PRIORITY_DATE_NAME = PUserTaskSortOrderZ(new UserTaskSortOrderZ(
	0LL));

const PUserTaskSortOrderZ UserTaskSortOrderC::DATE_PRIORITY_NAME = PUserTaskSortOrderZ(new UserTaskSortOrderZ(
	1LL));

const PUserTaskSortOrderZ UserTaskSortOrderC::NAME_PRIORITY_DATE = PUserTaskSortOrderZ(new UserTaskSortOrderZ(
	2LL));

const PUserTaskSortOrderZ UserTaskSortOrderC::PRIORITY_DATE_NAME_INV = PUserTaskSortOrderZ(new UserTaskSortOrderZ(
	4611686018427387904LL));

const PUserTaskSortOrderZ UserTaskSortOrderC::DATE_PRIORITY_NAME_INV = PUserTaskSortOrderZ(new UserTaskSortOrderZ(
	4611686018427387904LL));

const PUserTaskSortOrderZ UserTaskSortOrderC::NAME_PRIORITY_DATE_INV = PUserTaskSortOrderZ(new UserTaskSortOrderZ(
	4611686018427387904LL));

// checkpoint byps.gen.cpp.GenApiClass:489
UserTaskSortOrderC::UserTaskSortOrderC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::UserTaskSortOrderC::BSerializable_getTypeId() {
	return 854117900; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void UserTaskSortOrderC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_854117900(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::UserTaskSortOrderC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class UserTaskSortOrderZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
UserTaskSortOrderZ::UserTaskSortOrderZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::UserTaskSortOrderZ::UserTaskSortOrderZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::UserTaskSortOrderZ::BSerializable_getTypeId() {
	return 1199296467; 
}
void UserTaskSortOrderZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void UserTaskSortOrderZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1199296467(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::UserTaskSortOrderZ>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_829657911(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PUserTask > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ValuesOfObjKey
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ValuesOfObjKey::ValuesOfObjKey() {
	totalCount = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ValuesOfObjKey::ValuesOfObjKey(const PArrayString& values, const PArrayInt& usageCounts, int32_t totalCount)
	: values(values)
	, usageCounts(usageCounts)
	, totalCount(totalCount)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ValuesOfObjKey::BSerializable_getTypeId() {
	return 1153931872; 
}
void ValuesOfObjKey::setValues(PArrayString v) {
	values = v;
}
void ValuesOfObjKey::setUsageCounts(PArrayInt v) {
	usageCounts = v;
}
void ValuesOfObjKey::setTotalCount(int32_t v) {
	totalCount = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ValuesOfObjKey::serialize(BIO& ar, const BVERSION version) {
	ar & this->totalCount;
	ar & this->usageCounts;
	ar & this->values;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1153931872(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ValuesOfObjKey>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ValuesOfObjKeyOptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ValuesOfObjKeyOptions::ValuesOfObjKeyOptions() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ValuesOfObjKeyOptions::BSerializable_getTypeId() {
	return 958310068; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ValuesOfObjKeyOptions::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_958310068(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ValuesOfObjKeyOptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class VtDoc
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
VtDoc::VtDoc() {
	objId = 0;
	docId = 0;
	code = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::VtDoc::VtDoc(int32_t objId, int32_t docId, int32_t code)
	: objId(objId)
	, docId(docId)
	, code(code)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::VtDoc::BSerializable_getTypeId() {
	return 1935852595; 
}
void VtDoc::setObjId(int32_t v) {
	objId = v;
	setChangedMember(VtDocC::mbObjId);
}
void VtDoc::setDocId(int32_t v) {
	docId = v;
	setChangedMember(VtDocC::mbDocId);
}
void VtDoc::setCode(int32_t v) {
	code = v;
	setChangedMember(VtDocC::mbCode);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void VtDoc::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->code;
	ar & this->docId;
	ar & this->objId;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1935852595(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::VtDoc>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class VtDocC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
VtDocC::VtDocC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::VtDocC::BSerializable_getTypeId() {
	return 1585149555; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void VtDocC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1585149555(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::VtDocC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WFCollectNode
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WFCollectNode::WFCollectNode() {
	active = false;
	flowId = 0;
	nodeId = 0;
	objId = 0;
	objType = 0;
	prio = 0;
	userId = 0;
	overTimeLimit = false;
	workflowOwnerId = 0;
	designDepartmentId = 0;
	timeLimit = 0;
	timeLimitUserId = 0;
	overTimeLimitAny = false;
	hidden = false;
	parentFlowId = 0;
	callNodeId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WFCollectNode::WFCollectNode(const ::std::wstring& activateDateIso, bool active, int32_t flowId, const ::std::wstring& flowName, const ::std::wstring& inUseDateIso, int32_t nodeId, const ::std::wstring& nodeName, const ::std::wstring& objGuid, int32_t objId, int32_t objType, int32_t prio, const ::std::wstring& terminateDateIso, int32_t userId, const ::std::wstring& userName, bool overTimeLimit, const ::std::wstring& completionDateIso, const ::std::wstring& userDelayDateIso, const ::std::wstring& flowStatus, const ::std::wstring& timeLimitIso, const PArrayWFTimeLimit& timeLimitEscalations, int32_t workflowOwnerId, const ::std::wstring& workflowOwnerName, int32_t designDepartmentId, const ::std::wstring& designDepartmentName, const ::std::wstring& nodeComment, const ::std::wstring& objName, int32_t timeLimit, int32_t timeLimitUserId, const ::std::wstring& timeLimitUserName, const PArrayWFTimeLimit& timeLimitsWorkflow, const ::std::wstring& activateDateWorkflowIso, const ::std::wstring& formSpec, bool overTimeLimitAny, bool hidden, const ::std::wstring& nodeNameTranslationKey, const ::std::wstring& nodeCommentTranslationKey, const ::std::wstring& flowNameTranslationKey, const ::std::wstring& label, const ::std::wstring& properties, int32_t parentFlowId, const ::std::wstring& labelTranslationKey, int32_t callNodeId)
	: activateDateIso(activateDateIso)
	, active(active)
	, flowId(flowId)
	, flowName(flowName)
	, inUseDateIso(inUseDateIso)
	, nodeId(nodeId)
	, nodeName(nodeName)
	, objGuid(objGuid)
	, objId(objId)
	, objType(objType)
	, prio(prio)
	, terminateDateIso(terminateDateIso)
	, userId(userId)
	, userName(userName)
	, overTimeLimit(overTimeLimit)
	, completionDateIso(completionDateIso)
	, userDelayDateIso(userDelayDateIso)
	, flowStatus(flowStatus)
	, timeLimitIso(timeLimitIso)
	, timeLimitEscalations(timeLimitEscalations)
	, workflowOwnerId(workflowOwnerId)
	, workflowOwnerName(workflowOwnerName)
	, designDepartmentId(designDepartmentId)
	, designDepartmentName(designDepartmentName)
	, nodeComment(nodeComment)
	, objName(objName)
	, timeLimit(timeLimit)
	, timeLimitUserId(timeLimitUserId)
	, timeLimitUserName(timeLimitUserName)
	, timeLimitsWorkflow(timeLimitsWorkflow)
	, activateDateWorkflowIso(activateDateWorkflowIso)
	, formSpec(formSpec)
	, overTimeLimitAny(overTimeLimitAny)
	, hidden(hidden)
	, nodeNameTranslationKey(nodeNameTranslationKey)
	, nodeCommentTranslationKey(nodeCommentTranslationKey)
	, flowNameTranslationKey(flowNameTranslationKey)
	, label(label)
	, properties(properties)
	, parentFlowId(parentFlowId)
	, labelTranslationKey(labelTranslationKey)
	, callNodeId(callNodeId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WFCollectNode::BSerializable_getTypeId() {
	return 1492908819; 
}
void WFCollectNode::setActivateDateIso(::std::wstring v) {
	activateDateIso = v;
}
void WFCollectNode::setActive(bool v) {
	active = v;
}
void WFCollectNode::setFlowId(int32_t v) {
	flowId = v;
}
void WFCollectNode::setFlowName(::std::wstring v) {
	flowName = v;
}
void WFCollectNode::setInUseDateIso(::std::wstring v) {
	inUseDateIso = v;
}
void WFCollectNode::setNodeId(int32_t v) {
	nodeId = v;
}
void WFCollectNode::setNodeName(::std::wstring v) {
	nodeName = v;
}
void WFCollectNode::setObjGuid(::std::wstring v) {
	objGuid = v;
}
void WFCollectNode::setObjId(int32_t v) {
	objId = v;
}
void WFCollectNode::setObjType(int32_t v) {
	objType = v;
}
void WFCollectNode::setPrio(int32_t v) {
	prio = v;
}
void WFCollectNode::setTerminateDateIso(::std::wstring v) {
	terminateDateIso = v;
}
void WFCollectNode::setUserId(int32_t v) {
	userId = v;
}
void WFCollectNode::setUserName(::std::wstring v) {
	userName = v;
}
void WFCollectNode::setOverTimeLimit(bool v) {
	overTimeLimit = v;
}
void WFCollectNode::setCompletionDateIso(::std::wstring v) {
	completionDateIso = v;
}
void WFCollectNode::setUserDelayDateIso(::std::wstring v) {
	userDelayDateIso = v;
}
void WFCollectNode::setFlowStatus(::std::wstring v) {
	flowStatus = v;
}
void WFCollectNode::setTimeLimitIso(::std::wstring v) {
	timeLimitIso = v;
}
void WFCollectNode::setTimeLimitEscalations(PArrayWFTimeLimit v) {
	timeLimitEscalations = v;
}
void WFCollectNode::setWorkflowOwnerId(int32_t v) {
	workflowOwnerId = v;
}
void WFCollectNode::setWorkflowOwnerName(::std::wstring v) {
	workflowOwnerName = v;
}
void WFCollectNode::setDesignDepartmentId(int32_t v) {
	designDepartmentId = v;
}
void WFCollectNode::setDesignDepartmentName(::std::wstring v) {
	designDepartmentName = v;
}
void WFCollectNode::setNodeComment(::std::wstring v) {
	nodeComment = v;
}
void WFCollectNode::setObjName(::std::wstring v) {
	objName = v;
}
void WFCollectNode::setTimeLimit(int32_t v) {
	timeLimit = v;
}
void WFCollectNode::setTimeLimitUserId(int32_t v) {
	timeLimitUserId = v;
}
void WFCollectNode::setTimeLimitUserName(::std::wstring v) {
	timeLimitUserName = v;
}
void WFCollectNode::setTimeLimitsWorkflow(PArrayWFTimeLimit v) {
	timeLimitsWorkflow = v;
}
void WFCollectNode::setActivateDateWorkflowIso(::std::wstring v) {
	activateDateWorkflowIso = v;
}
void WFCollectNode::setFormSpec(::std::wstring v) {
	formSpec = v;
}
void WFCollectNode::setOverTimeLimitAny(bool v) {
	overTimeLimitAny = v;
}
void WFCollectNode::setHidden(bool v) {
	hidden = v;
}
void WFCollectNode::setNodeNameTranslationKey(::std::wstring v) {
	nodeNameTranslationKey = v;
}
void WFCollectNode::setNodeCommentTranslationKey(::std::wstring v) {
	nodeCommentTranslationKey = v;
}
void WFCollectNode::setFlowNameTranslationKey(::std::wstring v) {
	flowNameTranslationKey = v;
}
void WFCollectNode::setLabel(::std::wstring v) {
	label = v;
}
void WFCollectNode::setProperties(::std::wstring v) {
	properties = v;
}
void WFCollectNode::setParentFlowId(int32_t v) {
	parentFlowId = v;
}
void WFCollectNode::setLabelTranslationKey(::std::wstring v) {
	labelTranslationKey = v;
}
void WFCollectNode::setCallNodeId(int32_t v) {
	callNodeId = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WFCollectNode::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->activateDateIso;
	ar & this->active;
	ar & this->flowId;
	ar & this->flowName;
	ar & this->inUseDateIso;
	ar & this->nodeId;
	ar & this->nodeName;
	ar & this->objGuid;
	ar & this->objId;
	ar & this->objType;
	ar & this->prio;
	ar & this->terminateDateIso;
	ar & this->userId;
	ar & this->userName;
	if (version >= 600000098000000) {
		ar & this->completionDateIso;
		ar & this->overTimeLimit;
		if (version >= 700000000000000) {
			ar & this->userDelayDateIso;
			if (version >= 700000000000019) {
				ar & this->flowStatus;
				ar & this->timeLimitIso;
				if (version >= 700000000000047) {
					ar & this->workflowOwnerId;
					ar & this->workflowOwnerName;
					if (version >= 700000020000006) {
						ar & this->designDepartmentId;
						ar & this->designDepartmentName;
						if (version >= 700000026000003) {
							ar & this->nodeComment;
							ar & this->objName;
							if (version >= 800000010000002) {
								ar & this->timeLimit;
								ar & this->timeLimitUserId;
								ar & this->timeLimitUserName;
								if (version >= 800000022000000) {
									ar & this->activateDateWorkflowIso;
									if (version >= 800000024000000) {
										ar & this->formSpec;
										if (version >= 900000016000016) {
											ar & this->overTimeLimitAny;
											if (version >= 900000018000006) {
												ar & this->hidden;
												if (version >= 900000022000012) {
													ar & this->flowNameTranslationKey;
													ar & this->nodeCommentTranslationKey;
													ar & this->nodeNameTranslationKey;
													if (version >= 900000022000018) {
														ar & this->properties;
														if (version >= 900000022000019) {
															ar & this->label;
															if (version >= 900000030000021) {
																ar & this->labelTranslationKey;
																if (version >= 900000030000022) {
																	ar & this->parentFlowId;
																	if (version >= 1000000000000004) {
																		ar & this->callNodeId;
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
					}
				}
			}
		}
	}
	if (version >= 700000000000019) {
		ar & this->timeLimitEscalations;
		if (version >= 800000022000000) {
			ar & this->timeLimitsWorkflow;
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1492908819(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WFCollectNode>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2006133032(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PWFCollectNode > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WFDelegateNodeInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WFDelegateNodeInfo::WFDelegateNodeInfo() {
	nodeId = 0;
	delegateParallel = false;
	delegateNodeMoveX = 0;
	delegateNodeMoveY = 0;
	backNodeMoveX = 0;
	backNodeMoveY = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WFDelegateNodeInfo::WFDelegateNodeInfo(const ::std::wstring& flowId, int32_t nodeId, const ::std::wstring& delegateToUserId, const byps::PVectorString& delegateToUserIds, bool delegateParallel, const ::std::wstring& delegateNodeName, const ::std::wstring& delegateNodeComment, const ::std::wstring& backNodeName, const ::std::wstring& backNodeComment, int32_t delegateNodeMoveX, int32_t delegateNodeMoveY, int32_t backNodeMoveX, int32_t backNodeMoveY, const PWFNodeZ& copyMembersToDelegateNodeZ, const PWFNodeZ& copyMembersToBackNodeZ)
	: flowId(flowId)
	, nodeId(nodeId)
	, delegateToUserId(delegateToUserId)
	, delegateToUserIds(delegateToUserIds)
	, delegateParallel(delegateParallel)
	, delegateNodeName(delegateNodeName)
	, delegateNodeComment(delegateNodeComment)
	, backNodeName(backNodeName)
	, backNodeComment(backNodeComment)
	, delegateNodeMoveX(delegateNodeMoveX)
	, delegateNodeMoveY(delegateNodeMoveY)
	, backNodeMoveX(backNodeMoveX)
	, backNodeMoveY(backNodeMoveY)
	, copyMembersToDelegateNodeZ(copyMembersToDelegateNodeZ)
	, copyMembersToBackNodeZ(copyMembersToBackNodeZ)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WFDelegateNodeInfo::BSerializable_getTypeId() {
	return 20892334; 
}
void WFDelegateNodeInfo::setFlowId(::std::wstring v) {
	flowId = v;
}
void WFDelegateNodeInfo::setNodeId(int32_t v) {
	nodeId = v;
}
void WFDelegateNodeInfo::setDelegateToUserId(::std::wstring v) {
	delegateToUserId = v;
}
void WFDelegateNodeInfo::setDelegateToUserIds(byps::PVectorString v) {
	delegateToUserIds = v;
}
void WFDelegateNodeInfo::setDelegateParallel(bool v) {
	delegateParallel = v;
}
void WFDelegateNodeInfo::setDelegateNodeName(::std::wstring v) {
	delegateNodeName = v;
}
void WFDelegateNodeInfo::setDelegateNodeComment(::std::wstring v) {
	delegateNodeComment = v;
}
void WFDelegateNodeInfo::setBackNodeName(::std::wstring v) {
	backNodeName = v;
}
void WFDelegateNodeInfo::setBackNodeComment(::std::wstring v) {
	backNodeComment = v;
}
void WFDelegateNodeInfo::setDelegateNodeMoveX(int32_t v) {
	delegateNodeMoveX = v;
}
void WFDelegateNodeInfo::setDelegateNodeMoveY(int32_t v) {
	delegateNodeMoveY = v;
}
void WFDelegateNodeInfo::setBackNodeMoveX(int32_t v) {
	backNodeMoveX = v;
}
void WFDelegateNodeInfo::setBackNodeMoveY(int32_t v) {
	backNodeMoveY = v;
}
void WFDelegateNodeInfo::setCopyMembersToDelegateNodeZ(PWFNodeZ v) {
	copyMembersToDelegateNodeZ = v;
}
void WFDelegateNodeInfo::setCopyMembersToBackNodeZ(PWFNodeZ v) {
	copyMembersToBackNodeZ = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WFDelegateNodeInfo::serialize(BIO& ar, const BVERSION version) {
	ar & this->backNodeComment;
	ar & this->backNodeMoveX;
	ar & this->backNodeMoveY;
	ar & this->backNodeName;
	ar & this->delegateNodeComment;
	ar & this->delegateNodeMoveX;
	ar & this->delegateNodeMoveY;
	ar & this->delegateNodeName;
	ar & this->delegateToUserId;
	ar & this->flowId;
	ar & this->nodeId;
	if (version >= 1000000020000008) {
		ar & this->delegateParallel;
	}
	if (version >= 800000000000004) {
		ar & this->copyMembersToBackNodeZ;
		ar & this->copyMembersToDelegateNodeZ;
		if (version >= 1000000020000008) {
			ar & this->delegateToUserIds;
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_20892334(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WFDelegateNodeInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WFDiagram
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WFDiagram::WFDiagram() {
	deleted = false;
	id = 0;
	lockId = 0;
	objType = 0;
	ownerId = 0;
	prio = 0;
	templateId = 0;
	timeLimit = 0;
	timeLimitUserId = 0;
	overTimeLimit = false;
	flags = 0;
	access = 0;
	hidden = false;
	parentFlowId = 0;
	callNodeId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WFDiagram::WFDiagram(const ::std::wstring& acl, const PArrayAclItem& aclItems, const ::std::wstring& completionDateIso, bool deleted, int32_t id, int32_t lockId, const ::std::wstring& lockName, const PWFNodeMatrix& matrix, const ::std::wstring& name, const PArrayWFNode& nodes, const ::std::wstring& objId, int32_t objType, int32_t ownerId, const ::std::wstring& ownerName, int32_t prio, const ::std::wstring& startDateIso, int32_t templateId, const ::std::wstring& templateName, int32_t timeLimit, const ::std::wstring& timeLimitIso, int32_t timeLimitUserId, const ::std::wstring& timeLimitUserName, const PWFTypeZ& type, bool overTimeLimit, int32_t flags, int32_t access, const PWFVersion& version, const ::std::wstring& guid, const ::std::wstring& tStamp, const ::std::wstring& processOnServerId, const PArrayWFTimeLimit& timeLimitEscalations, const ::std::wstring& objName, const ::std::wstring& TStampSync, const ::std::wstring& nameTranslationKey, bool hidden, int32_t parentFlowId, int32_t callNodeId, const PMapIntegerWFDiagram& subWorkflows)
	: acl(acl)
	, aclItems(aclItems)
	, completionDateIso(completionDateIso)
	, deleted(deleted)
	, id(id)
	, lockId(lockId)
	, lockName(lockName)
	, matrix(matrix)
	, name(name)
	, nodes(nodes)
	, objId(objId)
	, objType(objType)
	, ownerId(ownerId)
	, ownerName(ownerName)
	, prio(prio)
	, startDateIso(startDateIso)
	, templateId(templateId)
	, templateName(templateName)
	, timeLimit(timeLimit)
	, timeLimitIso(timeLimitIso)
	, timeLimitUserId(timeLimitUserId)
	, timeLimitUserName(timeLimitUserName)
	, type(type)
	, overTimeLimit(overTimeLimit)
	, flags(flags)
	, access(access)
	, version(version)
	, guid(guid)
	, tStamp(tStamp)
	, processOnServerId(processOnServerId)
	, timeLimitEscalations(timeLimitEscalations)
	, objName(objName)
	, TStampSync(TStampSync)
	, nameTranslationKey(nameTranslationKey)
	, hidden(hidden)
	, parentFlowId(parentFlowId)
	, callNodeId(callNodeId)
	, subWorkflows(subWorkflows)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WFDiagram::BSerializable_getTypeId() {
	return 1663767661; 
}
void WFDiagram::setAcl(::std::wstring v) {
	acl = v;
	setChangedMember(WFDiagramC::mbAcl);
}
void WFDiagram::setAclItems(PArrayAclItem v) {
	aclItems = v;
	setChangedMember(WFDiagramC::mbAclItems);
}
void WFDiagram::setCompletionDateIso(::std::wstring v) {
	completionDateIso = v;
	setChangedMember(WFDiagramC::mbCompletionDateIso);
}
void WFDiagram::setDeleted(bool v) {
	deleted = v;
	setChangedMember(WFDiagramC::mbDeleted);
}
void WFDiagram::setId(int32_t v) {
	id = v;
	setChangedMember(WFDiagramC::mbId);
}
void WFDiagram::setLockId(int32_t v) {
	lockId = v;
	setChangedMember(WFDiagramC::mbLockId);
}
void WFDiagram::setLockName(::std::wstring v) {
	lockName = v;
}
void WFDiagram::setMatrix(PWFNodeMatrix v) {
	matrix = v;
	setChangedMember(WFDiagramC::mbMatrix);
}
void WFDiagram::setName(::std::wstring v) {
	name = v;
	setChangedMember(WFDiagramC::mbName);
}
void WFDiagram::setNodes(PArrayWFNode v) {
	nodes = v;
	setChangedMember(WFDiagramC::mbNodes);
}
void WFDiagram::setObjId(::std::wstring v) {
	objId = v;
	setChangedMember(WFDiagramC::mbObjId);
}
void WFDiagram::setObjType(int32_t v) {
	objType = v;
	setChangedMember(WFDiagramC::mbObjType);
}
void WFDiagram::setOwnerId(int32_t v) {
	ownerId = v;
	setChangedMember(WFDiagramC::mbOwnerId);
}
void WFDiagram::setOwnerName(::std::wstring v) {
	ownerName = v;
	setChangedMember(WFDiagramC::mbOwnerName);
}
void WFDiagram::setPrio(int32_t v) {
	prio = v;
	setChangedMember(WFDiagramC::mbPrio);
}
void WFDiagram::setStartDateIso(::std::wstring v) {
	startDateIso = v;
	setChangedMember(WFDiagramC::mbStartDateIso);
}
void WFDiagram::setTemplateId(int32_t v) {
	templateId = v;
	setChangedMember(WFDiagramC::mbTemplateId);
}
void WFDiagram::setTemplateName(::std::wstring v) {
	templateName = v;
	setChangedMember(WFDiagramC::mbTemplateName);
}
void WFDiagram::setTimeLimit(int32_t v) {
	timeLimit = v;
	setChangedMember(WFDiagramC::mbTimeLimitUserId);
}
void WFDiagram::setTimeLimitIso(::std::wstring v) {
	timeLimitIso = v;
	setChangedMember(WFDiagramC::mbTimeLimitIso);
}
void WFDiagram::setTimeLimitUserId(int32_t v) {
	timeLimitUserId = v;
	setChangedMember(WFDiagramC::mbTimeLimitUserId);
}
void WFDiagram::setTimeLimitUserName(::std::wstring v) {
	timeLimitUserName = v;
	setChangedMember(WFDiagramC::mbTimeLimitUserName);
}
void WFDiagram::setType(PWFTypeZ v) {
	type = v;
	setChangedMember(WFDiagramC::mbType);
}
void WFDiagram::setOverTimeLimit(bool v) {
	overTimeLimit = v;
}
void WFDiagram::setFlags(int32_t v) {
	flags = v;
	setChangedMember(WFDiagramC::mbFlags);
}
void WFDiagram::setAccess(int32_t v) {
	access = v;
	setChangedMember(WFDiagramC::mbAccess);
}
void WFDiagram::setVersion(PWFVersion v) {
	version = v;
	setChangedMember(WFDiagramC::mbVersion);
}
void WFDiagram::setGuid(::std::wstring v) {
	guid = v;
	setChangedMember(WFDiagramC::mbGuid);
}
void WFDiagram::setTStamp(::std::wstring v) {
	tStamp = v;
	setChangedMember(WFDiagramC::mbTStamp);
}
void WFDiagram::setProcessOnServerId(::std::wstring v) {
	processOnServerId = v;
	setChangedMember(WFDiagramC::mbProcessOnServerId);
}
void WFDiagram::setTimeLimitEscalations(PArrayWFTimeLimit v) {
	timeLimitEscalations = v;
	setChangedMember(WFDiagramC::mbTimeLimitEscalations);
}
void WFDiagram::setObjName(::std::wstring v) {
	objName = v;
	setChangedMember(WFDiagramC::mbObjName);
}
void WFDiagram::setTStampSync(::std::wstring v) {
	TStampSync = v;
	setChangedMember(WFDiagramC::mbTStampSync);
}
void WFDiagram::setNameTranslationKey(::std::wstring v) {
	nameTranslationKey = v;
	setChangedMember(WFDiagramC::mbNameTranslationKey);
}
void WFDiagram::setHidden(bool v) {
	hidden = v;
}
void WFDiagram::setParentFlowId(int32_t v) {
	parentFlowId = v;
}
void WFDiagram::setCallNodeId(int32_t v) {
	callNodeId = v;
	setChangedMember(WFDiagramC::mbCallNodeId);
}
void WFDiagram::setSubWorkflows(PMapIntegerWFDiagram v) {
	subWorkflows = v;
	setChangedMember(WFDiagramC::mbSubWorkflows);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WFDiagram::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->acl;
	ar & this->completionDateIso;
	ar & this->deleted;
	ar & this->id;
	ar & this->lockId;
	ar & this->lockName;
	ar & this->name;
	ar & this->objId;
	ar & this->objType;
	ar & this->ownerId;
	ar & this->ownerName;
	ar & this->prio;
	ar & this->startDateIso;
	ar & this->templateId;
	ar & this->templateName;
	ar & this->timeLimit;
	ar & this->timeLimitIso;
	ar & this->timeLimitUserId;
	ar & this->timeLimitUserName;
	if (version >= 600000096000000) {
		ar & this->overTimeLimit;
		if (version >= 600000098000000) {
			ar & this->flags;
			if (version >= 700000000000007) {
				ar & this->access;
				if (version >= 700000000000010) {
					ar & this->guid;
					ar & this->tStamp;
					if (version >= 700000000000015) {
						ar & this->processOnServerId;
						if (version >= 700000026000003) {
							ar & this->objName;
							if (version >= 900000018000005) {
								ar & this->nameTranslationKey;
								if (version >= 900000018000006) {
									ar & this->hidden;
									if (version >= 900000030000022) {
										ar & this->parentFlowId;
										if (version >= 900990009000001) {
											ar & this->TStampSync;
											if (version >= 1000000000000004) {
												ar & this->callNodeId;
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
	ar & this->aclItems;
	ar & this->matrix;
	ar & this->nodes;
	ar & this->type;
	if (version >= 700000000000008) {
		ar & this->version;
		if (version >= 700000000000016) {
			ar & this->timeLimitEscalations;
			if (version >= 900000030000022) {
				ar & this->subWorkflows;
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1663767661(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WFDiagram>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WFDiagramC
// Generated from class byps.gen.cpp.GenApiClass

const ::std::wstring WFDiagramC::ADHOC_WF_FINISH_SCRIPT_PREFIX = std::wstring(L"adhoc_");

const PWFDiagramZ WFDiagramC::mbLean = PWFDiagramZ(new WFDiagramZ(
	268435359LL));

const PWFDiagramZ WFDiagramC::mbAll = PWFDiagramZ(new WFDiagramZ(
	268435455LL));

const PWFDiagramZ WFDiagramC::mbOnlyLock = PWFDiagramZ(new WFDiagramZ(
	4096LL));

// checkpoint byps.gen.cpp.GenApiClass:489
WFDiagramC::WFDiagramC() {
	lnName = 0;
	lnGuid = 0;
	lnTStamp = 0;
	lnProcessOnServerId = 0;
	lnNameTranslationKey = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WFDiagramC::WFDiagramC(int32_t MAX_SUBNODES, int64_t mbId, int64_t mbName, int32_t lnName, int64_t mbObjId, int64_t mbObjType, int64_t mbCompletionDate, int64_t mbNodes, int64_t mbMatrix, int64_t mbTimeLimitUserId, int64_t mbTimeLimit, int64_t mbStartDate, int64_t mbAcl, int64_t mbOwnerId, int64_t mbLockId, int64_t mbPrio, int64_t mbDeleted, int64_t mbTemplateId, int64_t mbFlags, int64_t mbAccess, int64_t mbVersion, int64_t mbGuid, int32_t lnGuid, int64_t mbTStamp, int32_t lnTStamp, int64_t mbProcessOnServerId, int32_t lnProcessOnServerId, int64_t mbTimeLimitEscalations, int64_t mbObjName, int64_t mbNodesOverview, int64_t mbTStampSync, int32_t lnNameTranslationKey, int64_t mbNameTranslationKey, int64_t mbSubWorkflows, int64_t mbCallNodeId, const ::std::wstring& ADHOC_WF_FINISH_SCRIPT_PREFIX, int64_t mbAllMembers, int64_t mbLeanMembers, const PWFDiagramZ& mbLean, const PWFDiagramZ& mbAll, const PWFDiagramZ& mbOnlyLock, int64_t mbAclItems, int64_t mbCompletionDateIso, int64_t mbOwnerName, int64_t mbStartDateIso, int64_t mbTemplateName, int64_t mbTimeLimitIso, int64_t mbTimeLimitUserName, int64_t mbType, int32_t TEMPLATE_ID_ADHOC)
	: lnName(lnName)
	, lnGuid(lnGuid)
	, lnTStamp(lnTStamp)
	, lnProcessOnServerId(lnProcessOnServerId)
	, lnNameTranslationKey(lnNameTranslationKey)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WFDiagramC::BSerializable_getTypeId() {
	return 1231341428; 
}
void WFDiagramC::setLnName(int32_t v) {
	lnName = v;
}
void WFDiagramC::setLnGuid(int32_t v) {
	lnGuid = v;
}
void WFDiagramC::setLnTStamp(int32_t v) {
	lnTStamp = v;
}
void WFDiagramC::setLnProcessOnServerId(int32_t v) {
	lnProcessOnServerId = v;
}
void WFDiagramC::setLnNameTranslationKey(int32_t v) {
	lnNameTranslationKey = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WFDiagramC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnName;
	if (version >= 700000000000010) {
		ar & this->lnGuid;
		ar & this->lnTStamp;
		if (version >= 700000000000015) {
			ar & this->lnProcessOnServerId;
			if (version >= 900000018000005) {
				ar & this->lnNameTranslationKey;
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1231341428(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WFDiagramC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WFDiagramZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WFDiagramZ::WFDiagramZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WFDiagramZ::WFDiagramZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WFDiagramZ::BSerializable_getTypeId() {
	return 1717407429; 
}
void WFDiagramZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WFDiagramZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1717407429(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WFDiagramZ>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_838894319(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PWFDiagram > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WFEditNode
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WFEditNode::WFEditNode() {
	flowId = 0;
	nodeId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WFEditNode::WFEditNode(int32_t flowId, const PWFNode& node, int32_t nodeId, const PArrayWFNode& succNodes)
	: flowId(flowId)
	, node(node)
	, nodeId(nodeId)
	, succNodes(succNodes)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WFEditNode::BSerializable_getTypeId() {
	return 1822579866; 
}
void WFEditNode::setFlowId(int32_t v) {
	flowId = v;
}
void WFEditNode::setNode(PWFNode v) {
	node = v;
}
void WFEditNode::setNodeId(int32_t v) {
	nodeId = v;
}
void WFEditNode::setSuccNodes(PArrayWFNode v) {
	succNodes = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WFEditNode::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->flowId;
	ar & this->nodeId;
	ar & this->node;
	ar & this->succNodes;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1822579866(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WFEditNode>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class WFNode
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
WFNode::WFNode() {
	allowActivate = false;
	delayDays = 0;
	department2 = 0;
	designDepartment = 0;
	flags = 0;
	id = 0;
	isNext = 0;
	moveCyclePosX = 0;
	nbOfDonesToExit = 0;
	posX = 0;
	posY = 0;
	tag = 0;
	timeLimit = 0;
	type = 0;
	userId = 0;
	overTimeLimit = false;
	departmentGroup = 0;
	subFlowId = 0;
	retVal = 0;
	subTemplateId = 0;
	prio = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::WFNode::WFNode(bool allowActivate, const ::std::wstring& comment, int32_t delayDays, int32_t department2, int32_t designDepartment, const ::std::wstring& enterDateIso, const ::std::wstring& exitDateIso, int32_t flags, int32_t id, const ::std::wstring& inUseDateIso, int32_t isNext, int32_t moveCyclePosX, const ::std::wstring& name, int32_t nbOfDonesToExit, const ::std::wstring& onEnter, const ::std::wstring& onExit, int32_t posX, int32_t posY, int32_t tag, int32_t timeLimit, const ::std::wstring& timeLimitIso, int32_t type, int32_t userId, const ::std::wstring& userName, const ::std::wstring& userTerminate, const ::std::wstring& yesNoCondition, const ::std::wstring& delayDateIso, bool overTimeLimit, const ::std::wstring& userDelayDateIso, const ::std::wstring& processOnServerId, const PArrayWFTimeLimit& timeLimitEscalations, const PArrayString& objKeyNames, const PArrayString& scriptNames, const ::std::wstring& iconId, const ::std::wstring& formSpec, const ::std::wstring& nameTranslationKey, const ::std::wstring& commentTranslationKey, const ::std::wstring& label, const ::std::wstring& properties, int32_t departmentGroup, int32_t subFlowId, int32_t retVal, const ::std::wstring& returnValue, const ::std::wstring& labelTranslationKey, int32_t subTemplateId, int32_t prio)
	: allowActivate(allowActivate)
	, comment(comment)
	, delayDays(delayDays)
	, department2(department2)
	, designDepartment(designDepartment)
	, enterDateIso(enterDateIso)
	, exitDateIso(exitDateIso)
	, flags(flags)
	, id(id)
	, inUseDateIso(inUseDateIso)
	, isNext(isNext)
	, moveCyclePosX(moveCyclePosX)
	, name(name)
	, nbOfDonesToExit(nbOfDonesToExit)
	, onEnter(onEnter)
	, onExit(onExit)
	, posX(posX)
	, posY(posY)
	, tag(tag)
	, timeLimit(timeLimit)
	, timeLimitIso(timeLimitIso)
	, type(type)
	, userId(userId)
	, userName(userName)
	, userTerminate(userTerminate)
	, yesNoCondition(yesNoCondition)
	, delayDateIso(delayDateIso)
	, overTimeLimit(overTimeLimit)
	, userDelayDateIso(userDelayDateIso)
	, processOnServerId(processOnServerId)
	, timeLimitEscalations(timeLimitEscalations)
	, objKeyNames(objKeyNames)
	, scriptNames(scriptNames)
	, iconId(iconId)
	, formSpec(formSpec)
	, nameTranslationKey(nameTranslationKey)
	, commentTranslationKey(commentTranslationKey)
	, label(label)
	, properties(properties)
	, departmentGroup(departmentGroup)
	, subFlowId(subFlowId)
	, retVal(retVal)
	, returnValue(returnValue)
	, labelTranslationKey(labelTranslationKey)
	, subTemplateId(subTemplateId)
	, prio(prio)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::WFNode::BSerializable_getTypeId() {
	return 2015686193; 
}
void WFNode::setAllowActivate(bool v) {
	allowActivate = v;
}
void WFNode::setComment(::std::wstring v) {
	comment = v;
	setChangedMember(WFNodeC::mbComment);
}
void WFNode::setDelayDays(int32_t v) {
	delayDays = v;
	setChangedMember(WFNodeC::mbDelayDays);
}
void WFNode::setDepartment2(int32_t v) {
	department2 = v;
	setChangedMember(WFNodeC::mbDepartment2);
}
void WFNode::setDesignDepartment(int32_t v) {
	designDepartment = v;
	setChangedMember(WFNodeC::mbDesignDepartment);
}
void WFNode::setEnterDateIso(::std::wstring v) {
	enterDateIso = v;
	setChangedMember(WFNodeC::mbEnterDateIso);
}
void WFNode::setExitDateIso(::std::wstring v) {
	exitDateIso = v;
	setChangedMember(WFNodeC::mbExitDateIso);
}
void WFNode::setFlags(int32_t v) {
	flags = v;
	setChangedMember(WFNodeC::mbFlags);
}
void WFNode::setId(int32_t v) {
	id = v;
	setChangedMember(WFNodeC::mbId);
}
void WFNode::setInUseDateIso(::std::wstring v) {
	inUseDateIso = v;
	setChangedMember(WFNodeC::mbInUseDateIso);
}
void WFNode::setIsNext(int32_t v) {
	isNext = v;
	setChangedMember(WFNodeC::mbIsNext);
}
void WFNode::setMoveCyclePosX(int32_t v) {
	moveCyclePosX = v;
	setChangedMember(WFNodeC::mbMoveCyclePosX);
}
void WFNode::setName(::std::wstring v) {
	name = v;
	setChangedMember(WFNodeC::mbName);
}
void WFNode::setNbOfDonesToExit(int32_t v) {
	nbOfDonesToExit = v;
	setChangedMember(WFNodeC::mbNbOfDonesToExit);
}
void WFNode::setOnEnter(::std::wstring v) {
	onEnter = v;
	setChangedMember(WFNodeC::mbOnEnter);
}
void WFNode::setOnExit(::std::wstring v) {
	onExit = v;
	setChangedMember(WFNodeC::mbOnExit);
}
void WFNode::setPosX(int32_t v) {
	posX = v;
	setChangedMember(WFNodeC::mbPosX);
}
void WFNode::setPosY(int32_t v) {
	posY = v;
	setChangedMember(WFNodeC::mbPosY);
}
void WFNode::setTag(int32_t v) {
	tag = v;
	setChangedMember(WFNodeC::mbTag);
}
void WFNode::setTimeLimit(int32_t v) {
	timeLimit = v;
	setChangedMember(WFNodeC::mbTimeLimit);
}
void WFNode::setTimeLimitIso(::std::wstring v) {
	timeLimitIso = v;
	setChangedMember(WFNodeC::mbTimeLimitIso);
}
void WFNode::setType(int32_t v) {
	type = v;
	setChangedMember(WFNodeC::mbType);
}
void WFNode::setUserId(int32_t v) {
	userId = v;
	setChangedMember(WFNodeC::mbUserId);
}
void WFNode::setUserName(::std::wstring v) {
	userName = v;
	setChangedMember(WFNodeC::mbUserName);
}
void WFNode::setUserTerminate(::std::wstring v) {
	userTerminate = v;
	setChangedMember(WFNodeC::mbUserTerminate);
}
void WFNode::setYesNoCondition(::std::wstring v) {
	yesNoCondition = v;
	setChangedMember(WFNodeC::mbYesNoCondition);
}
void WFNode::setDelayDateIso(::std::wstring v) {
	delayDateIso = v;
	setChangedMember(WFNodeC::mbDelayDateIso);
}
void WFNode::setOverTimeLimit(bool v) {
	overTimeLimit = v;
}
void WFNode::setUserDelayDateIso(::std::wstring v) {
	userDelayDateIso = v;
	setChangedMember(WFNodeC::mbUserDelayDateIso);
}
void WFNode::setProcessOnServerId(::std::wstring v) {
	processOnServerId = v;
	setChangedMember(WFNodeC::mbProcessOnServerId);
}
void WFNode::setTimeLimitEscalations(PArrayWFTimeLimit v) {
	timeLimitEscalations = v;
	setChangedMember(WFNodeC::mbTimeLimitEscalations);
}
void WFNode::setObjKeyNames(PArrayString v) {
	objKeyNames = v;
	setChangedMember(WFNodeC::mbObjKeyNames);
}
void WFNode::setScriptNames(PArrayString v) {
	scriptNames = v;
	setChangedMember(WFNodeC::mbScriptNames);
}
void WFNode::setIconId(::std::wstring v) {
	iconId = v;
	setChangedMember(WFNodeC::mbIconId);
}
void WFNode::setFormSpec(::std::wstring v) {
	formSpec = v;
	setChangedMember(WFNodeC::mbFormSpec);
}
void WFNode::setNameTranslationKey(::std::wstring v) {
	nameTranslationKey = v;
	setChangedMember(WFNodeC::mbNameTranslationKey);
}
void WFNode::setCommentTranslationKey(::std::wstring v) {
	commentTranslationKey = v;
	setChangedMember(WFNodeC::mbCommentTranslationKey);
}
void WFNode::setLabel(::std::wstring v) {
	label = v;
	setChangedMember(WFNodeC::mbLabel);
}
void WFNode::setProperties(::std::wstring v) {
	properties = v;
	setChangedMember(WFNodeC::mbProperties);
}
void WFNode::setDepartmentGroup(int32_t v) {
	departmentGroup = v;
	setChangedMember(WFNodeC::mbDepartmentGroup);
}
void WFNode::setSubFlowId(int32_t v) {
	subFlowId = v;
	setChangedMember(WFNodeC::mbSubFlowId);
}
void WFNode::setRetVal(int32_t v) {
	retVal = v;
	setChangedMember(WFNodeC::mbRetVal);
}
void WFNode::setReturnValue(::std::wstring v) {
	returnValue = v;
	setChangedMember(WFNodeC::mbReturnValue);
}
void WFNode::setLabelTranslationKey(::std::wstring v) {
	labelTranslationKey = v;
	setChangedMember(WFNodeC::mbLabelTranslationKey);
}
void WFNode::setSubTemplateId(int32_t v) {
	subTemplateId = v;
	setChangedMember(WFNodeC::mbSubTemplateId);
}
void WFNode::setPrio(int32_t v) {
	prio = v;
	setChangedMember(WFNodeC::mbPrio);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void WFNode::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->allowActivate;
	ar & this->comment;
	ar & this->delayDateIso;
	ar & this->delayDays;
	ar & this->department2;
	ar & this->designDepartment;
	ar & this->enterDateIso;
	ar & this->exitDateIso;
	ar & this->flags;
	ar & this->id;
	ar & this->inUseDateIso;
	ar & this->isNext;
	ar & this->moveCyclePosX;
	ar & this->name;
	ar & this->nbOfDonesToExit;
	ar & this->onEnter;
	ar & this->onExit;
	ar & this->posX;
	ar & this->posY;
	ar & this->tag;
	ar & this->timeLimit;
	ar & this->timeLimitIso;
	ar & this->type;
	ar & this->userId;
	ar & this->userName;
	ar & this->userTerminate;
	ar & this->yesNoCondition;
	if (version >= 600000098000000) {
		ar & this->overTimeLimit;
		if (version >= 700000000000000) {
			ar & this->userDelayDateIso;
			if (version >= 700000000000015) {
				ar & this->processOnServerId;
				if (version >= 700000040000012) {
					ar & this->formSpec;
					ar & this->iconId;
					if (version >= 900000018000005) {
						ar & this->commentTranslationKey;
						ar & this->nameTranslationKey;
						if (version >= 900000022000018) {
							ar & this->properties;
							if (version >= 900000022000019) {
								ar & this->label;
								if (version >= 900000030000006) {
									ar & this->departmentGroup;
									if (version >= 900000030000021) {
										ar & this->labelTranslationKey;
										if (version >= 900000030000022) {
											ar & this->retVal;
											ar & this->subFlowId;
											if (version >= 900990009000003) {
												ar & this->returnValue;
												if (version >= 900990009000004) {
													ar & this->subTemplateId;
													if (version >= 900990009000005) {
														ar & this->prio;
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
	}
	if (version >= 700000000000016) {
		ar & this->timeLimitEscalations;
		if (version >= 700000000000021) {
			ar & this->objKeyNames;
			ar & this->scriptNames;
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2015686193(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::WFNode>(bio, pObj, pObjS, pBase);	
}
}}}}
