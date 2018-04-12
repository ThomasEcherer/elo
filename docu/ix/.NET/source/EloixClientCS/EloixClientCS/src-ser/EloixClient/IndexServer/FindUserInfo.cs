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
	/// This class describes the search criteria for {@link IXServicePortIF#findFirstUsers}.
	/// </summary>
	/// <remarks>
	/// The wildcards defined by {@link SessionOptionsC#DB_WILDCARDS} can be used for {@link #name}, {@link #desc}, {@link #property}, and {@link #ldapProperty}.
	/// 
	/// Members {@link #name}, {@link #desc}, {@link #property}, and {@link #ldapProperty} are combined by OR. Other members are combinded by AND.
	/// </remarks>
	public class FindUserInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindUserInfo() {
		}		
		
		public FindUserInfo(String @name, String @desc, EloixClient.IndexServer.KeyValue @property, EloixClient.IndexServer.KeyValue @ldapProperty, bool @onlyUsers, bool @onlyGroups, bool @returnUserInfoMap, String[] @userIds, EloixClient.IndexServer.CheckoutUsersZ @checkoutUsersZ, int @hasFlags, int @hasNotFlags, int @hasFlags2, int @hasNotFlags2) {
			this.nameValue = @name;
			this.descValue = @desc;
			this.propertyValue = @property;
			this.ldapPropertyValue = @ldapProperty;
			this.onlyUsersValue = @onlyUsers;
			this.onlyGroupsValue = @onlyGroups;
			this.returnUserInfoMapValue = @returnUserInfoMap;
			this.userIdsValue = @userIds;
			this.checkoutUsersZValue = @checkoutUsersZ;
			this.hasFlagsValue = @hasFlags;
			this.hasNotFlagsValue = @hasNotFlags;
			this.hasFlags2Value = @hasFlags2;
			this.hasNotFlags2Value = @hasNotFlags2;
		}		
		
		public FindUserInfo(FindUserInfo rhs) : base(rhs)
		{
			this.nameValue = rhs.nameValue;
			this.descValue = rhs.descValue;
			this.propertyValue = rhs.propertyValue;
			this.ldapPropertyValue = rhs.ldapPropertyValue;
			this.onlyUsersValue = rhs.onlyUsersValue;
			this.onlyGroupsValue = rhs.onlyGroupsValue;
			this.returnUserInfoMapValue = rhs.returnUserInfoMapValue;
			this.userIdsValue = rhs.userIdsValue;
			this.checkoutUsersZValue = rhs.checkoutUsersZValue;
			this.hasFlagsValue = rhs.hasFlagsValue;
			this.hasNotFlagsValue = rhs.hasNotFlagsValue;
			this.hasFlags2Value = rhs.hasFlags2Value;
			this.hasNotFlags2Value = rhs.hasNotFlags2Value;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Find by user name.
		/// </summary>
		/// <remarks>
		/// Search over {@link UserInfo#name}.
		/// </remarks>
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
		/// Find by user description.
		/// </summary>
		/// <remarks>
		/// Search over {@link UserInfo#desc}.
		/// </remarks>
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
		/// Find by an user property.
		/// </summary>
		/// <remarks>
		/// Search over all {@link UserInfo#userProps}. The key element in property is the index in the array {@link UserInfo#userProps}.
		/// <p>
		/// Example:
		/// <pre><code class="example">
		/// FindUserInfo findInfo = new FindUserInfo();
		/// KeyValue property = new KeyValue();
		/// property.setKey(Integer.toString(UserInfoC.PROP_NAME_EMAIL));
		/// property.setValue("maria.fritz@alpha.com");
		/// </code></pre>
		/// </p>
		/// </remarks>
		public EloixClient.IndexServer.KeyValue property
		{
			get
			{
				return propertyValue;
			}
			set
			{
				this.propertyValue = value;
			}
		}
		
		
		/// <summary>
		/// Find by a LDAP property.
		/// </summary>
		/// <remarks>
		/// Search over all {@link UserInfo#ldapProperties}. The key element in property is the key in the map {@link UserInfo#ldapProperties}.
		/// </remarks>
		public EloixClient.IndexServer.KeyValue ldapProperty
		{
			get
			{
				return ldapPropertyValue;
			}
			set
			{
				this.ldapPropertyValue = value;
			}
		}
		
		
		/// <summary>
		/// Search for users only.
		/// </summary>
		public bool onlyUsers
		{
			get
			{
				return onlyUsersValue;
			}
			set
			{
				this.onlyUsersValue = value;
			}
		}
		
		
		/// <summary>
		/// Search for groups only.
		/// </summary>
		public bool onlyGroups
		{
			get
			{
				return onlyGroupsValue;
			}
			set
			{
				this.onlyGroupsValue = value;
			}
		}
		
		
		/// <summary>
		/// Return entire information about each user.
		/// </summary>
		/// <remarks>
		/// If true, {@link UserInfo} objects are returned in {@link FindResult#userInfos}.
		/// If false, {@link UserName} objects are returned in {@link FindResult#userNames}.
		/// </remarks>
		public bool returnUserInfoMap
		{
			get
			{
				return returnUserInfoMapValue;
			}
			set
			{
				this.returnUserInfoMapValue = value;
			}
		}
		
		
		/// <summary>
		/// User IDs related to {@link #checkoutUsersZ}.
		/// </summary>
		public String[] userIds
		{
			get
			{
				return userIdsValue;
			}
			set
			{
				this.userIdsValue = value;
			}
		}
		
		
		/// <summary>
		/// Filter users as in {@link IXServicePortIF#checkoutUsers(ClientInfo, String[], CheckoutUsersZ, LockZ)}.
		/// </summary>
		public EloixClient.IndexServer.CheckoutUsersZ checkoutUsersZ
		{
			get
			{
				return checkoutUsersZValue;
			}
			set
			{
				this.checkoutUsersZValue = value;
			}
		}
		
		
		/// <summary>
		/// Select only users that have all of this {@link UserInfo#flags} set.
		/// </summary>
		/// <remarks>
		/// A value of 0 is ignored.
		/// The selected users are found by testing (UserInfo#flags & hasFlags) == hasFlags.
		/// </remarks>
		public int hasFlags
		{
			get
			{
				return hasFlagsValue;
			}
			set
			{
				this.hasFlagsValue = value;
			}
		}
		
		
		/// <summary>
		/// Select only users that have non this {@link UserInfo#flags} set.
		/// </summary>
		/// <remarks>
		/// The selected users are found by testing (UserInfo#flags & hasNotFlags) == 0.
		/// </remarks>
		public int hasNotFlags
		{
			get
			{
				return hasNotFlagsValue;
			}
			set
			{
				this.hasNotFlagsValue = value;
			}
		}
		
		
		/// <summary>
		/// Select only users that have all of this {@link UserInfo#flags2} set.
		/// </summary>
		/// <remarks>
		/// A value of 0 is ignored.
		/// The selected users are found by testing (UserInfo#flags2 & hasFlags2) == hasFlags2.
		/// </remarks>
		public int hasFlags2
		{
			get
			{
				return hasFlags2Value;
			}
			set
			{
				this.hasFlags2Value = value;
			}
		}
		
		
		/// <summary>
		/// Select only users that have none this {@link UserInfo#flags2} set.
		/// </summary>
		/// <remarks>
		/// The selected users are found by testing (UserInfo#flags2 & hasNotFlags2) == 0.
		/// </remarks>
		public int hasNotFlags2
		{
			get
			{
				return hasNotFlags2Value;
			}
			set
			{
				this.hasNotFlags2Value = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String nameValue;

		protected String descValue;

		protected EloixClient.IndexServer.KeyValue propertyValue;

		protected EloixClient.IndexServer.KeyValue ldapPropertyValue;

		protected bool onlyUsersValue;

		protected bool onlyGroupsValue;

		protected bool returnUserInfoMapValue;

		protected String[] userIdsValue;

		protected EloixClient.IndexServer.CheckoutUsersZ checkoutUsersZValue;

		protected int hasFlagsValue;

		protected int hasNotFlagsValue;

		protected int hasFlags2Value;

		protected int hasNotFlags2Value;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1847547446L;		
	} // end class
}  // end namespace
