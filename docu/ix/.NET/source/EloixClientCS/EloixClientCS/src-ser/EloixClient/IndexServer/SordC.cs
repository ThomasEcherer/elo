//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	/// <summary>
	/// <p>Constants for indexing information.
	/// </summary>
	/// <remarks>
	/// Each member of this class with prefix
	/// "mb" has a corresponding member in class <code>Sord</code></p>
	/// </remarks>
	public class SordC : EloixClient.IndexServer.ObjDataC, BSerializable
	{
	
		#region Constructors
		
		public SordC() {
		}		
		
		public SordC(int @lnDesc, String @GUID_REPLICATION_BASE, String @GUID_SCRIPTING_BASE, String @GUID_IX_SCRIPTING_BASE, String @GUID_ADMINISTRATION_BASE, String @GUID_COLD_BACKGROUND_IMAGES, String @GUID_WIN_SCRIPTING_BASE, String @GUID_WORKFLOW_ICONS_BASE, String @GUID_WFNODE_ICON_BEGINNODE, String @GUID_WFNODE_ICON_PERSONNODE, String @GUID_WFNODE_ICON_IFNODE, String @GUID_WFNODE_ICON_COLLECTNODE, String @GUID_WFNODE_ICON_TERMINATE, String @GUID_WFNODE_ICON_CYCLE_BEGIN, String @GUID_WFNODE_ICON_CYCLE_END, String @GUID_WFNODE_ICON_SET_SERVER_ID, String @GUID_WFNODE_ICON_SPLITNODE, String @GUID_USERS_FOLDER, String @GUID_TEXTREADER_FOLDER, String @GUID_TRNOTCONV_FOLDER, String @GUID_APPS_FOLDER, String @ELOINDEX_USER_FOLDER_DATA, String @ELOINDEX_USER_FOLDER_DATA_PROFILE, String @ELOINDEX_USER_FOLDER_PRIVATE, String @ELOINDEX_USER_FOLDER_INBOX) {
			this.lnDescValue = @lnDesc;
			this.GUID_REPLICATION_BASEValue = @GUID_REPLICATION_BASE;
			this.GUID_SCRIPTING_BASEValue = @GUID_SCRIPTING_BASE;
			this.GUID_IX_SCRIPTING_BASEValue = @GUID_IX_SCRIPTING_BASE;
			this.GUID_ADMINISTRATION_BASEValue = @GUID_ADMINISTRATION_BASE;
			this.GUID_COLD_BACKGROUND_IMAGESValue = @GUID_COLD_BACKGROUND_IMAGES;
			this.GUID_WIN_SCRIPTING_BASEValue = @GUID_WIN_SCRIPTING_BASE;
			this.GUID_WORKFLOW_ICONS_BASEValue = @GUID_WORKFLOW_ICONS_BASE;
			this.GUID_WFNODE_ICON_BEGINNODEValue = @GUID_WFNODE_ICON_BEGINNODE;
			this.GUID_WFNODE_ICON_PERSONNODEValue = @GUID_WFNODE_ICON_PERSONNODE;
			this.GUID_WFNODE_ICON_IFNODEValue = @GUID_WFNODE_ICON_IFNODE;
			this.GUID_WFNODE_ICON_COLLECTNODEValue = @GUID_WFNODE_ICON_COLLECTNODE;
			this.GUID_WFNODE_ICON_TERMINATEValue = @GUID_WFNODE_ICON_TERMINATE;
			this.GUID_WFNODE_ICON_CYCLE_BEGINValue = @GUID_WFNODE_ICON_CYCLE_BEGIN;
			this.GUID_WFNODE_ICON_CYCLE_ENDValue = @GUID_WFNODE_ICON_CYCLE_END;
			this.GUID_WFNODE_ICON_SET_SERVER_IDValue = @GUID_WFNODE_ICON_SET_SERVER_ID;
			this.GUID_WFNODE_ICON_SPLITNODEValue = @GUID_WFNODE_ICON_SPLITNODE;
			this.GUID_USERS_FOLDERValue = @GUID_USERS_FOLDER;
			this.GUID_TEXTREADER_FOLDERValue = @GUID_TEXTREADER_FOLDER;
			this.GUID_TRNOTCONV_FOLDERValue = @GUID_TRNOTCONV_FOLDER;
			this.GUID_APPS_FOLDERValue = @GUID_APPS_FOLDER;
			this.ELOINDEX_USER_FOLDER_DATAValue = @ELOINDEX_USER_FOLDER_DATA;
			this.ELOINDEX_USER_FOLDER_DATA_PROFILEValue = @ELOINDEX_USER_FOLDER_DATA_PROFILE;
			this.ELOINDEX_USER_FOLDER_PRIVATEValue = @ELOINDEX_USER_FOLDER_PRIVATE;
			this.ELOINDEX_USER_FOLDER_INBOXValue = @ELOINDEX_USER_FOLDER_INBOX;
		}		
		
		public SordC(SordC rhs) : base(rhs)
		{
			this.lnDescValue = rhs.lnDescValue;
			this.GUID_REPLICATION_BASEValue = rhs.GUID_REPLICATION_BASEValue;
			this.GUID_SCRIPTING_BASEValue = rhs.GUID_SCRIPTING_BASEValue;
			this.GUID_IX_SCRIPTING_BASEValue = rhs.GUID_IX_SCRIPTING_BASEValue;
			this.GUID_ADMINISTRATION_BASEValue = rhs.GUID_ADMINISTRATION_BASEValue;
			this.GUID_COLD_BACKGROUND_IMAGESValue = rhs.GUID_COLD_BACKGROUND_IMAGESValue;
			this.GUID_WIN_SCRIPTING_BASEValue = rhs.GUID_WIN_SCRIPTING_BASEValue;
			this.GUID_WORKFLOW_ICONS_BASEValue = rhs.GUID_WORKFLOW_ICONS_BASEValue;
			this.GUID_WFNODE_ICON_BEGINNODEValue = rhs.GUID_WFNODE_ICON_BEGINNODEValue;
			this.GUID_WFNODE_ICON_PERSONNODEValue = rhs.GUID_WFNODE_ICON_PERSONNODEValue;
			this.GUID_WFNODE_ICON_IFNODEValue = rhs.GUID_WFNODE_ICON_IFNODEValue;
			this.GUID_WFNODE_ICON_COLLECTNODEValue = rhs.GUID_WFNODE_ICON_COLLECTNODEValue;
			this.GUID_WFNODE_ICON_TERMINATEValue = rhs.GUID_WFNODE_ICON_TERMINATEValue;
			this.GUID_WFNODE_ICON_CYCLE_BEGINValue = rhs.GUID_WFNODE_ICON_CYCLE_BEGINValue;
			this.GUID_WFNODE_ICON_CYCLE_ENDValue = rhs.GUID_WFNODE_ICON_CYCLE_ENDValue;
			this.GUID_WFNODE_ICON_SET_SERVER_IDValue = rhs.GUID_WFNODE_ICON_SET_SERVER_IDValue;
			this.GUID_WFNODE_ICON_SPLITNODEValue = rhs.GUID_WFNODE_ICON_SPLITNODEValue;
			this.GUID_USERS_FOLDERValue = rhs.GUID_USERS_FOLDERValue;
			this.GUID_TEXTREADER_FOLDERValue = rhs.GUID_TEXTREADER_FOLDERValue;
			this.GUID_TRNOTCONV_FOLDERValue = rhs.GUID_TRNOTCONV_FOLDERValue;
			this.GUID_APPS_FOLDERValue = rhs.GUID_APPS_FOLDERValue;
			this.ELOINDEX_USER_FOLDER_DATAValue = rhs.ELOINDEX_USER_FOLDER_DATAValue;
			this.ELOINDEX_USER_FOLDER_DATA_PROFILEValue = rhs.ELOINDEX_USER_FOLDER_DATA_PROFILEValue;
			this.ELOINDEX_USER_FOLDER_PRIVATEValue = rhs.ELOINDEX_USER_FOLDER_PRIVATEValue;
			this.ELOINDEX_USER_FOLDER_INBOXValue = rhs.ELOINDEX_USER_FOLDER_INBOXValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Length of description + hidden text
		/// </summary>
		public int lnDesc
		{
			get
			{
				return lnDescValue;
			}
			set
			{
				this.lnDescValue = value;
			}
		}
		
		
		/// <summary>
		/// GUID of folder "Replication Base"
		/// </summary>
		public String GUID_REPLICATION_BASE
		{
			get
			{
				return GUID_REPLICATION_BASEValue;
			}
			set
			{
				this.GUID_REPLICATION_BASEValue = value;
			}
		}
		
		
		/// <summary>
		/// GUID of folder "Scripting Base"
		/// </summary>
		public String GUID_SCRIPTING_BASE
		{
			get
			{
				return GUID_SCRIPTING_BASEValue;
			}
			set
			{
				this.GUID_SCRIPTING_BASEValue = value;
			}
		}
		
		
		/// <summary>
		/// GUID of folder "IndexServer Scripting Base"
		/// </summary>
		public String GUID_IX_SCRIPTING_BASE
		{
			get
			{
				return GUID_IX_SCRIPTING_BASEValue;
			}
			set
			{
				this.GUID_IX_SCRIPTING_BASEValue = value;
			}
		}
		
		
		/// <summary>
		/// GUID of folder "Administration".
		/// </summary>
		/// <remarks>
		/// This folder contains "Replication Base", "Scripting Base" etc.
		/// </remarks>
		public String GUID_ADMINISTRATION_BASE
		{
			get
			{
				return GUID_ADMINISTRATION_BASEValue;
			}
			set
			{
				this.GUID_ADMINISTRATION_BASEValue = value;
			}
		}
		
		
		/// <summary>
		/// Archive folder /Administration/COLD Background Images
		/// </summary>
		public String GUID_COLD_BACKGROUND_IMAGES
		{
			get
			{
				return GUID_COLD_BACKGROUND_IMAGESValue;
			}
			set
			{
				this.GUID_COLD_BACKGROUND_IMAGESValue = value;
			}
		}
		
		
		/// <summary>
		/// Archive folder /Administration/ELOscripts, VB scripts for Windows Client.
		/// </summary>
		public String GUID_WIN_SCRIPTING_BASE
		{
			get
			{
				return GUID_WIN_SCRIPTING_BASEValue;
			}
			set
			{
				this.GUID_WIN_SCRIPTING_BASEValue = value;
			}
		}
		
		
		/// <summary>
		/// Archive folder that contains the icons for the workflow nodes.
		/// </summary>
		public String GUID_WORKFLOW_ICONS_BASE
		{
			get
			{
				return GUID_WORKFLOW_ICONS_BASEValue;
			}
			set
			{
				this.GUID_WORKFLOW_ICONS_BASEValue = value;
			}
		}
		
		
		/// <summary>
		/// Object-GUID of icon file for begin node.
		/// </summary>
		public String GUID_WFNODE_ICON_BEGINNODE
		{
			get
			{
				return GUID_WFNODE_ICON_BEGINNODEValue;
			}
			set
			{
				this.GUID_WFNODE_ICON_BEGINNODEValue = value;
			}
		}
		
		
		/// <summary>
		/// Object-GUID of icon file for person node.
		/// </summary>
		public String GUID_WFNODE_ICON_PERSONNODE
		{
			get
			{
				return GUID_WFNODE_ICON_PERSONNODEValue;
			}
			set
			{
				this.GUID_WFNODE_ICON_PERSONNODEValue = value;
			}
		}
		
		
		/// <summary>
		/// Object-GUID of icon file for decision node.
		/// </summary>
		public String GUID_WFNODE_ICON_IFNODE
		{
			get
			{
				return GUID_WFNODE_ICON_IFNODEValue;
			}
			set
			{
				this.GUID_WFNODE_ICON_IFNODEValue = value;
			}
		}
		
		
		/// <summary>
		/// Object-GUID of icon file for collect node.
		/// </summary>
		public String GUID_WFNODE_ICON_COLLECTNODE
		{
			get
			{
				return GUID_WFNODE_ICON_COLLECTNODEValue;
			}
			set
			{
				this.GUID_WFNODE_ICON_COLLECTNODEValue = value;
			}
		}
		
		
		/// <summary>
		/// reserved
		/// </summary>
		public String GUID_WFNODE_ICON_TERMINATE
		{
			get
			{
				return GUID_WFNODE_ICON_TERMINATEValue;
			}
			set
			{
				this.GUID_WFNODE_ICON_TERMINATEValue = value;
			}
		}
		
		
		/// <summary>
		/// Object-GUID of icon file for cycle node.
		/// </summary>
		public String GUID_WFNODE_ICON_CYCLE_BEGIN
		{
			get
			{
				return GUID_WFNODE_ICON_CYCLE_BEGINValue;
			}
			set
			{
				this.GUID_WFNODE_ICON_CYCLE_BEGINValue = value;
			}
		}
		
		
		/// <summary>
		/// Object-GUID of icon file for cycle node.
		/// </summary>
		public String GUID_WFNODE_ICON_CYCLE_END
		{
			get
			{
				return GUID_WFNODE_ICON_CYCLE_ENDValue;
			}
			set
			{
				this.GUID_WFNODE_ICON_CYCLE_ENDValue = value;
			}
		}
		
		
		/// <summary>
		/// Object-GUID of icon file for server node.
		/// </summary>
		public String GUID_WFNODE_ICON_SET_SERVER_ID
		{
			get
			{
				return GUID_WFNODE_ICON_SET_SERVER_IDValue;
			}
			set
			{
				this.GUID_WFNODE_ICON_SET_SERVER_IDValue = value;
			}
		}
		
		
		/// <summary>
		/// Object-GUID of icon file for split node.
		/// </summary>
		public String GUID_WFNODE_ICON_SPLITNODE
		{
			get
			{
				return GUID_WFNODE_ICON_SPLITNODEValue;
			}
			set
			{
				this.GUID_WFNODE_ICON_SPLITNODEValue = value;
			}
		}
		
		
		/// <summary>
		/// Object-GUID of users folder.
		/// </summary>
		public String GUID_USERS_FOLDER
		{
			get
			{
				return GUID_USERS_FOLDERValue;
			}
			set
			{
				this.GUID_USERS_FOLDERValue = value;
			}
		}
		
		
		/// <summary>
		/// Object-GUID of ELO Textreader folder.
		/// </summary>
		public String GUID_TEXTREADER_FOLDER
		{
			get
			{
				return GUID_TEXTREADER_FOLDERValue;
			}
			set
			{
				this.GUID_TEXTREADER_FOLDERValue = value;
			}
		}
		
		
		/// <summary>
		/// Object-GUID of ELO Textreader not converted documents folder.
		/// </summary>
		public String GUID_TRNOTCONV_FOLDER
		{
			get
			{
				return GUID_TRNOTCONV_FOLDERValue;
			}
			set
			{
				this.GUID_TRNOTCONV_FOLDERValue = value;
			}
		}
		
		
		/// <summary>
		/// GUID of folder "/Administration/ELO-Apps".
		/// </summary>
		public String GUID_APPS_FOLDER
		{
			get
			{
				return GUID_APPS_FOLDERValue;
			}
			set
			{
				this.GUID_APPS_FOLDERValue = value;
			}
		}
		
		
		/// <summary>
		/// Index value ELOINDEX of sub-folder "data" of a users folder.
		/// </summary>
		/// <remarks>
		/// The "data" sub-folder of a user folder can be read as follows:
		/// <code>String objId = "OKEY:ELOINDEX=" + ELOINDEX_USER_FOLDER_DATA + user-guid</code>
		/// <code>EditInfo ed = conn.ix().checkoutSord(objId, ...)</code>
		/// </remarks>
		public String ELOINDEX_USER_FOLDER_DATA
		{
			get
			{
				return ELOINDEX_USER_FOLDER_DATAValue;
			}
			set
			{
				this.ELOINDEX_USER_FOLDER_DATAValue = value;
			}
		}
		
		
		/// <summary>
		/// Index value ELOINDEX of sub-folder "data/elo.profile" of a users folder.
		/// </summary>
		public String ELOINDEX_USER_FOLDER_DATA_PROFILE
		{
			get
			{
				return ELOINDEX_USER_FOLDER_DATA_PROFILEValue;
			}
			set
			{
				this.ELOINDEX_USER_FOLDER_DATA_PROFILEValue = value;
			}
		}
		
		
		/// <summary>
		/// Index value ELOINDEX of sub-folder "private" of a users folder.
		/// </summary>
		public String ELOINDEX_USER_FOLDER_PRIVATE
		{
			get
			{
				return ELOINDEX_USER_FOLDER_PRIVATEValue;
			}
			set
			{
				this.ELOINDEX_USER_FOLDER_PRIVATEValue = value;
			}
		}
		
		
		/// <summary>
		/// Index value ELOINDEX of sub-folder "inbox" of a users folder.
		/// </summary>
		public String ELOINDEX_USER_FOLDER_INBOX
		{
			get
			{
				return ELOINDEX_USER_FOLDER_INBOXValue;
			}
			set
			{
				this.ELOINDEX_USER_FOLDER_INBOXValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// ACL in a human readable format.
		/// </summary>
		public const long mbAclItems = 1099511627776L;

		/// <summary>
		/// Replication set.
		/// </summary>
		public const long mbReplSet = 2199023255552L;

		/// <summary>
		/// Replication set names.
		/// </summary>
		public const long mbReplNames = 4398046511104L;

		/// <summary>
		/// Index lines.
		/// </summary>
		public const long mbObjKeys = 8796093022208L;

		/// <summary>
		/// Version information of the current document work version.
		/// </summary>
		public const long mbDocVersionMembers = 17592186044416L;

		/// <summary>
		/// Return the content of a "small" document in <code>DocVersion.fileData</code>.
		/// </summary>
		/// <remarks>
		/// Reading small documents is up to 3 times faster this way.
		/// The IX configuration defines the maximum size of a
		/// "small" document (e. g. less than 100KB).
		/// </remarks>
		public const long mbSmallDocumentContent = 35184372088832L;

		/// <summary>
		/// Detects whether there is a preview for a given document availiable.
		/// </summary>
		public const long mbPreview = 70368744177664L;

		/// <summary>
		/// Set this option to return the physical path of the document in the DocVersion object.
		/// </summary>
		/// <remarks>
		/// This Option requires always a request to Document Manager.
		/// </remarks>
		public const long mbPhysPath = 70368744177664L;

		/// <summary>
		/// GUIDs of parents that reference <code>this</code>
		/// </summary>
		public const long mbParentIds = 140737488355328L;

		/// <summary>
		/// GUIDs of linked archive entries.
		/// </summary>
		public const long mbLinks = 281474976710656L;

		public const long mbRefPaths = 562949953421312L;

		/// <summary>
		/// Member bit for Sord.attVersion
		/// </summary>
		public const long mbAttVersionMembers = 1125899906842624L;

		/// <summary>
		/// Document file content is supplied in {@link FileData#stream}.
		/// </summary>
		public const long mbContentStream = 2251799813685248L;

		public const long mbIDateIso = 128L;

		public const long mbXDateIso = 256L;

		public const long mbDelDateIso = 8388608L;

		public const long mbDeleted = 524288L;

		public const long mbDetails = 16L;

		public const long mbDocVersion = 17592186044416L;

		public const long mbHiddenText = 2097152L;

		public const long mbLinksComeIn = 281474976710656L;

		public const long mbLinksGoOut = 281474976710656L;

		public const long mbOwnerName = 131072L;

		/// <summary>
		/// Description and Hidden Text
		/// </summary>
		public const long mbDesc = 2097152L;

		/// <summary>
		/// This members are read-only and ignored in checkinSord
		/// </summary>
		public const long mbReadOnlyMembers = 985175307845632L;

		/// <summary>
		/// This members are write-only and were not read in checkoutSord, checkoutDoc, findFirstSords.
		/// </summary>
		/// <remarks>
		/// mbSDesc, mbSName
		/// </remarks>
		public const long mbWriteOnlyMembers = 1610612736L;

		protected int lnDescValue;

		/// <summary>
		/// All members - without mbSmallDocumentContent
		/// </summary>
		public new const long mbAllMembers = 2145422063697919L;

		/// <summary>
		/// Includes:
		/// ObjDataC.mbAllMembers with mbAclItems, mbObjKeys
		/// </summary>
		public const long mbLeanMembers = 10168869847039L;

		/// <summary>
		/// Includes:
		/// ObjDataC.mbAllMembers with mbObjKeys
		/// </summary>
		public const long mbReplMembers = 9070970929151L;

		/// <summary>
		/// Includes:
		/// mbLeanMembers without mbObjKeys
		/// </summary>
		public const long mbMinMembers = 1372776824831L;

		/// <summary>
		/// <code>Sord</code> objects with type greater or equal than
		/// <code>LBT_DOCUMENT</code> and less or equal than
		/// <code>LBT_DOCUMENT_MAX</code> are documents.
		/// </summary>
		public const int LBT_DOCUMENT = 254;

		/// <summary>
		/// <code>Sord</code> objects with type greater or equal than
		/// <code>LBT_DOCUMENT</code> and less or equal than
		/// <code>LBT_DOCUMENT_MAX</code> are documents.
		/// </summary>
		public const int LBT_DOCUMENT_MAX = 310;

		/// <summary>
		/// There is one <code>Sord</code> object inside the archive database with ID 1.
		/// </summary>
		/// <remarks>
		/// It contains some archive configuration and has this type:
		/// </remarks>
		public const int LBT_ARCHIVE = 9999;

		/// <summary>
		/// Sord type of user folder.
		/// </summary>
		/// <remarks>
		/// User folders are stored under folder Administration/Users and
		/// this value is used as {@link Sord#type}.
		/// </remarks>
		public const int TYPE_USER_FOLDER = 23;

		/// <summary>
		/// Implementation detail: This flag is added to the object ID in the table
		/// "dochistory" to differentiate between documents and attachments.
		/// </summary>
		public const int ATTACHMENT_FLAG_IN_DOCHISTORY = 1073741824;

		/// <summary>
		/// All members
		/// without
		/// mbSmallDocumentContent
		/// mbPreview
		/// </summary>
		public readonly static EloixClient.IndexServer.SordZ mbAll = new SordZ(2145422063697919L);

		/// <summary>
		/// Lean members
		/// </summary>
		public readonly static EloixClient.IndexServer.SordZ mbLean = new SordZ(10168869847039L);

		/// <summary>
		/// All members
		/// without
		/// mbSmallDocumentContent
		/// mbPreview
		/// mbDocVersionMembers
		/// mbRefPaths
		/// mbAttVersionMembers
		/// </summary>
		public readonly static EloixClient.IndexServer.SordZ mbAllIndex = new SordZ(438980017389567L);

		/// <summary>
		/// Minimum members.
		/// </summary>
		public readonly static EloixClient.IndexServer.SordZ mbMin = new SordZ(1372776824831L);

		/// <summary>
		/// Includes only <code>Sord.id</code>
		/// </summary>
		public readonly static EloixClient.IndexServer.SordZ mbOnlyId = new SordZ(1L);

		/// <summary>
		/// Includes only <code>Sord.guid</code>
		/// </summary>
		public readonly static EloixClient.IndexServer.SordZ mbOnlyGuid = new SordZ(2L);

		/// <summary>
		/// Do not store/read any members.
		/// </summary>
		/// <remarks>
		/// Evaluate the lock flag only.
		/// </remarks>
		public readonly static EloixClient.IndexServer.SordZ mbOnlyLock = new SordZ(0L);

		/// <summary>
		/// Same as mbOnlyLock
		/// </summary>
		public readonly static EloixClient.IndexServer.SordZ mbOnlyUnlock = new SordZ(0L);

		/// <summary>
		/// Includes:
		/// mbMinMembers,
		/// mbDocVersionMembers,
		/// mbPreview
		/// </summary>
		public readonly static EloixClient.IndexServer.SordZ mbMinDocVersion = new SordZ(89333707046911L);

		/// <summary>
		/// Includes:
		/// mbAllMembers,
		/// mbSmallDocumentContent
		/// without
		/// mbPreview
		/// </summary>
		public readonly static EloixClient.IndexServer.SordZ mbCheckout = new SordZ(2180606435786751L);

		/// <summary>
		/// Includes:
		/// mbAllMembers,
		/// mbSmallDocumentContent,
		/// mbPreview
		/// </summary>
		public readonly static EloixClient.IndexServer.SordZ mbCheckoutPreview = new SordZ(2250975179964415L);

		/// <summary>
		/// The objdesc column in the database is splitted into a visible and an
		/// invisible part.
		/// </summary>
		/// <remarks>
		/// This constant is the delimiter between them.
		/// </remarks>
		public const String DESC_DELIM = "!!ELO_DELIM!!";

		protected String GUID_REPLICATION_BASEValue;

		protected String GUID_SCRIPTING_BASEValue;

		protected String GUID_IX_SCRIPTING_BASEValue;

		protected String GUID_ADMINISTRATION_BASEValue;

		protected String GUID_COLD_BACKGROUND_IMAGESValue;

		protected String GUID_WIN_SCRIPTING_BASEValue;

		protected String GUID_WORKFLOW_ICONS_BASEValue;

		protected String GUID_WFNODE_ICON_BEGINNODEValue;

		protected String GUID_WFNODE_ICON_PERSONNODEValue;

		protected String GUID_WFNODE_ICON_IFNODEValue;

		protected String GUID_WFNODE_ICON_COLLECTNODEValue;

		protected String GUID_WFNODE_ICON_TERMINATEValue;

		protected String GUID_WFNODE_ICON_CYCLE_BEGINValue;

		protected String GUID_WFNODE_ICON_CYCLE_ENDValue;

		protected String GUID_WFNODE_ICON_SET_SERVER_IDValue;

		protected String GUID_WFNODE_ICON_SPLITNODEValue;

		protected String GUID_USERS_FOLDERValue;

		protected String GUID_TEXTREADER_FOLDERValue;

		protected String GUID_TRNOTCONV_FOLDERValue;

		protected String GUID_APPS_FOLDERValue;

		protected String ELOINDEX_USER_FOLDER_DATAValue;

		protected String ELOINDEX_USER_FOLDER_DATA_PROFILEValue;

		protected String ELOINDEX_USER_FOLDER_PRIVATEValue;

		protected String ELOINDEX_USER_FOLDER_INBOXValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1553100003L;		
	} // end class
}  // end namespace
