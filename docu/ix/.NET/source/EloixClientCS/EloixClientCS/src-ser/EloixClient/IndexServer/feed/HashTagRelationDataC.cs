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
	/// <p>Bit constants for members of HashTagRelation</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class HashTagRelationDataC : BSerializable
	{
	
		#region Constructors
		
		public HashTagRelationDataC() {
		}		
		
		public HashTagRelationDataC(int @lnHashtagGuid, int @lnActionGuid, int @lnTStamp) {
			this.lnHashtagGuidValue = @lnHashtagGuid;
			this.lnActionGuidValue = @lnActionGuid;
			this.lnTStampValue = @lnTStamp;
		}		
		
		public HashTagRelationDataC(HashTagRelationDataC rhs)
		{
			this.lnHashtagGuidValue = rhs.lnHashtagGuidValue;
			this.lnActionGuidValue = rhs.lnActionGuidValue;
			this.lnTStampValue = rhs.lnTStampValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Column length: Guid of the HashTag.
		/// </summary>
		/// <remarks>
		/// DB column: hashtagguid
		/// </remarks>
		public int lnHashtagGuid
		{
			get
			{
				return lnHashtagGuidValue;
			}
			set
			{
				this.lnHashtagGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Guid of the Action in which the HashTag is used.
		/// </summary>
		/// <remarks>
		/// DB column: actionguid
		/// </remarks>
		public int lnActionGuid
		{
			get
			{
				return lnActionGuidValue;
			}
			set
			{
				this.lnActionGuidValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Timestamp for replication.
		/// </summary>
		/// <remarks>
		/// DB column: tstamp
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
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Member bit: Guid of the HashTag.
		/// </summary>
		/// <remarks>
		/// DB column: hashtagguid
		/// </remarks>
		public const long mbHashtagGuid = 1L;

		protected int lnHashtagGuidValue;

		/// <summary>
		/// Member bit: Guid of the Action in which the HashTag is used.
		/// </summary>
		/// <remarks>
		/// DB column: actionguid
		/// </remarks>
		public const long mbActionGuid = 2L;

		protected int lnActionGuidValue;

		/// <summary>
		/// Member bit: Timestamp for replication.
		/// </summary>
		/// <remarks>
		/// DB column: tstamp
		/// </remarks>
		public const long mbTStamp = 4L;

		protected int lnTStampValue;

		/// <summary>
		/// Member bit: Status.
		/// </summary>
		/// <remarks>
		/// DB column: status
		/// </remarks>
		public const long mbStatus = 8L;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 15L;

		#endregion
		
		
		public static readonly long serialVersionUID = 2035445347L;		
	} // end class
}  // end namespace
