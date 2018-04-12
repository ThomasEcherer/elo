using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BStub_IXServicePortIF : BStub, IXServicePortIFAuth, BSerializable {	
		
		public readonly static long serialVersionUID = 1795705954L;
		
		public BStub_IXServicePortIF(BTransport transport)
			: base(transport) {}			
		
		public virtual void alive() {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			alive(BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void alive(BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_alive req = new BRequest_IXServicePortIF_alive();			
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.WFEditNode beginEditWorkFlowNode(int nFlowId, int nNodeId, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.WFEditNode> asyncResult = new BSyncResult<EloixClient.IndexServer.WFEditNode>();			
			beginEditWorkFlowNode(nFlowId, nNodeId, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.WFEditNode>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void beginEditWorkFlowNode(int nFlowId, int nNodeId, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.WFEditNode> asyncResult) {
			BRequest_IXServicePortIF_beginEditWorkFlowNode req = new BRequest_IXServicePortIF_beginEditWorkFlowNode();			
			req.nFlowIdValue = nFlowId;
			req.nNodeIdValue = nNodeId;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.EditInfo changeSordMask(EloixClient.IndexServer.Sord sord, String maskId, EloixClient.IndexServer.EditInfoZ editInfoZ) {
			BSyncResult<EloixClient.IndexServer.EditInfo> asyncResult = new BSyncResult<EloixClient.IndexServer.EditInfo>();			
			changeSordMask(sord, maskId, editInfoZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.EditInfo>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void changeSordMask(EloixClient.IndexServer.Sord sord, String maskId, EloixClient.IndexServer.EditInfoZ editInfoZ, BAsyncResult<EloixClient.IndexServer.EditInfo> asyncResult) {
			BRequest_IXServicePortIF_changeSordMask req = new BRequest_IXServicePortIF_changeSordMask();			
			req.sordValue = sord;
			req.maskIdValue = maskId;
			req.editInfoZValue = editInfoZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void checkinColors(EloixClient.IndexServer.ColorData[] colors, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			checkinColors(colors, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void checkinColors(EloixClient.IndexServer.ColorData[] colors, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_checkinColors req = new BRequest_IXServicePortIF_checkinColors();			
			req.colorsValue = colors;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void checkinConfigFiles(EloixClient.IndexServer.ConfigFile[] configFiles, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			checkinConfigFiles(configFiles, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void checkinConfigFiles(EloixClient.IndexServer.ConfigFile[] configFiles, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_checkinConfigFiles req = new BRequest_IXServicePortIF_checkinConfigFiles();			
			req.configFilesValue = configFiles;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.ConfigFile[] checkinConfigFilesBegin(String[] names) {
			BSyncResult<EloixClient.IndexServer.ConfigFile[]> asyncResult = new BSyncResult<EloixClient.IndexServer.ConfigFile[]>();			
			checkinConfigFilesBegin(names, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.ConfigFile[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinConfigFilesBegin(String[] names, BAsyncResult<EloixClient.IndexServer.ConfigFile[]> asyncResult) {
			BRequest_IXServicePortIF_checkinConfigFilesBegin req = new BRequest_IXServicePortIF_checkinConfigFilesBegin();			
			req.namesValue = names;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.ConfigFile[] checkinConfigFilesEnd(EloixClient.IndexServer.ConfigFile[] configFiles, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<EloixClient.IndexServer.ConfigFile[]> asyncResult = new BSyncResult<EloixClient.IndexServer.ConfigFile[]>();			
			checkinConfigFilesEnd(configFiles, unlockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.ConfigFile[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinConfigFilesEnd(EloixClient.IndexServer.ConfigFile[] configFiles, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<EloixClient.IndexServer.ConfigFile[]> asyncResult) {
			BRequest_IXServicePortIF_checkinConfigFilesEnd req = new BRequest_IXServicePortIF_checkinConfigFilesEnd();			
			req.configFilesValue = configFiles;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void checkinCounters(EloixClient.IndexServer.CounterInfo[] counterInfos, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			checkinCounters(counterInfos, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void checkinCounters(EloixClient.IndexServer.CounterInfo[] counterInfos, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_checkinCounters req = new BRequest_IXServicePortIF_checkinCounters();			
			req.counterInfosValue = counterInfos;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Document checkinDocBegin(EloixClient.IndexServer.Document document) {
			BSyncResult<EloixClient.IndexServer.Document> asyncResult = new BSyncResult<EloixClient.IndexServer.Document>();			
			checkinDocBegin(document, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Document>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinDocBegin(EloixClient.IndexServer.Document document, BAsyncResult<EloixClient.IndexServer.Document> asyncResult) {
			BRequest_IXServicePortIF_checkinDocBegin req = new BRequest_IXServicePortIF_checkinDocBegin();			
			req.documentValue = document;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Document checkinDocDupl(EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.Document document, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<EloixClient.IndexServer.Document> asyncResult = new BSyncResult<EloixClient.IndexServer.Document>();			
			checkinDocDupl(sord, sordZ, document, unlockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Document>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinDocDupl(EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.Document document, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<EloixClient.IndexServer.Document> asyncResult) {
			BRequest_IXServicePortIF_checkinDocDupl req = new BRequest_IXServicePortIF_checkinDocDupl();			
			req.sordValue = sord;
			req.sordZValue = sordZ;
			req.documentValue = document;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Document checkinDocEnd(EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.Document document, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<EloixClient.IndexServer.Document> asyncResult = new BSyncResult<EloixClient.IndexServer.Document>();			
			checkinDocEnd(sord, sordZ, document, unlockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Document>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinDocEnd(EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.Document document, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<EloixClient.IndexServer.Document> asyncResult) {
			BRequest_IXServicePortIF_checkinDocEnd req = new BRequest_IXServicePortIF_checkinDocEnd();			
			req.sordValue = sord;
			req.sordZValue = sordZ;
			req.documentValue = document;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int checkinDocMask(EloixClient.IndexServer.DocMask docMask, EloixClient.IndexServer.DocMaskZ docMaskZ, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<int> asyncResult = new BSyncResult<int>();			
			checkinDocMask(docMask, docMaskZ, unlockZ, BAsyncResultHelper.ToDelegate<int>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinDocMask(EloixClient.IndexServer.DocMask docMask, EloixClient.IndexServer.DocMaskZ docMaskZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<int> asyncResult) {
			BRequest_IXServicePortIF_checkinDocMask req = new BRequest_IXServicePortIF_checkinDocMask();			
			req.docMaskValue = docMask;
			req.docMaskZValue = docMaskZ;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Document[] checkinDocsBegin(EloixClient.IndexServer.Document[] documents) {
			BSyncResult<EloixClient.IndexServer.Document[]> asyncResult = new BSyncResult<EloixClient.IndexServer.Document[]>();			
			checkinDocsBegin(documents, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Document[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinDocsBegin(EloixClient.IndexServer.Document[] documents, BAsyncResult<EloixClient.IndexServer.Document[]> asyncResult) {
			BRequest_IXServicePortIF_checkinDocsBegin req = new BRequest_IXServicePortIF_checkinDocsBegin();			
			req.documentsValue = documents;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Document[] checkinDocsEnd(EloixClient.IndexServer.Sord[] sords, EloixClient.IndexServer.SordZ[] sordZs, EloixClient.IndexServer.Document[] documents, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<EloixClient.IndexServer.Document[]> asyncResult = new BSyncResult<EloixClient.IndexServer.Document[]>();			
			checkinDocsEnd(sords, sordZs, documents, unlockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Document[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinDocsEnd(EloixClient.IndexServer.Sord[] sords, EloixClient.IndexServer.SordZ[] sordZs, EloixClient.IndexServer.Document[] documents, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<EloixClient.IndexServer.Document[]> asyncResult) {
			BRequest_IXServicePortIF_checkinDocsEnd req = new BRequest_IXServicePortIF_checkinDocsEnd();			
			req.sordsValue = sords;
			req.sordZsValue = sordZs;
			req.documentsValue = documents;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int[] checkinKeys(EloixClient.IndexServer.KeyInfo[] keyInfos, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<int[]> asyncResult = new BSyncResult<int[]>();			
			checkinKeys(keyInfos, unlockZ, BAsyncResultHelper.ToDelegate<int[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinKeys(EloixClient.IndexServer.KeyInfo[] keyInfos, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<int[]> asyncResult) {
			BRequest_IXServicePortIF_checkinKeys req = new BRequest_IXServicePortIF_checkinKeys();			
			req.keyInfosValue = keyInfos;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void checkinKeywords(EloixClient.IndexServer.Keyword[] kws, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			checkinKeywords(kws, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void checkinKeywords(EloixClient.IndexServer.Keyword[] kws, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_checkinKeywords req = new BRequest_IXServicePortIF_checkinKeywords();			
			req.kwsValue = kws;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int[] checkinNotes(String objId, EloixClient.IndexServer.Note[] notes, EloixClient.IndexServer.NoteZ noteZ, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<int[]> asyncResult = new BSyncResult<int[]>();			
			checkinNotes(objId, notes, noteZ, unlockZ, BAsyncResultHelper.ToDelegate<int[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinNotes(String objId, EloixClient.IndexServer.Note[] notes, EloixClient.IndexServer.NoteZ noteZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<int[]> asyncResult) {
			BRequest_IXServicePortIF_checkinNotes req = new BRequest_IXServicePortIF_checkinNotes();			
			req.objIdValue = objId;
			req.notesValue = notes;
			req.noteZValue = noteZ;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Notification checkinNotification(EloixClient.IndexServer.Notification notif, EloixClient.IndexServer.NotificationZ notiZ) {
			BSyncResult<EloixClient.IndexServer.Notification> asyncResult = new BSyncResult<EloixClient.IndexServer.Notification>();			
			checkinNotification(notif, notiZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Notification>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinNotification(EloixClient.IndexServer.Notification notif, EloixClient.IndexServer.NotificationZ notiZ, BAsyncResult<EloixClient.IndexServer.Notification> asyncResult) {
			BRequest_IXServicePortIF_checkinNotification req = new BRequest_IXServicePortIF_checkinNotification();			
			req.notifValue = notif;
			req.notiZValue = notiZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int[] checkinReminder(EloixClient.IndexServer.Reminder remi, String[] receiverIds, bool expandGroups, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<int[]> asyncResult = new BSyncResult<int[]>();			
			checkinReminder(remi, receiverIds, expandGroups, unlockZ, BAsyncResultHelper.ToDelegate<int[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinReminder(EloixClient.IndexServer.Reminder remi, String[] receiverIds, bool expandGroups, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<int[]> asyncResult) {
			BRequest_IXServicePortIF_checkinReminder req = new BRequest_IXServicePortIF_checkinReminder();			
			req.remiValue = remi;
			req.receiverIdsValue = receiverIds;
			req.expandGroupsValue = expandGroups;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void checkinReplNames(EloixClient.IndexServer.ReplSetName[] replNames, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			checkinReplNames(replNames, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void checkinReplNames(EloixClient.IndexServer.ReplSetName[] replNames, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_checkinReplNames req = new BRequest_IXServicePortIF_checkinReplNames();			
			req.replNamesValue = replNames;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void checkinReportOptions(EloixClient.IndexServer.ReportOptions options, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			checkinReportOptions(options, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void checkinReportOptions(EloixClient.IndexServer.ReportOptions options, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_checkinReportOptions req = new BRequest_IXServicePortIF_checkinReportOptions();			
			req.optionsValue = options;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int checkinSord(EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<int> asyncResult = new BSyncResult<int>();			
			checkinSord(sord, sordZ, unlockZ, BAsyncResultHelper.ToDelegate<int>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinSord(EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<int> asyncResult) {
			BRequest_IXServicePortIF_checkinSord req = new BRequest_IXServicePortIF_checkinSord();			
			req.sordValue = sord;
			req.sordZValue = sordZ;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int[] checkinSordPath(String parentId, EloixClient.IndexServer.Sord[] sords, EloixClient.IndexServer.SordZ sordZ) {
			BSyncResult<int[]> asyncResult = new BSyncResult<int[]>();			
			checkinSordPath(parentId, sords, sordZ, BAsyncResultHelper.ToDelegate<int[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinSordPath(String parentId, EloixClient.IndexServer.Sord[] sords, EloixClient.IndexServer.SordZ sordZ, BAsyncResult<int[]> asyncResult) {
			BRequest_IXServicePortIF_checkinSordPath req = new BRequest_IXServicePortIF_checkinSordPath();			
			req.parentIdValue = parentId;
			req.sordsValue = sords;
			req.sordZValue = sordZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void checkinSordTypes(EloixClient.IndexServer.SordType[] sordTypes, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			checkinSordTypes(sordTypes, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void checkinSordTypes(EloixClient.IndexServer.SordType[] sordTypes, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_checkinSordTypes req = new BRequest_IXServicePortIF_checkinSordTypes();			
			req.sordTypesValue = sordTypes;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.StoreInfo[] checkinStorage(EloixClient.IndexServer.StoreInfo[] storeInfos, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<EloixClient.IndexServer.StoreInfo[]> asyncResult = new BSyncResult<EloixClient.IndexServer.StoreInfo[]>();			
			checkinStorage(storeInfos, unlockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.StoreInfo[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinStorage(EloixClient.IndexServer.StoreInfo[] storeInfos, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<EloixClient.IndexServer.StoreInfo[]> asyncResult) {
			BRequest_IXServicePortIF_checkinStorage req = new BRequest_IXServicePortIF_checkinStorage();			
			req.storeInfosValue = storeInfos;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void checkinSubs(EloixClient.IndexServer.SubsInfo[] deps, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			checkinSubs(deps, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void checkinSubs(EloixClient.IndexServer.SubsInfo[] deps, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_checkinSubs req = new BRequest_IXServicePortIF_checkinSubs();			
			req.depsValue = deps;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void checkinUserProfile(EloixClient.IndexServer.UserProfile userProfile, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			checkinUserProfile(userProfile, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void checkinUserProfile(EloixClient.IndexServer.UserProfile userProfile, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_checkinUserProfile req = new BRequest_IXServicePortIF_checkinUserProfile();			
			req.userProfileValue = userProfile;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int[] checkinUsers(EloixClient.IndexServer.UserInfo[] userInfos, EloixClient.IndexServer.CheckinUsersZ checkinUsersZ, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<int[]> asyncResult = new BSyncResult<int[]>();			
			checkinUsers(userInfos, checkinUsersZ, unlockZ, BAsyncResultHelper.ToDelegate<int[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinUsers(EloixClient.IndexServer.UserInfo[] userInfos, EloixClient.IndexServer.CheckinUsersZ checkinUsersZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<int[]> asyncResult) {
			BRequest_IXServicePortIF_checkinUsers req = new BRequest_IXServicePortIF_checkinUsers();			
			req.userInfosValue = userInfos;
			req.checkinUsersZValue = checkinUsersZ;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual IDictionary<int,EloixClient.IndexServer.OrgUnitInfo> checkinOrgUnits(EloixClient.IndexServer.OrgUnitInfo[] orgUnitInfos, EloixClient.IndexServer.CheckinOrgUnitInfo reserved, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<IDictionary<int,EloixClient.IndexServer.OrgUnitInfo>> asyncResult = new BSyncResult<IDictionary<int,EloixClient.IndexServer.OrgUnitInfo>>();			
			checkinOrgUnits(orgUnitInfos, reserved, unlockZ, BAsyncResultHelper.ToDelegate<IDictionary<int,EloixClient.IndexServer.OrgUnitInfo>>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinOrgUnits(EloixClient.IndexServer.OrgUnitInfo[] orgUnitInfos, EloixClient.IndexServer.CheckinOrgUnitInfo reserved, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<IDictionary<int,EloixClient.IndexServer.OrgUnitInfo>> asyncResult) {
			BRequest_IXServicePortIF_checkinOrgUnits req = new BRequest_IXServicePortIF_checkinOrgUnits();			
			req.orgUnitInfosValue = orgUnitInfos;
			req.reservedValue = reserved;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteOrgUnits(String[] ids, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteOrgUnits(ids, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteOrgUnits(String[] ids, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteOrgUnits req = new BRequest_IXServicePortIF_deleteOrgUnits();			
			req.idsValue = ids;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual IDictionary<int,EloixClient.IndexServer.OrgUnitInfo> checkoutOrgUnits(EloixClient.IndexServer.CheckoutOrgUnitInfo reserved, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<IDictionary<int,EloixClient.IndexServer.OrgUnitInfo>> asyncResult = new BSyncResult<IDictionary<int,EloixClient.IndexServer.OrgUnitInfo>>();			
			checkoutOrgUnits(reserved, lockZ, BAsyncResultHelper.ToDelegate<IDictionary<int,EloixClient.IndexServer.OrgUnitInfo>>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutOrgUnits(EloixClient.IndexServer.CheckoutOrgUnitInfo reserved, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<IDictionary<int,EloixClient.IndexServer.OrgUnitInfo>> asyncResult) {
			BRequest_IXServicePortIF_checkoutOrgUnits req = new BRequest_IXServicePortIF_checkoutOrgUnits();			
			req.reservedValue = reserved;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int checkinWorkFlow(EloixClient.IndexServer.WFDiagram wf, EloixClient.IndexServer.WFDiagramZ workFlowDiagramZ, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<int> asyncResult = new BSyncResult<int>();			
			checkinWorkFlow(wf, workFlowDiagramZ, unlockZ, BAsyncResultHelper.ToDelegate<int>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinWorkFlow(EloixClient.IndexServer.WFDiagram wf, EloixClient.IndexServer.WFDiagramZ workFlowDiagramZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<int> asyncResult) {
			BRequest_IXServicePortIF_checkinWorkFlow req = new BRequest_IXServicePortIF_checkinWorkFlow();			
			req.wfValue = wf;
			req.workFlowDiagramZValue = workFlowDiagramZ;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.ColorData[] checkoutColors(EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.ColorData[]> asyncResult = new BSyncResult<EloixClient.IndexServer.ColorData[]>();			
			checkoutColors(lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.ColorData[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutColors(EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.ColorData[]> asyncResult) {
			BRequest_IXServicePortIF_checkoutColors req = new BRequest_IXServicePortIF_checkoutColors();			
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.ConfigFile[] checkoutConfigFiles(String[] names, EloixClient.IndexServer.ConfigFileZ configFileZ, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.ConfigFile[]> asyncResult = new BSyncResult<EloixClient.IndexServer.ConfigFile[]>();			
			checkoutConfigFiles(names, configFileZ, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.ConfigFile[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutConfigFiles(String[] names, EloixClient.IndexServer.ConfigFileZ configFileZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.ConfigFile[]> asyncResult) {
			BRequest_IXServicePortIF_checkoutConfigFiles req = new BRequest_IXServicePortIF_checkoutConfigFiles();			
			req.namesValue = names;
			req.configFileZValue = configFileZ;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.CounterInfo[] checkoutCounters(String[] counterNames, bool incrementCounters, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.CounterInfo[]> asyncResult = new BSyncResult<EloixClient.IndexServer.CounterInfo[]>();			
			checkoutCounters(counterNames, incrementCounters, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.CounterInfo[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutCounters(String[] counterNames, bool incrementCounters, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.CounterInfo[]> asyncResult) {
			BRequest_IXServicePortIF_checkoutCounters req = new BRequest_IXServicePortIF_checkoutCounters();			
			req.counterNamesValue = counterNames;
			req.incrementCountersValue = incrementCounters;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.EditInfo checkoutDoc(String objId, String docId, EloixClient.IndexServer.EditInfoZ editInfoZ, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.EditInfo> asyncResult = new BSyncResult<EloixClient.IndexServer.EditInfo>();			
			checkoutDoc(objId, docId, editInfoZ, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.EditInfo>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutDoc(String objId, String docId, EloixClient.IndexServer.EditInfoZ editInfoZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.EditInfo> asyncResult) {
			BRequest_IXServicePortIF_checkoutDoc req = new BRequest_IXServicePortIF_checkoutDoc();			
			req.objIdValue = objId;
			req.docIdValue = docId;
			req.editInfoZValue = editInfoZ;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.DocMask checkoutDocMask(String maskId, EloixClient.IndexServer.DocMaskZ docMaskZ, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.DocMask> asyncResult = new BSyncResult<EloixClient.IndexServer.DocMask>();			
			checkoutDocMask(maskId, docMaskZ, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.DocMask>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutDocMask(String maskId, EloixClient.IndexServer.DocMaskZ docMaskZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.DocMask> asyncResult) {
			BRequest_IXServicePortIF_checkoutDocMask req = new BRequest_IXServicePortIF_checkoutDocMask();			
			req.maskIdValue = maskId;
			req.docMaskZValue = docMaskZ;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.KeyInfo[] checkoutKeys(String[] ids, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.KeyInfo[]> asyncResult = new BSyncResult<EloixClient.IndexServer.KeyInfo[]>();			
			checkoutKeys(ids, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.KeyInfo[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutKeys(String[] ids, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.KeyInfo[]> asyncResult) {
			BRequest_IXServicePortIF_checkoutKeys req = new BRequest_IXServicePortIF_checkoutKeys();			
			req.idsValue = ids;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Keyword[] checkoutKeywords(String[] kwids, EloixClient.IndexServer.KeywordZ keywordZ, int max, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.Keyword[]> asyncResult = new BSyncResult<EloixClient.IndexServer.Keyword[]>();			
			checkoutKeywords(kwids, keywordZ, max, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Keyword[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutKeywords(String[] kwids, EloixClient.IndexServer.KeywordZ keywordZ, int max, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.Keyword[]> asyncResult) {
			BRequest_IXServicePortIF_checkoutKeywords req = new BRequest_IXServicePortIF_checkoutKeywords();			
			req.kwidsValue = kwids;
			req.keywordZValue = keywordZ;
			req.maxValue = max;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Note[] checkoutNotes(String objId, String[] noteIds, EloixClient.IndexServer.NoteZ noteZ, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.Note[]> asyncResult = new BSyncResult<EloixClient.IndexServer.Note[]>();			
			checkoutNotes(objId, noteIds, noteZ, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Note[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutNotes(String objId, String[] noteIds, EloixClient.IndexServer.NoteZ noteZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.Note[]> asyncResult) {
			BRequest_IXServicePortIF_checkoutNotes req = new BRequest_IXServicePortIF_checkoutNotes();			
			req.objIdValue = objId;
			req.noteIdsValue = noteIds;
			req.noteZValue = noteZ;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Notification checkoutNotification(String watchGuid, String userGuid) {
			BSyncResult<EloixClient.IndexServer.Notification> asyncResult = new BSyncResult<EloixClient.IndexServer.Notification>();			
			checkoutNotification(watchGuid, userGuid, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Notification>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutNotification(String watchGuid, String userGuid, BAsyncResult<EloixClient.IndexServer.Notification> asyncResult) {
			BRequest_IXServicePortIF_checkoutNotification req = new BRequest_IXServicePortIF_checkoutNotification();			
			req.watchGuidValue = watchGuid;
			req.userGuidValue = userGuid;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Reminder[] checkoutReminders(int[] reminderIds, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.Reminder[]> asyncResult = new BSyncResult<EloixClient.IndexServer.Reminder[]>();			
			checkoutReminders(reminderIds, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Reminder[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutReminders(int[] reminderIds, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.Reminder[]> asyncResult) {
			BRequest_IXServicePortIF_checkoutReminders req = new BRequest_IXServicePortIF_checkoutReminders();			
			req.reminderIdsValue = reminderIds;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.ReplSetName[] checkoutReplNames(EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.ReplSetName[]> asyncResult = new BSyncResult<EloixClient.IndexServer.ReplSetName[]>();			
			checkoutReplNames(lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.ReplSetName[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutReplNames(EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.ReplSetName[]> asyncResult) {
			BRequest_IXServicePortIF_checkoutReplNames req = new BRequest_IXServicePortIF_checkoutReplNames();			
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.ReportOptions checkoutReportOptions(EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.ReportOptions> asyncResult = new BSyncResult<EloixClient.IndexServer.ReportOptions>();			
			checkoutReportOptions(lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.ReportOptions>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutReportOptions(EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.ReportOptions> asyncResult) {
			BRequest_IXServicePortIF_checkoutReportOptions req = new BRequest_IXServicePortIF_checkoutReportOptions();			
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.EditInfo checkoutSord(String objId, EloixClient.IndexServer.EditInfoZ editInfoZ, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.EditInfo> asyncResult = new BSyncResult<EloixClient.IndexServer.EditInfo>();			
			checkoutSord(objId, editInfoZ, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.EditInfo>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutSord(String objId, EloixClient.IndexServer.EditInfoZ editInfoZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.EditInfo> asyncResult) {
			BRequest_IXServicePortIF_checkoutSord req = new BRequest_IXServicePortIF_checkoutSord();			
			req.objIdValue = objId;
			req.editInfoZValue = editInfoZ;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.SordHist[] checkoutSordHistory(String objId) {
			BSyncResult<EloixClient.IndexServer.SordHist[]> asyncResult = new BSyncResult<EloixClient.IndexServer.SordHist[]>();			
			checkoutSordHistory(objId, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.SordHist[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutSordHistory(String objId, BAsyncResult<EloixClient.IndexServer.SordHist[]> asyncResult) {
			BRequest_IXServicePortIF_checkoutSordHistory req = new BRequest_IXServicePortIF_checkoutSordHistory();			
			req.objIdValue = objId;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.SordType[] checkoutSordTypes(int[] sordTypeIds, EloixClient.IndexServer.SordTypeZ sordTypeZ, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.SordType[]> asyncResult = new BSyncResult<EloixClient.IndexServer.SordType[]>();			
			checkoutSordTypes(sordTypeIds, sordTypeZ, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.SordType[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutSordTypes(int[] sordTypeIds, EloixClient.IndexServer.SordTypeZ sordTypeZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.SordType[]> asyncResult) {
			BRequest_IXServicePortIF_checkoutSordTypes req = new BRequest_IXServicePortIF_checkoutSordTypes();			
			req.sordTypeIdsValue = sordTypeIds;
			req.sordTypeZValue = sordTypeZ;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.StoreInfo[] checkoutStorage(String[] ids, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.StoreInfo[]> asyncResult = new BSyncResult<EloixClient.IndexServer.StoreInfo[]>();			
			checkoutStorage(ids, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.StoreInfo[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutStorage(String[] ids, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.StoreInfo[]> asyncResult) {
			BRequest_IXServicePortIF_checkoutStorage req = new BRequest_IXServicePortIF_checkoutStorage();			
			req.idsValue = ids;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.SubsInfo[] checkoutSubs(String userId, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.SubsInfo[]> asyncResult = new BSyncResult<EloixClient.IndexServer.SubsInfo[]>();			
			checkoutSubs(userId, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.SubsInfo[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutSubs(String userId, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.SubsInfo[]> asyncResult) {
			BRequest_IXServicePortIF_checkoutSubs req = new BRequest_IXServicePortIF_checkoutSubs();			
			req.userIdValue = userId;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.UserProfile checkoutUserProfile(EloixClient.IndexServer.UserProfile userProfile, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.UserProfile> asyncResult = new BSyncResult<EloixClient.IndexServer.UserProfile>();			
			checkoutUserProfile(userProfile, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.UserProfile>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutUserProfile(EloixClient.IndexServer.UserProfile userProfile, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.UserProfile> asyncResult) {
			BRequest_IXServicePortIF_checkoutUserProfile req = new BRequest_IXServicePortIF_checkoutUserProfile();			
			req.userProfileValue = userProfile;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.UserInfo[] checkoutUsers(String[] ids, EloixClient.IndexServer.CheckoutUsersZ checkoutUsersZ, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.UserInfo[]> asyncResult = new BSyncResult<EloixClient.IndexServer.UserInfo[]>();			
			checkoutUsers(ids, checkoutUsersZ, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.UserInfo[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutUsers(String[] ids, EloixClient.IndexServer.CheckoutUsersZ checkoutUsersZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.UserInfo[]> asyncResult) {
			BRequest_IXServicePortIF_checkoutUsers req = new BRequest_IXServicePortIF_checkoutUsers();			
			req.idsValue = ids;
			req.checkoutUsersZValue = checkoutUsersZ;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.WFDiagram checkoutWorkFlow(String flowId, EloixClient.IndexServer.WFTypeZ typeZ, EloixClient.IndexServer.WFDiagramZ workFlowDiagramZ, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.WFDiagram> asyncResult = new BSyncResult<EloixClient.IndexServer.WFDiagram>();			
			checkoutWorkFlow(flowId, typeZ, workFlowDiagramZ, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.WFDiagram>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutWorkFlow(String flowId, EloixClient.IndexServer.WFTypeZ typeZ, EloixClient.IndexServer.WFDiagramZ workFlowDiagramZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.WFDiagram> asyncResult) {
			BRequest_IXServicePortIF_checkoutWorkFlow req = new BRequest_IXServicePortIF_checkoutWorkFlow();			
			req.flowIdValue = flowId;
			req.typeZValue = typeZ;
			req.workFlowDiagramZValue = workFlowDiagramZ;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual bool cleanupStart(EloixClient.IndexServer.DeleteOptions deleteOptions) {
			BSyncResult<bool> asyncResult = new BSyncResult<bool>();			
			cleanupStart(deleteOptions, BAsyncResultHelper.ToDelegate<bool>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void cleanupStart(EloixClient.IndexServer.DeleteOptions deleteOptions, BAsyncResult<bool> asyncResult) {
			BRequest_IXServicePortIF_cleanupStart req = new BRequest_IXServicePortIF_cleanupStart();			
			req.deleteOptionsValue = deleteOptions;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.JobState cleanupState() {
			BSyncResult<EloixClient.IndexServer.JobState> asyncResult = new BSyncResult<EloixClient.IndexServer.JobState>();			
			cleanupState(BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.JobState>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void cleanupState(BAsyncResult<EloixClient.IndexServer.JobState> asyncResult) {
			BRequest_IXServicePortIF_cleanupState req = new BRequest_IXServicePortIF_cleanupState();			
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual bool cleanupStop() {
			BSyncResult<bool> asyncResult = new BSyncResult<bool>();			
			cleanupStop(BAsyncResultHelper.ToDelegate<bool>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void cleanupStop(BAsyncResult<bool> asyncResult) {
			BRequest_IXServicePortIF_cleanupStop req = new BRequest_IXServicePortIF_cleanupStop();			
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.JobState[] collectJobStates(bool activeJobs, bool finishedJobs, bool fullInfo) {
			BSyncResult<EloixClient.IndexServer.JobState[]> asyncResult = new BSyncResult<EloixClient.IndexServer.JobState[]>();			
			collectJobStates(activeJobs, finishedJobs, fullInfo, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.JobState[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void collectJobStates(bool activeJobs, bool finishedJobs, bool fullInfo, BAsyncResult<EloixClient.IndexServer.JobState[]> asyncResult) {
			BRequest_IXServicePortIF_collectJobStates req = new BRequest_IXServicePortIF_collectJobStates();			
			req.activeJobsValue = activeJobs;
			req.finishedJobsValue = finishedJobs;
			req.fullInfoValue = fullInfo;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.WFCollectNode[] collectWorkFlowNodes(String flowName, EloixClient.IndexServer.WFTypeZ wfTypeZ, String nodeName, int nodeType, String objId, String enterDateIso, String exitDateIso, String[] userIds, bool onlyActive, bool onlyStartNodes) {
			BSyncResult<EloixClient.IndexServer.WFCollectNode[]> asyncResult = new BSyncResult<EloixClient.IndexServer.WFCollectNode[]>();			
			collectWorkFlowNodes(flowName, wfTypeZ, nodeName, nodeType, objId, enterDateIso, exitDateIso, userIds, onlyActive, onlyStartNodes, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.WFCollectNode[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void collectWorkFlowNodes(String flowName, EloixClient.IndexServer.WFTypeZ wfTypeZ, String nodeName, int nodeType, String objId, String enterDateIso, String exitDateIso, String[] userIds, bool onlyActive, bool onlyStartNodes, BAsyncResult<EloixClient.IndexServer.WFCollectNode[]> asyncResult) {
			BRequest_IXServicePortIF_collectWorkFlowNodes req = new BRequest_IXServicePortIF_collectWorkFlowNodes();			
			req.flowNameValue = flowName;
			req.wfTypeZValue = wfTypeZ;
			req.nodeNameValue = nodeName;
			req.nodeTypeValue = nodeType;
			req.objIdValue = objId;
			req.enterDateIsoValue = enterDateIso;
			req.exitDateIsoValue = exitDateIso;
			req.userIdsValue = userIds;
			req.onlyActiveValue = onlyActive;
			req.onlyStartNodesValue = onlyStartNodes;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.IdName[] collectWorkFlows(EloixClient.IndexServer.WFTypeZ typeZ) {
			BSyncResult<EloixClient.IndexServer.IdName[]> asyncResult = new BSyncResult<EloixClient.IndexServer.IdName[]>();			
			collectWorkFlows(typeZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.IdName[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void collectWorkFlows(EloixClient.IndexServer.WFTypeZ typeZ, BAsyncResult<EloixClient.IndexServer.IdName[]> asyncResult) {
			BRequest_IXServicePortIF_collectWorkFlows req = new BRequest_IXServicePortIF_collectWorkFlows();			
			req.typeZValue = typeZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findFirstWorkflows(EloixClient.IndexServer.FindWorkflowInfo findInfo, int max, EloixClient.IndexServer.WFDiagramZ wfDiagramZ) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findFirstWorkflows(findInfo, max, wfDiagramZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findFirstWorkflows(EloixClient.IndexServer.FindWorkflowInfo findInfo, int max, EloixClient.IndexServer.WFDiagramZ wfDiagramZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findFirstWorkflows req = new BRequest_IXServicePortIF_findFirstWorkflows();			
			req.findInfoValue = findInfo;
			req.maxValue = max;
			req.wfDiagramZValue = wfDiagramZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findNextWorkflows(String searchId, int index, int maxResults) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findNextWorkflows(searchId, index, maxResults, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findNextWorkflows(String searchId, int index, int maxResults, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findNextWorkflows req = new BRequest_IXServicePortIF_findNextWorkflows();			
			req.searchIdValue = searchId;
			req.indexValue = index;
			req.maxResultsValue = maxResults;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual String cookKeyword(String kwid) {
			BSyncResult<String> asyncResult = new BSyncResult<String>();			
			cookKeyword(kwid, BAsyncResultHelper.ToDelegate<String>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void cookKeyword(String kwid, BAsyncResult<String> asyncResult) {
			BRequest_IXServicePortIF_cookKeyword req = new BRequest_IXServicePortIF_cookKeyword();			
			req.kwidValue = kwid;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int copySord(String newParentId, String objId, EloixClient.IndexServer.CopyInfo copyInfo, EloixClient.IndexServer.CopySordZ copySordZ) {
			BSyncResult<int> asyncResult = new BSyncResult<int>();			
			copySord(newParentId, objId, copyInfo, copySordZ, BAsyncResultHelper.ToDelegate<int>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void copySord(String newParentId, String objId, EloixClient.IndexServer.CopyInfo copyInfo, EloixClient.IndexServer.CopySordZ copySordZ, BAsyncResult<int> asyncResult) {
			BRequest_IXServicePortIF_copySord req = new BRequest_IXServicePortIF_copySord();			
			req.newParentIdValue = newParentId;
			req.objIdValue = objId;
			req.copyInfoValue = copyInfo;
			req.copySordZValue = copySordZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.EditInfo createDoc(String parentId, String maskId, String docTemplate, EloixClient.IndexServer.EditInfoZ editInfoZ) {
			BSyncResult<EloixClient.IndexServer.EditInfo> asyncResult = new BSyncResult<EloixClient.IndexServer.EditInfo>();			
			createDoc(parentId, maskId, docTemplate, editInfoZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.EditInfo>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void createDoc(String parentId, String maskId, String docTemplate, EloixClient.IndexServer.EditInfoZ editInfoZ, BAsyncResult<EloixClient.IndexServer.EditInfo> asyncResult) {
			BRequest_IXServicePortIF_createDoc req = new BRequest_IXServicePortIF_createDoc();			
			req.parentIdValue = parentId;
			req.maskIdValue = maskId;
			req.docTemplateValue = docTemplate;
			req.editInfoZValue = editInfoZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.DocMask createDocMask(String maskId) {
			BSyncResult<EloixClient.IndexServer.DocMask> asyncResult = new BSyncResult<EloixClient.IndexServer.DocMask>();			
			createDocMask(maskId, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.DocMask>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void createDocMask(String maskId, BAsyncResult<EloixClient.IndexServer.DocMask> asyncResult) {
			BRequest_IXServicePortIF_createDocMask req = new BRequest_IXServicePortIF_createDocMask();			
			req.maskIdValue = maskId;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.KeyInfo createKey() {
			BSyncResult<EloixClient.IndexServer.KeyInfo> asyncResult = new BSyncResult<EloixClient.IndexServer.KeyInfo>();			
			createKey(BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.KeyInfo>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void createKey(BAsyncResult<EloixClient.IndexServer.KeyInfo> asyncResult) {
			BRequest_IXServicePortIF_createKey req = new BRequest_IXServicePortIF_createKey();			
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Note createNote(String objId) {
			BSyncResult<EloixClient.IndexServer.Note> asyncResult = new BSyncResult<EloixClient.IndexServer.Note>();			
			createNote(objId, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Note>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void createNote(String objId, BAsyncResult<EloixClient.IndexServer.Note> asyncResult) {
			BRequest_IXServicePortIF_createNote req = new BRequest_IXServicePortIF_createNote();			
			req.objIdValue = objId;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Note createNote2(String objId, int noteType, String templId) {
			BSyncResult<EloixClient.IndexServer.Note> asyncResult = new BSyncResult<EloixClient.IndexServer.Note>();			
			createNote2(objId, noteType, templId, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Note>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void createNote2(String objId, int noteType, String templId, BAsyncResult<EloixClient.IndexServer.Note> asyncResult) {
			BRequest_IXServicePortIF_createNote2 req = new BRequest_IXServicePortIF_createNote2();			
			req.objIdValue = objId;
			req.noteTypeValue = noteType;
			req.templIdValue = templId;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Reminder createReminder(String objId) {
			BSyncResult<EloixClient.IndexServer.Reminder> asyncResult = new BSyncResult<EloixClient.IndexServer.Reminder>();			
			createReminder(objId, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Reminder>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void createReminder(String objId, BAsyncResult<EloixClient.IndexServer.Reminder> asyncResult) {
			BRequest_IXServicePortIF_createReminder req = new BRequest_IXServicePortIF_createReminder();			
			req.objIdValue = objId;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.EditInfo createSord(String parentId, String maskId, EloixClient.IndexServer.EditInfoZ editInfoZ) {
			BSyncResult<EloixClient.IndexServer.EditInfo> asyncResult = new BSyncResult<EloixClient.IndexServer.EditInfo>();			
			createSord(parentId, maskId, editInfoZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.EditInfo>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void createSord(String parentId, String maskId, EloixClient.IndexServer.EditInfoZ editInfoZ, BAsyncResult<EloixClient.IndexServer.EditInfo> asyncResult) {
			BRequest_IXServicePortIF_createSord req = new BRequest_IXServicePortIF_createSord();			
			req.parentIdValue = parentId;
			req.maskIdValue = maskId;
			req.editInfoZValue = editInfoZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.UserInfo createUser(String rightsAsUserId) {
			BSyncResult<EloixClient.IndexServer.UserInfo> asyncResult = new BSyncResult<EloixClient.IndexServer.UserInfo>();			
			createUser(rightsAsUserId, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.UserInfo>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void createUser(String rightsAsUserId, BAsyncResult<EloixClient.IndexServer.UserInfo> asyncResult) {
			BRequest_IXServicePortIF_createUser req = new BRequest_IXServicePortIF_createUser();			
			req.rightsAsUserIdValue = rightsAsUserId;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.WFNode createWFNode(int nodeId, int nodeTypeC) {
			BSyncResult<EloixClient.IndexServer.WFNode> asyncResult = new BSyncResult<EloixClient.IndexServer.WFNode>();			
			createWFNode(nodeId, nodeTypeC, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.WFNode>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void createWFNode(int nodeId, int nodeTypeC, BAsyncResult<EloixClient.IndexServer.WFNode> asyncResult) {
			BRequest_IXServicePortIF_createWFNode req = new BRequest_IXServicePortIF_createWFNode();			
			req.nodeIdValue = nodeId;
			req.nodeTypeCValue = nodeTypeC;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.WFDiagram createWorkFlow(String wfName, EloixClient.IndexServer.WFTypeZ typeZ) {
			BSyncResult<EloixClient.IndexServer.WFDiagram> asyncResult = new BSyncResult<EloixClient.IndexServer.WFDiagram>();			
			createWorkFlow(wfName, typeZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.WFDiagram>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void createWorkFlow(String wfName, EloixClient.IndexServer.WFTypeZ typeZ, BAsyncResult<EloixClient.IndexServer.WFDiagram> asyncResult) {
			BRequest_IXServicePortIF_createWorkFlow req = new BRequest_IXServicePortIF_createWorkFlow();			
			req.wfNameValue = wfName;
			req.typeZValue = typeZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteConfigFiles(String[] names, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteConfigFiles(names, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteConfigFiles(String[] names, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteConfigFiles req = new BRequest_IXServicePortIF_deleteConfigFiles();			
			req.namesValue = names;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteCounters(String[] counterNames, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteCounters(counterNames, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteCounters(String[] counterNames, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteCounters req = new BRequest_IXServicePortIF_deleteCounters();			
			req.counterNamesValue = counterNames;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual bool deleteDocMask(String maskId, String assignMaskId, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<bool> asyncResult = new BSyncResult<bool>();			
			deleteDocMask(maskId, assignMaskId, unlockZ, BAsyncResultHelper.ToDelegate<bool>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void deleteDocMask(String maskId, String assignMaskId, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<bool> asyncResult) {
			BRequest_IXServicePortIF_deleteDocMask req = new BRequest_IXServicePortIF_deleteDocMask();			
			req.maskIdValue = maskId;
			req.assignMaskIdValue = assignMaskId;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteKeys(String[] ids, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteKeys(ids, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteKeys(String[] ids, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteKeys req = new BRequest_IXServicePortIF_deleteKeys();			
			req.idsValue = ids;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteKeywords(String[] kwids, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteKeywords(kwids, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteKeywords(String[] kwids, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteKeywords req = new BRequest_IXServicePortIF_deleteKeywords();			
			req.kwidsValue = kwids;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteNotes(String[] noteIds, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteNotes(noteIds, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteNotes(String[] noteIds, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteNotes req = new BRequest_IXServicePortIF_deleteNotes();			
			req.noteIdsValue = noteIds;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int deleteNotification(String objGuid, String userGuid) {
			BSyncResult<int> asyncResult = new BSyncResult<int>();			
			deleteNotification(objGuid, userGuid, BAsyncResultHelper.ToDelegate<int>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void deleteNotification(String objGuid, String userGuid, BAsyncResult<int> asyncResult) {
			BRequest_IXServicePortIF_deleteNotification req = new BRequest_IXServicePortIF_deleteNotification();			
			req.objGuidValue = objGuid;
			req.userGuidValue = userGuid;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteReminders(int[] reminderIds, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteReminders(reminderIds, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteReminders(int[] reminderIds, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteReminders req = new BRequest_IXServicePortIF_deleteReminders();			
			req.reminderIdsValue = reminderIds;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteReport(String endDateISO) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteReport(endDateISO, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteReport(String endDateISO, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteReport req = new BRequest_IXServicePortIF_deleteReport();			
			req.endDateISOValue = endDateISO;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual bool deleteSord(String parentId, String objId, EloixClient.IndexServer.LockZ unlockZ, EloixClient.IndexServer.DeleteOptions deleteOptions) {
			BSyncResult<bool> asyncResult = new BSyncResult<bool>();			
			deleteSord(parentId, objId, unlockZ, deleteOptions, BAsyncResultHelper.ToDelegate<bool>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void deleteSord(String parentId, String objId, EloixClient.IndexServer.LockZ unlockZ, EloixClient.IndexServer.DeleteOptions deleteOptions, BAsyncResult<bool> asyncResult) {
			BRequest_IXServicePortIF_deleteSord req = new BRequest_IXServicePortIF_deleteSord();			
			req.parentIdValue = parentId;
			req.objIdValue = objId;
			req.unlockZValue = unlockZ;
			req.deleteOptionsValue = deleteOptions;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteSordTypes(int[] sordTypeIds, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteSordTypes(sordTypeIds, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteSordTypes(int[] sordTypeIds, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteSordTypes req = new BRequest_IXServicePortIF_deleteSordTypes();			
			req.sordTypeIdsValue = sordTypeIds;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteSubs(EloixClient.IndexServer.SubsInfo[] deps, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteSubs(deps, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteSubs(EloixClient.IndexServer.SubsInfo[] deps, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteSubs req = new BRequest_IXServicePortIF_deleteSubs();			
			req.depsValue = deps;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteUserProfile(EloixClient.IndexServer.UserProfile userProfile, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteUserProfile(userProfile, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteUserProfile(EloixClient.IndexServer.UserProfile userProfile, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteUserProfile req = new BRequest_IXServicePortIF_deleteUserProfile();			
			req.userProfileValue = userProfile;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteUsers(String[] ids, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteUsers(ids, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteUsers(String[] ids, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteUsers req = new BRequest_IXServicePortIF_deleteUsers();			
			req.idsValue = ids;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteWorkFlow(String flowId, EloixClient.IndexServer.WFTypeZ typeZ, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteWorkFlow(flowId, typeZ, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteWorkFlow(String flowId, EloixClient.IndexServer.WFTypeZ typeZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteWorkFlow req = new BRequest_IXServicePortIF_deleteWorkFlow();			
			req.flowIdValue = flowId;
			req.typeZValue = typeZ;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void endEditWorkFlowNode(int nFlowId, int nNodeId, bool bTerminate, bool bCancel, String sName, String sComment, int[] arrEnterNodesIds) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			endEditWorkFlowNode(nFlowId, nNodeId, bTerminate, bCancel, sName, sComment, arrEnterNodesIds, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void endEditWorkFlowNode(int nFlowId, int nNodeId, bool bTerminate, bool bCancel, String sName, String sComment, int[] arrEnterNodesIds, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_endEditWorkFlowNode req = new BRequest_IXServicePortIF_endEditWorkFlowNode();			
			req.nFlowIdValue = nFlowId;
			req.nNodeIdValue = nNodeId;
			req.bTerminateValue = bTerminate;
			req.bCancelValue = bCancel;
			req.sNameValue = sName;
			req.sCommentValue = sComment;
			req.arrEnterNodesIdsValue = arrEnterNodesIds;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void findClose(String searchId) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			findClose(searchId, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void findClose(String searchId, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_findClose req = new BRequest_IXServicePortIF_findClose();			
			req.searchIdValue = searchId;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findFirstConfigFiles(EloixClient.IndexServer.FindConfigFileInfo findInfo, int max, EloixClient.IndexServer.ConfigFileZ configFileZ) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findFirstConfigFiles(findInfo, max, configFileZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findFirstConfigFiles(EloixClient.IndexServer.FindConfigFileInfo findInfo, int max, EloixClient.IndexServer.ConfigFileZ configFileZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findFirstConfigFiles req = new BRequest_IXServicePortIF_findFirstConfigFiles();			
			req.findInfoValue = findInfo;
			req.maxValue = max;
			req.configFileZValue = configFileZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findFirstReportInfos(EloixClient.IndexServer.FindReportInfo opts, int max) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findFirstReportInfos(opts, max, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findFirstReportInfos(EloixClient.IndexServer.FindReportInfo opts, int max, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findFirstReportInfos req = new BRequest_IXServicePortIF_findFirstReportInfos();			
			req.optsValue = opts;
			req.maxValue = max;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findFirstSords(EloixClient.IndexServer.FindInfo findInfo, int max, EloixClient.IndexServer.SordZ sordZ) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findFirstSords(findInfo, max, sordZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findFirstSords(EloixClient.IndexServer.FindInfo findInfo, int max, EloixClient.IndexServer.SordZ sordZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findFirstSords req = new BRequest_IXServicePortIF_findFirstSords();			
			req.findInfoValue = findInfo;
			req.maxValue = max;
			req.sordZValue = sordZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findFirstTasks(EloixClient.IndexServer.FindTasksInfo findInfo, int max) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findFirstTasks(findInfo, max, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findFirstTasks(EloixClient.IndexServer.FindTasksInfo findInfo, int max, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findFirstTasks req = new BRequest_IXServicePortIF_findFirstTasks();			
			req.findInfoValue = findInfo;
			req.maxValue = max;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findNextConfigFiles(String searchId, int idx, int max, EloixClient.IndexServer.ConfigFileZ configFileZ) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findNextConfigFiles(searchId, idx, max, configFileZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findNextConfigFiles(String searchId, int idx, int max, EloixClient.IndexServer.ConfigFileZ configFileZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findNextConfigFiles req = new BRequest_IXServicePortIF_findNextConfigFiles();			
			req.searchIdValue = searchId;
			req.idxValue = idx;
			req.maxValue = max;
			req.configFileZValue = configFileZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findNextReportInfos(String searchId, int idx, int max) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findNextReportInfos(searchId, idx, max, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findNextReportInfos(String searchId, int idx, int max, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findNextReportInfos req = new BRequest_IXServicePortIF_findNextReportInfos();			
			req.searchIdValue = searchId;
			req.idxValue = idx;
			req.maxValue = max;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findNextSords(String searchId, int idx, int max, EloixClient.IndexServer.SordZ sordZ) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findNextSords(searchId, idx, max, sordZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findNextSords(String searchId, int idx, int max, EloixClient.IndexServer.SordZ sordZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findNextSords req = new BRequest_IXServicePortIF_findNextSords();			
			req.searchIdValue = searchId;
			req.idxValue = idx;
			req.maxValue = max;
			req.sordZValue = sordZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findNextTasks(String searchId, int idx, int max) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findNextTasks(searchId, idx, max, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findNextTasks(String searchId, int idx, int max, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findNextTasks req = new BRequest_IXServicePortIF_findNextTasks();			
			req.searchIdValue = searchId;
			req.idxValue = idx;
			req.maxValue = max;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void finishExport(String exportId) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			finishExport(exportId, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void finishExport(String exportId, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_finishExport req = new BRequest_IXServicePortIF_finishExport();			
			req.exportIdValue = exportId;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.IXServicePortC getConstants() {
			BSyncResult<EloixClient.IndexServer.IXServicePortC> asyncResult = new BSyncResult<EloixClient.IndexServer.IXServicePortC>();			
			getConstants(BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.IXServicePortC>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getConstants(BAsyncResult<EloixClient.IndexServer.IXServicePortC> asyncResult) {
			BRequest_IXServicePortIF_getConstants req = new BRequest_IXServicePortIF_getConstants();			
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual String getExportZipUrl(String exportId) {
			BSyncResult<String> asyncResult = new BSyncResult<String>();			
			getExportZipUrl(exportId, BAsyncResultHelper.ToDelegate<String>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getExportZipUrl(String exportId, BAsyncResult<String> asyncResult) {
			BRequest_IXServicePortIF_getExportZipUrl req = new BRequest_IXServicePortIF_getExportZipUrl();			
			req.exportIdValue = exportId;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual String getImportZipUrl(String importId) {
			BSyncResult<String> asyncResult = new BSyncResult<String>();			
			getImportZipUrl(importId, BAsyncResultHelper.ToDelegate<String>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getImportZipUrl(String importId, BAsyncResult<String> asyncResult) {
			BRequest_IXServicePortIF_getImportZipUrl req = new BRequest_IXServicePortIF_getImportZipUrl();			
			req.importIdValue = importId;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.ServerInfo getServerInfo() {
			BSyncResult<EloixClient.IndexServer.ServerInfo> asyncResult = new BSyncResult<EloixClient.IndexServer.ServerInfo>();			
			getServerInfo(BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.ServerInfo>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getServerInfo(BAsyncResult<EloixClient.IndexServer.ServerInfo> asyncResult) {
			BRequest_IXServicePortIF_getServerInfo req = new BRequest_IXServicePortIF_getServerInfo();			
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void setServerInfo(EloixClient.IndexServer.ServerInfo serverInfo) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			setServerInfo(serverInfo, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void setServerInfo(EloixClient.IndexServer.ServerInfo serverInfo, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_setServerInfo req = new BRequest_IXServicePortIF_setServerInfo();			
			req.serverInfoValue = serverInfo;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.ServerInfoDM getServerInfoDM() {
			BSyncResult<EloixClient.IndexServer.ServerInfoDM> asyncResult = new BSyncResult<EloixClient.IndexServer.ServerInfoDM>();			
			getServerInfoDM(BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.ServerInfoDM>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getServerInfoDM(BAsyncResult<EloixClient.IndexServer.ServerInfoDM> asyncResult) {
			BRequest_IXServicePortIF_getServerInfoDM req = new BRequest_IXServicePortIF_getServerInfoDM();			
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void setServerInfoDM(EloixClient.IndexServer.ServerInfoDM serverInfo) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			setServerInfoDM(serverInfo, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void setServerInfoDM(EloixClient.IndexServer.ServerInfoDM serverInfo, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_setServerInfoDM req = new BRequest_IXServicePortIF_setServerInfoDM();			
			req.serverInfoValue = serverInfo;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.SessionOptions getSessionOptions() {
			BSyncResult<EloixClient.IndexServer.SessionOptions> asyncResult = new BSyncResult<EloixClient.IndexServer.SessionOptions>();			
			getSessionOptions(BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.SessionOptions>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getSessionOptions(BAsyncResult<EloixClient.IndexServer.SessionOptions> asyncResult) {
			BRequest_IXServicePortIF_getSessionOptions req = new BRequest_IXServicePortIF_getSessionOptions();			
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.UserName[] getUserNames(String[] ids, EloixClient.IndexServer.CheckoutUsersZ checkoutUsersZ) {
			BSyncResult<EloixClient.IndexServer.UserName[]> asyncResult = new BSyncResult<EloixClient.IndexServer.UserName[]>();			
			getUserNames(ids, checkoutUsersZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.UserName[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getUserNames(String[] ids, EloixClient.IndexServer.CheckoutUsersZ checkoutUsersZ, BAsyncResult<EloixClient.IndexServer.UserName[]> asyncResult) {
			BRequest_IXServicePortIF_getUserNames req = new BRequest_IXServicePortIF_getUserNames();			
			req.idsValue = ids;
			req.checkoutUsersZValue = checkoutUsersZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int importWorkFlow(String flowName, byte[] fileData) {
			BSyncResult<int> asyncResult = new BSyncResult<int>();			
			importWorkFlow(flowName, fileData, BAsyncResultHelper.ToDelegate<int>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void importWorkFlow(String flowName, byte[] fileData, BAsyncResult<int> asyncResult) {
			BRequest_IXServicePortIF_importWorkFlow req = new BRequest_IXServicePortIF_importWorkFlow();			
			req.flowNameValue = flowName;
			req.fileDataValue = fileData;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int importWorkFlow2(String flowName, byte[] fileData, EloixClient.IndexServer.WorkflowImportOptions importOptions) {
			BSyncResult<int> asyncResult = new BSyncResult<int>();			
			importWorkFlow2(flowName, fileData, importOptions, BAsyncResultHelper.ToDelegate<int>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void importWorkFlow2(String flowName, byte[] fileData, EloixClient.IndexServer.WorkflowImportOptions importOptions, BAsyncResult<int> asyncResult) {
			BRequest_IXServicePortIF_importWorkFlow2 req = new BRequest_IXServicePortIF_importWorkFlow2();			
			req.flowNameValue = flowName;
			req.fileDataValue = fileData;
			req.importOptionsValue = importOptions;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void linkSords(String fromId, String[] toIds, EloixClient.IndexServer.LinkSordZ linkZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			linkSords(fromId, toIds, linkZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void linkSords(String fromId, String[] toIds, EloixClient.IndexServer.LinkSordZ linkZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_linkSords req = new BRequest_IXServicePortIF_linkSords();			
			req.fromIdValue = fromId;
			req.toIdsValue = toIds;
			req.linkZValue = linkZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int lockArchive(String keyId) {
			BSyncResult<int> asyncResult = new BSyncResult<int>();			
			lockArchive(keyId, BAsyncResultHelper.ToDelegate<int>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void lockArchive(String keyId, BAsyncResult<int> asyncResult) {
			BRequest_IXServicePortIF_lockArchive req = new BRequest_IXServicePortIF_lockArchive();			
			req.keyIdValue = keyId;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.LoginResult login(String userName, String userPwd, String clientComputer, String runAsUser) {
			BSyncResult<EloixClient.IndexServer.LoginResult> asyncResult = new BSyncResult<EloixClient.IndexServer.LoginResult>();			
			login(userName, userPwd, clientComputer, runAsUser, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.LoginResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void login(String userName, String userPwd, String clientComputer, String runAsUser, BAsyncResult<EloixClient.IndexServer.LoginResult> asyncResult) {
			BRequest_IXServicePortIF_login req = new BRequest_IXServicePortIF_login();			
			req.userNameValue = userName;
			req.userPwdValue = userPwd;
			req.clientComputerValue = clientComputer;
			req.runAsUserValue = runAsUser;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.LoginResult loginAdmin(String userName, String userPwd, String clientComputer, String reportAsUser) {
			BSyncResult<EloixClient.IndexServer.LoginResult> asyncResult = new BSyncResult<EloixClient.IndexServer.LoginResult>();			
			loginAdmin(userName, userPwd, clientComputer, reportAsUser, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.LoginResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void loginAdmin(String userName, String userPwd, String clientComputer, String reportAsUser, BAsyncResult<EloixClient.IndexServer.LoginResult> asyncResult) {
			BRequest_IXServicePortIF_loginAdmin req = new BRequest_IXServicePortIF_loginAdmin();			
			req.userNameValue = userName;
			req.userPwdValue = userPwd;
			req.clientComputerValue = clientComputer;
			req.reportAsUserValue = reportAsUser;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.LoginResult loginEloProf(int userId, String certificate, String clientComputer) {
			BSyncResult<EloixClient.IndexServer.LoginResult> asyncResult = new BSyncResult<EloixClient.IndexServer.LoginResult>();			
			loginEloProf(userId, certificate, clientComputer, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.LoginResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void loginEloProf(int userId, String certificate, String clientComputer, BAsyncResult<EloixClient.IndexServer.LoginResult> asyncResult) {
			BRequest_IXServicePortIF_loginEloProf req = new BRequest_IXServicePortIF_loginEloProf();			
			req.userIdValue = userId;
			req.certificateValue = certificate;
			req.clientComputerValue = clientComputer;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.LoginResult loginKerberos(byte[] ticket, String clientComputer) {
			BSyncResult<EloixClient.IndexServer.LoginResult> asyncResult = new BSyncResult<EloixClient.IndexServer.LoginResult>();			
			loginKerberos(ticket, clientComputer, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.LoginResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void loginKerberos(byte[] ticket, String clientComputer, BAsyncResult<EloixClient.IndexServer.LoginResult> asyncResult) {
			BRequest_IXServicePortIF_loginKerberos req = new BRequest_IXServicePortIF_loginKerberos();			
			req.ticketValue = ticket;
			req.clientComputerValue = clientComputer;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void logout() {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			logout(BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void logout(BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_logout req = new BRequest_IXServicePortIF_logout();			
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.IXExceptionData parseException(String exceptionString) {
			BSyncResult<EloixClient.IndexServer.IXExceptionData> asyncResult = new BSyncResult<EloixClient.IndexServer.IXExceptionData>();			
			parseException(exceptionString, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.IXExceptionData>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void parseException(String exceptionString, BAsyncResult<EloixClient.IndexServer.IXExceptionData> asyncResult) {
			BRequest_IXServicePortIF_parseException req = new BRequest_IXServicePortIF_parseException();			
			req.exceptionStringValue = exceptionString;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.JobState processFindResult(String searchId, EloixClient.IndexServer.ProcessInfo procInfo) {
			BSyncResult<EloixClient.IndexServer.JobState> asyncResult = new BSyncResult<EloixClient.IndexServer.JobState>();			
			processFindResult(searchId, procInfo, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.JobState>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void processFindResult(String searchId, EloixClient.IndexServer.ProcessInfo procInfo, BAsyncResult<EloixClient.IndexServer.JobState> asyncResult) {
			BRequest_IXServicePortIF_processFindResult req = new BRequest_IXServicePortIF_processFindResult();			
			req.searchIdValue = searchId;
			req.procInfoValue = procInfo;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.JobState processTrees(EloixClient.IndexServer.NavigationInfo navigationInfo, EloixClient.IndexServer.ProcessInfo procInfo) {
			BSyncResult<EloixClient.IndexServer.JobState> asyncResult = new BSyncResult<EloixClient.IndexServer.JobState>();			
			processTrees(navigationInfo, procInfo, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.JobState>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void processTrees(EloixClient.IndexServer.NavigationInfo navigationInfo, EloixClient.IndexServer.ProcessInfo procInfo, BAsyncResult<EloixClient.IndexServer.JobState> asyncResult) {
			BRequest_IXServicePortIF_processTrees req = new BRequest_IXServicePortIF_processTrees();			
			req.navigationInfoValue = navigationInfo;
			req.procInfoValue = procInfo;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.JobState queryJobState(String jobGuid, bool activeJobs, bool finishedJobs, bool fullInfo) {
			BSyncResult<EloixClient.IndexServer.JobState> asyncResult = new BSyncResult<EloixClient.IndexServer.JobState>();			
			queryJobState(jobGuid, activeJobs, finishedJobs, fullInfo, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.JobState>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void queryJobState(String jobGuid, bool activeJobs, bool finishedJobs, bool fullInfo, BAsyncResult<EloixClient.IndexServer.JobState> asyncResult) {
			BRequest_IXServicePortIF_queryJobState req = new BRequest_IXServicePortIF_queryJobState();			
			req.jobGuidValue = jobGuid;
			req.activeJobsValue = activeJobs;
			req.finishedJobsValue = finishedJobs;
			req.fullInfoValue = fullInfo;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void refSord(String oldParentId, String newParentId, String objId, int manSortIdx) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			refSord(oldParentId, newParentId, objId, manSortIdx, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void refSord(String oldParentId, String newParentId, String objId, int manSortIdx, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_refSord req = new BRequest_IXServicePortIF_refSord();			
			req.oldParentIdValue = oldParentId;
			req.newParentIdValue = newParentId;
			req.objIdValue = objId;
			req.manSortIdxValue = manSortIdx;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual bool restoreSord(String objId, EloixClient.IndexServer.RestoreOptions restoreOptions) {
			BSyncResult<bool> asyncResult = new BSyncResult<bool>();			
			restoreSord(objId, restoreOptions, BAsyncResultHelper.ToDelegate<bool>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void restoreSord(String objId, EloixClient.IndexServer.RestoreOptions restoreOptions, BAsyncResult<bool> asyncResult) {
			BRequest_IXServicePortIF_restoreSord req = new BRequest_IXServicePortIF_restoreSord();			
			req.objIdValue = objId;
			req.restoreOptionsValue = restoreOptions;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void setSessionOptions(EloixClient.IndexServer.SessionOptions opts) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			setSessionOptions(opts, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void setSessionOptions(EloixClient.IndexServer.SessionOptions opts, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_setSessionOptions req = new BRequest_IXServicePortIF_setSessionOptions();			
			req.optsValue = opts;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int startAdHocWorkFlow(String name, String objId, String[] arrUserIds, String nodeName, bool forValidation, bool serialFlow, String cancelUserId, String cancelMessage, String finishedUserId, String finishedMessage, String finishedScript) {
			BSyncResult<int> asyncResult = new BSyncResult<int>();			
			startAdHocWorkFlow(name, objId, arrUserIds, nodeName, forValidation, serialFlow, cancelUserId, cancelMessage, finishedUserId, finishedMessage, finishedScript, BAsyncResultHelper.ToDelegate<int>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void startAdHocWorkFlow(String name, String objId, String[] arrUserIds, String nodeName, bool forValidation, bool serialFlow, String cancelUserId, String cancelMessage, String finishedUserId, String finishedMessage, String finishedScript, BAsyncResult<int> asyncResult) {
			BRequest_IXServicePortIF_startAdHocWorkFlow req = new BRequest_IXServicePortIF_startAdHocWorkFlow();			
			req.nameValue = name;
			req.objIdValue = objId;
			req.arrUserIdsValue = arrUserIds;
			req.nodeNameValue = nodeName;
			req.forValidationValue = forValidation;
			req.serialFlowValue = serialFlow;
			req.cancelUserIdValue = cancelUserId;
			req.cancelMessageValue = cancelMessage;
			req.finishedUserIdValue = finishedUserId;
			req.finishedMessageValue = finishedMessage;
			req.finishedScriptValue = finishedScript;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual String startExport(String[] topLevelIDs, long options) {
			BSyncResult<String> asyncResult = new BSyncResult<String>();			
			startExport(topLevelIDs, options, BAsyncResultHelper.ToDelegate<String>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void startExport(String[] topLevelIDs, long options, BAsyncResult<String> asyncResult) {
			BRequest_IXServicePortIF_startExport req = new BRequest_IXServicePortIF_startExport();			
			req.topLevelIDsValue = topLevelIDs;
			req.optionsValue = options;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual String startExportExt(EloixClient.IndexServer.ExportExtOptions options) {
			BSyncResult<String> asyncResult = new BSyncResult<String>();			
			startExportExt(options, BAsyncResultHelper.ToDelegate<String>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void startExportExt(EloixClient.IndexServer.ExportExtOptions options, BAsyncResult<String> asyncResult) {
			BRequest_IXServicePortIF_startExportExt req = new BRequest_IXServicePortIF_startExportExt();			
			req.optionsValue = options;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual String startImport(String filingPath, int guidMethod, long options) {
			BSyncResult<String> asyncResult = new BSyncResult<String>();			
			startImport(filingPath, guidMethod, options, BAsyncResultHelper.ToDelegate<String>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void startImport(String filingPath, int guidMethod, long options, BAsyncResult<String> asyncResult) {
			BRequest_IXServicePortIF_startImport req = new BRequest_IXServicePortIF_startImport();			
			req.filingPathValue = filingPath;
			req.guidMethodValue = guidMethod;
			req.optionsValue = options;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int startWorkFlow(String templFlowId, String flowName, String objId) {
			BSyncResult<int> asyncResult = new BSyncResult<int>();			
			startWorkFlow(templFlowId, flowName, objId, BAsyncResultHelper.ToDelegate<int>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void startWorkFlow(String templFlowId, String flowName, String objId, BAsyncResult<int> asyncResult) {
			BRequest_IXServicePortIF_startWorkFlow req = new BRequest_IXServicePortIF_startWorkFlow();			
			req.templFlowIdValue = templFlowId;
			req.flowNameValue = flowName;
			req.objIdValue = objId;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void takeWorkFlowNode(int nFlowId, int nNodeId, String sUserId, int nFlags, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			takeWorkFlowNode(nFlowId, nNodeId, sUserId, nFlags, lockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void takeWorkFlowNode(int nFlowId, int nNodeId, String sUserId, int nFlags, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_takeWorkFlowNode req = new BRequest_IXServicePortIF_takeWorkFlowNode();			
			req.nFlowIdValue = nFlowId;
			req.nNodeIdValue = nNodeId;
			req.sUserIdValue = sUserId;
			req.nFlagsValue = nFlags;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int terminateWorkFlow(String flowId, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<int> asyncResult = new BSyncResult<int>();			
			terminateWorkFlow(flowId, unlockZ, BAsyncResultHelper.ToDelegate<int>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void terminateWorkFlow(String flowId, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<int> asyncResult) {
			BRequest_IXServicePortIF_terminateWorkFlow req = new BRequest_IXServicePortIF_terminateWorkFlow();			
			req.flowIdValue = flowId;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void delegateWorkFlowNode(EloixClient.IndexServer.WFDelegateNodeInfo delegateNodeInfo, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			delegateWorkFlowNode(delegateNodeInfo, lockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void delegateWorkFlowNode(EloixClient.IndexServer.WFDelegateNodeInfo delegateNodeInfo, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_delegateWorkFlowNode req = new BRequest_IXServicePortIF_delegateWorkFlowNode();			
			req.delegateNodeInfoValue = delegateNodeInfo;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deferWorkFlowNode(String flowId, int nodeId, String userDelayDateIso, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deferWorkFlowNode(flowId, nodeId, userDelayDateIso, lockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deferWorkFlowNode(String flowId, int nodeId, String userDelayDateIso, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deferWorkFlowNode req = new BRequest_IXServicePortIF_deferWorkFlowNode();			
			req.flowIdValue = flowId;
			req.nodeIdValue = nodeId;
			req.userDelayDateIsoValue = userDelayDateIso;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual String[] testAdapter(String fn, String[] @params) {
			BSyncResult<String[]> asyncResult = new BSyncResult<String[]>();			
			testAdapter(fn, @params, BAsyncResultHelper.ToDelegate<String[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void testAdapter(String fn, String[] @params, BAsyncResult<String[]> asyncResult) {
			BRequest_IXServicePortIF_testAdapter req = new BRequest_IXServicePortIF_testAdapter();			
			req.fnValue = fn;
			req.paramsValue = @params;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void unlinkSords(String fromId, String[] toIds, EloixClient.IndexServer.LinkSordZ linkZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			unlinkSords(fromId, toIds, linkZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void unlinkSords(String fromId, String[] toIds, EloixClient.IndexServer.LinkSordZ linkZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_unlinkSords req = new BRequest_IXServicePortIF_unlinkSords();			
			req.fromIdValue = fromId;
			req.toIdsValue = toIds;
			req.linkZValue = linkZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.CryptInfo[] checkoutCryptInfos(String[] ids, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.CryptInfo[]> asyncResult = new BSyncResult<EloixClient.IndexServer.CryptInfo[]>();			
			checkoutCryptInfos(ids, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.CryptInfo[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutCryptInfos(String[] ids, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.CryptInfo[]> asyncResult) {
			BRequest_IXServicePortIF_checkoutCryptInfos req = new BRequest_IXServicePortIF_checkoutCryptInfos();			
			req.idsValue = ids;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void checkinCryptInfos(EloixClient.IndexServer.CryptInfo[] cryptInfos, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			checkinCryptInfos(cryptInfos, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void checkinCryptInfos(EloixClient.IndexServer.CryptInfo[] cryptInfos, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_checkinCryptInfos req = new BRequest_IXServicePortIF_checkinCryptInfos();			
			req.cryptInfosValue = cryptInfos;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void provideCryptPassword(String encryptionSet, String pwd) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			provideCryptPassword(encryptionSet, pwd, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void provideCryptPassword(String encryptionSet, String pwd, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_provideCryptPassword req = new BRequest_IXServicePortIF_provideCryptPassword();			
			req.encryptionSetValue = encryptionSet;
			req.pwdValue = pwd;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void invalidateCache(int flags) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			invalidateCache(flags, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void invalidateCache(int flags, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_invalidateCache req = new BRequest_IXServicePortIF_invalidateCache();			
			req.flagsValue = flags;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.InvalidateCacheResult invalidateCache2(EloixClient.IndexServer.InvalidateCacheInfo info) {
			BSyncResult<EloixClient.IndexServer.InvalidateCacheResult> asyncResult = new BSyncResult<EloixClient.IndexServer.InvalidateCacheResult>();			
			invalidateCache2(info, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.InvalidateCacheResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void invalidateCache2(EloixClient.IndexServer.InvalidateCacheInfo info, BAsyncResult<EloixClient.IndexServer.InvalidateCacheResult> asyncResult) {
			BRequest_IXServicePortIF_invalidateCache2 req = new BRequest_IXServicePortIF_invalidateCache2();			
			req.infoValue = info;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findFirstTranslateTerms(EloixClient.IndexServer.FindTranslateTermInfo findInfo, int max) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findFirstTranslateTerms(findInfo, max, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findFirstTranslateTerms(EloixClient.IndexServer.FindTranslateTermInfo findInfo, int max, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findFirstTranslateTerms req = new BRequest_IXServicePortIF_findFirstTranslateTerms();			
			req.findInfoValue = findInfo;
			req.maxValue = max;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findNextTranslateTerms(String searchId, int idx, int max) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findNextTranslateTerms(searchId, idx, max, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findNextTranslateTerms(String searchId, int idx, int max, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findNextTranslateTerms req = new BRequest_IXServicePortIF_findNextTranslateTerms();			
			req.searchIdValue = searchId;
			req.idxValue = idx;
			req.maxValue = max;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.TranslateTerm[] checkoutTranslateTerms(String[] termIds, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.TranslateTerm[]> asyncResult = new BSyncResult<EloixClient.IndexServer.TranslateTerm[]>();			
			checkoutTranslateTerms(termIds, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.TranslateTerm[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutTranslateTerms(String[] termIds, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.TranslateTerm[]> asyncResult) {
			BRequest_IXServicePortIF_checkoutTranslateTerms req = new BRequest_IXServicePortIF_checkoutTranslateTerms();			
			req.termIdsValue = termIds;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual String[] checkinTranslateTerms(EloixClient.IndexServer.TranslateTerm[] tterms, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<String[]> asyncResult = new BSyncResult<String[]>();			
			checkinTranslateTerms(tterms, unlockZ, BAsyncResultHelper.ToDelegate<String[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinTranslateTerms(EloixClient.IndexServer.TranslateTerm[] tterms, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<String[]> asyncResult) {
			BRequest_IXServicePortIF_checkinTranslateTerms req = new BRequest_IXServicePortIF_checkinTranslateTerms();			
			req.ttermsValue = tterms;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteTranslateTerms(String[] termIds, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteTranslateTerms(termIds, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteTranslateTerms(String[] termIds, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteTranslateTerms req = new BRequest_IXServicePortIF_deleteTranslateTerms();			
			req.termIdsValue = termIds;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.WFVersion[] getWorkflowTemplateVersions(String flowId, bool onlyDeleted) {
			BSyncResult<EloixClient.IndexServer.WFVersion[]> asyncResult = new BSyncResult<EloixClient.IndexServer.WFVersion[]>();			
			getWorkflowTemplateVersions(flowId, onlyDeleted, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.WFVersion[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getWorkflowTemplateVersions(String flowId, bool onlyDeleted, BAsyncResult<EloixClient.IndexServer.WFVersion[]> asyncResult) {
			BRequest_IXServicePortIF_getWorkflowTemplateVersions req = new BRequest_IXServicePortIF_getWorkflowTemplateVersions();			
			req.flowIdValue = flowId;
			req.onlyDeletedValue = onlyDeleted;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.WFDiagram checkoutWorkflowTemplate(String flowId, String versionId, EloixClient.IndexServer.WFDiagramZ wfZ, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.WFDiagram> asyncResult = new BSyncResult<EloixClient.IndexServer.WFDiagram>();			
			checkoutWorkflowTemplate(flowId, versionId, wfZ, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.WFDiagram>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutWorkflowTemplate(String flowId, String versionId, EloixClient.IndexServer.WFDiagramZ wfZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.WFDiagram> asyncResult) {
			BRequest_IXServicePortIF_checkoutWorkflowTemplate req = new BRequest_IXServicePortIF_checkoutWorkflowTemplate();			
			req.flowIdValue = flowId;
			req.versionIdValue = versionId;
			req.wfZValue = wfZ;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int[] checkinWorkflowTemplate(EloixClient.IndexServer.WFDiagram wf, EloixClient.IndexServer.WFDiagramZ wfZ, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<int[]> asyncResult = new BSyncResult<int[]>();			
			checkinWorkflowTemplate(wf, wfZ, unlockZ, BAsyncResultHelper.ToDelegate<int[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinWorkflowTemplate(EloixClient.IndexServer.WFDiagram wf, EloixClient.IndexServer.WFDiagramZ wfZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<int[]> asyncResult) {
			BRequest_IXServicePortIF_checkinWorkflowTemplate req = new BRequest_IXServicePortIF_checkinWorkflowTemplate();			
			req.wfValue = wf;
			req.wfZValue = wfZ;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteWorkflowTemplate(String flowId, String versionId, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteWorkflowTemplate(flowId, versionId, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteWorkflowTemplate(String flowId, String versionId, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteWorkflowTemplate req = new BRequest_IXServicePortIF_deleteWorkflowTemplate();			
			req.flowIdValue = flowId;
			req.versionIdValue = versionId;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.NoteTemplate[] checkoutNoteTemplates(String userId, String[] ids, EloixClient.IndexServer.NoteTemplateZ ntemplZ, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.NoteTemplate[]> asyncResult = new BSyncResult<EloixClient.IndexServer.NoteTemplate[]>();			
			checkoutNoteTemplates(userId, ids, ntemplZ, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.NoteTemplate[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutNoteTemplates(String userId, String[] ids, EloixClient.IndexServer.NoteTemplateZ ntemplZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.NoteTemplate[]> asyncResult) {
			BRequest_IXServicePortIF_checkoutNoteTemplates req = new BRequest_IXServicePortIF_checkoutNoteTemplates();			
			req.userIdValue = userId;
			req.idsValue = ids;
			req.ntemplZValue = ntemplZ;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.NoteTemplate createNoteTemplate(String userId) {
			BSyncResult<EloixClient.IndexServer.NoteTemplate> asyncResult = new BSyncResult<EloixClient.IndexServer.NoteTemplate>();			
			createNoteTemplate(userId, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.NoteTemplate>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void createNoteTemplate(String userId, BAsyncResult<EloixClient.IndexServer.NoteTemplate> asyncResult) {
			BRequest_IXServicePortIF_createNoteTemplate req = new BRequest_IXServicePortIF_createNoteTemplate();			
			req.userIdValue = userId;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteNoteTemplates(String userId, String[] ids, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteNoteTemplates(userId, ids, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteNoteTemplates(String userId, String[] ids, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteNoteTemplates req = new BRequest_IXServicePortIF_deleteNoteTemplates();			
			req.userIdValue = userId;
			req.idsValue = ids;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int[] checkinNoteTemplates(EloixClient.IndexServer.NoteTemplate[] noteTemplates, EloixClient.IndexServer.NoteTemplateZ ntemplZ, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<int[]> asyncResult = new BSyncResult<int[]>();			
			checkinNoteTemplates(noteTemplates, ntemplZ, unlockZ, BAsyncResultHelper.ToDelegate<int[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinNoteTemplates(EloixClient.IndexServer.NoteTemplate[] noteTemplates, EloixClient.IndexServer.NoteTemplateZ ntemplZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<int[]> asyncResult) {
			BRequest_IXServicePortIF_checkinNoteTemplates req = new BRequest_IXServicePortIF_checkinNoteTemplates();			
			req.noteTemplatesValue = noteTemplates;
			req.ntemplZValue = ntemplZ;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void reload() {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			reload(BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void reload(BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_reload req = new BRequest_IXServicePortIF_reload();			
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void reloadScripts() {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			reloadScripts(BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void reloadScripts(BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_reloadScripts req = new BRequest_IXServicePortIF_reloadScripts();			
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual IDictionary<int,String> getCompiledScripts() {
			BSyncResult<IDictionary<int,String>> asyncResult = new BSyncResult<IDictionary<int,String>>();			
			getCompiledScripts(BAsyncResultHelper.ToDelegate<IDictionary<int,String>>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getCompiledScripts(BAsyncResult<IDictionary<int,String>> asyncResult) {
			BRequest_IXServicePortIF_getCompiledScripts req = new BRequest_IXServicePortIF_getCompiledScripts();			
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual String getScriptsToDebug() {
			BSyncResult<String> asyncResult = new BSyncResult<String>();			
			getScriptsToDebug(BAsyncResultHelper.ToDelegate<String>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getScriptsToDebug(BAsyncResult<String> asyncResult) {
			BRequest_IXServicePortIF_getScriptsToDebug req = new BRequest_IXServicePortIF_getScriptsToDebug();			
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void setScriptsToDebug(String scriptsToDebug) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			setScriptsToDebug(scriptsToDebug, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void setScriptsToDebug(String scriptsToDebug, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_setScriptsToDebug req = new BRequest_IXServicePortIF_setScriptsToDebug();			
			req.scriptsToDebugValue = scriptsToDebug;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int getDebuggerPort() {
			BSyncResult<int> asyncResult = new BSyncResult<int>();			
			getDebuggerPort(BAsyncResultHelper.ToDelegate<int>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getDebuggerPort(BAsyncResult<int> asyncResult) {
			BRequest_IXServicePortIF_getDebuggerPort req = new BRequest_IXServicePortIF_getDebuggerPort();			
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteKeywordList(String kwid, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteKeywordList(kwid, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteKeywordList(String kwid, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteKeywordList req = new BRequest_IXServicePortIF_deleteKeywordList();			
			req.kwidValue = kwid;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.KeywordList checkoutKeywordList(String kwid, EloixClient.IndexServer.KeywordZ keywordZ, int max, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.KeywordList> asyncResult = new BSyncResult<EloixClient.IndexServer.KeywordList>();			
			checkoutKeywordList(kwid, keywordZ, max, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.KeywordList>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutKeywordList(String kwid, EloixClient.IndexServer.KeywordZ keywordZ, int max, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.KeywordList> asyncResult) {
			BRequest_IXServicePortIF_checkoutKeywordList req = new BRequest_IXServicePortIF_checkoutKeywordList();			
			req.kwidValue = kwid;
			req.keywordZValue = keywordZ;
			req.maxValue = max;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void checkinKeywordList(EloixClient.IndexServer.KeywordList kwList, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			checkinKeywordList(kwList, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void checkinKeywordList(EloixClient.IndexServer.KeywordList kwList, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_checkinKeywordList req = new BRequest_IXServicePortIF_checkinKeywordList();			
			req.kwListValue = kwList;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.CombineAclResult combineAcl(EloixClient.IndexServer.AclItem[] lhs, EloixClient.IndexServer.AclItem[] rhs, EloixClient.IndexServer.CombineAclOptions options) {
			BSyncResult<EloixClient.IndexServer.CombineAclResult> asyncResult = new BSyncResult<EloixClient.IndexServer.CombineAclResult>();			
			combineAcl(lhs, rhs, options, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.CombineAclResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void combineAcl(EloixClient.IndexServer.AclItem[] lhs, EloixClient.IndexServer.AclItem[] rhs, EloixClient.IndexServer.CombineAclOptions options, BAsyncResult<EloixClient.IndexServer.CombineAclResult> asyncResult) {
			BRequest_IXServicePortIF_combineAcl req = new BRequest_IXServicePortIF_combineAcl();			
			req.lhsValue = lhs;
			req.rhsValue = rhs;
			req.optionsValue = options;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.AclAccessResult getAclAccess(EloixClient.IndexServer.AclAccessInfo aai) {
			BSyncResult<EloixClient.IndexServer.AclAccessResult> asyncResult = new BSyncResult<EloixClient.IndexServer.AclAccessResult>();			
			getAclAccess(aai, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.AclAccessResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getAclAccess(EloixClient.IndexServer.AclAccessInfo aai, BAsyncResult<EloixClient.IndexServer.AclAccessResult> asyncResult) {
			BRequest_IXServicePortIF_getAclAccess req = new BRequest_IXServicePortIF_getAclAccess();			
			req.aaiValue = aai;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.EditInfo[] getEditInfoFromESW(EloixClient.IndexServer.FileData[] fileDatas, EloixClient.IndexServer.EditInfoEswOptions eswOptions) {
			BSyncResult<EloixClient.IndexServer.EditInfo[]> asyncResult = new BSyncResult<EloixClient.IndexServer.EditInfo[]>();			
			getEditInfoFromESW(fileDatas, eswOptions, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.EditInfo[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getEditInfoFromESW(EloixClient.IndexServer.FileData[] fileDatas, EloixClient.IndexServer.EditInfoEswOptions eswOptions, BAsyncResult<EloixClient.IndexServer.EditInfo[]> asyncResult) {
			BRequest_IXServicePortIF_getEditInfoFromESW req = new BRequest_IXServicePortIF_getEditInfoFromESW();			
			req.fileDatasValue = fileDatas;
			req.eswOptionsValue = eswOptions;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FileData[] getESWFromEditInfo(EloixClient.IndexServer.EditInfo[] editInfos, EloixClient.IndexServer.EditInfoEswOptions eswOptions) {
			BSyncResult<EloixClient.IndexServer.FileData[]> asyncResult = new BSyncResult<EloixClient.IndexServer.FileData[]>();			
			getESWFromEditInfo(editInfos, eswOptions, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FileData[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getESWFromEditInfo(EloixClient.IndexServer.EditInfo[] editInfos, EloixClient.IndexServer.EditInfoEswOptions eswOptions, BAsyncResult<EloixClient.IndexServer.FileData[]> asyncResult) {
			BRequest_IXServicePortIF_getESWFromEditInfo req = new BRequest_IXServicePortIF_getESWFromEditInfo();			
			req.editInfosValue = editInfos;
			req.eswOptionsValue = eswOptions;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.LoginResult getSessionFromTicket(int options) {
			BSyncResult<EloixClient.IndexServer.LoginResult> asyncResult = new BSyncResult<EloixClient.IndexServer.LoginResult>();			
			getSessionFromTicket(options, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.LoginResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getSessionFromTicket(int options, BAsyncResult<EloixClient.IndexServer.LoginResult> asyncResult) {
			BRequest_IXServicePortIF_getSessionFromTicket req = new BRequest_IXServicePortIF_getSessionFromTicket();			
			req.optionsValue = options;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.SessionInfo[] getSessionInfos(EloixClient.IndexServer.SessionInfoParams @params) {
			BSyncResult<EloixClient.IndexServer.SessionInfo[]> asyncResult = new BSyncResult<EloixClient.IndexServer.SessionInfo[]>();			
			getSessionInfos(@params, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.SessionInfo[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getSessionInfos(EloixClient.IndexServer.SessionInfoParams @params, BAsyncResult<EloixClient.IndexServer.SessionInfo[]> asyncResult) {
			BRequest_IXServicePortIF_getSessionInfos req = new BRequest_IXServicePortIF_getSessionInfos();			
			req.paramsValue = @params;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.ExecuteScriptResult executeScript(EloixClient.IndexServer.ExecuteScriptParams @params) {
			BSyncResult<EloixClient.IndexServer.ExecuteScriptResult> asyncResult = new BSyncResult<EloixClient.IndexServer.ExecuteScriptResult>();			
			executeScript(@params, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.ExecuteScriptResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void executeScript(EloixClient.IndexServer.ExecuteScriptParams @params, BAsyncResult<EloixClient.IndexServer.ExecuteScriptResult> asyncResult) {
			BRequest_IXServicePortIF_executeScript req = new BRequest_IXServicePortIF_executeScript();			
			req.paramsValue = @params;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FileData exportWorkflow(EloixClient.IndexServer.WorkflowExportOptions wfExportOptions) {
			BSyncResult<EloixClient.IndexServer.FileData> asyncResult = new BSyncResult<EloixClient.IndexServer.FileData>();			
			exportWorkflow(wfExportOptions, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FileData>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void exportWorkflow(EloixClient.IndexServer.WorkflowExportOptions wfExportOptions, BAsyncResult<EloixClient.IndexServer.FileData> asyncResult) {
			BRequest_IXServicePortIF_exportWorkflow req = new BRequest_IXServicePortIF_exportWorkflow();			
			req.wfExportOptionsValue = wfExportOptions;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.ValuesOfObjKey getDistinctValuesOfObjKey(String okeyName, EloixClient.IndexServer.ValuesOfObjKeyOptions opts) {
			BSyncResult<EloixClient.IndexServer.ValuesOfObjKey> asyncResult = new BSyncResult<EloixClient.IndexServer.ValuesOfObjKey>();			
			getDistinctValuesOfObjKey(okeyName, opts, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.ValuesOfObjKey>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getDistinctValuesOfObjKey(String okeyName, EloixClient.IndexServer.ValuesOfObjKeyOptions opts, BAsyncResult<EloixClient.IndexServer.ValuesOfObjKey> asyncResult) {
			BRequest_IXServicePortIF_getDistinctValuesOfObjKey req = new BRequest_IXServicePortIF_getDistinctValuesOfObjKey();			
			req.okeyNameValue = okeyName;
			req.optsValue = opts;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.ArchiveStatistics getArchiveStatistics(long opts) {
			BSyncResult<EloixClient.IndexServer.ArchiveStatistics> asyncResult = new BSyncResult<EloixClient.IndexServer.ArchiveStatistics>();			
			getArchiveStatistics(opts, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.ArchiveStatistics>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getArchiveStatistics(long opts, BAsyncResult<EloixClient.IndexServer.ArchiveStatistics> asyncResult) {
			BRequest_IXServicePortIF_getArchiveStatistics req = new BRequest_IXServicePortIF_getArchiveStatistics();			
			req.optsValue = opts;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.MapDomain[] collectMapDomains() {
			BSyncResult<EloixClient.IndexServer.MapDomain[]> asyncResult = new BSyncResult<EloixClient.IndexServer.MapDomain[]>();			
			collectMapDomains(BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.MapDomain[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void collectMapDomains(BAsyncResult<EloixClient.IndexServer.MapDomain[]> asyncResult) {
			BRequest_IXServicePortIF_collectMapDomains req = new BRequest_IXServicePortIF_collectMapDomains();			
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void checkinMapDomain(EloixClient.IndexServer.MapDomain mapDomain, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			checkinMapDomain(mapDomain, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void checkinMapDomain(EloixClient.IndexServer.MapDomain mapDomain, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_checkinMapDomain req = new BRequest_IXServicePortIF_checkinMapDomain();			
			req.mapDomainValue = mapDomain;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.MapDomain checkoutMapDomain(String domainName, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.MapDomain> asyncResult = new BSyncResult<EloixClient.IndexServer.MapDomain>();			
			checkoutMapDomain(domainName, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.MapDomain>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutMapDomain(String domainName, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.MapDomain> asyncResult) {
			BRequest_IXServicePortIF_checkoutMapDomain req = new BRequest_IXServicePortIF_checkoutMapDomain();			
			req.domainNameValue = domainName;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteMapDomain(String domainName, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteMapDomain(domainName, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteMapDomain(String domainName, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteMapDomain req = new BRequest_IXServicePortIF_deleteMapDomain();			
			req.domainNameValue = domainName;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void checkinMap(String domainName, String id, int objId, EloixClient.IndexServer.KeyValue[] data, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			checkinMap(domainName, id, objId, data, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void checkinMap(String domainName, String id, int objId, EloixClient.IndexServer.KeyValue[] data, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_checkinMap req = new BRequest_IXServicePortIF_checkinMap();			
			req.domainNameValue = domainName;
			req.idValue = id;
			req.objIdValue = objId;
			req.dataValue = data;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.MapData checkoutMap(String domainName, String id, String[] keyNames, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.MapData> asyncResult = new BSyncResult<EloixClient.IndexServer.MapData>();			
			checkoutMap(domainName, id, keyNames, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.MapData>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutMap(String domainName, String id, String[] keyNames, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.MapData> asyncResult) {
			BRequest_IXServicePortIF_checkoutMap req = new BRequest_IXServicePortIF_checkoutMap();			
			req.domainNameValue = domainName;
			req.idValue = id;
			req.keyNamesValue = keyNames;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteMap(String domainName, String id, String[] keyNames, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteMap(domainName, id, keyNames, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteMap(String domainName, String id, String[] keyNames, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteMap req = new BRequest_IXServicePortIF_deleteMap();			
			req.domainNameValue = domainName;
			req.idValue = id;
			req.keyNamesValue = keyNames;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.ContextTerm[] getContextTerms(EloixClient.IndexServer.FindInfo findInfo, String field, int max) {
			BSyncResult<EloixClient.IndexServer.ContextTerm[]> asyncResult = new BSyncResult<EloixClient.IndexServer.ContextTerm[]>();			
			getContextTerms(findInfo, field, max, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.ContextTerm[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getContextTerms(EloixClient.IndexServer.FindInfo findInfo, String field, int max, BAsyncResult<EloixClient.IndexServer.ContextTerm[]> asyncResult) {
			BRequest_IXServicePortIF_getContextTerms req = new BRequest_IXServicePortIF_getContextTerms();			
			req.findInfoValue = findInfo;
			req.fieldValue = field;
			req.maxValue = max;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Any executeRegisteredFunction(String functionName, EloixClient.IndexServer.Any param) {
			BSyncResult<EloixClient.IndexServer.Any> asyncResult = new BSyncResult<EloixClient.IndexServer.Any>();			
			executeRegisteredFunction(functionName, param, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Any>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void executeRegisteredFunction(String functionName, EloixClient.IndexServer.Any param, BAsyncResult<EloixClient.IndexServer.Any> asyncResult) {
			BRequest_IXServicePortIF_executeRegisteredFunction req = new BRequest_IXServicePortIF_executeRegisteredFunction();			
			req.functionNameValue = functionName;
			req.paramValue = param;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual String executeRegisteredFunctionString(String functionName, String param) {
			BSyncResult<String> asyncResult = new BSyncResult<String>();			
			executeRegisteredFunctionString(functionName, param, BAsyncResultHelper.ToDelegate<String>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void executeRegisteredFunctionString(String functionName, String param, BAsyncResult<String> asyncResult) {
			BRequest_IXServicePortIF_executeRegisteredFunctionString req = new BRequest_IXServicePortIF_executeRegisteredFunctionString();			
			req.functionNameValue = functionName;
			req.paramValue = param;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual String[] getSearchTerms(EloixClient.IndexServer.FindInfo findInfo, int termType) {
			BSyncResult<String[]> asyncResult = new BSyncResult<String[]>();			
			getSearchTerms(findInfo, termType, BAsyncResultHelper.ToDelegate<String[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getSearchTerms(EloixClient.IndexServer.FindInfo findInfo, int termType, BAsyncResult<String[]> asyncResult) {
			BRequest_IXServicePortIF_getSearchTerms req = new BRequest_IXServicePortIF_getSearchTerms();			
			req.findInfoValue = findInfo;
			req.termTypeValue = termType;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int adminMode(int mode) {
			BSyncResult<int> asyncResult = new BSyncResult<int>();			
			adminMode(mode, BAsyncResultHelper.ToDelegate<int>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void adminMode(int mode, BAsyncResult<int> asyncResult) {
			BRequest_IXServicePortIF_adminMode req = new BRequest_IXServicePortIF_adminMode();			
			req.modeValue = mode;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FulltextConfig configureFulltext(String userId, EloixClient.IndexServer.FulltextConfig opts) {
			BSyncResult<EloixClient.IndexServer.FulltextConfig> asyncResult = new BSyncResult<EloixClient.IndexServer.FulltextConfig>();			
			configureFulltext(userId, opts, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FulltextConfig>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void configureFulltext(String userId, EloixClient.IndexServer.FulltextConfig opts, BAsyncResult<EloixClient.IndexServer.FulltextConfig> asyncResult) {
			BRequest_IXServicePortIF_configureFulltext req = new BRequest_IXServicePortIF_configureFulltext();			
			req.userIdValue = userId;
			req.optsValue = opts;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.NotifyServerResult notifyServer(EloixClient.IndexServer.NotifyServerInfo msg) {
			BSyncResult<EloixClient.IndexServer.NotifyServerResult> asyncResult = new BSyncResult<EloixClient.IndexServer.NotifyServerResult>();			
			notifyServer(msg, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.NotifyServerResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void notifyServer(EloixClient.IndexServer.NotifyServerInfo msg, BAsyncResult<EloixClient.IndexServer.NotifyServerResult> asyncResult) {
			BRequest_IXServicePortIF_notifyServer req = new BRequest_IXServicePortIF_notifyServer();			
			req.msgValue = msg;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.BackupProfile[] configureBackup(EloixClient.IndexServer.BackupProfile[] backupProfiles) {
			BSyncResult<EloixClient.IndexServer.BackupProfile[]> asyncResult = new BSyncResult<EloixClient.IndexServer.BackupProfile[]>();			
			configureBackup(backupProfiles, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.BackupProfile[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void configureBackup(EloixClient.IndexServer.BackupProfile[] backupProfiles, BAsyncResult<EloixClient.IndexServer.BackupProfile[]> asyncResult) {
			BRequest_IXServicePortIF_configureBackup req = new BRequest_IXServicePortIF_configureBackup();			
			req.backupProfilesValue = backupProfiles;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.BackupPurgeStatus controlBackup(EloixClient.IndexServer.ControlBackupInfo controlBackupInfo) {
			BSyncResult<EloixClient.IndexServer.BackupPurgeStatus> asyncResult = new BSyncResult<EloixClient.IndexServer.BackupPurgeStatus>();			
			controlBackup(controlBackupInfo, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.BackupPurgeStatus>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void controlBackup(EloixClient.IndexServer.ControlBackupInfo controlBackupInfo, BAsyncResult<EloixClient.IndexServer.BackupPurgeStatus> asyncResult) {
			BRequest_IXServicePortIF_controlBackup req = new BRequest_IXServicePortIF_controlBackup();			
			req.controlBackupInfoValue = controlBackupInfo;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.PurgeSettings configurePurge(EloixClient.IndexServer.PurgeSettings purgeSettings) {
			BSyncResult<EloixClient.IndexServer.PurgeSettings> asyncResult = new BSyncResult<EloixClient.IndexServer.PurgeSettings>();			
			configurePurge(purgeSettings, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.PurgeSettings>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void configurePurge(EloixClient.IndexServer.PurgeSettings purgeSettings, BAsyncResult<EloixClient.IndexServer.PurgeSettings> asyncResult) {
			BRequest_IXServicePortIF_configurePurge req = new BRequest_IXServicePortIF_configurePurge();			
			req.purgeSettingsValue = purgeSettings;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual String addUrlParams(String url, EloixClient.IndexServer.UrlParams @params) {
			BSyncResult<String> asyncResult = new BSyncResult<String>();			
			addUrlParams(url, @params, BAsyncResultHelper.ToDelegate<String>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void addUrlParams(String url, EloixClient.IndexServer.UrlParams @params, BAsyncResult<String> asyncResult) {
			BRequest_IXServicePortIF_addUrlParams req = new BRequest_IXServicePortIF_addUrlParams();			
			req.urlValue = url;
			req.paramsValue = @params;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual long openEventBus(EloixClient.IndexServer.EventBusParams @params) {
			BSyncResult<long> asyncResult = new BSyncResult<long>();			
			openEventBus(@params, BAsyncResultHelper.ToDelegate<long>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void openEventBus(EloixClient.IndexServer.EventBusParams @params, BAsyncResult<long> asyncResult) {
			BRequest_IXServicePortIF_openEventBus req = new BRequest_IXServicePortIF_openEventBus();			
			req.paramsValue = @params;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void closeEventBus(long busId) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			closeEventBus(busId, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void closeEventBus(long busId, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_closeEventBus req = new BRequest_IXServicePortIF_closeEventBus();			
			req.busIdValue = busId;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual long createEventBusSubscriber() {
			BSyncResult<long> asyncResult = new BSyncResult<long>();			
			createEventBusSubscriber(BAsyncResultHelper.ToDelegate<long>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void createEventBusSubscriber(BAsyncResult<long> asyncResult) {
			BRequest_IXServicePortIF_createEventBusSubscriber req = new BRequest_IXServicePortIF_createEventBusSubscriber();			
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteEventBusSubscriber(long subsId) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteEventBusSubscriber(subsId, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteEventBusSubscriber(long subsId, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteEventBusSubscriber req = new BRequest_IXServicePortIF_deleteEventBusSubscriber();			
			req.subsIdValue = subsId;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual long createEventBusListener(long subsId, EloixClient.IndexServer.EventListener eventListener) {
			BSyncResult<long> asyncResult = new BSyncResult<long>();			
			createEventBusListener(subsId, eventListener, BAsyncResultHelper.ToDelegate<long>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void createEventBusListener(long subsId, EloixClient.IndexServer.EventListener eventListener, BAsyncResult<long> asyncResult) {
			BRequest_IXServicePortIF_createEventBusListener req = new BRequest_IXServicePortIF_createEventBusListener();			
			req.subsIdValue = subsId;
			req.eventListenerValue = eventListener;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteEventBusListener(long lsnId) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteEventBusListener(lsnId, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteEventBusListener(long lsnId, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteEventBusListener req = new BRequest_IXServicePortIF_deleteEventBusListener();			
			req.lsnIdValue = lsnId;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Event[] internalReceiveEvents(long subsId, long timeoutMillis) {
			BSyncResult<EloixClient.IndexServer.Event[]> asyncResult = new BSyncResult<EloixClient.IndexServer.Event[]>();			
			internalReceiveEvents(subsId, timeoutMillis, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Event[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void internalReceiveEvents(long subsId, long timeoutMillis, BAsyncResult<EloixClient.IndexServer.Event[]> asyncResult) {
			BRequest_IXServicePortIF_internalReceiveEvents req = new BRequest_IXServicePortIF_internalReceiveEvents();			
			req.subsIdValue = subsId;
			req.timeoutMillisValue = timeoutMillis;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void sendEvents(long subsId, EloixClient.IndexServer.Event[] events) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			sendEvents(subsId, events, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void sendEvents(long subsId, EloixClient.IndexServer.Event[] events, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_sendEvents req = new BRequest_IXServicePortIF_sendEvents();			
			req.subsIdValue = subsId;
			req.eventsValue = events;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual String[] createRsaKeys() {
			BSyncResult<String[]> asyncResult = new BSyncResult<String[]>();			
			createRsaKeys(BAsyncResultHelper.ToDelegate<String[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void createRsaKeys(BAsyncResult<String[]> asyncResult) {
			BRequest_IXServicePortIF_createRsaKeys req = new BRequest_IXServicePortIF_createRsaKeys();			
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual String encryptStringRsa(String key, String data, bool encryptNotDecrypt) {
			BSyncResult<String> asyncResult = new BSyncResult<String>();			
			encryptStringRsa(key, data, encryptNotDecrypt, BAsyncResultHelper.ToDelegate<String>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void encryptStringRsa(String key, String data, bool encryptNotDecrypt, BAsyncResult<String> asyncResult) {
			BRequest_IXServicePortIF_encryptStringRsa req = new BRequest_IXServicePortIF_encryptStringRsa();			
			req.keyValue = key;
			req.dataValue = data;
			req.encryptNotDecryptValue = encryptNotDecrypt;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.ActivityProject createActivityProject(String projectName) {
			BSyncResult<EloixClient.IndexServer.ActivityProject> asyncResult = new BSyncResult<EloixClient.IndexServer.ActivityProject>();			
			createActivityProject(projectName, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.ActivityProject>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void createActivityProject(String projectName, BAsyncResult<EloixClient.IndexServer.ActivityProject> asyncResult) {
			BRequest_IXServicePortIF_createActivityProject req = new BRequest_IXServicePortIF_createActivityProject();			
			req.projectNameValue = projectName;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual String checkinActivityProject(EloixClient.IndexServer.ActivityProject actProj, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<String> asyncResult = new BSyncResult<String>();			
			checkinActivityProject(actProj, unlockZ, BAsyncResultHelper.ToDelegate<String>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinActivityProject(EloixClient.IndexServer.ActivityProject actProj, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<String> asyncResult) {
			BRequest_IXServicePortIF_checkinActivityProject req = new BRequest_IXServicePortIF_checkinActivityProject();			
			req.actProjValue = actProj;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.ActivityProject checkoutActivityProject(String projectName, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.ActivityProject> asyncResult = new BSyncResult<EloixClient.IndexServer.ActivityProject>();			
			checkoutActivityProject(projectName, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.ActivityProject>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutActivityProject(String projectName, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.ActivityProject> asyncResult) {
			BRequest_IXServicePortIF_checkoutActivityProject req = new BRequest_IXServicePortIF_checkoutActivityProject();			
			req.projectNameValue = projectName;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteActivityProject(String projectName, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteActivityProject(projectName, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteActivityProject(String projectName, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteActivityProject req = new BRequest_IXServicePortIF_deleteActivityProject();			
			req.projectNameValue = projectName;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.ActivityProject[] findActivityProjects(EloixClient.IndexServer.FindActivityProjectsInfo findInfo) {
			BSyncResult<EloixClient.IndexServer.ActivityProject[]> asyncResult = new BSyncResult<EloixClient.IndexServer.ActivityProject[]>();			
			findActivityProjects(findInfo, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.ActivityProject[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findActivityProjects(EloixClient.IndexServer.FindActivityProjectsInfo findInfo, BAsyncResult<EloixClient.IndexServer.ActivityProject[]> asyncResult) {
			BRequest_IXServicePortIF_findActivityProjects req = new BRequest_IXServicePortIF_findActivityProjects();			
			req.findInfoValue = findInfo;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Activity createActivity(String projectName, String objId) {
			BSyncResult<EloixClient.IndexServer.Activity> asyncResult = new BSyncResult<EloixClient.IndexServer.Activity>();			
			createActivity(projectName, objId, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Activity>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void createActivity(String projectName, String objId, BAsyncResult<EloixClient.IndexServer.Activity> asyncResult) {
			BRequest_IXServicePortIF_createActivity req = new BRequest_IXServicePortIF_createActivity();			
			req.projectNameValue = projectName;
			req.objIdValue = objId;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual String checkinActivity(EloixClient.IndexServer.Activity act, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<String> asyncResult = new BSyncResult<String>();			
			checkinActivity(act, unlockZ, BAsyncResultHelper.ToDelegate<String>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinActivity(EloixClient.IndexServer.Activity act, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<String> asyncResult) {
			BRequest_IXServicePortIF_checkinActivity req = new BRequest_IXServicePortIF_checkinActivity();			
			req.actValue = act;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteActivity(String actGuid, EloixClient.IndexServer.DeleteActivityOptions deleteOptions, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteActivity(actGuid, deleteOptions, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteActivity(String actGuid, EloixClient.IndexServer.DeleteActivityOptions deleteOptions, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteActivity req = new BRequest_IXServicePortIF_deleteActivity();			
			req.actGuidValue = actGuid;
			req.deleteOptionsValue = deleteOptions;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Activity checkoutActivity(String actGuid, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.Activity> asyncResult = new BSyncResult<EloixClient.IndexServer.Activity>();			
			checkoutActivity(actGuid, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Activity>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutActivity(String actGuid, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.Activity> asyncResult) {
			BRequest_IXServicePortIF_checkoutActivity req = new BRequest_IXServicePortIF_checkoutActivity();			
			req.actGuidValue = actGuid;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findFirstActivities(EloixClient.IndexServer.FindActivityInfo findInfo, int max, EloixClient.IndexServer.ActivityZ activityZ) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findFirstActivities(findInfo, max, activityZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findFirstActivities(EloixClient.IndexServer.FindActivityInfo findInfo, int max, EloixClient.IndexServer.ActivityZ activityZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findFirstActivities req = new BRequest_IXServicePortIF_findFirstActivities();			
			req.findInfoValue = findInfo;
			req.maxValue = max;
			req.activityZValue = activityZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findNextActivities(String searchId, int idx, int max, EloixClient.IndexServer.ActivityZ activityZ) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findNextActivities(searchId, idx, max, activityZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findNextActivities(String searchId, int idx, int max, EloixClient.IndexServer.ActivityZ activityZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findNextActivities req = new BRequest_IXServicePortIF_findNextActivities();			
			req.searchIdValue = searchId;
			req.idxValue = idx;
			req.maxValue = max;
			req.activityZValue = activityZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.OcrWorker registerOcrWorker(EloixClient.IndexServer.OcrWorker ocrWorker) {
			BSyncResult<EloixClient.IndexServer.OcrWorker> asyncResult = new BSyncResult<EloixClient.IndexServer.OcrWorker>();			
			registerOcrWorker(ocrWorker, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.OcrWorker>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void registerOcrWorker(EloixClient.IndexServer.OcrWorker ocrWorker, BAsyncResult<EloixClient.IndexServer.OcrWorker> asyncResult) {
			BRequest_IXServicePortIF_registerOcrWorker req = new BRequest_IXServicePortIF_registerOcrWorker();			
			req.ocrWorkerValue = ocrWorker;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.OcrResult processOcr(EloixClient.IndexServer.OcrInfo ocrInfo) {
			BSyncResult<EloixClient.IndexServer.OcrResult> asyncResult = new BSyncResult<EloixClient.IndexServer.OcrResult>();			
			processOcr(ocrInfo, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.OcrResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void processOcr(EloixClient.IndexServer.OcrInfo ocrInfo, BAsyncResult<EloixClient.IndexServer.OcrResult> asyncResult) {
			BRequest_IXServicePortIF_processOcr req = new BRequest_IXServicePortIF_processOcr();			
			req.ocrInfoValue = ocrInfo;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.AutoFilingResult evalAutoFiling(String maskId, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.AutoFilingOptions opts) {
			BSyncResult<EloixClient.IndexServer.AutoFilingResult> asyncResult = new BSyncResult<EloixClient.IndexServer.AutoFilingResult>();			
			evalAutoFiling(maskId, sord, opts, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.AutoFilingResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void evalAutoFiling(String maskId, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.AutoFilingOptions opts, BAsyncResult<EloixClient.IndexServer.AutoFilingResult> asyncResult) {
			BRequest_IXServicePortIF_evalAutoFiling req = new BRequest_IXServicePortIF_evalAutoFiling();			
			req.maskIdValue = maskId;
			req.sordValue = sord;
			req.optsValue = opts;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.MapHist[] checkoutMapHistory(String domainName, String mapId, EloixClient.IndexServer.MapHistZ membersZ) {
			BSyncResult<EloixClient.IndexServer.MapHist[]> asyncResult = new BSyncResult<EloixClient.IndexServer.MapHist[]>();			
			checkoutMapHistory(domainName, mapId, membersZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.MapHist[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutMapHistory(String domainName, String mapId, EloixClient.IndexServer.MapHistZ membersZ, BAsyncResult<EloixClient.IndexServer.MapHist[]> asyncResult) {
			BRequest_IXServicePortIF_checkoutMapHistory req = new BRequest_IXServicePortIF_checkoutMapHistory();			
			req.domainNameValue = domainName;
			req.mapIdValue = mapId;
			req.membersZValue = membersZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Document checkinDocBegin2(EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Document document, EloixClient.IndexServer.CheckinDocOptions opts) {
			BSyncResult<EloixClient.IndexServer.Document> asyncResult = new BSyncResult<EloixClient.IndexServer.Document>();			
			checkinDocBegin2(sord, document, opts, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Document>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinDocBegin2(EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Document document, EloixClient.IndexServer.CheckinDocOptions opts, BAsyncResult<EloixClient.IndexServer.Document> asyncResult) {
			BRequest_IXServicePortIF_checkinDocBegin2 req = new BRequest_IXServicePortIF_checkinDocBegin2();			
			req.sordValue = sord;
			req.documentValue = document;
			req.optsValue = opts;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.JobState controlBackgroundThread(EloixClient.IndexServer.JobState jobState) {
			BSyncResult<EloixClient.IndexServer.JobState> asyncResult = new BSyncResult<EloixClient.IndexServer.JobState>();			
			controlBackgroundThread(jobState, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.JobState>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void controlBackgroundThread(EloixClient.IndexServer.JobState jobState, BAsyncResult<EloixClient.IndexServer.JobState> asyncResult) {
			BRequest_IXServicePortIF_controlBackgroundThread req = new BRequest_IXServicePortIF_controlBackgroundThread();			
			req.jobStateValue = jobState;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findBackgroundThreads(EloixClient.IndexServer.FindBackgroundThreadOptions findBackgroundThreadOptions) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findBackgroundThreads(findBackgroundThreadOptions, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findBackgroundThreads(EloixClient.IndexServer.FindBackgroundThreadOptions findBackgroundThreadOptions, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findBackgroundThreads req = new BRequest_IXServicePortIF_findBackgroundThreads();			
			req.findBackgroundThreadOptionsValue = findBackgroundThreadOptions;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.QueryJobProtocolResult queryJobProtocol(EloixClient.IndexServer.QueryJobProtocolInfo queryJobProtocolInfo) {
			BSyncResult<EloixClient.IndexServer.QueryJobProtocolResult> asyncResult = new BSyncResult<EloixClient.IndexServer.QueryJobProtocolResult>();			
			queryJobProtocol(queryJobProtocolInfo, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.QueryJobProtocolResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void queryJobProtocol(EloixClient.IndexServer.QueryJobProtocolInfo queryJobProtocolInfo, BAsyncResult<EloixClient.IndexServer.QueryJobProtocolResult> asyncResult) {
			BRequest_IXServicePortIF_queryJobProtocol req = new BRequest_IXServicePortIF_queryJobProtocol();			
			req.queryJobProtocolInfoValue = queryJobProtocolInfo;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.KeywordsDynamicResult checkoutKeywordsDynamic(EloixClient.IndexServer.KeywordsDynamicInfo keywordsDynamicInfo) {
			BSyncResult<EloixClient.IndexServer.KeywordsDynamicResult> asyncResult = new BSyncResult<EloixClient.IndexServer.KeywordsDynamicResult>();			
			checkoutKeywordsDynamic(keywordsDynamicInfo, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.KeywordsDynamicResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutKeywordsDynamic(EloixClient.IndexServer.KeywordsDynamicInfo keywordsDynamicInfo, BAsyncResult<EloixClient.IndexServer.KeywordsDynamicResult> asyncResult) {
			BRequest_IXServicePortIF_checkoutKeywordsDynamic req = new BRequest_IXServicePortIF_checkoutKeywordsDynamic();			
			req.keywordsDynamicInfoValue = keywordsDynamicInfo;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.SordPaths checkoutSordPath(String objId, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.CheckoutSordPathInfo csi) {
			BSyncResult<EloixClient.IndexServer.SordPaths> asyncResult = new BSyncResult<EloixClient.IndexServer.SordPaths>();			
			checkoutSordPath(objId, sordZ, csi, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.SordPaths>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutSordPath(String objId, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.CheckoutSordPathInfo csi, BAsyncResult<EloixClient.IndexServer.SordPaths> asyncResult) {
			BRequest_IXServicePortIF_checkoutSordPath req = new BRequest_IXServicePortIF_checkoutSordPath();			
			req.objIdValue = objId;
			req.sordZValue = sordZ;
			req.csiValue = csi;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.PreviewImageResult checkoutPreviewImageURLs(EloixClient.IndexServer.PreviewImageInfo previewImageInfo) {
			BSyncResult<EloixClient.IndexServer.PreviewImageResult> asyncResult = new BSyncResult<EloixClient.IndexServer.PreviewImageResult>();			
			checkoutPreviewImageURLs(previewImageInfo, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.PreviewImageResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutPreviewImageURLs(EloixClient.IndexServer.PreviewImageInfo previewImageInfo, BAsyncResult<EloixClient.IndexServer.PreviewImageResult> asyncResult) {
			BRequest_IXServicePortIF_checkoutPreviewImageURLs req = new BRequest_IXServicePortIF_checkoutPreviewImageURLs();			
			req.previewImageInfoValue = previewImageInfo;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.ApplyForNotificationsInfo applyForNotifications(EloixClient.IndexServer.ApplyForNotificationsInfo info) {
			BSyncResult<EloixClient.IndexServer.ApplyForNotificationsInfo> asyncResult = new BSyncResult<EloixClient.IndexServer.ApplyForNotificationsInfo>();			
			applyForNotifications(info, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.ApplyForNotificationsInfo>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void applyForNotifications(EloixClient.IndexServer.ApplyForNotificationsInfo info, BAsyncResult<EloixClient.IndexServer.ApplyForNotificationsInfo> asyncResult) {
			BRequest_IXServicePortIF_applyForNotifications req = new BRequest_IXServicePortIF_applyForNotifications();			
			req.infoValue = info;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual IList<EloixClient.IndexServer.PublicDownload> getPublicDownloads(EloixClient.IndexServer.PublicDownloadOptions opts) {
			BSyncResult<IList<EloixClient.IndexServer.PublicDownload>> asyncResult = new BSyncResult<IList<EloixClient.IndexServer.PublicDownload>>();			
			getPublicDownloads(opts, BAsyncResultHelper.ToDelegate<IList<EloixClient.IndexServer.PublicDownload>>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getPublicDownloads(EloixClient.IndexServer.PublicDownloadOptions opts, BAsyncResult<IList<EloixClient.IndexServer.PublicDownload>> asyncResult) {
			BRequest_IXServicePortIF_getPublicDownloads req = new BRequest_IXServicePortIF_getPublicDownloads();			
			req.optsValue = opts;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void terminatePublicDownloadUrls(EloixClient.IndexServer.PublicDownloadOptions opts) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			terminatePublicDownloadUrls(opts, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void terminatePublicDownloadUrls(EloixClient.IndexServer.PublicDownloadOptions opts, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_terminatePublicDownloadUrls req = new BRequest_IXServicePortIF_terminatePublicDownloadUrls();			
			req.optsValue = opts;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void editPublicDownloadUrls(EloixClient.IndexServer.PublicDownloadOptions opts) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			editPublicDownloadUrls(opts, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void editPublicDownloadUrls(EloixClient.IndexServer.PublicDownloadOptions opts, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_editPublicDownloadUrls req = new BRequest_IXServicePortIF_editPublicDownloadUrls();			
			req.optsValue = opts;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual IList<EloixClient.IndexServer.ResolveRightsResult> resolveRights(EloixClient.IndexServer.UserInfo ui, EloixClient.IndexServer.ResolveRightsInfo info) {
			BSyncResult<IList<EloixClient.IndexServer.ResolveRightsResult>> asyncResult = new BSyncResult<IList<EloixClient.IndexServer.ResolveRightsResult>>();			
			resolveRights(ui, info, BAsyncResultHelper.ToDelegate<IList<EloixClient.IndexServer.ResolveRightsResult>>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void resolveRights(EloixClient.IndexServer.UserInfo ui, EloixClient.IndexServer.ResolveRightsInfo info, BAsyncResult<IList<EloixClient.IndexServer.ResolveRightsResult>> asyncResult) {
			BRequest_IXServicePortIF_resolveRights req = new BRequest_IXServicePortIF_resolveRights();			
			req.uiValue = ui;
			req.infoValue = info;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int startAdHocWorkFlow2(String name, String objId, EloixClient.IndexServer.UserNodeInfo[] userNodeInfo, EloixClient.IndexServer.StartAdHocWorkflowInfo startWfInfo) {
			BSyncResult<int> asyncResult = new BSyncResult<int>();			
			startAdHocWorkFlow2(name, objId, userNodeInfo, startWfInfo, BAsyncResultHelper.ToDelegate<int>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void startAdHocWorkFlow2(String name, String objId, EloixClient.IndexServer.UserNodeInfo[] userNodeInfo, EloixClient.IndexServer.StartAdHocWorkflowInfo startWfInfo, BAsyncResult<int> asyncResult) {
			BRequest_IXServicePortIF_startAdHocWorkFlow2 req = new BRequest_IXServicePortIF_startAdHocWorkFlow2();			
			req.nameValue = name;
			req.objIdValue = objId;
			req.userNodeInfoValue = userNodeInfo;
			req.startWfInfoValue = startWfInfo;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int startAdHocWorkFlow3(String name, String objId, EloixClient.IndexServer.StartAdHocWorkflowInfo startWfInfo) {
			BSyncResult<int> asyncResult = new BSyncResult<int>();			
			startAdHocWorkFlow3(name, objId, startWfInfo, BAsyncResultHelper.ToDelegate<int>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void startAdHocWorkFlow3(String name, String objId, EloixClient.IndexServer.StartAdHocWorkflowInfo startWfInfo, BAsyncResult<int> asyncResult) {
			BRequest_IXServicePortIF_startAdHocWorkFlow3 req = new BRequest_IXServicePortIF_startAdHocWorkFlow3();			
			req.nameValue = name;
			req.objIdValue = objId;
			req.startWfInfoValue = startWfInfo;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.PublicDownload insertPublicDownload(EloixClient.IndexServer.PublicDownloadOptions opts) {
			BSyncResult<EloixClient.IndexServer.PublicDownload> asyncResult = new BSyncResult<EloixClient.IndexServer.PublicDownload>();			
			insertPublicDownload(opts, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.PublicDownload>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void insertPublicDownload(EloixClient.IndexServer.PublicDownloadOptions opts, BAsyncResult<EloixClient.IndexServer.PublicDownload> asyncResult) {
			BRequest_IXServicePortIF_insertPublicDownload req = new BRequest_IXServicePortIF_insertPublicDownload();			
			req.optsValue = opts;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Subscription createSubscription(String watchGuid) {
			BSyncResult<EloixClient.IndexServer.Subscription> asyncResult = new BSyncResult<EloixClient.IndexServer.Subscription>();			
			createSubscription(watchGuid, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Subscription>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void createSubscription(String watchGuid, BAsyncResult<EloixClient.IndexServer.Subscription> asyncResult) {
			BRequest_IXServicePortIF_createSubscription req = new BRequest_IXServicePortIF_createSubscription();			
			req.watchGuidValue = watchGuid;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Subscription checkinSubscription(EloixClient.IndexServer.Subscription subs, EloixClient.IndexServer.SubscriptionZ subsZ) {
			BSyncResult<EloixClient.IndexServer.Subscription> asyncResult = new BSyncResult<EloixClient.IndexServer.Subscription>();			
			checkinSubscription(subs, subsZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Subscription>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinSubscription(EloixClient.IndexServer.Subscription subs, EloixClient.IndexServer.SubscriptionZ subsZ, BAsyncResult<EloixClient.IndexServer.Subscription> asyncResult) {
			BRequest_IXServicePortIF_checkinSubscription req = new BRequest_IXServicePortIF_checkinSubscription();			
			req.subsValue = subs;
			req.subsZValue = subsZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteSubscription(EloixClient.IndexServer.Subscription subs) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteSubscription(subs, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteSubscription(EloixClient.IndexServer.Subscription subs, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteSubscription req = new BRequest_IXServicePortIF_deleteSubscription();			
			req.subsValue = subs;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findFirstSubscriptions(EloixClient.IndexServer.FindSubscriptionInfo findInfo, int max, EloixClient.IndexServer.SubscriptionZ subsZ) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findFirstSubscriptions(findInfo, max, subsZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findFirstSubscriptions(EloixClient.IndexServer.FindSubscriptionInfo findInfo, int max, EloixClient.IndexServer.SubscriptionZ subsZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findFirstSubscriptions req = new BRequest_IXServicePortIF_findFirstSubscriptions();			
			req.findInfoValue = findInfo;
			req.maxValue = max;
			req.subsZValue = subsZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findNextSubscriptions(String searchId, int idx, int max, EloixClient.IndexServer.SubscriptionZ subsZ) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findNextSubscriptions(searchId, idx, max, subsZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findNextSubscriptions(String searchId, int idx, int max, EloixClient.IndexServer.SubscriptionZ subsZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findNextSubscriptions req = new BRequest_IXServicePortIF_findNextSubscriptions();			
			req.searchIdValue = searchId;
			req.idxValue = idx;
			req.maxValue = max;
			req.subsZValue = subsZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findFirstNotes(EloixClient.IndexServer.FindInfo findInfo, int max, EloixClient.IndexServer.NoteZ noteZ) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findFirstNotes(findInfo, max, noteZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findFirstNotes(EloixClient.IndexServer.FindInfo findInfo, int max, EloixClient.IndexServer.NoteZ noteZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findFirstNotes req = new BRequest_IXServicePortIF_findFirstNotes();			
			req.findInfoValue = findInfo;
			req.maxValue = max;
			req.noteZValue = noteZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findNextNotes(String searchId, int idx, int max, EloixClient.IndexServer.NoteZ noteZ) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findNextNotes(searchId, idx, max, noteZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findNextNotes(String searchId, int idx, int max, EloixClient.IndexServer.NoteZ noteZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findNextNotes req = new BRequest_IXServicePortIF_findNextNotes();			
			req.searchIdValue = searchId;
			req.idxValue = idx;
			req.maxValue = max;
			req.noteZValue = noteZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void checkinReport(EloixClient.IndexServer.ReportInfo report, EloixClient.IndexServer.CheckinReportInfo reserved, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			checkinReport(report, reserved, lockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void checkinReport(EloixClient.IndexServer.ReportInfo report, EloixClient.IndexServer.CheckinReportInfo reserved, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_checkinReport req = new BRequest_IXServicePortIF_checkinReport();			
			req.reportValue = report;
			req.reservedValue = reserved;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void linkSords2(String fromId, String[] toIds, EloixClient.IndexServer.LinkSordZ linkSordZ, EloixClient.IndexServer.LinkSordInfo linkSordInfo) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			linkSords2(fromId, toIds, linkSordZ, linkSordInfo, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void linkSords2(String fromId, String[] toIds, EloixClient.IndexServer.LinkSordZ linkSordZ, EloixClient.IndexServer.LinkSordInfo linkSordInfo, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_linkSords2 req = new BRequest_IXServicePortIF_linkSords2();			
			req.fromIdValue = fromId;
			req.toIdsValue = toIds;
			req.linkSordZValue = linkSordZ;
			req.linkSordInfoValue = linkSordInfo;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual String getWebDAVPathFromObjID(String objId) {
			BSyncResult<String> asyncResult = new BSyncResult<String>();			
			getWebDAVPathFromObjID(objId, BAsyncResultHelper.ToDelegate<String>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getWebDAVPathFromObjID(String objId, BAsyncResult<String> asyncResult) {
			BRequest_IXServicePortIF_getWebDAVPathFromObjID req = new BRequest_IXServicePortIF_getWebDAVPathFromObjID();			
			req.objIdValue = objId;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.GetWebDAVPathResult getWebDAVPathFromObjID2(EloixClient.IndexServer.GetWebDAVPathOptions options) {
			BSyncResult<EloixClient.IndexServer.GetWebDAVPathResult> asyncResult = new BSyncResult<EloixClient.IndexServer.GetWebDAVPathResult>();			
			getWebDAVPathFromObjID2(options, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.GetWebDAVPathResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getWebDAVPathFromObjID2(EloixClient.IndexServer.GetWebDAVPathOptions options, BAsyncResult<EloixClient.IndexServer.GetWebDAVPathResult> asyncResult) {
			BRequest_IXServicePortIF_getWebDAVPathFromObjID2 req = new BRequest_IXServicePortIF_getWebDAVPathFromObjID2();			
			req.optionsValue = options;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.CheckoutWorkflowHistoryResult checkoutWorkflowHistory(EloixClient.IndexServer.CheckoutWorkflowHistoryParams checkoutWorkflowHistoryParams) {
			BSyncResult<EloixClient.IndexServer.CheckoutWorkflowHistoryResult> asyncResult = new BSyncResult<EloixClient.IndexServer.CheckoutWorkflowHistoryResult>();			
			checkoutWorkflowHistory(checkoutWorkflowHistoryParams, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.CheckoutWorkflowHistoryResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutWorkflowHistory(EloixClient.IndexServer.CheckoutWorkflowHistoryParams checkoutWorkflowHistoryParams, BAsyncResult<EloixClient.IndexServer.CheckoutWorkflowHistoryResult> asyncResult) {
			BRequest_IXServicePortIF_checkoutWorkflowHistory req = new BRequest_IXServicePortIF_checkoutWorkflowHistory();			
			req.checkoutWorkflowHistoryParamsValue = checkoutWorkflowHistoryParams;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual int checkinDocMaskLineTemplate(EloixClient.IndexServer.DocMaskLineTemplate dmlt, EloixClient.IndexServer.DocMaskLineTemplateZ dmltZ, EloixClient.IndexServer.CheckInDocMaskLineTemplateOptions options, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<int> asyncResult = new BSyncResult<int>();			
			checkinDocMaskLineTemplate(dmlt, dmltZ, options, lockZ, BAsyncResultHelper.ToDelegate<int>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkinDocMaskLineTemplate(EloixClient.IndexServer.DocMaskLineTemplate dmlt, EloixClient.IndexServer.DocMaskLineTemplateZ dmltZ, EloixClient.IndexServer.CheckInDocMaskLineTemplateOptions options, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<int> asyncResult) {
			BRequest_IXServicePortIF_checkinDocMaskLineTemplate req = new BRequest_IXServicePortIF_checkinDocMaskLineTemplate();			
			req.dmltValue = dmlt;
			req.dmltZValue = dmltZ;
			req.optionsValue = options;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.DocMaskLineTemplate[] checkoutDocMaskLineTemplates(String[] groups, EloixClient.IndexServer.DocMaskLineTemplateZ dmltZ, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.DocMaskLineTemplate[]> asyncResult = new BSyncResult<EloixClient.IndexServer.DocMaskLineTemplate[]>();			
			checkoutDocMaskLineTemplates(groups, dmltZ, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.DocMaskLineTemplate[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkoutDocMaskLineTemplates(String[] groups, EloixClient.IndexServer.DocMaskLineTemplateZ dmltZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.DocMaskLineTemplate[]> asyncResult) {
			BRequest_IXServicePortIF_checkoutDocMaskLineTemplates req = new BRequest_IXServicePortIF_checkoutDocMaskLineTemplates();			
			req.groupsValue = groups;
			req.dmltZValue = dmltZ;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void deleteDocMaskLineTemplates(String[] groups, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			deleteDocMaskLineTemplates(groups, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void deleteDocMaskLineTemplates(String[] groups, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServicePortIF_deleteDocMaskLineTemplates req = new BRequest_IXServicePortIF_deleteDocMaskLineTemplates();			
			req.groupsValue = groups;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.WFEditNode beginForwardWorkflowNode(int flowId, int nodeId, EloixClient.IndexServer.BeginForwardWorkflowNodeInfo fwdInfo, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<EloixClient.IndexServer.WFEditNode> asyncResult = new BSyncResult<EloixClient.IndexServer.WFEditNode>();			
			beginForwardWorkflowNode(flowId, nodeId, fwdInfo, lockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.WFEditNode>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void beginForwardWorkflowNode(int flowId, int nodeId, EloixClient.IndexServer.BeginForwardWorkflowNodeInfo fwdInfo, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.WFEditNode> asyncResult) {
			BRequest_IXServicePortIF_beginForwardWorkflowNode req = new BRequest_IXServicePortIF_beginForwardWorkflowNode();			
			req.flowIdValue = flowId;
			req.nodeIdValue = nodeId;
			req.fwdInfoValue = fwdInfo;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.ForwardWorkflowNodeResult forwardWorkflowNode(int flowId, int nodeId, EloixClient.IndexServer.ForwardWorkflowNodeInfo fwdInfo, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<EloixClient.IndexServer.ForwardWorkflowNodeResult> asyncResult = new BSyncResult<EloixClient.IndexServer.ForwardWorkflowNodeResult>();			
			forwardWorkflowNode(flowId, nodeId, fwdInfo, unlockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.ForwardWorkflowNodeResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void forwardWorkflowNode(int flowId, int nodeId, EloixClient.IndexServer.ForwardWorkflowNodeInfo fwdInfo, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<EloixClient.IndexServer.ForwardWorkflowNodeResult> asyncResult) {
			BRequest_IXServicePortIF_forwardWorkflowNode req = new BRequest_IXServicePortIF_forwardWorkflowNode();			
			req.flowIdValue = flowId;
			req.nodeIdValue = nodeId;
			req.fwdInfoValue = fwdInfo;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findFirstUsers(EloixClient.IndexServer.FindUserInfo findUserInfo, int max) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findFirstUsers(findUserInfo, max, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findFirstUsers(EloixClient.IndexServer.FindUserInfo findUserInfo, int max, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findFirstUsers req = new BRequest_IXServicePortIF_findFirstUsers();			
			req.findUserInfoValue = findUserInfo;
			req.maxValue = max;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.FindResult findNextUsers(String searchId, int idx, int max) {
			BSyncResult<EloixClient.IndexServer.FindResult> asyncResult = new BSyncResult<EloixClient.IndexServer.FindResult>();			
			findNextUsers(searchId, idx, max, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.FindResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void findNextUsers(String searchId, int idx, int max, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) {
			BRequest_IXServicePortIF_findNextUsers req = new BRequest_IXServicePortIF_findNextUsers();			
			req.searchIdValue = searchId;
			req.idxValue = idx;
			req.maxValue = max;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.LicenseResult checkLicense(EloixClient.IndexServer.LicenseInfo licenseInfo) {
			BSyncResult<EloixClient.IndexServer.LicenseResult> asyncResult = new BSyncResult<EloixClient.IndexServer.LicenseResult>();			
			checkLicense(licenseInfo, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.LicenseResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void checkLicense(EloixClient.IndexServer.LicenseInfo licenseInfo, BAsyncResult<EloixClient.IndexServer.LicenseResult> asyncResult) {
			BRequest_IXServicePortIF_checkLicense req = new BRequest_IXServicePortIF_checkLicense();			
			req.licenseInfoValue = licenseInfo;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.JobState moveDocuments(EloixClient.IndexServer.MoveDocumentsInfo moveDocumentsInfo) {
			BSyncResult<EloixClient.IndexServer.JobState> asyncResult = new BSyncResult<EloixClient.IndexServer.JobState>();			
			moveDocuments(moveDocumentsInfo, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.JobState>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void moveDocuments(EloixClient.IndexServer.MoveDocumentsInfo moveDocumentsInfo, BAsyncResult<EloixClient.IndexServer.JobState> asyncResult) {
			BRequest_IXServicePortIF_moveDocuments req = new BRequest_IXServicePortIF_moveDocuments();			
			req.moveDocumentsInfoValue = moveDocumentsInfo;
			transport.sendMethod(req, asyncResult);
		}
		
		
	}
}
