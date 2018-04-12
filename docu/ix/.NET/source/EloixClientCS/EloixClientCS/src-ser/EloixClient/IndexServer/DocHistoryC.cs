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
	/// <p>Bit constants for members of DocHistory</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class DocHistoryC : BSerializable
	{
	
		#region Constructors
		
		public DocHistoryC() {
		}		
		
		public DocHistoryC(int @lnComment, int @lnVersion, int @lnDocMD5, int @lnGuid, int @lnTStamp, int @lnTStampSync) {
			this.lnCommentValue = @lnComment;
			this.lnVersionValue = @lnVersion;
			this.lnDocMD5Value = @lnDocMD5;
			this.lnGuidValue = @lnGuid;
			this.lnTStampValue = @lnTStamp;
			this.lnTStampSyncValue = @lnTStampSync;
		}		
		
		public DocHistoryC(DocHistoryC rhs)
		{
			this.lnCommentValue = rhs.lnCommentValue;
			this.lnVersionValue = rhs.lnVersionValue;
			this.lnDocMD5Value = rhs.lnDocMD5Value;
			this.lnGuidValue = rhs.lnGuidValue;
			this.lnTStampValue = rhs.lnTStampValue;
			this.lnTStampSyncValue = rhs.lnTStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: histcomment
		/// </summary>
		public int lnComment
		{
			get
			{
				return lnCommentValue;
			}
			set
			{
				this.lnCommentValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: histversion
		/// </summary>
		public int lnVersion
		{
			get
			{
				return lnVersionValue;
			}
			set
			{
				this.lnVersionValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: docmd5
		/// </summary>
		public int lnDocMD5
		{
			get
			{
				return lnDocMD5Value;
			}
			set
			{
				this.lnDocMD5Value = value;
			}
		}
		
		
		/// <summary>
		/// DB column: docguid
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
		/// DB column: doctstamp
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
		/// DB column: doctstampsync
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
		/// DB column: objectid
		/// </summary>
		public const long mbObjId = 1L;

		/// <summary>
		/// DB column: documentid
		/// </summary>
		public const long mbDocId = 2L;

		/// <summary>
		/// DB column: userid
		/// </summary>
		public const long mbUser = 4L;

		/// <summary>
		/// DB column: createdate
		/// </summary>
		public const long mbCreateDate = 8L;

		/// <summary>
		/// DB column: histcomment
		/// </summary>
		public const long mbComment = 16L;

		protected int lnCommentValue;

		/// <summary>
		/// DB column: histversion
		/// </summary>
		public const long mbVersion = 32L;

		protected int lnVersionValue;

		/// <summary>
		/// DB column: docmd5
		/// </summary>
		public const long mbDocMD5 = 64L;

		protected int lnDocMD5Value;

		/// <summary>
		/// DB column: docguid
		/// </summary>
		public const long mbGuid = 128L;

		protected int lnGuidValue;

		/// <summary>
		/// DB column: doctstamp
		/// </summary>
		public const long mbTStamp = 256L;

		protected int lnTStampValue;

		/// <summary>
		/// DB column: docsignature
		/// </summary>
		public const long mbSigId = 512L;

		/// <summary>
		/// DB column: docstatus
		/// </summary>
		public const long mbStatus = 1024L;

		/// <summary>
		/// DB column: docflags
		/// </summary>
		public const long mbFlags = 2048L;

		/// <summary>
		/// Member bit: The version is deleted at this date.
		/// </summary>
		/// <remarks>
		/// The value is an ELO date format. The
		/// DB column: deletedate
		/// </remarks>
		public const long mbDeleteDate = 4096L;

		/// <summary>
		/// Member bit: Number of valid signatures.
		/// </summary>
		/// <remarks>
		/// DB column: nbofvalidsignatures
		/// </remarks>
		public const long mbNbOfValidSignatures = 8192L;

		/// <summary>
		/// Member bit: The type of this DocHistory makes the difference between attachments and
		/// DB column: doctype
		/// </summary>
		public const long mbType = 16384L;

		/// <summary>
		/// Member bit: Timestamp of this object's last export by the replication.
		/// </summary>
		/// <remarks>
		/// DB column: doctstampsync
		/// </remarks>
		public const long mbTStampSync = 32768L;

		protected int lnTStampSyncValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 65535L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1456349355L;		
	} // end class
}  // end namespace
