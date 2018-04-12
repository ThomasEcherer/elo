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
	/// <p>Bit constants for members of EloIxOpt</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class EloIxOptDataC : BSerializable
	{
	
		#region Constructors
		
		public EloIxOptDataC() {
		}		
		
		public EloIxOptDataC(int @lnName, int @lnIxId, int @lnValue) {
			this.lnNameValue = @lnName;
			this.lnIxIdValue = @lnIxId;
			this.lnValueValue = @lnValue;
		}		
		
		public EloIxOptDataC(EloIxOptDataC rhs)
		{
			this.lnNameValue = rhs.lnNameValue;
			this.lnIxIdValue = rhs.lnIxIdValue;
			this.lnValueValue = rhs.lnValueValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: optname
		/// </summary>
		public int lnName
		{
			get
			{
				return lnNameValue;
			}
			set
			{
				this.lnNameValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: ixid
		/// </summary>
		public int lnIxId
		{
			get
			{
				return lnIxIdValue;
			}
			set
			{
				this.lnIxIdValue = value;
			}
		}
		
		
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
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: optname
		/// </summary>
		public const long mbName = 1L;

		protected int lnNameValue;

		/// <summary>
		/// DB column: ixid
		/// </summary>
		public const long mbIxId = 2L;

		protected int lnIxIdValue;

		/// <summary>
		/// DB column: optval
		/// </summary>
		public const long mbValue = 4L;

		protected int lnValueValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 7L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1223860309L;		
	} // end class
}  // end namespace
