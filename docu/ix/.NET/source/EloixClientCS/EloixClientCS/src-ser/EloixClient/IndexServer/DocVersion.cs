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
	/// <p>Description: This class describes a document version, a document preview
	/// or a signature.
	/// </summary>
	/// <remarks>
	/// </p>
	/// <p>Copyright: Copyright (c) 2002</p>
	/// <p>Organisation: ELO DIgital Office GmbH</p>
	/// </remarks>
	public class DocVersion : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public DocVersion() {
		}		
		
		public DocVersion(String @accessDateIso, String @comment, String @createDateIso, bool @deleted, String @ext, String @contentType, EloixClient.IndexServer.FileData @fileData, String @guid, int @id, String @md5, bool @milestone, int @ownerId, String @ownerName, int @pathId, int @pathId2, String @physPath, String @previewUrl, EloixClient.IndexServer.DocVersion @sig, EloixClient.IndexServer.DocVersion @preview, long @size, String @tStamp, String @updateDateIso, String @uploadResult, String @url, String @version, bool @workVersion, int @encryptionSet, EloixClient.IndexServer.DocVersion @fulltextContent, String @deleteDateIso, int @nbOfValidSignatures, String @relativeFilePath, String @tStampSync) {
			this.accessDateIsoValue = @accessDateIso;
			this.commentValue = @comment;
			this.createDateIsoValue = @createDateIso;
			this.deletedValue = @deleted;
			this.extValue = @ext;
			this.contentTypeValue = @contentType;
			this.fileDataValue = @fileData;
			this.guidValue = @guid;
			this.idValue = @id;
			this.md5Value = @md5;
			this.milestoneValue = @milestone;
			this.ownerIdValue = @ownerId;
			this.ownerNameValue = @ownerName;
			this.pathIdValue = @pathId;
			this.pathId2Value = @pathId2;
			this.physPathValue = @physPath;
			this.previewUrlValue = @previewUrl;
			this.sigValue = @sig;
			this.previewValue = @preview;
			this.sizeValue = @size;
			this.tStampValue = @tStamp;
			this.updateDateIsoValue = @updateDateIso;
			this.uploadResultValue = @uploadResult;
			this.urlValue = @url;
			this.versionValue = @version;
			this.workVersionValue = @workVersion;
			this.encryptionSetValue = @encryptionSet;
			this.fulltextContentValue = @fulltextContent;
			this.deleteDateIsoValue = @deleteDateIso;
			this.nbOfValidSignaturesValue = @nbOfValidSignatures;
			this.relativeFilePathValue = @relativeFilePath;
			this.tStampSyncValue = @tStampSync;
		}		
		
		public DocVersion(DocVersion rhs) : base(rhs)
		{
			this.accessDateIsoValue = rhs.accessDateIsoValue;
			this.commentValue = rhs.commentValue;
			this.createDateIsoValue = rhs.createDateIsoValue;
			this.deletedValue = rhs.deletedValue;
			this.extValue = rhs.extValue;
			this.contentTypeValue = rhs.contentTypeValue;
			this.fileDataValue = rhs.fileDataValue;
			this.guidValue = rhs.guidValue;
			this.idValue = rhs.idValue;
			this.md5Value = rhs.md5Value;
			this.milestoneValue = rhs.milestoneValue;
			this.ownerIdValue = rhs.ownerIdValue;
			this.ownerNameValue = rhs.ownerNameValue;
			this.pathIdValue = rhs.pathIdValue;
			this.pathId2Value = rhs.pathId2Value;
			this.physPathValue = rhs.physPathValue;
			this.previewUrlValue = rhs.previewUrlValue;
			this.sigValue = rhs.sigValue;
			this.previewValue = rhs.previewValue;
			this.sizeValue = rhs.sizeValue;
			this.tStampValue = rhs.tStampValue;
			this.updateDateIsoValue = rhs.updateDateIsoValue;
			this.uploadResultValue = rhs.uploadResultValue;
			this.urlValue = rhs.urlValue;
			this.versionValue = rhs.versionValue;
			this.workVersionValue = rhs.workVersionValue;
			this.encryptionSetValue = rhs.encryptionSetValue;
			this.fulltextContentValue = rhs.fulltextContentValue;
			this.deleteDateIsoValue = rhs.deleteDateIsoValue;
			this.nbOfValidSignaturesValue = rhs.nbOfValidSignaturesValue;
			this.relativeFilePathValue = rhs.relativeFilePathValue;
			this.tStampSyncValue = rhs.tStampSyncValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Last access date.
		/// </summary>
		/// <remarks>
		/// ClientInfo determines the Timezone.
		/// <p>Applies to document version and signature.
		/// Is undefined for preview and fulltextContent.</p>
		/// </remarks>
		public String accessDateIso
		{
			get
			{
				return accessDateIsoValue;
			}
			set
			{
				this.accessDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Version comment
		/// <p>Applies to document version.
		/// </summary>
		/// <remarks>
		/// Is undefined for signature, preview and fulltextContent.</p>
		/// </remarks>
		public String comment
		{
			get
			{
				return commentValue;
			}
			set
			{
				this.commentValue = value;
			}
		}
		
		
		/// <summary>
		/// Create date.
		/// </summary>
		/// <remarks>
		/// ClientInfo determines the Timezone.
		/// <p>Applies to document version and signature.
		/// Is undefined for preview and fulltextContent.</p>
		/// </remarks>
		public String createDateIso
		{
			get
			{
				return createDateIsoValue;
			}
			set
			{
				this.createDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Indicates whether the version is logically deleted.
		/// </summary>
		/// <remarks>
		/// <p>Applies to document version.
		/// Is undefined for signature, preview and fulltextContent.</p>
		/// </remarks>
		public bool deleted
		{
			get
			{
				return deletedValue;
			}
			set
			{
				this.deletedValue = value;
			}
		}
		
		
		/// <summary>
		/// Document file extension (without ".")
		/// </summary>
		/// <remarks>
		/// <p>Applies to document version, signature and preview.
		/// Is readonly for fulltextContent.</p>
		/// This value has precedence before <code>contentType</code>.
		/// </remarks>
		public String ext
		{
			get
			{
				return extValue;
			}
			set
			{
				this.extValue = value;
			}
		}
		
		
		/// <summary>
		/// Content-Type (MIME-Type).
		/// </summary>
		public String contentType
		{
			get
			{
				return contentTypeValue;
			}
			set
			{
				this.contentTypeValue = value;
			}
		}
		
		
		/// <summary>
		/// Document, preview or fulltextContent file content.
		/// </summary>
		/// <remarks>
		/// If <code>checkoutDoc</code> is called with option
		/// <code>mbSordDocSmallContent</code> and the requested document (version) is small (less than
		/// the configured value), this member contains the file data and content type. If
		/// <code>mbPreview</code> is additionally set, <code>fileData</code> contains the content of
		/// the preview - REGARDLESS of the size. In case there is no preview, <code>fileData</code>
		/// contains the data of the document (if it's a small file).
		/// <p>Applies to document version, signature and preview.</p>
		/// </remarks>
		public EloixClient.IndexServer.FileData fileData
		{
			get
			{
				return fileDataValue;
			}
			set
			{
				this.fileDataValue = value;
			}
		}
		
		
		/// <summary>
		/// Document GUID.
		/// </summary>
		/// <remarks>
		/// <p>Applies to document version and signature. Is undefined for preview and fulltextContent.</p>
		/// </remarks>
		public String guid
		{
			get
			{
				return guidValue;
			}
			set
			{
				this.guidValue = value;
			}
		}
		
		
		/// <summary>
		/// Document ID
		/// <p>Applies to document version and signature.
		/// </summary>
		/// <remarks>
		/// Is undefined for preview and fulltextContent.</p>
		/// </remarks>
		public int id
		{
			get
			{
				return idValue;
			}
			set
			{
				this.idValue = value;
			}
		}
		
		
		/// <summary>
		/// MD5 hash of the documet file.
		/// </summary>
		/// <remarks>
		/// <p>Applies to document version and signature. Is undefined for preview and fulltextContent.</p>
		/// </remarks>
		public String md5
		{
			get
			{
				return md5Value;
			}
			set
			{
				this.md5Value = value;
			}
		}
		
		
		/// <summary>
		/// Indicates whether the version is marked as a milestone version.
		/// </summary>
		/// <remarks>
		/// <p>Applies to document version. Is undefined for signature and preview and fulltextContent.</p>
		/// </remarks>
		public bool milestone
		{
			get
			{
				return milestoneValue;
			}
			set
			{
				this.milestoneValue = value;
			}
		}
		
		
		/// <summary>
		/// The owners user ID.
		/// </summary>
		/// <remarks>
		/// <p>Applies to document version. Is undefined for signature and preview and fulltextContent.</p>
		/// </remarks>
		public int ownerId
		{
			get
			{
				return ownerIdValue;
			}
			set
			{
				this.ownerIdValue = value;
			}
		}
		
		
		/// <summary>
		/// The owners user name.
		/// </summary>
		/// <remarks>
		/// This value is read only (ignored in checkinDoc...).
		/// <p>Applies to document version. Is undefined for signature and preview and fulltextContent.</p>
		/// </remarks>
		public String ownerName
		{
			get
			{
				return ownerNameValue;
			}
			set
			{
				this.ownerNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Storage path ID
		/// <p>Applies to document version and signature.
		/// </summary>
		/// <remarks>
		/// Is undefined for preview and fulltextContent.</p>
		/// </remarks>
		public int pathId
		{
			get
			{
				return pathIdValue;
			}
			set
			{
				this.pathIdValue = value;
			}
		}
		
		
		/// <summary>
		/// (to be defined)
		/// <p>Applies to document version and signature.
		/// </summary>
		/// <remarks>
		/// Is undefined for preview and fulltextContent.</p>
		/// </remarks>
		public int pathId2
		{
			get
			{
				return pathId2Value;
			}
			set
			{
				this.pathId2Value = value;
			}
		}
		
		
		/// <summary>
		/// Physical path
		/// <p>Applies to document version and signature.
		/// </summary>
		/// <remarks>
		/// Is undefined for preview and fulltextContent.</p>
		/// Set SordC.mbPhysPath or EditInfoC.mbPhysPath in the member selector
		/// passed to checkoutSord or checkoutDoc to read the physical path.
		/// </remarks>
		public String physPath
		{
			get
			{
				return physPathValue;
			}
			set
			{
				this.physPathValue = value;
			}
		}
		
		
		/// <summary>
		/// <p>URL to up-/download a document preview.
		/// </summary>
		/// <remarks>
		/// </p>
		/// <p>Applies to document version. Is empty for signature and preview and fulltextContent.</p>
		/// </remarks>
		public String previewUrl
		{
			get
			{
				return previewUrlValue;
			}
			set
			{
				this.previewUrlValue = value;
			}
		}
		
		
		/// <summary>
		/// Document signature
		/// <p>Applies to document version.
		/// </summary>
		/// <remarks>
		/// Is null for signature and preview and fulltextContent.</p>
		/// </remarks>
		public EloixClient.IndexServer.DocVersion sig
		{
			get
			{
				return sigValue;
			}
			set
			{
				this.sigValue = value;
			}
		}
		
		
		/// <summary>
		/// Document preview
		/// <p>Applies to document version.
		/// </summary>
		/// <remarks>
		/// Is null for signature and preview and fulltextContent.</p>
		/// </remarks>
		public EloixClient.IndexServer.DocVersion preview
		{
			get
			{
				return previewValue;
			}
			set
			{
				this.previewValue = value;
			}
		}
		
		
		/// <summary>
		/// File size.
		/// </summary>
		public long size
		{
			get
			{
				return sizeValue;
			}
			set
			{
				this.sizeValue = value;
			}
		}
		
		
		/// <summary>
		/// Document timestamp
		/// <p>Applies to document version and signature.
		/// </summary>
		/// <remarks>
		/// Is undefined for preview. (Is available for fulltextContent)</p>
		/// The format is JJJJ.MM.DD.hh.mm.ss
		/// </remarks>
		public String tStamp
		{
			get
			{
				return tStampValue;
			}
			set
			{
				this.tStampValue = value;
			}
		}
		
		
		/// <summary>
		/// Last update date.
		/// </summary>
		/// <remarks>
		/// ClientInfo determines the Timezone.
		/// <p>Applies to document version and signature. Is undefined for preview and fulltextContent.</p>
		/// </remarks>
		public String updateDateIso
		{
			get
			{
				return updateDateIsoValue;
			}
			set
			{
				this.updateDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Result from the ELODM if the document was uploaded.
		/// </summary>
		/// <remarks>
		/// <p>Applies to document version, signature, preview and fulltextContent.</p>
		/// </remarks>
		public String uploadResult
		{
			get
			{
				return uploadResultValue;
			}
			set
			{
				this.uploadResultValue = value;
			}
		}
		
		
		/// <summary>
		/// URL to up-/download
		/// <p>Applies to document version, signature,preview and fulltextContent.
		/// </summary>
		/// <remarks>
		/// </p>
		/// </remarks>
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
		/// Version number
		/// <p>Applies to document version.
		/// </summary>
		/// <remarks>
		/// Is undefined for signature, preview and fulltextContent.</p>
		/// </remarks>
		public String version
		{
			get
			{
				return versionValue;
			}
			set
			{
				this.versionValue = value;
			}
		}
		
		
		/// <summary>
		/// Indicates whether the version is the current work version.
		/// </summary>
		/// <remarks>
		/// <p>Applies to document version. Is undefined for signature, preview and fulltextContent.</p>
		/// </remarks>
		public bool workVersion
		{
			get
			{
				return workVersionValue;
			}
			set
			{
				this.workVersionValue = value;
			}
		}
		
		
		/// <summary>
		/// ID of the encryption set.
		/// </summary>
		/// <remarks>
		/// It's password is used to encrypt or decrypt the document.
		/// It a new document or version should be checked in, this member must be set
		/// to Sord.details.encryptionSet before checkinDocBegin is called.
		/// When this object is retrieved via IX it is always set to Sord.details.encryptionSet.
		/// <p>Applies to document version. Is undefined for signature, preview and fulltextContent.</p>
		/// </remarks>
		public int encryptionSet
		{
			get
			{
				return encryptionSetValue;
			}
			set
			{
				this.encryptionSetValue = value;
			}
		}
		
		
		/// <summary>
		/// This object provides the content of the fulltext database for the document version.
		/// </summary>
		/// <remarks>
		/// The information is read-only and only available for DocVersion objects that refer to
		/// a document version (and not an attachment, preview or signature).
		/// Currenly, only the members url, ext, contentType and encryptionSet are valid vor a DocVersion object
		/// that belongs to fulltext content. Whereby ext is always txt and contentType is always text/plain.
		/// A Byte Order Mark preceedes the content data.
		/// If the related document version is encrypted, the appropriate encryption password
		/// has to be set, before the fulltext information can be downloaded.
		/// If the SessionOptionC.DECRYPT_DOCUMENTS is not set, the fulltext information is transmitted
		/// encrypted.
		/// <p>Applies to document version. Is undefined for signature and preview.</p>
		/// </remarks>
		public EloixClient.IndexServer.DocVersion fulltextContent
		{
			get
			{
				return fulltextContentValue;
			}
			set
			{
				this.fulltextContentValue = value;
			}
		}
		
		
		/// <summary>
		/// Delete date.
		/// </summary>
		/// <remarks>
		/// ClientInfo determines the Timezone.
		/// <p>Is undefined if isDeleted() returns false.</p>
		/// </remarks>
		public String deleteDateIso
		{
			get
			{
				return deleteDateIsoValue;
			}
			set
			{
				this.deleteDateIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// Number of valid signatures.
		/// </summary>
		/// <remarks>
		/// This member holds the count of valid signatures in the signature file.
		/// It is only valid for a DocVersion object that represents a signature (member {@link #sig}).
		/// A value of zero means, that the signatures are unchecked. A number greater than zero means,
		/// that all signatures are valid. In this case the member value is equal to the number of signatures.
		/// If at least one signature is invalid, the value is less than zero. The number of invalid signatures is thereby unknown.
		/// Client applications are responsible to check signatures. The ELOix does not check signatures.
		/// </remarks>
		public int nbOfValidSignatures
		{
			get
			{
				return nbOfValidSignaturesValue;
			}
			set
			{
				this.nbOfValidSignaturesValue = value;
			}
		}
		
		
		/// <summary>
		/// Relative file path for external file.
		/// </summary>
		/// <remarks>
		/// This member specifies the location of the file relative to a custom path.
		/// If {@link #pathId} does not refer a custom path, this member is empty and ignored in {@link IXServicePortIF#checkinDocEnd(ClientInfo, Sord, SordZ, Document, LockZ)}.
		/// </remarks>
		public String relativeFilePath
		{
			get
			{
				return relativeFilePathValue;
			}
			set
			{
				this.relativeFilePathValue = value;
			}
		}
		
		
		/// <summary>
		/// Timestamp of this object's ACLs last export by the replication.
		/// </summary>
		public String tStampSync
		{
			get
			{
				return tStampSyncValue;
			}
			set
			{
				this.tStampSyncValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String accessDateIsoValue;

		protected String commentValue;

		protected String createDateIsoValue;

		protected bool deletedValue;

		protected String extValue;

		protected String contentTypeValue;

		protected EloixClient.IndexServer.FileData fileDataValue;

		protected String guidValue;

		protected int idValue;

		protected String md5Value;

		protected bool milestoneValue;

		protected int ownerIdValue;

		protected String ownerNameValue;

		protected int pathIdValue;

		protected int pathId2Value;

		protected String physPathValue;

		protected String previewUrlValue;

		protected EloixClient.IndexServer.DocVersion sigValue;

		protected EloixClient.IndexServer.DocVersion previewValue;

		protected long sizeValue;

		protected String tStampValue;

		protected String updateDateIsoValue;

		protected String uploadResultValue;

		protected String urlValue;

		protected String versionValue;

		protected bool workVersionValue;

		protected int encryptionSetValue;

		protected EloixClient.IndexServer.DocVersion fulltextContentValue;

		protected String deleteDateIsoValue;

		protected int nbOfValidSignaturesValue;

		protected String relativeFilePathValue;

		protected String tStampSyncValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 633004623L;		
	} // end class
}  // end namespace
