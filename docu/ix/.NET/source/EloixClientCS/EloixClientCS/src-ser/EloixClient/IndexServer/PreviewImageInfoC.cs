//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class PreviewImageInfoC : BSerializable
	{
	
		#region Constructors
		
		public PreviewImageInfoC() {
		}		
		
		public PreviewImageInfoC(PreviewImageInfoC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Default dots per inch for scalable vector graphics.
		/// </summary>
		public const int DEFAULT_DPI = 300;

		/// <summary>
		/// Flag that signalizes the server to process preview images in the size of
		/// the original document.
		/// </summary>
		/// <remarks>
		/// In case scalable documents sources like PDF,
		/// {@link PreviewImageInfoC#DEFAULT_DPI} is used.
		/// </remarks>
		public const int SIZE_ORIGINAL = 65536;

		/// <summary>
		/// Flag that signalizes the server to process preview images in a size for
		/// thumbnails.
		/// </summary>
		public const int SIZE_TINY = 131072;

		/// <summary>
		/// Flag that signalizes the server to process preview images in a medium size.
		/// </summary>
		/// <remarks>
		/// Images of this size are optimized in memory usage. They lack readability of
		/// text smaller than 10 points.
		/// </remarks>
		public const int SIZE_MEDIUM = 262144;

		/// <summary>
		/// Flag that signalizes the server to process preview images in a size for
		/// tiny thumbnails.
		/// </summary>
		/// <remarks>
		/// The maximum length of an edge will be 100 pixels.
		/// </remarks>
		public const int SIZE_TINIER = 524288;

		/// <summary>
		/// Flag that signalizes the server to scale down preview images to a size
		/// suitable for most browser's canvas element.
		/// </summary>
		/// <remarks>
		/// Choosing this settings will
		/// scale down only very large images.
		/// </remarks>
		public const int SIZE_LARGE = 1048576;

		#endregion
		
		
		public static readonly long serialVersionUID = 407268655L;		
	} // end class
}  // end namespace
