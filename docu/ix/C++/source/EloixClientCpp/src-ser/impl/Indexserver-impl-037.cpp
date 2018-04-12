#include "Indexserver-impl.h"
using namespace ::std;
using namespace ::byps;

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::checkinKeywords(const PArrayKeyword& kws, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	checkinKeywords(kws, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::checkinKeywords(const PArrayKeyword& kws, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinKeywords(kws, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayInt BStub_IXServicePortIF::checkinNotes(const ::std::wstring& objId, const PArrayNote& notes, const PNoteZ& noteZ, const PLockZ& unlockZ)  {
	BSyncResultT< PArrayInt > syncResult;	
	checkinNotes(objId, notes, noteZ, unlockZ, [&syncResult](PArrayInt v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinNotes(const ::std::wstring& objId, const PArrayNote& notes, const PNoteZ& noteZ, const PLockZ& unlockZ, ::std::function< void (PArrayInt, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinNotes(objId, notes, noteZ, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayInt, BResult_100361105 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PNotification BStub_IXServicePortIF::checkinNotification(const PNotification& notif, const PNotificationZ& notiZ)  {
	BSyncResultT< PNotification > syncResult;	
	checkinNotification(notif, notiZ, [&syncResult](PNotification v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinNotification(const PNotification& notif, const PNotificationZ& notiZ, ::std::function< void (PNotification, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinNotification(notif, notiZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PNotification, BResult_494610451 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayInt BStub_IXServicePortIF::checkinReminder(const PReminder& remi, const PArrayString& receiverIds, bool expandGroups, const PLockZ& unlockZ)  {
	BSyncResultT< PArrayInt > syncResult;	
	checkinReminder(remi, receiverIds, expandGroups, unlockZ, [&syncResult](PArrayInt v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinReminder(const PReminder& remi, const PArrayString& receiverIds, bool expandGroups, const PLockZ& unlockZ, ::std::function< void (PArrayInt, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinReminder(remi, receiverIds, expandGroups, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayInt, BResult_100361105 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::checkinReplNames(const PArrayReplSetName& replNames, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	checkinReplNames(replNames, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::checkinReplNames(const PArrayReplSetName& replNames, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinReplNames(replNames, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::checkinReportOptions(const PReportOptions& options, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	checkinReportOptions(options, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::checkinReportOptions(const PReportOptions& options, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinReportOptions(options, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
int32_t BStub_IXServicePortIF::checkinSord(const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ)  {
	BSyncResultT< int32_t > syncResult;	
	checkinSord(sord, sordZ, unlockZ, [&syncResult](int32_t v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinSord(const PSord& sord, const PSordZ& sordZ, const PLockZ& unlockZ, ::std::function< void (int32_t, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinSord(sord, sordZ, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< int32_t, BResult_5 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayInt BStub_IXServicePortIF::checkinSordPath(const ::std::wstring& parentId, const PArraySord& sords, const PSordZ& sordZ)  {
	BSyncResultT< PArrayInt > syncResult;	
	checkinSordPath(parentId, sords, sordZ, [&syncResult](PArrayInt v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinSordPath(const ::std::wstring& parentId, const PArraySord& sords, const PSordZ& sordZ, ::std::function< void (PArrayInt, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinSordPath(parentId, sords, sordZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayInt, BResult_100361105 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::checkinSordTypes(const PArraySordType& sordTypes, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	checkinSordTypes(sordTypes, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::checkinSordTypes(const PArraySordType& sordTypes, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinSordTypes(sordTypes, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayStoreInfo BStub_IXServicePortIF::checkinStorage(const PArrayStoreInfo& storeInfos, const PLockZ& unlockZ)  {
	BSyncResultT< PArrayStoreInfo > syncResult;	
	checkinStorage(storeInfos, unlockZ, [&syncResult](PArrayStoreInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinStorage(const PArrayStoreInfo& storeInfos, const PLockZ& unlockZ, ::std::function< void (PArrayStoreInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinStorage(storeInfos, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayStoreInfo, BResult_231031238 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::checkinSubs(const PArraySubsInfo& deps, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	checkinSubs(deps, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::checkinSubs(const PArraySubsInfo& deps, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinSubs(deps, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::checkinUserProfile(const PUserProfile& userProfile, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	checkinUserProfile(userProfile, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::checkinUserProfile(const PUserProfile& userProfile, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinUserProfile(userProfile, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayInt BStub_IXServicePortIF::checkinUsers(const PArrayUserInfo& userInfos, const PCheckinUsersZ& checkinUsersZ, const PLockZ& unlockZ)  {
	BSyncResultT< PArrayInt > syncResult;	
	checkinUsers(userInfos, checkinUsersZ, unlockZ, [&syncResult](PArrayInt v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinUsers(const PArrayUserInfo& userInfos, const PCheckinUsersZ& checkinUsersZ, const PLockZ& unlockZ, ::std::function< void (PArrayInt, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinUsers(userInfos, checkinUsersZ, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayInt, BResult_100361105 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PMapIntegerOrgUnitInfo BStub_IXServicePortIF::checkinOrgUnits(const PArrayOrgUnitInfo& orgUnitInfos, const PCheckinOrgUnitInfo& reserved, const PLockZ& unlockZ)  {
	BSyncResultT< PMapIntegerOrgUnitInfo > syncResult;	
	checkinOrgUnits(orgUnitInfos, reserved, unlockZ, [&syncResult](PMapIntegerOrgUnitInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinOrgUnits(const PArrayOrgUnitInfo& orgUnitInfos, const PCheckinOrgUnitInfo& reserved, const PLockZ& unlockZ, ::std::function< void (PMapIntegerOrgUnitInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinOrgUnits(orgUnitInfos, reserved, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PMapIntegerOrgUnitInfo, BResult_893011331 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteOrgUnits(const PArrayString& ids, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteOrgUnits(ids, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteOrgUnits(const PArrayString& ids, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteOrgUnits(ids, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PMapIntegerOrgUnitInfo BStub_IXServicePortIF::checkoutOrgUnits(const PCheckoutOrgUnitInfo& reserved, const PLockZ& lockZ)  {
	BSyncResultT< PMapIntegerOrgUnitInfo > syncResult;	
	checkoutOrgUnits(reserved, lockZ, [&syncResult](PMapIntegerOrgUnitInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutOrgUnits(const PCheckoutOrgUnitInfo& reserved, const PLockZ& lockZ, ::std::function< void (PMapIntegerOrgUnitInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutOrgUnits(reserved, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PMapIntegerOrgUnitInfo, BResult_893011331 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
int32_t BStub_IXServicePortIF::checkinWorkFlow(const PWFDiagram& wf, const PWFDiagramZ& workFlowDiagramZ, const PLockZ& unlockZ)  {
	BSyncResultT< int32_t > syncResult;	
	checkinWorkFlow(wf, workFlowDiagramZ, unlockZ, [&syncResult](int32_t v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkinWorkFlow(const PWFDiagram& wf, const PWFDiagramZ& workFlowDiagramZ, const PLockZ& unlockZ, ::std::function< void (int32_t, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkinWorkFlow(wf, workFlowDiagramZ, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< int32_t, BResult_5 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayColorData BStub_IXServicePortIF::checkoutColors(const PLockZ& lockZ)  {
	BSyncResultT< PArrayColorData > syncResult;	
	checkoutColors(lockZ, [&syncResult](PArrayColorData v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutColors(const PLockZ& lockZ, ::std::function< void (PArrayColorData, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutColors(lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayColorData, BResult_1870182600 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayConfigFile BStub_IXServicePortIF::checkoutConfigFiles(const PArrayString& names, const PConfigFileZ& configFileZ, const PLockZ& lockZ)  {
	BSyncResultT< PArrayConfigFile > syncResult;	
	checkoutConfigFiles(names, configFileZ, lockZ, [&syncResult](PArrayConfigFile v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutConfigFiles(const PArrayString& names, const PConfigFileZ& configFileZ, const PLockZ& lockZ, ::std::function< void (PArrayConfigFile, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutConfigFiles(names, configFileZ, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayConfigFile, BResult_1737266313 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayCounterInfo BStub_IXServicePortIF::checkoutCounters(const PArrayString& counterNames, bool incrementCounters, const PLockZ& lockZ)  {
	BSyncResultT< PArrayCounterInfo > syncResult;	
	checkoutCounters(counterNames, incrementCounters, lockZ, [&syncResult](PArrayCounterInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutCounters(const PArrayString& counterNames, bool incrementCounters, const PLockZ& lockZ, ::std::function< void (PArrayCounterInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutCounters(counterNames, incrementCounters, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayCounterInfo, BResult_1698110251 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PEditInfo BStub_IXServicePortIF::checkoutDoc(const ::std::wstring& objId, const ::std::wstring& docId, const PEditInfoZ& editInfoZ, const PLockZ& lockZ)  {
	BSyncResultT< PEditInfo > syncResult;	
	checkoutDoc(objId, docId, editInfoZ, lockZ, [&syncResult](PEditInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutDoc(const ::std::wstring& objId, const ::std::wstring& docId, const PEditInfoZ& editInfoZ, const PLockZ& lockZ, ::std::function< void (PEditInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutDoc(objId, docId, editInfoZ, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PEditInfo, BResult_820228328 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PDocMask BStub_IXServicePortIF::checkoutDocMask(const ::std::wstring& maskId, const PDocMaskZ& docMaskZ, const PLockZ& lockZ)  {
	BSyncResultT< PDocMask > syncResult;	
	checkoutDocMask(maskId, docMaskZ, lockZ, [&syncResult](PDocMask v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutDocMask(const ::std::wstring& maskId, const PDocMaskZ& docMaskZ, const PLockZ& lockZ, ::std::function< void (PDocMask, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutDocMask(maskId, docMaskZ, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PDocMask, BResult_2054753789 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayKeyInfo BStub_IXServicePortIF::checkoutKeys(const PArrayString& ids, const PLockZ& lockZ)  {
	BSyncResultT< PArrayKeyInfo > syncResult;	
	checkoutKeys(ids, lockZ, [&syncResult](PArrayKeyInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutKeys(const PArrayString& ids, const PLockZ& lockZ, ::std::function< void (PArrayKeyInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutKeys(ids, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayKeyInfo, BResult_1112009864 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayKeyword BStub_IXServicePortIF::checkoutKeywords(const PArrayString& kwids, const PKeywordZ& keywordZ, int32_t max, const PLockZ& lockZ)  {
	BSyncResultT< PArrayKeyword > syncResult;	
	checkoutKeywords(kwids, keywordZ, max, lockZ, [&syncResult](PArrayKeyword v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutKeywords(const PArrayString& kwids, const PKeywordZ& keywordZ, int32_t max, const PLockZ& lockZ, ::std::function< void (PArrayKeyword, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutKeywords(kwids, keywordZ, max, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayKeyword, BResult_206201524 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayNote BStub_IXServicePortIF::checkoutNotes(const ::std::wstring& objId, const PArrayString& noteIds, const PNoteZ& noteZ, const PLockZ& lockZ)  {
	BSyncResultT< PArrayNote > syncResult;	
	checkoutNotes(objId, noteIds, noteZ, lockZ, [&syncResult](PArrayNote v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutNotes(const ::std::wstring& objId, const PArrayString& noteIds, const PNoteZ& noteZ, const PLockZ& lockZ, ::std::function< void (PArrayNote, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutNotes(objId, noteIds, noteZ, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayNote, BResult_776454091 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PNotification BStub_IXServicePortIF::checkoutNotification(const ::std::wstring& watchGuid, const ::std::wstring& userGuid)  {
	BSyncResultT< PNotification > syncResult;	
	checkoutNotification(watchGuid, userGuid, [&syncResult](PNotification v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutNotification(const ::std::wstring& watchGuid, const ::std::wstring& userGuid, ::std::function< void (PNotification, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutNotification(watchGuid, userGuid));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PNotification, BResult_494610451 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayReminder BStub_IXServicePortIF::checkoutReminders(const PArrayInt& reminderIds, const PLockZ& lockZ)  {
	BSyncResultT< PArrayReminder > syncResult;	
	checkoutReminders(reminderIds, lockZ, [&syncResult](PArrayReminder v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutReminders(const PArrayInt& reminderIds, const PLockZ& lockZ, ::std::function< void (PArrayReminder, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutReminders(reminderIds, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayReminder, BResult_1701141707 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayReplSetName BStub_IXServicePortIF::checkoutReplNames(const PLockZ& lockZ)  {
	BSyncResultT< PArrayReplSetName > syncResult;	
	checkoutReplNames(lockZ, [&syncResult](PArrayReplSetName v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutReplNames(const PLockZ& lockZ, ::std::function< void (PArrayReplSetName, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutReplNames(lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayReplSetName, BResult_884364631 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PReportOptions BStub_IXServicePortIF::checkoutReportOptions(const PLockZ& lockZ)  {
	BSyncResultT< PReportOptions > syncResult;	
	checkoutReportOptions(lockZ, [&syncResult](PReportOptions v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutReportOptions(const PLockZ& lockZ, ::std::function< void (PReportOptions, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutReportOptions(lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PReportOptions, BResult_1057373949 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PEditInfo BStub_IXServicePortIF::checkoutSord(const ::std::wstring& objId, const PEditInfoZ& editInfoZ, const PLockZ& lockZ)  {
	BSyncResultT< PEditInfo > syncResult;	
	checkoutSord(objId, editInfoZ, lockZ, [&syncResult](PEditInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutSord(const ::std::wstring& objId, const PEditInfoZ& editInfoZ, const PLockZ& lockZ, ::std::function< void (PEditInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutSord(objId, editInfoZ, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PEditInfo, BResult_820228328 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArraySordHist BStub_IXServicePortIF::checkoutSordHistory(const ::std::wstring& objId)  {
	BSyncResultT< PArraySordHist > syncResult;	
	checkoutSordHistory(objId, [&syncResult](PArraySordHist v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutSordHistory(const ::std::wstring& objId, ::std::function< void (PArraySordHist, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutSordHistory(objId));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArraySordHist, BResult_491352407 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArraySordType BStub_IXServicePortIF::checkoutSordTypes(const PArrayInt& sordTypeIds, const PSordTypeZ& sordTypeZ, const PLockZ& lockZ)  {
	BSyncResultT< PArraySordType > syncResult;	
	checkoutSordTypes(sordTypeIds, sordTypeZ, lockZ, [&syncResult](PArraySordType v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutSordTypes(const PArrayInt& sordTypeIds, const PSordTypeZ& sordTypeZ, const PLockZ& lockZ, ::std::function< void (PArraySordType, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutSordTypes(sordTypeIds, sordTypeZ, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArraySordType, BResult_133130047 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayStoreInfo BStub_IXServicePortIF::checkoutStorage(const PArrayString& ids, const PLockZ& lockZ)  {
	BSyncResultT< PArrayStoreInfo > syncResult;	
	checkoutStorage(ids, lockZ, [&syncResult](PArrayStoreInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutStorage(const PArrayString& ids, const PLockZ& lockZ, ::std::function< void (PArrayStoreInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutStorage(ids, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayStoreInfo, BResult_231031238 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArraySubsInfo BStub_IXServicePortIF::checkoutSubs(const ::std::wstring& userId, const PLockZ& lockZ)  {
	BSyncResultT< PArraySubsInfo > syncResult;	
	checkoutSubs(userId, lockZ, [&syncResult](PArraySubsInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutSubs(const ::std::wstring& userId, const PLockZ& lockZ, ::std::function< void (PArraySubsInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutSubs(userId, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArraySubsInfo, BResult_105830886 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PUserProfile BStub_IXServicePortIF::checkoutUserProfile(const PUserProfile& userProfile, const PLockZ& lockZ)  {
	BSyncResultT< PUserProfile > syncResult;	
	checkoutUserProfile(userProfile, lockZ, [&syncResult](PUserProfile v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutUserProfile(const PUserProfile& userProfile, const PLockZ& lockZ, ::std::function< void (PUserProfile, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutUserProfile(userProfile, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PUserProfile, BResult_1401065069 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayUserInfo BStub_IXServicePortIF::checkoutUsers(const PArrayString& ids, const PCheckoutUsersZ& checkoutUsersZ, const PLockZ& lockZ)  {
	BSyncResultT< PArrayUserInfo > syncResult;	
	checkoutUsers(ids, checkoutUsersZ, lockZ, [&syncResult](PArrayUserInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutUsers(const PArrayString& ids, const PCheckoutUsersZ& checkoutUsersZ, const PLockZ& lockZ, ::std::function< void (PArrayUserInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutUsers(ids, checkoutUsersZ, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayUserInfo, BResult_1132956238 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PWFDiagram BStub_IXServicePortIF::checkoutWorkFlow(const ::std::wstring& flowId, const PWFTypeZ& typeZ, const PWFDiagramZ& workFlowDiagramZ, const PLockZ& lockZ)  {
	BSyncResultT< PWFDiagram > syncResult;	
	checkoutWorkFlow(flowId, typeZ, workFlowDiagramZ, lockZ, [&syncResult](PWFDiagram v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::checkoutWorkFlow(const ::std::wstring& flowId, const PWFTypeZ& typeZ, const PWFDiagramZ& workFlowDiagramZ, const PLockZ& lockZ, ::std::function< void (PWFDiagram, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_checkoutWorkFlow(flowId, typeZ, workFlowDiagramZ, lockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PWFDiagram, BResult_1663767661 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
bool BStub_IXServicePortIF::cleanupStart(const PDeleteOptions& deleteOptions)  {
	BSyncResultT< bool > syncResult;	
	cleanupStart(deleteOptions, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::cleanupStart(const PDeleteOptions& deleteOptions, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_cleanupStart(deleteOptions));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_1 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PJobState BStub_IXServicePortIF::cleanupState()  {
	BSyncResultT< PJobState > syncResult;	
	cleanupState([&syncResult](PJobState v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::cleanupState(::std::function< void (PJobState, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_cleanupState());
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PJobState, BResult_1436376940 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
bool BStub_IXServicePortIF::cleanupStop()  {
	BSyncResultT< bool > syncResult;	
	cleanupStop([&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::cleanupStop(::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_cleanupStop());
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_1 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayJobState BStub_IXServicePortIF::collectJobStates(bool activeJobs, bool finishedJobs, bool fullInfo)  {
	BSyncResultT< PArrayJobState > syncResult;	
	collectJobStates(activeJobs, finishedJobs, fullInfo, [&syncResult](PArrayJobState v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::collectJobStates(bool activeJobs, bool finishedJobs, bool fullInfo, ::std::function< void (PArrayJobState, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_collectJobStates(activeJobs, finishedJobs, fullInfo));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayJobState, BResult_1788243283 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayWFCollectNode BStub_IXServicePortIF::collectWorkFlowNodes(const ::std::wstring& flowName, const PWFTypeZ& wfTypeZ, const ::std::wstring& nodeName, int32_t nodeType, const ::std::wstring& objId, const ::std::wstring& enterDateIso, const ::std::wstring& exitDateIso, const PArrayString& userIds, bool onlyActive, bool onlyStartNodes)  {
	BSyncResultT< PArrayWFCollectNode > syncResult;	
	collectWorkFlowNodes(flowName, wfTypeZ, nodeName, nodeType, objId, enterDateIso, exitDateIso, userIds, onlyActive, onlyStartNodes, [&syncResult](PArrayWFCollectNode v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::collectWorkFlowNodes(const ::std::wstring& flowName, const PWFTypeZ& wfTypeZ, const ::std::wstring& nodeName, int32_t nodeType, const ::std::wstring& objId, const ::std::wstring& enterDateIso, const ::std::wstring& exitDateIso, const PArrayString& userIds, bool onlyActive, bool onlyStartNodes, ::std::function< void (PArrayWFCollectNode, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_collectWorkFlowNodes(flowName, wfTypeZ, nodeName, nodeType, objId, enterDateIso, exitDateIso, userIds, onlyActive, onlyStartNodes));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayWFCollectNode, BResult_2006133032 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PArrayIdName BStub_IXServicePortIF::collectWorkFlows(const PWFTypeZ& typeZ)  {
	BSyncResultT< PArrayIdName > syncResult;	
	collectWorkFlows(typeZ, [&syncResult](PArrayIdName v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::collectWorkFlows(const PWFTypeZ& typeZ, ::std::function< void (PArrayIdName, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_collectWorkFlows(typeZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PArrayIdName, BResult_755261279 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findFirstWorkflows(const PFindWorkflowInfo& findInfo, int32_t max, const PWFDiagramZ& wfDiagramZ)  {
	BSyncResultT< PFindResult > syncResult;	
	findFirstWorkflows(findInfo, max, wfDiagramZ, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findFirstWorkflows(const PFindWorkflowInfo& findInfo, int32_t max, const PWFDiagramZ& wfDiagramZ, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findFirstWorkflows(findInfo, max, wfDiagramZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PFindResult BStub_IXServicePortIF::findNextWorkflows(const ::std::wstring& searchId, int32_t index, int32_t maxResults)  {
	BSyncResultT< PFindResult > syncResult;	
	findNextWorkflows(searchId, index, maxResults, [&syncResult](PFindResult v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::findNextWorkflows(const ::std::wstring& searchId, int32_t index, int32_t maxResults, ::std::function< void (PFindResult, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_findNextWorkflows(searchId, index, maxResults));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PFindResult, BResult_1301335819 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
::std::wstring BStub_IXServicePortIF::cookKeyword(const ::std::wstring& kwid)  {
	BSyncResultT< ::std::wstring > syncResult;	
	cookKeyword(kwid, [&syncResult](::std::wstring v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::cookKeyword(const ::std::wstring& kwid, ::std::function< void (::std::wstring, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_cookKeyword(kwid));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< ::std::wstring, BResult_10 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
int32_t BStub_IXServicePortIF::copySord(const ::std::wstring& newParentId, const ::std::wstring& objId, const PCopyInfo& copyInfo, const PCopySordZ& copySordZ)  {
	BSyncResultT< int32_t > syncResult;	
	copySord(newParentId, objId, copyInfo, copySordZ, [&syncResult](int32_t v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::copySord(const ::std::wstring& newParentId, const ::std::wstring& objId, const PCopyInfo& copyInfo, const PCopySordZ& copySordZ, ::std::function< void (int32_t, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_copySord(newParentId, objId, copyInfo, copySordZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< int32_t, BResult_5 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PEditInfo BStub_IXServicePortIF::createDoc(const ::std::wstring& parentId, const ::std::wstring& maskId, const ::std::wstring& docTemplate, const PEditInfoZ& editInfoZ)  {
	BSyncResultT< PEditInfo > syncResult;	
	createDoc(parentId, maskId, docTemplate, editInfoZ, [&syncResult](PEditInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::createDoc(const ::std::wstring& parentId, const ::std::wstring& maskId, const ::std::wstring& docTemplate, const PEditInfoZ& editInfoZ, ::std::function< void (PEditInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_createDoc(parentId, maskId, docTemplate, editInfoZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PEditInfo, BResult_820228328 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PDocMask BStub_IXServicePortIF::createDocMask(const ::std::wstring& maskId)  {
	BSyncResultT< PDocMask > syncResult;	
	createDocMask(maskId, [&syncResult](PDocMask v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::createDocMask(const ::std::wstring& maskId, ::std::function< void (PDocMask, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_createDocMask(maskId));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PDocMask, BResult_2054753789 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PKeyInfo BStub_IXServicePortIF::createKey()  {
	BSyncResultT< PKeyInfo > syncResult;	
	createKey([&syncResult](PKeyInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::createKey(::std::function< void (PKeyInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_createKey());
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PKeyInfo, BResult_1537059480 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PNote BStub_IXServicePortIF::createNote(const ::std::wstring& objId)  {
	BSyncResultT< PNote > syncResult;	
	createNote(objId, [&syncResult](PNote v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::createNote(const ::std::wstring& objId, ::std::function< void (PNote, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_createNote(objId));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PNote, BResult_937420667 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PNote BStub_IXServicePortIF::createNote2(const ::std::wstring& objId, int32_t noteType, const ::std::wstring& templId)  {
	BSyncResultT< PNote > syncResult;	
	createNote2(objId, noteType, templId, [&syncResult](PNote v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::createNote2(const ::std::wstring& objId, int32_t noteType, const ::std::wstring& templId, ::std::function< void (PNote, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_createNote2(objId, noteType, templId));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PNote, BResult_937420667 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PReminder BStub_IXServicePortIF::createReminder(const ::std::wstring& objId)  {
	BSyncResultT< PReminder > syncResult;	
	createReminder(objId, [&syncResult](PReminder v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::createReminder(const ::std::wstring& objId, ::std::function< void (PReminder, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_createReminder(objId));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PReminder, BResult_256674679 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PEditInfo BStub_IXServicePortIF::createSord(const ::std::wstring& parentId, const ::std::wstring& maskId, const PEditInfoZ& editInfoZ)  {
	BSyncResultT< PEditInfo > syncResult;	
	createSord(parentId, maskId, editInfoZ, [&syncResult](PEditInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::createSord(const ::std::wstring& parentId, const ::std::wstring& maskId, const PEditInfoZ& editInfoZ, ::std::function< void (PEditInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_createSord(parentId, maskId, editInfoZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PEditInfo, BResult_820228328 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PUserInfo BStub_IXServicePortIF::createUser(const ::std::wstring& rightsAsUserId)  {
	BSyncResultT< PUserInfo > syncResult;	
	createUser(rightsAsUserId, [&syncResult](PUserInfo v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::createUser(const ::std::wstring& rightsAsUserId, ::std::function< void (PUserInfo, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_createUser(rightsAsUserId));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PUserInfo, BResult_1485735592 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PWFNode BStub_IXServicePortIF::createWFNode(int32_t nodeId, int32_t nodeTypeC)  {
	BSyncResultT< PWFNode > syncResult;	
	createWFNode(nodeId, nodeTypeC, [&syncResult](PWFNode v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::createWFNode(int32_t nodeId, int32_t nodeTypeC, ::std::function< void (PWFNode, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_createWFNode(nodeId, nodeTypeC));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PWFNode, BResult_2015686193 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
PWFDiagram BStub_IXServicePortIF::createWorkFlow(const ::std::wstring& wfName, const PWFTypeZ& typeZ)  {
	BSyncResultT< PWFDiagram > syncResult;	
	createWorkFlow(wfName, typeZ, [&syncResult](PWFDiagram v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::createWorkFlow(const ::std::wstring& wfName, const PWFTypeZ& typeZ, ::std::function< void (PWFDiagram, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_createWorkFlow(wfName, typeZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< PWFDiagram, BResult_1663767661 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteConfigFiles(const PArrayString& names, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteConfigFiles(names, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteConfigFiles(const PArrayString& names, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteConfigFiles(names, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteCounters(const PArrayString& counterNames, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteCounters(counterNames, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteCounters(const PArrayString& counterNames, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteCounters(counterNames, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
bool BStub_IXServicePortIF::deleteDocMask(const ::std::wstring& maskId, const ::std::wstring& assignMaskId, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteDocMask(maskId, assignMaskId, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	return syncResult.getResult();
}
void BStub_IXServicePortIF::deleteDocMask(const ::std::wstring& maskId, const ::std::wstring& assignMaskId, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteDocMask(maskId, assignMaskId, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_1 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteKeys(const PArrayString& ids, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteKeys(ids, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteKeys(const PArrayString& ids, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteKeys(ids, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

namespace de { namespace elo { namespace ix { namespace client { 
void BStub_IXServicePortIF::deleteKeywords(const PArrayString& kwids, const PLockZ& unlockZ)  {
	BSyncResultT< bool > syncResult;	
	deleteKeywords(kwids, unlockZ, [&syncResult](bool v, BException ex) {
		syncResult.setAsyncResult(v, ex);
	});
	syncResult.getResult();
}
void BStub_IXServicePortIF::deleteKeywords(const PArrayString& kwids, const PLockZ& unlockZ, ::std::function< void (bool, BException ex) > asyncResult)  {
	PMethodRequest req(new BRequest_IXServicePortIF_deleteKeywords(kwids, unlockZ));
	PAsyncResult outerResult( new BAsyncResultReceiveMethodL< bool, BResult_19 >(asyncResult) );
	transport->sendMethod(req, outerResult);
}
}}}}

