using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BStub_IXServerEvents : BStub, IXServerEvents, BSerializable {	
		
		public readonly static long serialVersionUID = 1938363825L;
		
		public BStub_IXServerEvents(BTransport transport)
			: base(transport) {}			
		
		public virtual String getAppInfo(EloixClient.IndexServer.IXServerEventsContext ec) {
			BSyncResult<String> asyncResult = new BSyncResult<String>();			
			getAppInfo(ec, BAsyncResultHelper.ToDelegate<String>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getAppInfo(EloixClient.IndexServer.IXServerEventsContext ec, BAsyncResult<String> asyncResult) {
			BRequest_IXServerEvents_getAppInfo req = new BRequest_IXServerEvents_getAppInfo();			
			req.ecValue = ec;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual bool hasMethod(EloixClient.IndexServer.IXServerEventsContext ec, String methodName) {
			BSyncResult<bool> asyncResult = new BSyncResult<bool>();			
			hasMethod(ec, methodName, BAsyncResultHelper.ToDelegate<bool>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void hasMethod(EloixClient.IndexServer.IXServerEventsContext ec, String methodName, BAsyncResult<bool> asyncResult) {
			BRequest_IXServerEvents_hasMethod req = new BRequest_IXServerEvents_hasMethod();			
			req.ecValue = ec;
			req.methodNameValue = methodName;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onBeforeCheckinSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onBeforeCheckinSord(ec, sord, sordDB, parentSord, sordZ, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onBeforeCheckinSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onBeforeCheckinSord req = new BRequest_IXServerEvents_onBeforeCheckinSord();			
			req.ecValue = ec;
			req.sordValue = sord;
			req.sordDBValue = sordDB;
			req.parentSordValue = parentSord;
			req.sordZValue = sordZ;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onAfterCheckinSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onAfterCheckinSord(ec, sord, sordDB, parentSord, sordZ, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onAfterCheckinSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onAfterCheckinSord req = new BRequest_IXServerEvents_onAfterCheckinSord();			
			req.ecValue = ec;
			req.sordValue = sord;
			req.sordDBValue = sordDB;
			req.parentSordValue = parentSord;
			req.sordZValue = sordZ;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onBeforeCheckinDocEnd(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Document doc, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onBeforeCheckinDocEnd(ec, sord, sordDB, parentSord, doc, sordZ, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onBeforeCheckinDocEnd(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Document doc, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onBeforeCheckinDocEnd req = new BRequest_IXServerEvents_onBeforeCheckinDocEnd();			
			req.ecValue = ec;
			req.sordValue = sord;
			req.sordDBValue = sordDB;
			req.parentSordValue = parentSord;
			req.docValue = doc;
			req.sordZValue = sordZ;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onAfterCheckinDocEnd(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Document doc, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onAfterCheckinDocEnd(ec, sord, sordDB, parentSord, doc, sordZ, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onAfterCheckinDocEnd(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Document doc, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onAfterCheckinDocEnd req = new BRequest_IXServerEvents_onAfterCheckinDocEnd();			
			req.ecValue = ec;
			req.sordValue = sord;
			req.sordDBValue = sordDB;
			req.parentSordValue = parentSord;
			req.docValue = doc;
			req.sordZValue = sordZ;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onBeforeDeleteSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.LockZ unlockZ, EloixClient.IndexServer.DeleteOptions delOpts) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onBeforeDeleteSord(ec, parentSord, sord, unlockZ, delOpts, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onBeforeDeleteSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.LockZ unlockZ, EloixClient.IndexServer.DeleteOptions delOpts, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onBeforeDeleteSord req = new BRequest_IXServerEvents_onBeforeDeleteSord();			
			req.ecValue = ec;
			req.parentSordValue = parentSord;
			req.sordValue = sord;
			req.unlockZValue = unlockZ;
			req.delOptsValue = delOpts;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onAfterDeleteSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.LockZ unlockZ, EloixClient.IndexServer.DeleteOptions delOpts, bool ret) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onAfterDeleteSord(ec, parentSord, sord, unlockZ, delOpts, ret, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onAfterDeleteSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.LockZ unlockZ, EloixClient.IndexServer.DeleteOptions delOpts, bool ret, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onAfterDeleteSord req = new BRequest_IXServerEvents_onAfterDeleteSord();			
			req.ecValue = ec;
			req.parentSordValue = parentSord;
			req.sordValue = sord;
			req.unlockZValue = unlockZ;
			req.delOptsValue = delOpts;
			req.retValue = ret;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onBeforeRefSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSordOld, EloixClient.IndexServer.Sord parentSordNew, EloixClient.IndexServer.Sord sord, int manSortIndex) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onBeforeRefSord(ec, parentSordOld, parentSordNew, sord, manSortIndex, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onBeforeRefSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSordOld, EloixClient.IndexServer.Sord parentSordNew, EloixClient.IndexServer.Sord sord, int manSortIndex, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onBeforeRefSord req = new BRequest_IXServerEvents_onBeforeRefSord();			
			req.ecValue = ec;
			req.parentSordOldValue = parentSordOld;
			req.parentSordNewValue = parentSordNew;
			req.sordValue = sord;
			req.manSortIndexValue = manSortIndex;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onAfterRefSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSordOld, EloixClient.IndexServer.Sord parentSordNew, EloixClient.IndexServer.Sord sord, int manSortIndex) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onAfterRefSord(ec, parentSordOld, parentSordNew, sord, manSortIndex, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onAfterRefSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSordOld, EloixClient.IndexServer.Sord parentSordNew, EloixClient.IndexServer.Sord sord, int manSortIndex, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onAfterRefSord req = new BRequest_IXServerEvents_onAfterRefSord();			
			req.ecValue = ec;
			req.parentSordOldValue = parentSordOld;
			req.parentSordNewValue = parentSordNew;
			req.sordValue = sord;
			req.manSortIndexValue = manSortIndex;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onAfterEndEditWorkFlowNode(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, int nodeId, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onAfterEndEditWorkFlowNode(ec, workflow, nodeId, sord, sordZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onAfterEndEditWorkFlowNode(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, int nodeId, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onAfterEndEditWorkFlowNode req = new BRequest_IXServerEvents_onAfterEndEditWorkFlowNode();			
			req.ecValue = ec;
			req.workflowValue = workflow;
			req.nodeIdValue = nodeId;
			req.sordValue = sord;
			req.sordZValue = sordZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onAfterCheckinReminder(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Reminder[] remiArray, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onAfterCheckinReminder(ec, remiArray, sord, sordZ, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onAfterCheckinReminder(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Reminder[] remiArray, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onAfterCheckinReminder req = new BRequest_IXServerEvents_onAfterCheckinReminder();			
			req.ecValue = ec;
			req.remiArrayValue = remiArray;
			req.sordValue = sord;
			req.sordZValue = sordZ;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.Any executeRegisteredFunction(EloixClient.IndexServer.IXServerEventsContext ec, String functionName, EloixClient.IndexServer.Any any) {
			BSyncResult<EloixClient.IndexServer.Any> asyncResult = new BSyncResult<EloixClient.IndexServer.Any>();			
			executeRegisteredFunction(ec, functionName, any, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.Any>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void executeRegisteredFunction(EloixClient.IndexServer.IXServerEventsContext ec, String functionName, EloixClient.IndexServer.Any any, BAsyncResult<EloixClient.IndexServer.Any> asyncResult) {
			BRequest_IXServerEvents_executeRegisteredFunction req = new BRequest_IXServerEvents_executeRegisteredFunction();			
			req.ecValue = ec;
			req.functionNameValue = functionName;
			req.anyValue = any;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual String executeRegisteredFunctionString(EloixClient.IndexServer.IXServerEventsContext ec, String functionName, String args) {
			BSyncResult<String> asyncResult = new BSyncResult<String>();			
			executeRegisteredFunctionString(ec, functionName, args, BAsyncResultHelper.ToDelegate<String>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void executeRegisteredFunctionString(EloixClient.IndexServer.IXServerEventsContext ec, String functionName, String args, BAsyncResult<String> asyncResult) {
			BRequest_IXServerEvents_executeRegisteredFunctionString req = new BRequest_IXServerEvents_executeRegisteredFunctionString();			
			req.ecValue = ec;
			req.functionNameValue = functionName;
			req.argsValue = args;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onBeforeStartWorkFlow(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onBeforeStartWorkFlow(ec, workflow, sord, sordZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onBeforeStartWorkFlow(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onBeforeStartWorkFlow req = new BRequest_IXServerEvents_onBeforeStartWorkFlow();			
			req.ecValue = ec;
			req.workflowValue = workflow;
			req.sordValue = sord;
			req.sordZValue = sordZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onAfterStartWorkFlow(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onAfterStartWorkFlow(ec, workflow, sord, sordZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onAfterStartWorkFlow(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onAfterStartWorkFlow req = new BRequest_IXServerEvents_onAfterStartWorkFlow();			
			req.ecValue = ec;
			req.workflowValue = workflow;
			req.sordValue = sord;
			req.sordZValue = sordZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onBeforeCheckinActivity(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Activity act, bool isNew, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onBeforeCheckinActivity(ec, act, isNew, sord, sordZ, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onBeforeCheckinActivity(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Activity act, bool isNew, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onBeforeCheckinActivity req = new BRequest_IXServerEvents_onBeforeCheckinActivity();			
			req.ecValue = ec;
			req.actValue = act;
			req.isNewValue = isNew;
			req.sordValue = sord;
			req.sordZValue = sordZ;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onAfterCheckinActivity(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Activity act, bool isNew, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onAfterCheckinActivity(ec, act, isNew, sord, sordZ, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onAfterCheckinActivity(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Activity act, bool isNew, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onAfterCheckinActivity req = new BRequest_IXServerEvents_onAfterCheckinActivity();			
			req.ecValue = ec;
			req.actValue = act;
			req.isNewValue = isNew;
			req.sordValue = sord;
			req.sordZValue = sordZ;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onBeforeCheckinNotes(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Note[] notes, EloixClient.IndexServer.Sord[] sords, long noteC, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onBeforeCheckinNotes(ec, notes, sords, noteC, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onBeforeCheckinNotes(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Note[] notes, EloixClient.IndexServer.Sord[] sords, long noteC, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onBeforeCheckinNotes req = new BRequest_IXServerEvents_onBeforeCheckinNotes();			
			req.ecValue = ec;
			req.notesValue = notes;
			req.sordsValue = sords;
			req.noteCValue = noteC;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onAfterCheckinNotes(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Note[] notes, EloixClient.IndexServer.Sord[] sords, long noteC, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onAfterCheckinNotes(ec, notes, sords, noteC, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onAfterCheckinNotes(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Note[] notes, EloixClient.IndexServer.Sord[] sords, long noteC, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onAfterCheckinNotes req = new BRequest_IXServerEvents_onAfterCheckinNotes();			
			req.ecValue = ec;
			req.notesValue = notes;
			req.sordsValue = sords;
			req.noteCValue = noteC;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onFileUploadBuildResponse(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.DocVersion dv, String fileName, EloixClient.IndexServer.HttpRequestInfo requestInfo, EloixClient.IndexServer.HttpResponseInfo responseInfo) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onFileUploadBuildResponse(ec, dv, fileName, requestInfo, responseInfo, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onFileUploadBuildResponse(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.DocVersion dv, String fileName, EloixClient.IndexServer.HttpRequestInfo requestInfo, EloixClient.IndexServer.HttpResponseInfo responseInfo, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onFileUploadBuildResponse req = new BRequest_IXServerEvents_onFileUploadBuildResponse();			
			req.ecValue = ec;
			req.dvValue = dv;
			req.fileNameValue = fileName;
			req.requestInfoValue = requestInfo;
			req.responseInfoValue = responseInfo;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.UserName[] getUserNames(EloixClient.IndexServer.IXServerEventsContext ec, String[] ids, EloixClient.IndexServer.CheckoutUsersZ checkoutUsersZ) {
			BSyncResult<EloixClient.IndexServer.UserName[]> asyncResult = new BSyncResult<EloixClient.IndexServer.UserName[]>();			
			getUserNames(ec, ids, checkoutUsersZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.UserName[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void getUserNames(EloixClient.IndexServer.IXServerEventsContext ec, String[] ids, EloixClient.IndexServer.CheckoutUsersZ checkoutUsersZ, BAsyncResult<EloixClient.IndexServer.UserName[]> asyncResult) {
			BRequest_IXServerEvents_getUserNames req = new BRequest_IXServerEvents_getUserNames();			
			req.ecValue = ec;
			req.idsValue = ids;
			req.checkoutUsersZValue = checkoutUsersZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onReadSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.Document doc, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onReadSord(ec, sord, sordZ, doc, lockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onReadSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.Document doc, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onReadSord req = new BRequest_IXServerEvents_onReadSord();			
			req.ecValue = ec;
			req.sordValue = sord;
			req.sordZValue = sordZ;
			req.docValue = doc;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual bool onCheckSordAccess(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, int lur, EloixClient.IndexServer.CheckAccessOptions opts) {
			BSyncResult<bool> asyncResult = new BSyncResult<bool>();			
			onCheckSordAccess(ec, sord, sordZ, lur, opts, BAsyncResultHelper.ToDelegate<bool>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void onCheckSordAccess(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, int lur, EloixClient.IndexServer.CheckAccessOptions opts, BAsyncResult<bool> asyncResult) {
			BRequest_IXServerEvents_onCheckSordAccess req = new BRequest_IXServerEvents_onCheckSordAccess();			
			req.ecValue = ec;
			req.sordValue = sord;
			req.sordZValue = sordZ;
			req.lurValue = lur;
			req.optsValue = opts;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onBeforeLogin(EloixClient.IndexServer.IXServerEventsContext ec, String userName, EloixClient.IndexServer.LoginScriptOptions opts) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onBeforeLogin(ec, userName, opts, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onBeforeLogin(EloixClient.IndexServer.IXServerEventsContext ec, String userName, EloixClient.IndexServer.LoginScriptOptions opts, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onBeforeLogin req = new BRequest_IXServerEvents_onBeforeLogin();			
			req.ecValue = ec;
			req.userNameValue = userName;
			req.optsValue = opts;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onAfterLogin(EloixClient.IndexServer.IXServerEventsContext ec, String userName, EloixClient.IndexServer.LoginScriptOptions opts) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onAfterLogin(ec, userName, opts, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onAfterLogin(EloixClient.IndexServer.IXServerEventsContext ec, String userName, EloixClient.IndexServer.LoginScriptOptions opts, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onAfterLogin req = new BRequest_IXServerEvents_onAfterLogin();			
			req.ecValue = ec;
			req.userNameValue = userName;
			req.optsValue = opts;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.EditInfo onCreateSord(EloixClient.IndexServer.IXServerEventsContext ec, String parentId, String maskId, EloixClient.IndexServer.EditInfoZ editZ) {
			BSyncResult<EloixClient.IndexServer.EditInfo> asyncResult = new BSyncResult<EloixClient.IndexServer.EditInfo>();			
			onCreateSord(ec, parentId, maskId, editZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.EditInfo>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void onCreateSord(EloixClient.IndexServer.IXServerEventsContext ec, String parentId, String maskId, EloixClient.IndexServer.EditInfoZ editZ, BAsyncResult<EloixClient.IndexServer.EditInfo> asyncResult) {
			BRequest_IXServerEvents_onCreateSord req = new BRequest_IXServerEvents_onCreateSord();			
			req.ecValue = ec;
			req.parentIdValue = parentId;
			req.maskIdValue = maskId;
			req.editZValue = editZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.EditInfo onCreateDoc(EloixClient.IndexServer.IXServerEventsContext ec, String parentId, String maskId, String docTemplate, EloixClient.IndexServer.EditInfoZ editInfoZ) {
			BSyncResult<EloixClient.IndexServer.EditInfo> asyncResult = new BSyncResult<EloixClient.IndexServer.EditInfo>();			
			onCreateDoc(ec, parentId, maskId, docTemplate, editInfoZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.EditInfo>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void onCreateDoc(EloixClient.IndexServer.IXServerEventsContext ec, String parentId, String maskId, String docTemplate, EloixClient.IndexServer.EditInfoZ editInfoZ, BAsyncResult<EloixClient.IndexServer.EditInfo> asyncResult) {
			BRequest_IXServerEvents_onCreateDoc req = new BRequest_IXServerEvents_onCreateDoc();			
			req.ecValue = ec;
			req.parentIdValue = parentId;
			req.maskIdValue = maskId;
			req.docTemplateValue = docTemplate;
			req.editInfoZValue = editInfoZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.UserInfo[] onBeforeCheckinUsers(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.UserInfo[] userInfos, EloixClient.IndexServer.CheckinUsersZ checkinUsersZ, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<EloixClient.IndexServer.UserInfo[]> asyncResult = new BSyncResult<EloixClient.IndexServer.UserInfo[]>();			
			onBeforeCheckinUsers(ec, userInfos, checkinUsersZ, unlockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.UserInfo[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void onBeforeCheckinUsers(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.UserInfo[] userInfos, EloixClient.IndexServer.CheckinUsersZ checkinUsersZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<EloixClient.IndexServer.UserInfo[]> asyncResult) {
			BRequest_IXServerEvents_onBeforeCheckinUsers req = new BRequest_IXServerEvents_onBeforeCheckinUsers();			
			req.ecValue = ec;
			req.userInfosValue = userInfos;
			req.checkinUsersZValue = checkinUsersZ;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onAfterCheckinUsers(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.UserInfo[] userInfos, EloixClient.IndexServer.CheckinUsersZ checkinUsersZ, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onAfterCheckinUsers(ec, userInfos, checkinUsersZ, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onAfterCheckinUsers(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.UserInfo[] userInfos, EloixClient.IndexServer.CheckinUsersZ checkinUsersZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onAfterCheckinUsers req = new BRequest_IXServerEvents_onAfterCheckinUsers();			
			req.ecValue = ec;
			req.userInfosValue = userInfos;
			req.checkinUsersZValue = checkinUsersZ;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.KeyValue[] onBeforeCheckinMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, int objId, EloixClient.IndexServer.KeyValue[] data, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<EloixClient.IndexServer.KeyValue[]> asyncResult = new BSyncResult<EloixClient.IndexServer.KeyValue[]>();			
			onBeforeCheckinMap(ec, domainName, id, objId, data, unlockZ, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.KeyValue[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void onBeforeCheckinMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, int objId, EloixClient.IndexServer.KeyValue[] data, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<EloixClient.IndexServer.KeyValue[]> asyncResult) {
			BRequest_IXServerEvents_onBeforeCheckinMap req = new BRequest_IXServerEvents_onBeforeCheckinMap();			
			req.ecValue = ec;
			req.domainNameValue = domainName;
			req.idValue = id;
			req.objIdValue = objId;
			req.dataValue = data;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onAfterCheckinMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, int objId, EloixClient.IndexServer.KeyValue[] data, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onAfterCheckinMap(ec, domainName, id, objId, data, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onAfterCheckinMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, int objId, EloixClient.IndexServer.KeyValue[] data, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onAfterCheckinMap req = new BRequest_IXServerEvents_onAfterCheckinMap();			
			req.ecValue = ec;
			req.domainNameValue = domainName;
			req.idValue = id;
			req.objIdValue = objId;
			req.dataValue = data;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual String[] onBeforeDeleteMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, String[] keyNames, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<String[]> asyncResult = new BSyncResult<String[]>();			
			onBeforeDeleteMap(ec, domainName, id, keyNames, unlockZ, BAsyncResultHelper.ToDelegate<String[]>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void onBeforeDeleteMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, String[] keyNames, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<String[]> asyncResult) {
			BRequest_IXServerEvents_onBeforeDeleteMap req = new BRequest_IXServerEvents_onBeforeDeleteMap();			
			req.ecValue = ec;
			req.domainNameValue = domainName;
			req.idValue = id;
			req.keyNamesValue = keyNames;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onAfterDeleteMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, String[] keyNames, EloixClient.IndexServer.LockZ unlockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onAfterDeleteMap(ec, domainName, id, keyNames, unlockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onAfterDeleteMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, String[] keyNames, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onAfterDeleteMap req = new BRequest_IXServerEvents_onAfterDeleteMap();			
			req.ecValue = ec;
			req.domainNameValue = domainName;
			req.idValue = id;
			req.keyNamesValue = keyNames;
			req.unlockZValue = unlockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onBeforeTakeWorkFlowNode(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, EloixClient.IndexServer.WFNode node, EloixClient.IndexServer.UserInfo user, int flags, EloixClient.IndexServer.LockZ lockZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onBeforeTakeWorkFlowNode(ec, workflow, node, user, flags, lockZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onBeforeTakeWorkFlowNode(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, EloixClient.IndexServer.WFNode node, EloixClient.IndexServer.UserInfo user, int flags, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onBeforeTakeWorkFlowNode req = new BRequest_IXServerEvents_onBeforeTakeWorkFlowNode();			
			req.ecValue = ec;
			req.workflowValue = workflow;
			req.nodeValue = node;
			req.userValue = user;
			req.flagsValue = flags;
			req.lockZValue = lockZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onBeforeFindSords(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.FindInfo findInfo, EloixClient.IndexServer.SordZ sordZ) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onBeforeFindSords(ec, findInfo, sordZ, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onBeforeFindSords(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.FindInfo findInfo, EloixClient.IndexServer.SordZ sordZ, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onBeforeFindSords req = new BRequest_IXServerEvents_onBeforeFindSords();			
			req.ecValue = ec;
			req.findInfoValue = findInfo;
			req.sordZValue = sordZ;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onBeforeFindSordsInternalSQL(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.FindInfo findInfo, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.FindInfoAsInternalSQL findSql) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onBeforeFindSordsInternalSQL(ec, findInfo, sordZ, findSql, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onBeforeFindSordsInternalSQL(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.FindInfo findInfo, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.FindInfoAsInternalSQL findSql, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onBeforeFindSordsInternalSQL req = new BRequest_IXServerEvents_onBeforeFindSordsInternalSQL();			
			req.ecValue = ec;
			req.findInfoValue = findInfo;
			req.sordZValue = sordZ;
			req.findSqlValue = findSql;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onFindSordsResult(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.FindInfo findInfo, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.FindResult findResult) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onFindSordsResult(ec, findInfo, sordZ, findResult, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onFindSordsResult(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.FindInfo findInfo, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.FindResult findResult, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onFindSordsResult req = new BRequest_IXServerEvents_onFindSordsResult();			
			req.ecValue = ec;
			req.findInfoValue = findInfo;
			req.sordZValue = sordZ;
			req.findResultValue = findResult;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void onFindClose(EloixClient.IndexServer.IXServerEventsContext ec, Object findInfo) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			onFindClose(ec, findInfo, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void onFindClose(EloixClient.IndexServer.IXServerEventsContext ec, Object findInfo, BAsyncResult<Object> asyncResult) {
			BRequest_IXServerEvents_onFindClose req = new BRequest_IXServerEvents_onFindClose();			
			req.ecValue = ec;
			req.findInfoValue = findInfo;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual EloixClient.IndexServer.InheritKeywordingResult onInheritKeywording(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord parentSord, String[] okeyNames, Object reserved) {
			BSyncResult<EloixClient.IndexServer.InheritKeywordingResult> asyncResult = new BSyncResult<EloixClient.IndexServer.InheritKeywordingResult>();			
			onInheritKeywording(ec, sord, parentSord, okeyNames, reserved, BAsyncResultHelper.ToDelegate<EloixClient.IndexServer.InheritKeywordingResult>(asyncResult));
			return asyncResult.GetResult();			
		}
		public virtual void onInheritKeywording(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord parentSord, String[] okeyNames, Object reserved, BAsyncResult<EloixClient.IndexServer.InheritKeywordingResult> asyncResult) {
			BRequest_IXServerEvents_onInheritKeywording req = new BRequest_IXServerEvents_onInheritKeywording();			
			req.ecValue = ec;
			req.sordValue = sord;
			req.parentSordValue = parentSord;
			req.okeyNamesValue = okeyNames;
			req.reservedValue = reserved;
			transport.sendMethod(req, asyncResult);
		}
		
		
	}
}
