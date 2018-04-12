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
	/// <p>Bit constants for members of PublicDownload</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class PublicDownloadDataC : BSerializable
	{
	
		#region Constructors
		
		public PublicDownloadDataC() {
		}		
		
		public PublicDownloadDataC(int @lnId, int @lnTimeStamp, int @lnExpiration, int @lnFileName, int @lnAttachmentCode) {
			this.lnIdValue = @lnId;
			this.lnTimeStampValue = @lnTimeStamp;
			this.lnExpirationValue = @lnExpiration;
			this.lnFileNameValue = @lnFileName;
			this.lnAttachmentCodeValue = @lnAttachmentCode;
		}		
		
		public PublicDownloadDataC(PublicDownloadDataC rhs)
		{
			this.lnIdValue = rhs.lnIdValue;
			this.lnTimeStampValue = rhs.lnTimeStampValue;
			this.lnExpirationValue = rhs.lnExpirationValue;
			this.lnFileNameValue = rhs.lnFileNameValue;
			this.lnAttachmentCodeValue = rhs.lnAttachmentCodeValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: guid
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
		/// DB column: tstamp
		/// </summary>
		public int lnTimeStamp
		{
			get
			{
				return lnTimeStampValue;
			}
			set
			{
				this.lnTimeStampValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: expiration
		/// </summary>
		public int lnExpiration
		{
			get
			{
				return lnExpirationValue;
			}
			set
			{
				this.lnExpirationValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: The fileName in the download url.
		/// </summary>
		/// <remarks>
		/// It is readonly.
		/// DB column: fname
		/// </remarks>
		public int lnFileName
		{
			get
			{
				return lnFileNameValue;
			}
			set
			{
				this.lnFileNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Indicates whether the download is inline or as attachment.
		/// </summary>
		/// <remarks>
		/// DB column: acode
		/// </remarks>
		public int lnAttachmentCode
		{
			get
			{
				return lnAttachmentCodeValue;
			}
			set
			{
				this.lnAttachmentCodeValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: guid
		/// </summary>
		public const long mbId = 1L;

		protected int lnIdValue;

		/// <summary>
		/// DB column: tstamp
		/// </summary>
		public const long mbTimeStamp = 2L;

		protected int lnTimeStampValue;

		/// <summary>
		/// DB column: remaining
		/// </summary>
		public const long mbRemaining = 4L;

		/// <summary>
		/// DB column: expiration
		/// </summary>
		public const long mbExpiration = 8L;

		protected int lnExpirationValue;

		/// <summary>
		/// DB column: docid
		/// </summary>
		public const long mbDocId = 16L;

		/// <summary>
		/// DB column: userid
		/// </summary>
		public const long mbUserId = 32L;

		/// <summary>
		/// DB column: objid
		/// </summary>
		public const long mbObjId = 64L;

		/// <summary>
		/// Member bit: The fileName in the download url.
		/// </summary>
		/// <remarks>
		/// It is readonly.
		/// DB column: fname
		/// </remarks>
		public const long mbFileName = 128L;

		protected int lnFileNameValue;

		/// <summary>
		/// Member bit: Indicates whether the download is inline or as attachment.
		/// </summary>
		/// <remarks>
		/// DB column: acode
		/// </remarks>
		public const long mbAttachmentCode = 256L;

		protected int lnAttachmentCodeValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 511L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1639180602L;		
	} // end class
}  // end namespace
