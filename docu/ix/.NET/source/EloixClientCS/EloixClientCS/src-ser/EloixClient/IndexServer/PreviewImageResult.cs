//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class PreviewImageResult : BSerializable
	{
	
		#region Constructors
		
		public PreviewImageResult() {
		}		
		
		public PreviewImageResult(IList<String> @urls, int @dpi, int @dimensionWidth, int @dimensionHeight, int @progress, int @progressMax, String @statusMessage, int @pages) {
			this.urlsValue = @urls;
			this.dpiValue = @dpi;
			this.dimensionWidthValue = @dimensionWidth;
			this.dimensionHeightValue = @dimensionHeight;
			this.progressValue = @progress;
			this.progressMaxValue = @progressMax;
			this.statusMessageValue = @statusMessage;
			this.pagesValue = @pages;
		}		
		
		public PreviewImageResult(PreviewImageResult rhs)
		{
			this.urlsValue = rhs.urlsValue;
			this.dpiValue = rhs.dpiValue;
			this.dimensionWidthValue = rhs.dimensionWidthValue;
			this.dimensionHeightValue = rhs.dimensionHeightValue;
			this.progressValue = rhs.progressValue;
			this.progressMaxValue = rhs.progressMaxValue;
			this.statusMessageValue = rhs.statusMessageValue;
			this.pagesValue = rhs.pagesValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// List of URLs pointing to the requested preview images.
		/// </summary>
		/// <remarks>
		/// The URL at the first
		/// index in the list points to the lexicographic ordered first requested page.
		/// </remarks>
		public IList<String> urls
		{
			get
			{
				return urlsValue;
			}
			set
			{
				this.urlsValue = value;
			}
		}
		
		
		/// <summary>
		/// Dots per inch of the requested preview images.
		/// </summary>
		/// <remarks>
		/// If the document source is a
		/// multi-page file, this value holds for every requested pages.
		/// </remarks>
		public int dpi
		{
			get
			{
				return dpiValue;
			}
			set
			{
				this.dpiValue = value;
			}
		}
		
		
		/// <summary>
		/// Width of first page.
		/// </summary>
		/// <remarks>
		/// Use this value to get an idea about the dimensions of
		/// the preview image in general. While this value is exact for the first page,
		/// following pages may have different dimension (e.g. different orientation,
		/// image as a whole page in a PDF document, ...)
		/// </remarks>
		public int dimensionWidth
		{
			get
			{
				return dimensionWidthValue;
			}
			set
			{
				this.dimensionWidthValue = value;
			}
		}
		
		
		/// <summary>
		/// Height of the first page.
		/// </summary>
		/// <remarks>
		/// Please consider the hints at
		/// {@link PreviewImageResult#dimensionWidth} with respect to multi-page
		/// documents.
		/// </remarks>
		public int dimensionHeight
		{
			get
			{
				return dimensionHeightValue;
			}
			set
			{
				this.dimensionHeightValue = value;
			}
		}
		
		
		/// <summary>
		/// Current progress of processing at the server.
		/// </summary>
		/// <remarks>
		/// Processing is finished at
		/// server side when this value equals {@link PreviewImageResult#progressMax}.
		/// </remarks>
		public int progress
		{
			get
			{
				return progressValue;
			}
			set
			{
				this.progressValue = value;
			}
		}
		
		
		/// <summary>
		/// Estimated value about the workload at the server.
		/// </summary>
		/// <remarks>
		/// There is a chance that
		/// the server is finished with the processing of the request when progress
		/// reaches this estimated value. In repeated requests progresMax can increase
		/// in comparison to calls in earlier times.
		/// </remarks>
		public int progressMax
		{
			get
			{
				return progressMaxValue;
			}
			set
			{
				this.progressMaxValue = value;
			}
		}
		
		
		/// <summary>
		/// Status message about the current processing of preview images at the
		/// server.
		/// </summary>
		public String statusMessage
		{
			get
			{
				return statusMessageValue;
			}
			set
			{
				this.statusMessageValue = value;
			}
		}
		
		
		/// <summary>
		/// Number of pages.
		/// </summary>
		public int pages
		{
			get
			{
				return pagesValue;
			}
			set
			{
				this.pagesValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected IList<String> urlsValue;

		protected int dpiValue;

		protected int dimensionWidthValue;

		protected int dimensionHeightValue;

		protected int progressValue;

		protected int progressMaxValue;

		protected String statusMessageValue;

		protected int pagesValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 661820173L;		
	} // end class
}  // end namespace
