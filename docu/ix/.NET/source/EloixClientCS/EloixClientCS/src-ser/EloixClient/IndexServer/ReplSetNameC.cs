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
	/// <p>Bit constants for members of ReplSetName</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class ReplSetNameC : BSerializable
	{
	
		#region Constructors
		
		public ReplSetNameC() {
		}		
		
		public ReplSetNameC(int @lnName, int @lnDesc, int @lnTStamp, int @lnTStampSync) {
			this.lnNameValue = @lnName;
			this.lnDescValue = @lnDesc;
			this.lnTStampValue = @lnTStamp;
			this.lnTStampSyncValue = @lnTStampSync;
		}		
		
		public ReplSetNameC(ReplSetNameC rhs)
		{
			this.lnNameValue = rhs.lnNameValue;
			this.lnDescValue = rhs.lnDescValue;
			this.lnTStampValue = rhs.lnTStampValue;
			this.lnTStampSyncValue = rhs.lnTStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: rsname
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
		/// DB column: rsdesc
		/// </summary>
		public int lnDesc
		{
			get
			{
				return lnDescValue;
			}
			set
			{
				this.lnDescValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: rststamp
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
		/// DB column: rststampsync
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
		/// DB column: rsid
		/// </summary>
		public const long mbId = 1L;

		/// <summary>
		/// DB column: rsimage
		/// </summary>
		public const long mbImage = 2L;

		/// <summary>
		/// DB column: rsname
		/// </summary>
		public const long mbName = 4L;

		protected int lnNameValue;

		/// <summary>
		/// DB column: rsdesc
		/// </summary>
		public const long mbDesc = 8L;

		protected int lnDescValue;

		/// <summary>
		/// DB column: rststamp
		/// </summary>
		public const long mbTStamp = 16L;

		protected int lnTStampValue;

		/// <summary>
		/// DB column: rsmobile
		/// </summary>
		public const long mbMobile = 32L;

		/// <summary>
		/// Member bit: Timestamp of this object's last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: rststampsync
		/// </remarks>
		public const long mbTStampSync = 64L;

		protected int lnTStampSyncValue;

		/// <summary>
		/// Member bit: Priority of this replication set.
		/// </summary>
		/// <remarks>
		/// DB column: rsprio
		/// </remarks>
		public const long mbPriority = 128L;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 255L;

		#endregion
		
		
		public static readonly long serialVersionUID = 969246601L;		
	} // end class
}  // end namespace
