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
	/// This class contains several options that are used to get the public
	/// downloads.
	/// </summary>
	/// <remarks>
	/// <p>
	/// Copyright: Copyright (c) 2014
	/// </p>
	/// <p>
	/// Organisation: ELO Digital Office GmbH
	/// </p>
	/// </remarks>
	public class PublicDownloadOptions : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public PublicDownloadOptions() {
		}		
		
		public PublicDownloadOptions(String[] @downloadIds, String @expiration, int @remaining, String @docId, String @objId, bool @fileNameFromSordName, bool @contentDispositionAttachment) {
			this.downloadIdsValue = @downloadIds;
			this.expirationValue = @expiration;
			this.remainingValue = @remaining;
			this.docIdValue = @docId;
			this.objIdValue = @objId;
			this.fileNameFromSordNameValue = @fileNameFromSordName;
			this.contentDispositionAttachmentValue = @contentDispositionAttachment;
		}		
		
		public PublicDownloadOptions(PublicDownloadOptions rhs) : base(rhs)
		{
			this.downloadIdsValue = rhs.downloadIdsValue;
			this.expirationValue = rhs.expirationValue;
			this.remainingValue = rhs.remainingValue;
			this.docIdValue = rhs.docIdValue;
			this.objIdValue = rhs.objIdValue;
			this.fileNameFromSordNameValue = rhs.fileNameFromSordNameValue;
			this.contentDispositionAttachmentValue = rhs.contentDispositionAttachmentValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// The download IDs to retrieve the public downloads.
		/// </summary>
		public String[] downloadIds
		{
			get
			{
				return downloadIdsValue;
			}
			set
			{
				this.downloadIdsValue = value;
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
			}
		}
		
		
		/// <summary>
		/// The remaining download.
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
			}
		}
		
		
		/// <summary>
		/// The doc id.
		/// </summary>
		public String docId
		{
			get
			{
				return docIdValue;
			}
			set
			{
				this.docIdValue = value;
			}
		}
		
		
		/// <summary>
		/// The obj id.
		/// </summary>
		public String objId
		{
			get
			{
				return objIdValue;
			}
			set
			{
				this.objIdValue = value;
			}
		}
		
		
		/// <summary>
		/// If true, the short description of the sord is used as file name in the download URL.
		/// </summary>
		/// <remarks>
		/// Otherwise the original file name is used.
		/// </remarks>
		public bool fileNameFromSordName
		{
			get
			{
				return fileNameFromSordNameValue;
			}
			set
			{
				this.fileNameFromSordNameValue = value;
			}
		}
		
		
		/// <summary>
		/// If true, the document is downloaded as an attachment.
		/// </summary>
		/// <remarks>
		/// Otherwise it content is shown in-line in the browser.
		/// </remarks>
		public bool contentDispositionAttachment
		{
			get
			{
				return contentDispositionAttachmentValue;
			}
			set
			{
				this.contentDispositionAttachmentValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String[] downloadIdsValue;

		protected String expirationValue;

		protected int remainingValue;

		protected String docIdValue;

		protected String objIdValue;

		protected bool fileNameFromSordNameValue;

		protected bool contentDispositionAttachmentValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 252853324L;		
	} // end class
}  // end namespace
