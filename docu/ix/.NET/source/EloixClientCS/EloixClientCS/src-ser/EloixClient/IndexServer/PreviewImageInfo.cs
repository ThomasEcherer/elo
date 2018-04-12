//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class PreviewImageInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public PreviewImageInfo() {
		}		
		
		public PreviewImageInfo(String @objectId, String @documentId, int @startPage, int @endPage, int @previewSize, bool @processDocument, bool @renderAnnotations, bool @renderAnnotationsOnly, bool @renderAnnotationsData) {
			this.objectIdValue = @objectId;
			this.documentIdValue = @documentId;
			this.startPageValue = @startPage;
			this.endPageValue = @endPage;
			this.previewSizeValue = @previewSize;
			this.processDocumentValue = @processDocument;
			this.renderAnnotationsValue = @renderAnnotations;
			this.renderAnnotationsOnlyValue = @renderAnnotationsOnly;
			this.renderAnnotationsDataValue = @renderAnnotationsData;
		}		
		
		public PreviewImageInfo(PreviewImageInfo rhs) : base(rhs)
		{
			this.objectIdValue = rhs.objectIdValue;
			this.documentIdValue = rhs.documentIdValue;
			this.startPageValue = rhs.startPageValue;
			this.endPageValue = rhs.endPageValue;
			this.previewSizeValue = rhs.previewSizeValue;
			this.processDocumentValue = rhs.processDocumentValue;
			this.renderAnnotationsValue = rhs.renderAnnotationsValue;
			this.renderAnnotationsOnlyValue = rhs.renderAnnotationsOnlyValue;
			this.renderAnnotationsDataValue = rhs.renderAnnotationsDataValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// <p>
		/// ID of the objects to query preview images for.
		/// </summary>
		/// <remarks>
		/// The ID must point to a
		/// document. Otherwise, an exception is thrown.
		/// </p>
		/// </remarks>
		public String objectId
		{
			get
			{
				return objectIdValue;
			}
			set
			{
				this.objectIdValue = value;
			}
		}
		
		
		/// <summary>
		/// <p>
		/// Id of the document(-version) to query preview images for.
		/// </summary>
		/// <remarks>
		/// If set,
		/// <code>objectId</code> is ignored.
		/// </p>
		/// </remarks>
		public String documentId
		{
			get
			{
				return documentIdValue;
			}
			set
			{
				this.documentIdValue = value;
			}
		}
		
		
		/// <summary>
		/// <p>
		/// First page number of the document to process a preview image for.
		/// </summary>
		/// <remarks>
		/// The
		/// number of the first page of a document is 1. If this value is &le; 0, 1 is
		/// assumed.
		/// </p>
		/// </remarks>
		public int startPage
		{
			get
			{
				return startPageValue;
			}
			set
			{
				this.startPageValue = value;
			}
		}
		
		
		/// <summary>
		/// <p>
		/// Last page number of the document to process a preview image for.
		/// </summary>
		/// <remarks>
		/// If this
		/// value is &le; 0, all pages of the document &ge; startPage are process. If 0
		/// &lt; endPage &le; startPage holds, only the startPage will be processed.
		/// </p>
		/// </remarks>
		public int endPage
		{
			get
			{
				return endPageValue;
			}
			set
			{
				this.endPageValue = value;
			}
		}
		
		
		/// <summary>
		/// Desired size of the preview images.
		/// </summary>
		/// <remarks>
		/// Valid values are defined in
		/// {@link PreviewImageInfoC}.
		/// </remarks>
		public int previewSize
		{
			get
			{
				return previewSizeValue;
			}
			set
			{
				this.previewSizeValue = value;
			}
		}
		
		
		/// <summary>
		/// <p>
		/// If processDocument is true, not only the URLs for each page are generated
		/// but also preview images are processed for the pages (startPage+1) to
		/// endPage in the background.
		/// </summary>
		/// <remarks>
		/// </p>
		/// </remarks>
		public bool processDocument
		{
			get
			{
				return processDocumentValue;
			}
			set
			{
				this.processDocumentValue = value;
			}
		}
		
		
		/// <summary>
		/// <p>
		/// Enables rendering of annotations.
		/// </summary>
		/// <remarks>
		/// If <code>renderAnnotations</code> is
		/// <b>true</b>, the preview images will also contain the annotations. If the
		/// preview images should contain the annotations but not the preview of the
		/// document page itself, also set <code>renderOnlyAnnotations</code> to
		/// <b>true</b>.
		/// </p>
		/// </remarks>
		public bool renderAnnotations
		{
			get
			{
				return renderAnnotationsValue;
			}
			set
			{
				this.renderAnnotationsValue = value;
			}
		}
		
		
		/// <summary>
		/// <p>
		/// Does only has an effect, if <code>renderAnnotations</code> is <b>true</b>.
		/// </summary>
		/// <remarks>
		/// If set to <b>true</b> the annotations will be rendered but the rendering of
		/// document pages will be omitted.
		/// </p>
		/// </remarks>
		public bool renderAnnotationsOnly
		{
			get
			{
				return renderAnnotationsOnlyValue;
			}
			set
			{
				this.renderAnnotationsOnlyValue = value;
			}
		}
		
		
		/// <summary>
		/// <p>
		/// Does only has an effect, if <code>renderAnnotations</code> is <b>true</b>.
		/// </summary>
		/// <remarks>
		/// If set to <b>true</b> there will be details rendered near the annotations.
		/// Details are the annotation's author and create date.
		/// </p>
		/// </remarks>
		public bool renderAnnotationsData
		{
			get
			{
				return renderAnnotationsDataValue;
			}
			set
			{
				this.renderAnnotationsDataValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String objectIdValue;

		protected String documentIdValue;

		protected int startPageValue;

		protected int endPageValue;

		protected int previewSizeValue;

		protected bool processDocumentValue;

		protected bool renderAnnotationsValue;

		protected bool renderAnnotationsOnlyValue;

		protected bool renderAnnotationsDataValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1006046685L;		
	} // end class
}  // end namespace
