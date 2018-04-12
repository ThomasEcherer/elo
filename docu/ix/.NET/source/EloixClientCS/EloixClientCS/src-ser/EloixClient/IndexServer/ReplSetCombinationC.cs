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
	/// <p>Bit constants for members of ReplSetCombination</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class ReplSetCombinationC : BSerializable
	{
	
		#region Constructors
		
		public ReplSetCombinationC() {
		}		
		
		public ReplSetCombinationC(int @lnCombiGuid, int @lnCombi) {
			this.lnCombiGuidValue = @lnCombiGuid;
			this.lnCombiValue = @lnCombi;
		}		
		
		public ReplSetCombinationC(ReplSetCombinationC rhs)
		{
			this.lnCombiGuidValue = rhs.lnCombiGuidValue;
			this.lnCombiValue = rhs.lnCombiValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: combiid
		/// </summary>
		public int lnCombiGuid
		{
			get
			{
				return lnCombiGuidValue;
			}
			set
			{
				this.lnCombiGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: dw
		/// </summary>
		public int lnCombi
		{
			get
			{
				return lnCombiValue;
			}
			set
			{
				this.lnCombiValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: combiid
		/// </summary>
		public const long mbCombiGuid = 1L;

		protected int lnCombiGuidValue;

		/// <summary>
		/// DB column: dw
		/// </summary>
		public const long mbCombi = 2L;

		protected int lnCombiValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 3L;

		#endregion
		
		
		public static readonly long serialVersionUID = 897151349L;		
	} // end class
}  // end namespace
