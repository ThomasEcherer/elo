#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;



namespace de { namespace elo { namespace ix { namespace client { 
BStub_IXServerEvents::BStub_IXServerEvents(PTransport transport) 
	: BStub(transport) {}
}}}}

// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BStub_IXServerEvents::BSerializable_getTypeId() {
	return 1938363825; 
}
namespace de { namespace elo { namespace ix { namespace client { 
::std::wstring BStub_IXServerEvents::getAppInfo(const PIXServerEventsContext& ec)  {
	BSyncResultT< ::std::wstring > syncResult;	
	getAppInfo(ec, [&syncResult](::std::wstring v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServerEvents::getAppInfo(const PIXServerEventsContext& ec, ::std::function< void (::std::wstring, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_getAppInfo(ec));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< ::std::wstring, BResult_10 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
bool BStub_IXServerEvents::hasMethod(const PIXServerEventsContext& ec, const ::std::wstring& methodName)  {
	BSyncResultT< bool > syncResult;	
	hasMethod(ec, methodName, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServerEvents::hasMethod(const PIXServerEventsContext& ec, const ::std::wstring& methodName, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_hasMethod(ec, methodName));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_1 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onBeforeCheckinSord(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PSordZ& sordZ, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	onBeforeCheckinSord(ec, sord, sordDB, parentSord, sordZ, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onBeforeCheckinSord(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PSordZ& sordZ, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onBeforeCheckinSord(ec, sord, sordDB, parentSord, sordZ, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onAfterCheckinSord(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PSordZ& sordZ, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	onAfterCheckinSord(ec, sord, sordDB, parentSord, sordZ, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onAfterCheckinSord(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PSordZ& sordZ, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onAfterCheckinSord(ec, sord, sordDB, parentSord, sordZ, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onBeforeCheckinDocEnd(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PDocument& doc, const PSordZ& sordZ, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	onBeforeCheckinDocEnd(ec, sord, sordDB, parentSord, doc, sordZ, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onBeforeCheckinDocEnd(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PDocument& doc, const PSordZ& sordZ, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onBeforeCheckinDocEnd(ec, sord, sordDB, parentSord, doc, sordZ, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onAfterCheckinDocEnd(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PDocument& doc, const PSordZ& sordZ, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	onAfterCheckinDocEnd(ec, sord, sordDB, parentSord, doc, sordZ, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onAfterCheckinDocEnd(const PIXServerEventsContext& ec, const PSord& sord, const PSord& sordDB, const PSord& parentSord, const PDocument& doc, const PSordZ& sordZ, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onAfterCheckinDocEnd(ec, sord, sordDB, parentSord, doc, sordZ, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onBeforeDeleteSord(const PIXServerEventsContext& ec, const PSord& parentSord, const PSord& sord, const PLockZ& unlockZ, const PDeleteOptions& delOpts)  {
	BSyncResultT< bool > syncResult;	
	onBeforeDeleteSord(ec, parentSord, sord, unlockZ, delOpts, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onBeforeDeleteSord(const PIXServerEventsContext& ec, const PSord& parentSord, const PSord& sord, const PLockZ& unlockZ, const PDeleteOptions& delOpts, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onBeforeDeleteSord(ec, parentSord, sord, unlockZ, delOpts));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onAfterDeleteSord(const PIXServerEventsContext& ec, const PSord& parentSord, const PSord& sord, const PLockZ& unlockZ, const PDeleteOptions& delOpts, bool ret)  {
	BSyncResultT< bool > syncResult;	
	onAfterDeleteSord(ec, parentSord, sord, unlockZ, delOpts, ret, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onAfterDeleteSord(const PIXServerEventsContext& ec, const PSord& parentSord, const PSord& sord, const PLockZ& unlockZ, const PDeleteOptions& delOpts, bool ret, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onAfterDeleteSord(ec, parentSord, sord, unlockZ, delOpts, ret));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onBeforeRefSord(const PIXServerEventsContext& ec, const PSord& parentSordOld, const PSord& parentSordNew, const PSord& sord, int32_t manSortIndex)  {
	BSyncResultT< bool > syncResult;	
	onBeforeRefSord(ec, parentSordOld, parentSordNew, sord, manSortIndex, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onBeforeRefSord(const PIXServerEventsContext& ec, const PSord& parentSordOld, const PSord& parentSordNew, const PSord& sord, int32_t manSortIndex, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onBeforeRefSord(ec, parentSordOld, parentSordNew, sord, manSortIndex));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onAfterRefSord(const PIXServerEventsContext& ec, const PSord& parentSordOld, const PSord& parentSordNew, const PSord& sord, int32_t manSortIndex)  {
	BSyncResultT< bool > syncResult;	
	onAfterRefSord(ec, parentSordOld, parentSordNew, sord, manSortIndex, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onAfterRefSord(const PIXServerEventsContext& ec, const PSord& parentSordOld, const PSord& parentSordNew, const PSord& sord, int32_t manSortIndex, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onAfterRefSord(ec, parentSordOld, parentSordNew, sord, manSortIndex));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onAfterEndEditWorkFlowNode(const PIXServerEventsContext& ec, const PWFDiagram& workflow, int32_t nodeId, const PSord& sord, const PSordZ& sordZ)  {
	BSyncResultT< bool > syncResult;	
	onAfterEndEditWorkFlowNode(ec, workflow, nodeId, sord, sordZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onAfterEndEditWorkFlowNode(const PIXServerEventsContext& ec, const PWFDiagram& workflow, int32_t nodeId, const PSord& sord, const PSordZ& sordZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onAfterEndEditWorkFlowNode(ec, workflow, nodeId, sord, sordZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onAfterCheckinReminder(const PIXServerEventsContext& ec, const PArrayReminder& remiArray, const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	onAfterCheckinReminder(ec, remiArray, sord, sordZ, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onAfterCheckinReminder(const PIXServerEventsContext& ec, const PArrayReminder& remiArray, const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onAfterCheckinReminder(ec, remiArray, sord, sordZ, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PAny BStub_IXServerEvents::executeRegisteredFunction(const PIXServerEventsContext& ec, const ::std::wstring& functionName, const PAny& any)  {
	BSyncResultT< PAny > syncResult;	
	executeRegisteredFunction(ec, functionName, any, [&syncResult](PAny v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServerEvents::executeRegisteredFunction(const PIXServerEventsContext& ec, const ::std::wstring& functionName, const PAny& any, ::std::function< void (PAny, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_executeRegisteredFunction(ec, functionName, any));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PAny, BResult_1191976387 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
::std::wstring BStub_IXServerEvents::executeRegisteredFunctionString(const PIXServerEventsContext& ec, const ::std::wstring& functionName, const ::std::wstring& args)  {
	BSyncResultT< ::std::wstring > syncResult;	
	executeRegisteredFunctionString(ec, functionName, args, [&syncResult](::std::wstring v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServerEvents::executeRegisteredFunctionString(const PIXServerEventsContext& ec, const ::std::wstring& functionName, const ::std::wstring& args, ::std::function< void (::std::wstring, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_executeRegisteredFunctionString(ec, functionName, args));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< ::std::wstring, BResult_10 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onBeforeStartWorkFlow(const PIXServerEventsContext& ec, const PWFDiagram& workflow, const PSord& sord, const PSordZ& sordZ)  {
	BSyncResultT< bool > syncResult;	
	onBeforeStartWorkFlow(ec, workflow, sord, sordZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onBeforeStartWorkFlow(const PIXServerEventsContext& ec, const PWFDiagram& workflow, const PSord& sord, const PSordZ& sordZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onBeforeStartWorkFlow(ec, workflow, sord, sordZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onAfterStartWorkFlow(const PIXServerEventsContext& ec, const PWFDiagram& workflow, const PSord& sord, const PSordZ& sordZ)  {
	BSyncResultT< bool > syncResult;	
	onAfterStartWorkFlow(ec, workflow, sord, sordZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onAfterStartWorkFlow(const PIXServerEventsContext& ec, const PWFDiagram& workflow, const PSord& sord, const PSordZ& sordZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onAfterStartWorkFlow(ec, workflow, sord, sordZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onBeforeCheckinActivity(const PIXServerEventsContext& ec, const PActivity& act, bool isNew, const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	onBeforeCheckinActivity(ec, act, isNew, sord, sordZ, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onBeforeCheckinActivity(const PIXServerEventsContext& ec, const PActivity& act, bool isNew, const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onBeforeCheckinActivity(ec, act, isNew, sord, sordZ, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onAfterCheckinActivity(const PIXServerEventsContext& ec, const PActivity& act, bool isNew, const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	onAfterCheckinActivity(ec, act, isNew, sord, sordZ, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onAfterCheckinActivity(const PIXServerEventsContext& ec, const PActivity& act, bool isNew, const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onAfterCheckinActivity(ec, act, isNew, sord, sordZ, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onBeforeCheckinNotes(const PIXServerEventsContext& ec, const PArrayNote& notes, const PArraySord& sords, int64_t noteC, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	onBeforeCheckinNotes(ec, notes, sords, noteC, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onBeforeCheckinNotes(const PIXServerEventsContext& ec, const PArrayNote& notes, const PArraySord& sords, int64_t noteC, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onBeforeCheckinNotes(ec, notes, sords, noteC, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onAfterCheckinNotes(const PIXServerEventsContext& ec, const PArrayNote& notes, const PArraySord& sords, int64_t noteC, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	onAfterCheckinNotes(ec, notes, sords, noteC, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onAfterCheckinNotes(const PIXServerEventsContext& ec, const PArrayNote& notes, const PArraySord& sords, int64_t noteC, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onAfterCheckinNotes(ec, notes, sords, noteC, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onFileUploadBuildResponse(const PIXServerEventsContext& ec, const PDocVersion& dv, const ::std::wstring& fileName, const PHttpRequestInfo& requestInfo, const PHttpResponseInfo& responseInfo)  {
	BSyncResultT< bool > syncResult;	
	onFileUploadBuildResponse(ec, dv, fileName, requestInfo, responseInfo, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onFileUploadBuildResponse(const PIXServerEventsContext& ec, const PDocVersion& dv, const ::std::wstring& fileName, const PHttpRequestInfo& requestInfo, const PHttpResponseInfo& responseInfo, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onFileUploadBuildResponse(ec, dv, fileName, requestInfo, responseInfo));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayUserName BStub_IXServerEvents::getUserNames(const PIXServerEventsContext& ec, const PArrayString& ids, const PCheckoutUsersZ& checkoutUsersZ)  {
	BSyncResultT< PArrayUserName > syncResult;	
	getUserNames(ec, ids, checkoutUsersZ, [&syncResult](PArrayUserName v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServerEvents::getUserNames(const PIXServerEventsContext& ec, const PArrayString& ids, const PCheckoutUsersZ& checkoutUsersZ, ::std::function< void (PArrayUserName, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_getUserNames(ec, ids, checkoutUsersZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayUserName, BResult_1001617329 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onReadSord(const PIXServerEventsContext& ec, const PSord& sord, const PSordZ& sordZ, const PDocument& doc, const PLockZ& lockZ)  {
	BSyncResultT< bool > syncResult;	
	onReadSord(ec, sord, sordZ, doc, lockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onReadSord(const PIXServerEventsContext& ec, const PSord& sord, const PSordZ& sordZ, const PDocument& doc, const PLockZ& lockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onReadSord(ec, sord, sordZ, doc, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
bool BStub_IXServerEvents::onCheckSordAccess(const PIXServerEventsContext& ec, const PSord& sord, const PSordZ& sordZ, int32_t lur, const PCheckAccessOptions& opts)  {
	BSyncResultT< bool > syncResult;	
	onCheckSordAccess(ec, sord, sordZ, lur, opts, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServerEvents::onCheckSordAccess(const PIXServerEventsContext& ec, const PSord& sord, const PSordZ& sordZ, int32_t lur, const PCheckAccessOptions& opts, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onCheckSordAccess(ec, sord, sordZ, lur, opts));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_1 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onBeforeLogin(const PIXServerEventsContext& ec, const ::std::wstring& userName, const PLoginScriptOptions& opts)  {
	BSyncResultT< bool > syncResult;	
	onBeforeLogin(ec, userName, opts, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onBeforeLogin(const PIXServerEventsContext& ec, const ::std::wstring& userName, const PLoginScriptOptions& opts, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onBeforeLogin(ec, userName, opts));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onAfterLogin(const PIXServerEventsContext& ec, const ::std::wstring& userName, const PLoginScriptOptions& opts)  {
	BSyncResultT< bool > syncResult;	
	onAfterLogin(ec, userName, opts, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onAfterLogin(const PIXServerEventsContext& ec, const ::std::wstring& userName, const PLoginScriptOptions& opts, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onAfterLogin(ec, userName, opts));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PEditInfo BStub_IXServerEvents::onCreateSord(const PIXServerEventsContext& ec, const ::std::wstring& parentId, const ::std::wstring& maskId, const PEditInfoZ& editZ)  {
	BSyncResultT< PEditInfo > syncResult;	
	onCreateSord(ec, parentId, maskId, editZ, [&syncResult](PEditInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServerEvents::onCreateSord(const PIXServerEventsContext& ec, const ::std::wstring& parentId, const ::std::wstring& maskId, const PEditInfoZ& editZ, ::std::function< void (PEditInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onCreateSord(ec, parentId, maskId, editZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PEditInfo, BResult_820228328 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PEditInfo BStub_IXServerEvents::onCreateDoc(const PIXServerEventsContext& ec, const ::std::wstring& parentId, const ::std::wstring& maskId, const ::std::wstring& docTemplate, const PEditInfoZ& editInfoZ)  {
	BSyncResultT< PEditInfo > syncResult;	
	onCreateDoc(ec, parentId, maskId, docTemplate, editInfoZ, [&syncResult](PEditInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServerEvents::onCreateDoc(const PIXServerEventsContext& ec, const ::std::wstring& parentId, const ::std::wstring& maskId, const ::std::wstring& docTemplate, const PEditInfoZ& editInfoZ, ::std::function< void (PEditInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onCreateDoc(ec, parentId, maskId, docTemplate, editInfoZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PEditInfo, BResult_820228328 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayUserInfo BStub_IXServerEvents::onBeforeCheckinUsers(const PIXServerEventsContext& ec, const PArrayUserInfo& userInfos, const PCheckinUsersZ& checkinUsersZ, const PLockZ& unlockZ)  {
	BSyncResultT< PArrayUserInfo > syncResult;	
	onBeforeCheckinUsers(ec, userInfos, checkinUsersZ, unlockZ, [&syncResult](PArrayUserInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServerEvents::onBeforeCheckinUsers(const PIXServerEventsContext& ec, const PArrayUserInfo& userInfos, const PCheckinUsersZ& checkinUsersZ, const PLockZ& unlockZ, ::std::function< void (PArrayUserInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onBeforeCheckinUsers(ec, userInfos, checkinUsersZ, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayUserInfo, BResult_1132956238 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onAfterCheckinUsers(const PIXServerEventsContext& ec, const PArrayUserInfo& userInfos, const PCheckinUsersZ& checkinUsersZ, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	onAfterCheckinUsers(ec, userInfos, checkinUsersZ, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onAfterCheckinUsers(const PIXServerEventsContext& ec, const PArrayUserInfo& userInfos, const PCheckinUsersZ& checkinUsersZ, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onAfterCheckinUsers(ec, userInfos, checkinUsersZ, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayKeyValue BStub_IXServerEvents::onBeforeCheckinMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, int32_t objId, const PArrayKeyValue& data, const PLockZ& unlockZ)  {
	BSyncResultT< PArrayKeyValue > syncResult;	
	onBeforeCheckinMap(ec, domainName, id, objId, data, unlockZ, [&syncResult](PArrayKeyValue v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServerEvents::onBeforeCheckinMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, int32_t objId, const PArrayKeyValue& data, const PLockZ& unlockZ, ::std::function< void (PArrayKeyValue, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onBeforeCheckinMap(ec, domainName, id, objId, data, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayKeyValue, BResult_1826370901 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onAfterCheckinMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, int32_t objId, const PArrayKeyValue& data, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	onAfterCheckinMap(ec, domainName, id, objId, data, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onAfterCheckinMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, int32_t objId, const PArrayKeyValue& data, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onAfterCheckinMap(ec, domainName, id, objId, data, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayString BStub_IXServerEvents::onBeforeDeleteMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, const PArrayString& keyNames, const PLockZ& unlockZ)  {
	BSyncResultT< PArrayString > syncResult;	
	onBeforeDeleteMap(ec, domainName, id, keyNames, unlockZ, [&syncResult](PArrayString v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServerEvents::onBeforeDeleteMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, const PArrayString& keyNames, const PLockZ& unlockZ, ::std::function< void (PArrayString, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onBeforeDeleteMap(ec, domainName, id, keyNames, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayString, BResult_1888107655 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onAfterDeleteMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, const PArrayString& keyNames, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	onAfterDeleteMap(ec, domainName, id, keyNames, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onAfterDeleteMap(const PIXServerEventsContext& ec, const ::std::wstring& domainName, const ::std::wstring& id, const PArrayString& keyNames, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onAfterDeleteMap(ec, domainName, id, keyNames, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onBeforeTakeWorkFlowNode(const PIXServerEventsContext& ec, const PWFDiagram& workflow, const PWFNode& node, const PUserInfo& user, int32_t flags, const PLockZ& lockZ)  {
	BSyncResultT< bool > syncResult;	
	onBeforeTakeWorkFlowNode(ec, workflow, node, user, flags, lockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onBeforeTakeWorkFlowNode(const PIXServerEventsContext& ec, const PWFDiagram& workflow, const PWFNode& node, const PUserInfo& user, int32_t flags, const PLockZ& lockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onBeforeTakeWorkFlowNode(ec, workflow, node, user, flags, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onBeforeFindSords(const PIXServerEventsContext& ec, const PFindInfo& findInfo, const PSordZ& sordZ)  {
	BSyncResultT< bool > syncResult;	
	onBeforeFindSords(ec, findInfo, sordZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onBeforeFindSords(const PIXServerEventsContext& ec, const PFindInfo& findInfo, const PSordZ& sordZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onBeforeFindSords(ec, findInfo, sordZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onBeforeFindSordsInternalSQL(const PIXServerEventsContext& ec, const PFindInfo& findInfo, const PSordZ& sordZ, const PFindInfoAsInternalSQL& findSql)  {
	BSyncResultT< bool > syncResult;	
	onBeforeFindSordsInternalSQL(ec, findInfo, sordZ, findSql, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onBeforeFindSordsInternalSQL(const PIXServerEventsContext& ec, const PFindInfo& findInfo, const PSordZ& sordZ, const PFindInfoAsInternalSQL& findSql, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onBeforeFindSordsInternalSQL(ec, findInfo, sordZ, findSql));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onFindSordsResult(const PIXServerEventsContext& ec, const PFindInfo& findInfo, const PSordZ& sordZ, const PFindResult& findResult)  {
	BSyncResultT< bool > syncResult;	
	onFindSordsResult(ec, findInfo, sordZ, findResult, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onFindSordsResult(const PIXServerEventsContext& ec, const PFindInfo& findInfo, const PSordZ& sordZ, const PFindResult& findResult, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onFindSordsResult(ec, findInfo, sordZ, findResult));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServerEvents::onFindClose(const PIXServerEventsContext& ec, const PSerializable& findInfo)  {
	BSyncResultT< bool > syncResult;	
	onFindClose(ec, findInfo, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServerEvents::onFindClose(const PIXServerEventsContext& ec, const PSerializable& findInfo, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onFindClose(ec, findInfo));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
InheritKeywordingResult BStub_IXServerEvents::onInheritKeywording(const PIXServerEventsContext& ec, const PSord& sord, const PSord& parentSord, const PArrayString& okeyNames, const PSerializable& reserved)  {
	BSyncResultT< InheritKeywordingResult > syncResult;	
	onInheritKeywording(ec, sord, parentSord, okeyNames, reserved, [&syncResult](InheritKeywordingResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServerEvents::onInheritKeywording(const PIXServerEventsContext& ec, const PSord& sord, const PSord& parentSord, const PArrayString& okeyNames, const PSerializable& reserved, ::std::function< void (InheritKeywordingResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServerEvents_onInheritKeywording(ec, sord, parentSord, okeyNames, reserved));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< InheritKeywordingResult, BResult_892356058 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

// checkpoint byps.gen.cpp.GenRemoteStub:224
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1938363825(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* reserved){
	BSerializer_16_Template<de::elo::ix::client::BStub_IXServerEvents, 1938363825>(bio, pObj, pObjS, reserved);
}
}}}}



namespace de { namespace elo { namespace ix { namespace client { 
BStub_IXServicePortIF::BStub_IXServicePortIF(PTransport transport) 
	: BStub(transport) {}
}}}}

// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::BStub_IXServicePortIF::BSerializable_getTypeId() {
	return 1795705954; 
}
namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::alive()  {
	BSyncResultT< bool > syncResult;	
	alive([&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::alive(::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_alive());
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PWFEditNode BStub_IXServicePortIF::beginEditWorkFlowNode(int32_t nFlowId, int32_t nNodeId, const PLockZ& lockZ)  {
	BSyncResultT< PWFEditNode > syncResult;	
	beginEditWorkFlowNode(nFlowId, nNodeId, lockZ, [&syncResult](PWFEditNode v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::beginEditWorkFlowNode(int32_t nFlowId, int32_t nNodeId, const PLockZ& lockZ, ::std::function< void (PWFEditNode, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_beginEditWorkFlowNode(nFlowId, nNodeId, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PWFEditNode, BResult_1822579866 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PEditInfo BStub_IXServicePortIF::changeSordMask(const PSord& sord, const ::std::wstring& maskId, const PEditInfoZ& editInfoZ)  {
	BSyncResultT< PEditInfo > syncResult;	
	changeSordMask(sord, maskId, editInfoZ, [&syncResult](PEditInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::changeSordMask(const PSord& sord, const ::std::wstring& maskId, const PEditInfoZ& editInfoZ, ::std::function< void (PEditInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_changeSordMask(sord, maskId, editInfoZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PEditInfo, BResult_820228328 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::checkinColors(const PArrayColorData& colors, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	checkinColors(colors, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::checkinColors(const PArrayColorData& colors, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinColors(colors, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::checkinConfigFiles(const PArrayConfigFile& configFiles, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	checkinConfigFiles(configFiles, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::checkinConfigFiles(const PArrayConfigFile& configFiles, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinConfigFiles(configFiles, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayConfigFile BStub_IXServicePortIF::checkinConfigFilesBegin(const PArrayString& names)  {
	BSyncResultT< PArrayConfigFile > syncResult;	
	checkinConfigFilesBegin(names, [&syncResult](PArrayConfigFile v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinConfigFilesBegin(const PArrayString& names, ::std::function< void (PArrayConfigFile, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinConfigFilesBegin(names));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayConfigFile, BResult_1737266313 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayConfigFile BStub_IXServicePortIF::checkinConfigFilesEnd(const PArrayConfigFile& configFiles, const PLockZ& unlockZ)  {
	BSyncResultT< PArrayConfigFile > syncResult;	
	checkinConfigFilesEnd(configFiles, unlockZ, [&syncResult](PArrayConfigFile v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinConfigFilesEnd(const PArrayConfigFile& configFiles, const PLockZ& unlockZ, ::std::function< void (PArrayConfigFile, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinConfigFilesEnd(configFiles, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayConfigFile, BResult_1737266313 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::checkinCounters(const PArrayCounterInfo& counterInfos, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	checkinCounters(counterInfos, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::checkinCounters(const PArrayCounterInfo& counterInfos, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinCounters(counterInfos, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PDocument BStub_IXServicePortIF::checkinDocBegin(const PDocument& document)  {
	BSyncResultT< PDocument > syncResult;	
	checkinDocBegin(document, [&syncResult](PDocument v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinDocBegin(const PDocument& document, ::std::function< void (PDocument, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinDocBegin(document));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PDocument, BResult_341056676 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PDocument BStub_IXServicePortIF::checkinDocDupl(const PSord& sord, const PSordZ& sordZ, const PDocument& document, const PLockZ& unlockZ)  {
	BSyncResultT< PDocument > syncResult;	
	checkinDocDupl(sord, sordZ, document, unlockZ, [&syncResult](PDocument v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinDocDupl(const PSord& sord, const PSordZ& sordZ, const PDocument& document, const PLockZ& unlockZ, ::std::function< void (PDocument, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinDocDupl(sord, sordZ, document, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PDocument, BResult_341056676 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PDocument BStub_IXServicePortIF::checkinDocEnd(const PSord& sord, const PSordZ& sordZ, const PDocument& document, const PLockZ& unlockZ)  {
	BSyncResultT< PDocument > syncResult;	
	checkinDocEnd(sord, sordZ, document, unlockZ, [&syncResult](PDocument v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinDocEnd(const PSord& sord, const PSordZ& sordZ, const PDocument& document, const PLockZ& unlockZ, ::std::function< void (PDocument, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinDocEnd(sord, sordZ, document, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PDocument, BResult_341056676 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
int32_t BStub_IXServicePortIF::checkinDocMask(const PDocMask& docMask, const PDocMaskZ& docMaskZ, const PLockZ& unlockZ)  {
	BSyncResultT< int32_t > syncResult;	
	checkinDocMask(docMask, docMaskZ, unlockZ, [&syncResult](int32_t v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinDocMask(const PDocMask& docMask, const PDocMaskZ& docMaskZ, const PLockZ& unlockZ, ::std::function< void (int32_t, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinDocMask(docMask, docMaskZ, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< int32_t, BResult_5 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayDocument BStub_IXServicePortIF::checkinDocsBegin(const PArrayDocument& documents)  {
	BSyncResultT< PArrayDocument > syncResult;	
	checkinDocsBegin(documents, [&syncResult](PArrayDocument v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinDocsBegin(const PArrayDocument& documents, ::std::function< void (PArrayDocument, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinDocsBegin(documents));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayDocument, BResult_1047127860 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayDocument BStub_IXServicePortIF::checkinDocsEnd(const PArraySord& sords, const PArraySordZ& sordZs, const PArrayDocument& documents, const PLockZ& unlockZ)  {
	BSyncResultT< PArrayDocument > syncResult;	
	checkinDocsEnd(sords, sordZs, documents, unlockZ, [&syncResult](PArrayDocument v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinDocsEnd(const PArraySord& sords, const PArraySordZ& sordZs, const PArrayDocument& documents, const PLockZ& unlockZ, ::std::function< void (PArrayDocument, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinDocsEnd(sords, sordZs, documents, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayDocument, BResult_1047127860 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayInt BStub_IXServicePortIF::checkinKeys(const PArrayKeyInfo& keyInfos, const PLockZ& unlockZ)  {
	BSyncResultT< PArrayInt > syncResult;	
	checkinKeys(keyInfos, unlockZ, [&syncResult](PArrayInt v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinKeys(const PArrayKeyInfo& keyInfos, const PLockZ& unlockZ, ::std::function< void (PArrayInt, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinKeys(keyInfos, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayInt, BResult_100361105 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

