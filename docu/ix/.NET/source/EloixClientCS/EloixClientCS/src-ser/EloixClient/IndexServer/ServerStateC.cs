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
	/// <p>Bit constants for members of ServerState</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class ServerStateC : BSerializable
	{
	
		#region Constructors
		
		public ServerStateC() {
		}		
		
		public ServerStateC(int @lnAction) {
			this.lnActionValue = @lnAction;
		}		
		
		public ServerStateC(ServerStateC rhs)
		{
			this.lnActionValue = rhs.lnActionValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: action
		/// </summary>
		public int lnAction
		{
			get
			{
				return lnActionValue;
			}
			set
			{
				this.lnActionValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: actionid
		/// </summary>
		public const long mbActionId = 1L;

		/// <summary>
		/// DB column: subkey
		/// </summary>
		public const long mbSubKey = 2L;

		/// <summary>
		/// DB column: action
		/// </summary>
		public const long mbAction = 4L;

		protected int lnActionValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 7L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1862501863L;		
	} // end class
}  // end namespace
