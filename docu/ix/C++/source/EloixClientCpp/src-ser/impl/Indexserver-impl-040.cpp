#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 
PActivity BStub_IXServicePortIF::createActivity(const ::std::wstring& projectName, const ::std::wstring& objId)  {
	BSyncResultT< PActivity > syncResult;	
	createActivity(projectName, objId, [&syncResult](PActivity v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::createActivity(const ::std::wstring& projectName, const ::std::wstring& objId, ::std::function< void (PActivity, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_createActivity(projectName, objId));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PActivity, BResult_460199434 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
::std::wstring BStub_IXServicePortIF::checkinActivity(const PActivity& act, const PLockZ& unlockZ)  {
	BSyncResultT< ::std::wstring > syncResult;	
	checkinActivity(act, unlockZ, [&syncResult](::std::wstring v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinActivity(const PActivity& act, const PLockZ& unlockZ, ::std::function< void (::std::wstring, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinActivity(act, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< ::std::wstring, BResult_10 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteActivity(const ::std::wstring& actGuid, const PDeleteActivityOptions& deleteOptions, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteActivity(actGuid, deleteOptions, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteActivity(const ::std::wstring& actGuid, const PDeleteActivityOptions& deleteOptions, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteActivity(actGuid, deleteOptions, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PActivity BStub_IXServicePortIF::checkoutActivity(const ::std::wstring& actGuid, const PLockZ& lockZ)  {
	BSyncResultT< PActivity > syncResult;	
	checkoutActivity(actGuid, lockZ, [&syncResult](PActivity v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutActivity(const ::std::wstring& actGuid, const PLockZ& lockZ, ::std::function< void (PActivity, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutActivity(actGuid, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PActivity, BResult_460199434 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findFirstActivities(const PFindActivityInfo& findInfo, int32_t max, const PActivityZ& activityZ)  {
	BSyncResultT< PFindResult > syncResult;	
	findFirstActivities(findInfo, max, activityZ, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findFirstActivities(const PFindActivityInfo& findInfo, int32_t max, const PActivityZ& activityZ, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findFirstActivities(findInfo, max, activityZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findNextActivities(const ::std::wstring& searchId, int32_t idx, int32_t max, const PActivityZ& activityZ)  {
	BSyncResultT< PFindResult > syncResult;	
	findNextActivities(searchId, idx, max, activityZ, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findNextActivities(const ::std::wstring& searchId, int32_t idx, int32_t max, const PActivityZ& activityZ, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findNextActivities(searchId, idx, max, activityZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
POcrWorker BStub_IXServicePortIF::registerOcrWorker(const POcrWorker& ocrWorker)  {
	BSyncResultT< POcrWorker > syncResult;	
	registerOcrWorker(ocrWorker, [&syncResult](POcrWorker v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::registerOcrWorker(const POcrWorker& ocrWorker, ::std::function< void (POcrWorker, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_registerOcrWorker(ocrWorker));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< POcrWorker, BResult_730157667 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
POcrResult BStub_IXServicePortIF::processOcr(const POcrInfo& ocrInfo)  {
	BSyncResultT< POcrResult > syncResult;	
	processOcr(ocrInfo, [&syncResult](POcrResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::processOcr(const POcrInfo& ocrInfo, ::std::function< void (POcrResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_processOcr(ocrInfo));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< POcrResult, BResult_998509414 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PAutoFilingResult BStub_IXServicePortIF::evalAutoFiling(const ::std::wstring& maskId, const PSord& sord, const PAutoFilingOptions& opts)  {
	BSyncResultT< PAutoFilingResult > syncResult;	
	evalAutoFiling(maskId, sord, opts, [&syncResult](PAutoFilingResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::evalAutoFiling(const ::std::wstring& maskId, const PSord& sord, const PAutoFilingOptions& opts, ::std::function< void (PAutoFilingResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_evalAutoFiling(maskId, sord, opts));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PAutoFilingResult, BResult_1881161566 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayMapHist BStub_IXServicePortIF::checkoutMapHistory(const ::std::wstring& domainName, const ::std::wstring& mapId, const PMapHistZ& membersZ)  {
	BSyncResultT< PArrayMapHist > syncResult;	
	checkoutMapHistory(domainName, mapId, membersZ, [&syncResult](PArrayMapHist v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutMapHistory(const ::std::wstring& domainName, const ::std::wstring& mapId, const PMapHistZ& membersZ, ::std::function< void (PArrayMapHist, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutMapHistory(domainName, mapId, membersZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayMapHist, BResult_1756288553 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PDocument BStub_IXServicePortIF::checkinDocBegin2(const PSord& sord, const PDocument& document, const PCheckinDocOptions& opts)  {
	BSyncResultT< PDocument > syncResult;	
	checkinDocBegin2(sord, document, opts, [&syncResult](PDocument v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinDocBegin2(const PSord& sord, const PDocument& document, const PCheckinDocOptions& opts, ::std::function< void (PDocument, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinDocBegin2(sord, document, opts));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PDocument, BResult_341056676 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PJobState BStub_IXServicePortIF::controlBackgroundThread(const PJobState& jobState)  {
	BSyncResultT< PJobState > syncResult;	
	controlBackgroundThread(jobState, [&syncResult](PJobState v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::controlBackgroundThread(const PJobState& jobState, ::std::function< void (PJobState, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_controlBackgroundThread(jobState));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PJobState, BResult_1436376940 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findBackgroundThreads(const PFindBackgroundThreadOptions& findBackgroundThreadOptions)  {
	BSyncResultT< PFindResult > syncResult;	
	findBackgroundThreads(findBackgroundThreadOptions, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findBackgroundThreads(const PFindBackgroundThreadOptions& findBackgroundThreadOptions, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findBackgroundThreads(findBackgroundThreadOptions));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PQueryJobProtocolResult BStub_IXServicePortIF::queryJobProtocol(const PQueryJobProtocolInfo& queryJobProtocolInfo)  {
	BSyncResultT< PQueryJobProtocolResult > syncResult;	
	queryJobProtocol(queryJobProtocolInfo, [&syncResult](PQueryJobProtocolResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::queryJobProtocol(const PQueryJobProtocolInfo& queryJobProtocolInfo, ::std::function< void (PQueryJobProtocolResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_queryJobProtocol(queryJobProtocolInfo));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PQueryJobProtocolResult, BResult_222450704 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PKeywordsDynamicResult BStub_IXServicePortIF::checkoutKeywordsDynamic(const PKeywordsDynamicInfo& keywordsDynamicInfo)  {
	BSyncResultT< PKeywordsDynamicResult > syncResult;	
	checkoutKeywordsDynamic(keywordsDynamicInfo, [&syncResult](PKeywordsDynamicResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutKeywordsDynamic(const PKeywordsDynamicInfo& keywordsDynamicInfo, ::std::function< void (PKeywordsDynamicResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutKeywordsDynamic(keywordsDynamicInfo));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PKeywordsDynamicResult, BResult_1552114559 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PSordPaths BStub_IXServicePortIF::checkoutSordPath(const ::std::wstring& objId, const PSordZ& sordZ, const PCheckoutSordPathInfo& csi)  {
	BSyncResultT< PSordPaths > syncResult;	
	checkoutSordPath(objId, sordZ, csi, [&syncResult](PSordPaths v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutSordPath(const ::std::wstring& objId, const PSordZ& sordZ, const PCheckoutSordPathInfo& csi, ::std::function< void (PSordPaths, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutSordPath(objId, sordZ, csi));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PSordPaths, BResult_1835331414 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PPreviewImageResult BStub_IXServicePortIF::checkoutPreviewImageURLs(const PPreviewImageInfo& previewImageInfo)  {
	BSyncResultT< PPreviewImageResult > syncResult;	
	checkoutPreviewImageURLs(previewImageInfo, [&syncResult](PPreviewImageResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutPreviewImageURLs(const PPreviewImageInfo& previewImageInfo, ::std::function< void (PPreviewImageResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutPreviewImageURLs(previewImageInfo));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PPreviewImageResult, BResult_661820173 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PApplyForNotificationsInfo BStub_IXServicePortIF::applyForNotifications(const PApplyForNotificationsInfo& info)  {
	BSyncResultT< PApplyForNotificationsInfo > syncResult;	
	applyForNotifications(info, [&syncResult](PApplyForNotificationsInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::applyForNotifications(const PApplyForNotificationsInfo& info, ::std::function< void (PApplyForNotificationsInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_applyForNotifications(info));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PApplyForNotificationsInfo, BResult_77743605 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PVectorPublicDownload BStub_IXServicePortIF::getPublicDownloads(const PPublicDownloadOptions& opts)  {
	BSyncResultT< PVectorPublicDownload > syncResult;	
	getPublicDownloads(opts, [&syncResult](PVectorPublicDownload v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getPublicDownloads(const PPublicDownloadOptions& opts, ::std::function< void (PVectorPublicDownload, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getPublicDownloads(opts));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PVectorPublicDownload, BResult_881442092 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::terminatePublicDownloadUrls(const PPublicDownloadOptions& opts)  {
	BSyncResultT< bool > syncResult;	
	terminatePublicDownloadUrls(opts, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::terminatePublicDownloadUrls(const PPublicDownloadOptions& opts, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_terminatePublicDownloadUrls(opts));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::editPublicDownloadUrls(const PPublicDownloadOptions& opts)  {
	BSyncResultT< bool > syncResult;	
	editPublicDownloadUrls(opts, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::editPublicDownloadUrls(const PPublicDownloadOptions& opts, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_editPublicDownloadUrls(opts));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PVectorResolveRightsResult BStub_IXServicePortIF::resolveRights(const PUserInfo& ui, const PResolveRightsInfo& info)  {
	BSyncResultT< PVectorResolveRightsResult > syncResult;	
	resolveRights(ui, info, [&syncResult](PVectorResolveRightsResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::resolveRights(const PUserInfo& ui, const PResolveRightsInfo& info, ::std::function< void (PVectorResolveRightsResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_resolveRights(ui, info));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PVectorResolveRightsResult, BResult_907729609 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
int32_t BStub_IXServicePortIF::startAdHocWorkFlow2(const ::std::wstring& name, const ::std::wstring& objId, const PArrayUserNodeInfo& userNodeInfo, const PStartAdHocWorkflowInfo& startWfInfo)  {
	BSyncResultT< int32_t > syncResult;	
	startAdHocWorkFlow2(name, objId, userNodeInfo, startWfInfo, [&syncResult](int32_t v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::startAdHocWorkFlow2(const ::std::wstring& name, const ::std::wstring& objId, const PArrayUserNodeInfo& userNodeInfo, const PStartAdHocWorkflowInfo& startWfInfo, ::std::function< void (int32_t, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_startAdHocWorkFlow2(name, objId, userNodeInfo, startWfInfo));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< int32_t, BResult_5 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
int32_t BStub_IXServicePortIF::startAdHocWorkFlow3(const ::std::wstring& name, const ::std::wstring& objId, const PStartAdHocWorkflowInfo& startWfInfo)  {
	BSyncResultT< int32_t > syncResult;	
	startAdHocWorkFlow3(name, objId, startWfInfo, [&syncResult](int32_t v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::startAdHocWorkFlow3(const ::std::wstring& name, const ::std::wstring& objId, const PStartAdHocWorkflowInfo& startWfInfo, ::std::function< void (int32_t, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_startAdHocWorkFlow3(name, objId, startWfInfo));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< int32_t, BResult_5 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PPublicDownload BStub_IXServicePortIF::insertPublicDownload(const PPublicDownloadOptions& opts)  {
	BSyncResultT< PPublicDownload > syncResult;	
	insertPublicDownload(opts, [&syncResult](PPublicDownload v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::insertPublicDownload(const PPublicDownloadOptions& opts, ::std::function< void (PPublicDownload, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_insertPublicDownload(opts));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PPublicDownload, BResult_2062827124 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PSubscription BStub_IXServicePortIF::createSubscription(const ::std::wstring& watchGuid)  {
	BSyncResultT< PSubscription > syncResult;	
	createSubscription(watchGuid, [&syncResult](PSubscription v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::createSubscription(const ::std::wstring& watchGuid, ::std::function< void (PSubscription, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_createSubscription(watchGuid));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PSubscription, BResult_323351719 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PSubscription BStub_IXServicePortIF::checkinSubscription(const PSubscription& subs, const PSubscriptionZ& subsZ)  {
	BSyncResultT< PSubscription > syncResult;	
	checkinSubscription(subs, subsZ, [&syncResult](PSubscription v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinSubscription(const PSubscription& subs, const PSubscriptionZ& subsZ, ::std::function< void (PSubscription, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinSubscription(subs, subsZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PSubscription, BResult_323351719 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteSubscription(const PSubscription& subs)  {
	BSyncResultT< bool > syncResult;	
	deleteSubscription(subs, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteSubscription(const PSubscription& subs, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteSubscription(subs));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findFirstSubscriptions(const PFindSubscriptionInfo& findInfo, int32_t max, const PSubscriptionZ& subsZ)  {
	BSyncResultT< PFindResult > syncResult;	
	findFirstSubscriptions(findInfo, max, subsZ, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findFirstSubscriptions(const PFindSubscriptionInfo& findInfo, int32_t max, const PSubscriptionZ& subsZ, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findFirstSubscriptions(findInfo, max, subsZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findNextSubscriptions(const ::std::wstring& searchId, int32_t idx, int32_t max, const PSubscriptionZ& subsZ)  {
	BSyncResultT< PFindResult > syncResult;	
	findNextSubscriptions(searchId, idx, max, subsZ, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findNextSubscriptions(const ::std::wstring& searchId, int32_t idx, int32_t max, const PSubscriptionZ& subsZ, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findNextSubscriptions(searchId, idx, max, subsZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findFirstNotes(const PFindInfo& findInfo, int32_t max, const PNoteZ& noteZ)  {
	BSyncResultT< PFindResult > syncResult;	
	findFirstNotes(findInfo, max, noteZ, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findFirstNotes(const PFindInfo& findInfo, int32_t max, const PNoteZ& noteZ, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findFirstNotes(findInfo, max, noteZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findNextNotes(const ::std::wstring& searchId, int32_t idx, int32_t max, const PNoteZ& noteZ)  {
	BSyncResultT< PFindResult > syncResult;	
	findNextNotes(searchId, idx, max, noteZ, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findNextNotes(const ::std::wstring& searchId, int32_t idx, int32_t max, const PNoteZ& noteZ, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findNextNotes(searchId, idx, max, noteZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::checkinReport(const PReportInfo& report, const PCheckinReportInfo& reserved, const PLockZ& lockZ)  {
	BSyncResultT< bool > syncResult;	
	checkinReport(report, reserved, lockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::checkinReport(const PReportInfo& report, const PCheckinReportInfo& reserved, const PLockZ& lockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinReport(report, reserved, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::linkSords2(const ::std::wstring& fromId, const PArrayString& toIds, const PLinkSordZ& linkSordZ, const PLinkSordInfo& linkSordInfo)  {
	BSyncResultT< bool > syncResult;	
	linkSords2(fromId, toIds, linkSordZ, linkSordInfo, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::linkSords2(const ::std::wstring& fromId, const PArrayString& toIds, const PLinkSordZ& linkSordZ, const PLinkSordInfo& linkSordInfo, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_linkSords2(fromId, toIds, linkSordZ, linkSordInfo));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
::std::wstring BStub_IXServicePortIF::getWebDAVPathFromObjID(const ::std::wstring& objId)  {
	BSyncResultT< ::std::wstring > syncResult;	
	getWebDAVPathFromObjID(objId, [&syncResult](::std::wstring v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getWebDAVPathFromObjID(const ::std::wstring& objId, ::std::function< void (::std::wstring, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getWebDAVPathFromObjID(objId));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< ::std::wstring, BResult_10 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PGetWebDAVPathResult BStub_IXServicePortIF::getWebDAVPathFromObjID2(const PGetWebDAVPathOptions& options)  {
	BSyncResultT< PGetWebDAVPathResult > syncResult;	
	getWebDAVPathFromObjID2(options, [&syncResult](PGetWebDAVPathResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::getWebDAVPathFromObjID2(const PGetWebDAVPathOptions& options, ::std::function< void (PGetWebDAVPathResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_getWebDAVPathFromObjID2(options));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PGetWebDAVPathResult, BResult_148564345 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PCheckoutWorkflowHistoryResult BStub_IXServicePortIF::checkoutWorkflowHistory(const PCheckoutWorkflowHistoryParams& checkoutWorkflowHistoryParams)  {
	BSyncResultT< PCheckoutWorkflowHistoryResult > syncResult;	
	checkoutWorkflowHistory(checkoutWorkflowHistoryParams, [&syncResult](PCheckoutWorkflowHistoryResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutWorkflowHistory(const PCheckoutWorkflowHistoryParams& checkoutWorkflowHistoryParams, ::std::function< void (PCheckoutWorkflowHistoryResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutWorkflowHistory(checkoutWorkflowHistoryParams));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PCheckoutWorkflowHistoryResult, BResult_1754570852 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
int32_t BStub_IXServicePortIF::checkinDocMaskLineTemplate(const PDocMaskLineTemplate& dmlt, const PDocMaskLineTemplateZ& dmltZ, const PCheckInDocMaskLineTemplateOptions& options, const PLockZ& lockZ)  {
	BSyncResultT< int32_t > syncResult;	
	checkinDocMaskLineTemplate(dmlt, dmltZ, options, lockZ, [&syncResult](int32_t v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinDocMaskLineTemplate(const PDocMaskLineTemplate& dmlt, const PDocMaskLineTemplateZ& dmltZ, const PCheckInDocMaskLineTemplateOptions& options, const PLockZ& lockZ, ::std::function< void (int32_t, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinDocMaskLineTemplate(dmlt, dmltZ, options, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< int32_t, BResult_5 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayDocMaskLineTemplate BStub_IXServicePortIF::checkoutDocMaskLineTemplates(const PArrayString& groups, const PDocMaskLineTemplateZ& dmltZ, const PLockZ& lockZ)  {
	BSyncResultT< PArrayDocMaskLineTemplate > syncResult;	
	checkoutDocMaskLineTemplates(groups, dmltZ, lockZ, [&syncResult](PArrayDocMaskLineTemplate v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutDocMaskLineTemplates(const PArrayString& groups, const PDocMaskLineTemplateZ& dmltZ, const PLockZ& lockZ, ::std::function< void (PArrayDocMaskLineTemplate, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutDocMaskLineTemplates(groups, dmltZ, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayDocMaskLineTemplate, BResult_1107316733 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteDocMaskLineTemplates(const PArrayString& groups, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteDocMaskLineTemplates(groups, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteDocMaskLineTemplates(const PArrayString& groups, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteDocMaskLineTemplates(groups, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PWFEditNode BStub_IXServicePortIF::beginForwardWorkflowNode(int32_t flowId, int32_t nodeId, const PBeginForwardWorkflowNodeInfo& fwdInfo, const PLockZ& lockZ)  {
	BSyncResultT< PWFEditNode > syncResult;	
	beginForwardWorkflowNode(flowId, nodeId, fwdInfo, lockZ, [&syncResult](PWFEditNode v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::beginForwardWorkflowNode(int32_t flowId, int32_t nodeId, const PBeginForwardWorkflowNodeInfo& fwdInfo, const PLockZ& lockZ, ::std::function< void (PWFEditNode, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_beginForwardWorkflowNode(flowId, nodeId, fwdInfo, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PWFEditNode, BResult_1822579866 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PForwardWorkflowNodeResult BStub_IXServicePortIF::forwardWorkflowNode(int32_t flowId, int32_t nodeId, const PForwardWorkflowNodeInfo& fwdInfo, const PLockZ& unlockZ)  {
	BSyncResultT< PForwardWorkflowNodeResult > syncResult;	
	forwardWorkflowNode(flowId, nodeId, fwdInfo, unlockZ, [&syncResult](PForwardWorkflowNodeResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::forwardWorkflowNode(int32_t flowId, int32_t nodeId, const PForwardWorkflowNodeInfo& fwdInfo, const PLockZ& unlockZ, ::std::function< void (PForwardWorkflowNodeResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_forwardWorkflowNode(flowId, nodeId, fwdInfo, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PForwardWorkflowNodeResult, BResult_1699606509 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findFirstUsers(const PFindUserInfo& findUserInfo, int32_t max)  {
	BSyncResultT< PFindResult > syncResult;	
	findFirstUsers(findUserInfo, max, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findFirstUsers(const PFindUserInfo& findUserInfo, int32_t max, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findFirstUsers(findUserInfo, max));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findNextUsers(const ::std::wstring& searchId, int32_t idx, int32_t max)  {
	BSyncResultT< PFindResult > syncResult;	
	findNextUsers(searchId, idx, max, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findNextUsers(const ::std::wstring& searchId, int32_t idx, int32_t max, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findNextUsers(searchId, idx, max));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PLicenseResult BStub_IXServicePortIF::checkLicense(const PLicenseInfo& licenseInfo)  {
	BSyncResultT< PLicenseResult > syncResult;	
	checkLicense(licenseInfo, [&syncResult](PLicenseResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkLicense(const PLicenseInfo& licenseInfo, ::std::function< void (PLicenseResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkLicense(licenseInfo));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PLicenseResult, BResult_545905411 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PJobState BStub_IXServicePortIF::moveDocuments(const PMoveDocumentsInfo& moveDocumentsInfo)  {
	BSyncResultT< PJobState > syncResult;	
	moveDocuments(moveDocumentsInfo, [&syncResult](PJobState v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::moveDocuments(const PMoveDocumentsInfo& moveDocumentsInfo, ::std::function< void (PJobState, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_moveDocuments(moveDocumentsInfo));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PJobState, BResult_1436376940 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

// checkpoint byps.gen.cpp.GenRemoteStub:224
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1795705954(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* reserved){
	BSerializer_16_Template<de::elo::ix::client::BStub_IXServicePortIF, 1795705954>(bio, pObj, pObjS, reserved);
}
}}}}



namespace de { namespace elo { namespace ix { namespace client { namespace compatibility { 
BStub_RawStreamService::BStub_RawStreamService(PTransport transport) 
	: BStub(transport) {}
}}}}}

// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::compatibility::BStub_RawStreamService::BSerializable_getTypeId() {
	return 354585327; 
}
namespace de { namespace elo { namespace ix { namespace client { namespace compatibility { 
::std::wstring BStub_RawStreamService::upload(const PArrayString& params, const PContentStream& is)  {
	BSyncResultT< ::std::wstring > syncResult;	
	upload(params, is, [&syncResult](::std::wstring v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_RawStreamService::upload(const PArrayString& params, const PContentStream& is, ::std::function< void (::std::wstring, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_RawStreamService_upload(params, is));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< ::std::wstring, de::elo::ix::client::BResult_10 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace compatibility { 
PContentStream BStub_RawStreamService::download(const PArrayString& params)  {
	BSyncResultT< PContentStream > syncResult;	
	download(params, [&syncResult](PContentStream v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_RawStreamService::download(const PArrayString& params, ::std::function< void (PContentStream, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_RawStreamService_download(params));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PContentStream, de::elo::ix::client::BResult_15 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

// checkpoint byps.gen.cpp.GenRemoteStub:224
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_354585327(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* reserved){
	BSerializer_16_Template<de::elo::ix::client::compatibility::BStub_RawStreamService, 354585327>(bio, pObj, pObjS, reserved);
}
}}}}



namespace de { namespace elo { namespace ix { namespace client { namespace compatibility { 
BStub_WClientService::BStub_WClientService(PTransport transport) 
	: BStub(transport) {}
}}}}}

// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::compatibility::BStub_WClientService::BSerializable_getTypeId() {
	return 1887299447; 
}
namespace de { namespace elo { namespace ix { namespace client { namespace compatibility { 
void BStub_WClientService::onAfterVersionChanged(int32_t objId, int32_t docId, int32_t flags)  {
	BSyncResultT< bool > syncResult;	
	onAfterVersionChanged(objId, docId, flags, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_WClientService::onAfterVersionChanged(int32_t objId, int32_t docId, int32_t flags, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_WClientService_onAfterVersionChanged(objId, docId, flags));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, de::elo::ix::client::BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

// checkpoint byps.gen.cpp.GenRemoteStub:224
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1887299447(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* reserved){
	BSerializer_16_Template<de::elo::ix::client::compatibility::BStub_WClientService, 1887299447>(bio, pObj, pObjS, reserved);
}
}}}}


namespace de { namespace elo { namespace ix { namespace client { namespace feed { 

// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::BSkeleton_FeedNotification::BSerializable_getTypeId() {
	return 320199695; 
}
void BSkeleton_FeedNotification::updateAction(const PAction& action)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_FeedNotification::updateAction(const PAction& action, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		updateAction(action);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
}}}}}



namespace de { namespace elo { namespace ix { namespace client { namespace feed { 
BStub_FeedNotification::BStub_FeedNotification(PTransport transport) 
	: BStub(transport) {}
}}}}}

// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::BStub_FeedNotification::BSerializable_getTypeId() {
	return 320199695; 
}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 
void BStub_FeedNotification::updateAction(const PAction& action)  {
	BSyncResultT< bool > syncResult;	
	updateAction(action, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_FeedNotification::updateAction(const PAction& action, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_FeedNotification_updateAction(action));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, de::elo::ix::client::BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

// checkpoint byps.gen.cpp.GenRemoteStub:224
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_320199695(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* reserved){
	BSerializer_16_Template<de::elo::ix::client::feed::BStub_FeedNotification, 320199695>(bio, pObj, pObjS, reserved);
}
}}}}



namespace de { namespace elo { namespace ix { namespace client { namespace feed { 
BStub_FeedService::BStub_FeedService(PTransport transport) 
	: BStub(transport) {}
}}}}}

// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::feed::BStub_FeedService::BSerializable_getTypeId() {
	return 1670701039; 
}
namespace de { namespace elo { namespace ix { namespace client { namespace feed { 
de::elo::ix::client::PFindResult BStub_FeedService::findFirstActions(const PFindActionsInfo& findInfo, int32_t max, const PActionZ& actionZ)  {
	BSyncResultT< de::elo::ix::client::PFindResult > syncResult;	
	findFirstActions(findInfo, max, actionZ, [&syncResult](de::elo::ix::client::PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_FeedService::findFirstActions(const PFindActionsInfo& findInfo, int32_t max, const PActionZ& actionZ, ::std::function< void (de::elo::ix::client::PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_FeedService_findFirstActions(findInfo, max, actionZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< de::elo::ix::client::PFindResult, de::elo::ix::client::BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 
de::elo::ix::client::PFindResult BStub_FeedService::findNextActions(const ::std::wstring& searchId, int32_t idx, int32_t max, const PActionZ& actionZ)  {
	BSyncResultT< de::elo::ix::client::PFindResult > syncResult;	
	findNextActions(searchId, idx, max, actionZ, [&syncResult](de::elo::ix::client::PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_FeedService::findNextActions(const ::std::wstring& searchId, int32_t idx, int32_t max, const PActionZ& actionZ, ::std::function< void (de::elo::ix::client::PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_FeedService_findNextActions(searchId, idx, max, actionZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< de::elo::ix::client::PFindResult, de::elo::ix::client::BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 
PAction BStub_FeedService::createAction(EActionType type, const ::std::wstring& parentGuid)  {
	BSyncResultT< PAction > syncResult;	
	createAction(type, parentGuid, [&syncResult](PAction v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_FeedService::createAction(EActionType type, const ::std::wstring& parentGuid, ::std::function< void (PAction, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_FeedService_createAction(type, parentGuid));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PAction, de::elo::ix::client::BResult_736351635 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 
::std::wstring BStub_FeedService::checkinAction(const PAction& action, const PActionZ& actionZ)  {
	BSyncResultT< ::std::wstring > syncResult;	
	checkinAction(action, actionZ, [&syncResult](::std::wstring v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_FeedService::checkinAction(const PAction& action, const PActionZ& actionZ, ::std::function< void (::std::wstring, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_FeedService_checkinAction(action, actionZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< ::std::wstring, de::elo::ix::client::BResult_10 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 
PAction BStub_FeedService::checkoutAction(const ::std::wstring& actionGuid, const PActionZ& actionZ)  {
	BSyncResultT< PAction > syncResult;	
	checkoutAction(actionGuid, actionZ, [&syncResult](PAction v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_FeedService::checkoutAction(const ::std::wstring& actionGuid, const PActionZ& actionZ, ::std::function< void (PAction, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_FeedService_checkoutAction(actionGuid, actionZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PAction, de::elo::ix::client::BResult_736351635 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 
void BStub_FeedService::registerNotify(const ::std::wstring& feedGuid, const PFeedNotification& notify)  {
	BSyncResultT< bool > syncResult;	
	registerNotify(feedGuid, notify, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_FeedService::registerNotify(const ::std::wstring& feedGuid, const PFeedNotification& notify, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_FeedService_registerNotify(feedGuid, notify));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, de::elo::ix::client::BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

