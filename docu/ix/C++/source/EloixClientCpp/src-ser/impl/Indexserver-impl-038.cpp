#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteNotes(const PArrayString& noteIds, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteNotes(noteIds, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteNotes(const PArrayString& noteIds, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteNotes(noteIds, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
int32_t BStub_IXServicePortIF::deleteNotification(const ::std::wstring& objGuid, const ::std::wstring& userGuid)  {
	BSyncResultT< int32_t > syncResult;	
	deleteNotification(objGuid, userGuid, [&syncResult](int32_t v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::deleteNotification(const ::std::wstring& objGuid, const ::std::wstring& userGuid, ::std::function< void (int32_t, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteNotification(objGuid, userGuid));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< int32_t, BResult_5 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteReminders(const PArrayInt& reminderIds, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteReminders(reminderIds, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteReminders(const PArrayInt& reminderIds, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteReminders(reminderIds, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteReport(const ::std::wstring& endDateISO)  {
	BSyncResultT< bool > syncResult;	
	deleteReport(endDateISO, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteReport(const ::std::wstring& endDateISO, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteReport(endDateISO));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
bool BStub_IXServicePortIF::deleteSord(const ::std::wstring& parentId, const ::std::wstring& objId, const PLockZ& unlockZ, const PDeleteOptions& deleteOptions)  {
	BSyncResultT< bool > syncResult;	
	deleteSord(parentId, objId, unlockZ, deleteOptions, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::deleteSord(const ::std::wstring& parentId, const ::std::wstring& objId, const PLockZ& unlockZ, const PDeleteOptions& deleteOptions, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteSord(parentId, objId, unlockZ, deleteOptions));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_1 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteSordTypes(const PArrayInt& sordTypeIds, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteSordTypes(sordTypeIds, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteSordTypes(const PArrayInt& sordTypeIds, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteSordTypes(sordTypeIds, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteSubs(const PArraySubsInfo& deps, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteSubs(deps, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteSubs(const PArraySubsInfo& deps, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteSubs(deps, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteUserProfile(const PUserProfile& userProfile, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteUserProfile(userProfile, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteUserProfile(const PUserProfile& userProfile, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteUserProfile(userProfile, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteUsers(const PArrayString& ids, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteUsers(ids, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteUsers(const PArrayString& ids, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteUsers(ids, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteWorkFlow(const ::std::wstring& flowId, const PWFTypeZ& typeZ, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteWorkFlow(flowId, typeZ, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteWorkFlow(const ::std::wstring& flowId, const PWFTypeZ& typeZ, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteWorkFlow(flowId, typeZ, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::endEditWorkFlowNode(int32_t nFlowId, int32_t nNodeId, bool bTerminate, bool bCancel, const ::std::wstring& sName, const ::std::wstring& sComment, const PArrayInt& arrEnterNodesIds)  {
	BSyncResultT< bool > syncResult;	
	endEditWorkFlowNode(nFlowId, nNodeId, bTerminate, bCancel, sName, sComment, arrEnterNodesIds, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::endEditWorkFlowNode(int32_t nFlowId, int32_t nNodeId, bool bTerminate, bool bCancel, const ::std::wstring& sName, const ::std::wstring& sComment, const PArrayInt& arrEnterNodesIds, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_endEditWorkFlowNode(nFlowId, nNodeId, bTerminate, bCancel, sName, sComment, arrEnterNodesIds));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::findClose(const ::std::wstring& searchId)  {
	BSyncResultT< bool > syncResult;	
	findClose(searchId, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::findClose(const ::std::wstring& searchId, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findClose(searchId));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findFirstConfigFiles(const PFindConfigFileInfo& findInfo, int32_t max, const PConfigFileZ& configFileZ)  {
	BSyncResultT< PFindResult > syncResult;	
	findFirstConfigFiles(findInfo, max, configFileZ, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findFirstConfigFiles(const PFindConfigFileInfo& findInfo, int32_t max, const PConfigFileZ& configFileZ, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findFirstConfigFiles(findInfo, max, configFileZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findFirstReportInfos(const PFindReportInfo& opts, int32_t max)  {
	BSyncResultT< PFindResult > syncResult;	
	findFirstReportInfos(opts, max, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findFirstReportInfos(const PFindReportInfo& opts, int32_t max, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findFirstReportInfos(opts, max));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findFirstSords(const PFindInfo& findInfo, int32_t max, const PSordZ& sordZ)  {
	BSyncResultT< PFindResult > syncResult;	
	findFirstSords(findInfo, max, sordZ, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findFirstSords(const PFindInfo& findInfo, int32_t max, const PSordZ& sordZ, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findFirstSords(findInfo, max, sordZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findFirstTasks(const PFindTasksInfo& findInfo, int32_t max)  {
	BSyncResultT< PFindResult > syncResult;	
	findFirstTasks(findInfo, max, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findFirstTasks(const PFindTasksInfo& findInfo, int32_t max, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findFirstTasks(findInfo, max));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findNextConfigFiles(const ::std::wstring& searchId, int32_t idx, int32_t max, const PConfigFileZ& configFileZ)  {
	BSyncResultT< PFindResult > syncResult;	
	findNextConfigFiles(searchId, idx, max, configFileZ, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findNextConfigFiles(const ::std::wstring& searchId, int32_t idx, int32_t max, const PConfigFileZ& configFileZ, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findNextConfigFiles(searchId, idx, max, configFileZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findNextReportInfos(const ::std::wstring& searchId, int32_t idx, int32_t max)  {
	BSyncResultT< PFindResult > syncResult;	
	findNextReportInfos(searchId, idx, max, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findNextReportInfos(const ::std::wstring& searchId, int32_t idx, int32_t max, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findNextReportInfos(searchId, idx, max));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findNextSords(const ::std::wstring& searchId, int32_t idx, int32_t max, const PSordZ& sordZ)  {
	BSyncResultT< PFindResult > syncResult;	
	findNextSords(searchId, idx, max, sordZ, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findNextSords(const ::std::wstring& searchId, int32_t idx, int32_t max, const PSordZ& sordZ, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findNextSords(searchId, idx, max, sordZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findNextTasks(const ::std::wstring& searchId, int32_t idx, int32_t max)  {
	BSyncResultT< PFindResult > syncResult;	
	findNextTasks(searchId, idx, max, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findNextTasks(const ::std::wstring& searchId, int32_t idx, int32_t max, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findNextTasks(searchId, idx, max));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::finishExport(const ::std::wstring& exportId)  {
	BSyncResultT< bool > syncResult;	
	finishExport(exportId, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::finishExport(const ::std::wstring& exportId, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_finishExport(exportId));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PIXServicePortC BStub_IXServicePortIF::getConstants()  {
	BSyncResultT< PIXServicePortC > syncResult;	
	getConstants([&syncResult](PIXServicePortC v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getConstants(::std::function< void (PIXServicePortC, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getConstants());
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PIXServicePortC, BResult_1264954948 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
::std::wstring BStub_IXServicePortIF::getExportZipUrl(const ::std::wstring& exportId)  {
	BSyncResultT< ::std::wstring > syncResult;	
	getExportZipUrl(exportId, [&syncResult](::std::wstring v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getExportZipUrl(const ::std::wstring& exportId, ::std::function< void (::std::wstring, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getExportZipUrl(exportId));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< ::std::wstring, BResult_10 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
::std::wstring BStub_IXServicePortIF::getImportZipUrl(const ::std::wstring& importId)  {
	BSyncResultT< ::std::wstring > syncResult;	
	getImportZipUrl(importId, [&syncResult](::std::wstring v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getImportZipUrl(const ::std::wstring& importId, ::std::function< void (::std::wstring, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getImportZipUrl(importId));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< ::std::wstring, BResult_10 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PServerInfo BStub_IXServicePortIF::getServerInfo()  {
	BSyncResultT< PServerInfo > syncResult;	
	getServerInfo([&syncResult](PServerInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getServerInfo(::std::function< void (PServerInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getServerInfo());
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PServerInfo, BResult_1701204890 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::setServerInfo(const PServerInfo& serverInfo)  {
	BSyncResultT< bool > syncResult;	
	setServerInfo(serverInfo, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::setServerInfo(const PServerInfo& serverInfo, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_setServerInfo(serverInfo));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PServerInfoDM BStub_IXServicePortIF::getServerInfoDM()  {
	BSyncResultT< PServerInfoDM > syncResult;	
	getServerInfoDM([&syncResult](PServerInfoDM v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getServerInfoDM(::std::function< void (PServerInfoDM, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getServerInfoDM());
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PServerInfoDM, BResult_1425760760 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::setServerInfoDM(const PServerInfoDM& serverInfo)  {
	BSyncResultT< bool > syncResult;	
	setServerInfoDM(serverInfo, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::setServerInfoDM(const PServerInfoDM& serverInfo, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_setServerInfoDM(serverInfo));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PSessionOptions BStub_IXServicePortIF::getSessionOptions()  {
	BSyncResultT< PSessionOptions > syncResult;	
	getSessionOptions([&syncResult](PSessionOptions v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getSessionOptions(::std::function< void (PSessionOptions, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getSessionOptions());
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PSessionOptions, BResult_1197100286 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayUserName BStub_IXServicePortIF::getUserNames(const PArrayString& ids, const PCheckoutUsersZ& checkoutUsersZ)  {
	BSyncResultT< PArrayUserName > syncResult;	
	getUserNames(ids, checkoutUsersZ, [&syncResult](PArrayUserName v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getUserNames(const PArrayString& ids, const PCheckoutUsersZ& checkoutUsersZ, ::std::function< void (PArrayUserName, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getUserNames(ids, checkoutUsersZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayUserName, BResult_1001617329 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
int32_t BStub_IXServicePortIF::importWorkFlow(const ::std::wstring& flowName, const PBytes& fileData)  {
	BSyncResultT< int32_t > syncResult;	
	importWorkFlow(flowName, fileData, [&syncResult](int32_t v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::importWorkFlow(const ::std::wstring& flowName, const PBytes& fileData, ::std::function< void (int32_t, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_importWorkFlow(flowName, fileData));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< int32_t, BResult_5 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
int32_t BStub_IXServicePortIF::importWorkFlow2(const ::std::wstring& flowName, const PBytes& fileData, const PWorkflowImportOptions& importOptions)  {
	BSyncResultT< int32_t > syncResult;	
	importWorkFlow2(flowName, fileData, importOptions, [&syncResult](int32_t v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::importWorkFlow2(const ::std::wstring& flowName, const PBytes& fileData, const PWorkflowImportOptions& importOptions, ::std::function< void (int32_t, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_importWorkFlow2(flowName, fileData, importOptions));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< int32_t, BResult_5 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::linkSords(const ::std::wstring& fromId, const PArrayString& toIds, const PLinkSordZ& linkZ)  {
	BSyncResultT< bool > syncResult;	
	linkSords(fromId, toIds, linkZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::linkSords(const ::std::wstring& fromId, const PArrayString& toIds, const PLinkSordZ& linkZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_linkSords(fromId, toIds, linkZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
int32_t BStub_IXServicePortIF::lockArchive(const ::std::wstring& keyId)  {
	BSyncResultT< int32_t > syncResult;	
	lockArchive(keyId, [&syncResult](int32_t v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::lockArchive(const ::std::wstring& keyId, ::std::function< void (int32_t, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_lockArchive(keyId));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< int32_t, BResult_5 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PLoginResult BStub_IXServicePortIF::login(const ::std::wstring& userName, const ::std::wstring& userPwd, const ::std::wstring& clientComputer, const ::std::wstring& runAsUser)  {
	BSyncResultT< PLoginResult > syncResult;	
	login(userName, userPwd, clientComputer, runAsUser, [&syncResult](PLoginResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::login(const ::std::wstring& userName, const ::std::wstring& userPwd, const ::std::wstring& clientComputer, const ::std::wstring& runAsUser, ::std::function< void (PLoginResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_login(userName, userPwd, clientComputer, runAsUser));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PLoginResult, BResult_777531606 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PLoginResult BStub_IXServicePortIF::loginAdmin(const ::std::wstring& userName, const ::std::wstring& userPwd, const ::std::wstring& clientComputer, const ::std::wstring& reportAsUser)  {
	BSyncResultT< PLoginResult > syncResult;	
	loginAdmin(userName, userPwd, clientComputer, reportAsUser, [&syncResult](PLoginResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::loginAdmin(const ::std::wstring& userName, const ::std::wstring& userPwd, const ::std::wstring& clientComputer, const ::std::wstring& reportAsUser, ::std::function< void (PLoginResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_loginAdmin(userName, userPwd, clientComputer, reportAsUser));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PLoginResult, BResult_777531606 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PLoginResult BStub_IXServicePortIF::loginEloProf(int32_t userId, const ::std::wstring& certificate, const ::std::wstring& clientComputer)  {
	BSyncResultT< PLoginResult > syncResult;	
	loginEloProf(userId, certificate, clientComputer, [&syncResult](PLoginResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::loginEloProf(int32_t userId, const ::std::wstring& certificate, const ::std::wstring& clientComputer, ::std::function< void (PLoginResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_loginEloProf(userId, certificate, clientComputer));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PLoginResult, BResult_777531606 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PLoginResult BStub_IXServicePortIF::loginKerberos(const PBytes& ticket, const ::std::wstring& clientComputer)  {
	BSyncResultT< PLoginResult > syncResult;	
	loginKerberos(ticket, clientComputer, [&syncResult](PLoginResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::loginKerberos(const PBytes& ticket, const ::std::wstring& clientComputer, ::std::function< void (PLoginResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_loginKerberos(ticket, clientComputer));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PLoginResult, BResult_777531606 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::logout()  {
	BSyncResultT< bool > syncResult;	
	logout([&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::logout(::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_logout());
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PIXExceptionData BStub_IXServicePortIF::parseException(const ::std::wstring& exceptionString)  {
	BSyncResultT< PIXExceptionData > syncResult;	
	parseException(exceptionString, [&syncResult](PIXExceptionData v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::parseException(const ::std::wstring& exceptionString, ::std::function< void (PIXExceptionData, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_parseException(exceptionString));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PIXExceptionData, BResult_784089396 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PJobState BStub_IXServicePortIF::processFindResult(const ::std::wstring& searchId, const PProcessInfo& procInfo)  {
	BSyncResultT< PJobState > syncResult;	
	processFindResult(searchId, procInfo, [&syncResult](PJobState v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::processFindResult(const ::std::wstring& searchId, const PProcessInfo& procInfo, ::std::function< void (PJobState, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_processFindResult(searchId, procInfo));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PJobState, BResult_1436376940 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PJobState BStub_IXServicePortIF::processTrees(const PNavigationInfo& navigationInfo, const PProcessInfo& procInfo)  {
	BSyncResultT< PJobState > syncResult;	
	processTrees(navigationInfo, procInfo, [&syncResult](PJobState v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::processTrees(const PNavigationInfo& navigationInfo, const PProcessInfo& procInfo, ::std::function< void (PJobState, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_processTrees(navigationInfo, procInfo));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PJobState, BResult_1436376940 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PJobState BStub_IXServicePortIF::queryJobState(const ::std::wstring& jobGuid, bool activeJobs, bool finishedJobs, bool fullInfo)  {
	BSyncResultT< PJobState > syncResult;	
	queryJobState(jobGuid, activeJobs, finishedJobs, fullInfo, [&syncResult](PJobState v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::queryJobState(const ::std::wstring& jobGuid, bool activeJobs, bool finishedJobs, bool fullInfo, ::std::function< void (PJobState, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_queryJobState(jobGuid, activeJobs, finishedJobs, fullInfo));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PJobState, BResult_1436376940 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::refSord(const ::std::wstring& oldParentId, const ::std::wstring& newParentId, const ::std::wstring& objId, int32_t manSortIdx)  {
	BSyncResultT< bool > syncResult;	
	refSord(oldParentId, newParentId, objId, manSortIdx, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::refSord(const ::std::wstring& oldParentId, const ::std::wstring& newParentId, const ::std::wstring& objId, int32_t manSortIdx, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_refSord(oldParentId, newParentId, objId, manSortIdx));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
bool BStub_IXServicePortIF::restoreSord(const ::std::wstring& objId, const PRestoreOptions& restoreOptions)  {
	BSyncResultT< bool > syncResult;	
	restoreSord(objId, restoreOptions, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::restoreSord(const ::std::wstring& objId, const PRestoreOptions& restoreOptions, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_restoreSord(objId, restoreOptions));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_1 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::setSessionOptions(const PSessionOptions& opts)  {
	BSyncResultT< bool > syncResult;	
	setSessionOptions(opts, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::setSessionOptions(const PSessionOptions& opts, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_setSessionOptions(opts));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
int32_t BStub_IXServicePortIF::startAdHocWorkFlow(const ::std::wstring& name, const ::std::wstring& objId, const PArrayString& arrUserIds, const ::std::wstring& nodeName, bool forValidation, bool serialFlow, const ::std::wstring& cancelUserId, const ::std::wstring& cancelMessage, const ::std::wstring& finishedUserId, const ::std::wstring& finishedMessage, const ::std::wstring& finishedScript)  {
	BSyncResultT< int32_t > syncResult;	
	startAdHocWorkFlow(name, objId, arrUserIds, nodeName, forValidation, serialFlow, cancelUserId, cancelMessage, finishedUserId, finishedMessage, finishedScript, [&syncResult](int32_t v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::startAdHocWorkFlow(const ::std::wstring& name, const ::std::wstring& objId, const PArrayString& arrUserIds, const ::std::wstring& nodeName, bool forValidation, bool serialFlow, const ::std::wstring& cancelUserId, const ::std::wstring& cancelMessage, const ::std::wstring& finishedUserId, const ::std::wstring& finishedMessage, const ::std::wstring& finishedScript, ::std::function< void (int32_t, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_startAdHocWorkFlow(name, objId, arrUserIds, nodeName, forValidation, serialFlow, cancelUserId, cancelMessage, finishedUserId, finishedMessage, finishedScript));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< int32_t, BResult_5 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
::std::wstring BStub_IXServicePortIF::startExport(const PArrayString& topLevelIDs, int64_t options)  {
	BSyncResultT< ::std::wstring > syncResult;	
	startExport(topLevelIDs, options, [&syncResult](::std::wstring v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::startExport(const PArrayString& topLevelIDs, int64_t options, ::std::function< void (::std::wstring, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_startExport(topLevelIDs, options));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< ::std::wstring, BResult_10 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
::std::wstring BStub_IXServicePortIF::startExportExt(const PExportExtOptions& options)  {
	BSyncResultT< ::std::wstring > syncResult;	
	startExportExt(options, [&syncResult](::std::wstring v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::startExportExt(const PExportExtOptions& options, ::std::function< void (::std::wstring, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_startExportExt(options));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< ::std::wstring, BResult_10 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
::std::wstring BStub_IXServicePortIF::startImport(const ::std::wstring& filingPath, int32_t guidMethod, int64_t options)  {
	BSyncResultT< ::std::wstring > syncResult;	
	startImport(filingPath, guidMethod, options, [&syncResult](::std::wstring v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::startImport(const ::std::wstring& filingPath, int32_t guidMethod, int64_t options, ::std::function< void (::std::wstring, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_startImport(filingPath, guidMethod, options));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< ::std::wstring, BResult_10 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
int32_t BStub_IXServicePortIF::startWorkFlow(const ::std::wstring& templFlowId, const ::std::wstring& flowName, const ::std::wstring& objId)  {
	BSyncResultT< int32_t > syncResult;	
	startWorkFlow(templFlowId, flowName, objId, [&syncResult](int32_t v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::startWorkFlow(const ::std::wstring& templFlowId, const ::std::wstring& flowName, const ::std::wstring& objId, ::std::function< void (int32_t, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_startWorkFlow(templFlowId, flowName, objId));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< int32_t, BResult_5 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::takeWorkFlowNode(int32_t nFlowId, int32_t nNodeId, const ::std::wstring& sUserId, int32_t nFlags, const PLockZ& lockZ)  {
	BSyncResultT< bool > syncResult;	
	takeWorkFlowNode(nFlowId, nNodeId, sUserId, nFlags, lockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::takeWorkFlowNode(int32_t nFlowId, int32_t nNodeId, const ::std::wstring& sUserId, int32_t nFlags, const PLockZ& lockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_takeWorkFlowNode(nFlowId, nNodeId, sUserId, nFlags, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
int32_t BStub_IXServicePortIF::terminateWorkFlow(const ::std::wstring& flowId, const PLockZ& unlockZ)  {
	BSyncResultT< int32_t > syncResult;	
	terminateWorkFlow(flowId, unlockZ, [&syncResult](int32_t v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::terminateWorkFlow(const ::std::wstring& flowId, const PLockZ& unlockZ, ::std::function< void (int32_t, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_terminateWorkFlow(flowId, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< int32_t, BResult_5 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::delegateWorkFlowNode(const PWFDelegateNodeInfo& delegateNodeInfo, const PLockZ& lockZ)  {
	BSyncResultT< bool > syncResult;	
	delegateWorkFlowNode(delegateNodeInfo, lockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::delegateWorkFlowNode(const PWFDelegateNodeInfo& delegateNodeInfo, const PLockZ& lockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_delegateWorkFlowNode(delegateNodeInfo, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deferWorkFlowNode(const ::std::wstring& flowId, int32_t nodeId, const ::std::wstring& userDelayDateIso, const PLockZ& lockZ)  {
	BSyncResultT< bool > syncResult;	
	deferWorkFlowNode(flowId, nodeId, userDelayDateIso, lockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deferWorkFlowNode(const ::std::wstring& flowId, int32_t nodeId, const ::std::wstring& userDelayDateIso, const PLockZ& lockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deferWorkFlowNode(flowId, nodeId, userDelayDateIso, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayString BStub_IXServicePortIF::testAdapter(const ::std::wstring& fn, const PArrayString& params)  {
	BSyncResultT< PArrayString > syncResult;	
	testAdapter(fn, params, [&syncResult](PArrayString v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::testAdapter(const ::std::wstring& fn, const PArrayString& params, ::std::function< void (PArrayString, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_testAdapter(fn, params));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayString, BResult_1888107655 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::unlinkSords(const ::std::wstring& fromId, const PArrayString& toIds, const PLinkSordZ& linkZ)  {
	BSyncResultT< bool > syncResult;	
	unlinkSords(fromId, toIds, linkZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::unlinkSords(const ::std::wstring& fromId, const PArrayString& toIds, const PLinkSordZ& linkZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_unlinkSords(fromId, toIds, linkZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayCryptInfo BStub_IXServicePortIF::checkoutCryptInfos(const PArrayString& ids, const PLockZ& lockZ)  {
	BSyncResultT< PArrayCryptInfo > syncResult;	
	checkoutCryptInfos(ids, lockZ, [&syncResult](PArrayCryptInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutCryptInfos(const PArrayString& ids, const PLockZ& lockZ, ::std::function< void (PArrayCryptInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutCryptInfos(ids, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayCryptInfo, BResult_809229049 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::checkinCryptInfos(const PArrayCryptInfo& cryptInfos, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	checkinCryptInfos(cryptInfos, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::checkinCryptInfos(const PArrayCryptInfo& cryptInfos, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinCryptInfos(cryptInfos, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::provideCryptPassword(const ::std::wstring& encryptionSet, const ::std::wstring& pwd)  {
	BSyncResultT< bool > syncResult;	
	provideCryptPassword(encryptionSet, pwd, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::provideCryptPassword(const ::std::wstring& encryptionSet, const ::std::wstring& pwd, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_provideCryptPassword(encryptionSet, pwd));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::invalidateCache(int32_t flags)  {
	BSyncResultT< bool > syncResult;	
	invalidateCache(flags, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::invalidateCache(int32_t flags, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_invalidateCache(flags));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PInvalidateCacheResult BStub_IXServicePortIF::invalidateCache2(const PInvalidateCacheInfo& info)  {
	BSyncResultT< PInvalidateCacheResult > syncResult;	
	invalidateCache2(info, [&syncResult](PInvalidateCacheResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::invalidateCache2(const PInvalidateCacheInfo& info, ::std::function< void (PInvalidateCacheResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_invalidateCache2(info));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PInvalidateCacheResult, BResult_1712381166 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findFirstTranslateTerms(const PFindTranslateTermInfo& findInfo, int32_t max)  {
	BSyncResultT< PFindResult > syncResult;	
	findFirstTranslateTerms(findInfo, max, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findFirstTranslateTerms(const PFindTranslateTermInfo& findInfo, int32_t max, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findFirstTranslateTerms(findInfo, max));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

