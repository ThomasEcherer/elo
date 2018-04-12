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
	/// <p>Bit constants for members of KeywordList</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class KeywordListC : BSerializable
	{
	
		#region Constructors
		
		public KeywordListC() {
		}		
		
		public KeywordListC(int @lnId, int @lnGuid, int @lnTStamp, int @lnTStampSync) {
			this.lnIdValue = @lnId;
			this.lnGuidValue = @lnGuid;
			this.lnTStampValue = @lnTStamp;
			this.lnTStampSyncValue = @lnTStampSync;
		}		
		
		public KeywordListC(KeywordListC rhs)
		{
			this.lnIdValue = rhs.lnIdValue;
			this.lnGuidValue = rhs.lnGuidValue;
			this.lnTStampValue = rhs.lnTStampValue;
			this.lnTStampSyncValue = rhs.lnTStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Column length: ID
		/// DB column: swlgroupid
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
		/// Column length: GUID
		/// DB column: swlguid
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
		/// Column length: Last modified, ISO - UTC
		/// DB column: swltstamp
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
		/// DB column: swltstampsync
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
		/// DB column: swlstatus
		/// </summary>
		public const long mbStatus = 1L;

		/// <summary>
		/// Member bit: ID
		/// DB column: swlgroupid
		/// </summary>
		public const long mbId = 2L;

		protected int lnIdValue;

		/// <summary>
		/// Member bit: GUID
		/// DB column: swlguid
		/// </summary>
		public const long mbGuid = 4L;

		protected int lnGuidValue;

		/// <summary>
		/// Member bit: Last modified, ISO - UTC
		/// DB column: swltstamp
		/// </summary>
		public const long mbTStamp = 8L;

		protected int lnTStampValue;

		/// <summary>
		/// Member bit: ID of the user that has written the keyword list at last.
		/// </summary>
		/// <remarks>
		/// DB column: swluser
		/// </remarks>
		public const long mbUserId = 16L;

		/// <summary>
		/// Member bit: ID of the user who holds a lock on the keyword list.
		/// </summary>
		/// <remarks>
		/// DB column: swllock
		/// </remarks>
		public const long mbLockId = 32L;

		/// <summary>
		/// Member bit: Timestamp of this object's last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: swltstampsync
		/// </remarks>
		public const long mbTStampSync = 64L;

		protected int lnTStampSyncValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 127L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1333073168L;		
	} // end class
}  // end namespace
