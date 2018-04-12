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
	/// <p>This class defines constants for access rights.
	/// </summary>
	/// <remarks>
	/// </p>
	/// <p>The <pre><code>FLAG_*</code></pre> constants are used in <pre><code>UserInfo.flags.
	/// The <pre><code>LUR_*</code></pre> constants are used in access control lists. </p>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class AccessC : BSerializable
	{
	
		#region Constructors
		
		public AccessC() {
		}		
		
		public AccessC(AccessC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Main administrator, can edit all users and groups.
		/// </summary>
		public const int FLAG_ADMIN = 1;

		/// <summary>
		/// Edit master data
		/// </summary>
		public const int FLAG_EDITCONFIG = 2;

		/// <summary>
		/// Edit archive structure: create, edit, move archive entries.
		/// </summary>
		public const int FLAG_EDITSTRUCTURE = 4;

		/// <summary>
		/// Edit documents: checkin, checkout.
		/// </summary>
		public const int FLAG_EDITDOCS = 8;

		/// <summary>
		/// Change password.
		/// </summary>
		public const int FLAG_CHANGEPW = 16;

		/// <summary>
		/// Change the archiving mode of a document.
		/// </summary>
		public const int FLAG_CHANGEREV = 32;

		/// <summary>
		/// Administrator, can edit only the users and groups he created.
		/// </summary>
		public const int FLAG_SUBADMIN = 64;

		/// <summary>
		/// Edit work flows.
		/// </summary>
		public const int FLAG_EDITWF = 128;

		/// <summary>
		/// Start work flows.
		/// </summary>
		public const int FLAG_STARTWF = 256;

		/// <summary>
		/// Delete documents.
		/// </summary>
		public const int FLAG_DELDOC = 512;

		/// <summary>
		/// Delete archive entries.
		/// </summary>
		public const int FLAG_DELSTRUC = 1024;

		/// <summary>
		/// SAP administrator.
		/// </summary>
		public const int FLAG_SAPADMIN = 4096;

		/// <summary>
		/// Import.
		/// </summary>
		public const int FLAG_IMPORT = 8192;

		/// <summary>
		/// Export.
		/// </summary>
		public const int FLAG_EXPORT = 16384;

		/// <summary>
		/// Create, edit, delete storage masks.
		/// </summary>
		public const int FLAG_EDITMASK = 32768;

		/// <summary>
		/// Create, edit, delete scripts.
		/// </summary>
		public const int FLAG_EDITSCRIPT = 65536;

		/// <summary>
		/// Edit expiration date of archive entries.
		/// </summary>
		public const int FLAG_EDITDUEDATE = 131072;

		/// <summary>
		/// Edit catchwords.
		/// </summary>
		public const int FLAG_EDITSWL = 262144;

		/// <summary>
		/// Delete read only documents.
		/// </summary>
		public const int FLAG_DELREADONLY = 524288;

		/// <summary>
		/// Edit replication set assignment.
		/// </summary>
		public const int FLAG_EDITREPL = 1048576;

		/// <summary>
		/// Edit security settings.
		/// </summary>
		public const int FLAG_EDITACL = 2097152;

		/// <summary>
		/// Ignore access control lists.
		/// </summary>
		public const int FLAG_IGNOREACL = 4194304;

		/// <summary>
		/// Edit scanner settings.
		/// </summary>
		public const int FLAG_EDITSCAN = 8388608;

		/// <summary>
		/// Change the storage mask of an existing (not new) archive entry.
		/// </summary>
		public const int FLAG_CHANGEMASK = 16777216;

		/// <summary>
		/// Edit activity projects.
		/// </summary>
		public const int FLAG_EDITACT = 33554432;

		/// <summary>
		/// Change storage path settings.
		/// </summary>
		public const int FLAG_CHANGEPATH = 67108864;

		/// <summary>
		/// User cannot login.
		/// </summary>
		/// <remarks>
		/// This is not a right but a prohibition.
		/// </remarks>
		public const int FLAG_NOLOGIN = 134217728;

		/// <summary>
		/// Delete a document version in history
		/// </summary>
		public const int FLAG_DELVERSION = 268435456;

		/// <summary>
		/// Author for release documents
		/// </summary>
		public const int FLAG_AUTHOR = 536870912;

		/// <summary>
		/// Read document file.
		/// </summary>
		public const int FLAG_HASFILEACCESS = 1073741824;

		/// <summary>
		/// This flag marks an option group.
		/// </summary>
		public const int FLAG_IS_OPTION_GROUP = -2147483648;

		/// <summary>
		/// All rights (without flag <pre><code>FLAG_NOLOGIN</code></pre> and <pre><code>FLAG_IS_OPTION_GROUP</code></pre>).
		/// </summary>
		public const int FLAG_ALL = 2013265919;

		/// <summary>
		/// User right: Allow interactive login.
		/// </summary>
		/// <remarks>
		/// This value has to be used in the UserInfo.flags2 member.
		/// </remarks>
		public const int FLAG2_INTERACTIVE_LOGIN = 1;

		/// <summary>
		/// User right: extend ACL during workflow execution.
		/// </summary>
		/// <remarks>
		/// This value has to be used in the UserInfo.flags2 member.
		/// </remarks>
		public const int FLAG2_EXTEND_WORKFLOW_RIGHTS = 2;

		/// <summary>
		/// User right: user is visible in a select box.
		/// </summary>
		/// <remarks>
		/// This value has to be used in the UserInfo.flags2 member.
		/// </remarks>
		public const int FLAG2_VISIBLE_USER = 4;

		/// <summary>
		/// User right: user works with ELO DMS Desktop.
		/// </summary>
		/// <remarks>
		/// This value has to be used in the UserInfo.flags2 member.
		/// </remarks>
		public const int FLAG2_IS_DMS_DESKTOP_USER = 8;

		/// <summary>
		/// User right: user can see additional keywording information.
		/// </summary>
		/// <remarks>
		/// This value has to be used in the UserInfo.flags2 member.
		/// </remarks>
		public const int FLAG2_SHOW_EXTRA_INFO = 16;

		/// <summary>
		/// User right: user is visible in document feed.
		/// </summary>
		/// <remarks>
		/// This value has to be used in the UserInfo.flags2 member.
		/// </remarks>
		public const int FLAG2_VISIBLE_FEED_USER = 32;

		/// <summary>
		/// User right: workflow controller.
		/// </summary>
		/// <remarks>
		/// This right allows a user to read all active workflows - even those where she or he is not involved.
		/// In IX 8.x, this functionality was implemented by the IX option usersCanReadAllActiveWorkflows.
		/// IX 9.x does not support this option, since it was a quick and very limited solution to archive compatibility with Windows Client.
		/// </remarks>
		public const int FLAG2_WF_CONTROLLER = 64;

		/// <summary>
		/// User right: limited client.
		/// </summary>
		/// <remarks>
		/// This right limits the functionality of the client application.
		/// In AdminConsole, this flag ist named "ELOxc Client User, Email only".
		/// </remarks>
		public const int FLAG2_LIMITED_CLIENT = 128;

		/// <summary>
		/// User right: analytics discover.
		/// </summary>
		/// <remarks>
		/// This right allows a user to access the 'discover' area at ELO Analytics and to edit searches.
		/// </remarks>
		public const int FLAG2_ANALYTICS_DISCOVER = 256;

		/// <summary>
		/// User right: analytics visualize.
		/// </summary>
		/// <remarks>
		/// This right allows a user to access the 'visualize' area at ELO Analytics and to edit visualizations.
		/// </remarks>
		public const int FLAG2_ANALYTICS_VISUALIZE = 512;

		/// <summary>
		/// User right: analytics dashboard edit.
		/// </summary>
		/// <remarks>
		/// This right allows a user to access the 'dashboard' area at ELO Analytics and to edit dashboards.
		/// </remarks>
		public const int FLAG2_ANALYTICS_DASHBOARD_EDIT = 1024;

		/// <summary>
		/// User right: analytics dashboard view.
		/// </summary>
		/// <remarks>
		/// This right allows a user to view predefined dashboards.
		/// </remarks>
		public const int FLAG2_ANALYTICS_DASHBOARD_VIEW = 2048;

		/// <summary>
		/// User right: all rights for UserInfo#flags2
		/// This value has to be used in the UserInfo.flags2 member.
		/// </summary>
		public const int FLAG2_ALL = 255;

		/// <summary>
		/// Access control right for reading an archive entry.
		/// </summary>
		public const int LUR_READ = 1;

		/// <summary>
		/// Access control right for writing an archive entry.
		/// </summary>
		public const int LUR_WRITE = 2;

		/// <summary>
		/// Access control right for deleting an archive entry.
		/// </summary>
		public const int LUR_DELETE = 4;

		/// <summary>
		/// Access control right for beeing able to checkin a new document version.
		/// </summary>
		public const int LUR_EDIT = 8;

		/// <summary>
		/// Insert or remove an entry to the list of subentries of a Sord.
		/// </summary>
		public const int LUR_LIST = 16;

		/// <summary>
		/// All access control rights.
		/// </summary>
		public const int LUR_ALL = 31;

		/// <summary>
		/// No access.
		/// </summary>
		public const int LUR_NOTHING = 0;

		#endregion
		
		
		public static readonly long serialVersionUID = 384025970L;		
	} // end class
}  // end namespace
