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
	/// <p>Bit constants for members of ObjChange</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class ObjChangeC : BSerializable
	{
	
		#region Constructors
		
		public ObjChangeC() {
		}		
		
		public ObjChangeC(int @lnObjId, int @lnTStamp, int @lnParam2) {
			this.lnObjIdValue = @lnObjId;
			this.lnTStampValue = @lnTStamp;
			this.lnParam2Value = @lnParam2;
		}		
		
		public ObjChangeC(ObjChangeC rhs)
		{
			this.lnObjIdValue = rhs.lnObjIdValue;
			this.lnTStampValue = rhs.lnTStampValue;
			this.lnParam2Value = rhs.lnParam2Value;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: chgobjid
		/// </summary>
		public int lnObjId
		{
			get
			{
				return lnObjIdValue;
			}
			set
			{
				this.lnObjIdValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: chgtstamp
		/// </summary>
		public int lnTStamp
		{
			get
			{
				return lnTStampValue;
			}
			set
			{
				this.lnTStampValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: chgparam2
		/// </summary>
		public int lnParam2
		{
			get
			{
				return lnParam2Value;
			}
			set
			{
				this.lnParam2Value = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: chgobjid
		/// </summary>
		public const long mbObjId = 1L;

		protected int lnObjIdValue;

		/// <summary>
		/// DB column: chgtstamp
		/// </summary>
		public const long mbTStamp = 2L;

		protected int lnTStampValue;

		/// <summary>
		/// DB column: chgcode
		/// </summary>
		public const long mbCode = 4L;

		/// <summary>
		/// DB column: chgparam
		/// </summary>
		public const long mbParam = 8L;

		/// <summary>
		/// DB column: chgparam2
		/// </summary>
		public const long mbParam2 = 16L;

		protected int lnParam2Value;

		/// <summary>
		/// DB column: chguser
		/// </summary>
		public const long mbUser = 32L;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 63L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1100272528L;		
	} // end class
}  // end namespace
