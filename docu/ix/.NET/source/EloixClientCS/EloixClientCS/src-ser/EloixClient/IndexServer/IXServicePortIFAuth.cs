using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	/// <summary>
	/// IndexServer Interface.
	/// </summary>
	/// <remarks>
	/// <p>Hint: This documentation is automatically generated from the server side
	/// source files of IndexServer. Many of the functions are not available on the
	/// client side. The only functions you can call are the members of
	/// <code>IXServicePortIF</code>. All other classes are simple data structures
	/// without functions - although the functions are documented here.</p>
	/// 
	/// <p>This interface contains all methods IndexServer provides for accessing
	/// an ELO archive. Since IndexServer runs (usually) as a SOAP-WEB-Service you can
	/// access it from all common programming languages and development environments.
	/// The examples are written in C#, because the majority of client programs will
	/// be written in C# or Java, which is very similar to C#. Find a complete
	/// C# example project via the link below.</p>
	/// 
	/// <p>For performance reason, uploading and downloading of document files are
	/// not implemented by SOAP calls. The transport of document files run over
	/// HTTP with a separate connection to IndexServer. It is also possible to access
	/// the ELO Document Manager directly to improve performance. But be aware of the
	/// fact that ELO Document Manager does not make any access checking and this might
	/// be a security whole in your environment.</p>
	/// 
	/// <p>To help C# and Java programmers in writing IndexServer client applications,
	/// there is a client helper class resp. a helper package available, see links below.</p>
	/// 
	/// <p>Note (1): "object ID" or "entry ID" is a numeric value that uniquely defines
	/// an object of indexing information in the archive database. Indexing
	/// information objects are represented as objects of class <code>Sord</code>. The
	/// member <code>Sord.id</code> contains the object ID. Object ID parameters are
	/// often named "objId", "parentId". </p>
	/// <p>Note (2): "document ID" or "attachment ID" is a numeric value that uniquely
	/// defines a document resp. attachment file version in the archive database.
	/// Document versions are represented as objects of class <code>DocHistory</code>.
	/// The member <code>DocHistory.docId</code> contains the document ID. Document ID
	/// parameters are often named "docId", "attId". </p>
	/// <p>Note (3): The SOAP transport layer eliminates "\r" in strings. For
	/// multi-line input values (e. g. Sord.desc) IX automatically transforms
	/// a "\n" into a "\r\n" before storing the string into database.</p>
	/// <p>Note (4): IX eliminates leading and trailing blanks from all strings
	/// before storing them into database.</p>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	// checkpoint byps.gen.cs.GenRemoteClass:93
	public interface IXServicePortIFAuth : BRemote {
	
		/// <summary>
		/// Extends the ticket lifetime.
		/// </summary>
		void alive();
		void alive(BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Locks a person task node of an active workflow inside the database and returns data needed to edit it.
		/// </summary>
		/// <remarks>
		/// If lockZ is not set to <code>LockC.NO</code>, <code>WFNode.inUseDate</code> will be set to now.
		/// </remarks>
		EloixClient.IndexServer.WFEditNode beginEditWorkFlowNode(int nFlowId, int nNodeId, EloixClient.IndexServer.LockZ lockZ);
		void beginEditWorkFlowNode(int nFlowId, int nNodeId, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.WFEditNode> asyncResult) ;
		
		/// <summary>
		/// Changes the storage mask of a archive entry.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The function does not update the object in the database.
		/// The method <code>checkinSord</code> must be used to write the changes into the database.
		/// </p><p>
		/// For new Sord objects (Sord.id &lt; 0), ACL items are replaced by the definitions
		/// of the mask. Existing objects keep the previous ACL setting.
		/// </p><p>
		/// ObjKeys with IDs &lt; ID_LINK (=50) are converted into the format of the
		/// new associated DocMaskLine. ObjKeys with IDs &gt;= ID_LINK are not changed.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.EditInfo changeSordMask(EloixClient.IndexServer.Sord sord, String maskId, EloixClient.IndexServer.EditInfoZ editInfoZ);
		void changeSordMask(EloixClient.IndexServer.Sord sord, String maskId, EloixClient.IndexServer.EditInfoZ editInfoZ, BAsyncResult<EloixClient.IndexServer.EditInfo> asyncResult) ;
		
		/// <summary>
		/// Check-in the marker definitions (colors for the archive entries).
		/// </summary>
		/// <remarks>
		/// This method
		/// deletes the current markers and inserts the supplied ones in <code>colors</code>.
		/// To insert a new color, set its Id to -1. If the supplied <code>colors</code>
		/// array does not contain a system color (Id == 0), a new system color object is created.
		/// The objects must have unique IDs (or -1) and unique names.
		/// </remarks>
		void checkinColors(EloixClient.IndexServer.ColorData[] colors, EloixClient.IndexServer.LockZ unlockZ);
		void checkinColors(EloixClient.IndexServer.ColorData[] colors, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Uploads configuration files to the configuration directory on the server.
		/// </summary>
		void checkinConfigFiles(EloixClient.IndexServer.ConfigFile[] configFiles, EloixClient.IndexServer.LockZ unlockZ);
		void checkinConfigFiles(EloixClient.IndexServer.ConfigFile[] configFiles, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Prepare ConfigFile objects with URLs to upload configuration or intray files.
		/// </summary>
		/// <remarks>
		/// The <code>names[.]</code> the must contain the destination directory and file name.
		/// <table border="2">
		/// <tr><td>example for file names</td><td>description</td></tr>
		/// <tr><td><code>names[.]=peter/postbox/file1.txt</code></td>
		/// <td>Prepares a <code>ConfigFile</code> object to write file1.txt into peter s server side intray directory</td></tr>
		/// <tr><td><code>configFile[.].dir=eloscripts/file1.txt</code></td>
		/// <td>Prepares a <code>ConfigFile</code> object to write file1.txt into the directory for scripts.</td></tr>
		/// </table>
		/// <pre><code>
		/// //Example for uploading a file into the server side intray of a user.<br/>
		/// String userName = ...;
		/// File file = ...;
		/// String destFile = userName + "/" + CONST.CONFIG_FILE.POSTBOX + "/" + file.getName();<br/>
		/// ConfigFile[] configFiles = ix.ix.checkinConfigFilesBegin(ci, new String[] {destFile});<br/>
		/// configFiles[0].uploadResult = ix.upload(configFiles[0].url, file);<br/>
		/// configFiles = ix.ix.checkinConfigFilesEnd(ci, configFiles);<br/>
		/// </code></pre>
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.ConfigFile[] checkinConfigFilesBegin(String[] names);
		void checkinConfigFilesBegin(String[] names, BAsyncResult<EloixClient.IndexServer.ConfigFile[]> asyncResult) ;
		
		/// <summary>
		/// Finishes a check-in procedure for configuration files.
		/// </summary>
		/// <remarks>
		/// <p>For files that have been uploaded into the in-tray folder of other users,
		/// no <code>ConfigFile</code> object can be returned, because the in-tray folders
		/// of other users are not readable. </p>
		/// </remarks>
		EloixClient.IndexServer.ConfigFile[] checkinConfigFilesEnd(EloixClient.IndexServer.ConfigFile[] configFiles, EloixClient.IndexServer.LockZ unlockZ);
		void checkinConfigFilesEnd(EloixClient.IndexServer.ConfigFile[] configFiles, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<EloixClient.IndexServer.ConfigFile[]> asyncResult) ;
		
		/// <summary>
		/// Update counter values or create new counters.
		/// </summary>
		void checkinCounters(EloixClient.IndexServer.CounterInfo[] counterInfos, EloixClient.IndexServer.LockZ unlockZ);
		void checkinCounters(EloixClient.IndexServer.CounterInfo[] counterInfos, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Prepares the IndexServer to enable a document to be checked in.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The check in procedure consists of three steps. First a call to <code>checkinDocBegin</code>
		/// prepares the IndexServer to upload a document. The function returns among
		/// other things the URL to which the document must be up loaded. In the second
		/// step the document is uploaded to this URL. The final step is to call <code>checkinDocEnd</code>
		/// with the result of the upload process. The upload result is interpreted by
		/// the IndexServer and the document is inserted into the database.
		/// </p><p>
		/// The upload URL accesses the ELODM (document manager service)
		/// directly due to performance reasons . The URL is valid as long as the session ticket is valid.
		/// </p><p>
		/// It is possible to insert more than one document or attachment versions and a signature file.
		/// </p><p>
		/// The parameter <code>document</code> of <code>checkinDocBegin</code> must contain
		/// a minimum of one version in <code>document.docs</code>, <code>document.atts</code> or
		/// <code>document.sig</code>. The minimum that must be set in the version object is the member <code>DocVersion.ext</code>.
		/// </p><p>
		/// <b>Examples</b>
		/// </p><p>
		/// <b>1. New document</b><br/>
		/// <code>IXServicePortIF db = ... </code><br/>
		/// <code>ClientInfo ci = ... </code><br/>
		/// <code>EditInfo ed = db.createDoc(ci, "1", null, null, EditInfoC.mbSordDocAtt);</code><br/>
		/// <code>ed.sord.short="new document";</code><br/>
		/// <code>ed.document.docs = new DocVersion[1];</code><br/>
		/// <code>ed.document.docs[0] = new DocVersion();</code><br/>
		/// <code>ed.document.docs[0].ext = "TIF";</code><br/>
		/// <code>ed.document.docs[0].pathId = ed.sord.path;</code><br/>
		/// <code>ed.document.docs[0].encryptionSet = ed.sord.details.encryptionSet;</code><br/>
		/// <code>ed.document = db.checkinDocBegin(ci, ed.document);</code><br/>
		/// <code>ed.document.docs[0].uploadResult = ...upload(ed.document.docs[0].url, file);</code><br/>
		/// <code>ed.document = db.checkinDocEnd(ci, ed.sord, SORD.mbAll, ed.document, LockC.NO);</code><br/>
		/// </p><p>
		/// <b>2. New document (file) version</b><br/>
		/// <code>IXServicePortIF db = ... </code><br/>
		/// <code>ClientInfo ci = ... </code><br/>
		/// <code>EditInfo ed = db.checkoutDoc(ci, "[object-ID]", null, EditInfoC.mbSordDocAtt, LockC.IF_FREE);</code><br/>
		/// <code>Document doc = new Document()</code><br/>
		/// <code>doc.docs = new DocVersion[1];</code><br/>
		/// <code>doc.docs[0] = new DocVersion();</code><br/>
		/// <code>doc.docs[0].ext = "TIF";</code><br/>
		/// <code>doc.docs[0].pathId = ed.sord.path;</code><br/>
		/// <code>doc.objId = 1234;</code><br/>
		/// <code>doc = db.checkinDocBegin(ci, doc);</code><br/>
		/// <code>doc.docs[0].uploadResult = ...upload(doc.docs[0].url, file);</code><br/>
		/// <code>doc = db.checkinDocEnd(ci, null, null, doc, LockC.YES);</code><br/>
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.Document checkinDocBegin(EloixClient.IndexServer.Document document);
		void checkinDocBegin(EloixClient.IndexServer.Document document, BAsyncResult<EloixClient.IndexServer.Document> asyncResult) ;
		
		/// <summary>
		/// Checks-in already existing documents again.
		/// </summary>
		/// <remarks>
		/// <p>This method is used to reduce transmission
		/// time as the document does not have to be checked-out.</p>
		/// </remarks>
		EloixClient.IndexServer.Document checkinDocDupl(EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.Document document, EloixClient.IndexServer.LockZ unlockZ);
		void checkinDocDupl(EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.Document document, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<EloixClient.IndexServer.Document> asyncResult) ;
		
		/// <summary>
		/// Checks in an uploaded document.
		/// </summary>
		/// <remarks>
		/// <p>
		/// See <code>checkinDocBegin</code>, if you want to checkin new document or attachment version(s).
		/// </p>
		/// <p>
		/// Changing the document or attachment work version, version number, comment, flags or status:
		/// <code><br/><br/>
		/// Document doc = new Document();<br/>
		/// doc.objId = an object ID or GUID<br/>
		/// doc.docs = new DocVersion[] {new DocVersion()};<br/>
		/// doc.docs[0].id = a document ID;<br/>
		/// doc.docs[0].workVersion = true;<br/>
		/// doc.docs[0].version = "2.0";<br/>
		/// doc.docs[0].comment = "new comment";<br/>
		/// doc.docs[0].milestone = true;<br/>
		/// doc.docs[0].deleted = false;<br/>
		/// ix.checkinDocEnd(ci, null, null, doc, LOCK.NO);<br/>
		/// </code>
		/// </p>
		/// <p>
		/// If the supplied sord has <code>sord.type==LBT_DOCUMENT</code>, sord.type will be detected from
		/// the file extension of the given work version.
		/// </p>
		/// <p>
		/// If the document is only to be unlocked, see <code>checkinSord</code>.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.Document checkinDocEnd(EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.Document document, EloixClient.IndexServer.LockZ unlockZ);
		void checkinDocEnd(EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.Document document, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<EloixClient.IndexServer.Document> asyncResult) ;
		
		/// <summary>
		/// Writes a keywording form into the database.
		/// </summary>
		/// <remarks>
		/// A new mask is inserted when <code>docMask.no</code> is less than 0.
		/// <p>
		/// If an existing keywording form is written with modified group names (DocMaskLine.key), a
		/// background thread is started to update the existing index values (Sord.objKeys[.].name).
		/// Use collectJobState to watch the state of the background job. Its name is
		/// &quot;Update existing index values for keywording form=...&quot;
		/// </p>
		/// </remarks>
		int checkinDocMask(EloixClient.IndexServer.DocMask docMask, EloixClient.IndexServer.DocMaskZ docMaskZ, EloixClient.IndexServer.LockZ unlockZ);
		void checkinDocMask(EloixClient.IndexServer.DocMask docMask, EloixClient.IndexServer.DocMaskZ docMaskZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<int> asyncResult) ;
		
		/// <summary>
		/// This method prepares the Index Server to allow multiple documents to be checked in at one time.
		/// </summary>
		/// <remarks>
		/// Utilized in the
		/// same manner as <code>checkinDocBegin</code> but is for multiple documents.
		/// </remarks>
		EloixClient.IndexServer.Document[] checkinDocsBegin(EloixClient.IndexServer.Document[] documents);
		void checkinDocsBegin(EloixClient.IndexServer.Document[] documents, BAsyncResult<EloixClient.IndexServer.Document[]> asyncResult) ;
		
		/// <summary>
		/// This method checks-in uploaded documents.
		/// </summary>
		/// <remarks>
		/// Utilized in the same manner as <code>checkinDocEnd</code>
		/// but for multiple documents and sords.
		/// </remarks>
		EloixClient.IndexServer.Document[] checkinDocsEnd(EloixClient.IndexServer.Sord[] sords, EloixClient.IndexServer.SordZ[] sordZs, EloixClient.IndexServer.Document[] documents, EloixClient.IndexServer.LockZ unlockZ);
		void checkinDocsEnd(EloixClient.IndexServer.Sord[] sords, EloixClient.IndexServer.SordZ[] sordZs, EloixClient.IndexServer.Document[] documents, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<EloixClient.IndexServer.Document[]> asyncResult) ;
		
		/// <summary>
		/// Writes or inserts key objects.
		/// </summary>
		/// <remarks>
		/// <p>
		/// If key data is only to be unlocked then the method should be called with
		/// <code>keyInfos=null</code> and <code>lockZ=lockZ.YES</code>.
		/// </p><p>
		/// The key objects with <code>KeyInfo[].id=-1</code> will be inserted in the database. Objects
		/// with <code>KeyInfo[].id>=0</code> will be updated.
		/// </p><p>
		/// Since the function requires an exclusive access to the user data, the data
		/// must be locked for the current user or must not be locked for anyone. To
		/// check in regardless of a lock supply <code>lockZ.FORCE</code>
		/// in <code>lockZ</code>.
		/// </remarks>
		int[] checkinKeys(EloixClient.IndexServer.KeyInfo[] keyInfos, EloixClient.IndexServer.LockZ unlockZ);
		void checkinKeys(EloixClient.IndexServer.KeyInfo[] keyInfos, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<int[]> asyncResult) ;
		
		/// <summary>
		/// Insert keywords and all their children.
		/// </summary>
		/// <remarks>
		/// The keyword IDs specify whether to insert or update.
		/// <p>
		/// <table border="2">
		/// <tr><td><code>kws[.].id={existing ID}</code></td>
		/// <td>
		/// Updates the keyword tree branch below the keyword with <code>kws[.].id</code>.
		/// The keyword must exist.
		/// </td></tr>
		/// <tr><td><code>kws[.].id={new root ID}</code></td>
		/// <td>Inserts or updates a new keyword list.</td></tr>
		/// </table>
		/// </p><p>
		/// <table border="2">
		/// <tr><th>Operations</th><th>Solution</td>
		/// <tr>
		/// <td>Insert a new child into an existing parent keyword</td>
		/// <td>Check-in the parent keyword with all current children plus the new child.
		/// Setting the text members and children arrays of the current children to <code>null</code> leaves them unchanged.
		/// </td>
		/// </tr>
		/// <tr>
		/// <td>Delete a child of an existing parent keyword</td>
		/// <td>Check-in the parent keyword with all current children minus the child to be deleted.
		/// Setting the text members and children arrays of the current children to <code>null</code> leaves them unchanged.
		/// </td>
		/// </tr>
		/// <tr>
		/// <td>Update <code>text, add, enabled</code> of an existing keyword</td>
		/// <td>Check-in the keyword with a non empty text member. Only when the text is not <code>null</code>
		/// and not an empty string will the members <code>add</code> and <code>enabled</code> be written into the database.
		/// </td>
		/// </tr>
		/// </table>
		/// </p>
		/// <p><b>IMPORTANT: This function assigns new IDs to all branches of the
		/// keyword trees below the parent keywords of the given keywords.
		/// The client program should read the parent keyword and all children below
		/// again to receive the new IDs. </b></p>
		/// <p>The access rights <code>AccessC.FLAG_EDITCONFIG</code> and
		/// <code>AccessC.FLAG_EDITSWL</code> are required to check-in keywords.<p>
		/// </remarks>
		void checkinKeywords(EloixClient.IndexServer.Keyword[] kws, EloixClient.IndexServer.LockZ unlockZ);
		void checkinKeywords(EloixClient.IndexServer.Keyword[] kws, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Write or insert Notes.
		/// </summary>
		/// <remarks>
		/// <p>Only Sord objects that reference documents can have notes.
		/// It is also possible to delete a Note: <code>notes[.].setDeleted(true);</code>.</p>
		/// <p> NOTE: When checking changed notes of annotation in stamp type notes or annotations
		/// can only be checked in once. When attempting to check in stamp type notes that already
		/// exist an exception will be returned. Use <code>MbOnlyLock</code> to unlock notes and annotations.</p>
		/// </remarks>
		int[] checkinNotes(String objId, EloixClient.IndexServer.Note[] notes, EloixClient.IndexServer.NoteZ noteZ, EloixClient.IndexServer.LockZ unlockZ);
		void checkinNotes(String objId, EloixClient.IndexServer.Note[] notes, EloixClient.IndexServer.NoteZ noteZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<int[]> asyncResult) ;
		
		/// <summary>
		/// Inserts or updates a Notification object
		/// 
		/// if userGuid is null, the own Guid will be taken
		/// if userGuid is not the own Guid, admin rights are needed
		/// </summary>
		EloixClient.IndexServer.Notification checkinNotification(EloixClient.IndexServer.Notification notif, EloixClient.IndexServer.NotificationZ notiZ);
		void checkinNotification(EloixClient.IndexServer.Notification notif, EloixClient.IndexServer.NotificationZ notiZ, BAsyncResult<EloixClient.IndexServer.Notification> asyncResult) ;
		
		/// <summary>
		/// Inserts or updates a reminder object.
		/// </summary>
		/// <remarks>
		/// <p><code>Reminder.receiverId = -1</code> should be set if receiverId is to be ignored.
		/// <code>Reminder.receiverName = null</code> should be set if the receiverName is to be ignored.</p>
		/// </remarks>
		int[] checkinReminder(EloixClient.IndexServer.Reminder remi, String[] receiverIds, bool expandGroups, EloixClient.IndexServer.LockZ unlockZ);
		void checkinReminder(EloixClient.IndexServer.Reminder remi, String[] receiverIds, bool expandGroups, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<int[]> asyncResult) ;
		
		/// <summary>
		/// Writes replication set names.
		/// </summary>
		void checkinReplNames(EloixClient.IndexServer.ReplSetName[] replNames, EloixClient.IndexServer.LockZ unlockZ);
		void checkinReplNames(EloixClient.IndexServer.ReplSetName[] replNames, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Writes the report options.
		/// </summary>
		void checkinReportOptions(EloixClient.IndexServer.ReportOptions options, EloixClient.IndexServer.LockZ unlockZ);
		void checkinReportOptions(EloixClient.IndexServer.ReportOptions options, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Writes or inserts a archive entry into the database.
		/// </summary>
		/// <remarks>
		/// <p>
		/// A new object does not have to be created with <code>createSord</code>. If the
		/// object is missing a GUID then a new one is created.
		/// </p>
		/// <p>
		/// If the Sord object is only to be unlocked <code>sordZ = SordC.mbOnlyUnlock</code> should be used
		/// and a minimum of <code>Sord.id</code> or <code>Sord.guid</code> must be set.
		/// </p>
		/// </remarks>
		int checkinSord(EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ);
		void checkinSord(EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<int> asyncResult) ;
		
		/// <summary>
		/// Checks the existence of an archive path and creates missing entries if necessary by
		/// traversing top-down through the Sords array.
		/// </summary>
		/// <remarks>
		/// <p>The folders are inserted inside the same database transaction. Thus either all folders
		/// are created or none.</p>
		/// <p>This function allows only one process at a given time to create a structure. This prevents
		/// from creating the same archive path twice by two parallel working processes.</p>
		/// <p>In order to write index values (Sord.objKeys), parameter sordZ has to contain SordC.mbObjKeys.
		/// If sord.objKeys == null or sordZ does not contain SordC.mbObjKeys, the index values defaults
		/// defined by the keywording form are written.
		/// </p>
		/// </remarks>
		int[] checkinSordPath(String parentId, EloixClient.IndexServer.Sord[] sords, EloixClient.IndexServer.SordZ sordZ);
		void checkinSordPath(String parentId, EloixClient.IndexServer.Sord[] sords, EloixClient.IndexServer.SordZ sordZ, BAsyncResult<int[]> asyncResult) ;
		
		/// <summary>
		/// Write or insert sord type information.
		/// </summary>
		void checkinSordTypes(EloixClient.IndexServer.SordType[] sordTypes, EloixClient.IndexServer.LockZ unlockZ);
		void checkinSordTypes(EloixClient.IndexServer.SordType[] sordTypes, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This method passes path information to the document manager.
		/// </summary>
		EloixClient.IndexServer.StoreInfo[] checkinStorage(EloixClient.IndexServer.StoreInfo[] storeInfos, EloixClient.IndexServer.LockZ unlockZ);
		void checkinStorage(EloixClient.IndexServer.StoreInfo[] storeInfos, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<EloixClient.IndexServer.StoreInfo[]> asyncResult) ;
		
		/// <summary>
		/// Insert deputy/substitute information.
		/// </summary>
		void checkinSubs(EloixClient.IndexServer.SubsInfo[] deps, EloixClient.IndexServer.LockZ unlockZ);
		void checkinSubs(EloixClient.IndexServer.SubsInfo[] deps, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Write (add) user profile options.
		/// </summary>
		void checkinUserProfile(EloixClient.IndexServer.UserProfile userProfile, EloixClient.IndexServer.LockZ unlockZ);
		void checkinUserProfile(EloixClient.IndexServer.UserProfile userProfile, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Writes or inserts users or groups.
		/// </summary>
		/// <remarks>
		/// <p>
		/// When inserting users or groups either <code>UserInfo.id=-1</code> should be
		/// set or the bit <code>CheckinUsersC.NEW_USER</code> in
		/// <code>checkinUsersC</code> should be used.
		/// The second case allows a complete user and group structure to be checked in with
		/// a single call of <code>checkinUsers</code>. Therefore the IDs in the submitted
		/// <code>UserInfo</code> objects must be unique and cannot be used by other users or groups in
		/// the archive database.
		/// </p><p>
		/// If only the user data is to be unlocked then the method should be called with
		/// <code>userInfos=null</code> and <code>lockZ=lockZ.YES</code>.
		/// </p><p>
		/// If the user of the current session is a sub-administrator (has right AccessC.FLAG_SUBADMIN)
		/// the <code>UserInfo.parent</code> members of the users in <code>userInfos</code>
		/// are internally set to the current users ID. In other words: sub-administrators
		/// are not free to define the parent of the users or groups.
		/// </p><p>
		/// The method checks whether the users or groups to be checked-in have
		/// more rights than their parents (administrators).
		/// </p><p>
		/// Since the function requires an exclusive access to the user data, the data
		/// must be locked for the current user or must not be locked for anyone. To
		/// check in regardless of a lock  <code>lockZ.FORCE</code> must be supplied
		/// in <code>lockZ</code>.
		/// </p><p>
		/// The users password is only written for new users or if
		/// <code>CheckinUsersC.PASSWORD</code> for the parameter <code>checkinUsersZ</code>
		/// is supplied along with the password member <code>UserInfo.pwd!=null</code>.
		/// In this case, the userInfos array must be of length=1. The user does not
		/// need to have the right AccessC.FLAG_SUBADMIN, but must have the right AccessC.FLAG_CHANGEPW.
		/// Only the members UserInfo.id and UserInfo.pwd are taken into account. This is how to
		/// change a password:
		/// <code>UserInfo ui = new UserInfo();</code><br/>
		/// <code>ui.id = current user id;</code><br/>
		/// <code>ui.pwd = new password;</code><br/>
		/// <code>ix.checkinUsers(ci, new UserInfo[] {ui}, CheckinUsersC.PASSWORD, LockC.NO);</code>
		/// </p><p>
		/// Password rules are checked, if the user changes the password or if a new user is stored.
		/// The password rules are defined in the user profile value at key UserProfileC.KEY_PASSWORD_RULES.
		/// If the password violates the password rules, an exception is throw with message "[ELOIX:3007]...".
		/// The error number (3007) is defined in IXExceptionC.PASSWORD_DENIED.
		/// </p><p>
		/// The password expiring date is handled. If the password is changed, the expiring date in the
		/// user data is updated: UserInfo.userProps[UserInfoC.PROP_ACTION] = "EX{iso-date-without-time}".
		/// Interactive client applications should check the action field in order display a dialog, if the
		/// password has to be changed. They do not need to check the "EX<iso-date>", because it is replaced
		/// by "PWf" (must change password) for the UserInfo object in the LoginResult object return by the
		/// login() functions, resp. the create() functions of IXConnFactory.
		/// The following code is recommended:
		/// <code>IXConnection conn = ...</code><br/>
		/// <code>String action = conn.getLoginResult().getUser().userProps[UserInfoC.PROP_ACTION];</code><br/>
		/// <code>boolean userShouldChangePassword = action.indexOf(UserInfoC.PROP_ACTION_USER_SHOULD_CHANGE_PASSWORD) >= 0;</code><br/>
		/// <code>boolean userMustChangePassword = action.indexOf(UserInfoC.PROP_ACTION_USER_MUST_CHANGE_PASSWORD) >= 0;</code>
		/// </p>
		/// </remarks>
		int[] checkinUsers(EloixClient.IndexServer.UserInfo[] userInfos, EloixClient.IndexServer.CheckinUsersZ checkinUsersZ, EloixClient.IndexServer.LockZ unlockZ);
		void checkinUsers(EloixClient.IndexServer.UserInfo[] userInfos, EloixClient.IndexServer.CheckinUsersZ checkinUsersZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<int[]> asyncResult) ;
		
		/// <summary>
		/// Inserts or updates organizational units.
		/// </summary>
		/// <remarks>
		/// <p>
		/// When inserting a new OU, <code>OrgUnitInfo.id=-1</code> has to be set.
		/// More than one OU can be checked in with a single call of
		/// <code>checkinOrgUnit</code>. Therefore the names, IDs and GUIDs in the
		/// submitted <code>OrgUnitInfo</code> objects must be unique and cannot be
		/// used by other OUs in the archive database.
		/// </p><p>
		/// If only the user and OU data is to be unlocked then the method should be
		/// called with <code>orgUnitInfos=null</code> and <code>lockZ=lockZ.YES</code>.
		/// </p>
		/// </remarks>
		IDictionary<int,EloixClient.IndexServer.OrgUnitInfo> checkinOrgUnits(EloixClient.IndexServer.OrgUnitInfo[] orgUnitInfos, EloixClient.IndexServer.CheckinOrgUnitInfo reserved, EloixClient.IndexServer.LockZ unlockZ);
		void checkinOrgUnits(EloixClient.IndexServer.OrgUnitInfo[] orgUnitInfos, EloixClient.IndexServer.CheckinOrgUnitInfo reserved, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<IDictionary<int,EloixClient.IndexServer.OrgUnitInfo>> asyncResult) ;
		
		/// <summary>
		/// Delete OUs.
		/// </summary>
		void deleteOrgUnits(String[] ids, EloixClient.IndexServer.LockZ unlockZ);
		void deleteOrgUnits(String[] ids, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Read the data of all OUs.
		/// </summary>
		IDictionary<int,EloixClient.IndexServer.OrgUnitInfo> checkoutOrgUnits(EloixClient.IndexServer.CheckoutOrgUnitInfo reserved, EloixClient.IndexServer.LockZ lockZ);
		void checkoutOrgUnits(EloixClient.IndexServer.CheckoutOrgUnitInfo reserved, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<IDictionary<int,EloixClient.IndexServer.OrgUnitInfo>> asyncResult) ;
		
		/// <summary>
		/// Write/create a workflow.
		/// </summary>
		/// <remarks>
		/// <p>In case of a new workflow object of type WFTypeC.ACTIVE, the workflow is
		/// immediately started after written into database. This requires a valid WFDiagram.getObjId().</p>
		/// </remarks>
		int checkinWorkFlow(EloixClient.IndexServer.WFDiagram wf, EloixClient.IndexServer.WFDiagramZ workFlowDiagramZ, EloixClient.IndexServer.LockZ unlockZ);
		void checkinWorkFlow(EloixClient.IndexServer.WFDiagram wf, EloixClient.IndexServer.WFDiagramZ workFlowDiagramZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<int> asyncResult) ;
		
		/// <summary>
		/// Checkout the markers definitions (colors of archive entries).
		/// </summary>
		EloixClient.IndexServer.ColorData[] checkoutColors(EloixClient.IndexServer.LockZ lockZ);
		void checkoutColors(EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.ColorData[]> asyncResult) ;
		
		/// <summary>
		/// Read config file names and file data.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The <code>names</code> parameter selects the config files. Each element in
		/// this array contains the virtual path to a file. A path private to a user starts
		/// with the user s name. Paths may contain the wildcard <code>*</code> instead
		/// of a file name. In this case all files in the directory are returned.
		/// </p><p>
		/// <table border="2">
		/// <tr><td>Example</td><td>Description</td></tr>
		/// <tr><td><code>name[.]=peter/template/*</code></td>
		/// <td>Selects all private document templates of user peter (document templates are currently not supported!)</td></tr>
		/// <tr><td><code>name[.]=peter/postbox/*</code></td>
		/// <td>Selects peters server side postbox files</td></tr>
		/// <tr><td><code>name[.]=template/*</code></td>
		/// <td>Selects all document templates available for all users (document templates are currently not supported!)</td></tr>
		/// <tr><td><code>name[.]=eloscripts/*</code></td>
		/// <td>Selects all scripts</td></tr>
		/// </table>
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.ConfigFile[] checkoutConfigFiles(String[] names, EloixClient.IndexServer.ConfigFileZ configFileZ, EloixClient.IndexServer.LockZ lockZ);
		void checkoutConfigFiles(String[] names, EloixClient.IndexServer.ConfigFileZ configFileZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.ConfigFile[]> asyncResult) ;
		
		/// <summary>
		/// Get counter information.
		/// </summary>
		EloixClient.IndexServer.CounterInfo[] checkoutCounters(String[] counterNames, bool incrementCounters, EloixClient.IndexServer.LockZ lockZ);
		void checkoutCounters(String[] counterNames, bool incrementCounters, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.CounterInfo[]> asyncResult) ;
		
		/// <summary>
		/// Reads the indexing information and the download URL of a document.
		/// </summary>
		/// <remarks>
		/// </p><p>
		/// At least one of the parameters <code>objId</code> and <code>docId</code> must
		/// be supplied.
		/// If only <code>objId</code> is supplied, the function reads the information
		/// for the current work version of the document. If <code>docId</code> is supplied,
		/// the function reads the information for a specific document or attachment version.
		/// All versions are returned if <code>docId="-1"</code> is supplied.
		/// </p><p>
		/// The document member of the returned object contains the URL from where the
		/// document file can be read. Use raw HTTP functions to download the file.
		/// </p>
		/// <p>
		/// If the document is only to be unlocked, see <code>checkinSord</code>.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.EditInfo checkoutDoc(String objId, String docId, EloixClient.IndexServer.EditInfoZ editInfoZ, EloixClient.IndexServer.LockZ lockZ);
		void checkoutDoc(String objId, String docId, EloixClient.IndexServer.EditInfoZ editInfoZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.EditInfo> asyncResult) ;
		
		/// <summary>
		/// Reads a storage mask from the database.
		/// </summary>
		EloixClient.IndexServer.DocMask checkoutDocMask(String maskId, EloixClient.IndexServer.DocMaskZ docMaskZ, EloixClient.IndexServer.LockZ lockZ);
		void checkoutDocMask(String maskId, EloixClient.IndexServer.DocMaskZ docMaskZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.DocMask> asyncResult) ;
		
		/// <summary>
		/// Reads a list of key objects.
		/// </summary>
		EloixClient.IndexServer.KeyInfo[] checkoutKeys(String[] ids, EloixClient.IndexServer.LockZ lockZ);
		void checkoutKeys(String[] ids, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.KeyInfo[]> asyncResult) ;
		
		/// <summary>
		/// Collects keywords and their children.
		/// </summary>
		/// <remarks>
		/// <p>The keyword objects with the given <code>kwids[.]</code> will be read.
		/// <table border="2">
		/// <tr><td rowspan=4><code>kwids[.]=</code></td><td><code>KeywordC.KWID_*</code>,</td></tr>
		/// <tr><td>an index row name,</td></tr>
		/// <tr><td>an ID of a previously read keyword.</td></tr>
		/// <tr><td>null, to read all toplevel keyword lists. Parameter <code>max</code> is ignored.</td></tr>
		/// </table>
		/// </p>
		/// <p>The parameter <code>max</code> controls how many keywords will be read.
		/// <table border="2">
		/// <tr><td>max = 0</td><td>Only the first level directly below the given
		/// <code>kwids[.]</code> is read (up to 676 keywords). The children of the
		/// returned keywords are <code>null</code></td></tr>
		/// <tr><td><code>max</code> = -1</td><td>Entire tree below <code>kwid</code> is read.</td></tr>
		/// <tr><td><code>max</code> &gt; 0</td><td>Approximately up to this number of keywords are read.
		/// The children of a keyword are always read completely or they are <code>null</code>.
		/// Thus up to <code>max</code>+675 keywords could be returned.</td></tr>
		/// </table>
		/// </p>
		/// <p>
		/// Hint: if <code>max</code> &gt;= 0 and the <code>Keyword.children</code>
		/// of a keyword is an empty array (not <code>null</code>), the keyword has definitely no children.
		/// If <code>Keyword.children = null</code>, query the children with a further
		/// call to <code>collectKeywords</code>.
		/// </p>
		/// <p>
		/// Before one of the returned keywords can be used as an index value the
		/// members <code>Keyword.enabled</code> and <code>Keyword.raw</code> must be
		/// analyzed, see <code>Keyword</code> documentation.</p>
		/// <p>You need the access right <code>AccessC.FLAG_EDITCONFIG</code> to lock keywords against concurrent modification.<p>
		/// </remarks>
		EloixClient.IndexServer.Keyword[] checkoutKeywords(String[] kwids, EloixClient.IndexServer.KeywordZ keywordZ, int max, EloixClient.IndexServer.LockZ lockZ);
		void checkoutKeywords(String[] kwids, EloixClient.IndexServer.KeywordZ keywordZ, int max, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.Keyword[]> asyncResult) ;
		
		/// <summary>
		/// Read notes of a given Sord.
		/// </summary>
		EloixClient.IndexServer.Note[] checkoutNotes(String objId, String[] noteIds, EloixClient.IndexServer.NoteZ noteZ, EloixClient.IndexServer.LockZ lockZ);
		void checkoutNotes(String objId, String[] noteIds, EloixClient.IndexServer.NoteZ noteZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.Note[]> asyncResult) ;
		
		/// <summary>
		/// Reads Notification for a watchGuid / userGuid combination
		/// 
		/// if userGuid is null, the own Guid will be taken
		/// if userGuid is not the own Guid, admin rights are needed
		/// </summary>
		EloixClient.IndexServer.Notification checkoutNotification(String watchGuid, String userGuid);
		void checkoutNotification(String watchGuid, String userGuid, BAsyncResult<EloixClient.IndexServer.Notification> asyncResult) ;
		
		/// <summary>
		/// Reads and locks a reminder object.
		/// </summary>
		EloixClient.IndexServer.Reminder[] checkoutReminders(int[] reminderIds, EloixClient.IndexServer.LockZ lockZ);
		void checkoutReminders(int[] reminderIds, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.Reminder[]> asyncResult) ;
		
		/// <summary>
		/// Reads replication set names.
		/// </summary>
		EloixClient.IndexServer.ReplSetName[] checkoutReplNames(EloixClient.IndexServer.LockZ lockZ);
		void checkoutReplNames(EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.ReplSetName[]> asyncResult) ;
		
		/// <summary>
		/// Reads the report options.
		/// </summary>
		EloixClient.IndexServer.ReportOptions checkoutReportOptions(EloixClient.IndexServer.LockZ lockZ);
		void checkoutReportOptions(EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.ReportOptions> asyncResult) ;
		
		/// <summary>
		/// Reads the data needed to edit an existing archive entry.
		/// </summary>
		/// <remarks>
		/// <table border="2">
		/// <tr>
		/// <td>Possible object identifiers (parameter objId)</td>
		/// <td>Usage</td>
		/// </tr><tr>
		/// <td>ID</td>
		/// <td>A numeric object number corresponding to Sord.getId() converted to string</td>
		/// </tr><tr>
		/// <td>GUID</td>
		/// <td>A GUID corresponding to Sord.getGuid()</td>
		/// </tr><tr>
		/// <td>Index value</td>
		/// <td>Use "OKEY:&lt;index-group-name&gt;=&lt;index-value&gt;" to select an object by an index value, example: "OKEY:SAPPATH=123124109824123/data".
		/// The wildcards &quot;%&quot; or &quot;*&quot; can be used in &lt;index-group-name&gt; or &lt;index-value&gt; to return all or any data that matches.
		/// </td>
		/// </tr><tr>
		/// <td>Index match value</td>
		/// <td>Use "LMATCH:&lt;index-group-name&gt;=&lt;fix-value&gt;%&lt;match-value&gt;"
		/// to select an object by an index value that starts with &lt;fix-value&gt; and
		/// might be followed by &lt;match-value&gt;. The object that fits most characters
		/// in &lt;match-value&gt; is selected.
		/// Example: "LMATCH:ELOINDEX=S%CH".
		/// The wildcards &quot;%&quot; or &quot;*&quot; can be used in &lt;index-group-name&gt; or &lt;match-value&gt; to return all or any data that matches.
		/// This selection mode only be utilized on non-deleted Sords.
		/// </td>
		/// </tr><tr>
		/// <td>Archive path</td>
		/// <td>Use "ARCPATH:&lt;delim-char&gt;&lt;SordName1&gt;&lt;delim-char&gt;&lt;SordName2&gt;..."
		/// to select an object by an archive path.
		/// This selection mode only be utilized on non-deleted Sords.
		/// </td>
		/// </tr><tr>
		/// <td>Archive path with base ID</td>
		/// <td>Use "ARCPATH[&lt;ID&gt;]:&lt;delim-char&gt;&lt;SordName1&gt;&lt;delim-char&gt;&lt;SordName2&gt;..." to select an object by an archive path</td>
		/// </tr>
		/// </tr><tr>
		/// <td>MD5 hash</td>
		/// <td>Use "MD5:&lt;MD5-hash-hex-string&gt;" to select an object by an MD5 hash. Use upper case letters for hexadecimal characters for the hash value.</td>
		/// </tr>
		/// </table>
		/// <p>
		/// The object can be locked against concurrent modification if <code>lockZ</code>
		/// is set to <code>lockZ.YES</code>.
		/// </remarks>
		EloixClient.IndexServer.EditInfo checkoutSord(String objId, EloixClient.IndexServer.EditInfoZ editInfoZ, EloixClient.IndexServer.LockZ lockZ);
		void checkoutSord(String objId, EloixClient.IndexServer.EditInfoZ editInfoZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.EditInfo> asyncResult) ;
		
		/// <summary>
		/// <code>checkoutSordHistory</code> retrieves all history entries related to a given object.
		/// </summary>
		EloixClient.IndexServer.SordHist[] checkoutSordHistory(String objId);
		void checkoutSordHistory(String objId, BAsyncResult<EloixClient.IndexServer.SordHist[]> asyncResult) ;
		
		/// <summary>
		/// Get sord type information.
		/// </summary>
		/// <remarks>
		/// <p>SordType objects give access to labels,
		/// icons and extensions corresponding to <code>Sord.type.</code></p>
		/// <p>Parameter <code>sordTypes</code> can be:
		/// <table border="2">
		/// <tr><th>sordType</th><th>return</th></tr>
		/// <tr><td>Array of type numbers or names</td><td>Returns for each type number (resp. name) the associated SordType information</td></tr>
		/// <tr><td>null</td><td>Returns SordType information for all types</td></tr>
		/// </table>
		/// </p><p>
		/// Parameter <code>sordTypeZ</code> specifies which members of the returned objects should be filled.
		/// It also contains the content type of the image data to be returned. This content type correspond
		/// to directories named "jpg", "ico" resp. "bmp" below ".../am-eloam/configuration/initdata/images/sordtypes/".
		/// Use ELO CLIENT to fill the directories with images of the required type.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.SordType[] checkoutSordTypes(int[] sordTypeIds, EloixClient.IndexServer.SordTypeZ sordTypeZ, EloixClient.IndexServer.LockZ lockZ);
		void checkoutSordTypes(int[] sordTypeIds, EloixClient.IndexServer.SordTypeZ sordTypeZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.SordType[]> asyncResult) ;
		
		/// <summary>
		/// checkoutStorage retrieves an array of configured paths from the Document
		/// Manager.
		/// </summary>
		/// <remarks>
		/// The contents matches the table &lt;elodmpath&gt;.
		/// </remarks>
		EloixClient.IndexServer.StoreInfo[] checkoutStorage(String[] ids, EloixClient.IndexServer.LockZ lockZ);
		void checkoutStorage(String[] ids, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.StoreInfo[]> asyncResult) ;
		
		/// <summary>
		/// Read the substitute information for the given user.
		/// </summary>
		/// <remarks>
		/// <p>The returned array
		/// contains the relations/users for which the given user is the substituted person
		/// or the substitute.</p>
		/// </remarks>
		EloixClient.IndexServer.SubsInfo[] checkoutSubs(String userId, EloixClient.IndexServer.LockZ lockZ);
		void checkoutSubs(String userId, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.SubsInfo[]> asyncResult) ;
		
		/// <summary>
		/// Read user profile options.
		/// </summary>
		/// <remarks>
		/// <p>
		/// Set <code>userProfile.userId</code> to the current user, to read her or his entire option set.
		/// This means that the default values for all users and the options inherited from the users groups are included too.
		/// </p>
		/// <p>
		/// In order to read the user specific options without defaults and group options, set <code>userProfile.excludeDefaultValues=true</code>
		/// and <code>userProfile.excludeGroupValues=true</code>.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.UserProfile checkoutUserProfile(EloixClient.IndexServer.UserProfile userProfile, EloixClient.IndexServer.LockZ lockZ);
		void checkoutUserProfile(EloixClient.IndexServer.UserProfile userProfile, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.UserProfile> asyncResult) ;
		
		/// <summary>
		/// Reads the user data for users or groups.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The function has various options for specifying which users are to read, e. g. all users,
		/// users of a specific group or groups of a specific user. The options are controlled
		/// with the bit-mask parameter <code>checkoutUsersC</code>. Possible values are
		/// combinations of <code>CheckoutUsersC</code> values.
		/// </p><p>
		/// Supplying <code>lockZ.YES</code> or <code>lockZ.FORCE</code> for the parameter
		/// <code>lockZ</code> locks the user data against concurrent modification.
		/// The lock can be released with <code>checkinUsers</code> or <code>deleteUsers</code>.
		/// </p><p>
		/// All returned <code>UserInfo</code> objects have empty passwords because the
		/// passwords cannot be read from the archive database.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.UserInfo[] checkoutUsers(String[] ids, EloixClient.IndexServer.CheckoutUsersZ checkoutUsersZ, EloixClient.IndexServer.LockZ lockZ);
		void checkoutUsers(String[] ids, EloixClient.IndexServer.CheckoutUsersZ checkoutUsersZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.UserInfo[]> asyncResult) ;
		
		/// <summary>
		/// Reads a workflow definition.
		/// </summary>
		EloixClient.IndexServer.WFDiagram checkoutWorkFlow(String flowId, EloixClient.IndexServer.WFTypeZ typeZ, EloixClient.IndexServer.WFDiagramZ workFlowDiagramZ, EloixClient.IndexServer.LockZ lockZ);
		void checkoutWorkFlow(String flowId, EloixClient.IndexServer.WFTypeZ typeZ, EloixClient.IndexServer.WFDiagramZ workFlowDiagramZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.WFDiagram> asyncResult) ;
		
		/// <summary>
		/// <code>cleanupStart(ClientInfo ci)</code> removes all deleted objects and related
		/// entries from the archive database.
		/// </summary>
		/// <remarks>
		/// <p>Once started the call returns immediately,
		/// while the unique background thread cleans the archive until it finishes or
		/// <code>cleanupStart(ClientInfo ci)</code> is called. Only users owning main administrator
		/// rights may clean up archives.</p>
		/// </remarks>
		bool cleanupStart(EloixClient.IndexServer.DeleteOptions deleteOptions);
		void cleanupStart(EloixClient.IndexServer.DeleteOptions deleteOptions, BAsyncResult<bool> asyncResult) ;
		
		/// <summary>
		/// <code>cleanupState(ClientInfo ci)</code> returns state information in
		/// a <code>BackgroundThreadInfo</code>.
		/// </summary>
		/// <remarks>
		/// <p>
		/// <table>
		/// <tr><td>IsRunning       </td><td>true/false;</td></tr>
		/// <tr><td>ThreadStart     </td><td>ISO date containing the cleaner s start;</td></tr>
		/// <tr><td>CountProcessed  </td><td>visited archive entries</td></tr>
		/// <tr><td>CountErrors     </td><td>erroneous entries</td></tr>
		/// <tr><td>LastID          </td><td>object ID of the last visited entry</td></tr>
		/// <tr><td>LastGUID        </td><td>object GUID of the last visited entry</td></tr>
		/// </table>
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.JobState cleanupState();
		void cleanupState(BAsyncResult<EloixClient.IndexServer.JobState> asyncResult) ;
		
		/// <summary>
		/// <code>cleanupStop(ClientInfo ci)</code> stops the cleaning as soon as possible
		/// finishing open transactions first.
		/// </summary>
		/// <remarks>
		/// <p>The call returns, when the background cleaner has
		/// been stopped. Only users owning main administrative rights may clean up archives.</p>
		/// </remarks>
		bool cleanupStop();
		void cleanupStop(BAsyncResult<bool> asyncResult) ;
		
		/// <summary>
		/// <code>collectJobStates</code> lists all the states of currently existing jobs from the IX backround job pool
		/// running or finished, but still listed.
		/// </summary>
		EloixClient.IndexServer.JobState[] collectJobStates(bool activeJobs, bool finishedJobs, bool fullInfo);
		void collectJobStates(bool activeJobs, bool finishedJobs, bool fullInfo, BAsyncResult<EloixClient.IndexServer.JobState[]> asyncResult) ;
		
		/// <summary>
		/// Collect workflow nodes.
		/// </summary>
		EloixClient.IndexServer.WFCollectNode[] collectWorkFlowNodes(String flowName, EloixClient.IndexServer.WFTypeZ wfTypeZ, String nodeName, int nodeType, String objId, String enterDateIso, String exitDateIso, String[] userIds, bool onlyActive, bool onlyStartNodes);
		void collectWorkFlowNodes(String flowName, EloixClient.IndexServer.WFTypeZ wfTypeZ, String nodeName, int nodeType, String objId, String enterDateIso, String exitDateIso, String[] userIds, bool onlyActive, bool onlyStartNodes, BAsyncResult<EloixClient.IndexServer.WFCollectNode[]> asyncResult) ;
		
		/// <summary>
		/// Collects workflow names.
		/// </summary>
		/// <remarks>
		/// <p><b>This method will be deprecated in future versions of the ELO IndexServer</b>.
		/// It is recommended that the findFirstTasks() and findNextTasks() methods are used for retrieving
		/// workflow information from the IndexServer.</p>
		/// </remarks>
		EloixClient.IndexServer.IdName[] collectWorkFlows(EloixClient.IndexServer.WFTypeZ typeZ);
		void collectWorkFlows(EloixClient.IndexServer.WFTypeZ typeZ, BAsyncResult<EloixClient.IndexServer.IdName[]> asyncResult) ;
		
		/// <summary>
		/// Finds active workflows.
		/// </summary>
		/// <remarks>
		/// <p>This method returns all active workflows for the current user.</p>
		/// </remarks>
		EloixClient.IndexServer.FindResult findFirstWorkflows(EloixClient.IndexServer.FindWorkflowInfo findInfo, int max, EloixClient.IndexServer.WFDiagramZ wfDiagramZ);
		void findFirstWorkflows(EloixClient.IndexServer.FindWorkflowInfo findInfo, int max, EloixClient.IndexServer.WFDiagramZ wfDiagramZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Finds more active workflows.
		/// </summary>
		/// <remarks>
		/// <p>This method returns all active workflows for the current user.</p>
		/// </remarks>
		EloixClient.IndexServer.FindResult findNextWorkflows(String searchId, int index, int maxResults);
		void findNextWorkflows(String searchId, int index, int maxResults, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Replaces control sequences in the text of a keyword.
		/// </summary>
		String cookKeyword(String kwid);
		void cookKeyword(String kwid, BAsyncResult<String> asyncResult) ;
		
		/// <summary>
		/// Moves an archive entry or creates a relation (logical copy).
		/// </summary>
		/// <remarks>
		/// <p>
		/// <b>1. Move</b><br/>
		/// To move an archive entry into another parent set bit <code>CopySordC.MOVE</code>
		/// in <code>copySordC</code>. Put the ID or GUID of the new parent into <code>newParentId</code>.
		/// If a reference shold be moved instead of an original, parameter <code>copyInfo</code> has to be passed with
		/// {@link CopyInfo#oldParentId} set to the current parent ID of the relation.
		/// In order to control the manual sort order, supply a <code>copyInfo</code> object with {@link CopyInfo#manSortIdx}.
		/// </p><p>
		/// <b>2. Relation</b><br/>
		/// Bit <code>CopySordC.REFERENCE</code> in <code>copySordC</code> should be used to
		/// create a logical copy of the archive entry in <code>newParentId</code>. <br/>
		/// Set <code>copyInfo=null</code> or supply an object and set the <code>CopyInfo.manSortIdx</code>
		/// to control the manual sort order. <br/>
		/// <p>References can be deleted with <code>deleteSord</code></p>
		/// </remarks>
		int copySord(String newParentId, String objId, EloixClient.IndexServer.CopyInfo copyInfo, EloixClient.IndexServer.CopySordZ copySordZ);
		void copySord(String newParentId, String objId, EloixClient.IndexServer.CopyInfo copyInfo, EloixClient.IndexServer.CopySordZ copySordZ, BAsyncResult<int> asyncResult) ;
		
		/// <summary>
		/// Creates a new document with indexing information.
		/// </summary>
		/// <remarks>
		/// </p><p>
		/// Currently the same as <code>createSord</code> but the type member of the
		/// returned indexing information (if any) is set to <code>SordC.LBT_DOCUMENT</code>.
		/// </p><p>
		/// If <code>maskId</code> is null or empty, the function tries to assign the
		/// mask defined in the configuration options of the Windows CLIENT.
		/// If this mask cannot be found, the behavior is unpredictable and
		/// -1 might be returned in sord.mask.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.EditInfo createDoc(String parentId, String maskId, String docTemplate, EloixClient.IndexServer.EditInfoZ editInfoZ);
		void createDoc(String parentId, String maskId, String docTemplate, EloixClient.IndexServer.EditInfoZ editInfoZ, BAsyncResult<EloixClient.IndexServer.EditInfo> asyncResult) ;
		
		/// <summary>
		/// Creates a storage mask object and assigns default values.
		/// </summary>
		/// <remarks>
		/// <p>
		/// This function does not insert the mask object into the database. Initial
		/// values can be copied from the mask specified with <code>maskId</code>.<p>
		/// </remarks>
		EloixClient.IndexServer.DocMask createDocMask(String maskId);
		void createDocMask(String maskId, BAsyncResult<EloixClient.IndexServer.DocMask> asyncResult) ;
		
		/// <summary>
		/// Creates and initializes a key object.
		/// </summary>
		EloixClient.IndexServer.KeyInfo createKey();
		void createKey(BAsyncResult<EloixClient.IndexServer.KeyInfo> asyncResult) ;
		
		/// <summary>
		/// Returns an initialized, temporary Note object.
		/// </summary>
		EloixClient.IndexServer.Note createNote(String objId);
		void createNote(String objId, BAsyncResult<EloixClient.IndexServer.Note> asyncResult) ;
		
		/// <summary>
		/// Returns an initialized, temporary Note object.
		/// </summary>
		/// <remarks>
		/// <p>The object is initialized by the given note template. Placeholders are
		/// replaced by the current values.</p>
		/// </remarks>
		EloixClient.IndexServer.Note createNote2(String objId, int noteType, String templId);
		void createNote2(String objId, int noteType, String templId, BAsyncResult<EloixClient.IndexServer.Note> asyncResult) ;
		
		/// <summary>
		/// Creates a reminder for the Sord specified by objId.
		/// </summary>
		EloixClient.IndexServer.Reminder createReminder(String objId);
		void createReminder(String objId, BAsyncResult<EloixClient.IndexServer.Reminder> asyncResult) ;
		
		/// <summary>
		/// Creates an object containing all the data needed to edit the
		/// indexing information of a new archive entry.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The function does not insert
		/// the new object into the database. <code>checkinSord</code> is used to insert a
		/// new object in the database.</p>
		/// <p>
		/// This function can also be used to retrieve the lists of storage masks, markers (colours)
		/// etc. For this purpose parameter <code>parentId=null</code> must be set along with
		/// <code>maskId=null</code> and supply <code>EditInfoC.mbBasicData</code> for <code>editInfoZ</code>.
		/// </p><p>
		/// To create and initialize an object for indexing information, parameter
		/// <code>editInfoZ</code> must include bit <code>EditInfoZ.mbSordMembers</code>, e. g. <code>EditInfoZ.mbSord</code>.
		/// Parameter <code>parentId</code> can specify the ID or GUID of the parent entry
		/// in the archive hierarchy. Access rights and replication information
		/// are initialized from the parent.
		/// </p><p>The <code>maskId</code> parameter
		/// is the name or ID of a storage mask that defines a template for the indexing
		/// information. If <code>maskId</code> is null or empty, the function tries to assign the
		/// mask with GUID <code>DocMaskC.GUID_FOLDER</code>. If this mask cannot be found, the
		/// default folder mask defined in the configuration options of the Windows CLIENT is used.
		/// If this mask is also not found, the behavior is unpredictable and a -1 might be returned in sord.mask.
		/// </p><p>
		/// The parameters <code>parentId</code> and <code>maskId</code> are unchecked if an event script
		/// {@link IXServerEvents#onCreateSord(IXServerEventsContext, String, String, EditInfoZ)} is configured.
		/// In this case, both can have arbitrary values.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.EditInfo createSord(String parentId, String maskId, EloixClient.IndexServer.EditInfoZ editInfoZ);
		void createSord(String parentId, String maskId, EloixClient.IndexServer.EditInfoZ editInfoZ, BAsyncResult<EloixClient.IndexServer.EditInfo> asyncResult) ;
		
		/// <summary>
		/// Creates an object for user data.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The returned <code>UserInfo</code> object is initialized with default values.
		/// User rights and keys are copied from the user <code>rightsAsUserId</code>.</p>
		/// 
		/// <p>This function does not create a new user in the archive database. To insert a new
		/// user into the database the function <code>checkinUsers</code> must be used after the user has been
		/// created with<code>createUser</code>.</p>
		/// 
		/// <p>If the user calling this function is a main administrator (has right
		/// AccessC.FLAG_ADMIN), the created user will have the same <code>UserInfo.parent</code>
		/// as the user specified in <code>rightsAsUserId</code>. If the user calling
		/// this function is a sub-administrator (has right AccessC.FLAG_SUBADMIN), the
		/// parent of the created user is the id of the calling user.</p>
		/// </remarks>
		EloixClient.IndexServer.UserInfo createUser(String rightsAsUserId);
		void createUser(String rightsAsUserId, BAsyncResult<EloixClient.IndexServer.UserInfo> asyncResult) ;
		
		/// <summary>
		/// Initalizes a WFNode object.
		/// </summary>
		/// <remarks>
		/// <p>WFNode.userId is set to WFNodeC.USERID_OWNER if the supplied type is a person node.</p>
		/// </remarks>
		EloixClient.IndexServer.WFNode createWFNode(int nodeId, int nodeTypeC);
		void createWFNode(int nodeId, int nodeTypeC, BAsyncResult<EloixClient.IndexServer.WFNode> asyncResult) ;
		
		/// <summary>
		/// Prepares a WFDiagram structure.
		/// </summary>
		EloixClient.IndexServer.WFDiagram createWorkFlow(String wfName, EloixClient.IndexServer.WFTypeZ typeZ);
		void createWorkFlow(String wfName, EloixClient.IndexServer.WFTypeZ typeZ, BAsyncResult<EloixClient.IndexServer.WFDiagram> asyncResult) ;
		
		/// <summary>
		/// Deletes configuration files.
		/// </summary>
		void deleteConfigFiles(String[] names, EloixClient.IndexServer.LockZ unlockZ);
		void deleteConfigFiles(String[] names, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Delete counters.
		/// </summary>
		/// <remarks>
		/// <p>This function is currently not implemented and always throws
		/// an exception. Counters cannot be deleted.</p>
		/// </remarks>
		void deleteCounters(String[] counterNames, EloixClient.IndexServer.LockZ unlockZ);
		void deleteCounters(String[] counterNames, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Deletes a storage mask.
		/// </summary>
		/// <remarks>
		/// </p><p>
		/// If archive entries connected to the mask still exist in the database, another
		/// mask <code>assignMaskId</code> can be assigned to them.
		/// </p><p>
		/// If <code>assignMaskId</code> is not defined and there are objects connected
		/// to the mask in the database the method throws an exception.
		/// </p><p>
		/// </remarks>
		bool deleteDocMask(String maskId, String assignMaskId, EloixClient.IndexServer.LockZ unlockZ);
		void deleteDocMask(String maskId, String assignMaskId, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<bool> asyncResult) ;
		
		/// <summary>
		/// Deletes keys.
		/// </summary>
		/// <remarks>
		/// <p>
		/// Since the function requires an exclusive access to the user data, the data
		/// must be locked for the current user or must not be locked for anyone. To
		/// check in regardless of a lock supply <code>lockZ.FORCE</code>
		/// in <code>lockZ</code>.
		/// </remarks>
		void deleteKeys(String[] ids, EloixClient.IndexServer.LockZ unlockZ);
		void deleteKeys(String[] ids, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Deletes the keywords with the given IDs.
		/// </summary>
		/// <remarks>
		/// <p><b>IMPORTANT: This function assigns new IDs to all branches of the
		/// keyword trees below the parent keywords of the given IDs.
		/// The client program should read the parent keyword and all children below
		/// again to receive the new IDs. </b></p>
		/// <p>The access rights <code>AccessC.FLAG_EDITCONFIG</code> and
		/// <code>AccessC.FLAG_EDITSWL</code> are required to delete keywords.<p>
		/// </remarks>
		void deleteKeywords(String[] kwids, EloixClient.IndexServer.LockZ unlockZ);
		void deleteKeywords(String[] kwids, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Deletes notes.
		/// </summary>
		/// <remarks>
		/// <p>After a note or annotation has been deleted it should not be checked in again with MbAll. In
		/// this case the isDeleted() value is overwritten and the note or annotation will no longer be
		/// deleted. In this case MbOnlyLock should be used to remove the lock on the notes.</p>
		/// </remarks>
		void deleteNotes(String[] noteIds, EloixClient.IndexServer.LockZ unlockZ);
		void deleteNotes(String[] noteIds, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Deleting the Notification identified by objGuid / userGuid combination
		/// if the Notification has child Notifications, they will be deleted as well.
		/// </summary>
		int deleteNotification(String objGuid, String userGuid);
		void deleteNotification(String objGuid, String userGuid, BAsyncResult<int> asyncResult) ;
		
		/// <summary>
		/// Deletes the reminders (logically) with the the given IDs.
		/// </summary>
		void deleteReminders(int[] reminderIds, EloixClient.IndexServer.LockZ unlockZ);
		void deleteReminders(int[] reminderIds, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Deletes report entries until <code>endDateISO</code>.
		/// </summary>
		void deleteReport(String endDateISO);
		void deleteReport(String endDateISO, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Deletes an archive entry and all child entries or deletes a relation (logical copy).
		/// </summary>
		/// <remarks>
		/// </p><p>
		/// A reference is deleted if <code>parentId</code> specifies an entry which is
		/// not the main parent of <code>objId</code>. The main parent can be found
		/// in <code>Sord.parent</code> after reading the indexing information for
		/// <code>objId</code> using <code>checkoutSord</code>. References are never deleted physically.
		/// </p><p>
		/// A archive entry is deleted if <code>parentId</code> is set to <code>null</code>
		/// or the id of its main parent.
		/// </p><p>
		/// If <code>deleteFinally=true</code>, all already logically deleted objects in the subtree of objId will be deleted physically.
		/// All related data (document versions, attachments, workflows, etc.) will also be physically deleted. Use this parameter with caution,
		/// since a reverse operation does not exist.
		/// </p><p>
		/// To delete logically set <code>deleteFinally=false</code>, which only sets the the delete flag within the database.
		/// </p><p>
		/// </remarks>
		bool deleteSord(String parentId, String objId, EloixClient.IndexServer.LockZ unlockZ, EloixClient.IndexServer.DeleteOptions deleteOptions);
		void deleteSord(String parentId, String objId, EloixClient.IndexServer.LockZ unlockZ, EloixClient.IndexServer.DeleteOptions deleteOptions, BAsyncResult<bool> asyncResult) ;
		
		/// <summary>
		/// Write or insert sord type information.
		/// </summary>
		void deleteSordTypes(int[] sordTypeIds, EloixClient.IndexServer.LockZ unlockZ);
		void deleteSordTypes(int[] sordTypeIds, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Delete deputy information.
		/// </summary>
		void deleteSubs(EloixClient.IndexServer.SubsInfo[] deps, EloixClient.IndexServer.LockZ unlockZ);
		void deleteSubs(EloixClient.IndexServer.SubsInfo[] deps, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Deletes profile options.
		/// </summary>
		void deleteUserProfile(EloixClient.IndexServer.UserProfile userProfile, EloixClient.IndexServer.LockZ unlockZ);
		void deleteUserProfile(EloixClient.IndexServer.UserProfile userProfile, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Deletes users or groups.
		/// </summary>
		/// <remarks>
		/// </p><p>
		/// Since this function requires exclusive access to the user data, the data
		/// must be locked for the current user or must not be locked for anyone. To
		/// check in regardless of a lock  <code>lockZ.FORCE</code>
		/// in <code>lockZ</code> must be supplied.
		/// </remarks>
		void deleteUsers(String[] ids, EloixClient.IndexServer.LockZ unlockZ);
		void deleteUsers(String[] ids, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Deletes a workflow.
		/// </summary>
		/// <remarks>
		/// <p> WOrkflows that are deleted are not physically deleted and can be retrieved using checkoutWorkFlow().
		/// Deleted workflows return true when the WFDiagram.isDeleted() method is called.</p>
		/// </remarks>
		void deleteWorkFlow(String flowId, EloixClient.IndexServer.WFTypeZ typeZ, EloixClient.IndexServer.LockZ unlockZ);
		void deleteWorkFlow(String flowId, EloixClient.IndexServer.WFTypeZ typeZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Stores an edited person node of an active workflow into the database and unlocks the workflow.
		/// </summary>
		/// <remarks>
		/// <p>The workflow is forwarded to the successor nodes as passed in parameter <code>arrEnterNodesIds</code>.</p>
		/// </remarks>
		void endEditWorkFlowNode(int nFlowId, int nNodeId, bool bTerminate, bool bCancel, String sName, String sComment, int[] arrEnterNodesIds);
		void endEditWorkFlowNode(int nFlowId, int nNodeId, bool bTerminate, bool bCancel, String sName, String sComment, int[] arrEnterNodesIds, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Deletes the search results explicitly in the IndexServer process to save memory.
		/// </summary>
		void findClose(String searchId);
		void findClose(String searchId, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Finds configuration or postbox files.
		/// </summary>
		EloixClient.IndexServer.FindResult findFirstConfigFiles(EloixClient.IndexServer.FindConfigFileInfo findInfo, int max, EloixClient.IndexServer.ConfigFileZ configFileZ);
		void findFirstConfigFiles(EloixClient.IndexServer.FindConfigFileInfo findInfo, int max, EloixClient.IndexServer.ConfigFileZ configFileZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Finds report entries.
		/// </summary>
		EloixClient.IndexServer.FindResult findFirstReportInfos(EloixClient.IndexServer.FindReportInfo opts, int max);
		void findFirstReportInfos(EloixClient.IndexServer.FindReportInfo opts, int max, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Find archive entries and retrieve  the first <code>max</code> objects.
		/// </summary>
		/// <remarks>
		/// <p>
		/// This function performs a search over indexing information, full text,
		/// or hierarchy (child lists).
		/// </p><p>
		/// It returns either an ID array or a <code>Sord</code> object array. The maximum
		/// array length is restricted to the value of the <code>max</code> parameter.
		/// Further results can be read with <code>findNextSords</code> using the search ID
		/// <code>FindResult.searchId</code> returned by this function. The search ID has
		/// a limited lifetime which can be configured. The default value is 5 minutes.
		/// The search results can be explicitly deleted with <code>findClose</code> to
		/// save memory on the server side.
		/// </p>
		/// <p>
		/// This function does not write report entries ReportInfoC.ACT_IX_CHECKOUT_SORD for
		/// the results although it can return as much indexing information as checkoutSord does.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.FindResult findFirstSords(EloixClient.IndexServer.FindInfo findInfo, int max, EloixClient.IndexServer.SordZ sordZ);
		void findFirstSords(EloixClient.IndexServer.FindInfo findInfo, int max, EloixClient.IndexServer.SordZ sordZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Finds reminders, activities and active workflow nodes.
		/// </summary>
		EloixClient.IndexServer.FindResult findFirstTasks(EloixClient.IndexServer.FindTasksInfo findInfo, int max);
		void findFirstTasks(EloixClient.IndexServer.FindTasksInfo findInfo, int max, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Finds next configuration files.
		/// </summary>
		EloixClient.IndexServer.FindResult findNextConfigFiles(String searchId, int idx, int max, EloixClient.IndexServer.ConfigFileZ configFileZ);
		void findNextConfigFiles(String searchId, int idx, int max, EloixClient.IndexServer.ConfigFileZ configFileZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Finds report entries.
		/// </summary>
		EloixClient.IndexServer.FindResult findNextReportInfos(String searchId, int idx, int max);
		void findNextReportInfos(String searchId, int idx, int max, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Retrieves further results of a previous search with <code>findFirstSords</code>.
		/// </summary>
		EloixClient.IndexServer.FindResult findNextSords(String searchId, int idx, int max, EloixClient.IndexServer.SordZ sordZ);
		void findNextSords(String searchId, int idx, int max, EloixClient.IndexServer.SordZ sordZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Continues the find process started with findFirstTasks.
		/// </summary>
		EloixClient.IndexServer.FindResult findNextTasks(String searchId, int idx, int max);
		void findNextTasks(String searchId, int idx, int max, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Removes temp-files after an export.
		/// </summary>
		/// <remarks>
		/// <p>This method should be called, after the generated
		/// ZIP-archive has been successfully downloaded.</p>
		/// </remarks>
		void finishExport(String exportId);
		void finishExport(String exportId, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Retrieves the constants.
		/// </summary>
		/// <remarks>
		/// <p>Constants are provided as objects to provide the advantage of type checking.
		/// (Java 1.4 does not support enumeration types).</p>
		/// </remarks>
		EloixClient.IndexServer.IXServicePortC getConstants();
		void getConstants(BAsyncResult<EloixClient.IndexServer.IXServicePortC> asyncResult) ;
		
		/// <summary>
		/// Gets the URL for downloading the generated ZIP-archive of this export.
		/// </summary>
		String getExportZipUrl(String exportId);
		void getExportZipUrl(String exportId, BAsyncResult<String> asyncResult) ;
		
		/// <summary>
		/// Retrieves the URL for uploading the ZIP-archive for this import.
		/// </summary>
		String getImportZipUrl(String importId);
		void getImportZipUrl(String importId, BAsyncResult<String> asyncResult) ;
		
		/// <summary>
		/// Retrieves configurational information, e.g. license key, additional IndexServers, etc
		/// </summary>
		EloixClient.IndexServer.ServerInfo getServerInfo();
		void getServerInfo(BAsyncResult<EloixClient.IndexServer.ServerInfo> asyncResult) ;
		
		/// <summary>
		/// Sets the writable members of ServerInfo.
		/// </summary>
		void setServerInfo(EloixClient.IndexServer.ServerInfo serverInfo);
		void setServerInfo(EloixClient.IndexServer.ServerInfo serverInfo, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Gets DM configuration information.
		/// </summary>
		EloixClient.IndexServer.ServerInfoDM getServerInfoDM();
		void getServerInfoDM(BAsyncResult<EloixClient.IndexServer.ServerInfoDM> asyncResult) ;
		
		/// <summary>
		/// Sets the writable members of the DM configuration.
		/// </summary>
		void setServerInfoDM(EloixClient.IndexServer.ServerInfoDM serverInfo);
		void setServerInfoDM(EloixClient.IndexServer.ServerInfoDM serverInfo, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Retrieve the current session options.
		/// </summary>
		EloixClient.IndexServer.SessionOptions getSessionOptions();
		void getSessionOptions(BAsyncResult<EloixClient.IndexServer.SessionOptions> asyncResult) ;
		
		/// <summary>
		/// Reads user or group names and IDs.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The method performs an internal call to <code>checkoutUsers</code>. <b>Note:</b> Only
		/// the names and IDs are returned and not the complete user data.
		/// </p><p>
		/// If the current user is assigned to organisation units, the function returns only
		/// users and groups assigned to at least one of the users organisation units.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.UserName[] getUserNames(String[] ids, EloixClient.IndexServer.CheckoutUsersZ checkoutUsersZ);
		void getUserNames(String[] ids, EloixClient.IndexServer.CheckoutUsersZ checkoutUsersZ, BAsyncResult<EloixClient.IndexServer.UserName[]> asyncResult) ;
		
		/// <summary>
		/// Imports a workflow template from a file.
		/// </summary>
		/// <remarks>
		/// <p>To export a workflow template
		/// into a file, use the workflow design dialogue in ELO-CLIENT.</p>
		/// </remarks>
		int importWorkFlow(String flowName, byte[] fileData);
		void importWorkFlow(String flowName, byte[] fileData, BAsyncResult<int> asyncResult) ;
		
		/// <summary>
		/// Imports a workflow template from a file.
		/// </summary>
		/// <remarks>
		/// <p>To export a workflow template
		/// into a file, use the workflow design dialogue in ELO-CLIENT.</p>
		/// </remarks>
		int importWorkFlow2(String flowName, byte[] fileData, EloixClient.IndexServer.WorkflowImportOptions importOptions);
		void importWorkFlow2(String flowName, byte[] fileData, EloixClient.IndexServer.WorkflowImportOptions importOptions, BAsyncResult<int> asyncResult) ;
		
		/// <summary>
		/// Links archive entries.
		/// </summary>
		/// <remarks>
		/// <p>Links are associations between archive entries and are
		/// independent from the archive hierarchy.
		/// </p><p>
		/// The links to or from an archive entry are listed in <code>Sord.linksGoOut</code>
		/// and <code>Sord.linksComeIn</code>. In the database structure and in the Indexserver API,
		/// links are vectors that point from one Sord to one or more other Sords. But the client applications
		/// usually do not take care of the direction. They add the links found in Sord.linksGoOut and
		/// Sord.linksComeIn in order to show the liked objects.
		/// </p><p>
		/// There are two different types of links: pairs and cross-links. A pair connects exactly two
		/// Sord objects. Each pair has its own link-ID in the database. A cross-link connects a group of objects
		/// under the same link-ID. At the first glance it seems, that each object has a pair-link to each other object.
		/// But there is a significant difference when deleting links.
		/// E.g. if the Sord objects sord1, sord2, sord3 are connected with a cross-link, function checkoutSord will return
		/// for sord1: {sord2, sord3}, sord2: {sord1, sord3} and sord3: {sord1, sord2}. If function unlinkSords
		/// is called for the link sord1-sord2 (fromSord=sord1, toSords=[sord2]), the next calls to checkoutSord will return
		/// for sord1: {sord3}, sord2: {}, sord3: {sord1}. If the objects were connected by pair-links, the result would
		/// be sord1: {sord3}, sord2: {sord3}, sord3: {sord1, sord2}.
		/// </p>
		/// </remarks>
		void linkSords(String fromId, String[] toIds, EloixClient.IndexServer.LinkSordZ linkZ);
		void linkSords(String fromId, String[] toIds, EloixClient.IndexServer.LinkSordZ linkZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Locks the archive with the specified key or retrieves the lock on the archive.
		/// </summary>
		/// <remarks>
		/// <p>If no key is specified (null or empty string), the current archive key is returned.
		/// To unlock the archive, call this function with <code>keyId="0"</code>.</p>
		/// </remarks>
		int lockArchive(String keyId);
		void lockArchive(String keyId, BAsyncResult<int> asyncResult) ;
		
		/// <summary>
		/// Log on to IndexServer.
		/// </summary>
		/// <remarks>
		/// <p>If the function succeeds, the return value is an object containing a ticket
		/// that allows access to all the other interface functions.
		/// </p><p>This ticket has a limited lifetime as returned in <code>LoginResult.ticketDuration</code>.
		/// The life time can be extended by calling <code>alive</code>.
		/// </p><p>The <code>runAsUser</code> parameter is used in Single-Sign-On environments.
		/// The login is performed for every user with the same SSO account specific to the application
		/// and the <runAsUser> parameter specifies the security context for the IndexServer
		/// connection. The SSO account must have administrator privileges.
		/// </p><p>
		/// <p><b>Examples:</b></p>
		/// <p>
		/// <code>// Initialize ClientInfo with language specific data </code><br/>
		/// <code>ClientInfo ci = new ClientInfo();</code><br/>
		/// <code>ci.setLanguage("de");</code><br/>
		/// <code>ci.setCountry("DE");</code><br/>
		/// <br/>
		/// <code>// Fritz logs on to IndexServer </code><br/>
		/// <code>LoginResult lr = eloix.login(ci, "Fritz", "fritzchen", "Fritz computer", null);</code><br/>
		/// <br/>
		/// <code>// The returned object contains a second ClientInfo object including the ticket. </code><br/>
		/// <code>// This ClientInfo should be used for all subsequent calls .</code><br/>
		/// <code>ci = lr.ci;</code><br/>
		/// <br/>
		/// <code>// Dump ticket and lifetime. </code><br/>
		/// <code>System.out.println("Ticket=" + ci.getTicket());</code><br/>
		/// <code>System.out.println("Lifetime=" + lr.getTicketLifetime());</code><br/>
		/// <br/>
		/// <code>// Logout </code><br/>
		/// <code>eloix.logout(ci);</code><br/>
		/// </p>
		/// 
		/// <p><b>Example for Single-Sign-On:</b></p>
		/// <p>
		/// <code>// Initialize ClientInfo with language specific data.</code><br/>
		/// <code>ClientInfo ci = new ClientInfo();</code><br/>
		/// <code>ci.setLanguage("de");</code><br/>
		/// <code>ci.setCountry("DE");</code><br/>
		/// <br/>
		/// <code>// Fritz logs on to IndexServer with SSO account "MyApp" </code><br/>
		/// <code>LoginResult lr = eloix.login(ci, "MyApp", "myapp", "Fritz computer", "Fritz");</code><br/>
		/// <br/>
		/// <code>// The returned object contains a second ClientInfo object including the ticket. </code><br/>
		/// <code>// Use for all subsequent calls this ClientInfo.</code><br/>
		/// <code>ci = lr.ci;</code><br/>
		/// <br/>
		/// <code>// Dump ticket and lifetime. </code><br/>
		/// <code>System.out.println("Ticket=" + ci.getTicket());</code><br/>
		/// <code>System.out.println("Lifetime=" + lr.getTicketLifetime());</code><br/>
		/// <code>System.out.println("user=" + lr.getUser().getName()); // =Fritz </code><br/>
		/// <br/>
		/// <code>// Logout </code><br/>
		/// <code>eloix.logout(ci);</code><br/>
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.LoginResult login(String userName, String userPwd, String clientComputer, String runAsUser);
		void login(String userName, String userPwd, String clientComputer, String runAsUser, BAsyncResult<EloixClient.IndexServer.LoginResult> asyncResult) ;
		
		/// <summary>
		/// Login any user as an administrator.
		/// </summary>
		/// <remarks>
		/// <p>This function logs on the user given in <code>reportAsUser</code> as an
		/// administrator. The effective rights of the resulting session are not constrained
		/// to the rights of the given user.
		/// The client application is responsible for access checking.</p>
		/// </remarks>
		EloixClient.IndexServer.LoginResult loginAdmin(String userName, String userPwd, String clientComputer, String reportAsUser);
		void loginAdmin(String userName, String userPwd, String clientComputer, String reportAsUser, BAsyncResult<EloixClient.IndexServer.LoginResult> asyncResult) ;
		
		/// <summary>
		/// This login is used by ELOprofessional applications if the IndexServer is used to
		/// forward workflows (WorkflowServer).
		/// </summary>
		/// <remarks>
		/// <p>This login returns a limited connection to the
		/// IndexServer. It is not possible to access documents or user data.</p>
		/// </remarks>
		EloixClient.IndexServer.LoginResult loginEloProf(int userId, String certificate, String clientComputer);
		void loginEloProf(int userId, String certificate, String clientComputer, BAsyncResult<EloixClient.IndexServer.LoginResult> asyncResult) ;
		
		/// <summary>
		/// Login method fÃ¼r Kerberos.
		/// </summary>
		EloixClient.IndexServer.LoginResult loginKerberos(byte[] ticket, String clientComputer);
		void loginKerberos(byte[] ticket, String clientComputer, BAsyncResult<EloixClient.IndexServer.LoginResult> asyncResult) ;
		
		/// <summary>
		/// Log out user.
		/// </summary>
		/// <remarks>
		/// <p>The ticket contained in <code>ci</code> becomes invalid.</p>
		/// </remarks>
		void logout();
		void logout(BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Parses the given string of an exception into a structured IXExceptionData object.
		/// </summary>
		/// <remarks>
		/// <p>If the given string does not represent an IXException, the exceptionType NOT_IX
		/// is returned (value -1) and the given exception string can be found in "message".
		/// </remarks>
		EloixClient.IndexServer.IXExceptionData parseException(String exceptionString);
		void parseException(String exceptionString, BAsyncResult<EloixClient.IndexServer.IXExceptionData> asyncResult) ;
		
		/// <summary>
		/// Executes the processing information given by <code>processInfo</code> for all objects
		/// found by a <code>findFirstSords</code> call.
		/// </summary>
		EloixClient.IndexServer.JobState processFindResult(String searchId, EloixClient.IndexServer.ProcessInfo procInfo);
		void processFindResult(String searchId, EloixClient.IndexServer.ProcessInfo procInfo, BAsyncResult<EloixClient.IndexServer.JobState> asyncResult) ;
		
		/// <summary>
		/// <code>processTrees</code> extends ValueClass implements a generic tree walk for all subtrees specified in
		/// <code>navInfo</code>.
		/// </summary>
		/// <remarks>
		/// <p>Specific operations for each node are queued in <code>procInfo</code>
		/// and will be applied in order of appearance.</p>
		/// </remarks>
		EloixClient.IndexServer.JobState processTrees(EloixClient.IndexServer.NavigationInfo navigationInfo, EloixClient.IndexServer.ProcessInfo procInfo);
		void processTrees(EloixClient.IndexServer.NavigationInfo navigationInfo, EloixClient.IndexServer.ProcessInfo procInfo, BAsyncResult<EloixClient.IndexServer.JobState> asyncResult) ;
		
		/// <summary>
		/// Returns the job state for a given job GUID.
		/// </summary>
		EloixClient.IndexServer.JobState queryJobState(String jobGuid, bool activeJobs, bool finishedJobs, bool fullInfo);
		void queryJobState(String jobGuid, bool activeJobs, bool finishedJobs, bool fullInfo, BAsyncResult<EloixClient.IndexServer.JobState> asyncResult) ;
		
		/// <summary>
		/// Creates a new object relationship.
		/// </summary>
		void refSord(String oldParentId, String newParentId, String objId, int manSortIdx);
		void refSord(String oldParentId, String newParentId, String objId, int manSortIdx, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Restores an archive entry, its references and notes.
		/// </summary>
		/// <remarks>
		/// <p>
		/// Passing true for <code>singleObject</code> restores only the object represented by
		/// <code>objId</code>.<br/> Otherwise, the complete subtree beginning at <code>objId</code> will be restored.
		/// </p><p>
		/// </remarks>
		bool restoreSord(String objId, EloixClient.IndexServer.RestoreOptions restoreOptions);
		void restoreSord(String objId, EloixClient.IndexServer.RestoreOptions restoreOptions, BAsyncResult<bool> asyncResult) ;
		
		/// <summary>
		/// This function sets options related to the session identified by the given
		/// ticket.
		/// </summary>
		void setSessionOptions(EloixClient.IndexServer.SessionOptions opts);
		void setSessionOptions(EloixClient.IndexServer.SessionOptions opts, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Starts an Ad Hoc Workflow.
		/// </summary>
		int startAdHocWorkFlow(String name, String objId, String[] arrUserIds, String nodeName, bool forValidation, bool serialFlow, String cancelUserId, String cancelMessage, String finishedUserId, String finishedMessage, String finishedScript);
		void startAdHocWorkFlow(String name, String objId, String[] arrUserIds, String nodeName, bool forValidation, bool serialFlow, String cancelUserId, String cancelMessage, String finishedUserId, String finishedMessage, String finishedScript, BAsyncResult<int> asyncResult) ;
		
		/// <summary>
		/// Starts an export-job.
		/// </summary>
		/// <remarks>
		/// <p>The given IDs and their children will be exported as specified in the
		/// options.</p>
		/// </remarks>
		String startExport(String[] topLevelIDs, long options);
		void startExport(String[] topLevelIDs, long options, BAsyncResult<String> asyncResult) ;
		
		/// <summary>
		/// Starts an export-job.
		/// </summary>
		/// <remarks>
		/// <p>This is an enhanced version which works with the
		/// same options as the ones in Windows Client</p>
		/// </remarks>
		String startExportExt(EloixClient.IndexServer.ExportExtOptions options);
		void startExportExt(EloixClient.IndexServer.ExportExtOptions options, BAsyncResult<String> asyncResult) ;
		
		/// <summary>
		/// Starts an import-job.
		/// </summary>
		/// <remarks>
		/// <p>The given IDs and their children will be imported as specified in the
		/// options.</p>
		/// </remarks>
		String startImport(String filingPath, int guidMethod, long options);
		void startImport(String filingPath, int guidMethod, long options, BAsyncResult<String> asyncResult) ;
		
		/// <summary>
		/// Starts a workflow from a workflow template.
		/// </summary>
		int startWorkFlow(String templFlowId, String flowName, String objId);
		void startWorkFlow(String templFlowId, String flowName, String objId, BAsyncResult<int> asyncResult) ;
		
		/// <summary>
		/// Assign a node to a user.
		/// </summary>
		/// <remarks>
		/// <p>This function is useful in two situations:<br/>
		/// 1. A user calls this function to assume a task for exclusive use.
		/// The task must be assigned to one of the user s groups or to a user
		/// substituted by the current user. Supply an empty <code>sUserId</code>.<br/>
		/// 2. A user calls this function to pass the task to another user. The task
		/// must be assigned to the current user. Supply any user name or ID in sUserId.
		/// </p>
		/// The function assigns in addition to the given node all nodes with the same {@link WFNode#departmentGroup}.
		/// </remarks>
		void takeWorkFlowNode(int nFlowId, int nNodeId, String sUserId, int nFlags, EloixClient.IndexServer.LockZ lockZ);
		void takeWorkFlowNode(int nFlowId, int nNodeId, String sUserId, int nFlags, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Terminates a workflow.
		/// </summary>
		int terminateWorkFlow(String flowId, EloixClient.IndexServer.LockZ unlockZ);
		void terminateWorkFlow(String flowId, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<int> asyncResult) ;
		
		/// <summary>
		/// Delegates the specified workflow node to another user.
		/// </summary>
		/// <remarks>
		/// <p>An additional person node is inserted into the workflow for the given user and the
		/// workflow is forwarded to this node. If {@link WFDelegateNodeInfo#backNodeName} is set,
		/// a further node is added after the delegation node for the current user.</p>
		/// </remarks>
		void delegateWorkFlowNode(EloixClient.IndexServer.WFDelegateNodeInfo delegateNodeInfo, EloixClient.IndexServer.LockZ lockZ);
		void delegateWorkFlowNode(EloixClient.IndexServer.WFDelegateNodeInfo delegateNodeInfo, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// <p>Sets the value userDelayDateIso of the given node.
		/// </summary>
		/// <remarks>
		/// </p>
		/// </remarks>
		void deferWorkFlowNode(String flowId, int nodeId, String userDelayDateIso, EloixClient.IndexServer.LockZ lockZ);
		void deferWorkFlowNode(String flowId, int nodeId, String userDelayDateIso, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This function is used for testing.
		/// </summary>
		/// <remarks>
		/// <p>In productive environments it always throws
		/// an exception.</p>
		/// </remarks>
		String[] testAdapter(String fn, String[] @params);
		void testAdapter(String fn, String[] @params, BAsyncResult<String[]> asyncResult) ;
		
		/// <summary>
		/// Remove links between archive entries.
		/// </summary>
		void unlinkSords(String fromId, String[] toIds, EloixClient.IndexServer.LinkSordZ linkZ);
		void unlinkSords(String fromId, String[] toIds, EloixClient.IndexServer.LinkSordZ linkZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Read and optionally lock the password information for document encryption.
		/// </summary>
		EloixClient.IndexServer.CryptInfo[] checkoutCryptInfos(String[] ids, EloixClient.IndexServer.LockZ lockZ);
		void checkoutCryptInfos(String[] ids, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.CryptInfo[]> asyncResult) ;
		
		/// <summary>
		/// Write and optionally unlock encryption information.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The passwords supplied in cryptInfos must be encrypted with the
		/// IXClient.encryptPassword function.
		/// </p><p>
		/// Administrators are allowed to alter internal keys and encryption set names.
		/// <table border="2">
		/// <tr><td>cryptInfos[.].keyInfo</td><td>Description</td></tr>
		/// <tr><td>*</td><td>Generate new internal keys and set cryptInfos[.].pwd as external password.</td></tr>
		/// <tr><td>Value from another ELO system</td><td>Set this value as internal and external key pair. cryptInfos[.].pwd is ignored.</td></tr>
		/// </table>
		/// </p>
		/// </remarks>
		void checkinCryptInfos(EloixClient.IndexServer.CryptInfo[] cryptInfos, EloixClient.IndexServer.LockZ unlockZ);
		void checkinCryptInfos(EloixClient.IndexServer.CryptInfo[] cryptInfos, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Provide a password to be used in the current session for encrypting and
		/// decrypting of documents.
		/// </summary>
		/// <remarks>
		/// <p>The given password must be encrypted with the IXClient.encryptPassword
		/// function to hide it from administrators. An unencrypted password will cause
		/// an exception.
		/// </p><p>
		/// To use the encryption/decryption functionality of IndexServer, the
		/// session option &lt;ix.encryptDocuments&gt; resp. &lt;ix.decryptDocuments&gt;
		/// has to be &lt;true&gt;.
		/// Then, IndexServer generates special URLs that cause it to encrypt documents on
		/// upload and decrypt documents on download.
		/// </p>
		/// Be aware of the fact that encryption/decryption happens between IndexServer
		/// and Document Manager communication and not between IndexServer and the client
		/// application. Thus it is strongly recommended to use HTTPS between the client
		/// application and IndexServer. The IndexServer configuration option
		/// &quot;ixUrlBase&quot; can be helpful to achieve this.
		/// </remarks>
		void provideCryptPassword(String encryptionSet, String pwd);
		void provideCryptPassword(String encryptionSet, String pwd, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Invalidate the internally used caches for users, storage masks, etc.
		/// </summary>
		void invalidateCache(int flags);
		void invalidateCache(int flags, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Invalidate the internally used caches.
		/// </summary>
		EloixClient.IndexServer.InvalidateCacheResult invalidateCache2(EloixClient.IndexServer.InvalidateCacheInfo info);
		void invalidateCache2(EloixClient.IndexServer.InvalidateCacheInfo info, BAsyncResult<EloixClient.IndexServer.InvalidateCacheResult> asyncResult) ;
		
		/// <summary>
		/// Find terms for which a translation is available.
		/// </summary>
		/// <remarks>
		/// <p>Close the search results with a call to findClose.</p>
		/// </remarks>
		EloixClient.IndexServer.FindResult findFirstTranslateTerms(EloixClient.IndexServer.FindTranslateTermInfo findInfo, int max);
		void findFirstTranslateTerms(EloixClient.IndexServer.FindTranslateTermInfo findInfo, int max, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Find next terms.
		/// </summary>
		EloixClient.IndexServer.FindResult findNextTranslateTerms(String searchId, int idx, int max);
		void findNextTranslateTerms(String searchId, int idx, int max, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Read terms from translation table for viewing or editing.
		/// </summary>
		/// <remarks>
		/// <p>
		/// It can also be used to retrieve the supported languages.
		/// Use this function, if only a few terms should be returned.
		/// Otherwise call <code>findFirstTranslateTerms</code>.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.TranslateTerm[] checkoutTranslateTerms(String[] termIds, EloixClient.IndexServer.LockZ lockZ);
		void checkoutTranslateTerms(String[] termIds, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.TranslateTerm[]> asyncResult) ;
		
		/// <summary>
		/// Write or insert terms into the translation table.
		/// </summary>
		/// <remarks>
		/// <p>
		/// This function should not be called frequently, because it causes the translation cache to be reloaded.
		/// </p>
		/// </remarks>
		String[] checkinTranslateTerms(EloixClient.IndexServer.TranslateTerm[] tterms, EloixClient.IndexServer.LockZ unlockZ);
		void checkinTranslateTerms(EloixClient.IndexServer.TranslateTerm[] tterms, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<String[]> asyncResult) ;
		
		/// <summary>
		/// Delete terms from the translation table.
		/// </summary>
		/// <remarks>
		/// <p>
		/// This function should not be called frequently, because it causes the translation cache to be reloaded.
		/// </p>
		/// </remarks>
		void deleteTranslateTerms(String[] termIds, EloixClient.IndexServer.LockZ unlockZ);
		void deleteTranslateTerms(String[] termIds, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Reads the version information of all versions of the given workflow.
		/// </summary>
		EloixClient.IndexServer.WFVersion[] getWorkflowTemplateVersions(String flowId, bool onlyDeleted);
		void getWorkflowTemplateVersions(String flowId, bool onlyDeleted, BAsyncResult<EloixClient.IndexServer.WFVersion[]> asyncResult) ;
		
		/// <summary>
		/// Check out versions of a workflow template.
		/// </summary>
		EloixClient.IndexServer.WFDiagram checkoutWorkflowTemplate(String flowId, String versionId, EloixClient.IndexServer.WFDiagramZ wfZ, EloixClient.IndexServer.LockZ lockZ);
		void checkoutWorkflowTemplate(String flowId, String versionId, EloixClient.IndexServer.WFDiagramZ wfZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.WFDiagram> asyncResult) ;
		
		/// <summary>
		/// Check in a workflow template as a new version or overwrite an existing version.
		/// </summary>
		int[] checkinWorkflowTemplate(EloixClient.IndexServer.WFDiagram wf, EloixClient.IndexServer.WFDiagramZ wfZ, EloixClient.IndexServer.LockZ unlockZ);
		void checkinWorkflowTemplate(EloixClient.IndexServer.WFDiagram wf, EloixClient.IndexServer.WFDiagramZ wfZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<int[]> asyncResult) ;
		
		/// <summary>
		/// Deletes a workflow template version.
		/// </summary>
		void deleteWorkflowTemplate(String flowId, String versionId, EloixClient.IndexServer.LockZ unlockZ);
		void deleteWorkflowTemplate(String flowId, String versionId, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Read the stamp definitions from the users options.
		/// </summary>
		EloixClient.IndexServer.NoteTemplate[] checkoutNoteTemplates(String userId, String[] ids, EloixClient.IndexServer.NoteTemplateZ ntemplZ, EloixClient.IndexServer.LockZ lockZ);
		void checkoutNoteTemplates(String userId, String[] ids, EloixClient.IndexServer.NoteTemplateZ ntemplZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.NoteTemplate[]> asyncResult) ;
		
		/// <summary>
		/// Initializes a new NoteTemplate object.
		/// </summary>
		EloixClient.IndexServer.NoteTemplate createNoteTemplate(String userId);
		void createNoteTemplate(String userId, BAsyncResult<EloixClient.IndexServer.NoteTemplate> asyncResult) ;
		
		/// <summary>
		/// Delete the stamp definition with the given ID.
		/// </summary>
		void deleteNoteTemplates(String userId, String[] ids, EloixClient.IndexServer.LockZ unlockZ);
		void deleteNoteTemplates(String userId, String[] ids, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Writes the given stamp definition into the database.
		/// </summary>
		int[] checkinNoteTemplates(EloixClient.IndexServer.NoteTemplate[] noteTemplates, EloixClient.IndexServer.NoteTemplateZ ntemplZ, EloixClient.IndexServer.LockZ unlockZ);
		void checkinNoteTemplates(EloixClient.IndexServer.NoteTemplate[] noteTemplates, EloixClient.IndexServer.NoteTemplateZ ntemplZ, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<int[]> asyncResult) ;
		
		/// <summary>
		/// This function reloads all internal objects.
		/// </summary>
		/// <remarks>
		/// <p>
		/// Call this function with administrator privileges,
		/// if configuration options,
		/// scripts or configuration files are modified.
		/// Current sessions and processes are tried to be kept alive.
		/// But under some conditions, sessions get lost and running
		/// processes terminate with an exception!
		/// </p>
		/// </remarks>
		void reload();
		void reload(BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This function reloads all scripts.
		/// </summary>
		/// <remarks>
		/// <p>
		/// Call this function with administrator privileges,
		/// </p>
		/// if some scripts are modified.
		/// </remarks>
		void reloadScripts();
		void reloadScripts(BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This function returns a map containing information of all compiled scripts.
		/// </summary>
		IDictionary<int,String> getCompiledScripts();
		void getCompiledScripts(BAsyncResult<IDictionary<int,String>> asyncResult) ;
		
		/// <summary>
		/// This function returns the list of the scripts which are currently debugged,
		/// i.e. the property "scriptsToDebug".
		/// </summary>
		String getScriptsToDebug();
		void getScriptsToDebug(BAsyncResult<String> asyncResult) ;
		
		/// <summary>
		/// This function allows to set the the property "scriptsToDebug".
		/// </summary>
		void setScriptsToDebug(String scriptsToDebug);
		void setScriptsToDebug(String scriptsToDebug, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This function returns debugger's port.
		/// </summary>
		int getDebuggerPort();
		void getDebuggerPort(BAsyncResult<int> asyncResult) ;
		
		/// <summary>
		/// Deletes a keyword list.
		/// </summary>
		void deleteKeywordList(String kwid, EloixClient.IndexServer.LockZ unlockZ);
		void deleteKeywordList(String kwid, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Reads a keyword list.
		/// </summary>
		/// <remarks>
		/// <p>
		/// This function internally calls checkoutKeywords.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.KeywordList checkoutKeywordList(String kwid, EloixClient.IndexServer.KeywordZ keywordZ, int max, EloixClient.IndexServer.LockZ lockZ);
		void checkoutKeywordList(String kwid, EloixClient.IndexServer.KeywordZ keywordZ, int max, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.KeywordList> asyncResult) ;
		
		/// <summary>
		/// Write or insert a keyword list.
		/// </summary>
		/// <remarks>
		/// <p>
		/// This function internally calls checkinKeywords.
		/// </p>
		/// </remarks>
		void checkinKeywordList(EloixClient.IndexServer.KeywordList kwList, EloixClient.IndexServer.LockZ unlockZ);
		void checkinKeywordList(EloixClient.IndexServer.KeywordList kwList, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Compares the given ACLs and computes the sum, difference and intersection.
		/// </summary>
		/// <remarks>
		/// <p>
		/// To remove the duplicate entries in an ACL, call this function with a null value for the rhs parameter.
		/// The CombineAclResult.sum contains the ACL without duplicates.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.CombineAclResult combineAcl(EloixClient.IndexServer.AclItem[] lhs, EloixClient.IndexServer.AclItem[] rhs, EloixClient.IndexServer.CombineAclOptions options);
		void combineAcl(EloixClient.IndexServer.AclItem[] lhs, EloixClient.IndexServer.AclItem[] rhs, EloixClient.IndexServer.CombineAclOptions options, BAsyncResult<EloixClient.IndexServer.CombineAclResult> asyncResult) ;
		
		/// <summary>
		/// Returns the access of the given ACL.
		/// </summary>
		EloixClient.IndexServer.AclAccessResult getAclAccess(EloixClient.IndexServer.AclAccessInfo aai);
		void getAclAccess(EloixClient.IndexServer.AclAccessInfo aai, BAsyncResult<EloixClient.IndexServer.AclAccessResult> asyncResult) ;
		
		/// <summary>
		/// Returns the EditInfo-Objects from the FileData-Objects.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The rows "IXDTEXT",
		/// "ISCRYPT", "ATTACHID" and "SIGID" in the esw-file are not supported in this version.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.EditInfo[] getEditInfoFromESW(EloixClient.IndexServer.FileData[] fileDatas, EloixClient.IndexServer.EditInfoEswOptions eswOptions);
		void getEditInfoFromESW(EloixClient.IndexServer.FileData[] fileDatas, EloixClient.IndexServer.EditInfoEswOptions eswOptions, BAsyncResult<EloixClient.IndexServer.EditInfo[]> asyncResult) ;
		
		/// <summary>
		/// Returns the FileData-Objects from the EditInfo-Objects.
		/// </summary>
		/// <remarks>
		/// <p>
		/// Caution: sord.XDateIso and sord.IDateIso have to contain a value related to the servers timezone.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.FileData[] getESWFromEditInfo(EloixClient.IndexServer.EditInfo[] editInfos, EloixClient.IndexServer.EditInfoEswOptions eswOptions);
		void getESWFromEditInfo(EloixClient.IndexServer.EditInfo[] editInfos, EloixClient.IndexServer.EditInfoEswOptions eswOptions, BAsyncResult<EloixClient.IndexServer.FileData[]> asyncResult) ;
		
		/// <summary>
		/// Returns the LoginResult object that represents the session of the ticket contained in the given ClientInfo object.
		/// </summary>
		EloixClient.IndexServer.LoginResult getSessionFromTicket(int options);
		void getSessionFromTicket(int options, BAsyncResult<EloixClient.IndexServer.LoginResult> asyncResult) ;
		
		/// <summary>
		/// Returns the SessionInfo-Objects about all the active connections.
		/// </summary>
		EloixClient.IndexServer.SessionInfo[] getSessionInfos(EloixClient.IndexServer.SessionInfoParams @params);
		void getSessionInfos(EloixClient.IndexServer.SessionInfoParams @params, BAsyncResult<EloixClient.IndexServer.SessionInfo[]> asyncResult) ;
		
		/// <summary>
		/// Execute a script.
		/// </summary>
		EloixClient.IndexServer.ExecuteScriptResult executeScript(EloixClient.IndexServer.ExecuteScriptParams @params);
		void executeScript(EloixClient.IndexServer.ExecuteScriptParams @params, BAsyncResult<EloixClient.IndexServer.ExecuteScriptResult> asyncResult) ;
		
		/// <summary>
		/// Exports the workflow-version.
		/// </summary>
		EloixClient.IndexServer.FileData exportWorkflow(EloixClient.IndexServer.WorkflowExportOptions wfExportOptions);
		void exportWorkflow(EloixClient.IndexServer.WorkflowExportOptions wfExportOptions, BAsyncResult<EloixClient.IndexServer.FileData> asyncResult) ;
		
		/// <summary>
		/// Read all distinct values from the database that are used for the given ObjKey
		/// name, potentionally causing an enormous database load.
		/// </summary>
		EloixClient.IndexServer.ValuesOfObjKey getDistinctValuesOfObjKey(String okeyName, EloixClient.IndexServer.ValuesOfObjKeyOptions opts);
		void getDistinctValuesOfObjKey(String okeyName, EloixClient.IndexServer.ValuesOfObjKeyOptions opts, BAsyncResult<EloixClient.IndexServer.ValuesOfObjKey> asyncResult) ;
		
		/// <summary>
		/// Read characteristical properties of the archive.
		/// </summary>
		EloixClient.IndexServer.ArchiveStatistics getArchiveStatistics(long opts);
		void getArchiveStatistics(long opts, BAsyncResult<EloixClient.IndexServer.ArchiveStatistics> asyncResult) ;
		
		/// <summary>
		/// Collects the existing map domains.
		/// </summary>
		/// <remarks>
		/// <p>
		/// This function does not return the special domain MapDomainC.DOMAIN_IX_OPTIONS.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.MapDomain[] collectMapDomains();
		void collectMapDomains(BAsyncResult<EloixClient.IndexServer.MapDomain[]> asyncResult) ;
		
		/// <summary>
		/// Creates or updates a map domain.
		/// </summary>
		void checkinMapDomain(EloixClient.IndexServer.MapDomain mapDomain, EloixClient.IndexServer.LockZ unlockZ);
		void checkinMapDomain(EloixClient.IndexServer.MapDomain mapDomain, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Reads the data of a map domain.
		/// </summary>
		EloixClient.IndexServer.MapDomain checkoutMapDomain(String domainName, EloixClient.IndexServer.LockZ lockZ);
		void checkoutMapDomain(String domainName, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.MapDomain> asyncResult) ;
		
		/// <summary>
		/// Deletes a map domain and removes the associated database tables.
		/// </summary>
		void deleteMapDomain(String domainName, EloixClient.IndexServer.LockZ unlockZ);
		void deleteMapDomain(String domainName, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Inserts or updates the given key-value-pairs in <code>data</code> in the map specified by <code>id</code>.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The map can be associated to a Sord object by setting the parameter <code>objId</code> to a valid Sord ID.
		/// This implies, that the map is deleted, if the Sord object is finally deleted. Furthermore, the map can
		/// be copied with the Sord object. Therefore, the map ID must be equal to the Sord ID and the map domain
		/// must be prepared to copy items by setting <code>MapDomain.copy=true</code>.
		/// </p>
		/// <p>
		/// If domainName is set to MapDomainC.DOMAIN_IX_OPTIONS, the IndexServer configuration options from table
		/// eloixopt can be written. Therefore the key items in <code>data</code> must be formatted as
		/// data[.].key = &qt;[&qt; + ixid + &qt;]&qt; + optname. Whereby ixid is &qt;_ALL&qt; or the
		/// IndexServer ID specified in the web.xml or config.xml. The parameter <code>id</code> is ignored when
		/// reading IndexServer options. The <code>unlockZ</code> parameter is ignored too, because the options
		/// table does not support locking. Only Administrators are allowed to access the IndexServer options.
		/// </p>
		/// <p>
		/// Since ELO10: Map items can be of type {@link MapValue} which allows to store a BLOB.
		/// The maximum BLOB size should be at most {@link FileDataC#MAX_BLOB_LENGTH}.
		/// <pre><code>
		/// InputStream istream = new FileInputStream(new File("c:\test.txt")); // is closed in checkinMap
		/// FileData fileData = new FileData();
		/// fileData.setContentType("text/plain");
		/// fileData.setStream(istream);
		/// MapValue mapValue = new MapValue();
		/// mapValue.setKey("myfile");
		/// mapValue.setBlobValue(fileData);
		/// conn.ix().checkinMap( "MyMapDomain", "1", 0, new KeyValue[] { mapValue }, LockC.NO );
		/// </code></pre>
		/// </p>
		/// </remarks>
		void checkinMap(String domainName, String id, int objId, EloixClient.IndexServer.KeyValue[] data, EloixClient.IndexServer.LockZ unlockZ);
		void checkinMap(String domainName, String id, int objId, EloixClient.IndexServer.KeyValue[] data, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Reads a map or parts of a map.
		/// </summary>
		/// <remarks>
		/// <p>
		/// Since ELO10: In order to access BLOB values, lookup the value in the returned element {@link MapData#mapItems} or cast
		/// the related object in {@link MapData#items} to {@link MapValue}.
		/// <pre><code>
		/// MapData map = conn.ix().checkoutMap( mapDomainName, "1", new String[] {"myfile"}, LockC.NO );
		/// MapValue mapValue = map.getMapItems().get("myfile");
		/// InputStream istream = mapValueR.getBlobValue().getStream();
		/// try {
		/// ...
		/// } finally {
		/// istream.close();
		/// }
		/// </code></pre>
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.MapData checkoutMap(String domainName, String id, String[] keyNames, EloixClient.IndexServer.LockZ lockZ);
		void checkoutMap(String domainName, String id, String[] keyNames, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.MapData> asyncResult) ;
		
		/// <summary>
		/// Delete map items.
		/// </summary>
		void deleteMap(String domainName, String id, String[] keyNames, EloixClient.IndexServer.LockZ unlockZ);
		void deleteMap(String domainName, String id, String[] keyNames, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Find terms for faceted search.
		/// </summary>
		EloixClient.IndexServer.ContextTerm[] getContextTerms(EloixClient.IndexServer.FindInfo findInfo, String field, int max);
		void getContextTerms(EloixClient.IndexServer.FindInfo findInfo, String field, int max, BAsyncResult<EloixClient.IndexServer.ContextTerm[]> asyncResult) ;
		
		/// <summary>
		/// Execute a registered function defined in a JavaScript or in an event handler.
		/// </summary>
		EloixClient.IndexServer.Any executeRegisteredFunction(String functionName, EloixClient.IndexServer.Any param);
		void executeRegisteredFunction(String functionName, EloixClient.IndexServer.Any param, BAsyncResult<EloixClient.IndexServer.Any> asyncResult) ;
		
		/// <summary>
		/// Execute a registered function defined in a JavaScript or in an event handler.
		/// </summary>
		String executeRegisteredFunctionString(String functionName, String param);
		void executeRegisteredFunctionString(String functionName, String param, BAsyncResult<String> asyncResult) ;
		
		/// <summary>
		/// Get alternative terms for an iSearch search.
		/// </summary>
		/// <remarks>
		/// <p>
		/// This function can be used to list all index values currently used for a given index group.
		/// To achieve this, pass termType=SearchTermsC.TERMS and set findInfo.findDirect.query = "LINE." + indexgroup + ":" + valueprefix.
		/// If more than 10 values shoud be returned, set findInfo.findOptions.totalCount to the maximum
		/// values to be returned.
		/// </p>
		/// </remarks>
		String[] getSearchTerms(EloixClient.IndexServer.FindInfo findInfo, int termType);
		void getSearchTerms(EloixClient.IndexServer.FindInfo findInfo, int termType, BAsyncResult<String[]> asyncResult) ;
		
		/// <summary>
		/// Queries, enters or leaves the administration mode.
		/// </summary>
		/// <remarks>
		/// <p>
		/// In administration mode, only main administrators can logon to the archive.
		/// </p>
		/// </remarks>
		int adminMode(int mode);
		void adminMode(int mode, BAsyncResult<int> asyncResult) ;
		
		/// <summary>
		/// Get or set the fulltext configuration.
		/// </summary>
		EloixClient.IndexServer.FulltextConfig configureFulltext(String userId, EloixClient.IndexServer.FulltextConfig opts);
		void configureFulltext(String userId, EloixClient.IndexServer.FulltextConfig opts, BAsyncResult<EloixClient.IndexServer.FulltextConfig> asyncResult) ;
		
		/// <summary>
		/// This function notifies the IndexServer about an operation of the client program.
		/// </summary>
		/// <remarks>
		/// <p>
		/// Use this function in order to notify the license management, when a write access
		/// has been processed, e.g. scan a document or perform OCR analysis on a document.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.NotifyServerResult notifyServer(EloixClient.IndexServer.NotifyServerInfo msg);
		void notifyServer(EloixClient.IndexServer.NotifyServerInfo msg, BAsyncResult<EloixClient.IndexServer.NotifyServerResult> asyncResult) ;
		
		/// <summary>
		/// Query or send backup profile information of the ELOdm.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The user calling this method must have the main administrator right
		/// (AccessC.FLAG_ADMIN).
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.BackupProfile[] configureBackup(EloixClient.IndexServer.BackupProfile[] backupProfiles);
		void configureBackup(EloixClient.IndexServer.BackupProfile[] backupProfiles, BAsyncResult<EloixClient.IndexServer.BackupProfile[]> asyncResult) ;
		
		/// <summary>
		/// Query the status of the backup and purge tasks of the ELOdm.
		/// </summary>
		/// <remarks>
		/// <p>
		/// In addition, the backup and purge tasks can be started or stopped.
		/// The user calling this method must have the main administrator right
		/// (AccessC.FLAG_ADMIN).
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.BackupPurgeStatus controlBackup(EloixClient.IndexServer.ControlBackupInfo controlBackupInfo);
		void controlBackup(EloixClient.IndexServer.ControlBackupInfo controlBackupInfo, BAsyncResult<EloixClient.IndexServer.BackupPurgeStatus> asyncResult) ;
		
		/// <summary>
		/// Query or send the purge task settings of the ELOdm.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The user calling this method must have the main administrator right
		/// (AccessC.FLAG_ADMIN).
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.PurgeSettings configurePurge(EloixClient.IndexServer.PurgeSettings purgeSettings);
		void configurePurge(EloixClient.IndexServer.PurgeSettings purgeSettings, BAsyncResult<EloixClient.IndexServer.PurgeSettings> asyncResult) ;
		
		/// <summary>
		/// Adds additional params to an upload or download URL.
		/// </summary>
		/// <remarks>
		/// <p>
		/// Currently, additional params are only available for download URLs.
		/// </p>
		/// </remarks>
		String addUrlParams(String url, EloixClient.IndexServer.UrlParams @params);
		void addUrlParams(String url, EloixClient.IndexServer.UrlParams @params, BAsyncResult<String> asyncResult) ;
		
		/// <summary>
		/// Open a new event bus.
		/// </summary>
		/// <remarks>
		/// <p>
		/// Caution: the event bus API functions cannot be used with SOAP communication.
		/// </p><p>
		/// An event bus is like a communication channel between two or more subscribers. One subscriber sends an
		/// event and the bus dispatches it to the subscribers that are listening.
		/// </p><p>
		/// Before an application can send events, it has to call the function <code>createEventBusSubscriber</code>
		/// in order to create a subscriber ID. A subscriber can send events to an event bus or listen to events from an event bus.
		/// To send an event, the function <code>sendEvents</code> has to be called.<br>
		/// In order to revive events from event busses, event listeners have to be registered with the event busses first.
		/// An event listener specifies a list of <code>EventFilter</code> objects which describe the requested event types and busses from which to receive events.
		/// A subscriber can register any number of event listeners to potentially different event busses with a single call to <code>createEventBusListener</code>.
		/// Further event listeners can be added by this function or deleted with <code>deleteEventBusListener</code> at any time.
		/// </p><p>
		/// A helper object of <code>IXConnection</code>, which can be obtained by <code>IXConnection.getEventBusApi()</code>,
		/// listens for incoming events and forwards them to an object that implements the <code>IXEventBusHandler</code> interface.
		/// This object has to be provided by the client application and must be passed in a call to <code>IXConnection.getEventBusApi().setHandler(...)</code>.
		/// </p><p>
		/// Normally, client applications will use the predefined busses listed in <code>EventBusC</code>.
		/// This class defines a broadcast bus and busses related to users. Any subscriber can receive events from the broadcast
		/// bus. In difference to that, user busses can be listened only by the owner - a user bus acts somewhat like a mailbox.
		/// <p></p>
		/// There is no constraint to subscribers for sending events to busses. A subscriber can send any event to a bus, if it knows the bus ID.
		/// <p></p>
		/// In some circumstances, it is useful to work with a private channel between particular subscribers. This could be a channel used
		/// for chat messages between users. Another example is a channel between separated components of an application that share the same
		/// ticket an have to synchronize the user interfaces.
		/// <p></p>
		/// Use this function to open an event bus e.g. to establish a private communication channel between
		/// two or more applications. The returned bus ID is built upon the given information in <code>params</code>.
		/// Two applications, that supply equal params objects, will receive equal bus IDs.
		/// At least one of the applications has to close the bus with <code>closeEventBus</code> if it is needed no more.
		/// </p>
		/// </remarks>
		long openEventBus(EloixClient.IndexServer.EventBusParams @params);
		void openEventBus(EloixClient.IndexServer.EventBusParams @params, BAsyncResult<long> asyncResult) ;
		
		/// <summary>
		/// Close an event bus opened by <code>openEventBus</code>.
		/// </summary>
		/// <remarks>
		/// <p>
		/// Any subscriber that knows the bus ID can close this event bus.
		/// When a bus is closed, all outstanding events in the ELOix are deleted.
		/// After a bus is closed, neither listener will receive anymore events from this bus.
		/// This function ignores unknown or already closed bus IDs or bus IDs defined in <code>EventBusC</code>.
		/// </p>
		/// </remarks>
		void closeEventBus(long busId);
		void closeEventBus(long busId, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Create an event bus subscriber.
		/// </summary>
		/// <remarks>
		/// <p>
		/// A subscriber sends events to an event bus or receives events from an event bus.
		/// An application resp. an <code>IXConnection</code> can open any number of subscribers.
		/// A subscriber has to be deleted with <code>deleteEventBusSubscriber</code> when it is no more needed.
		/// A bus is also deleted, if the last event listener is deleted. This might happen when <code>deleteEventBusSubscriber</code> or <code>deleteEventBusListener</code> is called.
		/// In this case, it is not necessary to call <code>deleteEventBusSubscriber</code>.
		/// </p>
		/// </remarks>
		long createEventBusSubscriber();
		void createEventBusSubscriber(BAsyncResult<long> asyncResult) ;
		
		/// <summary>
		/// Deletes an event bus subscriber.
		/// </summary>
		/// <remarks>
		/// <p>
		/// This function deletes a subscriber an all its event listeners.
		/// </p>
		/// </remarks>
		void deleteEventBusSubscriber(long subsId);
		void deleteEventBusSubscriber(long subsId, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Creates an event bus listener.
		/// </summary>
		/// <remarks>
		/// <p>
		/// This function creates an event bus listener that filters events from the event bus as described in the filter list of the <code>eventListener</code> parameter.
		/// Event bus listeners have to be deleted by either <code>deleteEventBusListener</code> or by deleting the subscriber with <code>deleteEventBusSubscriber</code>.
		/// </p>
		/// </remarks>
		long createEventBusListener(long subsId, EloixClient.IndexServer.EventListener eventListener);
		void createEventBusListener(long subsId, EloixClient.IndexServer.EventListener eventListener, BAsyncResult<long> asyncResult) ;
		
		/// <summary>
		/// Deletes an event bus listener.
		/// </summary>
		/// <remarks>
		/// <p>
		/// This function deletes an event bus listener that was created by a call to <code>createEventBusListener</code>.
		/// The function does not throw an exception, if the Listener ID does not exist.
		/// </p>
		/// </remarks>
		void deleteEventBusListener(long lsnId);
		void deleteEventBusListener(long lsnId, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Read events from the server.
		/// </summary>
		/// <remarks>
		/// <p>
		/// This function should not be called directly. It is used internally by the event bus helper object of <code>IXConnection</code>.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.Event[] internalReceiveEvents(long subsId, long timeoutMillis);
		void internalReceiveEvents(long subsId, long timeoutMillis, BAsyncResult<EloixClient.IndexServer.Event[]> asyncResult) ;
		
		/// <summary>
		/// Send events to event busses.
		/// </summary>
		/// <remarks>
		/// <p>
		/// Call this function to send events to event busses.
		/// </p>
		/// </remarks>
		void sendEvents(long subsId, EloixClient.IndexServer.Event[] events);
		void sendEvents(long subsId, EloixClient.IndexServer.Event[] events, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Helper function to create a RSA key pair.
		/// </summary>
		String[] createRsaKeys();
		void createRsaKeys(BAsyncResult<String[]> asyncResult) ;
		
		/// <summary>
		/// Encrypt or decrypt a string using the RSA algorithm.
		/// </summary>
		/// <remarks>
		/// <p>
		/// This function encrypts or decrypts the string <code>data</code> using the RSA algorithm.
		/// The string must not be longer than 768 characters.
		/// Pass the public RSA key in <code>key</code>, if the string should be encrypted.
		/// In order to decrypt the string, the private key has to be passed.
		/// Both keys must be created with <code>createRsaKeys</code>.
		/// </p>
		/// </remarks>
		String encryptStringRsa(String key, String data, bool encryptNotDecrypt);
		void encryptStringRsa(String key, String data, bool encryptNotDecrypt, BAsyncResult<String> asyncResult) ;
		
		/// <summary>
		/// This function creates an activity project in memory.
		/// </summary>
		/// <remarks>
		/// <p>
		/// If projectName is not null and not empty, the function checks whether the name is already used.
		/// The current session must have the permission AccessC.FLAG_EDITACT in order to call this function.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.ActivityProject createActivityProject(String projectName);
		void createActivityProject(String projectName, BAsyncResult<EloixClient.IndexServer.ActivityProject> asyncResult) ;
		
		/// <summary>
		/// This function writes an activity project into the database.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The current session must have the permission AccessC.FLAG_EDITACT in order to call this function.
		/// </p>
		/// </remarks>
		String checkinActivityProject(EloixClient.IndexServer.ActivityProject actProj, EloixClient.IndexServer.LockZ unlockZ);
		void checkinActivityProject(EloixClient.IndexServer.ActivityProject actProj, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<String> asyncResult) ;
		
		/// <summary>
		/// This function reads and optionally locks an activity project.
		/// </summary>
		EloixClient.IndexServer.ActivityProject checkoutActivityProject(String projectName, EloixClient.IndexServer.LockZ lockZ);
		void checkoutActivityProject(String projectName, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.ActivityProject> asyncResult) ;
		
		/// <summary>
		/// This function deletes an activity project from the database.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The current session must have the permission AccessC.FLAG_EDITACT in order to call this function.
		/// </p>
		/// </remarks>
		void deleteActivityProject(String projectName, EloixClient.IndexServer.LockZ unlockZ);
		void deleteActivityProject(String projectName, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This function reads all activity projects.
		/// </summary>
		EloixClient.IndexServer.ActivityProject[] findActivityProjects(EloixClient.IndexServer.FindActivityProjectsInfo findInfo);
		void findActivityProjects(EloixClient.IndexServer.FindActivityProjectsInfo findInfo, BAsyncResult<EloixClient.IndexServer.ActivityProject[]> asyncResult) ;
		
		/// <summary>
		/// This function creates an activity in memory based on the given project and assigned to the given object.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The current session must have read access to the Sord, if parameter objId is specified.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.Activity createActivity(String projectName, String objId);
		void createActivity(String projectName, String objId, BAsyncResult<EloixClient.IndexServer.Activity> asyncResult) ;
		
		/// <summary>
		/// This function inserts or updates an activity.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The current session must have read access to the given Sord.
		/// In order to update an existing activity, the current session must be sender or receiver of the activity (Acitivty.senderId, Activity.receiverId).
		/// </p>
		/// </remarks>
		String checkinActivity(EloixClient.IndexServer.Activity act, EloixClient.IndexServer.LockZ unlockZ);
		void checkinActivity(EloixClient.IndexServer.Activity act, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<String> asyncResult) ;
		
		/// <summary>
		/// This function deletes an activity.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The current session must be sender or receiver of the activity (Acitivty.senderId, Activity.receiverId).
		/// </p>
		/// </remarks>
		void deleteActivity(String actGuid, EloixClient.IndexServer.DeleteActivityOptions deleteOptions, EloixClient.IndexServer.LockZ unlockZ);
		void deleteActivity(String actGuid, EloixClient.IndexServer.DeleteActivityOptions deleteOptions, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// This function reads and optionally locks an activity.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The current session must be sender or receiver of the activity (Acitivty.senderId, Activity.receiverId).
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.Activity checkoutActivity(String actGuid, EloixClient.IndexServer.LockZ lockZ);
		void checkoutActivity(String actGuid, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.Activity> asyncResult) ;
		
		/// <summary>
		/// This function reads the activities of an object.
		/// </summary>
		EloixClient.IndexServer.FindResult findFirstActivities(EloixClient.IndexServer.FindActivityInfo findInfo, int max, EloixClient.IndexServer.ActivityZ activityZ);
		void findFirstActivities(EloixClient.IndexServer.FindActivityInfo findInfo, int max, EloixClient.IndexServer.ActivityZ activityZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// This function reads the next activites of an object.
		/// </summary>
		EloixClient.IndexServer.FindResult findNextActivities(String searchId, int idx, int max, EloixClient.IndexServer.ActivityZ activityZ);
		void findNextActivities(String searchId, int idx, int max, EloixClient.IndexServer.ActivityZ activityZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// This function is called from an OCR worker process to notify Indexserver about its state.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The behavior of a OCR worker process is beyond the API documentation. Contact ELO support,
		/// if a different OCR has to be integrated.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.OcrWorker registerOcrWorker(EloixClient.IndexServer.OcrWorker ocrWorker);
		void registerOcrWorker(EloixClient.IndexServer.OcrWorker ocrWorker, BAsyncResult<EloixClient.IndexServer.OcrWorker> asyncResult) ;
		
		/// <summary>
		/// Compute OCR on the given image data or on an archived document.
		/// </summary>
		/// <remarks>
		/// <p>
		/// <i>In order to use this function, the ELO OCR Service 8.0 has to be installed somewhere on the network and
		/// has to be configured for Indexserver access.</i>
		/// </p><p>
		/// The request can be performed synchronously or asynchronously.
		/// In asynchronous processing, the result is sent via the Indexserver Event API.
		/// In order to receive the result, the client application has to register a listener for the event type
		/// EventBusC.EVENT_OCR_RESULT.
		/// </p><p>
		/// Use an empty OcrInfo object to check, whether OCR is available.
		/// </p><p>
		/// This is a simple example for synchronous OCR processing:
		/// <pre><code>
		/// IXConnection conn = ...
		/// String imageFile = ... // Input file in TIFF, etc. format
		/// String textFile = ... // Output file in text format
		/// <br/>
		/// // Is OCR via IX available? - Pass an empty OcrInfo object to processOcr in order to find it out.
		/// OcrInfo ocrInfo = new OcrInfo();
		/// bool isOcrAvail = conn.Ix.processOcr(ocrInfo) != null;
		/// if (!isOcrAvail) return;
		/// <br/>
		/// // Query the languages supported by the OCR Engine
		/// OcrInfo ocrInfoLangs = new OcrInfo();
		/// ocrInfoLangs.queryLanguages = new OcrInfoQueryLanguages();
		/// OcrResult ocrResultLangs = conn.Ix.processOcr(ocrInfoLangs);
		/// <br/>
		/// // Anaylze file
		/// // Load entire image into memory
		/// OcrInfo ocrInfo = new OcrInfo();
		/// ocrInfo.recognizeFile = new OcrInfoRecognizeFile();
		/// ocrInfo.recognizeFile.imageData = new FileData();
		/// ocrInfo.recognizeFile.imageData.data = File.ReadAllBytes(imageFile);
		/// ocrInfo.recognizeFile.imageData.contentType = Path.GetExtension(imageFile);
		/// ocrInfo.recognizeFile.pageNo = -1; // analyze all pages
		/// ocrInfo.recognizeFile.outputFormat = OcrInfoC.TEXT; // return result as String
		/// ocrInfo.recognizeFile.recognizeLangs = new String[] {"German", "Czech"}; // Choosen from ocrResultLangs.internalLangs
		/// <br/>
		/// // Process OCR
		/// OcrResult ocrResult = conn.Ix.processOcr(ocrInfo);
		/// <br/>
		/// // Write text output to file
		/// File.WriteAllText(textFile, ocrResult.recognizeFile.text, Encoding.UTF8);
		/// </code></pre>
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.OcrResult processOcr(EloixClient.IndexServer.OcrInfo ocrInfo);
		void processOcr(EloixClient.IndexServer.OcrInfo ocrInfo, BAsyncResult<EloixClient.IndexServer.OcrResult> asyncResult) ;
		
		/// <summary>
		/// Evaluate the destination archive path based on filing definitions of a keywording from.
		/// </summary>
		/// <remarks>
		/// <p>
		/// This function evaluates the parent folder of a Sord object based on the filing
		/// definition of a keywording form WITHOUT storing the Sord object.
		/// This is in contrast to the checkinSord and checkinDocEnd functions which store the Sord object
		/// in the resulting parent.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.AutoFilingResult evalAutoFiling(String maskId, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.AutoFilingOptions opts);
		void evalAutoFiling(String maskId, EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.AutoFilingOptions opts, BAsyncResult<EloixClient.IndexServer.AutoFilingResult> asyncResult) ;
		
		/// <summary>
		/// Reads the history entries for the given map.
		/// </summary>
		/// <remarks>
		/// <p>
		/// History entries are only written for MapDomain objects with {@link MapDomain#history}=true.
		/// For MapDomain objects with {@link MapDomain#history}=false, an empty array is returned.
		/// If no history entries exist for the given domainName and mapId, an empty array is returned.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.MapHist[] checkoutMapHistory(String domainName, String mapId, EloixClient.IndexServer.MapHistZ membersZ);
		void checkoutMapHistory(String domainName, String mapId, EloixClient.IndexServer.MapHistZ membersZ, BAsyncResult<EloixClient.IndexServer.MapHist[]> asyncResult) ;
		
		/// <summary>
		/// Prepares the IndexServer to enable a document to be checked in.
		/// </summary>
		/// <remarks>
		/// <p>
		/// Retrieves path id and encryption set from the sord object and sets these values in document versions
		/// of this document.
		/// In case of limited release document, work version is set to false.
		/// Document id will not be set to 0, if "keepIds" is true in option "opts" (when no new document but
		/// only signature should be added for a version controlled document, up to this version clients had
		/// to reset the actual document id after running method checkinDocBegin)
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.Document checkinDocBegin2(EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Document document, EloixClient.IndexServer.CheckinDocOptions opts);
		void checkinDocBegin2(EloixClient.IndexServer.Sord sord, EloixClient.IndexServer.Document document, EloixClient.IndexServer.CheckinDocOptions opts, BAsyncResult<EloixClient.IndexServer.Document> asyncResult) ;
		
		/// <summary>
		/// Query the status of the job and control its state.
		/// </summary>
		/// <remarks>
		/// <p>
		/// Using this method the job can be cancelled. The user calling this method
		/// must have started the job or must have the administrator right
		/// (AccessC.FLAG_ADMIN).
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.JobState controlBackgroundThread(EloixClient.IndexServer.JobState jobState);
		void controlBackgroundThread(EloixClient.IndexServer.JobState jobState, BAsyncResult<EloixClient.IndexServer.JobState> asyncResult) ;
		
		/// <summary>
		/// Query all jobs executed in the background.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The method returns all jobs started by the calling user. If the user has
		/// the administrator right (AccessC.FLAG_ADMIN) the
		/// findBackgroundThreadOptions parameter can filter for users.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.FindResult findBackgroundThreads(EloixClient.IndexServer.FindBackgroundThreadOptions findBackgroundThreadOptions);
		void findBackgroundThreads(EloixClient.IndexServer.FindBackgroundThreadOptions findBackgroundThreadOptions, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Query the protocol of a background thread.
		/// </summary>
		/// <remarks>
		/// <p>
		/// The method returns all log messages that matches the restrictions given by
		/// the parameter queryJobProtocolInfo, and that are cached at the IndexServer.
		/// The amount of cached entries is configurable at the log4j configuration
		/// file.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.QueryJobProtocolResult queryJobProtocol(EloixClient.IndexServer.QueryJobProtocolInfo queryJobProtocolInfo);
		void queryJobProtocol(EloixClient.IndexServer.QueryJobProtocolInfo queryJobProtocolInfo, BAsyncResult<EloixClient.IndexServer.QueryJobProtocolResult> asyncResult) ;
		
		/// <summary>
		/// Queries dynamic keyword lists.
		/// </summary>
		/// <remarks>
		/// <p>
		/// A server script generates the data of dynamic keyword lists from external
		/// resources. Such resources may be databases of CRMs, webservices like
		/// twitter, an e-M@il provider, etc. The default installation does not provide
		/// any server scripts. They must be implemented by the end-user.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.KeywordsDynamicResult checkoutKeywordsDynamic(EloixClient.IndexServer.KeywordsDynamicInfo keywordsDynamicInfo);
		void checkoutKeywordsDynamic(EloixClient.IndexServer.KeywordsDynamicInfo keywordsDynamicInfo, BAsyncResult<EloixClient.IndexServer.KeywordsDynamicResult> asyncResult) ;
		
		/// <summary>
		/// Gets the list of Sord object which are the predecessors of the sord given by the objId.
		/// </summary>
		/// <remarks>
		/// <p>
		/// If csi.inclRefPaths is set, all the sord of the referenced paths are also returned.
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.SordPaths checkoutSordPath(String objId, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.CheckoutSordPathInfo csi);
		void checkoutSordPath(String objId, EloixClient.IndexServer.SordZ sordZ, EloixClient.IndexServer.CheckoutSordPathInfo csi, BAsyncResult<EloixClient.IndexServer.SordPaths> asyncResult) ;
		
		/// <summary>
		/// Generates URLs for preview images of documents.
		/// </summary>
		EloixClient.IndexServer.PreviewImageResult checkoutPreviewImageURLs(EloixClient.IndexServer.PreviewImageInfo previewImageInfo);
		void checkoutPreviewImageURLs(EloixClient.IndexServer.PreviewImageInfo previewImageInfo, BAsyncResult<EloixClient.IndexServer.PreviewImageResult> asyncResult) ;
		
		/// <summary>
		/// Specify, which notifications should be sent by the server.
		/// </summary>
		EloixClient.IndexServer.ApplyForNotificationsInfo applyForNotifications(EloixClient.IndexServer.ApplyForNotificationsInfo info);
		void applyForNotifications(EloixClient.IndexServer.ApplyForNotificationsInfo info, BAsyncResult<EloixClient.IndexServer.ApplyForNotificationsInfo> asyncResult) ;
		
		/// <summary>
		/// Gets the public downloads.
		/// </summary>
		IList<EloixClient.IndexServer.PublicDownload> getPublicDownloads(EloixClient.IndexServer.PublicDownloadOptions opts);
		void getPublicDownloads(EloixClient.IndexServer.PublicDownloadOptions opts, BAsyncResult<IList<EloixClient.IndexServer.PublicDownload>> asyncResult) ;
		
		/// <summary>
		/// Deletes the public downloads
		/// </summary>
		void terminatePublicDownloadUrls(EloixClient.IndexServer.PublicDownloadOptions opts);
		void terminatePublicDownloadUrls(EloixClient.IndexServer.PublicDownloadOptions opts, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Edits the public downloads
		/// </summary>
		void editPublicDownloadUrls(EloixClient.IndexServer.PublicDownloadOptions opts);
		void editPublicDownloadUrls(EloixClient.IndexServer.PublicDownloadOptions opts, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Resolves the rights of a user.
		/// </summary>
		/// <remarks>
		/// <p>
		/// This function calculates the effective rights of a given user. Hereby, the
		/// given parameter userInfo will not be checked in. This way it is possible to
		/// set hypothetical groups for the user and retrieve the results of the change
		/// without applying them. The effective rights always are calculated for every
		/// right.
		/// </p>
		/// <p>
		/// The groups of the given users will be combined with the groups he already
		/// is a member of. This combination works like the logical "or" function. If
		/// you want the result without a specific group, ignore the corresponding
		/// {@link ResolveRightsResult} which has set {@link ResolveRightsResult#type}=
		/// {@link ResolveRightsResultC#DIRECT}.
		/// </p>
		/// </remarks>
		IList<EloixClient.IndexServer.ResolveRightsResult> resolveRights(EloixClient.IndexServer.UserInfo ui, EloixClient.IndexServer.ResolveRightsInfo info);
		void resolveRights(EloixClient.IndexServer.UserInfo ui, EloixClient.IndexServer.ResolveRightsInfo info, BAsyncResult<IList<EloixClient.IndexServer.ResolveRightsResult>> asyncResult) ;
		
		/// <summary>
		/// Starts an Ad Hoc Workflow.
		/// </summary>
		int startAdHocWorkFlow2(String name, String objId, EloixClient.IndexServer.UserNodeInfo[] userNodeInfo, EloixClient.IndexServer.StartAdHocWorkflowInfo startWfInfo);
		void startAdHocWorkFlow2(String name, String objId, EloixClient.IndexServer.UserNodeInfo[] userNodeInfo, EloixClient.IndexServer.StartAdHocWorkflowInfo startWfInfo, BAsyncResult<int> asyncResult) ;
		
		/// <summary>
		/// Starts an Ad Hoc Workflow.
		/// </summary>
		int startAdHocWorkFlow3(String name, String objId, EloixClient.IndexServer.StartAdHocWorkflowInfo startWfInfo);
		void startAdHocWorkFlow3(String name, String objId, EloixClient.IndexServer.StartAdHocWorkflowInfo startWfInfo, BAsyncResult<int> asyncResult) ;
		
		/// <summary>
		/// Creates and inserts a new public download
		/// </summary>
		EloixClient.IndexServer.PublicDownload insertPublicDownload(EloixClient.IndexServer.PublicDownloadOptions opts);
		void insertPublicDownload(EloixClient.IndexServer.PublicDownloadOptions opts, BAsyncResult<EloixClient.IndexServer.PublicDownload> asyncResult) ;
		
		/// <summary>
		/// Initialize a subscription object.
		/// </summary>
		EloixClient.IndexServer.Subscription createSubscription(String watchGuid);
		void createSubscription(String watchGuid, BAsyncResult<EloixClient.IndexServer.Subscription> asyncResult) ;
		
		/// <summary>
		/// Add a subscription.
		/// </summary>
		EloixClient.IndexServer.Subscription checkinSubscription(EloixClient.IndexServer.Subscription subs, EloixClient.IndexServer.SubscriptionZ subsZ);
		void checkinSubscription(EloixClient.IndexServer.Subscription subs, EloixClient.IndexServer.SubscriptionZ subsZ, BAsyncResult<EloixClient.IndexServer.Subscription> asyncResult) ;
		
		/// <summary>
		/// Delete a subscription.
		/// </summary>
		void deleteSubscription(EloixClient.IndexServer.Subscription subs);
		void deleteSubscription(EloixClient.IndexServer.Subscription subs, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Find first max subscriptions.
		/// </summary>
		/// <remarks>
		/// This function finds the subscriptions of the current user.
		/// </remarks>
		EloixClient.IndexServer.FindResult findFirstSubscriptions(EloixClient.IndexServer.FindSubscriptionInfo findInfo, int max, EloixClient.IndexServer.SubscriptionZ subsZ);
		void findFirstSubscriptions(EloixClient.IndexServer.FindSubscriptionInfo findInfo, int max, EloixClient.IndexServer.SubscriptionZ subsZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Find next max subscriptions beginning at index idx.
		/// </summary>
		EloixClient.IndexServer.FindResult findNextSubscriptions(String searchId, int idx, int max, EloixClient.IndexServer.SubscriptionZ subsZ);
		void findNextSubscriptions(String searchId, int idx, int max, EloixClient.IndexServer.SubscriptionZ subsZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Find first notes.
		/// </summary>
		/// <remarks>
		/// This function starts a search for Note object and returns the first objects found in {@link FindResult#notes}.
		/// At least {@link FindInfo#findByNotes} must be set. The member {@link FindInfo#findChildren} optionally
		/// constrain the results to a folder.
		/// The search must be closed with {@link #findClose(ClientInfo, String)} in order to release internally cached data.
		/// </remarks>
		EloixClient.IndexServer.FindResult findFirstNotes(EloixClient.IndexServer.FindInfo findInfo, int max, EloixClient.IndexServer.NoteZ noteZ);
		void findFirstNotes(EloixClient.IndexServer.FindInfo findInfo, int max, EloixClient.IndexServer.NoteZ noteZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Find next notes.
		/// </summary>
		/// <remarks>
		/// This function continues a search for Note objects startet with function {@link #findFirstNotes(ClientInfo, FindInfo, int, NoteZ)}.
		/// </remarks>
		EloixClient.IndexServer.FindResult findNextNotes(String searchId, int idx, int max, EloixClient.IndexServer.NoteZ noteZ);
		void findNextNotes(String searchId, int idx, int max, EloixClient.IndexServer.NoteZ noteZ, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Inserts custom report entries.
		/// </summary>
		/// <remarks>
		/// <p>
		/// This function writes new entries into the report table. These entries always
		/// are appended to the report table. Once in the report table, no data will be
		/// overwritten by this function. The ReportInfo element must provide an action
		/// number {@link ReportInfo#actionNo} at least. The action number has to be
		/// within the range {@link ReportInfoC#ACT_CUSTOM_FIRST} and
		/// {@link ReportInfoC#ACT_CUSTOM_LAST}. Besides the action number, the report
		/// entry can hold custom data in the fields objId, extra1, extra2, text and
		/// extraInfo. If specified, the object in extraInfo must be Serializable.
		/// If the report entry to insert does not belong to a {@link Sord}, set the
		/// objId value to 0.
		/// </p>
		/// </remarks>
		void checkinReport(EloixClient.IndexServer.ReportInfo report, EloixClient.IndexServer.CheckinReportInfo reserved, EloixClient.IndexServer.LockZ lockZ);
		void checkinReport(EloixClient.IndexServer.ReportInfo report, EloixClient.IndexServer.CheckinReportInfo reserved, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Links archive entries like {@link #linkSords}.
		/// </summary>
		/// <remarks>
		/// <p>This method provides the additional parameter {@link LinkSordInfo} to
		/// specify more options for linking sords together.</p>
		/// </remarks>
		void linkSords2(String fromId, String[] toIds, EloixClient.IndexServer.LinkSordZ linkSordZ, EloixClient.IndexServer.LinkSordInfo linkSordInfo);
		void linkSords2(String fromId, String[] toIds, EloixClient.IndexServer.LinkSordZ linkSordZ, EloixClient.IndexServer.LinkSordInfo linkSordInfo, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Returns the WebDAV path from an Object ID.
		/// </summary>
		String getWebDAVPathFromObjID(String objId);
		void getWebDAVPathFromObjID(String objId, BAsyncResult<String> asyncResult) ;
		
		/// <summary>
		/// Returns the WebDAV path from an Object ID.
		/// </summary>
		EloixClient.IndexServer.GetWebDAVPathResult getWebDAVPathFromObjID2(EloixClient.IndexServer.GetWebDAVPathOptions options);
		void getWebDAVPathFromObjID2(EloixClient.IndexServer.GetWebDAVPathOptions options, BAsyncResult<EloixClient.IndexServer.GetWebDAVPathResult> asyncResult) ;
		
		/// <summary>
		/// Reads the histories of a node or a whole workflow.
		/// </summary>
		EloixClient.IndexServer.CheckoutWorkflowHistoryResult checkoutWorkflowHistory(EloixClient.IndexServer.CheckoutWorkflowHistoryParams checkoutWorkflowHistoryParams);
		void checkoutWorkflowHistory(EloixClient.IndexServer.CheckoutWorkflowHistoryParams checkoutWorkflowHistoryParams, BAsyncResult<EloixClient.IndexServer.CheckoutWorkflowHistoryResult> asyncResult) ;
		
		/// <summary>
		/// Writes a keyword template into the database.
		/// </summary>
		/// <remarks>
		/// If this keyword template is already used in keywording forms, these keywording forms will be updated.
		/// This function requires ELO 10 license.
		/// </remarks>
		int checkinDocMaskLineTemplate(EloixClient.IndexServer.DocMaskLineTemplate dmlt, EloixClient.IndexServer.DocMaskLineTemplateZ dmltZ, EloixClient.IndexServer.CheckInDocMaskLineTemplateOptions options, EloixClient.IndexServer.LockZ lockZ);
		void checkinDocMaskLineTemplate(EloixClient.IndexServer.DocMaskLineTemplate dmlt, EloixClient.IndexServer.DocMaskLineTemplateZ dmltZ, EloixClient.IndexServer.CheckInDocMaskLineTemplateOptions options, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<int> asyncResult) ;
		
		/// <summary>
		/// Check out keyword templates.
		/// </summary>
		/// <remarks>
		/// This function requires ELO 10 license.
		/// </remarks>
		EloixClient.IndexServer.DocMaskLineTemplate[] checkoutDocMaskLineTemplates(String[] groups, EloixClient.IndexServer.DocMaskLineTemplateZ dmltZ, EloixClient.IndexServer.LockZ lockZ);
		void checkoutDocMaskLineTemplates(String[] groups, EloixClient.IndexServer.DocMaskLineTemplateZ dmltZ, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.DocMaskLineTemplate[]> asyncResult) ;
		
		/// <summary>
		/// Delete keyword templates
		/// This function requires ELO 10 license.
		/// </summary>
		void deleteDocMaskLineTemplates(String[] groups, EloixClient.IndexServer.LockZ unlockZ);
		void deleteDocMaskLineTemplates(String[] groups, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Prepare forwarding of a workflow node.
		/// </summary>
		/// <remarks>
		/// Use this function to lock a workflow and get the data required for forwarding a node.
		/// </remarks>
		EloixClient.IndexServer.WFEditNode beginForwardWorkflowNode(int flowId, int nodeId, EloixClient.IndexServer.BeginForwardWorkflowNodeInfo fwdInfo, EloixClient.IndexServer.LockZ lockZ);
		void beginForwardWorkflowNode(int flowId, int nodeId, EloixClient.IndexServer.BeginForwardWorkflowNodeInfo fwdInfo, EloixClient.IndexServer.LockZ lockZ, BAsyncResult<EloixClient.IndexServer.WFEditNode> asyncResult) ;
		
		/// <summary>
		/// Forward a workflow node, terminate a workflow or modify node data.
		/// </summary>
		/// <remarks>
		/// <h2>Example 1: Forward a workflow node:</h2>
		/// <p>
		/// <pre><code>
		/// // Lock workflow and read node data
		/// WFEditNode editNode = conn.ix().beginForwardWorkflowNode(flowId, nodeId, null, LockC.IF_FREE);
		/// // Select successor nodes to be activated
		/// // Make sure to select only one successor if: (editNode.getNode().getFlags() & WFNodeC.FLAG_ONE_SUCCESSOR) != 0
		/// List<Integer> succNodes = Arrays.asList(editNode.getSuccNodes()[0].getId());
		/// // Optionally: change node name and comment
		/// WFNode activeNode = editNode.getNode();
		/// activeNode.setName("new name");
		/// activeNode.setComment("new comment");
		/// // Forward
		/// ForwardWorkflowNodeInfo fwdInfo = new ForwardWorkflowNodeInfo();
		/// fwdInfo.setNode(activeNode);
		/// fwdInfo.setSuccessorNodesToActivate(succNodes);
		/// connU.ix().forwardWorkflowNode(flowId, nodeId, fwdInfo, LockC.YES);
		/// </code></pre>
		/// </p>
		/// <h2>Example 2: Cancel forwarding after beginForwardWorkflowNode has locked the workflow</h2>
		/// <p>
		/// <pre><code>
		/// // Lock workflow and read node data
		/// WFEditNode editNode = conn.ix().beginForwardWorkflowNode(flowId, nodeId, null, LockC.IF_FREE);
		/// // Cancel forward
		/// ForwardWorkflowNodeInfo fwdInfo = null;
		/// connU.ix().forwardWorkflowNode(flowId, nodeId, fwdInfo, LockC.YES);
		/// </code></pre>
		/// </p>
		/// <h2>Example 3: Change node priority, name and comment</h2>
		/// <p>
		/// <pre><code>
		/// </p>
		/// // Lock workflow
		/// WFEditNode editNode = conn.ix().beginForwardWorkflowNode(flowId, nodeId, null, LockC.IF_FREE);
		/// // Change node priority, name and comment
		/// WFNode activeNode = editNode.getNode();
		/// activeNode.setPrio(UserTaskPriorityC.HIGHEST);
		/// activeNode.setName("new name");
		/// activeNode.setComment("new comment");
		/// // Update node and unlock
		/// ForwardWorkflowNodeInfo fwdInfo = new ForwardWorkflowNodeInfo();
		/// fwdInfo.setNode(activeNode);
		/// connU.ix().forwardWorkflowNode(flowId, nodeId, fwdInfo, LockC.YES);
		/// </code></pre>
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.ForwardWorkflowNodeResult forwardWorkflowNode(int flowId, int nodeId, EloixClient.IndexServer.ForwardWorkflowNodeInfo fwdInfo, EloixClient.IndexServer.LockZ unlockZ);
		void forwardWorkflowNode(int flowId, int nodeId, EloixClient.IndexServer.ForwardWorkflowNodeInfo fwdInfo, EloixClient.IndexServer.LockZ unlockZ, BAsyncResult<EloixClient.IndexServer.ForwardWorkflowNodeResult> asyncResult) ;
		
		/// <summary>
		/// Find user data.
		/// </summary>
		/// <remarks>
		/// This function allows to find users by their name, description, or one of their properties.
		/// Wildcards can be used as defined in the session options, see {@link SessionOptionsC#DB_WILDCARDS}.
		/// <p>
		/// Example:
		/// <pre><code class="example">
		/// FindUserInfo findUserInfo = new FindUserInfo();
		/// findUserInfo.setName("testFind?sers-*");
		/// int idx = 0, max = 100;
		/// FindResult fr = conn.ix().findFirstUsers(findUserInfo, max);
		/// try {
		/// while (true) {
		/// for (UserName userName : fr.getUserNames().values()) {
		/// // process userName object
		/// }
		/// 
		/// if (!fr.isMoreResults()) break;
		/// 
		/// idx += fr.getUserNames().length;
		/// fr = conn.ix().findNextUsers(fr.getSearchId(), idx, max);
		/// }
		/// }
		/// catch (RemoteException e) {
		/// // process exception
		/// throw e;
		/// }
		/// finally {
		/// conn.ix().findClose(fr.getSearchId());
		/// }
		/// </code></pre>
		/// </p>
		/// </remarks>
		EloixClient.IndexServer.FindResult findFirstUsers(EloixClient.IndexServer.FindUserInfo findUserInfo, int max);
		void findFirstUsers(EloixClient.IndexServer.FindUserInfo findUserInfo, int max, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Find next user data.
		/// </summary>
		EloixClient.IndexServer.FindResult findNextUsers(String searchId, int idx, int max);
		void findNextUsers(String searchId, int idx, int max, BAsyncResult<EloixClient.IndexServer.FindResult> asyncResult) ;
		
		/// <summary>
		/// Check licensing information.
		/// </summary>
		/// <remarks>
		/// This function checks the given license information using proprietary algorithms.
		/// </remarks>
		EloixClient.IndexServer.LicenseResult checkLicense(EloixClient.IndexServer.LicenseInfo licenseInfo);
		void checkLicense(EloixClient.IndexServer.LicenseInfo licenseInfo, BAsyncResult<EloixClient.IndexServer.LicenseResult> asyncResult) ;
		
		/// <summary>
		/// Move documents from one storage path to another storage path.
		/// </summary>
		EloixClient.IndexServer.JobState moveDocuments(EloixClient.IndexServer.MoveDocumentsInfo moveDocumentsInfo);
		void moveDocuments(EloixClient.IndexServer.MoveDocumentsInfo moveDocumentsInfo, BAsyncResult<EloixClient.IndexServer.JobState> asyncResult) ;
		
		
	}
}  // end namespace
