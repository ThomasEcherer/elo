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
	/// <p>Bit constants for members of SordLink</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class ObjLinkC : BSerializable
	{
	
		#region Constructors
		
		public ObjLinkC() {
		}		
		
		public ObjLinkC(int @lnParentId, int @lnId, int @lnLinkId, int @lnTStamp) {
			this.lnParentIdValue = @lnParentId;
			this.lnIdValue = @lnId;
			this.lnLinkIdValue = @lnLinkId;
			this.lnTStampValue = @lnTStamp;
		}		
		
		public ObjLinkC(ObjLinkC rhs)
		{
			this.lnParentIdValue = rhs.lnParentIdValue;
			this.lnIdValue = rhs.lnIdValue;
			this.lnLinkIdValue = rhs.lnLinkIdValue;
			this.lnTStampValue = rhs.lnTStampValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: objguidparent
		/// </summary>
		public int lnParentId
		{
			get
			{
				return lnParentIdValue;
			}
			set
			{
				this.lnParentIdValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: objguidtarget
		/// </summary>
		public int lnId
		{
			get
			{
				return lnIdValue;
			}
			set
			{
				this.lnIdValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: linkguid
		/// </summary>
		public int lnLinkId
		{
			get
			{
				return lnLinkIdValue;
			}
			set
			{
				this.lnLinkIdValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: linktstamp
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
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: objguidparent
		/// </summary>
		public const long mbParentId = 1L;

		protected int lnParentIdValue;

		/// <summary>
		/// DB column: objguidtarget
		/// </summary>
		public const long mbId = 2L;

		protected int lnIdValue;

		/// <summary>
		/// DB column: linkguid
		/// </summary>
		public const long mbLinkId = 4L;

		protected int lnLinkIdValue;

		/// <summary>
		/// DB column: linktstamp
		/// </summary>
		public const long mbTStamp = 8L;

		protected int lnTStampValue;

		/// <summary>
		/// DB column: linkflags
		/// </summary>
		public const long mbFlags = 16L;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 31L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1015668161L;		
	} // end class
}  // end namespace
