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
	/// This class contains a member of a <code>DocMask</code> object.
	/// </summary>
	/// <remarks>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class DocMaskDetails : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public DocMaskDetails() {
		}		
		
		public DocMaskDetails(int @archivingMode, int @encryptionSet, bool @fulltext, int @sortOrder, bool @documentMask, bool @searchMask, bool @folderMask, bool @createIndexPath, bool @createIndexReferencesPaths, bool @releaseDocument, bool @documentContainer, bool @translateSordName) {
			this.archivingModeValue = @archivingMode;
			this.encryptionSetValue = @encryptionSet;
			this.fulltextValue = @fulltext;
			this.sortOrderValue = @sortOrder;
			this.documentMaskValue = @documentMask;
			this.searchMaskValue = @searchMask;
			this.folderMaskValue = @folderMask;
			this.createIndexPathValue = @createIndexPath;
			this.createIndexReferencesPathsValue = @createIndexReferencesPaths;
			this.releaseDocumentValue = @releaseDocument;
			this.documentContainerValue = @documentContainer;
			this.translateSordNameValue = @translateSordName;
		}		
		
		public DocMaskDetails(DocMaskDetails rhs) : base(rhs)
		{
			this.archivingModeValue = rhs.archivingModeValue;
			this.encryptionSetValue = rhs.encryptionSetValue;
			this.fulltextValue = rhs.fulltextValue;
			this.sortOrderValue = rhs.sortOrderValue;
			this.documentMaskValue = rhs.documentMaskValue;
			this.searchMaskValue = rhs.searchMaskValue;
			this.folderMaskValue = rhs.folderMaskValue;
			this.createIndexPathValue = rhs.createIndexPathValue;
			this.createIndexReferencesPathsValue = rhs.createIndexReferencesPathsValue;
			this.releaseDocumentValue = rhs.releaseDocumentValue;
			this.documentContainerValue = rhs.documentContainerValue;
			this.translateSordNameValue = rhs.translateSordNameValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Archiving mode.
		/// </summary>
		/// <remarks>
		/// Sort order and archiving mode share the same database column.
		/// If the mask is used for documents, set <code>sortOrder=SordOrderC.NONE</code>.
		/// ELO 7.0: This value is only valid for document masks, <code>documentMask=true</code>.
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
		/// Sort order and archiving mode share the same database column.
		/// If the mask is used for folders, set <code>archivingMode=ArchivingModeC.NONE</code>.
		/// If both <code>sortOrder</code> and <code>archivingMode</code> are set, <code>sortOrder</code>
		/// has precedence and <code>archivingMode</code> is ignored.
		/// ELO 7.0: This value is only valid for folder masks, <code>folderMask=true</code>.
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
		/// Mask can be used to edit indexing information of a document.
		/// </summary>
		public bool documentMask
		{
			get
			{
				return documentMaskValue;
			}
			set
			{
				this.documentMaskValue = value;
			}
		}
		
		
		/// <summary>
		/// Mask can be used to search for indexing information.
		/// </summary>
		public bool searchMask
		{
			get
			{
				return searchMaskValue;
			}
			set
			{
				this.searchMaskValue = value;
			}
		}
		
		
		/// <summary>
		/// Mask can be used to edit indexing information of a folder
		/// </summary>
		public bool folderMask
		{
			get
			{
				return folderMaskValue;
			}
			set
			{
				this.folderMaskValue = value;
			}
		}
		
		
		/// <summary>
		/// If <code>DocMask.index</code> is defined,
		/// this option effects that the resulting archieve path is created, if
		/// it does not exist.
		/// </summary>
		public bool createIndexPath
		{
			get
			{
				return createIndexPathValue;
			}
			set
			{
				this.createIndexPathValue = value;
			}
		}
		
		
		/// <summary>
		/// If <code>DocMask.index</code> is defined including reference paths,
		/// this option effects that the resulting reference paths are created, if
		/// they do not exist.
		/// </summary>
		public bool createIndexReferencesPaths
		{
			get
			{
				return createIndexReferencesPathsValue;
			}
			set
			{
				this.createIndexReferencesPathsValue = value;
			}
		}
		
		
		/// <summary>
		/// Documents using this mask may be used as release notes
		/// </summary>
		public bool releaseDocument
		{
			get
			{
				return releaseDocumentValue;
			}
			set
			{
				this.releaseDocumentValue = value;
			}
		}
		
		
		/// <summary>
		/// Folders indexed with this mask get the flag {@link SordDetails#documentContainer} set accordingly.
		/// </summary>
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

		protected bool documentMaskValue;

		protected bool searchMaskValue;

		protected bool folderMaskValue;

		protected bool createIndexPathValue;

		protected bool createIndexReferencesPathsValue;

		protected bool releaseDocumentValue;

		protected bool documentContainerValue;

		protected bool translateSordNameValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 639048562L;		
	} // end class
}  // end namespace
