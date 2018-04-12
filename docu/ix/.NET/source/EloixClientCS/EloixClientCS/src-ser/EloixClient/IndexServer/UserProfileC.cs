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
	/// The constants in this class exist due to compatibility requirements with
	/// older Index Server versions, which gave back formatted data (Sord.xDataDispl).
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class UserProfileC : BSerializable
	{
	
		#region Constructors
		
		public UserProfileC() {
		}		
		
		public UserProfileC(int @lnKey, int @lnValue) {
			this.lnKeyValue = @lnKey;
			this.lnValueValue = @lnValue;
		}		
		
		public UserProfileC(UserProfileC rhs)
		{
			this.lnKeyValue = rhs.lnKeyValue;
			this.lnValueValue = rhs.lnValueValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Maximum length of key
		/// </summary>
		public int lnKey
		{
			get
			{
				return lnKeyValue;
			}
			set
			{
				this.lnKeyValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum length of value
		/// </summary>
		public int lnValue
		{
			get
			{
				return lnValueValue;
			}
			set
			{
				this.lnValueValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		public const String DATE_FORMAT = "DateFormat";

		public const String SORD_DATE_FORMAT = "DateFormat:Sord";

		public const String SORD_IDATE_FORMAT = "DateFormat:Sord:IDate";

		public const String SORD_XDATE_FORMAT = "DateFormat:Sord:XDate";

		public const String SORD_DELDATE_FORMAT = "DateFormat:Sord:DelDate";

		public const String DOC_VERSION_DATE_FORMAT = "DateFormat:DocVersion";

		public const String DOC_VERSION_CREATE_FORMAT = "DateFormat:DocVersion:createDate";

		public const String DOC_VERSION_ACCESS_FORMAT = "DateFormat:DocVersion:accessDate";

		public const String DOC_VERSION_UPDATE_FORMAT = "DateFormat:DocVersion:updateDate";

		/// <summary>
		/// Read/write user profile options for all users.
		/// </summary>
		public const String USERID_ALL = "2147483647";

		/// <summary>
		/// Extended access control for documents or folders used in workflows.
		/// </summary>
		/// <remarks>
		/// <p>
		/// There are two concepts of extending access control for folders and documents routed though a workflow.
		/// The rules are only applied if (a) the current user has an active workflow task for the folder or document and
		/// (b) the right AccessC.FLAG2_EXTEND_WORKFLOW_RIGHTS is assigned to the current user.
		/// </p><p>
		/// 1. Overlay additional access rights over the objects ACL: the lower 8 bits of the keys value
		/// specify a combination of AccessC.LUR_* constants that are added to the ACL access rights when access checking is performed.
		/// The objects ACL is not modified, this rule only changes the internal program logic.
		/// </p><p>
		/// 2. Permanently add additional access to the ACL: the higher 8 bits of the keys value
		/// specify a combination of AccessC.LUR_* constants for a new ACL entry to be added for the current user.
		/// The ACL is only extended, if checkoutSord or checkoutDoc detects less access for the current user.
		/// </remarks>
		public const String KEY_EXTEND_DOCUMENT_ACCESS_IN_WORKFLOW = "Client.1386.2.0.Options.ExpandWfRights.";

		/// <summary>
		/// Password rules.
		/// </summary>
		/// <remarks>
		/// The password rules are stored as a comma separated list of 5 Integers, e.g. "7,1,1,0,0".
		/// 1. Minimum password length
		/// 2. Is != 0, if password must contain at least one letter.
		/// 3. Is != 0, if password must contain at least one special character (not letter and not digit).
		/// 4. Is != 0, if password must contain at least one lower case and one upper case letter.
		/// 5. Is != 0, if password must contain at least one digit.
		/// </remarks>
		public const String KEY_PASSWORD_RULES = "Client.1235.1.0.Options.MinPassword.";

		/// <summary>
		/// The password has to be changed after this number of days.
		/// </summary>
		/// <remarks>
		/// The value corresponds to UserInfo.userProps[UserInfoC.PROP_ACTION].
		/// </remarks>
		public const String KEY_PASSWORD_VALID_DAYS = "Client.1215.2.0.Options.PasswordValidInDays.";

		/// <summary>
		/// Give the archive's language (set by a new installation since Server Setup 9.00.004).
		/// </summary>
		public const String KEY_ARCHIVE_LANGUAGE = "Elo.Search.archivelang";

		/// <summary>
		/// Automatically subscribe Feed if the User creates a new Document
		/// </summary>
		public const String KEY_FEED_SUBSCRIBE_MYDOC = "Elo.Feed.subscribe.mydoc";

		/// <summary>
		/// Automatically subscribe Feed if the User creates a new Folder
		/// </summary>
		public const String KEY_FEED_SUBSCRIBE_MYFOLDER = "Elo.Feed.subscribe.myfolder";

		/// <summary>
		/// Automatically subscribe Feed if the User creates a new Version of a Document
		/// </summary>
		public const String KEY_FEED_SUBSCRIBE_NEWVERSION = "Elo.Feed.subscribe.newversion";

		/// <summary>
		/// Automatically subscribe Feed if the User adds a comment to a Feed
		/// </summary>
		public const String KEY_FEED_SUBSCRIBE_NEWCOMMENT = "Elo.Feed.subscribe.newcomment";

		/// <summary>
		/// Prefix for fulltext search options.
		/// </summary>
		public const String KEY_PREFIX_FULLTEXT_SEARCH_OPTIONS = "Elo.Search.";

		protected int lnKeyValue;

		protected int lnValueValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1968434410L;		
	} // end class
}  // end namespace
