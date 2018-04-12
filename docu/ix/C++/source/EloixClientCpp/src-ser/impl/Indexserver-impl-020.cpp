#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EloFtStopC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
EloFtStopC::EloFtStopC() {
	lnStopword = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::EloFtStopC::EloFtStopC(int64_t mbStopword, int32_t lnStopword, int64_t mbAllMembers)
	: lnStopword(lnStopword)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EloFtStopC::BSerializable_getTypeId() {
	return 1842033553; 
}
void EloFtStopC::setLnStopword(int32_t v) {
	lnStopword = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EloFtStopC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnStopword;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1842033553(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EloFtStopC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EloIxOpt
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
EloIxOpt::EloIxOpt() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::EloIxOpt::EloIxOpt(const ::std::wstring& name, const ::std::wstring& ixId, const ::std::wstring& value)
	: name(name)
	, ixId(ixId)
	, value(value)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EloIxOpt::BSerializable_getTypeId() {
	return 1454054253; 
}
void EloIxOpt::setName(::std::wstring v) {
	name = v;
	setChangedMember(EloIxOptC::mbName);
}
void EloIxOpt::setIxId(::std::wstring v) {
	ixId = v;
	setChangedMember(EloIxOptC::mbIxId);
}
void EloIxOpt::setValue(::std::wstring v) {
	value = v;
	setChangedMember(EloIxOptC::mbValue);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EloIxOpt::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->ixId;
	ar & this->name;
	ar & this->value;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1454054253(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EloIxOpt>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EloIxOptDataC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
EloIxOptDataC::EloIxOptDataC() {
	lnName = 0;
	lnIxId = 0;
	lnValue = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::EloIxOptDataC::EloIxOptDataC(int64_t mbName, int32_t lnName, int64_t mbIxId, int32_t lnIxId, int64_t mbValue, int32_t lnValue, int64_t mbAllMembers)
	: lnName(lnName)
	, lnIxId(lnIxId)
	, lnValue(lnValue)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EloIxOptDataC::BSerializable_getTypeId() {
	return 1223860309; 
}
void EloIxOptDataC::setLnName(int32_t v) {
	lnName = v;
}
void EloIxOptDataC::setLnIxId(int32_t v) {
	lnIxId = v;
}
void EloIxOptDataC::setLnValue(int32_t v) {
	lnValue = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EloIxOptDataC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnIxId;
	ar & this->lnName;
	ar & this->lnValue;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1223860309(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EloIxOptDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EloIxOptC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
EloIxOptC::EloIxOptC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EloIxOptC::BSerializable_getTypeId() {
	return 149956656; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EloIxOptC::serialize(BIO& ar, const BVERSION version) {
	EloIxOptDataC::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_149956656(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EloIxOptC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EloIxOpt_old
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
EloIxOpt_old::EloIxOpt_old() {
	optNo = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::EloIxOpt_old::EloIxOpt_old(int32_t optNo, const ::std::wstring& optVal, const ::std::wstring& remark)
	: optNo(optNo)
	, optVal(optVal)
	, remark(remark)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EloIxOpt_old::BSerializable_getTypeId() {
	return 399031267; 
}
void EloIxOpt_old::setOptNo(int32_t v) {
	optNo = v;
	setChangedMember(EloIxOpt_oldC::mbOptNo);
}
void EloIxOpt_old::setOptVal(::std::wstring v) {
	optVal = v;
	setChangedMember(EloIxOpt_oldC::mbOptVal);
}
void EloIxOpt_old::setRemark(::std::wstring v) {
	remark = v;
	setChangedMember(EloIxOpt_oldC::mbRemark);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EloIxOpt_old::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->optNo;
	ar & this->optVal;
	ar & this->remark;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_399031267(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EloIxOpt_old>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EloIxOpt_oldC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
EloIxOpt_oldC::EloIxOpt_oldC() {
	lnOptVal = 0;
	lnRemark = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::EloIxOpt_oldC::EloIxOpt_oldC(int64_t mbOptNo, int64_t mbOptVal, int32_t lnOptVal, int64_t mbRemark, int32_t lnRemark, int64_t mbAllMembers)
	: lnOptVal(lnOptVal)
	, lnRemark(lnRemark)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EloIxOpt_oldC::BSerializable_getTypeId() {
	return 1148546611; 
}
void EloIxOpt_oldC::setLnOptVal(int32_t v) {
	lnOptVal = v;
}
void EloIxOpt_oldC::setLnRemark(int32_t v) {
	lnRemark = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EloIxOpt_oldC::serialize(BIO& ar, const BVERSION version) {
	ar & this->lnOptVal;
	ar & this->lnRemark;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1148546611(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EloIxOpt_oldC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class Event
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
Event::Event() {
	busId = 0;
	type = 0;
	param1 = 0;
	id = 0;
	senderId = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::Event::Event(int64_t busId, int64_t type, int64_t param1, const ::std::wstring& param2, int64_t id, int64_t senderId, const PBytes& data, const PAny& any, const ::std::wstring& acl)
	: busId(busId)
	, type(type)
	, param1(param1)
	, param2(param2)
	, id(id)
	, senderId(senderId)
	, data(data)
	, any(any)
	, acl(acl)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::Event::BSerializable_getTypeId() {
	return 877454055; 
}
void Event::setBusId(int64_t v) {
	busId = v;
}
void Event::setType(int64_t v) {
	type = v;
}
void Event::setParam1(int64_t v) {
	param1 = v;
}
void Event::setParam2(::std::wstring v) {
	param2 = v;
}
void Event::setId(int64_t v) {
	id = v;
}
void Event::setSenderId(int64_t v) {
	senderId = v;
}
void Event::setData(PBytes v) {
	data = v;
}
void Event::setAny(PAny v) {
	any = v;
}
void Event::setAcl(::std::wstring v) {
	acl = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void Event::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->busId;
	ar & this->id;
	ar & this->param1;
	ar & this->param2;
	ar & this->senderId;
	ar & this->type;
	if (version >= 800000010000005) {
		ar & this->acl;
	}
	ar & this->any;
	ar & this->data;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_877454055(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::Event>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EventBusC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
EventBusC::EventBusC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EventBusC::BSerializable_getTypeId() {
	return 572745886; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EventBusC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_572745886(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EventBusC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EventBusParams
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
EventBusParams::EventBusParams() {
	noForwardToOtherIxs = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::EventBusParams::EventBusParams(const ::std::wstring& ticket, const ::std::wstring& userId, const ::std::wstring& channelId, bool noForwardToOtherIxs)
	: ticket(ticket)
	, userId(userId)
	, channelId(channelId)
	, noForwardToOtherIxs(noForwardToOtherIxs)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EventBusParams::BSerializable_getTypeId() {
	return 1489333610; 
}
void EventBusParams::setTicket(::std::wstring v) {
	ticket = v;
}
void EventBusParams::setUserId(::std::wstring v) {
	userId = v;
}
void EventBusParams::setChannelId(::std::wstring v) {
	channelId = v;
}
void EventBusParams::setNoForwardToOtherIxs(bool v) {
	noForwardToOtherIxs = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EventBusParams::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->channelId;
	ar & this->ticket;
	ar & this->userId;
	if (version >= 800000032000011) {
		ar & this->noForwardToOtherIxs;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1489333610(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EventBusParams>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EventFilter
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
EventFilter::EventFilter() {
	busId = 0;
	type = 0;
	param1 = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::EventFilter::EventFilter(int64_t busId, int64_t type, int64_t param1, const ::std::wstring& param2)
	: busId(busId)
	, type(type)
	, param1(param1)
	, param2(param2)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EventFilter::BSerializable_getTypeId() {
	return 1095275943; 
}
void EventFilter::setBusId(int64_t v) {
	busId = v;
}
void EventFilter::setType(int64_t v) {
	type = v;
}
void EventFilter::setParam1(int64_t v) {
	param1 = v;
}
void EventFilter::setParam2(::std::wstring v) {
	param2 = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EventFilter::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->busId;
	ar & this->param1;
	ar & this->param2;
	ar & this->type;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1095275943(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EventFilter>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_722503869(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PEventFilter > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class EventListener
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
EventListener::EventListener() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::EventListener::EventListener(const PArrayEventFilter& filters)
	: filters(filters)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::EventListener::BSerializable_getTypeId() {
	return 1005733106; 
}
void EventListener::setFilters(PArrayEventFilter v) {
	filters = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void EventListener::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->filters;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1005733106(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::EventListener>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_910482075(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PEvent > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ExecuteScriptParams
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ExecuteScriptParams::ExecuteScriptParams() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ExecuteScriptParams::ExecuteScriptParams(const ::std::wstring& scriptEngine, const PFileData& scriptCode, const ::std::wstring& scriptString, const ::std::wstring& scriptObjId, const ::std::wstring& functionName, const PArrayString& functionParams)
	: scriptEngine(scriptEngine)
	, scriptCode(scriptCode)
	, scriptString(scriptString)
	, scriptObjId(scriptObjId)
	, functionName(functionName)
	, functionParams(functionParams)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ExecuteScriptParams::BSerializable_getTypeId() {
	return 936440117; 
}
void ExecuteScriptParams::setScriptEngine(::std::wstring v) {
	scriptEngine = v;
}
void ExecuteScriptParams::setScriptCode(PFileData v) {
	scriptCode = v;
}
void ExecuteScriptParams::setScriptString(::std::wstring v) {
	scriptString = v;
}
void ExecuteScriptParams::setScriptObjId(::std::wstring v) {
	scriptObjId = v;
}
void ExecuteScriptParams::setFunctionName(::std::wstring v) {
	functionName = v;
}
void ExecuteScriptParams::setFunctionParams(PArrayString v) {
	functionParams = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ExecuteScriptParams::serialize(BIO& ar, const BVERSION version) {
	ar & this->functionName;
	ar & this->scriptEngine;
	ar & this->scriptObjId;
	ar & this->scriptString;
	ar & this->functionParams;
	ar & this->scriptCode;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_936440117(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ExecuteScriptParams>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ExecuteScriptResult
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ExecuteScriptResult::ExecuteScriptResult() {
	errorLine = 0;
	errorColumn = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ExecuteScriptResult::ExecuteScriptResult(const ::std::wstring& returnedString, const ::std::wstring& errorMessage, int32_t errorLine, int32_t errorColumn)
	: returnedString(returnedString)
	, errorMessage(errorMessage)
	, errorLine(errorLine)
	, errorColumn(errorColumn)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ExecuteScriptResult::BSerializable_getTypeId() {
	return 63967077; 
}
void ExecuteScriptResult::setReturnedString(::std::wstring v) {
	returnedString = v;
}
void ExecuteScriptResult::setErrorMessage(::std::wstring v) {
	errorMessage = v;
}
void ExecuteScriptResult::setErrorLine(int32_t v) {
	errorLine = v;
}
void ExecuteScriptResult::setErrorColumn(int32_t v) {
	errorColumn = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ExecuteScriptResult::serialize(BIO& ar, const BVERSION version) {
	ar & this->errorColumn;
	ar & this->errorLine;
	ar & this->errorMessage;
	ar & this->returnedString;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_63967077(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ExecuteScriptResult>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ExportExtOptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ExportExtOptions::ExportExtOptions() {
	srcType = 0;
	exportDocs = false;
	exportDocsVersions = false;
	exportAttachments = false;
	exportKeywords = false;
	exportReminders = false;
	replaceRefWithOriginal = false;
	exportEncrytedDocs = false;
	exportStructure = false;
	ignoreEmptyFolders = false;
	dateType = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ExportExtOptions::ExportExtOptions(int32_t srcType, const PArrayString& srcList, const ::std::wstring& searchId, bool exportDocs, bool exportDocsVersions, bool exportAttachments, bool exportKeywords, bool exportReminders, bool replaceRefWithOriginal, bool exportEncrytedDocs, bool exportStructure, bool ignoreEmptyFolders, const ::std::wstring& dateStartIso, const ::std::wstring& dateEndIso, int32_t dateType, const PArrayString& masksList)
	: srcType(srcType)
	, srcList(srcList)
	, searchId(searchId)
	, exportDocs(exportDocs)
	, exportDocsVersions(exportDocsVersions)
	, exportAttachments(exportAttachments)
	, exportKeywords(exportKeywords)
	, exportReminders(exportReminders)
	, replaceRefWithOriginal(replaceRefWithOriginal)
	, exportEncrytedDocs(exportEncrytedDocs)
	, exportStructure(exportStructure)
	, ignoreEmptyFolders(ignoreEmptyFolders)
	, dateStartIso(dateStartIso)
	, dateEndIso(dateEndIso)
	, dateType(dateType)
	, masksList(masksList)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ExportExtOptions::BSerializable_getTypeId() {
	return 291967; 
}
void ExportExtOptions::setSrcType(int32_t v) {
	srcType = v;
}
void ExportExtOptions::setSrcList(PArrayString v) {
	srcList = v;
}
void ExportExtOptions::setSearchId(::std::wstring v) {
	searchId = v;
}
void ExportExtOptions::setExportDocs(bool v) {
	exportDocs = v;
}
void ExportExtOptions::setExportDocsVersions(bool v) {
	exportDocsVersions = v;
}
void ExportExtOptions::setExportAttachments(bool v) {
	exportAttachments = v;
}
void ExportExtOptions::setExportKeywords(bool v) {
	exportKeywords = v;
}
void ExportExtOptions::setExportReminders(bool v) {
	exportReminders = v;
}
void ExportExtOptions::setReplaceRefWithOriginal(bool v) {
	replaceRefWithOriginal = v;
}
void ExportExtOptions::setExportEncrytedDocs(bool v) {
	exportEncrytedDocs = v;
}
void ExportExtOptions::setExportStructure(bool v) {
	exportStructure = v;
}
void ExportExtOptions::setIgnoreEmptyFolders(bool v) {
	ignoreEmptyFolders = v;
}
void ExportExtOptions::setDateStartIso(::std::wstring v) {
	dateStartIso = v;
}
void ExportExtOptions::setDateEndIso(::std::wstring v) {
	dateEndIso = v;
}
void ExportExtOptions::setDateType(int32_t v) {
	dateType = v;
}
void ExportExtOptions::setMasksList(PArrayString v) {
	masksList = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ExportExtOptions::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->dateEndIso;
	ar & this->dateStartIso;
	ar & this->dateType;
	ar & this->exportAttachments;
	ar & this->exportDocs;
	ar & this->exportDocsVersions;
	ar & this->exportEncrytedDocs;
	ar & this->exportKeywords;
	ar & this->exportReminders;
	ar & this->replaceRefWithOriginal;
	ar & this->searchId;
	ar & this->srcType;
	if (version >= 900000016000014) {
		ar & this->exportStructure;
		if (version >= 1000000020000009) {
			ar & this->ignoreEmptyFolders;
		}
	}
	ar & this->masksList;
	ar & this->srcList;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_291967(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ExportExtOptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ExportExtOptionsC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ExportExtOptionsC::ExportExtOptionsC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ExportExtOptionsC::BSerializable_getTypeId() {
	return 162646972; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ExportExtOptionsC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_162646972(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ExportExtOptionsC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ExportOptionsC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ExportOptionsC::ExportOptionsC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ExportOptionsC::BSerializable_getTypeId() {
	return 2043834611; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ExportOptionsC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2043834611(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ExportOptionsC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FileData
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FileData::FileData() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FileData::FileData(const ::std::wstring& contentType, const PBytes& data, const PContentStream& stream)
	: contentType(contentType)
	, data(data)
	, stream(stream)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FileData::BSerializable_getTypeId() {
	return 888671717; 
}
void FileData::setContentType(::std::wstring v) {
	contentType = v;
	setChangedMember(FileDataC::mbContentType);
}
void FileData::setData(PBytes v) {
	data = v;
	setChangedMember(FileDataC::mbData);
}
void FileData::setStream(PContentStream v) {
	stream = v;
	setChangedMember(FileDataC::mbStream);
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FileData::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->contentType;
	ar & this->data;
	if (version >= 1000000020000005) {
		ar & this->stream;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_888671717(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FileData>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FileDataC
// Generated from class byps.gen.cpp.GenApiClass

const PFileDataZ FileDataC::mbDataArray = PFileDataZ(new FileDataZ(
	3LL));

const PFileDataZ FileDataC::mbDataStream = PFileDataZ(new FileDataZ(
	5LL));

// checkpoint byps.gen.cpp.GenApiClass:489
FileDataC::FileDataC() {
	lnContentType = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FileDataC::FileDataC(int64_t mbContentType, int64_t mbData, int64_t mbStream, const PFileDataZ& mbDataArray, const PFileDataZ& mbDataStream, int64_t MAX_BLOB_LENGTH, int32_t lnContentType)
	: lnContentType(lnContentType)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FileDataC::BSerializable_getTypeId() {
	return 1011013570; 
}
void FileDataC::setLnContentType(int32_t v) {
	lnContentType = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FileDataC::serialize(BIO& ar, const BVERSION version) {
	if (version >= 1000000020000007) {
		ar & this->lnContentType;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1011013570(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FileDataC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FileDataZ
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FileDataZ::FileDataZ() {
	bset = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FileDataZ::FileDataZ(int64_t bset)
	: bset(bset)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FileDataZ::BSerializable_getTypeId() {
	return 686143141; 
}
void FileDataZ::setBset(int64_t v) {
	bset = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FileDataZ::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->bset;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_686143141(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FileDataZ>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1078168929(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PFileData > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindActivityInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindActivityInfo::FindActivityInfo() {
	senderOrReceiver = false;
	inclGroup = false;
	inclDeputy = false;
	inclDeleted = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindActivityInfo::FindActivityInfo(const ::std::wstring& objId, const ::std::wstring& senderId, const ::std::wstring& receiverId, bool senderOrReceiver, bool inclGroup, bool inclDeputy, bool inclDeleted)
	: objId(objId)
	, senderId(senderId)
	, receiverId(receiverId)
	, senderOrReceiver(senderOrReceiver)
	, inclGroup(inclGroup)
	, inclDeputy(inclDeputy)
	, inclDeleted(inclDeleted)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindActivityInfo::BSerializable_getTypeId() {
	return 1456865464; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindActivityInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->inclDeputy;
	ar & this->inclGroup;
	ar & this->objId;
	ar & this->receiverId;
	ar & this->senderId;
	ar & this->senderOrReceiver;
	if (version >= 800000018000001) {
		ar & this->inclDeleted;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1456865464(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindActivityInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindActivityProjectsInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindActivityProjectsInfo::FindActivityProjectsInfo() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindActivityProjectsInfo::FindActivityProjectsInfo(const ::std::wstring& projectName)
	: projectName(projectName)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindActivityProjectsInfo::BSerializable_getTypeId() {
	return 151574948; 
}
void FindActivityProjectsInfo::setProjectName(::std::wstring v) {
	projectName = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindActivityProjectsInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->projectName;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_151574948(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindActivityProjectsInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindAlertInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindAlertInfo::FindAlertInfo() {
	inclAll = false;
	inclAlam = false;
	inclReminder = false;
	inclInTray = false;
	inclWorkFlow = false;
	inclOthers = false;
	inclSubs = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindAlertInfo::FindAlertInfo(const ::std::wstring& sourceId, const ::std::wstring& destId, bool inclAll, bool inclAlam, bool inclReminder, bool inclInTray, bool inclWorkFlow, bool inclOthers, bool inclSubs, const ::std::wstring& objId, const ::std::wstring& timeIso)
	: sourceId(sourceId)
	, destId(destId)
	, inclAll(inclAll)
	, inclAlam(inclAlam)
	, inclReminder(inclReminder)
	, inclInTray(inclInTray)
	, inclWorkFlow(inclWorkFlow)
	, inclOthers(inclOthers)
	, inclSubs(inclSubs)
	, objId(objId)
	, timeIso(timeIso)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindAlertInfo::BSerializable_getTypeId() {
	return 897433042; 
}
void FindAlertInfo::setSourceId(::std::wstring v) {
	sourceId = v;
}
void FindAlertInfo::setDestId(::std::wstring v) {
	destId = v;
}
void FindAlertInfo::setInclAll(bool v) {
	inclAll = v;
}
void FindAlertInfo::setInclAlam(bool v) {
	inclAlam = v;
}
void FindAlertInfo::setInclReminder(bool v) {
	inclReminder = v;
}
void FindAlertInfo::setInclInTray(bool v) {
	inclInTray = v;
}
void FindAlertInfo::setInclWorkFlow(bool v) {
	inclWorkFlow = v;
}
void FindAlertInfo::setInclOthers(bool v) {
	inclOthers = v;
}
void FindAlertInfo::setInclSubs(bool v) {
	inclSubs = v;
}
void FindAlertInfo::setObjId(::std::wstring v) {
	objId = v;
}
void FindAlertInfo::setTimeIso(::std::wstring v) {
	timeIso = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindAlertInfo::serialize(BIO& ar, const BVERSION version) {
	ar & this->destId;
	ar & this->inclAlam;
	ar & this->inclAll;
	ar & this->inclInTray;
	ar & this->inclOthers;
	ar & this->inclReminder;
	ar & this->inclSubs;
	ar & this->inclWorkFlow;
	ar & this->objId;
	ar & this->sourceId;
	ar & this->timeIso;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_897433042(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindAlertInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindBackgroundThreadOptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindBackgroundThreadOptions::FindBackgroundThreadOptions() {
	inclActiveJobs = false;
	inclFinishedJobs = false;
	inclFullInfo = false;
	sortOrder = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindBackgroundThreadOptions::FindBackgroundThreadOptions(bool inclActiveJobs, bool inclFinishedJobs, bool inclFullInfo, int32_t sortOrder, const PArrayUserInfo& userInfo, const PArrayString& guids, const ::std::wstring& dateAfter, const ::std::wstring& dateBefore)
	: inclActiveJobs(inclActiveJobs)
	, inclFinishedJobs(inclFinishedJobs)
	, inclFullInfo(inclFullInfo)
	, sortOrder(sortOrder)
	, userInfo(userInfo)
	, guids(guids)
	, dateAfter(dateAfter)
	, dateBefore(dateBefore)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindBackgroundThreadOptions::BSerializable_getTypeId() {
	return 1054287589; 
}
void FindBackgroundThreadOptions::setInclActiveJobs(bool v) {
	inclActiveJobs = v;
}
void FindBackgroundThreadOptions::setInclFinishedJobs(bool v) {
	inclFinishedJobs = v;
}
void FindBackgroundThreadOptions::setInclFullInfo(bool v) {
	inclFullInfo = v;
}
void FindBackgroundThreadOptions::setSortOrder(int32_t v) {
	sortOrder = v;
}
void FindBackgroundThreadOptions::setUserInfo(PArrayUserInfo v) {
	userInfo = v;
}
void FindBackgroundThreadOptions::setGuids(PArrayString v) {
	guids = v;
}
void FindBackgroundThreadOptions::setDateAfter(::std::wstring v) {
	dateAfter = v;
}
void FindBackgroundThreadOptions::setDateBefore(::std::wstring v) {
	dateBefore = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindBackgroundThreadOptions::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->dateAfter;
	ar & this->dateBefore;
	ar & this->inclActiveJobs;
	ar & this->inclFinishedJobs;
	ar & this->inclFullInfo;
	ar & this->sortOrder;
	ar & this->guids;
	ar & this->userInfo;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1054287589(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindBackgroundThreadOptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindByAcl
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindByAcl::FindByAcl() {
	distinctAcl = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindByAcl::FindByAcl(bool distinctAcl, const PArrayString& acls)
	: distinctAcl(distinctAcl)
	, acls(acls)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindByAcl::BSerializable_getTypeId() {
	return 1535514212; 
}
void FindByAcl::setDistinctAcl(bool v) {
	distinctAcl = v;
}
void FindByAcl::setAcls(PArrayString v) {
	acls = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindByAcl::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->distinctAcl;
	ar & this->acls;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1535514212(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindByAcl>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindByFulltext
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindByFulltext::FindByFulltext() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindByFulltext::FindByFulltext(const ::std::wstring& term)
	: term(term)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindByFulltext::BSerializable_getTypeId() {
	return 829543678; 
}
void FindByFulltext::setTerm(::std::wstring v) {
	term = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindByFulltext::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->term;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_829543678(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindByFulltext>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindByFulltextCtrl
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindByFulltextCtrl::FindByFulltextCtrl() {
	onlyDocs = false;
	reindex = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindByFulltextCtrl::FindByFulltextCtrl(const ::std::wstring& startTStamp, const ::std::wstring& endTStamp, bool onlyDocs, const ::std::wstring& profileKeyPrefix, bool reindex)
	: startTStamp(startTStamp)
	, endTStamp(endTStamp)
	, onlyDocs(onlyDocs)
	, profileKeyPrefix(profileKeyPrefix)
	, reindex(reindex)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindByFulltextCtrl::BSerializable_getTypeId() {
	return 96165507; 
}
void FindByFulltextCtrl::setStartTStamp(::std::wstring v) {
	startTStamp = v;
}
void FindByFulltextCtrl::setEndTStamp(::std::wstring v) {
	endTStamp = v;
}
void FindByFulltextCtrl::setOnlyDocs(bool v) {
	onlyDocs = v;
}
void FindByFulltextCtrl::setProfileKeyPrefix(::std::wstring v) {
	profileKeyPrefix = v;
}
void FindByFulltextCtrl::setReindex(bool v) {
	reindex = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindByFulltextCtrl::serialize(BIO& ar, const BVERSION version) {
	ar & this->endTStamp;
	ar & this->startTStamp;
	if (version >= 900000040000002) {
		ar & this->onlyDocs;
		ar & this->profileKeyPrefix;
		if (version >= 1000000000000006) {
			ar & this->reindex;
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_96165507(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindByFulltextCtrl>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindByFulltextCtrlResultItem
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindByFulltextCtrlResultItem::FindByFulltextCtrlResultItem() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindByFulltextCtrlResultItem::FindByFulltextCtrlResultItem(const PSord& sord, const ::std::wstring& TStamp, const PNote& note)
	: sord(sord)
	, TStamp(TStamp)
	, note(note)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindByFulltextCtrlResultItem::BSerializable_getTypeId() {
	return 1755682788; 
}
void FindByFulltextCtrlResultItem::setSord(PSord v) {
	sord = v;
}
void FindByFulltextCtrlResultItem::setTStamp(::std::wstring v) {
	TStamp = v;
}
void FindByFulltextCtrlResultItem::setNote(PNote v) {
	note = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindByFulltextCtrlResultItem::serialize(BIO& ar, const BVERSION version) {
	ar & this->TStamp;
	ar & this->sord;
	if (version >= 800000000000003) {
		ar & this->note;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1755682788(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindByFulltextCtrlResultItem>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1980589728(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PFindByFulltextCtrlResultItem > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindByFulltextResultItem
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindByFulltextResultItem::FindByFulltextResultItem() {
	relevance = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindByFulltextResultItem::FindByFulltextResultItem(int32_t relevance, const ::std::wstring& summaryFulltext, const ::std::wstring& summaryDesc, const PArrayString& fieldNames, const PSord& sord)
	: relevance(relevance)
	, summaryFulltext(summaryFulltext)
	, summaryDesc(summaryDesc)
	, fieldNames(fieldNames)
	, sord(sord)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindByFulltextResultItem::BSerializable_getTypeId() {
	return 709720021; 
}
void FindByFulltextResultItem::setRelevance(int32_t v) {
	relevance = v;
}
void FindByFulltextResultItem::setSummaryFulltext(::std::wstring v) {
	summaryFulltext = v;
}
void FindByFulltextResultItem::setSummaryDesc(::std::wstring v) {
	summaryDesc = v;
}
void FindByFulltextResultItem::setFieldNames(PArrayString v) {
	fieldNames = v;
}
void FindByFulltextResultItem::setSord(PSord v) {
	sord = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindByFulltextResultItem::serialize(BIO& ar, const BVERSION version) {
	ar & this->relevance;
	ar & this->summaryDesc;
	ar & this->summaryFulltext;
	ar & this->fieldNames;
	ar & this->sord;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_709720021(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindByFulltextResultItem>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_804274709(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PFindByFulltextResultItem > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindByIndex
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindByIndex::FindByIndex() {
	exactName = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindByIndex::FindByIndex(const ::std::wstring& delDateIso, const ::std::wstring& desc, const ::std::wstring& iDateIso, const ::std::wstring& maskId, const ::std::wstring& name, bool exactName, const PArrayObjKey& objKeys, const ::std::wstring& ownerId, const ::std::wstring& xDateIso, const ::std::wstring& acl, const ::std::wstring& pathId, const ::std::wstring& kind, const ::std::wstring& lockId, const PArrayString& maskIds, const ::std::wstring& deleteUser, const ::std::wstring& deleteDateIso)
	: delDateIso(delDateIso)
	, desc(desc)
	, iDateIso(iDateIso)
	, maskId(maskId)
	, name(name)
	, exactName(exactName)
	, objKeys(objKeys)
	, ownerId(ownerId)
	, xDateIso(xDateIso)
	, acl(acl)
	, pathId(pathId)
	, kind(kind)
	, lockId(lockId)
	, maskIds(maskIds)
	, deleteUser(deleteUser)
	, deleteDateIso(deleteDateIso)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindByIndex::BSerializable_getTypeId() {
	return 1985205034; 
}
void FindByIndex::setDelDateIso(::std::wstring v) {
	delDateIso = v;
}
void FindByIndex::setDesc(::std::wstring v) {
	desc = v;
}
void FindByIndex::setIDateIso(::std::wstring v) {
	iDateIso = v;
}
void FindByIndex::setMaskId(::std::wstring v) {
	maskId = v;
}
void FindByIndex::setName(::std::wstring v) {
	name = v;
}
void FindByIndex::setExactName(bool v) {
	exactName = v;
}
void FindByIndex::setObjKeys(PArrayObjKey v) {
	objKeys = v;
}
void FindByIndex::setOwnerId(::std::wstring v) {
	ownerId = v;
}
void FindByIndex::setXDateIso(::std::wstring v) {
	xDateIso = v;
}
void FindByIndex::setAcl(::std::wstring v) {
	acl = v;
}
void FindByIndex::setPathId(::std::wstring v) {
	pathId = v;
}
void FindByIndex::setKind(::std::wstring v) {
	kind = v;
}
void FindByIndex::setLockId(::std::wstring v) {
	lockId = v;
}
void FindByIndex::setMaskIds(PArrayString v) {
	maskIds = v;
}
void FindByIndex::setDeleteUser(::std::wstring v) {
	deleteUser = v;
}
void FindByIndex::setDeleteDateIso(::std::wstring v) {
	deleteDateIso = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindByIndex::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->delDateIso;
	ar & this->desc;
	ar & this->iDateIso;
	ar & this->maskId;
	ar & this->name;
	ar & this->ownerId;
	ar & this->xDateIso;
	if (version >= 700000000000010) {
		ar & this->acl;
		if (version >= 700000000000035) {
			ar & this->exactName;
			if (version >= 700000000000045) {
				ar & this->pathId;
				if (version >= 800000030000003) {
					ar & this->kind;
					if (version >= 900000000000031) {
						ar & this->lockId;
						if (version >= 1000000020000014) {
							ar & this->deleteDateIso;
							ar & this->deleteUser;
						}
					}
				}
			}
		}
	}
	ar & this->objKeys;
	if (version >= 900000040000003) {
		ar & this->maskIds;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1985205034(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindByIndex>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindByNotes
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindByNotes::FindByNotes() {
	type = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindByNotes::FindByNotes(const ::std::wstring& term, int32_t type)
	: term(term)
	, type(type)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindByNotes::BSerializable_getTypeId() {
	return 735083434; 
}
void FindByNotes::setTerm(::std::wstring v) {
	term = v;
}
void FindByNotes::setType(int32_t v) {
	type = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindByNotes::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->term;
	ar & this->type;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_735083434(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindByNotes>(bio, pObj, pObjS, pBase);	
}
}}}}
