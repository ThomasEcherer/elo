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
	/// <p>Bit constants for members of Relation</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class RelationC : BSerializable
	{
	
		#region Constructors
		
		public RelationC() {
		}		
		
		public RelationC(int @lnTStamp, int @lnGuid, int @lnTStampSync) {
			this.lnTStampValue = @lnTStamp;
			this.lnGuidValue = @lnGuid;
			this.lnTStampSyncValue = @lnTStampSync;
		}		
		
		public RelationC(RelationC rhs)
		{
			this.lnTStampValue = rhs.lnTStampValue;
			this.lnGuidValue = rhs.lnGuidValue;
			this.lnTStampSyncValue = rhs.lnTStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: reltstamp
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
		/// Column length: GUID
		/// DB column: relguid
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
		/// Column length: Timestamp of this object's last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: reltstampsync
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
		/// DB column: parentid
		/// </summary>
		public const long mbParentId = 1L;

		/// <summary>
		/// DB column: objectid
		/// </summary>
		public const long mbObjId = 2L;

		/// <summary>
		/// DB column: ordinal
		/// </summary>
		public const long mbOrdinal = 4L;

		/// <summary>
		/// DB column: relstatus
		/// </summary>
		public const long mbStatus = 8L;

		/// <summary>
		/// DB column: reltstamp
		/// </summary>
		public const long mbTStamp = 16L;

		protected int lnTStampValue;

		/// <summary>
		/// Member bit: GUID
		/// DB column: relguid
		/// </summary>
		public const long mbGuid = 32L;

		protected int lnGuidValue;

		/// <summary>
		/// Member bit: The Relation is deleted at this date.
		/// </summary>
		/// <remarks>
		/// ClientInfo determines the Timezone.
		/// DB column: reldeletedate
		/// </remarks>
		public const long mbDeleteDate = 64L;

		/// <summary>
		/// Member bit: This Relation represents the main relation of an object, if this value is
		/// DB column: relmain
		/// </summary>
		public const long mbRelMain = 128L;

		/// <summary>
		/// Member bit: Timestamp of this object's last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: reltstampsync
		/// </remarks>
		public const long mbTStampSync = 256L;

		protected int lnTStampSyncValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 511L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1203469035L;		
	} // end class
}  // end namespace
