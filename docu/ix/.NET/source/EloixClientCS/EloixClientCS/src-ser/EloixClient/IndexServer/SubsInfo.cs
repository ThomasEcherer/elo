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
	/// This class contains information about a user that is beeing deputized
	/// by another user.
	/// </summary>
	public class SubsInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public SubsInfo() {
		}		
		
		public SubsInfo(bool @active, bool @inheritRights, int @subsId, String @subsName, int @userId, String @userName) {
			this.activeValue = @active;
			this.inheritRightsValue = @inheritRights;
			this.subsIdValue = @subsId;
			this.subsNameValue = @subsName;
			this.userIdValue = @userId;
			this.userNameValue = @userName;
		}		
		
		public SubsInfo(SubsInfo rhs) : base(rhs)
		{
			this.activeValue = rhs.activeValue;
			this.inheritRightsValue = rhs.inheritRightsValue;
			this.subsIdValue = rhs.subsIdValue;
			this.subsNameValue = rhs.subsNameValue;
			this.userIdValue = rhs.userIdValue;
			this.userNameValue = rhs.userNameValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// The deputy relationship is applied if this member is true.
		/// </summary>
		/// <remarks>
		/// If false,
		/// the deputy does not currently act as the user but may activate the
		/// relationship by themself.
		/// </remarks>
		public bool active
		{
			get
			{
				return activeValue;
			}
			set
			{
				this.activeValue = value;
			}
		}
		
		
		/// <summary>
		/// The deputy inherits the rights of the user if this member is true.
		/// </summary>
		public bool inheritRights
		{
			get
			{
				return inheritRightsValue;
			}
			set
			{
				this.inheritRightsValue = value;
			}
		}
		
		
		/// <summary>
		/// Deputy: the user that deputizes <code>userId</code>.
		/// </summary>
		public int subsId
		{
			get
			{
				return subsIdValue;
			}
			set
			{
				this.subsIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Deputy name.
		/// </summary>
		/// <remarks>
		/// If this member is set <code>subsId</code> is ignored.
		/// </remarks>
		public String subsName
		{
			get
			{
				return subsNameValue;
			}
			set
			{
				this.subsNameValue = value;
			}
		}
		
		
		/// <summary>
		/// The user that is being deputized by <code>subsId</code>
		/// </summary>
		public int userId
		{
			get
			{
				return userIdValue;
			}
			set
			{
				this.userIdValue = value;
			}
		}
		
		
		/// <summary>
		/// User name.
		/// </summary>
		/// <remarks>
		/// If this member is set <code>userId</code> is ignored.
		/// </remarks>
		public String userName
		{
			get
			{
				return userNameValue;
			}
			set
			{
				this.userNameValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected bool activeValue;

		protected bool inheritRightsValue;

		protected int subsIdValue;

		protected String subsNameValue;

		protected int userIdValue;

		protected String userNameValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1910142939L;		
	} // end class
}  // end namespace
