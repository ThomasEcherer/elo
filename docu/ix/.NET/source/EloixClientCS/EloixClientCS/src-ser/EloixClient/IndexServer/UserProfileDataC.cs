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
	/// <p>Bit constants for members of UserProfileData</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class UserProfileDataC : BSerializable
	{
	
		#region Constructors
		
		public UserProfileDataC() {
		}		
		
		public UserProfileDataC(int @lnKey, int @lnValue) {
			this.lnKeyValue = @lnKey;
			this.lnValueValue = @lnValue;
		}		
		
		public UserProfileDataC(UserProfileDataC rhs)
		{
			this.lnKeyValue = rhs.lnKeyValue;
			this.lnValueValue = rhs.lnValueValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: optkey
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
		/// DB column: optvalue
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
		
		/// <summary>
		/// DB column: userid
		/// </summary>
		public const long mbUser = 1L;

		/// <summary>
		/// DB column: optkey
		/// </summary>
		public const long mbKey = 2L;

		protected int lnKeyValue;

		/// <summary>
		/// DB column: optvalue
		/// </summary>
		public const long mbValue = 4L;

		protected int lnValueValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 7L;

		#endregion
		
		
		public static readonly long serialVersionUID = 466121473L;		
	} // end class
}  // end namespace
