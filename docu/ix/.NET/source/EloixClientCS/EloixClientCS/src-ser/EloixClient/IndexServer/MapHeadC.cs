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
	/// <p>Bit constants for members of MapHead</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class MapHeadC : BSerializable
	{
	
		#region Constructors
		
		public MapHeadC() {
		}		
		
		public MapHeadC(int @lnId, int @lnTStamp, int @lnGuid) {
			this.lnIdValue = @lnId;
			this.lnTStampValue = @lnTStamp;
			this.lnGuidValue = @lnGuid;
		}		
		
		public MapHeadC(MapHeadC rhs)
		{
			this.lnIdValue = rhs.lnIdValue;
			this.lnTStampValue = rhs.lnTStampValue;
			this.lnGuidValue = rhs.lnGuidValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: mapid
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
		/// DB column: maptstamp
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
		/// DB column: mapguid
		/// </summary>
		public int lnGuid
		{
			get
			{
				return lnGuidValue;
			}
			set
			{
				this.lnGuidValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: mapid
		/// </summary>
		public const long mbId = 1L;

		protected int lnIdValue;

		/// <summary>
		/// DB column: maplockid
		/// </summary>
		public const long mbLockId = 2L;

		/// <summary>
		/// DB column: mapobjid
		/// </summary>
		public const long mbObjId = 4L;

		/// <summary>
		/// DB column: maptstamp
		/// </summary>
		public const long mbTStamp = 8L;

		protected int lnTStampValue;

		/// <summary>
		/// DB column: mapguid
		/// </summary>
		public const long mbGuid = 16L;

		protected int lnGuidValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 31L;

		#endregion
		
		
		public static readonly long serialVersionUID = 812078539L;		
	} // end class
}  // end namespace
