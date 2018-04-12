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
	/// <p>Data class containing the user information data for the user logged in to
	/// the Index server.
	/// </summary>
	/// <remarks>
	/// User information includes ID, name, rights, parent, etc.</p>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class UserInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public UserInfo() {
		}		
		
		public UserInfo(String @desc, int @flags, int[] @groupList, int @id, int[] @keylist, String @name, int @parent, String @pwd, EloixClient.IndexServer.SessionInfo[] @sessions, int @type, String[] @userProps, IDictionary<String,String> @ldapProperties, String @guid, String @tStamp, String @lastLoginIso, int @superiorId, int @flags2, int[] @orgUnitIds) {
			this.descValue = @desc;
			this.flagsValue = @flags;
			this.groupListValue = @groupList;
			this.idValue = @id;
			this.keylistValue = @keylist;
			this.nameValue = @name;
			this.parentValue = @parent;
			this.pwdValue = @pwd;
			this.sessionsValue = @sessions;
			this.typeValue = @type;
			this.userPropsValue = @userProps;
			this.ldapPropertiesValue = @ldapProperties;
			this.guidValue = @guid;
			this.tStampValue = @tStamp;
			this.lastLoginIsoValue = @lastLoginIso;
			this.superiorIdValue = @superiorId;
			this.flags2Value = @flags2;
			this.orgUnitIdsValue = @orgUnitIds;
		}		
		
		public UserInfo(UserInfo rhs) : base(rhs)
		{
			this.descValue = rhs.descValue;
			this.flagsValue = rhs.flagsValue;
			this.groupListValue = rhs.groupListValue;
			this.idValue = rhs.idValue;
			this.keylistValue = rhs.keylistValue;
			this.nameValue = rhs.nameValue;
			this.parentValue = rhs.parentValue;
			this.pwdValue = rhs.pwdValue;
			this.sessionsValue = rhs.sessionsValue;
			this.typeValue = rhs.typeValue;
			this.userPropsValue = rhs.userPropsValue;
			this.ldapPropertiesValue = rhs.ldapPropertiesValue;
			this.guidValue = rhs.guidValue;
			this.tStampValue = rhs.tStampValue;
			this.lastLoginIsoValue = rhs.lastLoginIsoValue;
			this.superiorIdValue = rhs.superiorIdValue;
			this.flags2Value = rhs.flags2Value;
			this.orgUnitIdsValue = rhs.orgUnitIdsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// User description.
		/// </summary>
		public String desc
		{
			get
			{
				return descValue;
			}
			set
			{
				this.descValue = value;
			}
		}
		
		
		/// <summary>
		/// User rights.
		/// </summary>
		/// <remarks>
		/// Possible values are combinations of <code>AccessC.FLAG_*</code> constants.
		/// </remarks>
		public int flags
		{
			get
			{
				return flagsValue;
			}
			set
			{
				this.flagsValue = value;
			}
		}
		
		
		/// <summary>
		/// The groups the user is a member of.
		/// </summary>
		/// <remarks>
		/// For Substitues, this list contains the IDs of the substituted users too.
		/// </remarks>
		public int[] groupList
		{
			get
			{
				return groupListValue;
			}
			set
			{
				this.groupListValue = value;
			}
		}
		
		
		/// <summary>
		/// User identifier
		/// </summary>
		public int id
		{
			get
			{
				return idValue;
			}
			set
			{
				this.idValue = value;
			}
		}
		
		
		/// <summary>
		/// User keys.
		/// </summary>
		/// <remarks>
		/// Array of key access rights. Each item is a combination of the
		/// access constants <code>AccessC.LUR_*</code>. The key ID corresponds to the
		/// index of the key access item in the key array. A user owns a key, if at least
		/// one access constant is included in the key item.
		/// Keys do not distinguish between <code>LUR_WRTE</code> and <code>LUR_LIST</code>:
		/// <code>LUR_WRITE</code> implies <code>LUR_LIST</code> and v.v.
		/// </remarks>
		public int[] keylist
		{
			get
			{
				return keylistValue;
			}
			set
			{
				this.keylistValue = value;
			}
		}
		
		
		/// <summary>
		/// User name
		/// </summary>
		public String name
		{
			get
			{
				return nameValue;
			}
			set
			{
				this.nameValue = value;
			}
		}
		
		
		/// <summary>
		/// User ID of the users parent (users adminstrator).
		/// </summary>
		public int parent
		{
			get
			{
				return parentValue;
			}
			set
			{
				this.parentValue = value;
			}
		}
		
		
		/// <summary>
		/// User password
		/// </summary>
		public String pwd
		{
			get
			{
				return pwdValue;
			}
			set
			{
				this.pwdValue = value;
			}
		}
		
		
		/// <summary>
		/// The currently active tickets for the user
		/// </summary>
		public EloixClient.IndexServer.SessionInfo[] sessions
		{
			get
			{
				return sessionsValue;
			}
			set
			{
				this.sessionsValue = value;
			}
		}
		
		
		/// <summary>
		/// User type.
		/// </summary>
		/// <remarks>
		/// <code>TYPE_USER</code> for user, <code>TYPE_GROUP</code> for group.
		/// </remarks>
		public int type
		{
			get
			{
				return typeValue;
			}
			set
			{
				this.typeValue = value;
			}
		}
		
		
		/// <summary>
		/// Reserved (Additional user properties).
		/// </summary>
		/// <remarks>
		/// Index this array with constants named PROP_* in class UserInfoC.
		/// </remarks>
		public String[] userProps
		{
			get
			{
				return userPropsValue;
			}
			set
			{
				this.userPropsValue = value;
			}
		}
		
		
		/// <summary>
		/// Reserved (LDAP user properties).
		/// </summary>
		/// <remarks>
		/// Keys of this map named LDAP_PROP_* in class UserInfoC.
		/// 
		/// Mandatory properties
		/// - For user: objectGUID, distinguishedName, displayName, sAMAccountName und UserPrincipalName
		/// - For group:  objectGUID, distinguishedName, name und sAMAccountName
		/// </remarks>
		public IDictionary<String,String> ldapProperties
		{
			get
			{
				return ldapPropertiesValue;
			}
			set
			{
				this.ldapPropertiesValue = value;
			}
		}
		
		
		/// <summary>
		/// GUID
		/// </summary>
		public String guid
		{
			get
			{
				return guidValue;
			}
			set
			{
				this.guidValue = value;
			}
		}
		
		
		/// <summary>
		/// Timestamp
		/// The format is JJJJ.MM.DD.hh.mm.ss
		/// </summary>
		public String tStamp
		{
			get
			{
				return tStampValue;
			}
			set
			{
				this.tStampValue = value;
			}
		}
		
		
		/// <summary>
		/// Last login timestamp (in timezone UTC).
		/// </summary>
		/// <remarks>
		/// This value is read-only and undefined for groups.
		/// Only the date part is valid.
		/// </remarks>
		public String lastLoginIso
		{
			get
			{
				return lastLoginIsoValue;
			}
			set
			{
				this.lastLoginIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// ID of the users superior.
		/// </summary>
		/// <remarks>
		/// If the user does not have a superior, this value is equal to <code>id</code>.
		/// </remarks>
		public int superiorId
		{
			get
			{
				return superiorIdValue;
			}
			set
			{
				this.superiorIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Second bitset of user rights.
		/// </summary>
		public int flags2
		{
			get
			{
				return flags2Value;
			}
			set
			{
				this.flags2Value = value;
			}
		}
		
		
		/// <summary>
		/// Organisation unit IDs.
		/// </summary>
		/// <remarks>
		/// A user or group can be assigned to at most one organization unit.
		/// But due to its group membership a user or group can actually belong to a list of organization units.
		/// When writing this UserInfo object, only the first organization unit in the array is taken into account.
		/// In order to remove the relationship, set an empty array.
		/// </remarks>
		public int[] orgUnitIds
		{
			get
			{
				return orgUnitIdsValue;
			}
			set
			{
				this.orgUnitIdsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String descValue;

		protected int flagsValue;

		protected int[] groupListValue;

		protected int idValue;

		protected int[] keylistValue;

		protected String nameValue;

		protected int parentValue;

		protected String pwdValue;

		protected EloixClient.IndexServer.SessionInfo[] sessionsValue;

		protected int typeValue;

		protected String[] userPropsValue;

		protected IDictionary<String,String> ldapPropertiesValue;

		protected String guidValue;

		protected String tStampValue;

		protected String lastLoginIsoValue;

		protected int superiorIdValue;

		protected int flags2Value;

		protected int[] orgUnitIdsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1485735592L;		
	} // end class
}  // end namespace
