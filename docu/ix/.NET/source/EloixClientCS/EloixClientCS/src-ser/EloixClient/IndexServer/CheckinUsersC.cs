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
	/// <p>Constants for the function <code>checkinUsers</code>.
	/// </summary>
	/// <remarks>
	/// </p>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: </p>
	/// </remarks>
	public class CheckinUsersC : BSerializable
	{
	
		#region Constructors
		
		public CheckinUsersC() {
		}		
		
		public CheckinUsersC(CheckinUsersC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Checkin no user.
		/// </summary>
		/// <remarks>
		/// Makes sense if you only want to unlock user data.
		/// </remarks>
		public const long bsetNOTHING = 0L;

		/// <summary>
		/// Write without password.
		/// </summary>
		/// <remarks>
		/// Create new user if user ID &lt; 0.
		/// </remarks>
		public const long bsetWRITE = 1L;

		/// <summary>
		/// Updates a users password.
		/// </summary>
		public const long bsetPASSWORD = 2L;

		/// <summary>
		/// Insert a new user with the supplied user ID.
		/// </summary>
		public const long bsetNEW_USER = 4L;

		/// <summary>
		/// Checkin no user.
		/// </summary>
		/// <remarks>
		/// Makes sense if you only want to unlock user data.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckinUsersZ NOTHING = new CheckinUsersZ(0L);

		/// <summary>
		/// Updates a users password.
		/// </summary>
		public readonly static EloixClient.IndexServer.CheckinUsersZ PASSWORD = new CheckinUsersZ(2L);

		/// <summary>
		/// Insert a new user with the supplied user ID.
		/// </summary>
		/// <remarks>
		/// Set the user's password.
		/// </remarks>
		public readonly static EloixClient.IndexServer.CheckinUsersZ NEW_USER = new CheckinUsersZ(5L);

		/// <summary>
		/// Updates or creates a user.
		/// </summary>
		public readonly static EloixClient.IndexServer.CheckinUsersZ WRITE = new CheckinUsersZ(1L);

		/// <summary>
		/// Updates or creates a user and set's the users's password.
		/// </summary>
		public readonly static EloixClient.IndexServer.CheckinUsersZ WRITE_PASSWORD = new CheckinUsersZ(3L);

		#endregion
		
		
		public static readonly long serialVersionUID = 1602486374L;		
	} // end class
}  // end namespace
