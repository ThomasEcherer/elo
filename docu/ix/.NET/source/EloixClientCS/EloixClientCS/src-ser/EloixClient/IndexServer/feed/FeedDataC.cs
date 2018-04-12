//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	/// <summary>
	/// <p>Bit constants for members of Feed</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class FeedDataC : BSerializable
	{
	
		#region Constructors
		
		public FeedDataC() {
		}		
		
		public FeedDataC(int @lnGuid, int @lnCreateDateIso, int @lnTStamp, int @lnObjGuid, int @lnTStampSync) {
			this.lnGuidValue = @lnGuid;
			this.lnCreateDateIsoValue = @lnCreateDateIso;
			this.lnTStampValue = @lnTStamp;
			this.lnObjGuidValue = @lnObjGuid;
			this.lnTStampSyncValue = @lnTStampSync;
		}		
		
		public FeedDataC(FeedDataC rhs)
		{
			this.lnGuidValue = rhs.lnGuidValue;
			this.lnCreateDateIsoValue = rhs.lnCreateDateIsoValue;
			this.lnTStampValue = rhs.lnTStampValue;
			this.lnObjGuidValue = rhs.lnObjGuidValue;
			this.lnTStampSyncValue = rhs.lnTStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Column length: Feed GUID.
		/// </summary>
		/// <remarks>
		/// DB column: feedguid
		/// </remarks>
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
		/// Column length: Create date.
		/// </summary>
		/// <remarks>
		/// DB column: createdateiso
		/// </remarks>
		public int lnCreateDateIso
		{
			get
			{
				return lnCreateDateIsoValue;
			}
			set
			{
				this.lnCreateDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Time stamp.
		/// </summary>
		/// <remarks>
		/// DB column: feedtstamp
		/// </remarks>
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
		/// Column length: GUID of the associated Sord object.
		/// </summary>
		/// <remarks>
		/// DB column: objguid
		/// </remarks>
		public int lnObjGuid
		{
			get
			{
				return lnObjGuidValue;
			}
			set
			{
				this.lnObjGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Timestamp of this object's last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: feedtstampsync
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
		/// Member bit: Feed GUID.
		/// </summary>
		/// <remarks>
		/// DB column: feedguid
		/// </remarks>
		public const long mbGuid = 1L;

		protected int lnGuidValue;

		/// <summary>
		/// Member bit: Create date.
		/// </summary>
		/// <remarks>
		/// DB column: createdateiso
		/// </remarks>
		public const long mbCreateDateIso = 2L;

		protected int lnCreateDateIsoValue;

		/// <summary>
		/// Member bit: Time stamp.
		/// </summary>
		/// <remarks>
		/// DB column: feedtstamp
		/// </remarks>
		public const long mbTStamp = 4L;

		protected int lnTStampValue;

		/// <summary>
		/// Member bit: GUID of the associated Sord object.
		/// </summary>
		/// <remarks>
		/// DB column: objguid
		/// </remarks>
		public const long mbObjGuid = 8L;

		protected int lnObjGuidValue;

		/// <summary>
		/// Member bit: Timestamp of this object's last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: feedtstampsync
		/// </remarks>
		public const long mbTStampSync = 16L;

		protected int lnTStampSyncValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 31L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1837685365L;		
	} // end class
}  // end namespace
