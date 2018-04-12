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
	/// <p>Bit constants for members of Note</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class NoteDataC : BSerializable
	{
	
		#region Constructors
		
		public NoteDataC() {
		}		
		
		public NoteDataC(int @lnDesc, int @lnGuid, int @lnTStamp, int @lnAcl, int @lnTStampSync) {
			this.lnDescValue = @lnDesc;
			this.lnGuidValue = @lnGuid;
			this.lnTStampValue = @lnTStamp;
			this.lnAclValue = @lnAcl;
			this.lnTStampSyncValue = @lnTStampSync;
		}		
		
		public NoteDataC(NoteDataC rhs)
		{
			this.lnDescValue = rhs.lnDescValue;
			this.lnGuidValue = rhs.lnGuidValue;
			this.lnTStampValue = rhs.lnTStampValue;
			this.lnAclValue = rhs.lnAclValue;
			this.lnTStampSyncValue = rhs.lnTStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: pidesc
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
		/// DB column: noteguid
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
		/// DB column: notetstamp
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
		/// DB column: noteacl
		/// </summary>
		public int lnAcl
		{
			get
			{
				return lnAclValue;
			}
			set
			{
				this.lnAclValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Timestamp of this object's last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: notetstampsync
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
		/// DB column: noteid
		/// </summary>
		public const long mbId = 1L;

		/// <summary>
		/// DB column: parentid
		/// </summary>
		public const long mbParentId = 2L;

		/// <summary>
		/// DB column: pageno
		/// </summary>
		public const long mbPageNo = 4L;

		/// <summary>
		/// DB column: xpos
		/// </summary>
		public const long mbXPos = 8L;

		/// <summary>
		/// DB column: ypos
		/// </summary>
		public const long mbYPos = 16L;

		/// <summary>
		/// DB column: userid
		/// </summary>
		public const long mbOwnerId = 32L;

		/// <summary>
		/// DB column: notetype
		/// </summary>
		public const long mbType = 64L;

		/// <summary>
		/// DB column: hlock
		/// </summary>
		public const long mbHLock = 128L;

		/// <summary>
		/// DB column: createdate
		/// </summary>
		public const long mbCreateDate = 256L;

		/// <summary>
		/// DB column: pidesc
		/// </summary>
		public const long mbDesc = 512L;

		protected int lnDescValue;

		/// <summary>
		/// DB column: noteguid
		/// </summary>
		public const long mbGuid = 1024L;

		protected int lnGuidValue;

		/// <summary>
		/// DB column: notetstamp
		/// </summary>
		public const long mbTStamp = 2048L;

		protected int lnTStampValue;

		/// <summary>
		/// DB column: notestatus
		/// </summary>
		public const long mbStatus = 4096L;

		/// <summary>
		/// DB column: width
		/// </summary>
		public const long mbWidth = 8192L;

		/// <summary>
		/// DB column: height
		/// </summary>
		public const long mbHeight = 16384L;

		/// <summary>
		/// DB column: noteacl
		/// </summary>
		public const long mbAcl = 32768L;

		protected int lnAclValue;

		/// <summary>
		/// DB column: color
		/// </summary>
		public const long mbColor = 65536L;

		/// <summary>
		/// Member bit: The Note is deleted at this date.
		/// </summary>
		/// <remarks>
		/// ClientInfo determines the Timezone.
		/// DB column: deletedate
		/// </remarks>
		public const long mbDeleteDate = 131072L;

		/// <summary>
		/// Member bit: Timestamp of this object's last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: notetstampsync
		/// </remarks>
		public const long mbTStampSync = 262144L;

		protected int lnTStampSyncValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 524287L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1521483547L;		
	} // end class
}  // end namespace
