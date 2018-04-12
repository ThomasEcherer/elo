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
	/// <p>Constants related to user information.
	/// </summary>
	/// <remarks>
	/// </p>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class UserInfoC : BSerializable
	{
	
		#region Constructors
		
		public UserInfoC() {
		}		
		
		public UserInfoC(int @lnName, int @lnPwd, int @lnDesc, int @lnUserProp, int @lnLdapPropKey, int @lnLdapPropValue, String @GUID_EVERYONE_GROUP, String @GUID_ADMINISTRATOR) {
			this.lnNameValue = @lnName;
			this.lnPwdValue = @lnPwd;
			this.lnDescValue = @lnDesc;
			this.lnUserPropValue = @lnUserProp;
			this.lnLdapPropKeyValue = @lnLdapPropKey;
			this.lnLdapPropValueValue = @lnLdapPropValue;
			this.GUID_EVERYONE_GROUPValue = @GUID_EVERYONE_GROUP;
			this.GUID_ADMINISTRATORValue = @GUID_ADMINISTRATOR;
		}		
		
		public UserInfoC(UserInfoC rhs)
		{
			this.lnNameValue = rhs.lnNameValue;
			this.lnPwdValue = rhs.lnPwdValue;
			this.lnDescValue = rhs.lnDescValue;
			this.lnUserPropValue = rhs.lnUserPropValue;
			this.lnLdapPropKeyValue = rhs.lnLdapPropKeyValue;
			this.lnLdapPropValueValue = rhs.lnLdapPropValueValue;
			this.GUID_EVERYONE_GROUPValue = rhs.GUID_EVERYONE_GROUPValue;
			this.GUID_ADMINISTRATORValue = rhs.GUID_ADMINISTRATORValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Maximum user name length
		/// </summary>
		public int lnName
		{
			get
			{
				return lnNameValue;
			}
			set
			{
				this.lnNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum user password length
		/// </summary>
		public int lnPwd
		{
			get
			{
				return lnPwdValue;
			}
			set
			{
				this.lnPwdValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum user desc length
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
		/// Maximum user property length
		/// </summary>
		public int lnUserProp
		{
			get
			{
				return lnUserPropValue;
			}
			set
			{
				this.lnUserPropValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum length of LDAP property key.
		/// </summary>
		public int lnLdapPropKey
		{
			get
			{
				return lnLdapPropKeyValue;
			}
			set
			{
				this.lnLdapPropKeyValue = value;
			}
		}
		
		
		/// <summary>
		/// Maximum length of LDAP property value.
		/// </summary>
		public int lnLdapPropValue
		{
			get
			{
				return lnLdapPropValueValue;
			}
			set
			{
				this.lnLdapPropValueValue = value;
			}
		}
		
		
		/// <summary>
		/// GUID of group "Everybody"
		/// </summary>
		public String GUID_EVERYONE_GROUP
		{
			get
			{
				return GUID_EVERYONE_GROUPValue;
			}
			set
			{
				this.GUID_EVERYONE_GROUPValue = value;
			}
		}
		
		
		/// <summary>
		/// GUID of main administrator
		/// </summary>
		public String GUID_ADMINISTRATOR
		{
			get
			{
				return GUID_ADMINISTRATORValue;
			}
			set
			{
				this.GUID_ADMINISTRATORValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Maximum number of user properties.
		/// </summary>
		public const int MAX_USERPROP = 8;

		/// <summary>
		/// Maximum number of keys.
		/// </summary>
		public const int MAX_KEY = 254;

		/// <summary>
		/// Maximale number of users and groups.
		/// </summary>
		public const int MAX_USERS = 16384;

		/// <summary>
		/// Maximum number of groups per user.
		/// </summary>
		public const int MAX_GROUPS = 16384;

		/// <summary>
		/// Maximum number of persistent groups per user.
		/// </summary>
		public const int MAX_PERSISTENT_GROUPS = 16384;

		/// <summary>
		/// Type value for an user.
		/// </summary>
		public const int TYPE_USER = 1;

		/// <summary>
		/// Type value for a group.
		/// </summary>
		public const int TYPE_GROUP = 0;

		/// <summary>
		/// Type value for the current user
		/// </summary>
		public const int TYPE_USERID_OWNER = -2;

		public const int MAX_NAME = 64;

		public const int PROP_NAME_OS = 0;

		public const int PROP_NAME_EMAIL = 1;

		/// <summary>
		/// This user property is used to trigger actions in the client application.
		/// </summary>
		/// <remarks>
		/// The value of the property is found at UserInfo.userProps[UserInfoC.PROP_ACTION].
		/// If the value contains the String PROP_ACTION_SHOW_PASSWORD_DIALOG, the user should change the password.
		/// If the value contains the String PROP_ACTION_FORCE_CHANGE_PASSWORD, the user must change the password.
		/// If the value contains the String PROP_ACTION_END_PASSWORD_DATE, the password expires at the ISO date
		/// defined by the next 10 characters. E.g. "EX20120405" means that the password expires at April 5, 2012.
		/// </remarks>
		public const int PROP_ACTION = 3;

		/// <summary>
		/// The user should change the password.
		/// </summary>
		public const String PROP_ACTION_USER_SHOULD_CHANGE_PASSWORD = "PW";

		/// <summary>
		/// The user must change the password.
		/// </summary>
		public const String PROP_ACTION_USER_MUST_CHANGE_PASSWORD = "PWf";

		/// <summary>
		/// The password expires.
		/// </summary>
		public const String PROP_ACTION_END_PASSWORD_DATE = "EX";

		/// <summary>
		/// User property GUID.
		/// </summary>
		public const int PROP_GUID = 4;

		protected int lnNameValue;

		protected int lnPwdValue;

		protected int lnDescValue;

		protected int lnUserPropValue;

		protected int lnLdapPropKeyValue;

		protected int lnLdapPropValueValue;

		/// <summary>
		/// Every user is in the group "Everyone".
		/// </summary>
		/// <remarks>
		/// This is
		/// the internal ID for this group.
		/// </remarks>
		public const int ID_EVERYONE_GROUP = 9999;

		/// <summary>
		/// User ID of main administrator.
		/// </summary>
		public const int ID_ADMINISTRATOR = 0;

		protected String GUID_EVERYONE_GROUPValue;

		protected String GUID_ADMINISTRATORValue;

		/// <summary>
		/// This value can be set for UserInfo.pwd to
		/// </summary>
		public const String PWD_VALUE_IGNORE = "(1E6ADC03-1A05-4df0-B627-3DAE0F6DA133)_ignorepwd";

		/// <summary>
		/// Common name
		/// </summary>
		public const String LDAP_PROP_CN = "cn";

		/// <summary>
		/// Distinguished name
		/// </summary>
		public const String LDAP_PROP_DISTINGUISHED_NAME = "distinguishedName";

		/// <summary>
		/// Display name
		/// </summary>
		public const String LDAP_PROP_DISPLAY_NAME = "displayName";

		/// <summary>
		/// Name
		/// </summary>
		public const String LDAP_PROP_NAME = "name";

		/// <summary>
		/// Proxy addresses
		/// </summary>
		public const String LDAP_PROP_PROXY_ADDRESSES = "proxyAddresses";

		/// <summary>
		/// Flags that control the behavior of the user account
		/// </summary>
		public const String LDAP_PROP_USER_ACCOUNT_CONTROL = "userAccountControl";

		/// <summary>
		/// NT account name
		/// </summary>
		public const String LDAP_PROP_SAM_ACCOUNT_NAME = "sAMAccountName";

		/// <summary>
		/// Contains information about every account type object
		/// </summary>
		public const String LDAP_PROP_SAM_ACCOUNT_TYPE = "sAMAccountType";

		/// <summary>
		/// User principal name
		/// </summary>
		public const String LDAP_PROP_USER_PRINCIPAL_NAME = "userPrincipalName";

		/// <summary>
		/// Object category
		/// </summary>
		public const String LDAP_PROP_OBJECT_CATEGORY = "objectCategory";

		/// <summary>
		/// Mail nick name
		/// </summary>
		public const String LDAP_PROP_MAIL_NICK_NAME = "mailNickname";

		/// <summary>
		/// The unique identifier for an object
		/// </summary>
		public const String LDAP_PROP_OBJECT_GUID = "objectGUID";

		/// <summary>
		/// A binary value that specifies the security identifier (SID) of the user.
		/// </summary>
		public const String LDAP_PROP_OBJECT_SID = "objectSid";

		/// <summary>
		/// Mailbox globally unique identifier
		/// </summary>
		public const String LDAP_PROP_MS_EXCHANGE_MAILBOX_GUID = "msExchMailboxGuid";

		/// <summary>
		/// Group type
		/// </summary>
		public const String LDAP_PROP_GROUP_TYPE = "groupType";

		/// <summary>
		/// Full Qualified Domain Name
		/// </summary>
		public const String LDAP_PROP_FQDN = "fqdn";

		/// <summary>
		/// Online
		/// </summary>
		public const String LDAP_PROP_ONLINE = "online";

		/// <summary>
		/// Object class
		/// </summary>
		public const String LDAP_PROP_OBJECT_CLASS = "objectClass";

		/// <summary>
		/// Member of
		/// </summary>
		public const String LDAP_PROP_MEMBER_OF = "memberOf";

		/// <summary>
		/// LegacyExchangeDN
		/// </summary>
		public const String LDAP_PROP_LEGACY_EXCHANGE_DN = "legacyExchangeDN";

		/// <summary>
		/// Mail
		/// </summary>
		public const String LDAP_PROP_MAIL = "mail";

		/// <summary>
		/// msExchHideFromAddressLists
		/// </summary>
		public const String LDAP_PROP_EXCH_HIDE_FROM_ADDRESS_LISTS = "msExchHideFromAddressLists";

		/// <summary>
		/// msExchRecipientTypeDetails
		/// </summary>
		public const String LDAP_PROP_EXCH_RECIPIENT_TYPE_DETAILS = "msExchRecipientTypeDetails";

		/// <summary>
		/// msExchRecipientDisplayType
		/// </summary>
		public const String LDAP_PROP_EXCH_RECIPIENT_DISPLAY_TYPE = "msExchRecipientDisplayType";

		/// <summary>
		/// msExchDelegateListLink
		/// </summary>
		public const String LDAP_PROP_EXCH_DELEGATE_LIST_LINK = "msExchDelegateListLink";

		/// <summary>
		/// msExchPublicFolderMailbox
		/// </summary>
		public const String LDAP_PROP_EXCH_PUBFOLDER_MAILBOX = "msExchPublicFolderMailbox";

		/// <summary>
		/// adminDisplayName
		/// </summary>
		public const String LDAP_PROP_ADMIN_DISPLAY_NAME = "adminDisplayName";

		/// <summary>
		/// msExchMessageJournalRecipient
		/// </summary>
		public const String LDAP_PROP_EXCH_JOURNAL_RCPT = "msExchMessageJournalRecipient";

		/// <summary>
		/// msExchOwningServer
		/// </summary>
		public const String LDAP_PROP_EXCH_OWNING_SERVER = "msExchOwningServer";

		/// <summary>
		/// PrimarySmtpAddress
		/// </summary>
		public const String LDAP_PROP_ONLINE_MAIL = "PrimarySmtpAddress";

		/// <summary>
		/// RecipientTypeDetails
		/// </summary>
		public const String LDAP_PROP_ONLINE_RECIPIENT_TYPE_DETAILS = "RecipientTypeDetails";

		/// <summary>
		/// Guid
		/// </summary>
		public const String LDAP_PROP_ONLINE_GUID = "Guid";

		/// <summary>
		/// IsMailboxEnabled
		/// </summary>
		public const String LDAP_PROP_ONLINE_MAILBOX_ENABLED = "IsMailboxEnabled";

		/// <summary>
		/// Common name.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_CN = "cn";

		/// <summary>
		/// Distinguished name.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_DISTINGUISHED_NAME = "distinguishedname";

		/// <summary>
		/// Display name.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_DISPLAY_NAME = "displayname";

		/// <summary>
		/// Name.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties.
		/// </remarks>
		public const String LDAP_KEY_NAME = "name";

		/// <summary>
		/// Proxy addresses.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_PROXY_ADDRESSES = "proxyaddresses";

		/// <summary>
		/// Flags that control the behavior of the user account.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_USER_ACCOUNT_CONTROL = "useraccountcontrol";

		/// <summary>
		/// NT account name.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_SAM_ACCOUNT_NAME = "samaccountname";

		/// <summary>
		/// Contains information about every account type object.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_SAM_ACCOUNT_TYPE = "samaccounttype";

		/// <summary>
		/// User principal name.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_USER_PRINCIPAL_NAME = "userprincipalname";

		/// <summary>
		/// Object category.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_OBJECT_CATEGORY = "objectcategory";

		/// <summary>
		/// Mail nick name.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_MAIL_NICK_NAME = "mailnickname";

		/// <summary>
		/// The unique identifier for an object.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_OBJECT_GUID = "objectguid";

		/// <summary>
		/// A binary value that specifies the security identifier (SID) of the user.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_OBJECT_SID = "objectsid";

		/// <summary>
		/// Mailbox globally unique identifier.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_MS_EXCHANGE_MAILBOX_GUID = "msexchmailboxguid";

		/// <summary>
		/// Group type.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_GROUP_TYPE = "grouptype";

		/// <summary>
		/// Full Qualified Domain Name.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_FQDN = "fqdn";

		/// <summary>
		/// Online.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_ONLINE = "online";

		/// <summary>
		/// Object class.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_OBJECT_CLASS = "objectclass";

		/// <summary>
		/// Member of.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_MEMBER_OF = "memberof";

		/// <summary>
		/// LegacyExchangeDN.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_LEGACY_EXCHANGE_DN = "legacyexchangedn";

		/// <summary>
		/// Mail.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_MAIL = "mail";

		/// <summary>
		/// msExchHideFromAddressLists.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_EXCH_HIDE_FROM_ADDRESS_LISTS = "msexchhidefromaddresslists";

		/// <summary>
		/// msExchRecipientTypeDetails.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_EXCH_RECIPIENT_TYPE_DETAILS = "msexchrecipienttypedetails";

		/// <summary>
		/// msExchRecipientDisplayType.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_EXCH_RECIPIENT_DISPLAY_TYPE = "msexchrecipientdisplaytype";

		/// <summary>
		/// msExchDelegateListLink.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_EXCH_DELEGATE_LIST_LINK = "msexchdelegatelistlink";

		/// <summary>
		/// msExchPublicFolderMailbox.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_EXCH_PUBFOLDER_MAILBOX = "msexchpublicfoldermailbox";

		/// <summary>
		/// adminDisplayName.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_ADMIN_DISPLAY_NAME = "admindisplayname";

		/// <summary>
		/// msExchMessageJournalRecipient.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_EXCH_JOURNAL_RCPT = "msexchmessagejournalrecipient";

		/// <summary>
		/// msExchOwningServer.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_EXCH_OWNING_SERVER = "msexchowningserver";

		/// <summary>
		/// PrimarySmtpAddress.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_ONLINE_MAIL = "primarysmtpaddress";

		/// <summary>
		/// RecipientTypeDetails.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_ONLINE_RECIPIENT_TYPE_DETAILS = "recipienttypedetails";

		/// <summary>
		/// Guid.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_ONLINE_GUID = "guid";

		/// <summary>
		/// IsMailboxEnabled.
		/// </summary>
		/// <remarks>
		/// Key to access the map UserInfo.ldapProperties
		/// </remarks>
		public const String LDAP_KEY_ONLINE_MAILBOX_ENABLED = "ismailboxenabled";

		#endregion
		
		
		public static readonly long serialVersionUID = 703234555L;		
	} // end class
}  // end namespace
