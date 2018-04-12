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
	/// <p>Bit constants for members of PhysDel</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class PhysDelDataC : BSerializable
	{
	
		#region Constructors
		
		public PhysDelDataC() {
		}		
		
		public PhysDelDataC(int @lnGuid, int @lnTStamp, int @lnTStampSync) {
			this.lnGuidValue = @lnGuid;
			this.lnTStampValue = @lnTStamp;
			this.lnTStampSyncValue = @lnTStampSync;
		}		
		
		public PhysDelDataC(PhysDelDataC rhs)
		{
			this.lnGuidValue = rhs.lnGuidValue;
			this.lnTStampValue = rhs.lnTStampValue;
			this.lnTStampSyncValue = rhs.lnTStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: pdguid
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
		/// DB column: pdtstamp
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
		/// DB column: tstampsync
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
		/// DB column: pdguid
		/// </summary>
		public const long mbGuid = 1L;

		protected int lnGuidValue;

		/// <summary>
		/// DB column: pdtype
		/// </summary>
		public const long mbType = 2L;

		/// <summary>
		/// DB column: pdtstamp
		/// </summary>
		public const long mbTStamp = 4L;

		protected int lnTStampValue;

		/// <summary>
		/// Member bit: Timestamp of this object's last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: tstampsync
		/// </remarks>
		public const long mbTStampSync = 8L;

		protected int lnTStampSyncValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 15L;

		#endregion
		
		
		public static readonly long serialVersionUID = 448931954L;		
	} // end class
}  // end namespace
