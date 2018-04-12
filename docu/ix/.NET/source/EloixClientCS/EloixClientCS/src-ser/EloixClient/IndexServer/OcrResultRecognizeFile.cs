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
	/// This class contains the result of an OCR analysis.
	/// </summary>
	public class OcrResultRecognizeFile : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public OcrResultRecognizeFile() {
		}		
		
		public OcrResultRecognizeFile(EloixClient.IndexServer.FileData @textData, String @text, double @skewAngle, int @width, int @height) {
			this.textDataValue = @textData;
			this.textValue = @text;
			this.skewAngleValue = @skewAngle;
			this.widthValue = @width;
			this.heightValue = @height;
		}		
		
		public OcrResultRecognizeFile(OcrResultRecognizeFile rhs) : base(rhs)
		{
			this.textDataValue = rhs.textDataValue;
			this.textValue = rhs.textValue;
			this.skewAngleValue = rhs.skewAngleValue;
			this.widthValue = rhs.widthValue;
			this.heightValue = rhs.heightValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Binary data.
		/// </summary>
		/// <remarks>
		/// This member is set, if {@link OcrInfoRecognizeFile#outputFormat} was set to {@link OcrInfoC#CHAR_AND_RECT}.
		/// </remarks>
		public EloixClient.IndexServer.FileData textData
		{
			get
			{
				return textDataValue;
			}
			set
			{
				this.textDataValue = value;
			}
		}
		
		
		/// <summary>
		/// Recognized text.
		/// </summary>
		/// <remarks>
		/// This member is set, if {@link OcrInfoRecognizeFile#outputFormat} was set to {@link OcrInfoC#TEXT}.
		/// </remarks>
		public String text
		{
			get
			{
				return textValue;
			}
			set
			{
				this.textValue = value;
			}
		}
		
		
		/// <summary>
		/// Skew angle.
		/// </summary>
		/// <remarks>
		/// Only valid if a single page was analyzed, see {@link OcrInfoRecognizeFile#pageNo}.
		/// </remarks>
		public double skewAngle
		{
			get
			{
				return skewAngleValue;
			}
			set
			{
				this.skewAngleValue = value;
			}
		}
		
		
		/// <summary>
		/// Page width.
		/// </summary>
		/// <remarks>
		/// Only valid if a single page was analyzed, see {@link OcrInfoRecognizeFile#pageNo}.
		/// </remarks>
		public int width
		{
			get
			{
				return widthValue;
			}
			set
			{
				this.widthValue = value;
			}
		}
		
		
		/// <summary>
		/// Page height.
		/// </summary>
		/// <remarks>
		/// Only valid if a single page was analyzed, see {@link OcrInfoRecognizeFile#pageNo}.
		/// </remarks>
		public int height
		{
			get
			{
				return heightValue;
			}
			set
			{
				this.heightValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.FileData textDataValue;

		protected String textValue;

		protected double skewAngleValue;

		protected int widthValue;

		protected int heightValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1533562699L;		
	} // end class
}  // end namespace
