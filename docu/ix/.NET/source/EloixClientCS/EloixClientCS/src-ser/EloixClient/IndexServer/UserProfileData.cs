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
	/// Internal class.
	/// </summary>
	public class UserProfileData : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public UserProfileData() {
		}		
		
		public UserProfileData(int @user, String @key, String @value) {
			this.userValue = @user;
			this.keyValue = @key;
			this.valueValue = @value;
		}		
		
		public UserProfileData(UserProfileData rhs) : base(rhs)
		{
			this.userValue = rhs.userValue;
			this.keyValue = rhs.keyValue;
			this.valueValue = rhs.valueValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// User ID.
		/// </summary>
		/// <remarks>
		/// DB column: userid
		/// </remarks>
		public int user
		{
			get
			{
				return userValue;
			}
			set
			{
				this.userValue = value;
				setChangedMember(UserProfileDataC.mbUser);
			}
		}
		
		
		/// <summary>
		/// Option key.
		/// </summary>
		/// <remarks>
		/// DB column: optkey
		/// </remarks>
		public String key
		{
			get
			{
				return keyValue;
			}
			set
			{
				this.keyValue = value;
				setChangedMember(UserProfileDataC.mbKey);
			}
		}
		
		
		/// <summary>
		/// Option value.
		/// </summary>
		/// <remarks>
		/// DB column: optvalue
		/// </remarks>
		public String value
		{
			get
			{
				return valueValue;
			}
			set
			{
				this.valueValue = value;
				setChangedMember(UserProfileDataC.mbValue);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int userValue;

		protected String keyValue;

		protected String valueValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2015395180L;		
	} // end class
}  // end namespace
