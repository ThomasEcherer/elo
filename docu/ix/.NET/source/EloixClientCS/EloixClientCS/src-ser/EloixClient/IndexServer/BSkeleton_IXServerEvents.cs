using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	/// <summary>
	/// This class provides a skeleton implementation of the interface IXServerEvents.
	/// </summary>
	/// <remark>
	/// Your interface implementation class has to be derived from this skeleton.
	/// Either provide an asynchronous or a synchronous function in your subclass.
	/// The framework calls only the asynchronous function.
	/// </remark>
	public class BSkeleton_IXServerEvents : BSkeleton, IXServerEvents {	
		
		public readonly static long serialVersionUID = 1938363825L;
		
		public virtual String getAppInfo(EloixClient.IndexServer.IXServerEventsContext ec) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void getAppInfo(EloixClient.IndexServer.IXServerEventsContext ec, BAsyncResult<String> asyncResult) {
			String __byps__ret = default(String);
			Exception __byps__ex = null;
			try {
				__byps__ret = getAppInfo(ec);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual bool hasMethod(EloixClient.IndexServer.IXServerEventsContext ec, String methodName) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void hasMethod(EloixClient.IndexServer.IXServerEventsContext ec, String methodName, BAsyncResult<bool> asyncResult) {
			bool __byps__ret = default(bool);
			Exception __byps__ex = null;
			try {
				__byps__ret = hasMethod(ec, methodName);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onBeforeCheckinSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onBeforeCheckinSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onBeforeCheckinSord(ec, sord, sordDB, parentSord, sordZ, unlockZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onAfterCheckinSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onAfterCheckinSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onAfterCheckinSord(ec, sord, sordDB, parentSord, sordZ, unlockZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onBeforeCheckinDocEnd(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Document doc, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onBeforeCheckinDocEnd(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Document doc, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onBeforeCheckinDocEnd(ec, sord, sordDB, parentSord, doc, sordZ, unlockZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onAfterCheckinDocEnd(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Document doc, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onAfterCheckinDocEnd(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Document doc, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onAfterCheckinDocEnd(ec, sord, sordDB, parentSord, doc, sordZ, unlockZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onBeforeDeleteSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.LockZ unlockZ, EloixClient.IndexServer.DeleteOptions delOpts) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onBeforeDeleteSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.LockZ unlockZ, EloixClient.IndexServer.DeleteOptions delOpts, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onBeforeDeleteSord(ec, parentSord, sord, unlockZ, delOpts);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onAfterDeleteSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.LockZ unlockZ, EloixClient.IndexServer.DeleteOptions delOpts, bool ret) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onAfterDeleteSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.LockZ unlockZ, EloixClient.IndexServer.DeleteOptions delOpts, bool ret, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onAfterDeleteSord(ec, parentSord, sord, unlockZ, delOpts, ret);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onBeforeRefSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSordOld, EloixClient.IndexServer.Sord parentSordNew, EloixClient.IndexServer.Sord sord, int manSortIndex) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onBeforeRefSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSordOld, EloixClient.IndexServer.Sord parentSordNew, EloixClient.IndexServer.Sord sord, int manSortIndex, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onBeforeRefSord(ec, parentSordOld, parentSordNew, sord, manSortIndex);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onAfterRefSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSordOld, EloixClient.IndexServer.Sord parentSordNew, EloixClient.IndexServer.Sord sord, int manSortIndex) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onAfterRefSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSordOld, EloixClient.IndexServer.Sord parentSordNew, EloixClient.IndexServer.Sord sord, int manSortIndex, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onAfterRefSord(ec, parentSordOld, parentSordNew, sord, manSortIndex);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onAfterEndEditWorkFlowNode(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, int nodeId, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onAfterEndEditWorkFlowNode(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, int nodeId, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onAfterEndEditWorkFlowNode(ec, workflow, nodeId, sord, sordZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onAfterCheckinReminder(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Reminder[] remiArray, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onAfterCheckinReminder(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Reminder[] remiArray, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onAfterCheckinReminder(ec, remiArray, sord, sordZ, unlockZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual EloixClient.IndexServer.Any executeRegisteredFunction(EloixClient.IndexServer.IXServerEventsContext ec, String functionName, EloixClient.IndexServer.Any any) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void executeRegisteredFunction(EloixClient.IndexServer.IXServerEventsContext ec, String functionName, EloixClient.IndexServer.Any any, BAsyncResult<EloixClient.IndexServer.Any> asyncResult) {
			EloixClient.IndexServer.Any __byps__ret = default(EloixClient.IndexServer.Any);
			Exception __byps__ex = null;
			try {
				__byps__ret = executeRegisteredFunction(ec, functionName, any);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual String executeRegisteredFunctionString(EloixClient.IndexServer.IXServerEventsContext ec, String functionName, String args) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void executeRegisteredFunctionString(EloixClient.IndexServer.IXServerEventsContext ec, String functionName, String args, BAsyncResult<String> asyncResult) {
			String __byps__ret = default(String);
			Exception __byps__ex = null;
			try {
				__byps__ret = executeRegisteredFunctionString(ec, functionName, args);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onBeforeStartWorkFlow(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onBeforeStartWorkFlow(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onBeforeStartWorkFlow(ec, workflow, sord, sordZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onAfterStartWorkFlow(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onAfterStartWorkFlow(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onAfterStartWorkFlow(ec, workflow, sord, sordZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onBeforeCheckinActivity(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Activity act, bool isNew, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onBeforeCheckinActivity(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Activity act, bool isNew, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onBeforeCheckinActivity(ec, act, isNew, sord, sordZ, unlockZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onAfterCheckinActivity(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Activity act, bool isNew, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onAfterCheckinActivity(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Activity act, bool isNew, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onAfterCheckinActivity(ec, act, isNew, sord, sordZ, unlockZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onBeforeCheckinNotes(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Note[] notes, EloixClient.IndexServer.Sord[] sords, long noteC, EloixClient.IndexServer.LockZ unlockZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onBeforeCheckinNotes(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Note[] notes, EloixClient.IndexServer.Sord[] sords, long noteC, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onBeforeCheckinNotes(ec, notes, sords, noteC, unlockZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onAfterCheckinNotes(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Note[] notes, EloixClient.IndexServer.Sord[] sords, long noteC, EloixClient.IndexServer.LockZ unlockZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onAfterCheckinNotes(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Note[] notes, EloixClient.IndexServer.Sord[] sords, long noteC, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onAfterCheckinNotes(ec, notes, sords, noteC, unlockZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onFileUploadBuildResponse(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.DocVersion dv, String fileName, EloixClient.IndexServer.HttpRequestInfo requestInfo, EloixClient.IndexServer.HttpResponseInfo responseInfo) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onFileUploadBuildResponse(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.DocVersion dv, String fileName, EloixClient.IndexServer.HttpRequestInfo requestInfo, EloixClient.IndexServer.HttpResponseInfo responseInfo, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onFileUploadBuildResponse(ec, dv, fileName, requestInfo, responseInfo);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual EloixClient.IndexServer.UserName[] getUserNames(EloixClient.IndexServer.IXServerEventsContext ec, String[] ids, EloixClient.IndexServer.CheckoutUsersZ checkoutUsersZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void getUserNames(EloixClient.IndexServer.IXServerEventsContext ec, String[] ids, EloixClient.IndexServer.CheckoutUsersZ checkoutUsersZ, BAsyncResult<EloixClient.IndexServer.UserName[]> asyncResult) {
			EloixClient.IndexServer.UserName[] __byps__ret = default(EloixClient.IndexServer.UserName[]);
			Exception __byps__ex = null;
			try {
				__byps__ret = getUserNames(ec, ids, checkoutUsersZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onReadSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.Document doc, EloixClient.IndexServer.LockZ lockZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onReadSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.Document doc, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onReadSord(ec, sord, sordZ, doc, lockZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual bool onCheckSordAccess(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, int lur, EloixClient.IndexServer.CheckAccessOptions opts) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onCheckSordAccess(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, int lur, EloixClient.IndexServer.CheckAccessOptions opts, BAsyncResult<bool> asyncResult) {
			bool __byps__ret = default(bool);
			Exception __byps__ex = null;
			try {
				__byps__ret = onCheckSordAccess(ec, sord, sordZ, lur, opts);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onBeforeLogin(EloixClient.IndexServer.IXServerEventsContext ec, String userName, EloixClient.IndexServer.LoginScriptOptions opts) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onBeforeLogin(EloixClient.IndexServer.IXServerEventsContext ec, String userName, EloixClient.IndexServer.LoginScriptOptions opts, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onBeforeLogin(ec, userName, opts);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onAfterLogin(EloixClient.IndexServer.IXServerEventsContext ec, String userName, EloixClient.IndexServer.LoginScriptOptions opts) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onAfterLogin(EloixClient.IndexServer.IXServerEventsContext ec, String userName, EloixClient.IndexServer.LoginScriptOptions opts, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onAfterLogin(ec, userName, opts);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual EloixClient.IndexServer.EditInfo onCreateSord(EloixClient.IndexServer.IXServerEventsContext ec, String parentId, String maskId, EloixClient.IndexServer.EditInfoZ editZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onCreateSord(EloixClient.IndexServer.IXServerEventsContext ec, String parentId, String maskId, EloixClient.IndexServer.EditInfoZ editZ, BAsyncResult<EloixClient.IndexServer.EditInfo> asyncResult) {
			EloixClient.IndexServer.EditInfo __byps__ret = default(EloixClient.IndexServer.EditInfo);
			Exception __byps__ex = null;
			try {
				__byps__ret = onCreateSord(ec, parentId, maskId, editZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual EloixClient.IndexServer.EditInfo onCreateDoc(EloixClient.IndexServer.IXServerEventsContext ec, String parentId, String maskId, String docTemplate, EloixClient.IndexServer.EditInfoZ editInfoZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onCreateDoc(EloixClient.IndexServer.IXServerEventsContext ec, String parentId, String maskId, String docTemplate, EloixClient.IndexServer.EditInfoZ editInfoZ, BAsyncResult<EloixClient.IndexServer.EditInfo> asyncResult) {
			EloixClient.IndexServer.EditInfo __byps__ret = default(EloixClient.IndexServer.EditInfo);
			Exception __byps__ex = null;
			try {
				__byps__ret = onCreateDoc(ec, parentId, maskId, docTemplate, editInfoZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual EloixClient.IndexServer.UserInfo[] onBeforeCheckinUsers(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.UserInfo[] userInfos, EloixClient.IndexServer.CheckinUsersZ checkinUsersZ, EloixClient.IndexServer.LockZ unlockZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onBeforeCheckinUsers(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.UserInfo[] userInfos, EloixClient.IndexServer.CheckinUsersZ checkinUsersZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<EloixClient.IndexServer.UserInfo[]> asyncResult) {
			EloixClient.IndexServer.UserInfo[] __byps__ret = default(EloixClient.IndexServer.UserInfo[]);
			Exception __byps__ex = null;
			try {
				__byps__ret = onBeforeCheckinUsers(ec, userInfos, checkinUsersZ, unlockZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onAfterCheckinUsers(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.UserInfo[] userInfos, EloixClient.IndexServer.CheckinUsersZ checkinUsersZ, EloixClient.IndexServer.LockZ unlockZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onAfterCheckinUsers(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.UserInfo[] userInfos, EloixClient.IndexServer.CheckinUsersZ checkinUsersZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onAfterCheckinUsers(ec, userInfos, checkinUsersZ, unlockZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual EloixClient.IndexServer.KeyValue[] onBeforeCheckinMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, int objId, EloixClient.IndexServer.KeyValue[] data, EloixClient.IndexServer.LockZ unlockZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onBeforeCheckinMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, int objId, EloixClient.IndexServer.KeyValue[] data, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<EloixClient.IndexServer.KeyValue[]> asyncResult) {
			EloixClient.IndexServer.KeyValue[] __byps__ret = default(EloixClient.IndexServer.KeyValue[]);
			Exception __byps__ex = null;
			try {
				__byps__ret = onBeforeCheckinMap(ec, domainName, id, objId, data, unlockZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onAfterCheckinMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, int objId, EloixClient.IndexServer.KeyValue[] data, EloixClient.IndexServer.LockZ unlockZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onAfterCheckinMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, int objId, EloixClient.IndexServer.KeyValue[] data, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onAfterCheckinMap(ec, domainName, id, objId, data, unlockZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual String[] onBeforeDeleteMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, String[] keyNames, EloixClient.IndexServer.LockZ unlockZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onBeforeDeleteMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, String[] keyNames, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<String[]> asyncResult) {
			String[] __byps__ret = default(String[]);
			Exception __byps__ex = null;
			try {
				__byps__ret = onBeforeDeleteMap(ec, domainName, id, keyNames, unlockZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onAfterDeleteMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, String[] keyNames, EloixClient.IndexServer.LockZ unlockZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onAfterDeleteMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, String[] keyNames, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onAfterDeleteMap(ec, domainName, id, keyNames, unlockZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onBeforeTakeWorkFlowNode(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, EloixClient.IndexServer.WFNode node, EloixClient.IndexServer.UserInfo user, int flags, EloixClient.IndexServer.LockZ lockZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onBeforeTakeWorkFlowNode(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, EloixClient.IndexServer.WFNode node, EloixClient.IndexServer.UserInfo user, int flags, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onBeforeTakeWorkFlowNode(ec, workflow, node, user, flags, lockZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onBeforeFindSords(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.FindInfo findInfo, EloixClient.IndexServer.SordZ sordZ) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onBeforeFindSords(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.FindInfo findInfo, EloixClient.IndexServer.SordZ sordZ, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onBeforeFindSords(ec, findInfo, sordZ);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onBeforeFindSordsInternalSQL(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.FindInfo findInfo, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.FindInfoAsInternalSQL findSql) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onBeforeFindSordsInternalSQL(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.FindInfo findInfo, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.FindInfoAsInternalSQL findSql, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onBeforeFindSordsInternalSQL(ec, findInfo, sordZ, findSql);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onFindSordsResult(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.FindInfo findInfo, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.FindResult findResult) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onFindSordsResult(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.FindInfo findInfo, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.FindResult findResult, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onFindSordsResult(ec, findInfo, sordZ, findResult);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void onFindClose(EloixClient.IndexServer.IXServerEventsContext ec, Object findInfo) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onFindClose(EloixClient.IndexServer.IXServerEventsContext ec, Object findInfo, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				onFindClose(ec, findInfo);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual EloixClient.IndexServer.InheritKeywordingResult onInheritKeywording(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord parentSord, String[] okeyNames, Object reserved) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void onInheritKeywording(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord parentSord, String[] okeyNames, Object reserved, BAsyncResult<EloixClient.IndexServer.InheritKeywordingResult> asyncResult) {
			EloixClient.IndexServer.InheritKeywordingResult __byps__ret = default(EloixClient.IndexServer.InheritKeywordingResult);
			Exception __byps__ex = null;
			try {
				__byps__ret = onInheritKeywording(ec, sord, parentSord, okeyNames, reserved);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		
	}
}
