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
	/// <p>Constants to select users and groups</p>
	/// </summary>
	public class CheckoutUsersC : BSerializable
	{
	
		#region Constructors
		
		public CheckoutUsersC() {
		}		
		
		public CheckoutUsersC(CheckoutUsersC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Internal use only.
		/// </summary>
		public const long bsetNOTHING = 0L;

		/// <summary>
		/// Internal use only.
		/// </summary>
		public const long bsetBY_IDS = 1L;

		/// <summary>
		/// Internal use only.
		/// </summary>
		public const long bsetALL_USERS = 2L;

		/// <summary>
		/// Internal use only.
		/// </summary>
		public const long bsetALL_GROUPS = 3L;

		/// <summary>
		/// Internal use only.
		/// </summary>
		public const long bsetALL_USERS_AND_GROUPS = 4L;

		/// <summary>
		/// Internal use only.
		/// </summary>
		public const long bsetMEMBERS_OF_GROUP = 5L;

		/// <summary>
		/// Internal use only.
		/// </summary>
		public const long bsetUSERS_OF_GROUP = 6L;

		/// <summary>
		/// Internal use only.
		/// </summary>
		public const long bsetMEMBERS_OF_GROUP_RECURSIVE = 7L;

		/// <summary>
		/// Internal use only.
		/// </summary>
		public const long bsetUSERS_OF_GROUP_RECURSIVE = 8L;

		/// <summary>
		/// Internal use only.
		/// </summary>
		public const long bsetGROUPS_OF_MEMBER = 9L;

		/// <summary>
		/// Internal use only.
		/// </summary>
		public const long bsetGROUPS_OF_MEMBER_RECURSIVE = 10L;

		/// <summary>
		/// Internal use only.
		/// </summary>
		public const long bsetSESSION_INFO = 11L;

		/// <summary>
		/// Internal use only.
		/// </summary>
		public const long bsetSUBADMINS = 12L;

		/// <summary>
		/// Internal use only.
		/// </summary>
		public const long bsetMEMBERS_OF_ORGUNIT = 13L;

		/// <summary>
		/// Internal use only.
		/// </summary>
		public const long bsetUSERS_OF_SUBADMIN = 14L;

		/// <summary>
		/// Internal use only.
		/// </summary>
		public const long bsetSELECT_MASK = 255L;

		/// <summary>
		/// Internal use only.
		/// </summary>
		public const long bsetMY_USERS = 256L;

		/// <summary>
		/// Internal use only.
		/// </summary>
		public const long bsetEFFECTIVE_RIGHTS = 512L;

		/// <summary>
		/// Select no user or group.
		/// </summary>
		/// <remarks>
		/// Makes sense if you only want to lock user data.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ NOTHING = new CheckoutUsersZ(0L);

		/// <summary>
		/// Selects the user objects of the specified users.
		/// </summary>
		/// <remarks>
		/// Returned user data contains effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ BY_IDS = new CheckoutUsersZ(513L);

		/// <summary>
		/// Selects the user objects of the specified users.
		/// </summary>
		/// <remarks>
		/// Returned user data does not contain effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ BY_IDS_RAW = new CheckoutUsersZ(1L);

		/// <summary>
		/// Selects all users.
		/// </summary>
		/// <remarks>
		/// Returned user data contains effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ ALL_USERS = new CheckoutUsersZ(514L);

		/// <summary>
		/// Selects all users.
		/// </summary>
		/// <remarks>
		/// Returned user data does not contain effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ ALL_USERS_RAW = new CheckoutUsersZ(2L);

		/// <summary>
		/// Selects all groups.
		/// </summary>
		/// <remarks>
		/// Returned user data contains effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ ALL_GROUPS = new CheckoutUsersZ(515L);

		/// <summary>
		/// Selects all groups.
		/// </summary>
		/// <remarks>
		/// Returned user data does not contain effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ ALL_GROUPS_RAW = new CheckoutUsersZ(3L);

		/// <summary>
		/// Selects all users an all groups.
		/// </summary>
		/// <remarks>
		/// Returned user data contains effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ ALL_USERS_AND_GROUPS = new CheckoutUsersZ(516L);

		/// <summary>
		/// Selects all users an all groups.
		/// </summary>
		/// <remarks>
		/// Returned user data does not contain effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ ALL_USERS_AND_GROUPS_RAW = new CheckoutUsersZ(4L);

		/// <summary>
		/// Selects all members (users and groups) of the specified group.
		/// </summary>
		/// <remarks>
		/// Does not look
		/// for members of member groups recursively.
		/// Returned user data contains effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ MEMBERS_OF_GROUP = new CheckoutUsersZ(517L);

		/// <summary>
		/// Selects all members (users and groups) of the specified group.
		/// </summary>
		/// <remarks>
		/// Does not look
		/// for members of member groups recursively.
		/// Returned user data does not contain effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ MEMBERS_OF_GROUP_RAW = new CheckoutUsersZ(5L);

		/// <summary>
		/// Selects all users of the specified group.
		/// </summary>
		/// <remarks>
		/// Does not look
		/// for members of member groups recursively.
		/// Returned user data contains effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ USERS_OF_GROUP = new CheckoutUsersZ(518L);

		/// <summary>
		/// Selects all users of the specified group.
		/// </summary>
		/// <remarks>
		/// Does not look
		/// for members of member groups recursively.
		/// Returned user data does not contain effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ USERS_OF_GROUP_RAW = new CheckoutUsersZ(6L);

		/// <summary>
		/// Selects all members (users and groups) of the specified group.
		/// </summary>
		/// <remarks>
		/// Walks recursively
		/// over the group members and selects all members directly or indirectly contained
		/// in the specified group.
		/// Returned user data contains effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ MEMBERS_OF_GROUP_RECURSIVE = new CheckoutUsersZ(519L);

		/// <summary>
		/// Selects all members (users and groups) of the specified group.
		/// </summary>
		/// <remarks>
		/// Walks recursively
		/// over the group members and selects all members directly or indirectly contained
		/// in the specified group.
		/// Returned user data does not contain effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ MEMBERS_OF_GROUP_RECURSIVE_RAW = new CheckoutUsersZ(7L);

		/// <summary>
		/// Selects all users of the specified group.
		/// </summary>
		/// <remarks>
		/// Walks recursively
		/// over the group members and selects all users directly or indirectly contained
		/// in the specified group.
		/// Returned user data contains effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ USERS_OF_GROUP_RECURSIVE = new CheckoutUsersZ(520L);

		/// <summary>
		/// Selects all users of the specified group.
		/// </summary>
		/// <remarks>
		/// Walks recursively
		/// over the group members and selects all users directly or indirectly contained
		/// in the specified group.
		/// Returned user data does not contain effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ USERS_OF_GROUP_RECURSIVE_RAW = new CheckoutUsersZ(8L);

		/// <summary>
		/// Selects all direct groups of a user (or group).
		/// </summary>
		/// <remarks>
		/// Does not look for groups
		/// recursively.
		/// Returned user data contains effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ GROUPS_OF_MEMBER = new CheckoutUsersZ(521L);

		/// <summary>
		/// Selects all direct groups of a user (or group).
		/// </summary>
		/// <remarks>
		/// Does not look for groups
		/// recursively.
		/// Returned user data does not contain effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ GROUPS_OF_MEMBER_RAW = new CheckoutUsersZ(9L);

		/// <summary>
		/// Selects all direct groups of a user (or group).
		/// </summary>
		/// <remarks>
		/// Does not look for groups
		/// recursively. Walks recursively over the users groups.
		/// Returned user data contains effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ GROUPS_OF_MEMBER_RECURSIVE = new CheckoutUsersZ(522L);

		/// <summary>
		/// Selects all direct groups of a user (or group).
		/// </summary>
		/// <remarks>
		/// Does not look for groups
		/// recursively. Walks recursively over the users groups.
		/// Returned user data does not contain effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ GROUPS_OF_MEMBER_RECURSIVE_RAW = new CheckoutUsersZ(10L);

		/// <summary>
		/// Selects all active users.
		/// </summary>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ SESSION_USERS = new CheckoutUsersZ(523L);

		/// <summary>
		/// Selects all active users.
		/// </summary>
		/// <remarks>
		/// Returned user data does not contain effective rights.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ SESSION_USERS_RAW = new CheckoutUsersZ(11L);

		/// <summary>
		/// Selects all sub-administrators.
		/// </summary>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ SUBADMINS = new CheckoutUsersZ(524L);

		/// <summary>
		/// Selects all Members of a given Orgunit
		/// </summary>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ MEMBERS_OF_ORGUNIT = new CheckoutUsersZ(13L);

		/// <summary>
		/// Selects all users and group managed by the given user.
		/// </summary>
		public readonly static EloixClient.IndexServer.CheckoutUsersZ USERS_OF_SUBADMIN = new CheckoutUsersZ(526L);

		#endregion
		
		
		public static readonly long serialVersionUID = 531758278L;		
	} // end class
}  // end namespace
