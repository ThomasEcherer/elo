#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 
void BStub_FeedService::unregisterNotify(const ::std::wstring& feedGuid)  {
	BSyncResultT< bool > syncResult;	
	unregisterNotify(feedGuid, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_FeedService::unregisterNotify(const ::std::wstring& feedGuid, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_FeedService_unregisterNotify(feedGuid));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, de::elo::ix::client::BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 
PAction BStub_FeedService::internalInsertSystemAction(const PAction& action)  {
	BSyncResultT< PAction > syncResult;	
	internalInsertSystemAction(action, [&syncResult](PAction v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_FeedService::internalInsertSystemAction(const PAction& action, ::std::function< void (PAction, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_FeedService_internalInsertSystemAction(action));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PAction, de::elo::ix::client::BResult_736351635 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 
PHashTag BStub_FeedService::checkoutHashTag(const ::std::wstring& hashtagGuidOrName, const PHashTagZ& hstgZ)  {
	BSyncResultT< PHashTag > syncResult;	
	checkoutHashTag(hashtagGuidOrName, hstgZ, [&syncResult](PHashTag v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_FeedService::checkoutHashTag(const ::std::wstring& hashtagGuidOrName, const PHashTagZ& hstgZ, ::std::function< void (PHashTag, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_FeedService_checkoutHashTag(hashtagGuidOrName, hstgZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PHashTag, de::elo::ix::client::BResult_1143177929 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 
de::elo::ix::client::PFindResult BStub_FeedService::findFirstHashTagRelation(const PFindHashTagInfo& findInfo, int32_t max, const PHashTagZ& hashTagZ)  {
	BSyncResultT< de::elo::ix::client::PFindResult > syncResult;	
	findFirstHashTagRelation(findInfo, max, hashTagZ, [&syncResult](de::elo::ix::client::PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_FeedService::findFirstHashTagRelation(const PFindHashTagInfo& findInfo, int32_t max, const PHashTagZ& hashTagZ, ::std::function< void (de::elo::ix::client::PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_FeedService_findFirstHashTagRelation(findInfo, max, hashTagZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< de::elo::ix::client::PFindResult, de::elo::ix::client::BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 
de::elo::ix::client::PFindResult BStub_FeedService::findNextHashTagRelation(const ::std::wstring& searchId, int32_t idx, int32_t max, const PHashTagZ& hashTagZ)  {
	BSyncResultT< de::elo::ix::client::PFindResult > syncResult;	
	findNextHashTagRelation(searchId, idx, max, hashTagZ, [&syncResult](de::elo::ix::client::PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_FeedService::findNextHashTagRelation(const ::std::wstring& searchId, int32_t idx, int32_t max, const PHashTagZ& hashTagZ, ::std::function< void (de::elo::ix::client::PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_FeedService_findNextHashTagRelation(searchId, idx, max, hashTagZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< de::elo::ix::client::PFindResult, de::elo::ix::client::BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 
byps_ptr< ::std::set< PHashTag > > BStub_FeedService::findHashTagByActions(const PArrayString& actionGuids, const PHashTagZ& hashTagZ)  {
	BSyncResultT< byps_ptr< ::std::set< PHashTag > > > syncResult;	
	findHashTagByActions(actionGuids, hashTagZ, [&syncResult](byps_ptr< ::std::set< PHashTag > > v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_FeedService::findHashTagByActions(const PArrayString& actionGuids, const PHashTagZ& hashTagZ, ::std::function< void (byps_ptr< ::std::set< PHashTag > >, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_FeedService_findHashTagByActions(actionGuids, hashTagZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< byps_ptr< ::std::set< PHashTag > >, de::elo::ix::client::BResult_1535847981 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 
PMapStringHashTag BStub_FeedService::findHashTags(const PFindHashTagInfo& findInfo)  {
	BSyncResultT< PMapStringHashTag > syncResult;	
	findHashTags(findInfo, [&syncResult](PMapStringHashTag v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_FeedService::findHashTags(const PFindHashTagInfo& findInfo, ::std::function< void (PMapStringHashTag, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_FeedService_findHashTags(findInfo));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PMapStringHashTag, de::elo::ix::client::BResult_1556767716 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 
de::elo::ix::client::PFindResult BStub_FeedService::findFirstNotification(const PFindNotificationInfo& findInfo, int32_t max)  {
	BSyncResultT< de::elo::ix::client::PFindResult > syncResult;	
	findFirstNotification(findInfo, max, [&syncResult](de::elo::ix::client::PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_FeedService::findFirstNotification(const PFindNotificationInfo& findInfo, int32_t max, ::std::function< void (de::elo::ix::client::PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_FeedService_findFirstNotification(findInfo, max));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< de::elo::ix::client::PFindResult, de::elo::ix::client::BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 
de::elo::ix::client::PFindResult BStub_FeedService::findNextNotification(const ::std::wstring& searchId, int32_t idx, int32_t max)  {
	BSyncResultT< de::elo::ix::client::PFindResult > syncResult;	
	findNextNotification(searchId, idx, max, [&syncResult](de::elo::ix::client::PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_FeedService::findNextNotification(const ::std::wstring& searchId, int32_t idx, int32_t max, ::std::function< void (de::elo::ix::client::PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_FeedService_findNextNotification(searchId, idx, max));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< de::elo::ix::client::PFindResult, de::elo::ix::client::BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace feed { 
de::elo::ix::client::PSubscription BStub_FeedService::createHashTagSubscription(const ::std::wstring& hashtagGuidOrName, const ::std::wstring& userGuidOrId)  {
	BSyncResultT< de::elo::ix::client::PSubscription > syncResult;	
	createHashTagSubscription(hashtagGuidOrName, userGuidOrId, [&syncResult](de::elo::ix::client::PSubscription v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_FeedService::createHashTagSubscription(const ::std::wstring& hashtagGuidOrName, const ::std::wstring& userGuidOrId, ::std::function< void (de::elo::ix::client::PSubscription, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_FeedService_createHashTagSubscription(hashtagGuidOrName, userGuidOrId));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< de::elo::ix::client::PSubscription, de::elo::ix::client::BResult_323351719 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

// checkpoint byps.gen.cpp.GenRemoteStub:224
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1670701039(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* reserved){
	BSerializer_16_Template<de::elo::ix::client::feed::BStub_FeedService, 1670701039>(bio, pObj, pObjS, reserved);
}
}}}}



namespace de { namespace elo { namespace ix { namespace client { namespace health { 
BStub_HealthCheckService::BStub_HealthCheckService(PTransport transport) 
	: BStub(transport) {}
}}}}}

// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::health::BStub_HealthCheckService::BSerializable_getTypeId() {
	return 969424915; 
}
namespace de { namespace elo { namespace ix { namespace client { namespace health { 
void BStub_HealthCheckService::updateMeanValue(const ::std::wstring& name, double meanValue, int64_t sampleSize)  {
	BSyncResultT< bool > syncResult;	
	updateMeanValue(name, meanValue, sampleSize, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_HealthCheckService::updateMeanValue(const ::std::wstring& name, double meanValue, int64_t sampleSize, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_HealthCheckService_updateMeanValue(name, meanValue, sampleSize));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, de::elo::ix::client::BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace health { 
void BStub_HealthCheckService::updateDoubleValue(const ::std::wstring& name, double doubleValue)  {
	BSyncResultT< bool > syncResult;	
	updateDoubleValue(name, doubleValue, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_HealthCheckService::updateDoubleValue(const ::std::wstring& name, double doubleValue, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_HealthCheckService_updateDoubleValue(name, doubleValue));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, de::elo::ix::client::BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace health { 
void BStub_HealthCheckService::computeDoubleValue(const ::std::wstring& name, double doubleValue, HealthCheckValueOperation operation)  {
	BSyncResultT< bool > syncResult;	
	computeDoubleValue(name, doubleValue, operation, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_HealthCheckService::computeDoubleValue(const ::std::wstring& name, double doubleValue, HealthCheckValueOperation operation, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_HealthCheckService_computeDoubleValue(name, doubleValue, operation));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, de::elo::ix::client::BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace health { 
void BStub_HealthCheckService::update(const PHealthCheckInfo& hci)  {
	BSyncResultT< bool > syncResult;	
	update(hci, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_HealthCheckService::update(const PHealthCheckInfo& hci, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_HealthCheckService_update(hci));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, de::elo::ix::client::BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace health { 
void BStub_HealthCheckService::updateAll(const PVectorHealthCheckInfo& hcis)  {
	BSyncResultT< bool > syncResult;	
	updateAll(hcis, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_HealthCheckService::updateAll(const PVectorHealthCheckInfo& hcis, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_HealthCheckService_updateAll(hcis));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, de::elo::ix::client::BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace health { 
PSerializable BStub_HealthCheckService::uploadAll(const PSerializable& reserved)  {
	BSyncResultT< PSerializable > syncResult;	
	uploadAll(reserved, [&syncResult](PSerializable v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_HealthCheckService::uploadAll(const PSerializable& reserved, ::std::function< void (PSerializable, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_HealthCheckService_uploadAll(reserved));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PSerializable, de::elo::ix::client::BResult_21 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace health { 
PHealthCheckInfos BStub_HealthCheckService::read(const byps::PVectorString& names)  {
	BSyncResultT< PHealthCheckInfos > syncResult;	
	read(names, [&syncResult](PHealthCheckInfos v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_HealthCheckService::read(const byps::PVectorString& names, ::std::function< void (PHealthCheckInfos, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_HealthCheckService_read(names));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PHealthCheckInfos, de::elo::ix::client::BResult_333475674 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

// checkpoint byps.gen.cpp.GenRemoteStub:224
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_969424915(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* reserved){
	BSerializer_16_Template<de::elo::ix::client::health::BStub_HealthCheckService, 969424915>(bio, pObj, pObjS, reserved);
}
}}}}



namespace de { namespace elo { namespace ix { namespace client { namespace myelo { 
BStub_MyELOService::BStub_MyELOService(PTransport transport) 
	: BStub(transport) {}
}}}}}

// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::myelo::BStub_MyELOService::BSerializable_getTypeId() {
	return 1063633807; 
}
namespace de { namespace elo { namespace ix { namespace client { namespace myelo { 
PMyELOState BStub_MyELOService::checkState(const ::std::wstring& userGuidOrID, const ::std::wstring& sinceDateIso)  {
	BSyncResultT< PMyELOState > syncResult;	
	checkState(userGuidOrID, sinceDateIso, [&syncResult](PMyELOState v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_MyELOService::checkState(const ::std::wstring& userGuidOrID, const ::std::wstring& sinceDateIso, ::std::function< void (PMyELOState, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_MyELOService_checkState(userGuidOrID, sinceDateIso));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PMyELOState, de::elo::ix::client::BResult_1426941339 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace myelo { 
PMyELOContent BStub_MyELOService::readContent(const PMyELOState& state, const PMyELOInfo& info)  {
	BSyncResultT< PMyELOContent > syncResult;	
	readContent(state, info, [&syncResult](PMyELOContent v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_MyELOService::readContent(const PMyELOState& state, const PMyELOInfo& info, ::std::function< void (PMyELOContent, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_MyELOService_readContent(state, info));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PMyELOContent, de::elo::ix::client::BResult_1585309177 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

// checkpoint byps.gen.cpp.GenRemoteStub:224
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_1063633807(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* reserved){
	BSerializer_16_Template<de::elo::ix::client::myelo::BStub_MyELOService, 1063633807>(bio, pObj, pObjS, reserved);
}
}}}}


namespace de { namespace elo { namespace ix { namespace client { namespace notify { 

// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::notify::BSkeleton_ClientNotification::BSerializable_getTypeId() {
	return 2104055021; 
}
void BSkeleton_ClientNotification::adminMode(const de::elo::ix::client::PClientInfo& ci, int32_t mode)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_ClientNotification::adminMode(const de::elo::ix::client::PClientInfo& ci, int32_t mode, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		adminMode(ci, mode);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
void BSkeleton_ClientNotification::updateTask(const de::elo::ix::client::PClientInfo& ci, const de::elo::ix::client::PUserTask& userTask, TaskNotifyType notifyType)  {
	throw BException(BExceptionC::UNSUPPORTED_METHOD, L"");
}
void BSkeleton_ClientNotification::updateTask(const de::elo::ix::client::PClientInfo& ci, const de::elo::ix::client::PUserTask& userTask, TaskNotifyType notifyType, ::std::function< void (bool, BException ex) > asyncResult)  {
	bool __byps__ret = false;
	try {
		updateTask(ci, userTask, notifyType);
		asyncResult(__byps__ret, BException());
	} catch (const std::exception& __byps__ex) {
		asyncResult(__byps__ret, __byps__ex);
	}
}
}}}}}



namespace de { namespace elo { namespace ix { namespace client { namespace notify { 
BStub_ClientNotification::BStub_ClientNotification(PTransport transport) 
	: BStub(transport) {}
}}}}}

// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::notify::BStub_ClientNotification::BSerializable_getTypeId() {
	return 2104055021; 
}
namespace de { namespace elo { namespace ix { namespace client { namespace notify { 
void BStub_ClientNotification::adminMode(const de::elo::ix::client::PClientInfo& ci, int32_t mode)  {
	BSyncResultT< bool > syncResult;	
	adminMode(ci, mode, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_ClientNotification::adminMode(const de::elo::ix::client::PClientInfo& ci, int32_t mode, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_ClientNotification_adminMode(ci, mode));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, de::elo::ix::client::BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace notify { 
void BStub_ClientNotification::updateTask(const de::elo::ix::client::PClientInfo& ci, const de::elo::ix::client::PUserTask& userTask, TaskNotifyType notifyType)  {
	BSyncResultT< bool > syncResult;	
	updateTask(ci, userTask, notifyType, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_ClientNotification::updateTask(const de::elo::ix::client::PClientInfo& ci, const de::elo::ix::client::PUserTask& userTask, TaskNotifyType notifyType, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_ClientNotification_updateTask(ci, userTask, notifyType));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, de::elo::ix::client::BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

// checkpoint byps.gen.cpp.GenRemoteStub:224
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_2104055021(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* reserved){
	BSerializer_16_Template<de::elo::ix::client::notify::BStub_ClientNotification, 2104055021>(bio, pObj, pObjS, reserved);
}
}}}}



namespace de { namespace elo { namespace ix { namespace client { namespace system { 
BStub_SystemInformation::BStub_SystemInformation(PTransport transport) 
	: BStub(transport) {}
}}}}}

// checkpoint byps.gen.cpp.PrintContext:496
BTYPEID de::elo::ix::client::system::BStub_SystemInformation::BSerializable_getTypeId() {
	return 708455930; 
}
namespace de { namespace elo { namespace ix { namespace client { namespace system { 
PArchivReport BStub_SystemInformation::archivReport(const PSystemInfo& si)  {
	BSyncResultT< PArchivReport > syncResult;	
	archivReport(si, [&syncResult](PArchivReport v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_SystemInformation::archivReport(const PSystemInfo& si, ::std::function< void (PArchivReport, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_SystemInformation_archivReport(si));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArchivReport, de::elo::ix::client::BResult_1383534582 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace system { 
PSystemReport BStub_SystemInformation::countDocsInStorePath(const PSystemInfo& si)  {
	BSyncResultT< PSystemReport > syncResult;	
	countDocsInStorePath(si, [&syncResult](PSystemReport v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_SystemInformation::countDocsInStorePath(const PSystemInfo& si, ::std::function< void (PSystemReport, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_SystemInformation_countDocsInStorePath(si));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PSystemReport, de::elo::ix::client::BResult_276702696 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace system { 
PLicenseReport BStub_SystemInformation::licenseReport(const PSystemInfo& si)  {
	BSyncResultT< PLicenseReport > syncResult;	
	licenseReport(si, [&syncResult](PLicenseReport v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_SystemInformation::licenseReport(const PSystemInfo& si, ::std::function< void (PLicenseReport, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_SystemInformation_licenseReport(si));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PLicenseReport, de::elo::ix::client::BResult_1320348587 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

namespace de { namespace elo { namespace ix { namespace client { namespace system { 
PUserReport BStub_SystemInformation::userReport(const PSystemInfo& si)  {
	BSyncResultT< PUserReport > syncResult;	
	userReport(si, [&syncResult](PUserReport v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_SystemInformation::userReport(const PSystemInfo& si, ::std::function< void (PUserReport, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_SystemInformation_userReport(si));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PUserReport, de::elo::ix::client::BResult_18214274 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}}

// checkpoint byps.gen.cpp.GenRemoteStub:224
namespace de { namespace elo { namespace ix { namespace client { 
void BSerializer_708455930(BIO& bio, POBJECT& pObj, PSerializable& pObjS, void* reserved){
	BSerializer_16_Template<de::elo::ix::client::system::BStub_SystemInformation, 708455930>(bio, pObj, pObjS, reserved);
}
}}}}

//-------------------------------------------------
// Registry 

de::elo::ix::client::BRegistry_Indexserver::BRegistry_Indexserver()
{
	registerClass(typeid(BBytes), de::elo::ix::client::BSerializer_1374008726, 1374008726);
	registerClass(typeid(de::elo::ix::client::AccessC), de::elo::ix::client::BSerializer_384025970, 384025970);
	registerClass(typeid(de::elo::ix::client::AclAccessInfo), de::elo::ix::client::BSerializer_11569337, 11569337);
	registerClass(typeid(de::elo::ix::client::AclAccessResult), de::elo::ix::client::BSerializer_200528028, 200528028);
	registerClass(typeid(de::elo::ix::client::AclItem), de::elo::ix::client::BSerializer_1255072841, 1255072841);
	registerClass(typeid(de::elo::ix::client::AclItemC), de::elo::ix::client::BSerializer_1507233874, 1507233874);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PAclItem > ), de::elo::ix::client::BSerializer_1944875656, 1944875656);
	registerClass(typeid(de::elo::ix::client::Activity), de::elo::ix::client::BSerializer_460199434, 460199434);
	registerClass(typeid(de::elo::ix::client::ActivityC), de::elo::ix::client::BSerializer_1091363488, 1091363488);
	registerClass(typeid(de::elo::ix::client::ActivityDataC), de::elo::ix::client::BSerializer_72578008, 72578008);
	registerClass(typeid(de::elo::ix::client::ActivityOption), de::elo::ix::client::BSerializer_595132669, 595132669);
	registerClass(typeid(de::elo::ix::client::ActivityOptionC), de::elo::ix::client::BSerializer_1364827052, 1364827052);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PActivityOption > ), de::elo::ix::client::BSerializer_1831677187, 1831677187);
	registerClass(typeid(de::elo::ix::client::ActivityProject), de::elo::ix::client::BSerializer_2121298555, 2121298555);
	registerClass(typeid(de::elo::ix::client::ActivityProjectC), de::elo::ix::client::BSerializer_1697907147, 1697907147);
	registerClass(typeid(de::elo::ix::client::ActivityProjectDataC), de::elo::ix::client::BSerializer_1946995741, 1946995741);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PActivityProject > ), de::elo::ix::client::BSerializer_607287445, 607287445);
	registerClass(typeid(de::elo::ix::client::ActivityZ), de::elo::ix::client::BSerializer_730005706, 730005706);
	registerClass(typeid(de::elo::ix::client::AdminModeC), de::elo::ix::client::BSerializer_1820929375, 1820929375);
	registerClass(typeid(de::elo::ix::client::Alert), de::elo::ix::client::BSerializer_280775671, 280775671);
	registerClass(typeid(de::elo::ix::client::AlertC), de::elo::ix::client::BSerializer_1426544289, 1426544289);
	registerClass(typeid(de::elo::ix::client::AlertDataC), de::elo::ix::client::BSerializer_1498169909, 1498169909);
	registerClass(typeid(de::elo::ix::client::Any), de::elo::ix::client::BSerializer_1191976387, 1191976387);
	registerClass(typeid(de::elo::ix::client::AnyC), de::elo::ix::client::BSerializer_908393697, 908393697);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PAny > ), de::elo::ix::client::BSerializer_1233910153, 1233910153);
	registerClass(typeid(de::elo::ix::client::ApplyForNotificationsInfo), de::elo::ix::client::BSerializer_77743605, 77743605);
	registerClass(typeid(de::elo::ix::client::ArcPath), de::elo::ix::client::BSerializer_945258954, 945258954);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PArcPath > ), de::elo::ix::client::BSerializer_1192039710, 1192039710);
	registerClass(typeid(de::elo::ix::client::ArchiveStatistics), de::elo::ix::client::BSerializer_2056457945, 2056457945);
	registerClass(typeid(de::elo::ix::client::ArchiveStatisticsOptionsC), de::elo::ix::client::BSerializer_276716257, 276716257);
	registerClass(typeid(de::elo::ix::client::ArchivingModeC), de::elo::ix::client::BSerializer_1464718703, 1464718703);
	registerClass(typeid(de::elo::ix::client::AutoFilingOptions), de::elo::ix::client::BSerializer_225606439, 225606439);
	registerClass(typeid(de::elo::ix::client::AutoFilingResult), de::elo::ix::client::BSerializer_1881161566, 1881161566);
	registerClass(typeid(de::elo::ix::client::BRequest_IXEventBusHandler_processEventBusEvents), de::elo::ix::client::BSerializer_1736645961, 1736645961);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_executeRegisteredFunction), de::elo::ix::client::BSerializer_1363890826, 1363890826);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_executeRegisteredFunctionString), de::elo::ix::client::BSerializer_1679329575, 1679329575);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_getAppInfo), de::elo::ix::client::BSerializer_1887140750, 1887140750);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_getUserNames), de::elo::ix::client::BSerializer_1950460032, 1950460032);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_hasMethod), de::elo::ix::client::BSerializer_110863678, 110863678);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinActivity), de::elo::ix::client::BSerializer_1027171864, 1027171864);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinDocEnd), de::elo::ix::client::BSerializer_1920958924, 1920958924);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinMap), de::elo::ix::client::BSerializer_1002917709, 1002917709);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinNotes), de::elo::ix::client::BSerializer_1729896360, 1729896360);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinReminder), de::elo::ix::client::BSerializer_2130431109, 2130431109);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinSord), de::elo::ix::client::BSerializer_1025485545, 1025485545);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onAfterCheckinUsers), de::elo::ix::client::BSerializer_1723326561, 1723326561);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onAfterDeleteMap), de::elo::ix::client::BSerializer_40991853, 40991853);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onAfterDeleteSord), de::elo::ix::client::BSerializer_1270939805, 1270939805);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onAfterEndEditWorkFlowNode), de::elo::ix::client::BSerializer_812031586, 812031586);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onAfterLogin), de::elo::ix::client::BSerializer_1693784539, 1693784539);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onAfterRefSord), de::elo::ix::client::BSerializer_807852157, 807852157);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onAfterStartWorkFlow), de::elo::ix::client::BSerializer_527527197, 527527197);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinActivity), de::elo::ix::client::BSerializer_1917517477, 1917517477);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinDocEnd), de::elo::ix::client::BSerializer_129508967, 129508967);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinMap), de::elo::ix::client::BSerializer_1578945530, 1578945530);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinNotes), de::elo::ix::client::BSerializer_1241851157, 1241851157);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinSord), de::elo::ix::client::BSerializer_1702478812, 1702478812);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onBeforeCheckinUsers), de::elo::ix::client::BSerializer_1235281358, 1235281358);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onBeforeDeleteMap), de::elo::ix::client::BSerializer_393231686, 393231686);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onBeforeDeleteSord), de::elo::ix::client::BSerializer_694911984, 694911984);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onBeforeFindSords), de::elo::ix::client::BSerializer_384369013, 384369013);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onBeforeFindSordsInternalSQL), de::elo::ix::client::BSerializer_894418660, 894418660);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onBeforeLogin), de::elo::ix::client::BSerializer_2101716238, 2101716238);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onBeforeRefSord), de::elo::ix::client::BSerializer_372486646, 372486646);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onBeforeStartWorkFlow), de::elo::ix::client::BSerializer_1522940694, 1522940694);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onBeforeTakeWorkFlowNode), de::elo::ix::client::BSerializer_727945599, 727945599);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onCheckSordAccess), de::elo::ix::client::BSerializer_1507824766, 1507824766);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onCreateDoc), de::elo::ix::client::BSerializer_1029500828, 1029500828);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onCreateSord), de::elo::ix::client::BSerializer_1849307166, 1849307166);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onFileUploadBuildResponse), de::elo::ix::client::BSerializer_2105244922, 2105244922);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onFindClose), de::elo::ix::client::BSerializer_1223837305, 1223837305);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onFindSordsResult), de::elo::ix::client::BSerializer_127227249, 127227249);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onInheritKeywording), de::elo::ix::client::BSerializer_53854844, 53854844);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServerEvents_onReadSord), de::elo::ix::client::BSerializer_227337860, 227337860);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_addUrlParams), de::elo::ix::client::BSerializer_177992598, 177992598);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_adminMode), de::elo::ix::client::BSerializer_1311037156, 1311037156);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_alive), de::elo::ix::client::BSerializer_1536711337, 1536711337);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_applyForNotifications), de::elo::ix::client::BSerializer_1849289399, 1849289399);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_beginEditWorkFlowNode), de::elo::ix::client::BSerializer_626823938, 626823938);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_beginForwardWorkflowNode), de::elo::ix::client::BSerializer_48774765, 48774765);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_changeSordMask), de::elo::ix::client::BSerializer_1393938400, 1393938400);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkLicense), de::elo::ix::client::BSerializer_523346511, 523346511);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinActivity), de::elo::ix::client::BSerializer_1990464102, 1990464102);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinActivityProject), de::elo::ix::client::BSerializer_310669779, 310669779);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinColors), de::elo::ix::client::BSerializer_1576322695, 1576322695);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinConfigFiles), de::elo::ix::client::BSerializer_1785918050, 1785918050);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinConfigFilesBegin), de::elo::ix::client::BSerializer_453135787, 453135787);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinConfigFilesEnd), de::elo::ix::client::BSerializer_1770305117, 1770305117);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinCounters), de::elo::ix::client::BSerializer_1020556978, 1020556978);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinCryptInfos), de::elo::ix::client::BSerializer_1795186254, 1795186254);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinDocBegin), de::elo::ix::client::BSerializer_165848488, 165848488);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinDocBegin2), de::elo::ix::client::BSerializer_846335882, 846335882);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinDocDupl), de::elo::ix::client::BSerializer_1795690130, 1795690130);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinDocEnd), de::elo::ix::client::BSerializer_1604643226, 1604643226);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinDocMask), de::elo::ix::client::BSerializer_1795441139, 1795441139);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinDocMaskLineTemplate), de::elo::ix::client::BSerializer_702278853, 702278853);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinDocsBegin), de::elo::ix::client::BSerializer_2078187849, 2078187849);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinDocsEnd), de::elo::ix::client::BSerializer_1794336151, 1794336151);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinKeys), de::elo::ix::client::BSerializer_573935819, 573935819);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinKeywordList), de::elo::ix::client::BSerializer_1216164720, 1216164720);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinKeywords), de::elo::ix::client::BSerializer_125387007, 125387007);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinMap), de::elo::ix::client::BSerializer_1126894501, 1126894501);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinMapDomain), de::elo::ix::client::BSerializer_1848884425, 1848884425);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinNoteTemplates), de::elo::ix::client::BSerializer_1356325488, 1356325488);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinNotes), de::elo::ix::client::BSerializer_615204554, 615204554);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinNotification), de::elo::ix::client::BSerializer_1249191106, 1249191106);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinOrgUnits), de::elo::ix::client::BSerializer_656770626, 656770626);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinReminder), de::elo::ix::client::BSerializer_1167138871, 1167138871);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinReplNames), de::elo::ix::client::BSerializer_897197218, 897197218);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinReport), de::elo::ix::client::BSerializer_1996643915, 1996643915);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinReportOptions), de::elo::ix::client::BSerializer_955196883, 955196883);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinSord), de::elo::ix::client::BSerializer_574183525, 574183525);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinSordPath), de::elo::ix::client::BSerializer_998405674, 998405674);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinSordTypes), de::elo::ix::client::BSerializer_890210068, 890210068);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinStorage), de::elo::ix::client::BSerializer_1212457916, 1212457916);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinSubs), de::elo::ix::client::BSerializer_574188810, 574188810);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinSubscription), de::elo::ix::client::BSerializer_995161332, 995161332);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinTranslateTerms), de::elo::ix::client::BSerializer_366611184, 366611184);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinUserProfile), de::elo::ix::client::BSerializer_1903655079, 1903655079);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinUsers), de::elo::ix::client::BSerializer_621774353, 621774353);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinWorkFlow), de::elo::ix::client::BSerializer_614110410, 614110410);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkinWorkflowTemplate), de::elo::ix::client::BSerializer_847491504, 847491504);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutActivity), de::elo::ix::client::BSerializer_708798549, 708798549);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutActivityProject), de::elo::ix::client::BSerializer_1209441042, 1209441042);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutColors), de::elo::ix::client::BSerializer_2037655284, 2037655284);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutConfigFiles), de::elo::ix::client::BSerializer_846870983, 846870983);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutCounters), de::elo::ix::client::BSerializer_575147667, 575147667);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutCryptInfos), de::elo::ix::client::BSerializer_1964025427, 1964025427);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutDoc), de::elo::ix::client::BSerializer_753364764, 753364764);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutDocMask), de::elo::ix::client::BSerializer_2135358504, 2135358504);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutDocMaskLineTemplates), de::elo::ix::client::BSerializer_550757795, 550757795);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeys), de::elo::ix::client::BSerializer_1879670928, 1879670928);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeywordList), de::elo::ix::client::BSerializer_2139755509, 2139755509);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeywords), de::elo::ix::client::BSerializer_1470317638, 1470317638);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutKeywordsDynamic), de::elo::ix::client::BSerializer_1951955225, 1951955225);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutMap), de::elo::ix::client::BSerializer_753372992, 753372992);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutMapDomain), de::elo::ix::client::BSerializer_223879132, 223879132);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutMapHistory), de::elo::ix::client::BSerializer_739067188, 739067188);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutNoteTemplates), de::elo::ix::client::BSerializer_1837424715, 1837424715);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutNotes), de::elo::ix::client::BSerializer_1856680027, 1856680027);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutNotification), de::elo::ix::client::BSerializer_294879111, 294879111);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutOrgUnits), de::elo::ix::client::BSerializer_2042492025, 2042492025);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutPreviewImageURLs), de::elo::ix::client::BSerializer_755346067, 755346067);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutReminders), de::elo::ix::client::BSerializer_400637221, 400637221);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutReplNames), de::elo::ix::client::BSerializer_1175566339, 1175566339);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutReportOptions), de::elo::ix::client::BSerializer_1436296110, 1436296110);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutSord), de::elo::ix::client::BSerializer_1879918634, 1879918634);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutSordHistory), de::elo::ix::client::BSerializer_782528246, 782528246);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutSordPath), de::elo::ix::client::BSerializer_1700856977, 1700856977);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutSordTypes), de::elo::ix::client::BSerializer_1182553489, 1182553489);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutStorage), de::elo::ix::client::BSerializer_1576625569, 1576625569);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutSubs), de::elo::ix::client::BSerializer_1879923919, 1879923919);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutTranslateTerms), de::elo::ix::client::BSerializer_1899181963, 1899181963);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutUserProfile), de::elo::ix::client::BSerializer_1452265150, 1452265150);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutUsers), de::elo::ix::client::BSerializer_1850110228, 1850110228);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutWorkFlow), de::elo::ix::client::BSerializer_981594235, 981594235);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutWorkflowHistory), de::elo::ix::client::BSerializer_1555002297, 1555002297);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_checkoutWorkflowTemplate), de::elo::ix::client::BSerializer_968696309, 968696309);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_cleanupStart), de::elo::ix::client::BSerializer_97888340, 97888340);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_cleanupState), de::elo::ix::client::BSerializer_97888387, 97888387);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_cleanupStop), de::elo::ix::client::BSerializer_689578544, 689578544);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_closeEventBus), de::elo::ix::client::BSerializer_1579680296, 1579680296);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_collectJobStates), de::elo::ix::client::BSerializer_1479025845, 1479025845);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_collectMapDomains), de::elo::ix::client::BSerializer_1590880889, 1590880889);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_collectWorkFlowNodes), de::elo::ix::client::BSerializer_791411518, 791411518);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_collectWorkFlows), de::elo::ix::client::BSerializer_1540999264, 1540999264);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_combineAcl), de::elo::ix::client::BSerializer_1476771969, 1476771969);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_configureBackup), de::elo::ix::client::BSerializer_251783250, 251783250);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_configureFulltext), de::elo::ix::client::BSerializer_655595212, 655595212);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_configurePurge), de::elo::ix::client::BSerializer_1407134747, 1407134747);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_controlBackgroundThread), de::elo::ix::client::BSerializer_796672607, 796672607);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_controlBackup), de::elo::ix::client::BSerializer_429289481, 429289481);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_cookKeyword), de::elo::ix::client::BSerializer_922862219, 922862219);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_copySord), de::elo::ix::client::BSerializer_1944880601, 1944880601);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_createActivity), de::elo::ix::client::BSerializer_806333153, 806333153);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_createActivityProject), de::elo::ix::client::BSerializer_1769051912, 1769051912);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_createDoc), de::elo::ix::client::BSerializer_734350810, 734350810);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_createDocMask), de::elo::ix::client::BSerializer_171070926, 171070926);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_createEventBusListener), de::elo::ix::client::BSerializer_563568172, 563568172);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_createEventBusSubscriber), de::elo::ix::client::BSerializer_1671043104, 1671043104);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_createKey), de::elo::ix::client::BSerializer_734344371, 734344371);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_createNote), de::elo::ix::client::BSerializer_1289740092, 1289740092);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_createNote2), de::elo::ix::client::BSerializer_1327237138, 1327237138);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_createNoteTemplate), de::elo::ix::client::BSerializer_1517964638, 1517964638);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_createReminder), de::elo::ix::client::BSerializer_1943697476, 1943697476);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_createRsaKeys), de::elo::ix::client::BSerializer_518307262, 518307262);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_createSord), de::elo::ix::client::BSerializer_1289591200, 1289591200);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_createSubscription), de::elo::ix::client::BSerializer_1409951761, 1409951761);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_createUser), de::elo::ix::client::BSerializer_1289528163, 1289528163);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_createWFNode), de::elo::ix::client::BSerializer_2023998883, 2023998883);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_createWorkFlow), de::elo::ix::client::BSerializer_1798241359, 1798241359);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deferWorkFlowNode), de::elo::ix::client::BSerializer_77680797, 77680797);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_delegateWorkFlowNode), de::elo::ix::client::BSerializer_2095741220, 2095741220);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteActivity), de::elo::ix::client::BSerializer_2125754512, 2125754512);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteActivityProject), de::elo::ix::client::BSerializer_1847611287, 1847611287);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteConfigFiles), de::elo::ix::client::BSerializer_28637388, 28637388);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteCounters), de::elo::ix::client::BSerializer_885266568, 885266568);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteDocMask), de::elo::ix::client::BSerializer_1672606371, 1672606371);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteDocMaskLineTemplates), de::elo::ix::client::BSerializer_1672428606, 1672428606);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteEventBusListener), de::elo::ix::client::BSerializer_1871772453, 1871772453);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteEventBusSubscriber), de::elo::ix::client::BSerializer_1276207409, 1276207409);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteKeys), de::elo::ix::client::BSerializer_894462987, 894462987);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteKeywordList), de::elo::ix::client::BSerializer_1321521914, 1321521914);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteKeywords), de::elo::ix::client::BSerializer_9903403, 9903403);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteMap), de::elo::ix::client::BSerializer_1691419845, 1691419845);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteMapDomain), de::elo::ix::client::BSerializer_1747919839, 1747919839);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteNoteTemplates), de::elo::ix::client::BSerializer_2114072954, 2114072954);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteNotes), de::elo::ix::client::BSerializer_1955485472, 1955485472);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteNotification), de::elo::ix::client::BSerializer_109683220, 109683220);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteOrgUnits), de::elo::ix::client::BSerializer_792061036, 792061036);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteReminders), de::elo::ix::client::BSerializer_1922531104, 1922531104);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteReport), de::elo::ix::client::BSerializer_385335563, 385335563);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteSord), de::elo::ix::client::BSerializer_894215281, 894215281);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteSordTypes), de::elo::ix::client::BSerializer_789245482, 789245482);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteSubs), de::elo::ix::client::BSerializer_894209996, 894209996);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteSubscription), de::elo::ix::client::BSerializer_363712994, 363712994);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteTranslateTerms), de::elo::ix::client::BSerializer_158441882, 158441882);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteUserProfile), de::elo::ix::client::BSerializer_634031555, 634031555);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteUsers), de::elo::ix::client::BSerializer_1948915673, 1948915673);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteWorkFlow), de::elo::ix::client::BSerializer_478820000, 478820000);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_deleteWorkflowTemplate), de::elo::ix::client::BSerializer_1634712102, 1634712102);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_editPublicDownloadUrls), de::elo::ix::client::BSerializer_245225739, 245225739);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_encryptStringRsa), de::elo::ix::client::BSerializer_1840380736, 1840380736);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_endEditWorkFlowNode), de::elo::ix::client::BSerializer_551973808, 551973808);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_evalAutoFiling), de::elo::ix::client::BSerializer_1823282746, 1823282746);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_executeRegisteredFunction), de::elo::ix::client::BSerializer_778610599, 778610599);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_executeRegisteredFunctionString), de::elo::ix::client::BSerializer_553270730, 553270730);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_executeScript), de::elo::ix::client::BSerializer_905800490, 905800490);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_exportWorkflow), de::elo::ix::client::BSerializer_809552457, 809552457);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findActivityProjects), de::elo::ix::client::BSerializer_1955899064, 1955899064);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findBackgroundThreads), de::elo::ix::client::BSerializer_610169452, 610169452);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findClose), de::elo::ix::client::BSerializer_928687287, 928687287);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findFirstActivities), de::elo::ix::client::BSerializer_1661199666, 1661199666);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findFirstConfigFiles), de::elo::ix::client::BSerializer_954269076, 954269076);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findFirstNotes), de::elo::ix::client::BSerializer_299362112, 299362112);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findFirstReportInfos), de::elo::ix::client::BSerializer_693111280, 693111280);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findFirstSords), de::elo::ix::client::BSerializer_303977764, 303977764);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findFirstSubscriptions), de::elo::ix::client::BSerializer_1290105973, 1290105973);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findFirstTasks), de::elo::ix::client::BSerializer_304485389, 304485389);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findFirstTranslateTerms), de::elo::ix::client::BSerializer_1162113222, 1162113222);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findFirstUsers), de::elo::ix::client::BSerializer_305931911, 305931911);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findFirstWorkflows), de::elo::ix::client::BSerializer_546938477, 546938477);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findNextActivities), de::elo::ix::client::BSerializer_2116795663, 2116795663);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findNextConfigFiles), de::elo::ix::client::BSerializer_2108007283, 2108007283);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findNextNotes), de::elo::ix::client::BSerializer_1493835871, 1493835871);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findNextReportInfos), de::elo::ix::client::BSerializer_1846849487, 1846849487);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findNextSords), de::elo::ix::client::BSerializer_1498451523, 1498451523);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findNextSubscriptions), de::elo::ix::client::BSerializer_1930960532, 1930960532);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findNextTasks), de::elo::ix::client::BSerializer_1498959148, 1498959148);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findNextTranslateTerms), de::elo::ix::client::BSerializer_1524508923, 1524508923);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findNextUsers), de::elo::ix::client::BSerializer_1500405670, 1500405670);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_findNextWorkflows), de::elo::ix::client::BSerializer_1653142322, 1653142322);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_finishExport), de::elo::ix::client::BSerializer_1487849891, 1487849891);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_forwardWorkflowNode), de::elo::ix::client::BSerializer_572079312, 572079312);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getAclAccess), de::elo::ix::client::BSerializer_939270158, 939270158);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getArchiveStatistics), de::elo::ix::client::BSerializer_538085115, 538085115);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getCompiledScripts), de::elo::ix::client::BSerializer_1449667401, 1449667401);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getConstants), de::elo::ix::client::BSerializer_14637361, 14637361);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getContextTerms), de::elo::ix::client::BSerializer_1075096680, 1075096680);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getDebuggerPort), de::elo::ix::client::BSerializer_1274938050, 1274938050);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getDistinctValuesOfObjKey), de::elo::ix::client::BSerializer_1260382845, 1260382845);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getESWFromEditInfo), de::elo::ix::client::BSerializer_1694552757, 1694552757);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getEditInfoFromESW), de::elo::ix::client::BSerializer_835848697, 835848697);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getExportZipUrl), de::elo::ix::client::BSerializer_1446672866, 1446672866);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getImportZipUrl), de::elo::ix::client::BSerializer_254632211, 254632211);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getPublicDownloads), de::elo::ix::client::BSerializer_1822446082, 1822446082);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getScriptsToDebug), de::elo::ix::client::BSerializer_272016144, 272016144);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getSearchTerms), de::elo::ix::client::BSerializer_349631039, 349631039);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getServerInfo), de::elo::ix::client::BSerializer_2074326767, 2074326767);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getServerInfoDM), de::elo::ix::client::BSerializer_563195558, 563195558);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getSessionFromTicket), de::elo::ix::client::BSerializer_147146740, 147146740);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getSessionInfos), de::elo::ix::client::BSerializer_1406789391, 1406789391);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getSessionOptions), de::elo::ix::client::BSerializer_109969832, 109969832);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getUserNames), de::elo::ix::client::BSerializer_730904509, 730904509);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getWebDAVPathFromObjID), de::elo::ix::client::BSerializer_1491154434, 1491154434);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getWebDAVPathFromObjID2), de::elo::ix::client::BSerializer_1018852852, 1018852852);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_getWorkflowTemplateVersions), de::elo::ix::client::BSerializer_775523732, 775523732);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_importWorkFlow), de::elo::ix::client::BSerializer_2013797722, 2013797722);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_importWorkFlow2), de::elo::ix::client::BSerializer_1996780008, 1996780008);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_insertPublicDownload), de::elo::ix::client::BSerializer_1596476256, 1596476256);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_internalReceiveEvents), de::elo::ix::client::BSerializer_1518401879, 1518401879);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_invalidateCache), de::elo::ix::client::BSerializer_767982831, 767982831);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_invalidateCache2), de::elo::ix::client::BSerializer_1962336065, 1962336065);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_linkSords), de::elo::ix::client::BSerializer_1326760021, 1326760021);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_linkSords2), de::elo::ix::client::BSerializer_1820112259, 1820112259);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_lockArchive), de::elo::ix::client::BSerializer_2083874271, 2083874271);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_login), de::elo::ix::client::BSerializer_1526465549, 1526465549);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_loginAdmin), de::elo::ix::client::BSerializer_139618532, 139618532);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_loginEloProf), de::elo::ix::client::BSerializer_1544232786, 1544232786);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_loginKerberos), de::elo::ix::client::BSerializer_575080338, 575080338);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_logout), de::elo::ix::client::BSerializer_75785664, 75785664);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_moveDocuments), de::elo::ix::client::BSerializer_1730554767, 1730554767);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_notifyServer), de::elo::ix::client::BSerializer_1873214498, 1873214498);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_openEventBus), de::elo::ix::client::BSerializer_1111320026, 1111320026);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_parseException), de::elo::ix::client::BSerializer_218602898, 218602898);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_processFindResult), de::elo::ix::client::BSerializer_255834993, 255834993);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_processOcr), de::elo::ix::client::BSerializer_2058356197, 2058356197);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_processTrees), de::elo::ix::client::BSerializer_1894562916, 1894562916);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_provideCryptPassword), de::elo::ix::client::BSerializer_515214142, 515214142);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_queryJobProtocol), de::elo::ix::client::BSerializer_1653875517, 1653875517);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_queryJobState), de::elo::ix::client::BSerializer_221322822, 221322822);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_refSord), de::elo::ix::client::BSerializer_1607355701, 1607355701);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_registerOcrWorker), de::elo::ix::client::BSerializer_318217117, 318217117);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_reload), de::elo::ix::client::BSerializer_86902351, 86902351);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_reloadScripts), de::elo::ix::client::BSerializer_1767312455, 1767312455);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_resolveRights), de::elo::ix::client::BSerializer_262295187, 262295187);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_restoreSord), de::elo::ix::client::BSerializer_487898554, 487898554);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_sendEvents), de::elo::ix::client::BSerializer_1721831543, 1721831543);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_setScriptsToDebug), de::elo::ix::client::BSerializer_1212168964, 1212168964);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_setServerInfo), de::elo::ix::client::BSerializer_1300195555, 1300195555);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_setServerInfoDM), de::elo::ix::client::BSerializer_347556966, 347556966);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_setSessionOptions), de::elo::ix::client::BSerializer_830182988, 830182988);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_startAdHocWorkFlow), de::elo::ix::client::BSerializer_1995358580, 1995358580);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_startAdHocWorkFlow2), de::elo::ix::client::BSerializer_1726573786, 1726573786);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_startAdHocWorkFlow3), de::elo::ix::client::BSerializer_1726573785, 1726573785);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_startExport), de::elo::ix::client::BSerializer_1213820864, 1213820864);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_startExportExt), de::elo::ix::client::BSerializer_1607764545, 1607764545);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_startImport), de::elo::ix::client::BSerializer_1318178737, 1318178737);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_startWorkFlow), de::elo::ix::client::BSerializer_211211499, 211211499);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_takeWorkFlowNode), de::elo::ix::client::BSerializer_1305676322, 1305676322);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_terminatePublicDownloadUrls), de::elo::ix::client::BSerializer_158007264, 158007264);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_terminateWorkFlow), de::elo::ix::client::BSerializer_1986005738, 1986005738);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_testAdapter), de::elo::ix::client::BSerializer_1934035815, 1934035815);
	registerClass(typeid(de::elo::ix::client::BRequest_IXServicePortIF_unlinkSords), de::elo::ix::client::BSerializer_1910068060, 1910068060);
	registerClass(typeid(de::elo::ix::client::BResult_1), de::elo::ix::client::BSerializer_139578694, 139578694);
	registerClass(typeid(de::elo::ix::client::BResult_10), de::elo::ix::client::BSerializer_31972170, 31972170);
	registerClass(typeid(de::elo::ix::client::BResult_1001617329), de::elo::ix::client::BSerializer_1737934677, 1737934677);
	registerClass(typeid(de::elo::ix::client::BResult_100361105), de::elo::ix::client::BSerializer_1083146178, 1083146178);
	registerClass(typeid(de::elo::ix::client::BResult_1005790586), de::elo::ix::client::BSerializer_1028792992, 1028792992);
	registerClass(typeid(de::elo::ix::client::BResult_1034263904), de::elo::ix::client::BSerializer_928929669, 928929669);
	registerClass(typeid(de::elo::ix::client::BResult_1047127860), de::elo::ix::client::BSerializer_1007078901, 1007078901);
	registerClass(typeid(de::elo::ix::client::BResult_1057373949), de::elo::ix::client::BSerializer_1483320409, 1483320409);
	registerClass(typeid(de::elo::ix::client::BResult_105830886), de::elo::ix::client::BSerializer_1366049664, 1366049664);
	registerClass(typeid(de::elo::ix::client::BResult_1078168929), de::elo::ix::client::BSerializer_1463196284, 1463196284);
	registerClass(typeid(de::elo::ix::client::BResult_1088095067), de::elo::ix::client::BSerializer_253657563, 253657563);
	registerClass(typeid(de::elo::ix::client::BResult_1107316733), de::elo::ix::client::BSerializer_874621629, 874621629);
	registerClass(typeid(de::elo::ix::client::BResult_1112009864), de::elo::ix::client::BSerializer_1906806987, 1906806987);
	registerClass(typeid(de::elo::ix::client::BResult_1132956238), de::elo::ix::client::BSerializer_1840998419, 1840998419);
	registerClass(typeid(de::elo::ix::client::BResult_1143177929), de::elo::ix::client::BSerializer_50804539, 50804539);
	registerClass(typeid(de::elo::ix::client::BResult_1153931872), de::elo::ix::client::BSerializer_1917165361, 1917165361);
	registerClass(typeid(de::elo::ix::client::BResult_1191976387), de::elo::ix::client::BSerializer_1472696983, 1472696983);
	registerClass(typeid(de::elo::ix::client::BResult_1197100286), de::elo::ix::client::BSerializer_678319756, 678319756);
	registerClass(typeid(de::elo::ix::client::BResult_1233469422), de::elo::ix::client::BSerializer_778916661, 778916661);
	registerClass(typeid(de::elo::ix::client::BResult_1264954948), de::elo::ix::client::BSerializer_1553005093, 1553005093);
	registerClass(typeid(de::elo::ix::client::BResult_1301335819), de::elo::ix::client::BSerializer_526443365, 526443365);
	registerClass(typeid(de::elo::ix::client::BResult_1320348587), de::elo::ix::client::BSerializer_1169396716, 1169396716);
	registerClass(typeid(de::elo::ix::client::BResult_133130047), de::elo::ix::client::BSerializer_324094143, 324094143);
	registerClass(typeid(de::elo::ix::client::BResult_1376733713), de::elo::ix::client::BSerializer_98220986, 98220986);
	registerClass(typeid(de::elo::ix::client::BResult_1383534582), de::elo::ix::client::BSerializer_878709939, 878709939);
	registerClass(typeid(de::elo::ix::client::BResult_1401065069), de::elo::ix::client::BSerializer_1364135521, 1364135521);
	registerClass(typeid(de::elo::ix::client::BResult_1425760760), de::elo::ix::client::BSerializer_1576794397, 1576794397);
	registerClass(typeid(de::elo::ix::client::BResult_1426941339), de::elo::ix::client::BSerializer_1775232095, 1775232095);
	registerClass(typeid(de::elo::ix::client::BResult_1436376940), de::elo::ix::client::BSerializer_201271360, 201271360);
	registerClass(typeid(de::elo::ix::client::BResult_1443841819), de::elo::ix::client::BSerializer_980746876, 980746876);
	registerClass(typeid(de::elo::ix::client::BResult_148564345), de::elo::ix::client::BSerializer_1968102497, 1968102497);
	registerClass(typeid(de::elo::ix::client::BResult_1485735592), de::elo::ix::client::BSerializer_853868916, 853868916);
	registerClass(typeid(de::elo::ix::client::BResult_1495731174), de::elo::ix::client::BSerializer_888818351, 888818351);
	registerClass(typeid(de::elo::ix::client::BResult_15), de::elo::ix::client::BSerializer_31972165, 31972165);
	registerClass(typeid(de::elo::ix::client::BResult_1535847981), de::elo::ix::client::BSerializer_1539142900, 1539142900);
	registerClass(typeid(de::elo::ix::client::BResult_1537059480), de::elo::ix::client::BSerializer_1208871945, 1208871945);
	registerClass(typeid(de::elo::ix::client::BResult_1552114559), de::elo::ix::client::BSerializer_2135982691, 2135982691);
	registerClass(typeid(de::elo::ix::client::BResult_1556767716), de::elo::ix::client::BSerializer_1590515712, 1590515712);
	registerClass(typeid(de::elo::ix::client::BResult_1576340510), de::elo::ix::client::BSerializer_664594975, 664594975);
	registerClass(typeid(de::elo::ix::client::BResult_1585309177), de::elo::ix::client::BSerializer_1516472013, 1516472013);
	registerClass(typeid(de::elo::ix::client::BResult_1663767661), de::elo::ix::client::BSerializer_1136640270, 1136640270);
	registerClass(typeid(de::elo::ix::client::BResult_1698110251), de::elo::ix::client::BSerializer_237230375, 237230375);
	registerClass(typeid(de::elo::ix::client::BResult_1699606509), de::elo::ix::client::BSerializer_792677022, 792677022);
	registerClass(typeid(de::elo::ix::client::BResult_1701141707), de::elo::ix::client::BSerializer_1830105166, 1830105166);
	registerClass(typeid(de::elo::ix::client::BResult_1701204890), de::elo::ix::client::BSerializer_1855130839, 1855130839);
	registerClass(typeid(de::elo::ix::client::BResult_1712381166), de::elo::ix::client::BSerializer_226398691, 226398691);
	registerClass(typeid(de::elo::ix::client::BResult_1737266313), de::elo::ix::client::BSerializer_470722300, 470722300);
	registerClass(typeid(de::elo::ix::client::BResult_1754570852), de::elo::ix::client::BSerializer_439024483, 439024483);
	registerClass(typeid(de::elo::ix::client::BResult_1756288553), de::elo::ix::client::BSerializer_2129303359, 2129303359);
	registerClass(typeid(de::elo::ix::client::BResult_1768472140), de::elo::ix::client::BSerializer_1408305917, 1408305917);
	registerClass(typeid(de::elo::ix::client::BResult_1788243283), de::elo::ix::client::BSerializer_538961305, 538961305);
	registerClass(typeid(de::elo::ix::client::BResult_18214274), de::elo::ix::client::BSerializer_124408536, 124408536);
	registerClass(typeid(de::elo::ix::client::BResult_1822579866), de::elo::ix::client::BSerializer_218334399, 218334399);
	registerClass(typeid(de::elo::ix::client::BResult_1826370901), de::elo::ix::client::BSerializer_584143824, 584143824);
	registerClass(typeid(de::elo::ix::client::BResult_1835331414), de::elo::ix::client::BSerializer_267493766, 267493766);
	registerClass(typeid(de::elo::ix::client::BResult_1870182600), de::elo::ix::client::BSerializer_1546359614, 1546359614);
	registerClass(typeid(de::elo::ix::client::BResult_1881161566), de::elo::ix::client::BSerializer_1082076800, 1082076800);
	registerClass(typeid(de::elo::ix::client::BResult_1888107655), de::elo::ix::client::BSerializer_1300693476, 1300693476);
	registerClass(typeid(de::elo::ix::client::BResult_19), de::elo::ix::client::BSerializer_31972161, 31972161);
	registerClass(typeid(de::elo::ix::client::BResult_1963952629), de::elo::ix::client::BSerializer_2087116643, 2087116643);
	registerClass(typeid(de::elo::ix::client::BResult_1995912373), de::elo::ix::client::BSerializer_496923600, 496923600);
	registerClass(typeid(de::elo::ix::client::BResult_200528028), de::elo::ix::client::BSerializer_670536426, 670536426);
	registerClass(typeid(de::elo::ix::client::BResult_2006133032), de::elo::ix::client::BSerializer_1542551545, 1542551545);
	registerClass(typeid(de::elo::ix::client::BResult_2011132580), de::elo::ix::client::BSerializer_1152181358, 1152181358);
	registerClass(typeid(de::elo::ix::client::BResult_2015686193), de::elo::ix::client::BSerializer_1749255216, 1749255216);
	registerClass(typeid(de::elo::ix::client::BResult_2054753789), de::elo::ix::client::BSerializer_65290103, 65290103);
	registerClass(typeid(de::elo::ix::client::BResult_2056457945), de::elo::ix::client::BSerializer_1754530970, 1754530970);
	registerClass(typeid(de::elo::ix::client::BResult_206201524), de::elo::ix::client::BSerializer_271580133, 271580133);
	registerClass(typeid(de::elo::ix::client::BResult_2062827124), de::elo::ix::client::BSerializer_59064871, 59064871);
	registerClass(typeid(de::elo::ix::client::BResult_21), de::elo::ix::client::BSerializer_31972138, 31972138);
	registerClass(typeid(de::elo::ix::client::BResult_2121298555), de::elo::ix::client::BSerializer_1182476551, 1182476551);
	registerClass(typeid(de::elo::ix::client::BResult_222450704), de::elo::ix::client::BSerializer_269034055, 269034055);
	registerClass(typeid(de::elo::ix::client::BResult_231031238), de::elo::ix::client::BSerializer_1008002146, 1008002146);
	registerClass(typeid(de::elo::ix::client::BResult_239574905), de::elo::ix::client::BSerializer_334967155, 334967155);
	registerClass(typeid(de::elo::ix::client::BResult_256674679), de::elo::ix::client::BSerializer_516768961, 516768961);
	registerClass(typeid(de::elo::ix::client::BResult_276702696), de::elo::ix::client::BSerializer_270472684, 270472684);
	registerClass(typeid(de::elo::ix::client::BResult_323351719), de::elo::ix::client::BSerializer_679516051, 679516051);
	registerClass(typeid(de::elo::ix::client::BResult_333475674), de::elo::ix::client::BSerializer_1093888861, 1093888861);
	registerClass(typeid(de::elo::ix::client::BResult_341056676), de::elo::ix::client::BSerializer_945357981, 945357981);
	registerClass(typeid(de::elo::ix::client::BResult_42339713), de::elo::ix::client::BSerializer_58447221, 58447221);
	registerClass(typeid(de::elo::ix::client::BResult_460199434), de::elo::ix::client::BSerializer_1768431067, 1768431067);
	registerClass(typeid(de::elo::ix::client::BResult_491352407), de::elo::ix::client::BSerializer_652213248, 652213248);
	registerClass(typeid(de::elo::ix::client::BResult_494610451), de::elo::ix::client::BSerializer_2092431731, 2092431731);
	registerClass(typeid(de::elo::ix::client::BResult_498630295), de::elo::ix::client::BSerializer_1349324407, 1349324407);
	registerClass(typeid(de::elo::ix::client::BResult_5), de::elo::ix::client::BSerializer_139578690, 139578690);
	registerClass(typeid(de::elo::ix::client::BResult_52201250), de::elo::ix::client::BSerializer_1769614830, 1769614830);
	registerClass(typeid(de::elo::ix::client::BResult_545905411), de::elo::ix::client::BSerializer_1133476629, 1133476629);
	registerClass(typeid(de::elo::ix::client::BResult_6), de::elo::ix::client::BSerializer_139578689, 139578689);
	registerClass(typeid(de::elo::ix::client::BResult_607287445), de::elo::ix::client::BSerializer_1768200726, 1768200726);
	registerClass(typeid(de::elo::ix::client::BResult_63967077), de::elo::ix::client::BSerializer_311083626, 311083626);
	registerClass(typeid(de::elo::ix::client::BResult_661820173), de::elo::ix::client::BSerializer_765305647, 765305647);
	registerClass(typeid(de::elo::ix::client::BResult_730157667), de::elo::ix::client::BSerializer_296180383, 296180383);
	registerClass(typeid(de::elo::ix::client::BResult_736351635), de::elo::ix::client::BSerializer_790953868, 790953868);
	registerClass(typeid(de::elo::ix::client::BResult_755261279), de::elo::ix::client::BSerializer_933605785, 933605785);
	registerClass(typeid(de::elo::ix::client::BResult_776454091), de::elo::ix::client::BSerializer_799026444, 799026444);
	registerClass(typeid(de::elo::ix::client::BResult_77743605), de::elo::ix::client::BSerializer_1249722428, 1249722428);
	registerClass(typeid(de::elo::ix::client::BResult_777531606), de::elo::ix::client::BSerializer_115175465, 115175465);
	registerClass(typeid(de::elo::ix::client::BResult_784089396), de::elo::ix::client::BSerializer_942817669, 942817669);
	registerClass(typeid(de::elo::ix::client::BResult_785380175), de::elo::ix::client::BSerializer_30303361, 30303361);
	registerClass(typeid(de::elo::ix::client::BResult_809229049), de::elo::ix::client::BSerializer_681379622, 681379622);
	registerClass(typeid(de::elo::ix::client::BResult_810727301), de::elo::ix::client::BSerializer_1125286952, 1125286952);
	registerClass(typeid(de::elo::ix::client::BResult_820228328), de::elo::ix::client::BSerializer_474407488, 474407488);
	registerClass(typeid(de::elo::ix::client::BResult_881442092), de::elo::ix::client::BSerializer_1007204783, 1007204783);
	registerClass(typeid(de::elo::ix::client::BResult_884364631), de::elo::ix::client::BSerializer_1628589312, 1628589312);
	registerClass(typeid(de::elo::ix::client::BResult_888671717), de::elo::ix::client::BSerializer_970359246, 970359246);
	registerClass(typeid(de::elo::ix::client::BResult_892356058), de::elo::ix::client::BSerializer_1595522649, 1595522649);
	registerClass(typeid(de::elo::ix::client::BResult_893011331), de::elo::ix::client::BSerializer_1901668644, 1901668644);
	registerClass(typeid(de::elo::ix::client::BResult_907729609), de::elo::ix::client::BSerializer_1537036490, 1537036490);
	registerClass(typeid(de::elo::ix::client::BResult_910482075), de::elo::ix::client::BSerializer_1281727937, 1281727937);
	registerClass(typeid(de::elo::ix::client::BResult_937420667), de::elo::ix::client::BSerializer_1910622485, 1910622485);
	registerClass(typeid(de::elo::ix::client::BResult_998509414), de::elo::ix::client::BSerializer_870856762, 870856762);
	registerClass(typeid(de::elo::ix::client::BStub_IXEventBusHandler), de::elo::ix::client::BSerializer_627994447, 627994447);
	registerClass(typeid(de::elo::ix::client::BStub_IXServerEvents), de::elo::ix::client::BSerializer_1938363825, 1938363825);
	registerClass(typeid(de::elo::ix::client::BStub_IXServicePortIF), de::elo::ix::client::BSerializer_1795705954, 1795705954);
	registerClass(typeid(de::elo::ix::client::BackupProfile), de::elo::ix::client::BSerializer_1230334315, 1230334315);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PBackupProfile > ), de::elo::ix::client::BSerializer_1233469422, 1233469422);
	registerClass(typeid(de::elo::ix::client::BackupPurgeStatus), de::elo::ix::client::BSerializer_52201250, 52201250);
	registerClass(typeid(de::elo::ix::client::BackupStatus), de::elo::ix::client::BSerializer_1288074907, 1288074907);
	registerClass(typeid(de::elo::ix::client::BeginForwardWorkflowNodeInfo), de::elo::ix::client::BSerializer_823426303, 823426303);
	registerClass(typeid(de::elo::ix::client::Bitset), de::elo::ix::client::BSerializer_1084624222, 1084624222);
	registerClass(typeid(de::elo::ix::client::CheckAccessOptions), de::elo::ix::client::BSerializer_2061147439, 2061147439);
	registerClass(typeid(de::elo::ix::client::CheckInDocMaskLineTemplateOptions), de::elo::ix::client::BSerializer_1586163042, 1586163042);
	registerClass(typeid(de::elo::ix::client::CheckinDocOptions), de::elo::ix::client::BSerializer_1433031299, 1433031299);
	registerClass(typeid(de::elo::ix::client::CheckinOrgUnitInfo), de::elo::ix::client::BSerializer_740959052, 740959052);
	registerClass(typeid(de::elo::ix::client::CheckinReportInfo), de::elo::ix::client::BSerializer_279483092, 279483092);
	registerClass(typeid(de::elo::ix::client::CheckinUsersC), de::elo::ix::client::BSerializer_1602486374, 1602486374);
	registerClass(typeid(de::elo::ix::client::CheckinUsersZ), de::elo::ix::client::BSerializer_403687865, 403687865);
	registerClass(typeid(de::elo::ix::client::CheckoutOrgUnitInfo), de::elo::ix::client::BSerializer_948431844, 948431844);
	registerClass(typeid(de::elo::ix::client::CheckoutSordPathInfo), de::elo::ix::client::BSerializer_730679282, 730679282);
	registerClass(typeid(de::elo::ix::client::CheckoutUsersC), de::elo::ix::client::BSerializer_531758278, 531758278);
	registerClass(typeid(de::elo::ix::client::CheckoutUsersZ), de::elo::ix::client::BSerializer_1897433533, 1897433533);
	registerClass(typeid(de::elo::ix::client::CheckoutWorkflowHistoryParams), de::elo::ix::client::BSerializer_299426984, 299426984);
	registerClass(typeid(de::elo::ix::client::CheckoutWorkflowHistoryResult), de::elo::ix::client::BSerializer_1754570852, 1754570852);
	registerClass(typeid(de::elo::ix::client::ClientInfo), de::elo::ix::client::BSerializer_1258190913, 1258190913);
	registerClass(typeid(de::elo::ix::client::ClientInfoC), de::elo::ix::client::BSerializer_847449421, 847449421);
	registerClass(typeid(de::elo::ix::client::ColorData), de::elo::ix::client::BSerializer_1735048729, 1735048729);
	registerClass(typeid(de::elo::ix::client::ColorDataC), de::elo::ix::client::BSerializer_881975137, 881975137);
	registerClass(typeid(de::elo::ix::client::ColorDataInternC), de::elo::ix::client::BSerializer_1208511866, 1208511866);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PColorData > ), de::elo::ix::client::BSerializer_1870182600, 1870182600);
	registerClass(typeid(de::elo::ix::client::CombineAclOptions), de::elo::ix::client::BSerializer_66519402, 66519402);
	registerClass(typeid(de::elo::ix::client::CombineAclResult), de::elo::ix::client::BSerializer_1034263904, 1034263904);
	registerClass(typeid(de::elo::ix::client::ConfigFile), de::elo::ix::client::BSerializer_582012382, 582012382);
	registerClass(typeid(de::elo::ix::client::ConfigFileC), de::elo::ix::client::BSerializer_2098566124, 2098566124);
	registerClass(typeid(de::elo::ix::client::ConfigFileZ), de::elo::ix::client::BSerializer_821574897, 821574897);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PConfigFile > ), de::elo::ix::client::BSerializer_1737266313, 1737266313);
	registerClass(typeid(de::elo::ix::client::ContextTerm), de::elo::ix::client::BSerializer_1464223403, 1464223403);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PContextTerm > ), de::elo::ix::client::BSerializer_1005790586, 1005790586);
	registerClass(typeid(de::elo::ix::client::ControlBackupInfo), de::elo::ix::client::BSerializer_1738666671, 1738666671);
	registerClass(typeid(de::elo::ix::client::ControlBackupInfoC), de::elo::ix::client::BSerializer_1165618755, 1165618755);
	registerClass(typeid(de::elo::ix::client::CopyInfo), de::elo::ix::client::BSerializer_2138439536, 2138439536);
	registerClass(typeid(de::elo::ix::client::CopyOptions), de::elo::ix::client::BSerializer_1427182574, 1427182574);
	registerClass(typeid(de::elo::ix::client::CopyResult), de::elo::ix::client::BSerializer_1904597264, 1904597264);
	registerClass(typeid(de::elo::ix::client::CopySordC), de::elo::ix::client::BSerializer_1616091412, 1616091412);
	registerClass(typeid(de::elo::ix::client::CopySordZ), de::elo::ix::client::BSerializer_2059126408, 2059126408);
	registerClass(typeid(de::elo::ix::client::CountResult), de::elo::ix::client::BSerializer_1581335066, 1581335066);
	registerClass(typeid(de::elo::ix::client::CounterInfo), de::elo::ix::client::BSerializer_1809378891, 1809378891);
	registerClass(typeid(de::elo::ix::client::CounterInfoC), de::elo::ix::client::BSerializer_1843901056, 1843901056);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PCounterInfo > ), de::elo::ix::client::BSerializer_1698110251, 1698110251);
	registerClass(typeid(de::elo::ix::client::CryptInfo), de::elo::ix::client::BSerializer_1826259804, 1826259804);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PCryptInfo > ), de::elo::ix::client::BSerializer_809229049, 809229049);
	registerClass(typeid(de::elo::ix::client::DeleteActivityOptions), de::elo::ix::client::BSerializer_78913228, 78913228);
	registerClass(typeid(de::elo::ix::client::DeleteOptions), de::elo::ix::client::BSerializer_329713511, 329713511);
	registerClass(typeid(de::elo::ix::client::DeleteOrgUnitInfo), de::elo::ix::client::BSerializer_537993523, 537993523);
	registerClass(typeid(de::elo::ix::client::DocHistory), de::elo::ix::client::BSerializer_189452795, 189452795);
	registerClass(typeid(de::elo::ix::client::DocHistoryC), de::elo::ix::client::BSerializer_1456349355, 1456349355);
	registerClass(typeid(de::elo::ix::client::DocInfoDM), de::elo::ix::client::BSerializer_673204378, 673204378);
	registerClass(typeid(de::elo::ix::client::DocInfoDMC), de::elo::ix::client::BSerializer_1042422760, 1042422760);
	registerClass(typeid(de::elo::ix::client::DocMask), de::elo::ix::client::BSerializer_2054753789, 2054753789);
	registerClass(typeid(de::elo::ix::client::DocMaskC), de::elo::ix::client::BSerializer_387842089, 387842089);
	registerClass(typeid(de::elo::ix::client::DocMaskDataC), de::elo::ix::client::BSerializer_1968969939, 1968969939);
	registerClass(typeid(de::elo::ix::client::DocMaskDetails), de::elo::ix::client::BSerializer_639048562, 639048562);
	registerClass(typeid(de::elo::ix::client::DocMaskLine), de::elo::ix::client::BSerializer_1291500689, 1291500689);
	registerClass(typeid(de::elo::ix::client::DocMaskLineC), de::elo::ix::client::BSerializer_1453574806, 1453574806);
	registerClass(typeid(de::elo::ix::client::DocMaskLineDataC), de::elo::ix::client::BSerializer_1178569423, 1178569423);
	registerClass(typeid(de::elo::ix::client::DocMaskLineTemplate), de::elo::ix::client::BSerializer_117741089, 117741089);
	registerClass(typeid(de::elo::ix::client::DocMaskLineTemplateC), de::elo::ix::client::BSerializer_984407269, 984407269);
	registerClass(typeid(de::elo::ix::client::DocMaskLineTemplateDataC), de::elo::ix::client::BSerializer_96404005, 96404005);
	registerClass(typeid(de::elo::ix::client::DocMaskLineTemplateZ), de::elo::ix::client::BSerializer_1687510263, 1687510263);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PDocMaskLineTemplate > ), de::elo::ix::client::BSerializer_1107316733, 1107316733);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PDocMaskLine > ), de::elo::ix::client::BSerializer_745804061, 745804061);
	registerClass(typeid(de::elo::ix::client::DocMaskZ), de::elo::ix::client::BSerializer_1064616030, 1064616030);
	registerClass(typeid(de::elo::ix::client::DocVersion), de::elo::ix::client::BSerializer_633004623, 633004623);
	registerClass(typeid(de::elo::ix::client::DocVersionC), de::elo::ix::client::BSerializer_615288749, 615288749);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PDocVersion > ), de::elo::ix::client::BSerializer_807293031, 807293031);
	registerClass(typeid(de::elo::ix::client::Document), de::elo::ix::client::BSerializer_341056676, 341056676);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PDocument > ), de::elo::ix::client::BSerializer_1047127860, 1047127860);
	registerClass(typeid(de::elo::ix::client::EditInfo), de::elo::ix::client::BSerializer_820228328, 820228328);
	registerClass(typeid(de::elo::ix::client::EditInfoC), de::elo::ix::client::BSerializer_2100880359, 2100880359);
	registerClass(typeid(de::elo::ix::client::EditInfoEswOptions), de::elo::ix::client::BSerializer_522299581, 522299581);
	registerClass(typeid(de::elo::ix::client::EditInfoZ), de::elo::ix::client::BSerializer_878901868, 878901868);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PEditInfo > ), de::elo::ix::client::BSerializer_785380175, 785380175);
	registerClass(typeid(de::elo::ix::client::EloDmOpt), de::elo::ix::client::BSerializer_353149300, 353149300);
	registerClass(typeid(de::elo::ix::client::EloDmOptC), de::elo::ix::client::BSerializer_605470240, 605470240);
	registerClass(typeid(de::elo::ix::client::EloDmOptDataC), de::elo::ix::client::BSerializer_1218961099, 1218961099);
	registerClass(typeid(de::elo::ix::client::EloFtOpt), de::elo::ix::client::BSerializer_181406923, 181406923);
	registerClass(typeid(de::elo::ix::client::EloFtOptC), de::elo::ix::client::BSerializer_1603857234, 1603857234);
	registerClass(typeid(de::elo::ix::client::EloFtOptDataC), de::elo::ix::client::BSerializer_1220982870, 1220982870);
	registerClass(typeid(de::elo::ix::client::EloFtStop), de::elo::ix::client::BSerializer_2135577346, 2135577346);
	registerClass(typeid(de::elo::ix::client::EloFtStopC), de::elo::ix::client::BSerializer_1842033553, 1842033553);
	registerClass(typeid(de::elo::ix::client::EloIxOpt), de::elo::ix::client::BSerializer_1454054253, 1454054253);
	registerClass(typeid(de::elo::ix::client::EloIxOptC), de::elo::ix::client::BSerializer_149956656, 149956656);
	registerClass(typeid(de::elo::ix::client::EloIxOptDataC), de::elo::ix::client::BSerializer_1223860309, 1223860309);
	registerClass(typeid(de::elo::ix::client::EloIxOpt_old), de::elo::ix::client::BSerializer_399031267, 399031267);
	registerClass(typeid(de::elo::ix::client::EloIxOpt_oldC), de::elo::ix::client::BSerializer_1148546611, 1148546611);
	registerClass(typeid(de::elo::ix::client::Event), de::elo::ix::client::BSerializer_877454055, 877454055);
	registerClass(typeid(de::elo::ix::client::EventBusC), de::elo::ix::client::BSerializer_572745886, 572745886);
	registerClass(typeid(de::elo::ix::client::EventBusParams), de::elo::ix::client::BSerializer_1489333610, 1489333610);
	registerClass(typeid(de::elo::ix::client::EventFilter), de::elo::ix::client::BSerializer_1095275943, 1095275943);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PEventFilter > ), de::elo::ix::client::BSerializer_722503869, 722503869);
	registerClass(typeid(de::elo::ix::client::EventListener), de::elo::ix::client::BSerializer_1005733106, 1005733106);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PEvent > ), de::elo::ix::client::BSerializer_910482075, 910482075);
	registerClass(typeid(de::elo::ix::client::ExecuteScriptParams), de::elo::ix::client::BSerializer_936440117, 936440117);
	registerClass(typeid(de::elo::ix::client::ExecuteScriptResult), de::elo::ix::client::BSerializer_63967077, 63967077);
	registerClass(typeid(de::elo::ix::client::ExportExtOptions), de::elo::ix::client::BSerializer_291967, 291967);
	registerClass(typeid(de::elo::ix::client::ExportExtOptionsC), de::elo::ix::client::BSerializer_162646972, 162646972);
	registerClass(typeid(de::elo::ix::client::ExportOptionsC), de::elo::ix::client::BSerializer_2043834611, 2043834611);
	registerClass(typeid(de::elo::ix::client::FileData), de::elo::ix::client::BSerializer_888671717, 888671717);
	registerClass(typeid(de::elo::ix::client::FileDataC), de::elo::ix::client::BSerializer_1011013570, 1011013570);
	registerClass(typeid(de::elo::ix::client::FileDataZ), de::elo::ix::client::BSerializer_686143141, 686143141);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PFileData > ), de::elo::ix::client::BSerializer_1078168929, 1078168929);
	registerClass(typeid(de::elo::ix::client::FindActivityInfo), de::elo::ix::client::BSerializer_1456865464, 1456865464);
	registerClass(typeid(de::elo::ix::client::FindActivityProjectsInfo), de::elo::ix::client::BSerializer_151574948, 151574948);
	registerClass(typeid(de::elo::ix::client::FindAlertInfo), de::elo::ix::client::BSerializer_897433042, 897433042);
	registerClass(typeid(de::elo::ix::client::FindBackgroundThreadOptions), de::elo::ix::client::BSerializer_1054287589, 1054287589);
	registerClass(typeid(de::elo::ix::client::FindByAcl), de::elo::ix::client::BSerializer_1535514212, 1535514212);
	registerClass(typeid(de::elo::ix::client::FindByFulltext), de::elo::ix::client::BSerializer_829543678, 829543678);
	registerClass(typeid(de::elo::ix::client::FindByFulltextCtrl), de::elo::ix::client::BSerializer_96165507, 96165507);
	registerClass(typeid(de::elo::ix::client::FindByFulltextCtrlResultItem), de::elo::ix::client::BSerializer_1755682788, 1755682788);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PFindByFulltextCtrlResultItem > ), de::elo::ix::client::BSerializer_1980589728, 1980589728);
	registerClass(typeid(de::elo::ix::client::FindByFulltextResultItem), de::elo::ix::client::BSerializer_709720021, 709720021);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PFindByFulltextResultItem > ), de::elo::ix::client::BSerializer_804274709, 804274709);
	registerClass(typeid(de::elo::ix::client::FindByIndex), de::elo::ix::client::BSerializer_1985205034, 1985205034);
	registerClass(typeid(de::elo::ix::client::FindByNotes), de::elo::ix::client::BSerializer_735083434, 735083434);
	registerClass(typeid(de::elo::ix::client::FindByPreviewCtrl), de::elo::ix::client::BSerializer_78436038, 78436038);
	registerClass(typeid(de::elo::ix::client::FindByRegisteredFunction), de::elo::ix::client::BSerializer_700871698, 700871698);
	registerClass(typeid(de::elo::ix::client::FindBySordHist), de::elo::ix::client::BSerializer_2098788325, 2098788325);
	registerClass(typeid(de::elo::ix::client::FindByType), de::elo::ix::client::BSerializer_151307616, 151307616);
	registerClass(typeid(de::elo::ix::client::FindByVersion), de::elo::ix::client::BSerializer_925953882, 925953882);
	registerClass(typeid(de::elo::ix::client::FindChildren), de::elo::ix::client::BSerializer_752202075, 752202075);
	registerClass(typeid(de::elo::ix::client::FindConfigFileInfo), de::elo::ix::client::BSerializer_1887106523, 1887106523);
	registerClass(typeid(de::elo::ix::client::FindDirect), de::elo::ix::client::BSerializer_1028007046, 1028007046);
	registerClass(typeid(de::elo::ix::client::FindDirectC), de::elo::ix::client::BSerializer_627433249, 627433249);
	registerClass(typeid(de::elo::ix::client::FindInfo), de::elo::ix::client::BSerializer_1017838205, 1017838205);
	registerClass(typeid(de::elo::ix::client::FindInfoAsInternalSQL), de::elo::ix::client::BSerializer_2003160309, 2003160309);
	registerClass(typeid(de::elo::ix::client::FindLinks), de::elo::ix::client::BSerializer_832548178, 832548178);
	registerClass(typeid(de::elo::ix::client::FindOptions), de::elo::ix::client::BSerializer_1371440255, 1371440255);
	registerClass(typeid(de::elo::ix::client::FindReportInfo), de::elo::ix::client::BSerializer_504724737, 504724737);
	registerClass(typeid(de::elo::ix::client::FindResult), de::elo::ix::client::BSerializer_1301335819, 1301335819);
	registerClass(typeid(de::elo::ix::client::FindSubscriptionInfo), de::elo::ix::client::BSerializer_1419135016, 1419135016);
	registerClass(typeid(de::elo::ix::client::FindTasksInfo), de::elo::ix::client::BSerializer_1489194452, 1489194452);
	registerClass(typeid(de::elo::ix::client::FindTranslateTermInfo), de::elo::ix::client::BSerializer_986701599, 986701599);
	registerClass(typeid(de::elo::ix::client::FindUserInfo), de::elo::ix::client::BSerializer_1847547446, 1847547446);
	registerClass(typeid(de::elo::ix::client::FindWorkflowInfo), de::elo::ix::client::BSerializer_1768797010, 1768797010);
	registerClass(typeid(de::elo::ix::client::FontInfo), de::elo::ix::client::BSerializer_1478273890, 1478273890);
	registerClass(typeid(de::elo::ix::client::ForwardWorkflowNodeInfo), de::elo::ix::client::BSerializer_523867474, 523867474);
	registerClass(typeid(de::elo::ix::client::ForwardWorkflowNodeResult), de::elo::ix::client::BSerializer_1699606509, 1699606509);
	registerClass(typeid(de::elo::ix::client::FulltextConfig), de::elo::ix::client::BSerializer_239574905, 239574905);
	registerClass(typeid(de::elo::ix::client::FulltextConfigC), de::elo::ix::client::BSerializer_2025824562, 2025824562);
	registerClass(typeid(de::elo::ix::client::GetWebDAVPathOptions), de::elo::ix::client::BSerializer_1410517836, 1410517836);
	registerClass(typeid(de::elo::ix::client::GetWebDAVPathResult), de::elo::ix::client::BSerializer_148564345, 148564345);
	registerClass(typeid(de::elo::ix::client::HttpRequestInfo), de::elo::ix::client::BSerializer_1892343155, 1892343155);
	registerClass(typeid(de::elo::ix::client::HttpResponseInfo), de::elo::ix::client::BSerializer_1552189905, 1552189905);
	registerClass(typeid(de::elo::ix::client::IXExceptionC), de::elo::ix::client::BSerializer_1204588365, 1204588365);
	registerClass(typeid(de::elo::ix::client::IXExceptionData), de::elo::ix::client::BSerializer_784089396, 784089396);
	registerClass(typeid(de::elo::ix::client::IXServerEventsC), de::elo::ix::client::BSerializer_1963572851, 1963572851);
	registerClass(typeid(de::elo::ix::client::IXServerEventsContext), de::elo::ix::client::BSerializer_956691491, 956691491);
	registerClass(typeid(de::elo::ix::client::IXServicePortC), de::elo::ix::client::BSerializer_1264954948, 1264954948);
	registerClass(typeid(de::elo::ix::client::IdName), de::elo::ix::client::BSerializer_381683845, 381683845);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PIdName > ), de::elo::ix::client::BSerializer_755261279, 755261279);
	registerClass(typeid(de::elo::ix::client::ImportOptionsC), de::elo::ix::client::BSerializer_1908370444, 1908370444);
	registerClass(typeid(de::elo::ix::client::IndexServerForArchive), de::elo::ix::client::BSerializer_145656220, 145656220);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PIndexServerForArchive > ), de::elo::ix::client::BSerializer_1712744473, 1712744473);
	registerClass(typeid(de::elo::ix::client::InvalidateCacheC), de::elo::ix::client::BSerializer_320503229, 320503229);
	registerClass(typeid(de::elo::ix::client::InvalidateCacheInfo), de::elo::ix::client::BSerializer_1441686860, 1441686860);
	registerClass(typeid(de::elo::ix::client::InvalidateCacheInfoParam), de::elo::ix::client::BSerializer_102205772, 102205772);
	registerClass(typeid(de::elo::ix::client::InvalidateCacheResult), de::elo::ix::client::BSerializer_1712381166, 1712381166);
	registerClass(typeid(de::elo::ix::client::JobState), de::elo::ix::client::BSerializer_1436376940, 1436376940);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PJobState > ), de::elo::ix::client::BSerializer_1788243283, 1788243283);
	registerClass(typeid(de::elo::ix::client::KeyInfo), de::elo::ix::client::BSerializer_1537059480, 1537059480);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PKeyInfo > ), de::elo::ix::client::BSerializer_1112009864, 1112009864);
	registerClass(typeid(de::elo::ix::client::KeyValue), de::elo::ix::client::BSerializer_516301248, 516301248);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PKeyValue > ), de::elo::ix::client::BSerializer_1826370901, 1826370901);
	registerClass(typeid(de::elo::ix::client::Keyword), de::elo::ix::client::BSerializer_1426243550, 1426243550);
	registerClass(typeid(de::elo::ix::client::KeywordC), de::elo::ix::client::BSerializer_1338796818, 1338796818);
	registerClass(typeid(de::elo::ix::client::KeywordList), de::elo::ix::client::BSerializer_1495731174, 1495731174);
	registerClass(typeid(de::elo::ix::client::KeywordListC), de::elo::ix::client::BSerializer_1333073168, 1333073168);
	registerClass(typeid(de::elo::ix::client::KeywordZ), de::elo::ix::client::BSerializer_450335637, 450335637);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PKeyword > ), de::elo::ix::client::BSerializer_206201524, 206201524);
	registerClass(typeid(de::elo::ix::client::KeywordsDynamicInfo), de::elo::ix::client::BSerializer_2008405893, 2008405893);
	registerClass(typeid(de::elo::ix::client::KeywordsDynamicResult), de::elo::ix::client::BSerializer_1552114559, 1552114559);
	registerClass(typeid(de::elo::ix::client::License), de::elo::ix::client::BSerializer_1330120264, 1330120264);
	registerClass(typeid(de::elo::ix::client::LicenseInfo), de::elo::ix::client::BSerializer_2024296158, 2024296158);
	registerClass(typeid(de::elo::ix::client::LicenseResult), de::elo::ix::client::BSerializer_545905411, 545905411);
	registerClass(typeid(de::elo::ix::client::LinkSordC), de::elo::ix::client::BSerializer_4981037, 4981037);
	registerClass(typeid(de::elo::ix::client::LinkSordInfo), de::elo::ix::client::BSerializer_1427691295, 1427691295);
	registerClass(typeid(de::elo::ix::client::LinkSordZ), de::elo::ix::client::BSerializer_1473512051, 1473512051);
	registerClass(typeid(de::elo::ix::client::LockC), de::elo::ix::client::BSerializer_837669511, 837669511);
	registerClass(typeid(de::elo::ix::client::LockZ), de::elo::ix::client::BSerializer_1407753312, 1407753312);
	registerClass(typeid(de::elo::ix::client::LoginResult), de::elo::ix::client::BSerializer_777531606, 777531606);
	registerClass(typeid(de::elo::ix::client::LoginScriptOptions), de::elo::ix::client::BSerializer_1536364115, 1536364115);
	registerClass(typeid(de::elo::ix::client::LoginScriptOptionsC), de::elo::ix::client::BSerializer_1002222217, 1002222217);
	registerClass(typeid(de::elo::ix::client::MapData), de::elo::ix::client::BSerializer_2011132580, 2011132580);
	registerClass(typeid(de::elo::ix::client::MapDataC), de::elo::ix::client::BSerializer_1277095765, 1277095765);
	registerClass(typeid(de::elo::ix::client::MapDomain), de::elo::ix::client::BSerializer_42339713, 42339713);
	registerClass(typeid(de::elo::ix::client::MapDomainC), de::elo::ix::client::BSerializer_47433043, 47433043);
	registerClass(typeid(de::elo::ix::client::MapDomainDataC), de::elo::ix::client::BSerializer_915355095, 915355095);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PMapDomain > ), de::elo::ix::client::BSerializer_1963952629, 1963952629);
	registerClass(typeid(de::elo::ix::client::MapHead), de::elo::ix::client::BSerializer_1379783697, 1379783697);
	registerClass(typeid(de::elo::ix::client::MapHeadC), de::elo::ix::client::BSerializer_812078539, 812078539);
	registerClass(typeid(de::elo::ix::client::MapHist), de::elo::ix::client::BSerializer_303505086, 303505086);
	registerClass(typeid(de::elo::ix::client::MapHistC), de::elo::ix::client::BSerializer_379654790, 379654790);
	registerClass(typeid(de::elo::ix::client::MapHistHeadC), de::elo::ix::client::BSerializer_812099209, 812099209);
	registerClass(typeid(de::elo::ix::client::MapHistItem), de::elo::ix::client::BSerializer_342049067, 342049067);
	registerClass(typeid(de::elo::ix::client::MapHistItemC), de::elo::ix::client::BSerializer_1314989638, 1314989638);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PMapHistItem > ), de::elo::ix::client::BSerializer_240257308, 240257308);
	registerClass(typeid(de::elo::ix::client::MapHistZ), de::elo::ix::client::BSerializer_1505340976, 1505340976);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PMapHist > ), de::elo::ix::client::BSerializer_1756288553, 1756288553);
	registerClass(typeid(de::elo::ix::client::MapItem), de::elo::ix::client::BSerializer_1461301521, 1461301521);
	registerClass(typeid(de::elo::ix::client::MapItemC), de::elo::ix::client::BSerializer_812006040, 812006040);
	registerClass(typeid(de::elo::ix::client::MapValue), de::elo::ix::client::BSerializer_408347242, 408347242);
	registerClass(typeid(de::elo::ix::client::MaskName), de::elo::ix::client::BSerializer_458953805, 458953805);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PMaskName > ), de::elo::ix::client::BSerializer_248117584, 248117584);
	registerClass(typeid(de::elo::ix::client::MoveDocumentsInfo), de::elo::ix::client::BSerializer_2016315141, 2016315141);
	registerClass(typeid(de::elo::ix::client::NavigationInfo), de::elo::ix::client::BSerializer_1953181452, 1953181452);
	registerClass(typeid(de::elo::ix::client::NavigationInfoC), de::elo::ix::client::BSerializer_1520348158, 1520348158);
	registerClass(typeid(de::elo::ix::client::Note), de::elo::ix::client::BSerializer_937420667, 937420667);
	registerClass(typeid(de::elo::ix::client::NoteC), de::elo::ix::client::BSerializer_1319955249, 1319955249);
	registerClass(typeid(de::elo::ix::client::NoteDataC), de::elo::ix::client::BSerializer_1521483547, 1521483547);
	registerClass(typeid(de::elo::ix::client::NoteFreehand), de::elo::ix::client::BSerializer_611837980, 611837980);
	registerClass(typeid(de::elo::ix::client::NoteFreehandC), de::elo::ix::client::BSerializer_1034219603, 1034219603);
	registerClass(typeid(de::elo::ix::client::NoteImage), de::elo::ix::client::BSerializer_1753613701, 1753613701);
	registerClass(typeid(de::elo::ix::client::NoteTemplate), de::elo::ix::client::BSerializer_1995912373, 1995912373);
	registerClass(typeid(de::elo::ix::client::NoteTemplateC), de::elo::ix::client::BSerializer_240897408, 240897408);
	registerClass(typeid(de::elo::ix::client::NoteTemplateDataC), de::elo::ix::client::BSerializer_1775437403, 1775437403);
	registerClass(typeid(de::elo::ix::client::NoteTemplateZ), de::elo::ix::client::BSerializer_1483878971, 1483878971);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PNoteTemplate > ), de::elo::ix::client::BSerializer_1443841819, 1443841819);
	registerClass(typeid(de::elo::ix::client::NoteText), de::elo::ix::client::BSerializer_669464920, 669464920);
	registerClass(typeid(de::elo::ix::client::NoteZ), de::elo::ix::client::BSerializer_2137405429, 2137405429);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PNote > ), de::elo::ix::client::BSerializer_776454091, 776454091);
	registerClass(typeid(de::elo::ix::client::Notification), de::elo::ix::client::BSerializer_494610451, 494610451);
	registerClass(typeid(de::elo::ix::client::NotificationC), de::elo::ix::client::BSerializer_1070921523, 1070921523);
	registerClass(typeid(de::elo::ix::client::NotificationDataC), de::elo::ix::client::BSerializer_2010056196, 2010056196);
	registerClass(typeid(de::elo::ix::client::NotificationZ), de::elo::ix::client::BSerializer_1624160439, 1624160439);
	registerClass(typeid(de::elo::ix::client::NotifyServerInfo), de::elo::ix::client::BSerializer_539899885, 539899885);
	registerClass(typeid(de::elo::ix::client::NotifyServerResult), de::elo::ix::client::BSerializer_810727301, 810727301);
	registerClass(typeid(de::elo::ix::client::ObjChange), de::elo::ix::client::BSerializer_753146, 753146);
	registerClass(typeid(de::elo::ix::client::ObjChangeC), de::elo::ix::client::BSerializer_1100272528, 1100272528);
	registerClass(typeid(de::elo::ix::client::ObjDataC), de::elo::ix::client::BSerializer_1521332903, 1521332903);
	registerClass(typeid(de::elo::ix::client::ObjHistC), de::elo::ix::client::BSerializer_1015803641, 1015803641);
	registerClass(typeid(de::elo::ix::client::ObjHistKeyC), de::elo::ix::client::BSerializer_1013854536, 1013854536);
	registerClass(typeid(de::elo::ix::client::ObjKey), de::elo::ix::client::BSerializer_237417996, 237417996);
	registerClass(typeid(de::elo::ix::client::ObjKeyC), de::elo::ix::client::BSerializer_711473895, 711473895);
	registerClass(typeid(de::elo::ix::client::ObjKeyData), de::elo::ix::client::BSerializer_1508164560, 1508164560);
	registerClass(typeid(de::elo::ix::client::ObjKeyDataC), de::elo::ix::client::BSerializer_2463451, 2463451);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PObjKey > ), de::elo::ix::client::BSerializer_1628260993, 1628260993);
	registerClass(typeid(de::elo::ix::client::ObjLinkC), de::elo::ix::client::BSerializer_1015668161, 1015668161);
	registerClass(typeid(de::elo::ix::client::OcrInfo), de::elo::ix::client::BSerializer_1803060225, 1803060225);
	registerClass(typeid(de::elo::ix::client::OcrInfoC), de::elo::ix::client::BSerializer_1068350778, 1068350778);
	registerClass(typeid(de::elo::ix::client::OcrInfoQueryLanguages), de::elo::ix::client::BSerializer_648095775, 648095775);
	registerClass(typeid(de::elo::ix::client::OcrInfoRecognizeFile), de::elo::ix::client::BSerializer_701419851, 701419851);
	registerClass(typeid(de::elo::ix::client::OcrRect), de::elo::ix::client::BSerializer_1044855049, 1044855049);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::POcrRect > ), de::elo::ix::client::BSerializer_610838867, 610838867);
	registerClass(typeid(de::elo::ix::client::OcrResult), de::elo::ix::client::BSerializer_998509414, 998509414);
	registerClass(typeid(de::elo::ix::client::OcrResultQueryLanguages), de::elo::ix::client::BSerializer_916614291, 916614291);
	registerClass(typeid(de::elo::ix::client::OcrResultRecognizeFile), de::elo::ix::client::BSerializer_1533562699, 1533562699);
	registerClass(typeid(de::elo::ix::client::OcrWorker), de::elo::ix::client::BSerializer_730157667, 730157667);
	registerClass(typeid(de::elo::ix::client::OcrWorkerC), de::elo::ix::client::BSerializer_45899817, 45899817);
	registerClass(typeid(de::elo::ix::client::OrgUnitInfo), de::elo::ix::client::BSerializer_413918850, 413918850);
	registerClass(typeid(de::elo::ix::client::OrgUnitInfoC), de::elo::ix::client::BSerializer_864257789, 864257789);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::POrgUnitInfo > ), de::elo::ix::client::BSerializer_1879760993, 1879760993);
	registerClass(typeid(de::elo::ix::client::OrgUnitName), de::elo::ix::client::BSerializer_427676481, 427676481);
	registerClass(typeid(de::elo::ix::client::PhysDel), de::elo::ix::client::BSerializer_124345500, 124345500);
	registerClass(typeid(de::elo::ix::client::PhysDelC), de::elo::ix::client::BSerializer_278631137, 278631137);
	registerClass(typeid(de::elo::ix::client::PhysDelDataC), de::elo::ix::client::BSerializer_448931954, 448931954);
	registerClass(typeid(de::elo::ix::client::PhysDelDocs), de::elo::ix::client::BSerializer_855528761, 855528761);
	registerClass(typeid(de::elo::ix::client::PhysDelDocsC), de::elo::ix::client::BSerializer_434896477, 434896477);
	registerClass(typeid(de::elo::ix::client::PointInfo), de::elo::ix::client::BSerializer_1225068828, 1225068828);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PPointInfo > ), de::elo::ix::client::BSerializer_1853594537, 1853594537);
	registerClass(typeid(de::elo::ix::client::PreviewImageInfo), de::elo::ix::client::BSerializer_1006046685, 1006046685);
	registerClass(typeid(de::elo::ix::client::PreviewImageInfoC), de::elo::ix::client::BSerializer_407268655, 407268655);
	registerClass(typeid(de::elo::ix::client::PreviewImageResult), de::elo::ix::client::BSerializer_661820173, 661820173);
	registerClass(typeid(de::elo::ix::client::ProcessAcl), de::elo::ix::client::BSerializer_402225782, 402225782);
	registerClass(typeid(de::elo::ix::client::ProcessCopyElements), de::elo::ix::client::BSerializer_147051188, 147051188);
	registerClass(typeid(de::elo::ix::client::ProcessCountElements), de::elo::ix::client::BSerializer_1130489422, 1130489422);
	registerClass(typeid(de::elo::ix::client::ProcessFulltext), de::elo::ix::client::BSerializer_1125907212, 1125907212);
	registerClass(typeid(de::elo::ix::client::ProcessInfo), de::elo::ix::client::BSerializer_1037318967, 1037318967);
	registerClass(typeid(de::elo::ix::client::ProcessInfoC), de::elo::ix::client::BSerializer_659513392, 659513392);
	registerClass(typeid(de::elo::ix::client::ProcessInheritKeywording), de::elo::ix::client::BSerializer_1130489423, 1130489423);
	registerClass(typeid(de::elo::ix::client::ProcessMoveDocumentsToStoragePath), de::elo::ix::client::BSerializer_3376635, 3376635);
	registerClass(typeid(de::elo::ix::client::ProcessReleaseLock), de::elo::ix::client::BSerializer_1270934212, 1270934212);
	registerClass(typeid(de::elo::ix::client::ProcessReplSet), de::elo::ix::client::BSerializer_712209598, 712209598);
	registerClass(typeid(de::elo::ix::client::ProcessScript), de::elo::ix::client::BSerializer_1122555546, 1122555546);
	registerClass(typeid(de::elo::ix::client::PublicDownload), de::elo::ix::client::BSerializer_2062827124, 2062827124);
	registerClass(typeid(de::elo::ix::client::PublicDownloadC), de::elo::ix::client::BSerializer_1919187163, 1919187163);
	registerClass(typeid(de::elo::ix::client::PublicDownloadDataC), de::elo::ix::client::BSerializer_1639180602, 1639180602);
	registerClass(typeid(de::elo::ix::client::PublicDownloadOptions), de::elo::ix::client::BSerializer_252853324, 252853324);
	registerClass(typeid(de::elo::ix::client::PurgeSettings), de::elo::ix::client::BSerializer_1576340510, 1576340510);
	registerClass(typeid(de::elo::ix::client::PurgeSettingsC), de::elo::ix::client::BSerializer_1865968564, 1865968564);
	registerClass(typeid(de::elo::ix::client::PurgeStatus), de::elo::ix::client::BSerializer_2053888643, 2053888643);
	registerClass(typeid(de::elo::ix::client::QueryJobProtocolC), de::elo::ix::client::BSerializer_1764906979, 1764906979);
	registerClass(typeid(de::elo::ix::client::QueryJobProtocolEvent), de::elo::ix::client::BSerializer_892520690, 892520690);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PQueryJobProtocolEvent > ), de::elo::ix::client::BSerializer_1465721064, 1465721064);
	registerClass(typeid(de::elo::ix::client::QueryJobProtocolInfo), de::elo::ix::client::BSerializer_1362638222, 1362638222);
	registerClass(typeid(de::elo::ix::client::QueryJobProtocolResult), de::elo::ix::client::BSerializer_222450704, 222450704);
	registerClass(typeid(de::elo::ix::client::Relation), de::elo::ix::client::BSerializer_837810375, 837810375);
	registerClass(typeid(de::elo::ix::client::RelationC), de::elo::ix::client::BSerializer_1203469035, 1203469035);
	registerClass(typeid(de::elo::ix::client::Reminder), de::elo::ix::client::BSerializer_256674679, 256674679);
	registerClass(typeid(de::elo::ix::client::ReminderC), de::elo::ix::client::BSerializer_1431555044, 1431555044);
	registerClass(typeid(de::elo::ix::client::ReminderDataC), de::elo::ix::client::BSerializer_1099169893, 1099169893);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PReminder > ), de::elo::ix::client::BSerializer_1701141707, 1701141707);
	registerClass(typeid(de::elo::ix::client::ReplCode), de::elo::ix::client::BSerializer_1235558040, 1235558040);
	registerClass(typeid(de::elo::ix::client::ReplSet), de::elo::ix::client::BSerializer_1124529321, 1124529321);
	registerClass(typeid(de::elo::ix::client::ReplSetCombination), de::elo::ix::client::BSerializer_2078338937, 2078338937);
	registerClass(typeid(de::elo::ix::client::ReplSetCombinationC), de::elo::ix::client::BSerializer_897151349, 897151349);
	registerClass(typeid(de::elo::ix::client::ReplSetName), de::elo::ix::client::BSerializer_755067340, 755067340);
	registerClass(typeid(de::elo::ix::client::ReplSetNameC), de::elo::ix::client::BSerializer_969246601, 969246601);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PReplSetName > ), de::elo::ix::client::BSerializer_884364631, 884364631);
	registerClass(typeid(de::elo::ix::client::RepliHist), de::elo::ix::client::BSerializer_899503054, 899503054);
	registerClass(typeid(de::elo::ix::client::RepliHistC), de::elo::ix::client::BSerializer_104551413, 104551413);
	registerClass(typeid(de::elo::ix::client::ReportC), de::elo::ix::client::BSerializer_1285453013, 1285453013);
	registerClass(typeid(de::elo::ix::client::ReportErpCode), de::elo::ix::client::BSerializer_508806040, 508806040);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PReportErpCode > ), de::elo::ix::client::BSerializer_1004870809, 1004870809);
	registerClass(typeid(de::elo::ix::client::ReportInfo), de::elo::ix::client::BSerializer_1280848136, 1280848136);
	registerClass(typeid(de::elo::ix::client::ReportInfoC), de::elo::ix::client::BSerializer_1071192839, 1071192839);
	registerClass(typeid(de::elo::ix::client::ReportInfoUserModified), de::elo::ix::client::BSerializer_1649121955, 1649121955);
	registerClass(typeid(de::elo::ix::client::ReportInfoUserProps), de::elo::ix::client::BSerializer_2088129978, 2088129978);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PReportInfo > ), de::elo::ix::client::BSerializer_1243223397, 1243223397);
	registerClass(typeid(de::elo::ix::client::ReportModeC), de::elo::ix::client::BSerializer_1594659914, 1594659914);
	registerClass(typeid(de::elo::ix::client::ReportModeZ), de::elo::ix::client::BSerializer_1248158950, 1248158950);
	registerClass(typeid(de::elo::ix::client::ReportOptions), de::elo::ix::client::BSerializer_1057373949, 1057373949);
	registerClass(typeid(de::elo::ix::client::ReportOptionsC), de::elo::ix::client::BSerializer_2081332891, 2081332891);
	registerClass(typeid(de::elo::ix::client::ResolveRightsInfo), de::elo::ix::client::BSerializer_1631708942, 1631708942);
	registerClass(typeid(de::elo::ix::client::ResolveRightsResult), de::elo::ix::client::BSerializer_973279163, 973279163);
	registerClass(typeid(de::elo::ix::client::ResolveRightsResultC), de::elo::ix::client::BSerializer_1322441656, 1322441656);
	registerClass(typeid(de::elo::ix::client::RestoreOptions), de::elo::ix::client::BSerializer_378110234, 378110234);
	registerClass(typeid(de::elo::ix::client::SearchModeC), de::elo::ix::client::BSerializer_1758444419, 1758444419);
	registerClass(typeid(de::elo::ix::client::SearchModeZ), de::elo::ix::client::BSerializer_424689505, 424689505);
	registerClass(typeid(de::elo::ix::client::SearchTermsC), de::elo::ix::client::BSerializer_334358315, 334358315);
	registerClass(typeid(de::elo::ix::client::ServerInfo), de::elo::ix::client::BSerializer_1701204890, 1701204890);
	registerClass(typeid(de::elo::ix::client::ServerInfoDM), de::elo::ix::client::BSerializer_1425760760, 1425760760);
	registerClass(typeid(de::elo::ix::client::ServerInfoDMC), de::elo::ix::client::BSerializer_287365821, 287365821);
	registerClass(typeid(de::elo::ix::client::ServerState), de::elo::ix::client::BSerializer_1076606418, 1076606418);
	registerClass(typeid(de::elo::ix::client::ServerStateC), de::elo::ix::client::BSerializer_1862501863, 1862501863);
	registerClass(typeid(de::elo::ix::client::SessionInfo), de::elo::ix::client::BSerializer_866689803, 866689803);
	registerClass(typeid(de::elo::ix::client::SessionInfoParams), de::elo::ix::client::BSerializer_2013576169, 2013576169);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PSessionInfo > ), de::elo::ix::client::BSerializer_1376733713, 1376733713);
	registerClass(typeid(de::elo::ix::client::SessionOptions), de::elo::ix::client::BSerializer_1197100286, 1197100286);
	registerClass(typeid(de::elo::ix::client::SessionOptionsC), de::elo::ix::client::BSerializer_2000345779, 2000345779);
	registerClass(typeid(de::elo::ix::client::Sord), de::elo::ix::client::BSerializer_1576327931, 1576327931);
	registerClass(typeid(de::elo::ix::client::SordC), de::elo::ix::client::BSerializer_1553100003, 1553100003);
	registerClass(typeid(de::elo::ix::client::SordDetails), de::elo::ix::client::BSerializer_1713693326, 1713693326);
	registerClass(typeid(de::elo::ix::client::SordHist), de::elo::ix::client::BSerializer_2121567102, 2121567102);
	registerClass(typeid(de::elo::ix::client::SordHistC), de::elo::ix::client::BSerializer_520610723, 520610723);
	registerClass(typeid(de::elo::ix::client::SordHistKey), de::elo::ix::client::BSerializer_251810638, 251810638);
	registerClass(typeid(de::elo::ix::client::SordHistKeyC), de::elo::ix::client::BSerializer_762601968, 762601968);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PSordHistKey > ), de::elo::ix::client::BSerializer_645430982, 645430982);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PSordHist > ), de::elo::ix::client::BSerializer_491352407, 491352407);
	registerClass(typeid(de::elo::ix::client::SordLink), de::elo::ix::client::BSerializer_200815802, 200815802);
	registerClass(typeid(de::elo::ix::client::SordLinkC), de::elo::ix::client::BSerializer_1347988541, 1347988541);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PSordLink > ), de::elo::ix::client::BSerializer_376993407, 376993407);
	registerClass(typeid(de::elo::ix::client::SordPath), de::elo::ix::client::BSerializer_544862901, 544862901);
	registerClass(typeid(de::elo::ix::client::SordPaths), de::elo::ix::client::BSerializer_1835331414, 1835331414);
	registerClass(typeid(de::elo::ix::client::SordType), de::elo::ix::client::BSerializer_2065094749, 2065094749);
	registerClass(typeid(de::elo::ix::client::SordTypeC), de::elo::ix::client::BSerializer_635922924, 635922924);
	registerClass(typeid(de::elo::ix::client::SordTypeZ), de::elo::ix::client::BSerializer_314474107, 314474107);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PSordType > ), de::elo::ix::client::BSerializer_133130047, 133130047);
	registerClass(typeid(de::elo::ix::client::SordZ), de::elo::ix::client::BSerializer_1441094282, 1441094282);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PSordZ > ), de::elo::ix::client::BSerializer_1559053609, 1559053609);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PSord > ), de::elo::ix::client::BSerializer_919539303, 919539303);
	registerClass(typeid(de::elo::ix::client::SortOrderC), de::elo::ix::client::BSerializer_1551556842, 1551556842);
	registerClass(typeid(de::elo::ix::client::StartAdHocWorkflowInfo), de::elo::ix::client::BSerializer_1587514612, 1587514612);
	registerClass(typeid(de::elo::ix::client::StoreInfo), de::elo::ix::client::BSerializer_964052256, 964052256);
	registerClass(typeid(de::elo::ix::client::StoreInfoC), de::elo::ix::client::BSerializer_979653235, 979653235);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PStoreInfo > ), de::elo::ix::client::BSerializer_231031238, 231031238);
	registerClass(typeid(de::elo::ix::client::SubsInfo), de::elo::ix::client::BSerializer_1910142939, 1910142939);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PSubsInfo > ), de::elo::ix::client::BSerializer_105830886, 105830886);
	registerClass(typeid(de::elo::ix::client::Subscription), de::elo::ix::client::BSerializer_323351719, 323351719);
	registerClass(typeid(de::elo::ix::client::SubscriptionC), de::elo::ix::client::BSerializer_1994646365, 1994646365);
	registerClass(typeid(de::elo::ix::client::SubscriptionDataC), de::elo::ix::client::BSerializer_1152087606, 1152087606);
	registerClass(typeid(de::elo::ix::client::SubscriptionZ), de::elo::ix::client::BSerializer_1493215896, 1493215896);
	registerClass(typeid(de::elo::ix::client::Thesaurus), de::elo::ix::client::BSerializer_1664944753, 1664944753);
	registerClass(typeid(de::elo::ix::client::ThesaurusC), de::elo::ix::client::BSerializer_670698541, 670698541);
	registerClass(typeid(de::elo::ix::client::TranslateTerm), de::elo::ix::client::BSerializer_356302605, 356302605);
	registerClass(typeid(de::elo::ix::client::TranslateTermC), de::elo::ix::client::BSerializer_1212336284, 1212336284);
	registerClass(typeid(de::elo::ix::client::TranslateTermData), de::elo::ix::client::BSerializer_486835904, 486835904);
	registerClass(typeid(de::elo::ix::client::TranslateTermDataC), de::elo::ix::client::BSerializer_1699470707, 1699470707);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PTranslateTerm > ), de::elo::ix::client::BSerializer_1088095067, 1088095067);
	registerClass(typeid(de::elo::ix::client::UrlParams), de::elo::ix::client::BSerializer_2007960901, 2007960901);
	registerClass(typeid(de::elo::ix::client::UserInfo), de::elo::ix::client::BSerializer_1485735592, 1485735592);
	registerClass(typeid(de::elo::ix::client::UserInfoC), de::elo::ix::client::BSerializer_703234555, 703234555);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PUserInfo > ), de::elo::ix::client::BSerializer_1132956238, 1132956238);
	registerClass(typeid(de::elo::ix::client::UserName), de::elo::ix::client::BSerializer_123879203, 123879203);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PUserName > ), de::elo::ix::client::BSerializer_1001617329, 1001617329);
	registerClass(typeid(de::elo::ix::client::UserNodeInfo), de::elo::ix::client::BSerializer_2059835971, 2059835971);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PUserNodeInfo > ), de::elo::ix::client::BSerializer_1772247724, 1772247724);
	registerClass(typeid(de::elo::ix::client::UserProfile), de::elo::ix::client::BSerializer_1401065069, 1401065069);
	registerClass(typeid(de::elo::ix::client::UserProfileC), de::elo::ix::client::BSerializer_1968434410, 1968434410);
	registerClass(typeid(de::elo::ix::client::UserProfileData), de::elo::ix::client::BSerializer_2015395180, 2015395180);
	registerClass(typeid(de::elo::ix::client::UserProfileDataC), de::elo::ix::client::BSerializer_466121473, 466121473);
	registerClass(typeid(de::elo::ix::client::UserTask), de::elo::ix::client::BSerializer_1484696239, 1484696239);
	registerClass(typeid(de::elo::ix::client::UserTaskPriorityC), de::elo::ix::client::BSerializer_260320342, 260320342);
	registerClass(typeid(de::elo::ix::client::UserTaskSortOrderC), de::elo::ix::client::BSerializer_854117900, 854117900);
	registerClass(typeid(de::elo::ix::client::UserTaskSortOrderZ), de::elo::ix::client::BSerializer_1199296467, 1199296467);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PUserTask > ), de::elo::ix::client::BSerializer_829657911, 829657911);
	registerClass(typeid(de::elo::ix::client::ValueClass), de::elo::ix::client::BSerializer_175726414, 175726414);
	registerClass(typeid(de::elo::ix::client::ValuesOfObjKey), de::elo::ix::client::BSerializer_1153931872, 1153931872);
	registerClass(typeid(de::elo::ix::client::ValuesOfObjKeyOptions), de::elo::ix::client::BSerializer_958310068, 958310068);
	registerClass(typeid(de::elo::ix::client::VtDoc), de::elo::ix::client::BSerializer_1935852595, 1935852595);
	registerClass(typeid(de::elo::ix::client::VtDocC), de::elo::ix::client::BSerializer_1585149555, 1585149555);
	registerClass(typeid(de::elo::ix::client::WFCollectNode), de::elo::ix::client::BSerializer_1492908819, 1492908819);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PWFCollectNode > ), de::elo::ix::client::BSerializer_2006133032, 2006133032);
	registerClass(typeid(de::elo::ix::client::WFDelegateNodeInfo), de::elo::ix::client::BSerializer_20892334, 20892334);
	registerClass(typeid(de::elo::ix::client::WFDiagram), de::elo::ix::client::BSerializer_1663767661, 1663767661);
	registerClass(typeid(de::elo::ix::client::WFDiagramC), de::elo::ix::client::BSerializer_1231341428, 1231341428);
	registerClass(typeid(de::elo::ix::client::WFDiagramZ), de::elo::ix::client::BSerializer_1717407429, 1717407429);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PWFDiagram > ), de::elo::ix::client::BSerializer_838894319, 838894319);
	registerClass(typeid(de::elo::ix::client::WFEditNode), de::elo::ix::client::BSerializer_1822579866, 1822579866);
	registerClass(typeid(de::elo::ix::client::WFNode), de::elo::ix::client::BSerializer_2015686193, 2015686193);
	registerClass(typeid(de::elo::ix::client::WFNodeAssoc), de::elo::ix::client::BSerializer_1042649178, 1042649178);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PWFNodeAssoc > ), de::elo::ix::client::BSerializer_715244239, 715244239);
	registerClass(typeid(de::elo::ix::client::WFNodeC), de::elo::ix::client::BSerializer_1514069164, 1514069164);
	registerClass(typeid(de::elo::ix::client::WFNodeHistory), de::elo::ix::client::BSerializer_784568809, 784568809);
	registerClass(typeid(de::elo::ix::client::WFNodeHistoryC), de::elo::ix::client::BSerializer_1457412372, 1457412372);
	registerClass(typeid(de::elo::ix::client::WFNodeMatrix), de::elo::ix::client::BSerializer_425879495, 425879495);
	registerClass(typeid(de::elo::ix::client::WFNodeMatrixC), de::elo::ix::client::BSerializer_171864975, 171864975);
	registerClass(typeid(de::elo::ix::client::WFNodeZ), de::elo::ix::client::BSerializer_226200225, 226200225);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PWFNode > ), de::elo::ix::client::BSerializer_1457843286, 1457843286);
	registerClass(typeid(de::elo::ix::client::WFTakeNodeC), de::elo::ix::client::BSerializer_1164251184, 1164251184);
	registerClass(typeid(de::elo::ix::client::WFTimeLimit), de::elo::ix::client::BSerializer_633363356, 633363356);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PWFTimeLimit > ), de::elo::ix::client::BSerializer_1495941578, 1495941578);
	registerClass(typeid(de::elo::ix::client::WFTypeC), de::elo::ix::client::BSerializer_1842783874, 1842783874);
	registerClass(typeid(de::elo::ix::client::WFTypeZ), de::elo::ix::client::BSerializer_927083544, 927083544);
	registerClass(typeid(de::elo::ix::client::WFVersion), de::elo::ix::client::BSerializer_914434915, 914434915);
	registerClass(typeid(de::elo::ix::client::WFVersionC), de::elo::ix::client::BSerializer_1378592156, 1378592156);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::PWFVersion > ), de::elo::ix::client::BSerializer_1768472140, 1768472140);
	registerClass(typeid(de::elo::ix::client::WorkFlowActiveDoc), de::elo::ix::client::BSerializer_1807635378, 1807635378);
	registerClass(typeid(de::elo::ix::client::WorkFlowActiveDocC), de::elo::ix::client::BSerializer_509854692, 509854692);
	registerClass(typeid(de::elo::ix::client::WorkFlowHead), de::elo::ix::client::BSerializer_37271022, 37271022);
	registerClass(typeid(de::elo::ix::client::WorkFlowHeadC), de::elo::ix::client::BSerializer_807993720, 807993720);
	registerClass(typeid(de::elo::ix::client::WorkFlowNodeMatrix), de::elo::ix::client::BSerializer_1337377725, 1337377725);
	registerClass(typeid(de::elo::ix::client::WorkFlowNodeMatrixC), de::elo::ix::client::BSerializer_813423307, 813423307);
	registerClass(typeid(de::elo::ix::client::WorkflowExchangeInfo), de::elo::ix::client::BSerializer_2070549585, 2070549585);
	registerClass(typeid(de::elo::ix::client::WorkflowExportOptions), de::elo::ix::client::BSerializer_402835780, 402835780);
	registerClass(typeid(de::elo::ix::client::WorkflowExportOptionsC), de::elo::ix::client::BSerializer_1063132081, 1063132081);
	registerClass(typeid(de::elo::ix::client::WorkflowImportOptions), de::elo::ix::client::BSerializer_449037977, 449037977);
	registerClass(typeid(de::elo::ix::client::WorkflowNodeInfo), de::elo::ix::client::BSerializer_1659862348, 1659862348);
	registerClass(typeid(de::elo::ix::client::compatibility::BRequest_RawStreamService_download), de::elo::ix::client::BSerializer_280725475, 280725475);
	registerClass(typeid(de::elo::ix::client::compatibility::BRequest_RawStreamService_upload), de::elo::ix::client::BSerializer_527524138, 527524138);
	registerClass(typeid(de::elo::ix::client::compatibility::BRequest_WClientService_onAfterVersionChanged), de::elo::ix::client::BSerializer_2095806986, 2095806986);
	registerClass(typeid(de::elo::ix::client::compatibility::BStub_RawStreamService), de::elo::ix::client::BSerializer_354585327, 354585327);
	registerClass(typeid(de::elo::ix::client::compatibility::BStub_WClientService), de::elo::ix::client::BSerializer_1887299447, 1887299447);
	registerClass(typeid(de::elo::ix::client::compatibility::WClientC), de::elo::ix::client::BSerializer_1800529481, 1800529481);
	registerClass(typeid(de::elo::ix::client::feed::Action), de::elo::ix::client::BSerializer_736351635, 736351635);
	registerClass(typeid(de::elo::ix::client::feed::ActionC), de::elo::ix::client::BSerializer_1988394652, 1988394652);
	registerClass(typeid(de::elo::ix::client::feed::ActionDataC), de::elo::ix::client::BSerializer_423487901, 423487901);
	registerClass(typeid(de::elo::ix::client::feed::ActionHistDataC), de::elo::ix::client::BSerializer_734763371, 734763371);
	registerClass(typeid(de::elo::ix::client::feed::ActionHistory), de::elo::ix::client::BSerializer_598833764, 598833764);
	registerClass(typeid(de::elo::ix::client::feed::ActionHistoryC), de::elo::ix::client::BSerializer_442981425, 442981425);
	registerClass(typeid(de::elo::ix::client::feed::ActionZ), de::elo::ix::client::BSerializer_1006784044, 1006784044);
	registerClass(typeid(::byps::BArray1< de::elo::ix::client::feed::PAction > ), de::elo::ix::client::BSerializer_433625553, 433625553);
	registerClass(typeid(de::elo::ix::client::feed::BRequest_FeedNotification_updateAction), de::elo::ix::client::BSerializer_688797212, 688797212);
	registerClass(typeid(de::elo::ix::client::feed::BRequest_FeedService_checkinAction), de::elo::ix::client::BSerializer_1138765790, 1138765790);
	registerClass(typeid(de::elo::ix::client::feed::BRequest_FeedService_checkoutAction), de::elo::ix::client::BSerializer_1737190301, 1737190301);
	registerClass(typeid(de::elo::ix::client::feed::BRequest_FeedService_checkoutHashTag), de::elo::ix::client::BSerializer_122354907, 122354907);
	registerClass(typeid(de::elo::ix::client::feed::BRequest_FeedService_createAction), de::elo::ix::client::BSerializer_643943187, 643943187);
	registerClass(typeid(de::elo::ix::client::feed::BRequest_FeedService_createHashTagSubscription), de::elo::ix::client::BSerializer_1471082196, 1471082196);
	registerClass(typeid(de::elo::ix::client::feed::BRequest_FeedService_findFirstActions), de::elo::ix::client::BSerializer_334710983, 334710983);
	registerClass(typeid(de::elo::ix::client::feed::BRequest_FeedService_findFirstHashTagRelation), de::elo::ix::client::BSerializer_2144547950, 2144547950);
	registerClass(typeid(de::elo::ix::client::feed::BRequest_FeedService_findFirstNotification), de::elo::ix::client::BSerializer_906090337, 906090337);
	registerClass(typeid(de::elo::ix::client::feed::BRequest_FeedService_findHashTagByActions), de::elo::ix::client::BSerializer_421489164, 421489164);
	registerClass(typeid(de::elo::ix::client::feed::BRequest_FeedService_findHashTags), de::elo::ix::client::BSerializer_66310175, 66310175);
	registerClass(typeid(de::elo::ix::client::feed::BRequest_FeedService_findNextActions), de::elo::ix::client::BSerializer_933597872, 933597872);
	registerClass(typeid(de::elo::ix::client::feed::BRequest_FeedService_findNextHashTagRelation), de::elo::ix::client::BSerializer_1204755579, 1204755579);
	registerClass(typeid(de::elo::ix::client::feed::BRequest_FeedService_findNextNotification), de::elo::ix::client::BSerializer_1326557416, 1326557416);
	registerClass(typeid(de::elo::ix::client::feed::BRequest_FeedService_internalInsertSystemAction), de::elo::ix::client::BSerializer_1637137212, 1637137212);
	registerClass(typeid(de::elo::ix::client::feed::BRequest_FeedService_registerNotify), de::elo::ix::client::BSerializer_458959949, 458959949);
	registerClass(typeid(de::elo::ix::client::feed::BRequest_FeedService_unregisterNotify), de::elo::ix::client::BSerializer_285270298, 285270298);
	registerClass(typeid(de::elo::ix::client::feed::BStub_FeedNotification), de::elo::ix::client::BSerializer_320199695, 320199695);
	registerClass(typeid(de::elo::ix::client::feed::BStub_FeedService), de::elo::ix::client::BSerializer_1670701039, 1670701039);
	registerClass(typeid(de::elo::ix::client::feed::Feed), de::elo::ix::client::BSerializer_556531185, 556531185);
	registerClass(typeid(de::elo::ix::client::feed::FeedC), de::elo::ix::client::BSerializer_1754071588, 1754071588);
	registerClass(typeid(de::elo::ix::client::feed::FeedDataC), de::elo::ix::client::BSerializer_1837685365, 1837685365);
	registerClass(typeid(de::elo::ix::client::feed::FeedZ), de::elo::ix::client::BSerializer_126672288, 126672288);
	registerClass(typeid(de::elo::ix::client::feed::FindActionsInfo), de::elo::ix::client::BSerializer_1747180074, 1747180074);
	registerClass(typeid(de::elo::ix::client::feed::FindActionsInfoC), de::elo::ix::client::BSerializer_815857210, 815857210);
	registerClass(typeid(de::elo::ix::client::feed::FindHashTagInfo), de::elo::ix::client::BSerializer_256103952, 256103952);
	registerClass(typeid(de::elo::ix::client::feed::FindNotificationInfo), de::elo::ix::client::BSerializer_432579435, 432579435);
	registerClass(typeid(de::elo::ix::client::feed::HashTag), de::elo::ix::client::BSerializer_1143177929, 1143177929);
	registerClass(typeid(de::elo::ix::client::feed::HashTagC), de::elo::ix::client::BSerializer_250741620, 250741620);
	registerClass(typeid(de::elo::ix::client::feed::HashTagDataC), de::elo::ix::client::BSerializer_513648569, 513648569);
	registerClass(typeid(de::elo::ix::client::feed::HashTagRelation), de::elo::ix::client::BSerializer_1313473584, 1313473584);
	registerClass(typeid(de::elo::ix::client::feed::HashTagRelationC), de::elo::ix::client::BSerializer_747134350, 747134350);
	registerClass(typeid(de::elo::ix::client::feed::HashTagRelationDataC), de::elo::ix::client::BSerializer_2035445347, 2035445347);
	registerClass(typeid(de::elo::ix::client::feed::HashTagRelationZ), de::elo::ix::client::BSerializer_509234307, 509234307);
	registerClass(typeid(de::elo::ix::client::feed::HashTagZ), de::elo::ix::client::BSerializer_1664941037, 1664941037);
	registerClass(typeid(de::elo::ix::client::health::BRequest_HealthCheckService_computeDoubleValue), de::elo::ix::client::BSerializer_1919177848, 1919177848);
	registerClass(typeid(de::elo::ix::client::health::BRequest_HealthCheckService_read), de::elo::ix::client::BSerializer_771256331, 771256331);
	registerClass(typeid(de::elo::ix::client::health::BRequest_HealthCheckService_update), de::elo::ix::client::BSerializer_1948144488, 1948144488);
	registerClass(typeid(de::elo::ix::client::health::BRequest_HealthCheckService_updateAll), de::elo::ix::client::BSerializer_720562919, 720562919);
	registerClass(typeid(de::elo::ix::client::health::BRequest_HealthCheckService_updateDoubleValue), de::elo::ix::client::BSerializer_677413784, 677413784);
	registerClass(typeid(de::elo::ix::client::health::BRequest_HealthCheckService_updateMeanValue), de::elo::ix::client::BSerializer_1150533084, 1150533084);
	registerClass(typeid(de::elo::ix::client::health::BRequest_HealthCheckService_uploadAll), de::elo::ix::client::BSerializer_1827236639, 1827236639);
	registerClass(typeid(de::elo::ix::client::health::BStub_HealthCheckService), de::elo::ix::client::BSerializer_969424915, 969424915);
	registerClass(typeid(de::elo::ix::client::health::HealthCheckInfo), de::elo::ix::client::BSerializer_585951890, 585951890);
	registerClass(typeid(de::elo::ix::client::health::HealthCheckInfoC), de::elo::ix::client::BSerializer_526645641, 526645641);
	registerClass(typeid(de::elo::ix::client::health::HealthCheckInfos), de::elo::ix::client::BSerializer_333475674, 333475674);
	registerClass(typeid(de::elo::ix::client::health::HealthCheckValueNameC), de::elo::ix::client::BSerializer_2106201675, 2106201675);
	registerClass(typeid(de::elo::ix::client::myelo::BRequest_MyELOService_checkState), de::elo::ix::client::BSerializer_2068722874, 2068722874);
	registerClass(typeid(de::elo::ix::client::myelo::BRequest_MyELOService_readContent), de::elo::ix::client::BSerializer_261913914, 261913914);
	registerClass(typeid(de::elo::ix::client::myelo::BStub_MyELOService), de::elo::ix::client::BSerializer_1063633807, 1063633807);
	registerClass(typeid(de::elo::ix::client::myelo::MyELOContent), de::elo::ix::client::BSerializer_1585309177, 1585309177);
	registerClass(typeid(de::elo::ix::client::myelo::MyELOInfo), de::elo::ix::client::BSerializer_455864090, 455864090);
	registerClass(typeid(de::elo::ix::client::myelo::MyELOState), de::elo::ix::client::BSerializer_1426941339, 1426941339);
	registerClass(typeid(de::elo::ix::client::notify::BRequest_ClientNotification_adminMode), de::elo::ix::client::BSerializer_475567923, 475567923);
	registerClass(typeid(de::elo::ix::client::notify::BRequest_ClientNotification_updateTask), de::elo::ix::client::BSerializer_1469990419, 1469990419);
	registerClass(typeid(de::elo::ix::client::notify::BStub_ClientNotification), de::elo::ix::client::BSerializer_2104055021, 2104055021);
	registerClass(typeid(de::elo::ix::client::search::LanguageConfig), de::elo::ix::client::BSerializer_2005992013, 2005992013);
	registerClass(typeid(de::elo::ix::client::search::OptimizerConfig), de::elo::ix::client::BSerializer_645566676, 645566676);
	registerClass(typeid(de::elo::ix::client::search::ReindexerConfig), de::elo::ix::client::BSerializer_1470978622, 1470978622);
	registerClass(typeid(de::elo::ix::client::search::SearchIndexerConfig), de::elo::ix::client::BSerializer_1425319615, 1425319615);
	registerClass(typeid(de::elo::ix::client::search::UpdaterConfig), de::elo::ix::client::BSerializer_1275243126, 1275243126);
	registerClass(typeid(de::elo::ix::client::system::ArchivReport), de::elo::ix::client::BSerializer_1383534582, 1383534582);
	registerClass(typeid(de::elo::ix::client::system::ArchivValue), de::elo::ix::client::BSerializer_1695870218, 1695870218);
	registerClass(typeid(de::elo::ix::client::system::BRequest_SystemInformation_archivReport), de::elo::ix::client::BSerializer_1995041693, 1995041693);
	registerClass(typeid(de::elo::ix::client::system::BRequest_SystemInformation_countDocsInStorePath), de::elo::ix::client::BSerializer_1786633213, 1786633213);
	registerClass(typeid(de::elo::ix::client::system::BRequest_SystemInformation_licenseReport), de::elo::ix::client::BSerializer_821360905, 821360905);
	registerClass(typeid(de::elo::ix::client::system::BRequest_SystemInformation_userReport), de::elo::ix::client::BSerializer_2081672491, 2081672491);
	registerClass(typeid(de::elo::ix::client::system::BStub_SystemInformation), de::elo::ix::client::BSerializer_708455930, 708455930);
	registerClass(typeid(de::elo::ix::client::system::LicenseCounter), de::elo::ix::client::BSerializer_189487184, 189487184);
	registerClass(typeid(de::elo::ix::client::system::LicenseReport), de::elo::ix::client::BSerializer_1320348587, 1320348587);
	registerClass(typeid(de::elo::ix::client::system::SystemInfo), de::elo::ix::client::BSerializer_2061316528, 2061316528);
	registerClass(typeid(de::elo::ix::client::system::SystemReport), de::elo::ix::client::BSerializer_276702696, 276702696);
	registerClass(typeid(de::elo::ix::client::system::UserReport), de::elo::ix::client::BSerializer_18214274, 18214274);
	registerClass(typeid(::byps::BArray1< int32_t > ), de::elo::ix::client::BSerializer_100361105, 100361105);
	registerClass(typeid(::byps::BArray1< ::std::wstring > ), de::elo::ix::client::BSerializer_1888107655, 1888107655);
	registerClass(typeid(::std::vector< de::elo::ix::client::PWFDiagram >), de::elo::ix::client::BSerializer_2063419988, 2063419988);
	registerClass(typeid(::std::vector< de::elo::ix::client::PWFNodeHistory >), de::elo::ix::client::BSerializer_1549980077, 1549980077);
	registerClass(typeid(::std::map< int32_t , int32_t >), de::elo::ix::client::BSerializer_1434022628, 1434022628);
	registerClass(typeid(::std::map< ::std::wstring , de::elo::ix::client::feed::PHashTag >), de::elo::ix::client::BSerializer_1556767716, 1556767716);
	registerClass(typeid(::std::set< de::elo::ix::client::feed::PHashTag >), de::elo::ix::client::BSerializer_1535847981, 1535847981);
	registerClass(typeid(::std::vector< de::elo::ix::client::PInvalidateCacheInfoParam >), de::elo::ix::client::BSerializer_189813709, 189813709);
	registerClass(typeid(::std::vector< de::elo::ix::client::PNote >), de::elo::ix::client::BSerializer_2111020589, 2111020589);
	registerClass(typeid(::std::vector< de::elo::ix::client::PPublicDownload >), de::elo::ix::client::BSerializer_881442092, 881442092);
	registerClass(typeid(::std::vector< de::elo::ix::client::PResolveRightsResult >), de::elo::ix::client::BSerializer_907729609, 907729609);
	registerClass(typeid(::std::vector< de::elo::ix::client::PSord >), de::elo::ix::client::BSerializer_2106404937, 2106404937);
	registerClass(typeid(::std::vector< de::elo::ix::client::PSordPath >), de::elo::ix::client::BSerializer_1773247378, 1773247378);
	registerClass(typeid(::std::vector< de::elo::ix::client::PSubsInfo >), de::elo::ix::client::BSerializer_1546602844, 1546602844);
	registerClass(typeid(::std::vector< de::elo::ix::client::PValueClass >), de::elo::ix::client::BSerializer_1241863010, 1241863010);
	registerClass(typeid(::std::vector< de::elo::ix::client::feed::PActionHistory >), de::elo::ix::client::BSerializer_1399835671, 1399835671);
	registerClass(typeid(::std::vector< de::elo::ix::client::feed::EActionType >), de::elo::ix::client::BSerializer_1644858720, 1644858720);
	registerClass(typeid(::std::vector< de::elo::ix::client::feed::PHashTagRelation >), de::elo::ix::client::BSerializer_1403472717, 1403472717);
	registerClass(typeid(::std::vector< de::elo::ix::client::health::PHealthCheckInfo >), de::elo::ix::client::BSerializer_1270538819, 1270538819);
	registerClass(typeid(::std::vector< de::elo::ix::client::system::PArchivValue >), de::elo::ix::client::BSerializer_164573046, 164573046);
	registerClass(typeid(::std::vector< de::elo::ix::client::system::PLicenseCounter >), de::elo::ix::client::BSerializer_2005491011, 2005491011);
	registerClass(typeid(::std::vector< int32_t >), de::elo::ix::client::BSerializer_181681714, 181681714);
	registerClass(typeid(::std::vector< ::std::wstring >), de::elo::ix::client::BSerializer_2123584667, 2123584667);
	registerClass(typeid(::std::vector< byps::PVectorString >), de::elo::ix::client::BSerializer_1489667803, 1489667803);
	registerClass(typeid(::std::vector< byps::PMapStringString >), de::elo::ix::client::BSerializer_1319324274, 1319324274);
	registerClass(typeid(::std::map< int32_t , de::elo::ix::client::POrgUnitInfo >), de::elo::ix::client::BSerializer_893011331, 893011331);
	registerClass(typeid(::std::map< int32_t , de::elo::ix::client::PUserInfo >), de::elo::ix::client::BSerializer_1870226832, 1870226832);
	registerClass(typeid(::std::map< int32_t , de::elo::ix::client::PUserName >), de::elo::ix::client::BSerializer_1874463571, 1874463571);
	registerClass(typeid(::std::map< int32_t , de::elo::ix::client::PWFDiagram >), de::elo::ix::client::BSerializer_1085717935, 1085717935);
	registerClass(typeid(::std::map< int32_t , int32_t >), de::elo::ix::client::BSerializer_1347703734, 1347703734);
	registerClass(typeid(::std::map< int32_t , ::std::wstring >), de::elo::ix::client::BSerializer_498630295, 498630295);
	registerClass(typeid(::std::map< int32_t , de::elo::ix::client::PVectorWFDiagram >), de::elo::ix::client::BSerializer_1741591604, 1741591604);
	registerClass(typeid(::std::map< int32_t , de::elo::ix::client::PVectorWFNodeHistory >), de::elo::ix::client::BSerializer_689498285, 689498285);
	registerClass(typeid(::std::map< ::std::wstring , de::elo::ix::client::PMapValue >), de::elo::ix::client::BSerializer_1129834343, 1129834343);
	registerClass(typeid(::std::map< ::std::wstring , de::elo::ix::client::PNotification >), de::elo::ix::client::BSerializer_1147263971, 1147263971);
	registerClass(typeid(::std::map< ::std::wstring , de::elo::ix::client::PSubscription >), de::elo::ix::client::BSerializer_1862275569, 1862275569);
	registerClass(typeid(::std::map< ::std::wstring , de::elo::ix::client::feed::PFeed >), de::elo::ix::client::BSerializer_425536672, 425536672);
	registerClass(typeid(::std::map< ::std::wstring , de::elo::ix::client::feed::PHashTag >), de::elo::ix::client::BSerializer_1239602222, 1239602222);
	registerClass(typeid(::std::map< ::std::wstring , ::std::wstring >), de::elo::ix::client::BSerializer_1710660846, 1710660846);
}
