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
	/// <p>Bit constants for members of EloIxOpt_old</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class EloIxOpt_oldC : BSerializable
	{
	
		#region Constructors
		
		public EloIxOpt_oldC() {
		}		
		
		public EloIxOpt_oldC(int @lnOptVal, int @lnRemark) {
			this.lnOptValValue = @lnOptVal;
			this.lnRemarkValue = @lnRemark;
		}		
		
		public EloIxOpt_oldC(EloIxOpt_oldC rhs)
		{
			this.lnOptValValue = rhs.lnOptValValue;
			this.lnRemarkValue = rhs.lnRemarkValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: optval
		/// </summary>
		public int lnOptVal
		{
			get
			{
				return lnOptValValue;
			}
			set
			{
				this.lnOptValValue = value;
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
		/// DB column: optno
		/// </summary>
		public const long mbOptNo = 1L;

		/// <summary>
		/// DB column: optval
		/// </summary>
		public const long mbOptVal = 2L;

		protected int lnOptValValue;

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
		
		
		public static readonly long serialVersionUID = 1148546611L;		
	} // end class
}  // end namespace
