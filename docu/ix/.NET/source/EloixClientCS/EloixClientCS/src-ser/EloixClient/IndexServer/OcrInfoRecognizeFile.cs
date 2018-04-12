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
	/// This class describes an OCR analysis request.
	/// </summary>
	public class OcrInfoRecognizeFile : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public OcrInfoRecognizeFile() {
		}		
		
		public OcrInfoRecognizeFile(EloixClient.IndexServer.FileData @imageData, String @objId, int @pageNo, int[] @pageNumbers, String[] @recognizeLangs, EloixClient.IndexServer.OcrRect[] @recognizeRects, int @rectUnit, int @timeoutSeconds, int @pageTimeout, int @minCharConfidence, int @replaceChar, int @accuracy, bool @singleColumnMode, int @spaces, int @encoding, int @outputFormat) {
			this.imageDataValue = @imageData;
			this.objIdValue = @objId;
			this.pageNoValue = @pageNo;
			this.pageNumbersValue = @pageNumbers;
			this.recognizeLangsValue = @recognizeLangs;
			this.recognizeRectsValue = @recognizeRects;
			this.rectUnitValue = @rectUnit;
			this.timeoutSecondsValue = @timeoutSeconds;
			this.pageTimeoutValue = @pageTimeout;
			this.minCharConfidenceValue = @minCharConfidence;
			this.replaceCharValue = @replaceChar;
			this.accuracyValue = @accuracy;
			this.singleColumnModeValue = @singleColumnMode;
			this.spacesValue = @spaces;
			this.encodingValue = @encoding;
			this.outputFormatValue = @outputFormat;
		}		
		
		public OcrInfoRecognizeFile(OcrInfoRecognizeFile rhs) : base(rhs)
		{
			this.imageDataValue = rhs.imageDataValue;
			this.objIdValue = rhs.objIdValue;
			this.pageNoValue = rhs.pageNoValue;
			this.pageNumbersValue = rhs.pageNumbersValue;
			this.recognizeLangsValue = rhs.recognizeLangsValue;
			this.recognizeRectsValue = rhs.recognizeRectsValue;
			this.rectUnitValue = rhs.rectUnitValue;
			this.timeoutSecondsValue = rhs.timeoutSecondsValue;
			this.pageTimeoutValue = rhs.pageTimeoutValue;
			this.minCharConfidenceValue = rhs.minCharConfidenceValue;
			this.replaceCharValue = rhs.replaceCharValue;
			this.accuracyValue = rhs.accuracyValue;
			this.singleColumnModeValue = rhs.singleColumnModeValue;
			this.spacesValue = rhs.spacesValue;
			this.encodingValue = rhs.encodingValue;
			this.outputFormatValue = rhs.outputFormatValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Image file content.
		/// </summary>
		/// <remarks>
		/// Either imageData or objId must be set.
		/// </remarks>
		public EloixClient.IndexServer.FileData imageData
		{
			get
			{
				return imageDataValue;
			}
			set
			{
				this.imageDataValue = value;
			}
		}
		
		
		/// <summary>
		/// Object ID of an archived document to be analyzed.
		/// </summary>
		/// <remarks>
		/// Either imageData or objId must be set.
		/// </remarks>
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
		/// Page number.
		/// </summary>
		/// <remarks>
		/// The first page number is 0.
		/// If all pages should be analyzed, set pageNo = -1.
		/// </remarks>
		public int pageNo
		{
			get
			{
				return pageNoValue;
			}
			set
			{
				this.pageNoValue = value;
			}
		}
		
		
		/// <summary>
		/// Array of page numbers which should be analysed by the OCR.
		/// </summary>
		/// <remarks>
		/// The first page number is 0.
		/// The following constants can be used:
		/// {@link OcrInfoC#ALL_PAGES}, {@link OcrInfoC#EVEN_PAGES}, {@link OcrInfoC#ODD_PAGES}
		/// </remarks>
		public int[] pageNumbers
		{
			get
			{
				return pageNumbersValue;
			}
			set
			{
				this.pageNumbersValue = value;
			}
		}
		
		
		/// <summary>
		/// The image data is of this language(s).
		/// </summary>
		/// <remarks>
		/// The supported languages can be requested by a call to {@link IXServicePortIF#processOcr(ClientInfo, OcrInfo)}.
		/// The OcrInfo parameter must have member {@link OcrInfo#queryLanguages} set. Use the internal languages
		/// returned in {@link OcrResult#queryLanguages} for this member.
		/// At least one language must be set. The String is case sensitive.
		/// </remarks>
		public String[] recognizeLangs
		{
			get
			{
				return recognizeLangsValue;
			}
			set
			{
				this.recognizeLangsValue = value;
			}
		}
		
		
		/// <summary>
		/// Constrain recognition to this rectangles.
		/// </summary>
		/// <remarks>
		/// Optional.
		/// </remarks>
		public EloixClient.IndexServer.OcrRect[] recognizeRects
		{
			get
			{
				return recognizeRectsValue;
			}
			set
			{
				this.recognizeRectsValue = value;
			}
		}
		
		
		/// <summary>
		/// Rectangle coordinates are based on this unit.
		/// </summary>
		/// <remarks>
		/// Use on of the constants OcrInfoC.UNIT_*.
		/// Optional.
		/// </remarks>
		public int rectUnit
		{
			get
			{
				return rectUnitValue;
			}
			set
			{
				this.rectUnitValue = value;
			}
		}
		
		
		/// <summary>
		/// Recognition timeout.
		/// </summary>
		/// <remarks>
		/// Cancel recognition if it least longer than this number of seconds.
		/// Optional.
		/// </remarks>
		public int timeoutSeconds
		{
			get
			{
				return timeoutSecondsValue;
			}
			set
			{
				this.timeoutSecondsValue = value;
			}
		}
		
		
		/// <summary>
		/// Recognition timeout for a single page.
		/// </summary>
		/// <remarks>
		/// Cancel recognition if it least longer than this number of seconds.
		/// Optional.
		/// </remarks>
		public int pageTimeout
		{
			get
			{
				return pageTimeoutValue;
			}
			set
			{
				this.pageTimeoutValue = value;
			}
		}
		
		
		/// <summary>
		/// Minimum confidence of character recognition in percent.
		/// </summary>
		/// <remarks>
		/// Characters that are recognized with a lower confidence are replaced by {@link #replaceChar}.
		/// Optional.
		/// </remarks>
		public int minCharConfidence
		{
			get
			{
				return minCharConfidenceValue;
			}
			set
			{
				this.minCharConfidenceValue = value;
			}
		}
		
		
		/// <summary>
		/// Replacement for characters.
		/// </summary>
		/// <remarks>
		/// Characters that are recognized with a lower confidence than {@link #minCharConfidence} are replaced this character.
		/// Optional.
		/// </remarks>
		public int replaceChar
		{
			get
			{
				return replaceCharValue;
			}
			set
			{
				this.replaceCharValue = value;
			}
		}
		
		
		/// <summary>
		/// Recognition accuracy.
		/// </summary>
		/// <remarks>
		/// A value of 0 activates the fast mode, a value of 1 activates the exact mode.
		/// </remarks>
		public int accuracy
		{
			get
			{
				return accuracyValue;
			}
			set
			{
				this.accuracyValue = value;
			}
		}
		
		
		/// <summary>
		/// Disable table recognition.
		/// </summary>
		/// <remarks>
		/// Set this member to true, if the OCR should not try to recognized columns and rows of tables.
		/// Optional.
		/// </remarks>
		public bool singleColumnMode
		{
			get
			{
				return singleColumnModeValue;
			}
			set
			{
				this.singleColumnModeValue = value;
			}
		}
		
		
		/// <summary>
		/// OcrInfoC.NORMAL/TWOSPACES/EXACT
		/// </summary>
		public int spaces
		{
			get
			{
				return spacesValue;
			}
			set
			{
				this.spacesValue = value;
			}
		}
		
		
		/// <summary>
		/// OcrInfoC.ENCODING_UTF8 / _UTF16 / _UTF16LE
		/// </summary>
		public int encoding
		{
			get
			{
				return encodingValue;
			}
			set
			{
				this.encodingValue = value;
			}
		}
		
		
		/// <summary>
		/// Output format.
		/// </summary>
		/// <remarks>
		/// Must be one of the following:
		/// {@link OcrInfoC#TEXT}, {@link OcrInfoC#CHAR_AND_RECT}, {@link OcrInfoC#CHAR_AND_RECT_EX}
		/// {@link OcrInfoC#PDF}, {@link OcrInfoC#XML}
		/// </remarks>
		public int outputFormat
		{
			get
			{
				return outputFormatValue;
			}
			set
			{
				this.outputFormatValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.FileData imageDataValue;

		protected String objIdValue;

		protected int pageNoValue;

		protected int[] pageNumbersValue;

		protected String[] recognizeLangsValue;

		protected EloixClient.IndexServer.OcrRect[] recognizeRectsValue;

		protected int rectUnitValue;

		protected int timeoutSecondsValue;

		protected int pageTimeoutValue;

		protected int minCharConfidenceValue;

		protected int replaceCharValue;

		protected int accuracyValue;

		protected bool singleColumnModeValue;

		protected int spacesValue;

		protected int encodingValue;

		protected int outputFormatValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 701419851L;		
	} // end class
}  // end namespace
