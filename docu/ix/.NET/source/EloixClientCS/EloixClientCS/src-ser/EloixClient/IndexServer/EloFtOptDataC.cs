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
	/// <p>Bit constants for members of EloFtOpt</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class EloFtOptDataC : BSerializable
	{
	
		#region Constructors
		
		public EloFtOptDataC() {
		}		
		
		public EloFtOptDataC(int @lnValue, int @lnRemark) {
			this.lnValueValue = @lnValue;
			this.lnRemarkValue = @lnRemark;
		}		
		
		public EloFtOptDataC(EloFtOptDataC rhs)
		{
			this.lnValueValue = rhs.lnValueValue;
			this.lnRemarkValue = rhs.lnRemarkValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: optval
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
		
		
		/// <summary>
		/// DB column: remark
		/// </summary>
		public int lnRemark
		{
			get
			{
				return lnRemarkValue;
			}
			set
			{
				this.lnRemarkValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: optid
		/// </summary>
		public const long mbId = 1L;

		/// <summary>
		/// DB column: optval
		/// </summary>
		public const long mbValue = 2L;

		protected int lnValueValue;

		/// <summary>
		/// DB column: remark
		/// </summary>
		public const long mbRemark = 4L;

		protected int lnRemarkValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 7L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1220982870L;		
	} // end class
}  // end namespace
