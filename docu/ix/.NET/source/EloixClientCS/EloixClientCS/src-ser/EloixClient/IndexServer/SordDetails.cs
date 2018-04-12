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
	/// Objects of this class are data elements and control the values assigned to
	/// certain boolean properties(yes/no attributes).
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class SordDetails : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public SordDetails() {
		}		
		
		public SordDetails(int @archivingMode, int @encryptionSet, bool @fulltext, int @sortOrder, bool @arcReplEnabled, bool @fulltextDone, bool @replRoot, bool @linked, bool @incomplete, bool @limitedReleaseDocument, bool @linkedPermanent, bool @documentContainer, bool @translateSordName) {
			this.archivingModeValue = @archivingMode;
			this.encryptionSetValue = @encryptionSet;
			this.fulltextValue = @fulltext;
			this.sortOrderValue = @sortOrder;
			this.arcReplEnabledValue = @arcReplEnabled;
			this.fulltextDoneValue = @fulltextDone;
			this.replRootValue = @replRoot;
			this.linkedValue = @linked;
			this.incompleteValue = @incomplete;
			this.limitedReleaseDocumentValue = @limitedReleaseDocument;
			this.linkedPermanentValue = @linkedPermanent;
			this.documentContainerValue = @documentContainer;
			this.translateSordNameValue = @translateSordName;
		}		
		
		public SordDetails(SordDetails rhs) : base(rhs)
		{
			this.archivingModeValue = rhs.archivingModeValue;
			this.encryptionSetValue = rhs.encryptionSetValue;
			this.fulltextValue = rhs.fulltextValue;
			this.sortOrderValue = rhs.sortOrderValue;
			this.arcReplEnabledValue = rhs.arcReplEnabledValue;
			this.fulltextDoneValue = rhs.fulltextDoneValue;
			this.replRootValue = rhs.replRootValue;
			this.linkedValue = rhs.linkedValue;
			this.incompleteValue = rhs.incompleteValue;
			this.limitedReleaseDocumentValue = rhs.limitedReleaseDocumentValue;
			this.linkedPermanentValue = rhs.linkedPermanentValue;
			this.documentContainerValue = rhs.documentContainerValue;
			this.translateSordNameValue = rhs.translateSordNameValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Archiving mode.
		/// </summary>
		/// <remarks>
		/// The possible values are:
		/// <table border="2">
		/// <tr><td>version controlled</td><td>ArchivingModeC.VERSION</td></tr>
		/// <tr><td>read-only</td><td>ArchivingModeC.READONLY</td></tr>
		/// <tr><td>read/write</td><td>ArchivingModeC.READWRITE</td></tr>
		/// </table>
		/// This value is only valid for document objects.
		/// </remarks>
		public int archivingMode
		{
			get
			{
				return archivingModeValue;
			}
			set
			{
				this.archivingModeValue = value;
			}
		}
		
		
		/// <summary>
		/// Encryption set number.
		/// </summary>
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
		/// Document is or should be containted in the fultext database.
		/// </summary>
		public bool fulltext
		{
			get
			{
				return fulltextValue;
			}
			set
			{
				this.fulltextValue = value;
			}
		}
		
		
		/// <summary>
		/// Sort order of child entries.
		/// </summary>
		/// <remarks>
		/// This value is only valid for folder objects.
		/// </remarks>
		public int sortOrder
		{
			get
			{
				return sortOrderValue;
			}
			set
			{
				this.sortOrderValue = value;
			}
		}
		
		
		/// <summary>
		/// True, if replication is enabled for this archive.
		/// </summary>
		public bool arcReplEnabled
		{
			get
			{
				return arcReplEnabledValue;
			}
			set
			{
				this.arcReplEnabledValue = value;
			}
		}
		
		
		/// <summary>
		/// Document is indexed in the fultext database.
		/// </summary>
		public bool fulltextDone
		{
			get
			{
				return fulltextDoneValue;
			}
			set
			{
				this.fulltextDoneValue = value;
			}
		}
		
		
		/// <summary>
		/// True, if this object is a root folder for replication.
		/// </summary>
		public bool replRoot
		{
			get
			{
				return replRootValue;
			}
			set
			{
				this.replRootValue = value;
			}
		}
		
		
		/// <summary>
		/// True, if this object has links to other Sords.
		/// </summary>
		/// <remarks>
		/// This member is read-only and is ignored in checkinSord and checkinDocEnd.
		/// </remarks>
		public bool linked
		{
			get
			{
				return linkedValue;
			}
			set
			{
				this.linkedValue = value;
			}
		}
		
		
		/// <summary>
		/// True, if a document or attachment version has been deleted.
		/// </summary>
		public bool incomplete
		{
			get
			{
				return incompleteValue;
			}
			set
			{
				this.incompleteValue = value;
			}
		}
		
		
		/// <summary>
		/// Documents using this mask may be used as release notes
		/// </summary>
		public bool limitedReleaseDocument
		{
			get
			{
				return limitedReleaseDocumentValue;
			}
			set
			{
				this.limitedReleaseDocumentValue = value;
			}
		}
		
		
		/// <summary>
		/// True, if this object has permanent links to other Sords.
		/// </summary>
		/// <remarks>
		/// This member is read-only and is ignored in checkinSord and checkinDocEnd.
		/// </remarks>
		public bool linkedPermanent
		{
			get
			{
				return linkedPermanentValue;
			}
			set
			{
				this.linkedPermanentValue = value;
			}
		}
		
		
		/// <summary>
		/// Folders can be marked as a document container by this flag.
		/// </summary>
		/// <remarks>
		/// If true,
		/// clients are advised to preview the first document in this folder on
		/// selection.
		/// </remarks>
		public bool documentContainer
		{
			get
			{
				return documentContainerValue;
			}
			set
			{
				this.documentContainerValue = value;
			}
		}
		
		
		/// <summary>
		/// If <tt>true</tt> translate the sord's short description into or from the user language.
		/// </summary>
		public bool translateSordName
		{
			get
			{
				return translateSordNameValue;
			}
			set
			{
				this.translateSordNameValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int archivingModeValue;

		protected int encryptionSetValue;

		protected bool fulltextValue;

		protected int sortOrderValue;

		protected bool arcReplEnabledValue;

		protected bool fulltextDoneValue;

		protected bool replRootValue;

		protected bool linkedValue;

		protected bool incompleteValue;

		protected bool limitedReleaseDocumentValue;

		protected bool linkedPermanentValue;

		protected bool documentContainerValue;

		protected bool translateSordNameValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1713693326L;		
	} // end class
}  // end namespace
