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
	/// <p>Bit constants for members of ColorData</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class ColorDataInternC : BSerializable
	{
	
		#region Constructors
		
		public ColorDataInternC() {
		}		
		
		public ColorDataInternC(int @lnName, int @lnGuid, int @lnTStamp, int @lnTStampSync) {
			this.lnNameValue = @lnName;
			this.lnGuidValue = @lnGuid;
			this.lnTStampValue = @lnTStamp;
			this.lnTStampSyncValue = @lnTStampSync;
		}		
		
		public ColorDataInternC(ColorDataInternC rhs)
		{
			this.lnNameValue = rhs.lnNameValue;
			this.lnGuidValue = rhs.lnGuidValue;
			this.lnTStampValue = rhs.lnTStampValue;
			this.lnTStampSyncValue = rhs.lnTStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: colorname
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
		/// Column length: GUID
		/// DB column: colorguid
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
		
		
		/// <summary>
		/// Column length: TStamp
		/// DB column: colortstamp
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
		/// Column length: Timestamp of this object's last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: colortstampsync
		/// </remarks>
		public int lnTStampSync
		{
			get
			{
				return lnTStampSyncValue;
			}
			set
			{
				this.lnTStampSyncValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: colorno
		/// </summary>
		public const long mbId = 1L;

		/// <summary>
		/// DB column: colorname
		/// </summary>
		public const long mbName = 2L;

		protected int lnNameValue;

		/// <summary>
		/// DB column: colorid
		/// </summary>
		public const long mbRGB = 4L;

		/// <summary>
		/// DB column: colorstatus
		/// </summary>
		public const long mbStatus = 8L;

		/// <summary>
		/// Member bit: GUID
		/// DB column: colorguid
		/// </summary>
		public const long mbGuid = 16L;

		protected int lnGuidValue;

		/// <summary>
		/// Member bit: TStamp
		/// DB column: colortstamp
		/// </summary>
		public const long mbTStamp = 32L;

		protected int lnTStampValue;

		/// <summary>
		/// Member bit: Timestamp of this object's last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: colortstampsync
		/// </remarks>
		public const long mbTStampSync = 64L;

		protected int lnTStampSyncValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 127L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1208511866L;		
	} // end class
}  // end namespace
