#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FindWorkflowInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FindWorkflowInfo::FindWorkflowInfo() {
	overTimeLimit = false;
	inclDeleted = false;
	inclHidden = false;
	excludeUserGroups = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FindWorkflowInfo::FindWorkflowInfo(const PArrayString& userIds, const ::std::wstring& name, const PWFTypeZ& type, bool overTimeLimit, const ::std::wstring& objId, const ::std::wstring& startDateIso, const ::std::wstring& completionDateIso, const ::std::wstring& templateId, bool inclDeleted, const PArrayString& ownerIds, const PArrayString& activeUserIds, bool inclHidden, const PSordZ& sordZ, bool excludeUserGroups)
	: userIds(userIds)
	, name(name)
	, type(type)
	, overTimeLimit(overTimeLimit)
	, objId(objId)
	, startDateIso(startDateIso)
	, completionDateIso(completionDateIso)
	, templateId(templateId)
	, inclDeleted(inclDeleted)
	, ownerIds(ownerIds)
	, activeUserIds(activeUserIds)
	, inclHidden(inclHidden)
	, sordZ(sordZ)
	, excludeUserGroups(excludeUserGroups)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FindWorkflowInfo::BSerializable_getTypeId() {
	return 1768797010; 
}
void FindWorkflowInfo::setUserIds(PArrayString v) {
	userIds = v;
}
void FindWorkflowInfo::setName(::std::wstring v) {
	name = v;
}
void FindWorkflowInfo::setType(PWFTypeZ v) {
	type = v;
}
void FindWorkflowInfo::setOverTimeLimit(bool v) {
	overTimeLimit = v;
}
void FindWorkflowInfo::setObjId(::std::wstring v) {
	objId = v;
}
void FindWorkflowInfo::setStartDateIso(::std::wstring v) {
	startDateIso = v;
}
void FindWorkflowInfo::setCompletionDateIso(::std::wstring v) {
	completionDateIso = v;
}
void FindWorkflowInfo::setTemplateId(::std::wstring v) {
	templateId = v;
}
void FindWorkflowInfo::setInclDeleted(bool v) {
	inclDeleted = v;
}
void FindWorkflowInfo::setOwnerIds(PArrayString v) {
	ownerIds = v;
}
void FindWorkflowInfo::setActiveUserIds(PArrayString v) {
	activeUserIds = v;
}
void FindWorkflowInfo::setInclHidden(bool v) {
	inclHidden = v;
}
void FindWorkflowInfo::setSordZ(PSordZ v) {
	sordZ = v;
}
void FindWorkflowInfo::setExcludeUserGroups(bool v) {
	excludeUserGroups = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FindWorkflowInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	if (version >= 600000098000000) {
		ar & this->completionDateIso;
		ar & this->inclDeleted;
		ar & this->name;
		ar & this->objId;
		ar & this->overTimeLimit;
		ar & this->startDateIso;
		ar & this->templateId;
		if (version >= 900000018000006) {
			ar & this->inclHidden;
			if (version >= 1000000000000001) {
				ar & this->excludeUserGroups;
			}
		}
	}
	ar & this->userIds;
	if (version >= 600000098000000) {
		ar & this->type;
		if (version >= 700000020000007) {
			ar & this->activeUserIds;
			ar & this->ownerIds;
			if (version >= 900990009000007) {
				ar & this->sordZ;
			}
		}
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1768797010(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FindWorkflowInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FontInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FontInfo::FontInfo() {
	bold = false;
	italic = false;
	strikeOut = false;
	underline = false;
	RGB = 0;
	height = 0;
	heightPerCell = false;
	escapement = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FontInfo::FontInfo(const ::std::wstring& faceName, bool bold, bool italic, bool strikeOut, bool underline, int32_t RGB, int32_t height, bool heightPerCell, int32_t escapement)
	: faceName(faceName)
	, bold(bold)
	, italic(italic)
	, strikeOut(strikeOut)
	, underline(underline)
	, RGB(RGB)
	, height(height)
	, heightPerCell(heightPerCell)
	, escapement(escapement)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FontInfo::BSerializable_getTypeId() {
	return 1478273890; 
}
void FontInfo::setFaceName(::std::wstring v) {
	faceName = v;
}
void FontInfo::setBold(bool v) {
	bold = v;
}
void FontInfo::setItalic(bool v) {
	italic = v;
}
void FontInfo::setStrikeOut(bool v) {
	strikeOut = v;
}
void FontInfo::setUnderline(bool v) {
	underline = v;
}
void FontInfo::setRGB(int32_t v) {
	RGB = v;
}
void FontInfo::setHeight(int32_t v) {
	height = v;
}
void FontInfo::setHeightPerCell(bool v) {
	heightPerCell = v;
}
void FontInfo::setEscapement(int32_t v) {
	escapement = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FontInfo::serialize(BIO& ar, const BVERSION version) {
	ar & this->RGB;
	ar & this->bold;
	ar & this->escapement;
	ar & this->faceName;
	ar & this->height;
	ar & this->heightPerCell;
	ar & this->italic;
	ar & this->strikeOut;
	ar & this->underline;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1478273890(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FontInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ForwardWorkflowNodeInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ForwardWorkflowNodeInfo::ForwardWorkflowNodeInfo() {
	terminateWorkflow = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::ForwardWorkflowNodeInfo::ForwardWorkflowNodeInfo(bool terminateWorkflow, const byps::PVectorInteger& successorNodesToActivate, const PWFNode& node)
	: terminateWorkflow(terminateWorkflow)
	, successorNodesToActivate(successorNodesToActivate)
	, node(node)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ForwardWorkflowNodeInfo::BSerializable_getTypeId() {
	return 523867474; 
}
void ForwardWorkflowNodeInfo::setTerminateWorkflow(bool v) {
	terminateWorkflow = v;
}
void ForwardWorkflowNodeInfo::setSuccessorNodesToActivate(byps::PVectorInteger v) {
	successorNodesToActivate = v;
}
void ForwardWorkflowNodeInfo::setNode(PWFNode v) {
	node = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ForwardWorkflowNodeInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->terminateWorkflow;
	ar & this->node;
	ar & this->successorNodesToActivate;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_523867474(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ForwardWorkflowNodeInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ForwardWorkflowNodeResult
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ForwardWorkflowNodeResult::ForwardWorkflowNodeResult() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ForwardWorkflowNodeResult::BSerializable_getTypeId() {
	return 1699606509; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ForwardWorkflowNodeResult::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1699606509(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ForwardWorkflowNodeResult>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FulltextConfig
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FulltextConfig::FulltextConfig() {
	source = 0;
	flags = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::FulltextConfig::FulltextConfig(int32_t source, int32_t flags, const ::std::wstring& knowlegeMapUrl, const de::elo::ix::client::search::PSearchIndexerConfig& indexerConfig)
	: source(source)
	, flags(flags)
	, knowlegeMapUrl(knowlegeMapUrl)
	, indexerConfig(indexerConfig)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FulltextConfig::BSerializable_getTypeId() {
	return 239574905; 
}
void FulltextConfig::setSource(int32_t v) {
	source = v;
}
void FulltextConfig::setFlags(int32_t v) {
	flags = v;
}
void FulltextConfig::setKnowlegeMapUrl(::std::wstring v) {
	knowlegeMapUrl = v;
}
void FulltextConfig::setIndexerConfig(de::elo::ix::client::search::PSearchIndexerConfig v) {
	indexerConfig = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FulltextConfig::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->flags;
	ar & this->knowlegeMapUrl;
	ar & this->source;
	if (version >= 900990009000010) {
		ar & this->indexerConfig;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_239574905(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FulltextConfig>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class FulltextConfigC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
FulltextConfigC::FulltextConfigC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::FulltextConfigC::BSerializable_getTypeId() {
	return 2025824562; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void FulltextConfigC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2025824562(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::FulltextConfigC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class GetWebDAVPathOptions
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
GetWebDAVPathOptions::GetWebDAVPathOptions() {
	tickketInPath = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::GetWebDAVPathOptions::GetWebDAVPathOptions(bool tickketInPath, const ::std::wstring& objId)
	: tickketInPath(tickketInPath)
	, objId(objId)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::GetWebDAVPathOptions::BSerializable_getTypeId() {
	return 1410517836; 
}
void GetWebDAVPathOptions::setTickketInPath(bool v) {
	tickketInPath = v;
}
void GetWebDAVPathOptions::setObjId(::std::wstring v) {
	objId = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void GetWebDAVPathOptions::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->objId;
	ar & this->tickketInPath;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1410517836(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::GetWebDAVPathOptions>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class GetWebDAVPathResult
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
GetWebDAVPathResult::GetWebDAVPathResult() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::GetWebDAVPathResult::GetWebDAVPathResult(const ::std::wstring& path)
	: path(path)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::GetWebDAVPathResult::BSerializable_getTypeId() {
	return 148564345; 
}
void GetWebDAVPathResult::setPath(::std::wstring v) {
	path = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void GetWebDAVPathResult::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->path;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_148564345(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::GetWebDAVPathResult>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class HttpRequestInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
HttpRequestInfo::HttpRequestInfo() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::HttpRequestInfo::HttpRequestInfo(const PArrayKeyValue& headers, const PArrayKeyValue& cookies, const PArrayKeyValue& requestParams, const ::std::wstring& requestURI, const ::std::wstring& requestURL)
	: headers(headers)
	, cookies(cookies)
	, requestParams(requestParams)
	, requestURI(requestURI)
	, requestURL(requestURL)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::HttpRequestInfo::BSerializable_getTypeId() {
	return 1892343155; 
}
void HttpRequestInfo::setHeaders(PArrayKeyValue v) {
	headers = v;
}
void HttpRequestInfo::setCookies(PArrayKeyValue v) {
	cookies = v;
}
void HttpRequestInfo::setRequestParams(PArrayKeyValue v) {
	requestParams = v;
}
void HttpRequestInfo::setRequestURI(::std::wstring v) {
	requestURI = v;
}
void HttpRequestInfo::setRequestURL(::std::wstring v) {
	requestURL = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void HttpRequestInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->requestURI;
	ar & this->requestURL;
	ar & this->cookies;
	ar & this->headers;
	ar & this->requestParams;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1892343155(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::HttpRequestInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class HttpResponseInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
HttpResponseInfo::HttpResponseInfo() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::HttpResponseInfo::HttpResponseInfo(const ::std::wstring& contentType, const ::std::wstring& responseString)
	: contentType(contentType)
	, responseString(responseString)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::HttpResponseInfo::BSerializable_getTypeId() {
	return 1552189905; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void HttpResponseInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->contentType;
	ar & this->responseString;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1552189905(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::HttpResponseInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class IXExceptionC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
IXExceptionC::IXExceptionC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::IXExceptionC::BSerializable_getTypeId() {
	return 1204588365; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void IXExceptionC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1204588365(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::IXExceptionC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class IXExceptionData
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
IXExceptionData::IXExceptionData() {
	exceptionType = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::IXExceptionData::IXExceptionData(const ::std::wstring& callId, const ::std::wstring& details, int32_t exceptionType, const ::std::wstring& message, const ::std::wstring& ticket)
	: callId(callId)
	, details(details)
	, exceptionType(exceptionType)
	, message(message)
	, ticket(ticket)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::IXExceptionData::BSerializable_getTypeId() {
	return 784089396; 
}
void IXExceptionData::setCallId(::std::wstring v) {
	callId = v;
}
void IXExceptionData::setDetails(::std::wstring v) {
	details = v;
}
void IXExceptionData::setExceptionType(int32_t v) {
	exceptionType = v;
}
void IXExceptionData::setMessage(::std::wstring v) {
	message = v;
}
void IXExceptionData::setTicket(::std::wstring v) {
	ticket = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void IXExceptionData::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->callId;
	ar & this->details;
	ar & this->exceptionType;
	ar & this->message;
	ar & this->ticket;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_784089396(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::IXExceptionData>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class IXServerEventsC
// Generated from class byps.gen.cpp.GenApiClass

const ::std::wstring IXServerEventsC::STREAM_VERSION = std::wstring(L"9.00.016.006");

// checkpoint byps.gen.cpp.GenApiClass:489
IXServerEventsC::IXServerEventsC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::IXServerEventsC::BSerializable_getTypeId() {
	return 1963572851; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void IXServerEventsC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1963572851(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::IXServerEventsC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class IXServerEventsContext
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
IXServerEventsContext::IXServerEventsContext() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::IXServerEventsContext::IXServerEventsContext(const ::std::wstring& url, const PClientInfo& ci, const PUserInfo& user, const byps::PMapStringString& sessionOptions, const ::std::wstring& clientComputer)
	: url(url)
	, ci(ci)
	, user(user)
	, sessionOptions(sessionOptions)
	, clientComputer(clientComputer)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::IXServerEventsContext::BSerializable_getTypeId() {
	return 956691491; 
}
void IXServerEventsContext::setUrl(::std::wstring v) {
	url = v;
}
void IXServerEventsContext::setCi(PClientInfo v) {
	ci = v;
}
void IXServerEventsContext::setUser(PUserInfo v) {
	user = v;
}
void IXServerEventsContext::setSessionOptions(byps::PMapStringString v) {
	sessionOptions = v;
}
void IXServerEventsContext::setClientComputer(::std::wstring v) {
	clientComputer = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void IXServerEventsContext::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->url;
	if (version >= 900000016000005) {
		ar & this->clientComputer;
	}
	ar & this->ci;
	ar & this->user;
	if (version >= 900000016000005) {
		ar & this->sessionOptions;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_956691491(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::IXServerEventsContext>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class IXServicePortC
// Generated from class byps.gen.cpp.GenApiClass

const ::std::wstring IXServicePortC::STREAM_VERSION = std::wstring(L"10.17.080.003");

// checkpoint byps.gen.cpp.GenApiClass:489
IXServicePortC::IXServicePortC() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::IXServicePortC::IXServicePortC(const ::std::wstring& STREAM_VERSION, const PAccessC& ACCESS, const PAclItemC& ACL_ITEM, const PActivityC& ACTIVITY, const PActivityProjectC& ACTIVITY_PROJECT, const PAlertC& ALERT, const PArchivingModeC& ARCHIVING_MODE, const PCheckinUsersC& CHECKIN_USERS, const PCheckoutUsersC& CHECKOUT_USERS, const PColorDataC& COLOR, const PConfigFileC& CONFIG_FILE, const PCopySordC& COPY_SORD, const PCounterInfoC& COUNTER_INFO, const PDocMaskC& DOC_MASK, const PDocMaskLineC& DOC_MASK_LINE, const PDocVersionC& DOC_VERSION, const PEditInfoC& EDIT_INFO, const PExportOptionsC& EXPORT_OPTIONS, const PImportOptionsC& IMPORT_OPTIONS, const PIXExceptionC& IXEXCEPTION, const PKeywordC& KEYWORD, const PLinkSordC& LINK_SORD, const PLockC& LOCK, const PNavigationInfoC& NAV_INFO, const PNoteC& NOTE, const PObjKeyC& OBJ_KEY, const PProcessInfoC& PROCESS_INFO, const PReminderC& REMINDER, const PReplSetNameC& REPL_SET_NAME, const PReportC& REPORT, const PReportInfoC& REPORT_INFO, const PReportModeC& REPORT_MODE, const PReportOptionsC& REPORT_OPTIONS, const PSearchModeC& SEARCH_MODE, const PServerStateC& SERVER_STATE, const PSessionOptionsC& SESSION_OPTIONS, const PSordC& SORD, const PSordHistC& SORD_HIST, const PSordHistKeyC& SORD_HIST_KEY, const PSordTypeC& SORD_TYPE, const PSortOrderC& SORT_ORDER, const PStoreInfoC& STORE_INFO, const PWFTakeNodeC& TAKE_NODE, const PThesaurusC& THESAURUS, const PUserInfoC& USER_INFO, const PUserProfileC& USER_PROFILE, const PUserTaskPriorityC& USER_TASK_PRIORITY, const PUserTaskSortOrderC& USER_TASK_SORT_ORDER, const PVtDocC& VT_DOC, const PWFDiagramC& WORKFLOW, const PWFNodeC& WORKFLOW_NODE, const PWFNodeMatrixC& WORKFLOW_NODE_ASSOC_TYPE, const PWFTypeC& WORKFLOW_TYPE, const PInvalidateCacheC& INVALIDATE_CACHE, const PWFVersionC& WORKFLOW_VERSION, const PNoteTemplateC& NOTE_TEMPLATE, const PNoteFreehandC& NOTE_FREEHAND, const PArchiveStatisticsOptionsC& ARCHIVE_STATISTICS_OPTIONS, const PMapDomainC& MAP_CONFIG, const PMapDomainC& MAP_DOMAIN, const PEloIxOptC& ELO_IX_OPT, const PAnyC& ANY, const PSearchTermsC& SEARCH_TERMS, const PAdminModeC& ADMIN_MODE, const PFulltextConfigC& FULLTEXT_CONFIG, const PServerInfoDMC& SERVER_INFO_DM, const PFindDirectC& FIND_DIRECT, const de::elo::ix::client::feed::PActionC& ACTION, const de::elo::ix::client::feed::PFeedC& FEED, const PTranslateTermC& TRANSLATE_TERM, const PEventBusC& EVENT_BUS, const PPreviewImageInfoC& PREVIEW_IMAGE_INFO, const PResolveRightsResultC& RESOLVE_RIGHTS, const de::elo::ix::client::feed::PFindActionsInfoC& FIND_ACTIONS_INFO, const PSubscriptionC& SUBSCRIPTION, const PMapDataC& MAP_DATA, const PMapHistC& MAP_HIST, const PWorkflowExportOptionsC& WORKFLOW_EXPORT_OPTIONS, const PWFNodeHistoryC& WORKFLOW_NODE_HISTORY, const PDocMaskLineTemplateC& DOC_MASK_LINE_TEMPLATE, const PPublicDownloadC& PUBLIC_DOWNLOAD, const PFileDataC& FILE_DATA, const POcrInfoC& OCR_INFO)
	: ACCESS(ACCESS)
	, ACL_ITEM(ACL_ITEM)
	, ACTIVITY(ACTIVITY)
	, ACTIVITY_PROJECT(ACTIVITY_PROJECT)
	, ALERT(ALERT)
	, ARCHIVING_MODE(ARCHIVING_MODE)
	, CHECKIN_USERS(CHECKIN_USERS)
	, CHECKOUT_USERS(CHECKOUT_USERS)
	, COLOR(COLOR)
	, CONFIG_FILE(CONFIG_FILE)
	, COPY_SORD(COPY_SORD)
	, COUNTER_INFO(COUNTER_INFO)
	, DOC_MASK(DOC_MASK)
	, DOC_MASK_LINE(DOC_MASK_LINE)
	, DOC_VERSION(DOC_VERSION)
	, EDIT_INFO(EDIT_INFO)
	, EXPORT_OPTIONS(EXPORT_OPTIONS)
	, IMPORT_OPTIONS(IMPORT_OPTIONS)
	, IXEXCEPTION(IXEXCEPTION)
	, KEYWORD(KEYWORD)
	, LINK_SORD(LINK_SORD)
	, LOCK(LOCK)
	, NAV_INFO(NAV_INFO)
	, NOTE(NOTE)
	, OBJ_KEY(OBJ_KEY)
	, PROCESS_INFO(PROCESS_INFO)
	, REMINDER(REMINDER)
	, REPL_SET_NAME(REPL_SET_NAME)
	, REPORT(REPORT)
	, REPORT_INFO(REPORT_INFO)
	, REPORT_MODE(REPORT_MODE)
	, REPORT_OPTIONS(REPORT_OPTIONS)
	, SEARCH_MODE(SEARCH_MODE)
	, SERVER_STATE(SERVER_STATE)
	, SESSION_OPTIONS(SESSION_OPTIONS)
	, SORD(SORD)
	, SORD_HIST(SORD_HIST)
	, SORD_HIST_KEY(SORD_HIST_KEY)
	, SORD_TYPE(SORD_TYPE)
	, SORT_ORDER(SORT_ORDER)
	, STORE_INFO(STORE_INFO)
	, TAKE_NODE(TAKE_NODE)
	, THESAURUS(THESAURUS)
	, USER_INFO(USER_INFO)
	, USER_PROFILE(USER_PROFILE)
	, USER_TASK_PRIORITY(USER_TASK_PRIORITY)
	, USER_TASK_SORT_ORDER(USER_TASK_SORT_ORDER)
	, VT_DOC(VT_DOC)
	, WORKFLOW(WORKFLOW)
	, WORKFLOW_NODE(WORKFLOW_NODE)
	, WORKFLOW_NODE_ASSOC_TYPE(WORKFLOW_NODE_ASSOC_TYPE)
	, WORKFLOW_TYPE(WORKFLOW_TYPE)
	, INVALIDATE_CACHE(INVALIDATE_CACHE)
	, WORKFLOW_VERSION(WORKFLOW_VERSION)
	, NOTE_TEMPLATE(NOTE_TEMPLATE)
	, NOTE_FREEHAND(NOTE_FREEHAND)
	, ARCHIVE_STATISTICS_OPTIONS(ARCHIVE_STATISTICS_OPTIONS)
	, MAP_CONFIG(MAP_CONFIG)
	, MAP_DOMAIN(MAP_DOMAIN)
	, ELO_IX_OPT(ELO_IX_OPT)
	, ANY(ANY)
	, SEARCH_TERMS(SEARCH_TERMS)
	, ADMIN_MODE(ADMIN_MODE)
	, FULLTEXT_CONFIG(FULLTEXT_CONFIG)
	, SERVER_INFO_DM(SERVER_INFO_DM)
	, FIND_DIRECT(FIND_DIRECT)
	, ACTION(ACTION)
	, FEED(FEED)
	, TRANSLATE_TERM(TRANSLATE_TERM)
	, EVENT_BUS(EVENT_BUS)
	, PREVIEW_IMAGE_INFO(PREVIEW_IMAGE_INFO)
	, RESOLVE_RIGHTS(RESOLVE_RIGHTS)
	, FIND_ACTIONS_INFO(FIND_ACTIONS_INFO)
	, SUBSCRIPTION(SUBSCRIPTION)
	, MAP_DATA(MAP_DATA)
	, MAP_HIST(MAP_HIST)
	, WORKFLOW_EXPORT_OPTIONS(WORKFLOW_EXPORT_OPTIONS)
	, WORKFLOW_NODE_HISTORY(WORKFLOW_NODE_HISTORY)
	, DOC_MASK_LINE_TEMPLATE(DOC_MASK_LINE_TEMPLATE)
	, PUBLIC_DOWNLOAD(PUBLIC_DOWNLOAD)
	, FILE_DATA(FILE_DATA)
	, OCR_INFO(OCR_INFO)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::IXServicePortC::BSerializable_getTypeId() {
	return 1264954948; 
}
void IXServicePortC::setACCESS(PAccessC v) {
	ACCESS = v;
}
void IXServicePortC::setACL_ITEM(PAclItemC v) {
	ACL_ITEM = v;
}
void IXServicePortC::setACTIVITY(PActivityC v) {
	ACTIVITY = v;
}
void IXServicePortC::setACTIVITY_PROJECT(PActivityProjectC v) {
	ACTIVITY_PROJECT = v;
}
void IXServicePortC::setALERT(PAlertC v) {
	ALERT = v;
}
void IXServicePortC::setARCHIVING_MODE(PArchivingModeC v) {
	ARCHIVING_MODE = v;
}
void IXServicePortC::setCHECKIN_USERS(PCheckinUsersC v) {
	CHECKIN_USERS = v;
}
void IXServicePortC::setCHECKOUT_USERS(PCheckoutUsersC v) {
	CHECKOUT_USERS = v;
}
void IXServicePortC::setCOLOR(PColorDataC v) {
	COLOR = v;
}
void IXServicePortC::setCONFIG_FILE(PConfigFileC v) {
	CONFIG_FILE = v;
}
void IXServicePortC::setCOPY_SORD(PCopySordC v) {
	COPY_SORD = v;
}
void IXServicePortC::setCOUNTER_INFO(PCounterInfoC v) {
	COUNTER_INFO = v;
}
void IXServicePortC::setDOC_MASK(PDocMaskC v) {
	DOC_MASK = v;
}
void IXServicePortC::setDOC_MASK_LINE(PDocMaskLineC v) {
	DOC_MASK_LINE = v;
}
void IXServicePortC::setDOC_VERSION(PDocVersionC v) {
	DOC_VERSION = v;
}
void IXServicePortC::setEDIT_INFO(PEditInfoC v) {
	EDIT_INFO = v;
}
void IXServicePortC::setEXPORT_OPTIONS(PExportOptionsC v) {
	EXPORT_OPTIONS = v;
}
void IXServicePortC::setIMPORT_OPTIONS(PImportOptionsC v) {
	IMPORT_OPTIONS = v;
}
void IXServicePortC::setIXEXCEPTION(PIXExceptionC v) {
	IXEXCEPTION = v;
}
void IXServicePortC::setKEYWORD(PKeywordC v) {
	KEYWORD = v;
}
void IXServicePortC::setLINK_SORD(PLinkSordC v) {
	LINK_SORD = v;
}
void IXServicePortC::setLOCK(PLockC v) {
	LOCK = v;
}
void IXServicePortC::setNAV_INFO(PNavigationInfoC v) {
	NAV_INFO = v;
}
void IXServicePortC::setNOTE(PNoteC v) {
	NOTE = v;
}
void IXServicePortC::setOBJ_KEY(PObjKeyC v) {
	OBJ_KEY = v;
}
void IXServicePortC::setPROCESS_INFO(PProcessInfoC v) {
	PROCESS_INFO = v;
}
void IXServicePortC::setREMINDER(PReminderC v) {
	REMINDER = v;
}
void IXServicePortC::setREPL_SET_NAME(PReplSetNameC v) {
	REPL_SET_NAME = v;
}
void IXServicePortC::setREPORT(PReportC v) {
	REPORT = v;
}
void IXServicePortC::setREPORT_INFO(PReportInfoC v) {
	REPORT_INFO = v;
}
void IXServicePortC::setREPORT_MODE(PReportModeC v) {
	REPORT_MODE = v;
}
void IXServicePortC::setREPORT_OPTIONS(PReportOptionsC v) {
	REPORT_OPTIONS = v;
}
void IXServicePortC::setSEARCH_MODE(PSearchModeC v) {
	SEARCH_MODE = v;
}
void IXServicePortC::setSERVER_STATE(PServerStateC v) {
	SERVER_STATE = v;
}
void IXServicePortC::setSESSION_OPTIONS(PSessionOptionsC v) {
	SESSION_OPTIONS = v;
}
void IXServicePortC::setSORD(PSordC v) {
	SORD = v;
}
void IXServicePortC::setSORD_HIST(PSordHistC v) {
	SORD_HIST = v;
}
void IXServicePortC::setSORD_HIST_KEY(PSordHistKeyC v) {
	SORD_HIST_KEY = v;
}
void IXServicePortC::setSORD_TYPE(PSordTypeC v) {
	SORD_TYPE = v;
}
void IXServicePortC::setSORT_ORDER(PSortOrderC v) {
	SORT_ORDER = v;
}
void IXServicePortC::setSTORE_INFO(PStoreInfoC v) {
	STORE_INFO = v;
}
void IXServicePortC::setTAKE_NODE(PWFTakeNodeC v) {
	TAKE_NODE = v;
}
void IXServicePortC::setTHESAURUS(PThesaurusC v) {
	THESAURUS = v;
}
void IXServicePortC::setUSER_INFO(PUserInfoC v) {
	USER_INFO = v;
}
void IXServicePortC::setUSER_PROFILE(PUserProfileC v) {
	USER_PROFILE = v;
}
void IXServicePortC::setUSER_TASK_PRIORITY(PUserTaskPriorityC v) {
	USER_TASK_PRIORITY = v;
}
void IXServicePortC::setUSER_TASK_SORT_ORDER(PUserTaskSortOrderC v) {
	USER_TASK_SORT_ORDER = v;
}
void IXServicePortC::setVT_DOC(PVtDocC v) {
	VT_DOC = v;
}
void IXServicePortC::setWORKFLOW(PWFDiagramC v) {
	WORKFLOW = v;
}
void IXServicePortC::setWORKFLOW_NODE(PWFNodeC v) {
	WORKFLOW_NODE = v;
}
void IXServicePortC::setWORKFLOW_NODE_ASSOC_TYPE(PWFNodeMatrixC v) {
	WORKFLOW_NODE_ASSOC_TYPE = v;
}
void IXServicePortC::setWORKFLOW_TYPE(PWFTypeC v) {
	WORKFLOW_TYPE = v;
}
void IXServicePortC::setINVALIDATE_CACHE(PInvalidateCacheC v) {
	INVALIDATE_CACHE = v;
}
void IXServicePortC::setWORKFLOW_VERSION(PWFVersionC v) {
	WORKFLOW_VERSION = v;
}
void IXServicePortC::setNOTE_TEMPLATE(PNoteTemplateC v) {
	NOTE_TEMPLATE = v;
}
void IXServicePortC::setNOTE_FREEHAND(PNoteFreehandC v) {
	NOTE_FREEHAND = v;
}
void IXServicePortC::setARCHIVE_STATISTICS_OPTIONS(PArchiveStatisticsOptionsC v) {
	ARCHIVE_STATISTICS_OPTIONS = v;
}
void IXServicePortC::setMAP_CONFIG(PMapDomainC v) {
	MAP_CONFIG = v;
}
void IXServicePortC::setMAP_DOMAIN(PMapDomainC v) {
	MAP_DOMAIN = v;
}
void IXServicePortC::setELO_IX_OPT(PEloIxOptC v) {
	ELO_IX_OPT = v;
}
void IXServicePortC::setANY(PAnyC v) {
	ANY = v;
}
void IXServicePortC::setSEARCH_TERMS(PSearchTermsC v) {
	SEARCH_TERMS = v;
}
void IXServicePortC::setADMIN_MODE(PAdminModeC v) {
	ADMIN_MODE = v;
}
void IXServicePortC::setFULLTEXT_CONFIG(PFulltextConfigC v) {
	FULLTEXT_CONFIG = v;
}
void IXServicePortC::setSERVER_INFO_DM(PServerInfoDMC v) {
	SERVER_INFO_DM = v;
}
void IXServicePortC::setFIND_DIRECT(PFindDirectC v) {
	FIND_DIRECT = v;
}
void IXServicePortC::setACTION(de::elo::ix::client::feed::PActionC v) {
	ACTION = v;
}
void IXServicePortC::setFEED(de::elo::ix::client::feed::PFeedC v) {
	FEED = v;
}
void IXServicePortC::setTRANSLATE_TERM(PTranslateTermC v) {
	TRANSLATE_TERM = v;
}
void IXServicePortC::setEVENT_BUS(PEventBusC v) {
	EVENT_BUS = v;
}
void IXServicePortC::setPREVIEW_IMAGE_INFO(PPreviewImageInfoC v) {
	PREVIEW_IMAGE_INFO = v;
}
void IXServicePortC::setRESOLVE_RIGHTS(PResolveRightsResultC v) {
	RESOLVE_RIGHTS = v;
}
void IXServicePortC::setFIND_ACTIONS_INFO(de::elo::ix::client::feed::PFindActionsInfoC v) {
	FIND_ACTIONS_INFO = v;
}
void IXServicePortC::setSUBSCRIPTION(PSubscriptionC v) {
	SUBSCRIPTION = v;
}
void IXServicePortC::setMAP_DATA(PMapDataC v) {
	MAP_DATA = v;
}
void IXServicePortC::setMAP_HIST(PMapHistC v) {
	MAP_HIST = v;
}
void IXServicePortC::setWORKFLOW_EXPORT_OPTIONS(PWorkflowExportOptionsC v) {
	WORKFLOW_EXPORT_OPTIONS = v;
}
void IXServicePortC::setWORKFLOW_NODE_HISTORY(PWFNodeHistoryC v) {
	WORKFLOW_NODE_HISTORY = v;
}
void IXServicePortC::setDOC_MASK_LINE_TEMPLATE(PDocMaskLineTemplateC v) {
	DOC_MASK_LINE_TEMPLATE = v;
}
void IXServicePortC::setPUBLIC_DOWNLOAD(PPublicDownloadC v) {
	PUBLIC_DOWNLOAD = v;
}
void IXServicePortC::setFILE_DATA(PFileDataC v) {
	FILE_DATA = v;
}
void IXServicePortC::setOCR_INFO(POcrInfoC v) {
	OCR_INFO = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void IXServicePortC::serialize(BIO& ar, const BVERSION version) {
	ar & this->ACCESS;
	ar & this->ACL_ITEM;
	ar & this->ACTIVITY;
	ar & this->ACTIVITY_PROJECT;
	ar & this->ALERT;
	ar & this->ARCHIVING_MODE;
	ar & this->CHECKIN_USERS;
	ar & this->CHECKOUT_USERS;
	ar & this->COLOR;
	ar & this->CONFIG_FILE;
	ar & this->COPY_SORD;
	ar & this->COUNTER_INFO;
	ar & this->DOC_MASK;
	ar & this->DOC_MASK_LINE;
	ar & this->DOC_VERSION;
	ar & this->EDIT_INFO;
	ar & this->EXPORT_OPTIONS;
	ar & this->IMPORT_OPTIONS;
	ar & this->IXEXCEPTION;
	ar & this->KEYWORD;
	ar & this->LINK_SORD;
	ar & this->LOCK;
	ar & this->NAV_INFO;
	ar & this->NOTE;
	ar & this->OBJ_KEY;
	ar & this->PROCESS_INFO;
	ar & this->REMINDER;
	ar & this->REPL_SET_NAME;
	ar & this->REPORT;
	ar & this->REPORT_INFO;
	ar & this->REPORT_MODE;
	ar & this->REPORT_OPTIONS;
	ar & this->SEARCH_MODE;
	ar & this->SERVER_STATE;
	ar & this->SESSION_OPTIONS;
	ar & this->SORD;
	ar & this->SORD_HIST;
	ar & this->SORD_HIST_KEY;
	ar & this->SORD_TYPE;
	ar & this->SORT_ORDER;
	ar & this->STORE_INFO;
	ar & this->TAKE_NODE;
	ar & this->THESAURUS;
	ar & this->USER_INFO;
	ar & this->USER_PROFILE;
	ar & this->USER_TASK_PRIORITY;
	ar & this->USER_TASK_SORT_ORDER;
	ar & this->VT_DOC;
	ar & this->WORKFLOW;
	ar & this->WORKFLOW_NODE;
	ar & this->WORKFLOW_NODE_ASSOC_TYPE;
	ar & this->WORKFLOW_TYPE;
	if (version >= 600000093000000) {
		ar & this->INVALIDATE_CACHE;
		if (version >= 700000000000008) {
			ar & this->WORKFLOW_VERSION;
			if (version >= 700000000000024) {
				ar & this->NOTE_TEMPLATE;
				if (version >= 700000000000025) {
					ar & this->NOTE_FREEHAND;
					if (version >= 700000020000009) {
						ar & this->ARCHIVE_STATISTICS_OPTIONS;
						if (version >= 700000040000001) {
							ar & this->MAP_CONFIG;
							if (version >= 700000040000003) {
								ar & this->ELO_IX_OPT;
								if (version >= 700000040000019) {
									ar & this->ANY;
									if (version >= 700000040000021) {
										ar & this->SEARCH_TERMS;
										if (version >= 700000040000022) {
											ar & this->ADMIN_MODE;
											if (version >= 700000040000023) {
												ar & this->FULLTEXT_CONFIG;
												if (version >= 700000040000026) {
													ar & this->SERVER_INFO_DM;
													if (version >= 800000000000001) {
														ar & this->FIND_DIRECT;
														if (version >= 800000010000000) {
															ar & this->EVENT_BUS;
															if (version >= 800000012000004) {
																ar & this->MAP_DOMAIN;
																if (version >= 900000000000003) {
																	ar & this->ACTION;
																	ar & this->FEED;
																	if (version >= 900000000000007) {
																		ar & this->TRANSLATE_TERM;
																		if (version >= 900000000000015) {
																			ar & this->PREVIEW_IMAGE_INFO;
																			if (version >= 900000000000020) {
																				ar & this->RESOLVE_RIGHTS;
																				if (version >= 900000000000037) {
																					ar & this->FIND_ACTIONS_INFO;
																					if (version >= 900000014000003) {
																						ar & this->SUBSCRIPTION;
																						if (version >= 900000014000009) {
																							ar & this->MAP_DATA;
																							if (version >= 900000018000002) {
																								ar & this->MAP_HIST;
																								ar & this->WORKFLOW_EXPORT_OPTIONS;
																								if (version >= 900000030000018) {
																									ar & this->WORKFLOW_NODE_HISTORY;
																									if (version >= 900000030000030) {
																										ar & this->PUBLIC_DOWNLOAD;
																										if (version >= 900990009000002) {
																											ar & this->DOC_MASK_LINE_TEMPLATE;
																											if (version >= 1000000020000006) {
																												ar & this->FILE_DATA;
																												if (version >= 1000170059000002) {
																													ar & this->OCR_INFO;
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
void BSerializer_1264954948(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::IXServicePortC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class IdName
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
IdName::IdName() {
	id = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::IdName::IdName(const ::std::wstring& guid, int32_t id, const ::std::wstring& name)
	: guid(guid)
	, id(id)
	, name(name)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::IdName::BSerializable_getTypeId() {
	return 381683845; 
}
void IdName::setGuid(::std::wstring v) {
	guid = v;
}
void IdName::setId(int32_t v) {
	id = v;
}
void IdName::setName(::std::wstring v) {
	name = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void IdName::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->guid;
	ar & this->id;
	ar & this->name;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_381683845(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::IdName>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_755261279(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PIdName > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class ImportOptionsC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
ImportOptionsC::ImportOptionsC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::ImportOptionsC::BSerializable_getTypeId() {
	return 1908370444; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void ImportOptionsC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1908370444(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::ImportOptionsC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class IndexServerForArchive
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
IndexServerForArchive::IndexServerForArchive() {
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::IndexServerForArchive::IndexServerForArchive(const ::std::wstring& arcName, const ::std::wstring& url)
	: arcName(arcName)
	, url(url)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::IndexServerForArchive::BSerializable_getTypeId() {
	return 145656220; 
}
void IndexServerForArchive::setArcName(::std::wstring v) {
	arcName = v;
}
void IndexServerForArchive::setUrl(::std::wstring v) {
	url = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void IndexServerForArchive::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->arcName;
	ar & this->url;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_145656220(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::IndexServerForArchive>(bio, pObj, pObjS, pBase);	
}
}}}}
// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1712744473(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_Obj_Template<::byps::BArray1< de::elo::ix::client::PIndexServerForArchive > >(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class InvalidateCacheC
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
InvalidateCacheC::InvalidateCacheC() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::InvalidateCacheC::BSerializable_getTypeId() {
	return 320503229; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void InvalidateCacheC::serialize(BIO& ar, const BVERSION version) {
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_320503229(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::InvalidateCacheC>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class InvalidateCacheInfo
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
InvalidateCacheInfo::InvalidateCacheInfo() {
	flags = 0;
	id = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::InvalidateCacheInfo::InvalidateCacheInfo(int32_t flags, int32_t id, const PVectorInvalidateCacheInfoParam& parameters)
	: flags(flags)
	, id(id)
	, parameters(parameters)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::InvalidateCacheInfo::BSerializable_getTypeId() {
	return 1441686860; 
}
void InvalidateCacheInfo::setFlags(int32_t v) {
	flags = v;
}
void InvalidateCacheInfo::setId(int32_t v) {
	id = v;
}
void InvalidateCacheInfo::setParameters(PVectorInvalidateCacheInfoParam v) {
	parameters = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void InvalidateCacheInfo::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->flags;
	ar & this->id;
	if (version >= 900000030000015) {
		ar & this->parameters;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1441686860(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::InvalidateCacheInfo>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class InvalidateCacheInfoParam
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
InvalidateCacheInfoParam::InvalidateCacheInfoParam() {
	flag = 0;
	count = 0;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::InvalidateCacheInfoParam::InvalidateCacheInfoParam(const ::std::wstring& guid, int32_t flag, int32_t count)
	: guid(guid)
	, flag(flag)
	, count(count)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::InvalidateCacheInfoParam::BSerializable_getTypeId() {
	return 102205772; 
}
void InvalidateCacheInfoParam::setGuid(::std::wstring v) {
	guid = v;
}
void InvalidateCacheInfoParam::setFlag(int32_t v) {
	flag = v;
}
void InvalidateCacheInfoParam::setCount(int32_t v) {
	count = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void InvalidateCacheInfoParam::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->count;
	ar & this->flag;
	ar & this->guid;
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_102205772(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::InvalidateCacheInfoParam>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class InvalidateCacheResult
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
InvalidateCacheResult::InvalidateCacheResult() {
}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::InvalidateCacheResult::BSerializable_getTypeId() {
	return 1712381166; 
}
// checkpoint byps.gen.cpp.GenApiClass:876
void InvalidateCacheResult::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1712381166(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::InvalidateCacheResult>(bio, pObj, pObjS, pBase);	
}
}}}}
namespace de { namespace elo { namespace ix { namespace client { 

//-------------------------------------------------
// Implementation of class JobState
// Generated from class byps.gen.cpp.GenApiClass

// checkpoint byps.gen.cpp.GenApiClass:489
JobState::JobState() {
	countErrors = 0;
	countEstimatedMax = 0;
	countProcessed = 0;
	expires = 0;
	jobRunning = false;
	lastID = 0;
	doCancelJob = false;
}
// checkpoint byps.gen.cpp.GenApiClass:536
de::elo::ix::client::JobState::JobState(int64_t countErrors, int64_t countEstimatedMax, int64_t countProcessed, int64_t expires, const ::std::wstring& jobEnd, const ::std::wstring& jobGuid, const ::std::wstring& jobName, bool jobRunning, const ::std::wstring& jobStart, const ::std::wstring& lastGuid, int32_t lastID, const PProcessInfo& procInfo, const PCountResult& countResult, const ::std::wstring& strMsg, bool doCancelJob)
	: countErrors(countErrors)
	, countEstimatedMax(countEstimatedMax)
	, countProcessed(countProcessed)
	, expires(expires)
	, jobEnd(jobEnd)
	, jobGuid(jobGuid)
	, jobName(jobName)
	, jobRunning(jobRunning)
	, jobStart(jobStart)
	, lastGuid(lastGuid)
	, lastID(lastID)
	, procInfo(procInfo)
	, countResult(countResult)
	, strMsg(strMsg)
	, doCancelJob(doCancelJob)
	{}
// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::JobState::BSerializable_getTypeId() {
	return 1436376940; 
}
void JobState::setCountErrors(int64_t v) {
	countErrors = v;
}
void JobState::setCountEstimatedMax(int64_t v) {
	countEstimatedMax = v;
}
void JobState::setCountProcessed(int64_t v) {
	countProcessed = v;
}
void JobState::setExpires(int64_t v) {
	expires = v;
}
void JobState::setJobEnd(::std::wstring v) {
	jobEnd = v;
}
void JobState::setJobGuid(::std::wstring v) {
	jobGuid = v;
}
void JobState::setJobName(::std::wstring v) {
	jobName = v;
}
void JobState::setJobRunning(bool v) {
	jobRunning = v;
}
void JobState::setJobStart(::std::wstring v) {
	jobStart = v;
}
void JobState::setLastGuid(::std::wstring v) {
	lastGuid = v;
}
void JobState::setLastID(int32_t v) {
	lastID = v;
}
void JobState::setProcInfo(PProcessInfo v) {
	procInfo = v;
}
void JobState::setCountResult(PCountResult v) {
	countResult = v;
}
void JobState::setStrMsg(::std::wstring v) {
	strMsg = v;
}
void JobState::setDoCancelJob(bool v) {
	doCancelJob = v;
}
// checkpoint byps.gen.cpp.GenApiClass:876
void JobState::serialize(BIO& ar, const BVERSION version) {
	ValueClass::serialize(ar, version);
	ar & this->countErrors;
	ar & this->countEstimatedMax;
	ar & this->countProcessed;
	ar & this->expires;
	ar & this->jobEnd;
	ar & this->jobGuid;
	ar & this->jobName;
	ar & this->jobRunning;
	ar & this->jobStart;
	ar & this->lastGuid;
	ar & this->lastID;
	ar & this->strMsg;
	if (version >= 800000036000000) {
		ar & this->doCancelJob;
	}
	ar & this->procInfo;
	if (version >= 700000000000000) {
		ar & this->countResult;
	}
}
}}}}

// checkpoint byps.gen.cpp.GenApiClass:933
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1436376940(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* pBase) {
	BSerializer_ObjS_Template<de::elo::ix::client::JobState>(bio, pObj, pObjS, pBase);	
}
}}}}
