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
	/// This class describes the public download information.
	/// </summary>
	/// <remarks>
	/// <p>
	/// Internal use.
	/// </p>
	/// </remarks>
	public class PublicDownload : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public PublicDownload() {
		}		
		
		public PublicDownload(String @id, int @remaining, String @expiration, String @timeStamp, int @docId, int @objId, int @userId, String @url, String @fileName, String @attachmentCode) {
			this.idValue = @id;
			this.remainingValue = @remaining;
			this.expirationValue = @expiration;
			this.timeStampValue = @timeStamp;
			this.docIdValue = @docId;
			this.objIdValue = @objId;
			this.userIdValue = @userId;
			this.urlValue = @url;
			this.fileNameValue = @fileName;
			this.attachmentCodeValue = @attachmentCode;
		}		
		
		public PublicDownload(PublicDownload rhs) : base(rhs)
		{
			this.idValue = rhs.idValue;
			this.remainingValue = rhs.remainingValue;
			this.expirationValue = rhs.expirationValue;
			this.timeStampValue = rhs.timeStampValue;
			this.docIdValue = rhs.docIdValue;
			this.objIdValue = rhs.objIdValue;
			this.userIdValue = rhs.userIdValue;
			this.urlValue = rhs.urlValue;
			this.fileNameValue = rhs.fileNameValue;
			this.attachmentCodeValue = rhs.attachmentCodeValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// The download ID.
		/// </summary>
		public String id
		{
			get
			{
				return idValue;
			}
			set
			{
				this.idValue = value;
				setChangedMember(PublicDownloadC.mbId);
			}
		}
		
		
		/// <summary>
		/// The download count.
		/// </summary>
		public int remaining
		{
			get
			{
				return remainingValue;
			}
			set
			{
				this.remainingValue = value;
				setChangedMember(PublicDownloadC.mbRemaining);
			}
		}
		
		
		/// <summary>
		/// The expired time.
		/// </summary>
		public String expiration
		{
			get
			{
				return expirationValue;
			}
			set
			{
				this.expirationValue = value;
				setChangedMember(PublicDownloadC.mbExpiration);
			}
		}
		
		
		/// <summary>
		/// The time stamp.
		/// </summary>
		public String timeStamp
		{
			get
			{
				return timeStampValue;
			}
			set
			{
				this.timeStampValue = value;
				setChangedMember(PublicDownloadC.mbTimeStamp);
			}
		}
		
		
		/// <summary>
		/// The document ID.
		/// </summary>
		public int docId
		{
			get
			{
				return docIdValue;
			}
			set
			{
				this.docIdValue = value;
				setChangedMember(PublicDownloadC.mbDocId);
			}
		}
		
		
		/// <summary>
		/// The object ID.
		/// </summary>
		public int objId
		{
			get
			{
				return objIdValue;
			}
			set
			{
				this.objIdValue = value;
				setChangedMember(PublicDownloadC.mbObjId);
			}
		}
		
		
		/// <summary>
		/// The user ID.
		/// </summary>
		public int userId
		{
			get
			{
				return userIdValue;
			}
			set
			{
				this.userIdValue = value;
				setChangedMember(PublicDownloadC.mbUserId);
			}
		}
		
		
		/// <summary>
		/// The download URL
		/// </summary>
		public String url
		{
			get
			{
				return urlValue;
			}
			set
			{
				this.urlValue = value;
			}
		}
		
		
		/// <summary>
		/// The fileName in the download url.
		/// </summary>
		/// <remarks>
		/// It is readonly.
		/// </remarks>
		public String fileName
		{
			get
			{
				return fileNameValue;
			}
			set
			{
				this.fileNameValue = value;
				setChangedMember(PublicDownloadC.mbFileName);
			}
		}
		
		
		/// <summary>
		/// Indicates whether the download is inline or as attachment.
		/// </summary>
		public String attachmentCode
		{
			get
			{
				return attachmentCodeValue;
			}
			set
			{
				this.attachmentCodeValue = value;
				setChangedMember(PublicDownloadC.mbAttachmentCode);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String idValue;

		protected int remainingValue;

		protected String expirationValue;

		protected String timeStampValue;

		protected int docIdValue;

		protected int objIdValue;

		protected int userIdValue;

		protected String urlValue;

		protected String fileNameValue;

		protected String attachmentCodeValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2062827124L;		
	} // end class
}  // end namespace
