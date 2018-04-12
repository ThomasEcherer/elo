#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findNextTranslateTerms(const ::std::wstring& searchId, int32_t idx, int32_t max)  {
	BSyncResultT< PFindResult > syncResult;	
	findNextTranslateTerms(searchId, idx, max, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findNextTranslateTerms(const ::std::wstring& searchId, int32_t idx, int32_t max, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findNextTranslateTerms(searchId, idx, max));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayTranslateTerm BStub_IXServicePortIF::checkoutTranslateTerms(const PArrayString& termIds, const PLockZ& lockZ)  {
	BSyncResultT< PArrayTranslateTerm > syncResult;	
	checkoutTranslateTerms(termIds, lockZ, [&syncResult](PArrayTranslateTerm v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutTranslateTerms(const PArrayString& termIds, const PLockZ& lockZ, ::std::function< void (PArrayTranslateTerm, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutTranslateTerms(termIds, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayTranslateTerm, BResult_1088095067 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayString BStub_IXServicePortIF::checkinTranslateTerms(const PArrayTranslateTerm& tterms, const PLockZ& unlockZ)  {
	BSyncResultT< PArrayString > syncResult;	
	checkinTranslateTerms(tterms, unlockZ, [&syncResult](PArrayString v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinTranslateTerms(const PArrayTranslateTerm& tterms, const PLockZ& unlockZ, ::std::function< void (PArrayString, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinTranslateTerms(tterms, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayString, BResult_1888107655 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteTranslateTerms(const PArrayString& termIds, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteTranslateTerms(termIds, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteTranslateTerms(const PArrayString& termIds, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteTranslateTerms(termIds, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayWFVersion BStub_IXServicePortIF::getWorkflowTemplateVersions(const ::std::wstring& flowId, bool onlyDeleted)  {
	BSyncResultT< PArrayWFVersion > syncResult;	
	getWorkflowTemplateVersions(flowId, onlyDeleted, [&syncResult](PArrayWFVersion v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getWorkflowTemplateVersions(const ::std::wstring& flowId, bool onlyDeleted, ::std::function< void (PArrayWFVersion, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getWorkflowTemplateVersions(flowId, onlyDeleted));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayWFVersion, BResult_1768472140 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PWFDiagram BStub_IXServicePortIF::checkoutWorkflowTemplate(const ::std::wstring& flowId, const ::std::wstring& versionId, const PWFDiagramZ& wfZ, const PLockZ& lockZ)  {
	BSyncResultT< PWFDiagram > syncResult;	
	checkoutWorkflowTemplate(flowId, versionId, wfZ, lockZ, [&syncResult](PWFDiagram v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutWorkflowTemplate(const ::std::wstring& flowId, const ::std::wstring& versionId, const PWFDiagramZ& wfZ, const PLockZ& lockZ, ::std::function< void (PWFDiagram, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutWorkflowTemplate(flowId, versionId, wfZ, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PWFDiagram, BResult_1663767661 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayInt BStub_IXServicePortIF::checkinWorkflowTemplate(const PWFDiagram& wf, const PWFDiagramZ& wfZ, const PLockZ& unlockZ)  {
	BSyncResultT< PArrayInt > syncResult;	
	checkinWorkflowTemplate(wf, wfZ, unlockZ, [&syncResult](PArrayInt v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinWorkflowTemplate(const PWFDiagram& wf, const PWFDiagramZ& wfZ, const PLockZ& unlockZ, ::std::function< void (PArrayInt, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinWorkflowTemplate(wf, wfZ, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayInt, BResult_100361105 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteWorkflowTemplate(const ::std::wstring& flowId, const ::std::wstring& versionId, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteWorkflowTemplate(flowId, versionId, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteWorkflowTemplate(const ::std::wstring& flowId, const ::std::wstring& versionId, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteWorkflowTemplate(flowId, versionId, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayNoteTemplate BStub_IXServicePortIF::checkoutNoteTemplates(const ::std::wstring& userId, const PArrayString& ids, const PNoteTemplateZ& ntemplZ, const PLockZ& lockZ)  {
	BSyncResultT< PArrayNoteTemplate > syncResult;	
	checkoutNoteTemplates(userId, ids, ntemplZ, lockZ, [&syncResult](PArrayNoteTemplate v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutNoteTemplates(const ::std::wstring& userId, const PArrayString& ids, const PNoteTemplateZ& ntemplZ, const PLockZ& lockZ, ::std::function< void (PArrayNoteTemplate, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutNoteTemplates(userId, ids, ntemplZ, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayNoteTemplate, BResult_1443841819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PNoteTemplate BStub_IXServicePortIF::createNoteTemplate(const ::std::wstring& userId)  {
	BSyncResultT< PNoteTemplate > syncResult;	
	createNoteTemplate(userId, [&syncResult](PNoteTemplate v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::createNoteTemplate(const ::std::wstring& userId, ::std::function< void (PNoteTemplate, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_createNoteTemplate(userId));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PNoteTemplate, BResult_1995912373 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteNoteTemplates(const ::std::wstring& userId, const PArrayString& ids, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteNoteTemplates(userId, ids, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteNoteTemplates(const ::std::wstring& userId, const PArrayString& ids, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteNoteTemplates(userId, ids, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayInt BStub_IXServicePortIF::checkinNoteTemplates(const PArrayNoteTemplate& noteTemplates, const PNoteTemplateZ& ntemplZ, const PLockZ& unlockZ)  {
	BSyncResultT< PArrayInt > syncResult;	
	checkinNoteTemplates(noteTemplates, ntemplZ, unlockZ, [&syncResult](PArrayInt v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinNoteTemplates(const PArrayNoteTemplate& noteTemplates, const PNoteTemplateZ& ntemplZ, const PLockZ& unlockZ, ::std::function< void (PArrayInt, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinNoteTemplates(noteTemplates, ntemplZ, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayInt, BResult_100361105 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::reload()  {
	BSyncResultT< bool > syncResult;	
	reload([&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::reload(::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_reload());
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::reloadScripts()  {
	BSyncResultT< bool > syncResult;	
	reloadScripts([&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::reloadScripts(::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_reloadScripts());
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
byps::PMapIntegerString BStub_IXServicePortIF::getCompiledScripts()  {
	BSyncResultT< byps::PMapIntegerString > syncResult;	
	getCompiledScripts([&syncResult](byps::PMapIntegerString v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getCompiledScripts(::std::function< void (byps::PMapIntegerString, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getCompiledScripts());
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< byps::PMapIntegerString, BResult_498630295 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
::std::wstring BStub_IXServicePortIF::getScriptsToDebug()  {
	BSyncResultT< ::std::wstring > syncResult;	
	getScriptsToDebug([&syncResult](::std::wstring v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getScriptsToDebug(::std::function< void (::std::wstring, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getScriptsToDebug());
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< ::std::wstring, BResult_10 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::setScriptsToDebug(const ::std::wstring& scriptsToDebug)  {
	BSyncResultT< bool > syncResult;	
	setScriptsToDebug(scriptsToDebug, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::setScriptsToDebug(const ::std::wstring& scriptsToDebug, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_setScriptsToDebug(scriptsToDebug));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
int32_t BStub_IXServicePortIF::getDebuggerPort()  {
	BSyncResultT< int32_t > syncResult;	
	getDebuggerPort([&syncResult](int32_t v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getDebuggerPort(::std::function< void (int32_t, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getDebuggerPort());
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< int32_t, BResult_5 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteKeywordList(const ::std::wstring& kwid, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteKeywordList(kwid, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteKeywordList(const ::std::wstring& kwid, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteKeywordList(kwid, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PKeywordList BStub_IXServicePortIF::checkoutKeywordList(const ::std::wstring& kwid, const PKeywordZ& keywordZ, int32_t max, const PLockZ& lockZ)  {
	BSyncResultT< PKeywordList > syncResult;	
	checkoutKeywordList(kwid, keywordZ, max, lockZ, [&syncResult](PKeywordList v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutKeywordList(const ::std::wstring& kwid, const PKeywordZ& keywordZ, int32_t max, const PLockZ& lockZ, ::std::function< void (PKeywordList, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutKeywordList(kwid, keywordZ, max, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PKeywordList, BResult_1495731174 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::checkinKeywordList(const PKeywordList& kwList, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	checkinKeywordList(kwList, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::checkinKeywordList(const PKeywordList& kwList, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinKeywordList(kwList, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PCombineAclResult BStub_IXServicePortIF::combineAcl(const PArrayAclItem& lhs, const PArrayAclItem& rhs, const PCombineAclOptions& options)  {
	BSyncResultT< PCombineAclResult > syncResult;	
	combineAcl(lhs, rhs, options, [&syncResult](PCombineAclResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::combineAcl(const PArrayAclItem& lhs, const PArrayAclItem& rhs, const PCombineAclOptions& options, ::std::function< void (PCombineAclResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_combineAcl(lhs, rhs, options));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PCombineAclResult, BResult_1034263904 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PAclAccessResult BStub_IXServicePortIF::getAclAccess(const PAclAccessInfo& aai)  {
	BSyncResultT< PAclAccessResult > syncResult;	
	getAclAccess(aai, [&syncResult](PAclAccessResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getAclAccess(const PAclAccessInfo& aai, ::std::function< void (PAclAccessResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getAclAccess(aai));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PAclAccessResult, BResult_200528028 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayEditInfo BStub_IXServicePortIF::getEditInfoFromESW(const PArrayFileData& fileDatas, const PEditInfoEswOptions& eswOptions)  {
	BSyncResultT< PArrayEditInfo > syncResult;	
	getEditInfoFromESW(fileDatas, eswOptions, [&syncResult](PArrayEditInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getEditInfoFromESW(const PArrayFileData& fileDatas, const PEditInfoEswOptions& eswOptions, ::std::function< void (PArrayEditInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getEditInfoFromESW(fileDatas, eswOptions));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayEditInfo, BResult_785380175 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayFileData BStub_IXServicePortIF::getESWFromEditInfo(const PArrayEditInfo& editInfos, const PEditInfoEswOptions& eswOptions)  {
	BSyncResultT< PArrayFileData > syncResult;	
	getESWFromEditInfo(editInfos, eswOptions, [&syncResult](PArrayFileData v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getESWFromEditInfo(const PArrayEditInfo& editInfos, const PEditInfoEswOptions& eswOptions, ::std::function< void (PArrayFileData, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getESWFromEditInfo(editInfos, eswOptions));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayFileData, BResult_1078168929 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PLoginResult BStub_IXServicePortIF::getSessionFromTicket(int32_t options)  {
	BSyncResultT< PLoginResult > syncResult;	
	getSessionFromTicket(options, [&syncResult](PLoginResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getSessionFromTicket(int32_t options, ::std::function< void (PLoginResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getSessionFromTicket(options));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PLoginResult, BResult_777531606 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArraySessionInfo BStub_IXServicePortIF::getSessionInfos(const PSessionInfoParams& params)  {
	BSyncResultT< PArraySessionInfo > syncResult;	
	getSessionInfos(params, [&syncResult](PArraySessionInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getSessionInfos(const PSessionInfoParams& params, ::std::function< void (PArraySessionInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getSessionInfos(params));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArraySessionInfo, BResult_1376733713 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PExecuteScriptResult BStub_IXServicePortIF::executeScript(const PExecuteScriptParams& params)  {
	BSyncResultT< PExecuteScriptResult > syncResult;	
	executeScript(params, [&syncResult](PExecuteScriptResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::executeScript(const PExecuteScriptParams& params, ::std::function< void (PExecuteScriptResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_executeScript(params));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PExecuteScriptResult, BResult_63967077 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFileData BStub_IXServicePortIF::exportWorkflow(const PWorkflowExportOptions& wfExportOptions)  {
	BSyncResultT< PFileData > syncResult;	
	exportWorkflow(wfExportOptions, [&syncResult](PFileData v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::exportWorkflow(const PWorkflowExportOptions& wfExportOptions, ::std::function< void (PFileData, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_exportWorkflow(wfExportOptions));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFileData, BResult_888671717 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PValuesOfObjKey BStub_IXServicePortIF::getDistinctValuesOfObjKey(const ::std::wstring& okeyName, const PValuesOfObjKeyOptions& opts)  {
	BSyncResultT< PValuesOfObjKey > syncResult;	
	getDistinctValuesOfObjKey(okeyName, opts, [&syncResult](PValuesOfObjKey v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getDistinctValuesOfObjKey(const ::std::wstring& okeyName, const PValuesOfObjKeyOptions& opts, ::std::function< void (PValuesOfObjKey, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getDistinctValuesOfObjKey(okeyName, opts));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PValuesOfObjKey, BResult_1153931872 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArchiveStatistics BStub_IXServicePortIF::getArchiveStatistics(int64_t opts)  {
	BSyncResultT< PArchiveStatistics > syncResult;	
	getArchiveStatistics(opts, [&syncResult](PArchiveStatistics v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getArchiveStatistics(int64_t opts, ::std::function< void (PArchiveStatistics, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getArchiveStatistics(opts));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArchiveStatistics, BResult_2056457945 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayMapDomain BStub_IXServicePortIF::collectMapDomains()  {
	BSyncResultT< PArrayMapDomain > syncResult;	
	collectMapDomains([&syncResult](PArrayMapDomain v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::collectMapDomains(::std::function< void (PArrayMapDomain, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_collectMapDomains());
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayMapDomain, BResult_1963952629 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::checkinMapDomain(const PMapDomain& mapDomain, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	checkinMapDomain(mapDomain, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::checkinMapDomain(const PMapDomain& mapDomain, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinMapDomain(mapDomain, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PMapDomain BStub_IXServicePortIF::checkoutMapDomain(const ::std::wstring& domainName, const PLockZ& lockZ)  {
	BSyncResultT< PMapDomain > syncResult;	
	checkoutMapDomain(domainName, lockZ, [&syncResult](PMapDomain v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutMapDomain(const ::std::wstring& domainName, const PLockZ& lockZ, ::std::function< void (PMapDomain, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutMapDomain(domainName, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PMapDomain, BResult_42339713 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteMapDomain(const ::std::wstring& domainName, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteMapDomain(domainName, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteMapDomain(const ::std::wstring& domainName, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteMapDomain(domainName, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::checkinMap(const ::std::wstring& domainName, const ::std::wstring& id, int32_t objId, const PArrayKeyValue& data, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	checkinMap(domainName, id, objId, data, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::checkinMap(const ::std::wstring& domainName, const ::std::wstring& id, int32_t objId, const PArrayKeyValue& data, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinMap(domainName, id, objId, data, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PMapData BStub_IXServicePortIF::checkoutMap(const ::std::wstring& domainName, const ::std::wstring& id, const PArrayString& keyNames, const PLockZ& lockZ)  {
	BSyncResultT< PMapData > syncResult;	
	checkoutMap(domainName, id, keyNames, lockZ, [&syncResult](PMapData v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutMap(const ::std::wstring& domainName, const ::std::wstring& id, const PArrayString& keyNames, const PLockZ& lockZ, ::std::function< void (PMapData, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutMap(domainName, id, keyNames, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PMapData, BResult_2011132580 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteMap(const ::std::wstring& domainName, const ::std::wstring& id, const PArrayString& keyNames, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteMap(domainName, id, keyNames, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteMap(const ::std::wstring& domainName, const ::std::wstring& id, const PArrayString& keyNames, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteMap(domainName, id, keyNames, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayContextTerm BStub_IXServicePortIF::getContextTerms(const PFindInfo& findInfo, const ::std::wstring& field, int32_t max)  {
	BSyncResultT< PArrayContextTerm > syncResult;	
	getContextTerms(findInfo, field, max, [&syncResult](PArrayContextTerm v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getContextTerms(const PFindInfo& findInfo, const ::std::wstring& field, int32_t max, ::std::function< void (PArrayContextTerm, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getContextTerms(findInfo, field, max));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayContextTerm, BResult_1005790586 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PAny BStub_IXServicePortIF::executeRegisteredFunction(const ::std::wstring& functionName, const PAny& param)  {
	BSyncResultT< PAny > syncResult;	
	executeRegisteredFunction(functionName, param, [&syncResult](PAny v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::executeRegisteredFunction(const ::std::wstring& functionName, const PAny& param, ::std::function< void (PAny, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_executeRegisteredFunction(functionName, param));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PAny, BResult_1191976387 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
::std::wstring BStub_IXServicePortIF::executeRegisteredFunctionString(const ::std::wstring& functionName, const ::std::wstring& param)  {
	BSyncResultT< ::std::wstring > syncResult;	
	executeRegisteredFunctionString(functionName, param, [&syncResult](::std::wstring v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::executeRegisteredFunctionString(const ::std::wstring& functionName, const ::std::wstring& param, ::std::function< void (::std::wstring, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_executeRegisteredFunctionString(functionName, param));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< ::std::wstring, BResult_10 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayString BStub_IXServicePortIF::getSearchTerms(const PFindInfo& findInfo, int32_t termType)  {
	BSyncResultT< PArrayString > syncResult;	
	getSearchTerms(findInfo, termType, [&syncResult](PArrayString v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getSearchTerms(const PFindInfo& findInfo, int32_t termType, ::std::function< void (PArrayString, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getSearchTerms(findInfo, termType));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayString, BResult_1888107655 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
int32_t BStub_IXServicePortIF::adminMode(int32_t mode)  {
	BSyncResultT< int32_t > syncResult;	
	adminMode(mode, [&syncResult](int32_t v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::adminMode(int32_t mode, ::std::function< void (int32_t, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_adminMode(mode));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< int32_t, BResult_5 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFulltextConfig BStub_IXServicePortIF::configureFulltext(const ::std::wstring& userId, const PFulltextConfig& opts)  {
	BSyncResultT< PFulltextConfig > syncResult;	
	configureFulltext(userId, opts, [&syncResult](PFulltextConfig v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::configureFulltext(const ::std::wstring& userId, const PFulltextConfig& opts, ::std::function< void (PFulltextConfig, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_configureFulltext(userId, opts));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFulltextConfig, BResult_239574905 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PNotifyServerResult BStub_IXServicePortIF::notifyServer(const PNotifyServerInfo& msg)  {
	BSyncResultT< PNotifyServerResult > syncResult;	
	notifyServer(msg, [&syncResult](PNotifyServerResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::notifyServer(const PNotifyServerInfo& msg, ::std::function< void (PNotifyServerResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_notifyServer(msg));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PNotifyServerResult, BResult_810727301 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayBackupProfile BStub_IXServicePortIF::configureBackup(const PArrayBackupProfile& backupProfiles)  {
	BSyncResultT< PArrayBackupProfile > syncResult;	
	configureBackup(backupProfiles, [&syncResult](PArrayBackupProfile v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::configureBackup(const PArrayBackupProfile& backupProfiles, ::std::function< void (PArrayBackupProfile, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_configureBackup(backupProfiles));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayBackupProfile, BResult_1233469422 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PBackupPurgeStatus BStub_IXServicePortIF::controlBackup(const PControlBackupInfo& controlBackupInfo)  {
	BSyncResultT< PBackupPurgeStatus > syncResult;	
	controlBackup(controlBackupInfo, [&syncResult](PBackupPurgeStatus v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::controlBackup(const PControlBackupInfo& controlBackupInfo, ::std::function< void (PBackupPurgeStatus, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_controlBackup(controlBackupInfo));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PBackupPurgeStatus, BResult_52201250 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PPurgeSettings BStub_IXServicePortIF::configurePurge(const PPurgeSettings& purgeSettings)  {
	BSyncResultT< PPurgeSettings > syncResult;	
	configurePurge(purgeSettings, [&syncResult](PPurgeSettings v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::configurePurge(const PPurgeSettings& purgeSettings, ::std::function< void (PPurgeSettings, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_configurePurge(purgeSettings));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PPurgeSettings, BResult_1576340510 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
::std::wstring BStub_IXServicePortIF::addUrlParams(const ::std::wstring& url, const PUrlParams& params)  {
	BSyncResultT< ::std::wstring > syncResult;	
	addUrlParams(url, params, [&syncResult](::std::wstring v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::addUrlParams(const ::std::wstring& url, const PUrlParams& params, ::std::function< void (::std::wstring, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_addUrlParams(url, params));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< ::std::wstring, BResult_10 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
int64_t BStub_IXServicePortIF::openEventBus(const PEventBusParams& params)  {
	BSyncResultT< int64_t > syncResult;	
	openEventBus(params, [&syncResult](int64_t v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::openEventBus(const PEventBusParams& params, ::std::function< void (int64_t, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_openEventBus(params));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< int64_t, BResult_6 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::closeEventBus(int64_t busId)  {
	BSyncResultT< bool > syncResult;	
	closeEventBus(busId, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::closeEventBus(int64_t busId, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_closeEventBus(busId));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
int64_t BStub_IXServicePortIF::createEventBusSubscriber()  {
	BSyncResultT< int64_t > syncResult;	
	createEventBusSubscriber([&syncResult](int64_t v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::createEventBusSubscriber(::std::function< void (int64_t, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_createEventBusSubscriber());
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< int64_t, BResult_6 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteEventBusSubscriber(int64_t subsId)  {
	BSyncResultT< bool > syncResult;	
	deleteEventBusSubscriber(subsId, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteEventBusSubscriber(int64_t subsId, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteEventBusSubscriber(subsId));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
int64_t BStub_IXServicePortIF::createEventBusListener(int64_t subsId, const PEventListener& eventListener)  {
	BSyncResultT< int64_t > syncResult;	
	createEventBusListener(subsId, eventListener, [&syncResult](int64_t v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::createEventBusListener(int64_t subsId, const PEventListener& eventListener, ::std::function< void (int64_t, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_createEventBusListener(subsId, eventListener));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< int64_t, BResult_6 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteEventBusListener(int64_t lsnId)  {
	BSyncResultT< bool > syncResult;	
	deleteEventBusListener(lsnId, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteEventBusListener(int64_t lsnId, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteEventBusListener(lsnId));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayEvent BStub_IXServicePortIF::internalReceiveEvents(int64_t subsId, int64_t timeoutMillis)  {
	BSyncResultT< PArrayEvent > syncResult;	
	internalReceiveEvents(subsId, timeoutMillis, [&syncResult](PArrayEvent v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::internalReceiveEvents(int64_t subsId, int64_t timeoutMillis, ::std::function< void (PArrayEvent, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_internalReceiveEvents(subsId, timeoutMillis));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayEvent, BResult_910482075 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::sendEvents(int64_t subsId, const PArrayEvent& events)  {
	BSyncResultT< bool > syncResult;	
	sendEvents(subsId, events, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::sendEvents(int64_t subsId, const PArrayEvent& events, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_sendEvents(subsId, events));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayString BStub_IXServicePortIF::createRsaKeys()  {
	BSyncResultT< PArrayString > syncResult;	
	createRsaKeys([&syncResult](PArrayString v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::createRsaKeys(::std::function< void (PArrayString, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_createRsaKeys());
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayString, BResult_1888107655 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
::std::wstring BStub_IXServicePortIF::encryptStringRsa(const ::std::wstring& key, const ::std::wstring& data, bool encryptNotDecrypt)  {
	BSyncResultT< ::std::wstring > syncResult;	
	encryptStringRsa(key, data, encryptNotDecrypt, [&syncResult](::std::wstring v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::encryptStringRsa(const ::std::wstring& key, const ::std::wstring& data, bool encryptNotDecrypt, ::std::function< void (::std::wstring, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_encryptStringRsa(key, data, encryptNotDecrypt));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< ::std::wstring, BResult_10 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PActivityProject BStub_IXServicePortIF::createActivityProject(const ::std::wstring& projectName)  {
	BSyncResultT< PActivityProject > syncResult;	
	createActivityProject(projectName, [&syncResult](PActivityProject v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::createActivityProject(const ::std::wstring& projectName, ::std::function< void (PActivityProject, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_createActivityProject(projectName));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PActivityProject, BResult_2121298555 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
::std::wstring BStub_IXServicePortIF::checkinActivityProject(const PActivityProject& actProj, const PLockZ& unlockZ)  {
	BSyncResultT< ::std::wstring > syncResult;	
	checkinActivityProject(actProj, unlockZ, [&syncResult](::std::wstring v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinActivityProject(const PActivityProject& actProj, const PLockZ& unlockZ, ::std::function< void (::std::wstring, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinActivityProject(actProj, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< ::std::wstring, BResult_10 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PActivityProject BStub_IXServicePortIF::checkoutActivityProject(const ::std::wstring& projectName, const PLockZ& lockZ)  {
	BSyncResultT< PActivityProject > syncResult;	
	checkoutActivityProject(projectName, lockZ, [&syncResult](PActivityProject v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutActivityProject(const ::std::wstring& projectName, const PLockZ& lockZ, ::std::function< void (PActivityProject, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutActivityProject(projectName, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PActivityProject, BResult_2121298555 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteActivityProject(const ::std::wstring& projectName, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteActivityProject(projectName, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteActivityProject(const ::std::wstring& projectName, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteActivityProject(projectName, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayActivityProject BStub_IXServicePortIF::findActivityProjects(const PFindActivityProjectsInfo& findInfo)  {
	BSyncResultT< PArrayActivityProject > syncResult;	
	findActivityProjects(findInfo, [&syncResult](PArrayActivityProject v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findActivityProjects(const PFindActivityProjectsInfo& findInfo, ::std::function< void (PArrayActivityProject, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findActivityProjects(findInfo));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayActivityProject, BResult_607287445 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

