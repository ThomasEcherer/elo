using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	/// <summary>
	/// The IndexServer fires this events while processing API calls.
	/// </summary>
	/// <remarks>
	/// Event handler functions can be written in JavaScript and their
	/// script files have to be stored below the archive folder
	/// "Administration/IndexServer Scripting Base".
	/// <p>The first level of entries in
	/// "Administration/IndexServer Scripting Base" consists of
	/// the mandatory folder "_ALL" and optional folders that
	/// are named like the IndexServer instances. An IndexServer instance
	/// name is usually the computer name on which the IndexServer is running.
	/// But an arbitary name can be explicitly assigned by setting the
	/// servlet parameter "ixid" in the web.xml or config.xml files.
	/// </p><p>
	/// The second level below "Administration/IndexServer Scripting Base"
	/// shold contain folders named by the person or company that
	/// provide the JavaScript modules.
	/// </p><p>
	/// The IndexServer recursively searches in the folder
	/// "_ALL" and the folder with the instance name
	/// for JavaScript files with extension ".js". All functions
	/// in this files named like the functions defined in this interface are
	/// recognized as event handler functions. There might be more than one
	/// handler per event. All handers are executed in a random order, if the
	/// event is raised.
	/// </p>
	/// </remarks>
	// checkpoint byps.gen.cs.GenRemoteClass:93
	public interface IXServerEvents : BRemote {
	
		/// <summary>
		/// This mandatory method returns information about the application that implements
		/// the interface.
		/// </summary>
		/// <remarks>
		/// It should return the application name and version and
		/// the implementors name.
		/// The returned String is printed into the log file and is added to
		/// error messages.
		/// This method is mandatory.
		/// </remarks>
		String getAppInfo(EloixClient.IndexServer.IXServerEventsContext ec);
		void getAppInfo(EloixClient.IndexServer.IXServerEventsContext ec, BAsyncResult<String> asyncResult) ;
		
		/// <summary>
		/// This mandatory method tests, wether an interace method is implemented.
		/// </summary>
		/// <remarks>
		/// The IndexServer calls this function for each method, before the method
		/// is called the first time.
		/// </remarks>
		bool hasMethod(EloixClient.IndexServer.IXServerEventsContext ec, String methodName);
		void hasMethod(EloixClient.IndexServer.IXServerEventsContext ec, String methodName, BAsyncResult<bool> asyncResult) ;
		
		/// <summary>
		/// This synchronous event is raised before a Sord object is written.
		/// </summary>
		/// <remarks>
		/// It is raised in checkinSord, checkinDocEnd, checkinDocsEnd, startImport.
		/// </remarks>
		void onBeforeCheckinSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ);
		void onBeforeCheckinSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This asynchronous event is raised after a Sord object has been written.
		/// </summary>
		/// <remarks>
		/// It is raised in checkinSord, checkinDocEnd, checkinDocsEnd, checkinSordPath, startImport.
		/// </remarks>
		void onAfterCheckinSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ);
		void onAfterCheckinSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This synchronous event is raised before a document or a document version is checked in.
		/// </summary>
		/// <remarks>
		/// It is raised in checkinDocEnd, checkinDocsEnd, startImport.
		/// </remarks>
		void onBeforeCheckinDocEnd(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Document doc, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ);
		void onBeforeCheckinDocEnd(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Document doc, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This asynchronous event is raised after a document or a document version has been checked in.
		/// </summary>
		/// <remarks>
		/// It is raised in checkinDocEnd, checkinDocsEnd, startImport.
		/// </remarks>
		void onAfterCheckinDocEnd(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Document doc, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ);
		void onAfterCheckinDocEnd(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord sordDB, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Document doc, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This synchronous event is raised before a Sord is deleted.
		/// </summary>
		/// <remarks>
		/// It is raised in deleteSord, cleanupStart.
		/// </remarks>
		void onBeforeDeleteSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.LockZ unlockZ, EloixClient.IndexServer.DeleteOptions delOpts);
		void onBeforeDeleteSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.LockZ unlockZ, EloixClient.IndexServer.DeleteOptions delOpts, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This asynchronous event is raised after a Sord is deleted.
		/// </summary>
		/// <remarks>
		/// It is raised in deleteSord, cleanupStart.
		/// </remarks>
		void onAfterDeleteSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.LockZ unlockZ, EloixClient.IndexServer.DeleteOptions delOpts, bool ret);
		void onAfterDeleteSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSord, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.LockZ unlockZ, EloixClient.IndexServer.DeleteOptions delOpts, bool ret, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This synchronous event is raised before a Sord is moved or a reference is created.
		/// </summary>
		/// <remarks>
		/// It is raised in refSord, copySord.
		/// </remarks>
		void onBeforeRefSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSordOld, EloixClient.IndexServer.Sord parentSordNew, EloixClient.IndexServer.Sord sord, int manSortIndex);
		void onBeforeRefSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSordOld, EloixClient.IndexServer.Sord parentSordNew, EloixClient.IndexServer.Sord sord, int manSortIndex, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This asynchronous event is raised after a Sord is moved or a reference is created.
		/// </summary>
		/// <remarks>
		/// It is raised in refSord, copySord.
		/// </remarks>
		void onAfterRefSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSordOld, EloixClient.IndexServer.Sord parentSordNew, EloixClient.IndexServer.Sord sord, int manSortIndex);
		void onAfterRefSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord parentSordOld, EloixClient.IndexServer.Sord parentSordNew, EloixClient.IndexServer.Sord sord, int manSortIndex, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This asynchronous event is raised after a workflow node is forwarded by
		/// endEditWorkFlowNode.
		/// </summary>
		void onAfterEndEditWorkFlowNode(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, int nodeId, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ);
		void onAfterEndEditWorkFlowNode(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, int nodeId, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This asynchronous event is raised after checkinReminder was called.
		/// </summary>
		void onAfterCheckinReminder(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Reminder[] remiArray, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ);
		void onAfterCheckinReminder(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Reminder[] remiArray, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This event is raised when the IXServicePortIF function executeRegisteredFunction is called.
		/// </summary>
		EloixClient.IndexServer.Any executeRegisteredFunction(EloixClient.IndexServer.IXServerEventsContext ec, String functionName, EloixClient.IndexServer.Any any);
		void executeRegisteredFunction(EloixClient.IndexServer.IXServerEventsContext ec, String functionName, EloixClient.IndexServer.Any any, BAsyncResult<EloixClient.IndexServer.Any> asyncResult) ;
		
		/// <summary>
		/// This event is raised when the IXServicePortIF function executeRegisteredFunctionString is called.
		/// </summary>
		String executeRegisteredFunctionString(EloixClient.IndexServer.IXServerEventsContext ec, String functionName, String args);
		void executeRegisteredFunctionString(EloixClient.IndexServer.IXServerEventsContext ec, String functionName, String args, BAsyncResult<String> asyncResult) ;
		
		/// <summary>
		/// This synchronous event is raised before a workflow is started.
		/// </summary>
		void onBeforeStartWorkFlow(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ);
		void onBeforeStartWorkFlow(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This asynchronous event is raised after a workflow is started.
		/// </summary>
		void onAfterStartWorkFlow(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ);
		void onAfterStartWorkFlow(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This event is raised before an activity is written.
		/// </summary>
		/// <remarks>
		/// The event is invoked too, if the activity is to be deleted. An activity is called deleted, if member activity.backAt is not empty.
		/// </remarks>
		void onBeforeCheckinActivity(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Activity act, bool isNew, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ);
		void onBeforeCheckinActivity(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Activity act, bool isNew, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This event is raised asynchronously after an activity is written.
		/// </summary>
		/// <remarks>
		/// The event is invoked too, if the activity was deleted. An activity is called deleted, if member activity.backAt is not empty.
		/// </remarks>
		void onAfterCheckinActivity(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Activity act, bool isNew, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ);
		void onAfterCheckinActivity(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Activity act, bool isNew, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This synchronous event is raised before a Note object is written.
		/// </summary>
		/// <remarks>
		/// It is raised in checkinNotes
		/// </remarks>
		void onBeforeCheckinNotes(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Note[] notes, EloixClient.IndexServer.Sord[] sords, long noteC, EloixClient.IndexServer.LockZ unlockZ);
		void onBeforeCheckinNotes(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Note[] notes, EloixClient.IndexServer.Sord[] sords, long noteC, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This asynchronous event is raised after a Note object has been written.
		/// </summary>
		/// <remarks>
		/// It is raised in
		/// </remarks>
		void onAfterCheckinNotes(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Note[] notes, EloixClient.IndexServer.Sord[] sords, long noteC, EloixClient.IndexServer.LockZ unlockZ);
		void onAfterCheckinNotes(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Note[] notes, EloixClient.IndexServer.Sord[] sords, long noteC, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This event is raised after files has been uploaded by the JSON API to build the response message.
		/// </summary>
		/// <remarks>
		/// The response message depends on the file upload solution used by the client side JavaScript.
		/// This event can only be implemented as a JavaScript function. It is not possible to process it in a WEB-service like other events in this interface.
		/// </remarks>
		void onFileUploadBuildResponse(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.DocVersion dv, String fileName, EloixClient.IndexServer.HttpRequestInfo requestInfo, EloixClient.IndexServer.HttpResponseInfo responseInfo);
		void onFileUploadBuildResponse(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.DocVersion dv, String fileName, EloixClient.IndexServer.HttpRequestInfo requestInfo, EloixClient.IndexServer.HttpResponseInfo responseInfo, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Get lean user and group information.
		/// </summary>
		/// <remarks>
		/// This method is called to internally process the API function {@link IXServicePortIF#getUserNames(ClientInfo, String[], CheckoutUsersZ)}.
		/// This method should call {@link IXServicePortIF#getUserNames(ClientInfo, String[], CheckoutUsersZ)} internally and should
		/// only modify {@link UserName#flags2} or {@link UserName#flags2} in the returned array. E.g. {@link UserName#flags2} can
		/// be changed in order to hide particular users by removing the bit {@link AccessC#FLAG2_VISIBLE_USER}.
		/// </remarks>
		EloixClient.IndexServer.UserName[] getUserNames(EloixClient.IndexServer.IXServerEventsContext ec, String[] ids, EloixClient.IndexServer.CheckoutUsersZ checkoutUsersZ);
		void getUserNames(EloixClient.IndexServer.IXServerEventsContext ec, String[] ids, EloixClient.IndexServer.CheckoutUsersZ checkoutUsersZ, BAsyncResult<EloixClient.IndexServer.UserName[]> asyncResult) ;
		
		/// <summary>
		/// Modify the Sord information returned in checkoutSord, checkoutDoc, findFirstSords, etc.
		/// </summary>
		/// <remarks>
		/// This function is called, before a Sord object is returned to the client application.
		/// It can be used to modify or delete some of the transmitted data. But it must not change the
		/// members sord.id and sord.guid. Furthermore it cannot prevent the Sord object from being transmitted.
		/// This method cannot be implemented by services because of the output parameters.
		/// This method is frequently called and should perform as fast as possible.
		/// </remarks>
		void onReadSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.Document doc, EloixClient.IndexServer.LockZ lockZ);
		void onReadSord(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.Document doc, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Check access to Sord object.
		/// </summary>
		/// <remarks>
		/// Use this method to replace the internal access checking of the ACL for Sord objects.
		/// In order to deny access to the given sord, return false, otherwise return true.
		/// <p>
		/// This method should not be implemented by services for performance reasons. It is frequently called
		/// and should perform as fast as possible.
		/// </p><p>
		/// The Indexserver's access check function can be called via class de.elo.ix.jscript.Access.
		/// Example code:
		/// <code><pre>
		/// function onCheckSordAccess(ec, sord, sordZ, lur, opts) {
		/// var acc = new Packages.de.elo.ix.jscript.Access();
		/// var succ = acc.checkAccess(sord, lur);
		/// return succ;
		/// }
		/// </pre></code>
		/// </p>
		/// </remarks>
		bool onCheckSordAccess(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, int lur, EloixClient.IndexServer.CheckAccessOptions opts);
		void onCheckSordAccess(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, int lur, EloixClient.IndexServer.CheckAccessOptions opts, BAsyncResult<bool> asyncResult) ;
		
		/// <summary>
		/// Before a user is authenticated the IX calls this method.
		/// </summary>
		/// <remarks>
		/// Use it to allow or
		/// deny the the login to the user. If the user is not allowed to login
		/// according to the {@link LoginScriptOptions} opts, an exception has to be
		/// thrown.
		/// <p>
		/// Example code:
		/// <code><pre>
		/// function onBeforeLogin(ec, user, opts) {
		/// if (username == "OnlyWithWebClient" && options.getClientName() != LoginScriptOptionsC.CLIENT_NAME_WEBCLIENT) {
		/// throw "User may login only with the WebClient";
		/// }
		/// }
		/// </pre></code>
		/// </p>
		/// </remarks>
		void onBeforeLogin(EloixClient.IndexServer.IXServerEventsContext ec, String userName, EloixClient.IndexServer.LoginScriptOptions opts);
		void onBeforeLogin(EloixClient.IndexServer.IXServerEventsContext ec, String userName, EloixClient.IndexServer.LoginScriptOptions opts, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This method is called asynchronously after a user has been successfully authenticated.
		/// </summary>
		void onAfterLogin(EloixClient.IndexServer.IXServerEventsContext ec, String userName, EloixClient.IndexServer.LoginScriptOptions opts);
		void onAfterLogin(EloixClient.IndexServer.IXServerEventsContext ec, String userName, EloixClient.IndexServer.LoginScriptOptions opts, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This event is triggered in createSord, checkinSordPath and optionally in createDoc.
		/// </summary>
		/// <remarks>
		/// Use this event in order to customize the initialization of an EditInfo resp. Sord object.
		/// The script can call the {@link IXServicePortIF#createSord(ClientInfo, String, String, EditInfoZ)} function
		/// in order to get a new EditInfo object. The script can return null, if the standard initialization
		/// should be used. Before the EditInfo object created by this function is returned to the client application,
		/// the following mebers are overwritten: EditInfo.sord.id=-1, EditInfo.sord.guid=<random GUID>.
		/// All members in EditInfo that are not assigned by this function but requested from the element selector editZ,
		/// are assigned (as far as possible) before the EditInfo object is returned to the client.
		/// Hint: Although this function is named createSord, it has to return an EditInfo object.
		/// This event is not triggered, if there is an onCreateDoc event customized.
		/// </remarks>
		EloixClient.IndexServer.EditInfo onCreateSord(EloixClient.IndexServer.IXServerEventsContext ec, String parentId, String maskId, EloixClient.IndexServer.EditInfoZ editZ);
		void onCreateSord(EloixClient.IndexServer.IXServerEventsContext ec, String parentId, String maskId, EloixClient.IndexServer.EditInfoZ editZ, BAsyncResult<EloixClient.IndexServer.EditInfo> asyncResult) ;
		
		/// <summary>
		/// This event is triggered in createDoc.
		/// </summary>
		/// <remarks>
		/// If an onCreateDoc event is configured, the event onCreateSord is not triggered in onCreateSord.
		/// </remarks>
		EloixClient.IndexServer.EditInfo onCreateDoc(EloixClient.IndexServer.IXServerEventsContext ec, String parentId, String maskId, String docTemplate, EloixClient.IndexServer.EditInfoZ editInfoZ);
		void onCreateDoc(EloixClient.IndexServer.IXServerEventsContext ec, String parentId, String maskId, String docTemplate, EloixClient.IndexServer.EditInfoZ editInfoZ, BAsyncResult<EloixClient.IndexServer.EditInfo> asyncResult) ;
		
		/// <summary>
		/// This event is invoked before {@link IXServicePortIF#checkinUsers(ClientInfo, UserInfo[], CheckinUsersZ, LockZ)} processes the supplied UserInfo objects.
		/// </summary>
		EloixClient.IndexServer.UserInfo[] onBeforeCheckinUsers(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.UserInfo[] userInfos, EloixClient.IndexServer.CheckinUsersZ checkinUsersZ, EloixClient.IndexServer.LockZ unlockZ);
		void onBeforeCheckinUsers(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.UserInfo[] userInfos, EloixClient.IndexServer.CheckinUsersZ checkinUsersZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<EloixClient.IndexServer.UserInfo[]> asyncResult) ;
		
		/// <summary>
		/// This event is called after {@link IXServicePortIF#checkinUsers(ClientInfo, UserInfo[], CheckinUsersZ, LockZ)} has processed the supplied UserInfo objects.
		/// </summary>
		/// <remarks>
		/// Indexserver invokes this event asynchronously after the users have been written.
		/// </remarks>
		void onAfterCheckinUsers(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.UserInfo[] userInfos, EloixClient.IndexServer.CheckinUsersZ checkinUsersZ, EloixClient.IndexServer.LockZ unlockZ);
		void onAfterCheckinUsers(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.UserInfo[] userInfos, EloixClient.IndexServer.CheckinUsersZ checkinUsersZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This event is called before {@link IXServicePortIF#checkinMap(ClientInfo, String, String, int, KeyValue[], LockZ)} is executed.
		/// </summary>
		EloixClient.IndexServer.KeyValue[] onBeforeCheckinMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, int objId, EloixClient.IndexServer.KeyValue[] data, EloixClient.IndexServer.LockZ unlockZ);
		void onBeforeCheckinMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, int objId, EloixClient.IndexServer.KeyValue[] data, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<EloixClient.IndexServer.KeyValue[]> asyncResult) ;
		
		/// <summary>
		/// This event is called after {@link IXServicePortIF#checkinMap(ClientInfo, String, String, int, KeyValue[], LockZ)} has processed.
		/// </summary>
		void onAfterCheckinMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, int objId, EloixClient.IndexServer.KeyValue[] data, EloixClient.IndexServer.LockZ unlockZ);
		void onAfterCheckinMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, int objId, EloixClient.IndexServer.KeyValue[] data, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This event is called before {@link IXServicePortIF#deleteMap(ClientInfo, String, String, String[], LockZ)} is executed.
		/// </summary>
		String[] onBeforeDeleteMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, String[] keyNames, EloixClient.IndexServer.LockZ unlockZ);
		void onBeforeDeleteMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, String[] keyNames, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<String[]> asyncResult) ;
		
		/// <summary>
		/// This event is called after {@link IXServicePortIF#deleteMap(ClientInfo, String, String, String[], LockZ)} has processed.
		/// </summary>
		void onAfterDeleteMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, String[] keyNames, EloixClient.IndexServer.LockZ unlockZ);
		void onAfterDeleteMap(EloixClient.IndexServer.IXServerEventsContext ec, String domainName, String id, String[] keyNames, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This event is fired before {@link IXServicePortIF#takeWorkFlowNode(ClientInfo, int, int, String, int, LockZ)} is processed.
		/// </summary>
		void onBeforeTakeWorkFlowNode(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, EloixClient.IndexServer.WFNode node, EloixClient.IndexServer.UserInfo user, int flags, EloixClient.IndexServer.LockZ lockZ);
		void onBeforeTakeWorkFlowNode(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.WFDiagram workflow, EloixClient.IndexServer.WFNode node, EloixClient.IndexServer.UserInfo user, int flags, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This event is fired before the FindInfo object passed in findFirstSords is evaluated.
		/// </summary>
		/// <remarks>
		/// The passed findInfo object can be modified.
		/// </remarks>
		void onBeforeFindSords(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.FindInfo findInfo, EloixClient.IndexServer.SordZ sordZ);
		void onBeforeFindSords(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.FindInfo findInfo, EloixClient.IndexServer.SordZ sordZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This event is fired before findFirstSords executes the search statement.
		/// </summary>
		/// <remarks>
		/// Be aware of the fact that there is no guaranty about the generated FindSql data.
		/// Subsequent IX versions can create different FindSql objects for the same FindInfo object.
		/// Hence, modifications of the FindSql data might not work in future releases.
		/// Prefer to use {@link IXServerEvents#onBeforeFindSords(IXServerEventsContext, FindInfo, SordZ)} wherever possible.
		/// </remarks>
		void onBeforeFindSordsInternalSQL(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.FindInfo findInfo, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.FindInfoAsInternalSQL findSql);
		void onBeforeFindSordsInternalSQL(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.FindInfo findInfo, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.FindInfoAsInternalSQL findSql, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This event is called for find results found by findFirstSords and findNextSords.
		/// </summary>
		void onFindSordsResult(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.FindInfo findInfo, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.FindResult findResult);
		void onFindSordsResult(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.FindInfo findInfo, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.FindResult findResult, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This event is called when a search via findFirstSords/findNextSords is closed.
		/// </summary>
		void onFindClose(EloixClient.IndexServer.IXServerEventsContext ec, Object findInfo);
		void onFindClose(EloixClient.IndexServer.IXServerEventsContext ec, Object findInfo, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This event is called when index values are inherited.
		/// </summary>
		/// <remarks>
		/// <p>
		/// Example:
		/// <pre>
		/// <code class="example">
		/// function onInheritKeywording(ec, sord, parent, okeyNames, reserved) {
		/// for (var i = 0; i < okeyNames.length; i++) {
		/// var key = okeyNames[i];
		/// var value = getObjKey(parent, key);
		/// log.info("inherit " + key + ", value=" + value);
		/// setObjKey(sord, key, value);
		/// }
		/// return InheritKeywordingResult.INHERITED;
		/// }
		/// </code>
		/// </pre>
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.InheritKeywordingResult onInheritKeywording(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord parentSord, String[] okeyNames, Object reserved);
		void onInheritKeywording(EloixClient.IndexServer.IXServerEventsContext ec, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Sord parentSord, String[] okeyNames, Object reserved, BAsyncResult<EloixClient.IndexServer.InheritKeywordingResult> asyncResult) ;
		
		
	}
}  // end namespace
