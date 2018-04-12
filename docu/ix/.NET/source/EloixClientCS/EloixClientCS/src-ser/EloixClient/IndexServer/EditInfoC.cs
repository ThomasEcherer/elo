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
	/// <p>Constants to read data for editing the indexing information of an archive entry</p>
	/// </summary>
	public class EditInfoC : BSerializable
	{
	
		#region Constructors
		
		public EditInfoC() {
		}		
		
		public EditInfoC(EditInfoC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Mask names.
		/// </summary>
		public const long mbMaskNames = 1L;

		/// <summary>
		/// Path names.
		/// </summary>
		public const long mbPathNames = 2L;

		/// <summary>
		/// Marker names (colors).
		/// </summary>
		public const long mbMarkerNames = 4L;

		/// <summary>
		/// RESERVED.
		/// </summary>
		/// <remarks>
		/// Document templates.
		/// </remarks>
		public const long mbDocTemplates = 8L;

		/// <summary>
		/// Complete data of the mask of the specified object.
		/// </summary>
		public const long mbMask = 16L;

		/// <summary>
		/// Information to download the document of the archive entry.
		/// </summary>
		public const long mbDocumentMembers = 64L;

		/// <summary>
		/// Information to download the attachment of the archive entry.
		/// </summary>
		public const long mbAttachmentMembers = 128L;

		/// <summary>
		/// Information to download the signature of the archive entry.
		/// </summary>
		public const long mbSignatureMembers = 256L;

		/// <summary>
		/// Names of all replication sets.
		/// </summary>
		public const long mbReplNames = 512L;

		/// <summary>
		/// List of Sord types (labels, icons, extensions corresponding to Sord.type).
		/// </summary>
		/// <remarks>
		/// Icon images are returned in JPEG format.
		/// </remarks>
		public const long mbSordTypesJPG = 1024L;

		/// <summary>
		/// Return notes in checkoutSord and checkoutDoc.
		/// </summary>
		public const long mbNoteMembers = 2048L;

		/// <summary>
		/// Return keywords in checkoutSord and checkoutDoc.
		/// </summary>
		public const long mbKeywordMembers = 4096L;

		/// <summary>
		/// Return document preview in checkoutDoc
		/// </summary>
		public const long mbPreviewMembers = 8192L;

		/// <summary>
		/// Return the physical path of the document in checkoutDoc.
		/// </summary>
		/// <remarks>
		/// This requires a request to Document Mangager.
		/// </remarks>
		public const long mbPhysPath = 8192L;

		/// <summary>
		/// All members: indexing information + basic data + document + attachment + signature
		/// </summary>
		public const long mbAllMembers = 16383L;

		/// <summary>
		/// Sord object with all members.
		/// </summary>
		public readonly static EloixClient.IndexServer.EditInfoZ mbSord = new EditInfoZ(0L, new SordZ(2145422063697919L));

		/// <summary>
		/// Sord object with all members, work version can be read from an InputStream.
		/// </summary>
		/// <remarks>
		/// File content is supplied in {@link Sord#docVersion}, {@link FileData#stream}.
		/// </remarks>
		public readonly static EloixClient.IndexServer.EditInfoZ mbSordContentStream = new EditInfoZ(0L, new SordZ(4397221877383167L));

		/// <summary>
		/// Sord object with lean members.
		/// </summary>
		public readonly static EloixClient.IndexServer.EditInfoZ mbSordLean = new EditInfoZ(0L, new SordZ(10168869847039L));

		/// <summary>
		/// Sord object with SordC.mbAll, document versions, signatures.
		/// </summary>
		public readonly static EloixClient.IndexServer.EditInfoZ mbSordDoc = new EditInfoZ(320L, new SordZ(2145422063697919L));

		/// <summary>
		/// Sord object with SordC.mbAll, document versions, attachment versions, signatures.
		/// </summary>
		public readonly static EloixClient.IndexServer.EditInfoZ mbSordDocAtt = new EditInfoZ(448L, new SordZ(2145422063697919L));

		/// <summary>
		/// Sord object with SordC.mbAll, document versions, attachment versions, signatures.
		/// </summary>
		/// <remarks>
		/// File contents are supplied in {@link FileData#stream}.
		/// </remarks>
		public readonly static EloixClient.IndexServer.EditInfoZ mbSordDocAttContentStream = new EditInfoZ(448L, new SordZ(4397221877383167L));

		/// <summary>
		/// Includes
		/// mbDocumentMembers, mbSignatureMembers, SordC.mbCheckout
		/// </summary>
		public readonly static EloixClient.IndexServer.EditInfoZ mbSordDocSmallContent = new EditInfoZ(320L, new SordZ(2180606435786751L));

		/// <summary>
		/// Includes
		/// mbDocumentMembers|mbSignatureMembers, SordC.mbCheckoutPreview
		/// </summary>
		public readonly static EloixClient.IndexServer.EditInfoZ mbSordPreviewSmallContent = new EditInfoZ(8512L, new SordZ(2180606435786751L));

		/// <summary>
		/// Document version(s) and signature, no index information
		/// </summary>
		public readonly static EloixClient.IndexServer.EditInfoZ mbDocument = new EditInfoZ(320L, new SordZ(0L));

		/// <summary>
		/// Attachment version(s), no index information
		/// </summary>
		public readonly static EloixClient.IndexServer.EditInfoZ mbAttachment = new EditInfoZ(128L, new SordZ(0L));

		/// <summary>
		/// All members
		/// without
		/// mbSmallDocumentContent
		/// </summary>
		public readonly static EloixClient.IndexServer.EditInfoZ mbAll = new EditInfoZ(16383L, new SordZ(2215790807875583L));

		/// <summary>
		/// Arrays of mask, marker, repl, path names
		/// </summary>
		public readonly static EloixClient.IndexServer.EditInfoZ mbBasicData = new EditInfoZ(5639L, new SordZ(0L));

		/// <summary>
		/// Lock or unlock object, do not read or write any data.
		/// </summary>
		public readonly static EloixClient.IndexServer.EditInfoZ mbOnlyLock = new EditInfoZ(0L, new SordZ(0L));

		/// <summary>
		/// Return only notes.
		/// </summary>
		public readonly static EloixClient.IndexServer.EditInfoZ mbNotes = new EditInfoZ(2048L, new SordZ(0L));

		/// <summary>
		/// Return all Sord members and notes.
		/// </summary>
		public readonly static EloixClient.IndexServer.EditInfoZ mbSordNotes = new EditInfoZ(2048L, new SordZ(2145422063697919L));

		/// <summary>
		/// Read only Sord ID and GUID.
		/// </summary>
		public readonly static EloixClient.IndexServer.EditInfoZ mbOnlyId = new EditInfoZ(0L, new SordZ(3L));

		#endregion
		
		
		public static readonly long serialVersionUID = 2100880359L;		
	} // end class
}  // end namespace
