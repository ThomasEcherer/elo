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
	/// Contains data to edit the indexing information.
	/// </summary>
	/// <remarks>
	/// Therfore it provides storage
	/// mask names, storage path names, marker names, document template names,
	/// replication set names, document version information, etc.
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class EditInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public EditInfo() {
		}		
		
		public EditInfo(EloixClient.IndexServer.IdName[] @docTemplates, EloixClient.IndexServer.Document @document, EloixClient.IndexServer.Keyword[] @keywords, EloixClient.IndexServer.IdName[] @markerNames, EloixClient.IndexServer.DocMask @mask, EloixClient.IndexServer.MaskName[] @maskNames, EloixClient.IndexServer.Note[] @notes, EloixClient.IndexServer.IdName[] @pathNames, EloixClient.IndexServer.IdName[] @replNames, EloixClient.IndexServer.Sord @sord, EloixClient.IndexServer.SordType[] @sordTypes) {
			this.docTemplatesValue = @docTemplates;
			this.documentValue = @document;
			this.keywordsValue = @keywords;
			this.markerNamesValue = @markerNames;
			this.maskValue = @mask;
			this.maskNamesValue = @maskNames;
			this.notesValue = @notes;
			this.pathNamesValue = @pathNames;
			this.replNamesValue = @replNames;
			this.sordValue = @sord;
			this.sordTypesValue = @sordTypes;
		}		
		
		public EditInfo(EditInfo rhs) : base(rhs)
		{
			this.docTemplatesValue = rhs.docTemplatesValue;
			this.documentValue = rhs.documentValue;
			this.keywordsValue = rhs.keywordsValue;
			this.markerNamesValue = rhs.markerNamesValue;
			this.maskValue = rhs.maskValue;
			this.maskNamesValue = rhs.maskNamesValue;
			this.notesValue = rhs.notesValue;
			this.pathNamesValue = rhs.pathNamesValue;
			this.replNamesValue = rhs.replNamesValue;
			this.sordValue = rhs.sordValue;
			this.sordTypesValue = rhs.sordTypesValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Document template names (Template files for new documents).
		/// </summary>
		public EloixClient.IndexServer.IdName[] docTemplates
		{
			get
			{
				return docTemplatesValue;
			}
			set
			{
				this.docTemplatesValue = value;
				setChangedMember(EditInfoC.mbDocTemplates);
			}
		}
		
		
		/// <summary>
		/// Document or attachment information.
		/// </summary>
		public EloixClient.IndexServer.Document document
		{
			get
			{
				return documentValue;
			}
			set
			{
				this.documentValue = value;
				setChangedMember(EditInfoC.mbDocumentMembers);
			}
		}
		
		
		/// <summary>
		/// Root keywords with first level of keywords below.
		/// </summary>
		/// <remarks>
		/// <p>
		/// <table border="2">
		/// <tr><td rowspan="4">for documents, keyword[.].id is one of: </td><td>KeywordC.KWID_STANDARD_LIST, Standard keyword list</td></tr>
		/// <tr><td>KeywordC.KWID_VERSION, Version number keyword list</td></tr>
		/// <tr><td>KeywordC.KWID_VERSION_COMMENT, Version comment keyword list</td></tr>
		/// <tr><td>Keyword lists of storage mask</td></tr>
		/// <tr><td rowspan="2">for non-documents, keyword[.].id is one of: </td><td>KeywordC.KWID_STANDARD_LIST, Standard keyword list</td></tr>
		/// <tr><td>Keyword lists of storage mask</td></tr>
		/// </table>
		/// </p>
		/// </remarks>
		public EloixClient.IndexServer.Keyword[] keywords
		{
			get
			{
				return keywordsValue;
			}
			set
			{
				this.keywordsValue = value;
				setChangedMember(EditInfoC.mbKeywordMembers);
			}
		}
		
		
		/// <summary>
		/// Marker names (Colours).
		/// </summary>
		public EloixClient.IndexServer.IdName[] markerNames
		{
			get
			{
				return markerNamesValue;
			}
			set
			{
				this.markerNamesValue = value;
				setChangedMember(EditInfoC.mbMarkerNames);
			}
		}
		
		
		/// <summary>
		/// Document mask data of the mask selected in <code>sord</code>.
		/// </summary>
		public EloixClient.IndexServer.DocMask mask
		{
			get
			{
				return maskValue;
			}
			set
			{
				this.maskValue = value;
				setChangedMember(EditInfoC.mbMaskNames);
			}
		}
		
		
		/// <summary>
		/// Storage mask names.
		/// </summary>
		public EloixClient.IndexServer.MaskName[] maskNames
		{
			get
			{
				return maskNamesValue;
			}
			set
			{
				this.maskNamesValue = value;
				setChangedMember(EditInfoC.mbMaskNames);
			}
		}
		
		
		/// <summary>
		/// Notes.
		/// </summary>
		public EloixClient.IndexServer.Note[] notes
		{
			get
			{
				return notesValue;
			}
			set
			{
				this.notesValue = value;
				setChangedMember(EditInfoC.mbNoteMembers);
			}
		}
		
		
		/// <summary>
		/// Storage path names.
		/// </summary>
		public EloixClient.IndexServer.IdName[] pathNames
		{
			get
			{
				return pathNamesValue;
			}
			set
			{
				this.pathNamesValue = value;
				setChangedMember(EditInfoC.mbPathNames);
			}
		}
		
		
		/// <summary>
		/// Replication set names.
		/// </summary>
		public EloixClient.IndexServer.IdName[] replNames
		{
			get
			{
				return replNamesValue;
			}
			set
			{
				this.replNamesValue = value;
				setChangedMember(EditInfoC.mbReplNames);
			}
		}
		
		
		/// <summary>
		/// Indexing information.
		/// </summary>
		public EloixClient.IndexServer.Sord sord
		{
			get
			{
				return sordValue;
			}
			set
			{
				this.sordValue = value;
				setChangedMember(EditInfoC.mbSordTypesJPG);
			}
		}
		
		
		/// <summary>
		/// Sord types (labels, icons, extensions corresponding to Sord.type).
		/// </summary>
		public EloixClient.IndexServer.SordType[] sordTypes
		{
			get
			{
				return sordTypesValue;
			}
			set
			{
				this.sordTypesValue = value;
				setChangedMember(EditInfoC.mbSordTypesJPG);
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.IdName[] docTemplatesValue;

		protected EloixClient.IndexServer.Document documentValue;

		protected EloixClient.IndexServer.Keyword[] keywordsValue;

		protected EloixClient.IndexServer.IdName[] markerNamesValue;

		protected EloixClient.IndexServer.DocMask maskValue;

		protected EloixClient.IndexServer.MaskName[] maskNamesValue;

		protected EloixClient.IndexServer.Note[] notesValue;

		protected EloixClient.IndexServer.IdName[] pathNamesValue;

		protected EloixClient.IndexServer.IdName[] replNamesValue;

		protected EloixClient.IndexServer.Sord sordValue;

		protected EloixClient.IndexServer.SordType[] sordTypesValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 820228328L;		
	} // end class
}  // end namespace
