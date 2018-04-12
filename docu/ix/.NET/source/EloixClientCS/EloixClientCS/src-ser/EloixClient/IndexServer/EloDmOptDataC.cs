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
	/// <p>Bit constants for members of EloDmOpt</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class EloDmOptDataC : BSerializable
	{
	
		#region Constructors
		
		public EloDmOptDataC() {
		}		
		
		public EloDmOptDataC(int @lnValue, int @lnRemark, int @lnInstanceName) {
			this.lnValueValue = @lnValue;
			this.lnRemarkValue = @lnRemark;
			this.lnInstanceNameValue = @lnInstanceName;
		}		
		
		public EloDmOptDataC(EloDmOptDataC rhs)
		{
			this.lnValueValue = rhs.lnValueValue;
			this.lnRemarkValue = rhs.lnRemarkValue;
			this.lnInstanceNameValue = rhs.lnInstanceNameValue;
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
		
		
		/// <summary>
		/// Column length: DB column: instance
		/// DB column: instancename
		/// </summary>
		public int lnInstanceName
		{
			get
			{
				return lnInstanceNameValue;
			}
			set
			{
				this.lnInstanceNameValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: optno
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
		/// Member bit: DB column: instance
		/// DB column: instancename
		/// </summary>
		public const long mbInstanceName = 8L;

		protected int lnInstanceNameValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 15L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1218961099L;		
	} // end class
}  // end namespace
