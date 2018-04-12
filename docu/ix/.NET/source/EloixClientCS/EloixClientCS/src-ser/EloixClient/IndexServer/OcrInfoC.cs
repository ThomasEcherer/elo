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
	/// Constants for OCR processing.
	/// </summary>
	public class OcrInfoC : BSerializable
	{
	
		#region Constructors
		
		public OcrInfoC() {
		}		
		
		public OcrInfoC(OcrInfoC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// PDF output.
		/// </summary>
		/// <remarks>
		/// OCR will convert the output in a PDF format.
		/// </remarks>
		public const int PDF = 4;

		/// <summary>
		/// Text output.
		/// </summary>
		/// <remarks>
		/// The OCR result is a UTF-16LE character stream.
		/// </remarks>
		public const int TEXT = 6;

		/// <summary>
		/// XML output.
		/// </summary>
		/// <remarks>
		/// The OCR result is a xml style layout.
		/// </remarks>
		public const int XML = 7;

		/// <summary>
		/// Compute character positions.
		/// </summary>
		/// <remarks>
		/// The OCR result is a binary stream of subsequent records of this layout:
		/// <br/>
		/// <table>
		/// <tr><td>UTF-16 Character</td><td>2 Bytes</td></tr>
		/// <tr><td>Horizontal position of upper left corner</td><td>4 Bytes (Integer)</td></tr>
		/// <tr><td>Vertical position of upper left corner</td><td>4 Bytes (Integer)</td></tr>
		/// <tr><td>Horizontal position of bottom right corner</td><td>4 Bytes (Integer)</td></tr>
		/// <tr><td>Vertical position of bottom right corner</td><td>4 Bytes (Integer)</td></tr>
		/// <tr><td>Confidence in percent</td><td>4 Bytes (Integer)</td></tr>
		/// <tr><td>Original UTF-16 Character</td><td>2 Bytes</td></tr>
		/// </table>
		/// <p>
		/// The character and integer byte order is Little Endian.
		/// </p><p>
		/// If the recognition confidence is lower than {@link OcrInfoRecognizeFile#minCharConfidence},
		/// the UTF-16 character is equal to {@link OcrInfoRecognizeFile#replaceChar}.
		/// </p><p>
		/// The rectangle coordinates are measured in points. The vertical axis points to the bottom in positive direction.
		/// </remarks>
		public const int CHAR_AND_RECT = 9;

		/// <summary>
		/// Compute character positions.
		/// </summary>
		/// <remarks>
		/// The OCR result is a binary stream as defined in {@link #CHAR_AND_RECT}
		/// prefixed by a header of this layout:
		/// <table>
		/// <tr><td>Magic</td><td>4 Bytes (Integer)</td></tr>
		/// <tr><td>Version</td><td>4 Bytes (Integer)</td></tr>
		/// <tr><td>Skew Angle</td><td>8 Bytes (Double)</td></tr>
		/// <tr><td>Width</td><td>4 Bytes (Integer)</td></tr>
		/// <tr><td>Height</td><td>4 Bytes (Integer)</td></tr>
		/// </table>
		/// The value of Magic is 0x52434F45.
		/// The value of Version is 1.
		/// The Integer and Double byte order is Little Endian.
		/// The Double value format is IEEE 754.
		/// </remarks>
		public const int CHAR_AND_RECT_EX = 12;

		/// <summary>
		/// Compute character positions and return XML format.
		/// </summary>
		public const int CHAR_AND_RECT_XML = 10;

		public const int MESSAGES_LANGUAGE_ENGLISH = 0;

		public const int MESSAGES_LANGUAGE_RUSSIAN = 1;

		public const int MESSAGES_LANGUAGE_GERMAN = 2;

		public const int MESSAGES_LANGUAGE_FRENCH = 3;

		public const int MESSAGES_LANGUAGE_UKRAINIAN = 4;

		public const int MESSAGES_LANGUAGE_SPANISH = 5;

		public const int MESSAGES_LANGUAGE_ITALIAN = 6;

		public const int MESSAGES_LANGUAGE_DUTCHSTANDARD = 7;

		public const int MESSAGES_LANGUAGE_PORTUGUESE = 8;

		public const int MESSAGES_LANGUAGE_SLOVAK = 9;

		public const int MESSAGES_LANGUAGE_POLISH = 10;

		public const int MESSAGES_LANGUAGE_CZECH = 11;

		public const int MESSAGES_LANGUAGE_HUNGARIAN = 12;

		public const int MESSAGES_LANGUAGE_LITHUANIAN = 13;

		public const int MESSAGES_LANGUAGE_LATVIAN = 14;

		public const int MESSAGES_LANGUAGE_ESTONIAN = 15;

		public const int MESSAGES_LANGUAGE_BULGARIAN = 16;

		public const int UNIT_POINT = 1;

		public const int UNIT_MILLIMETER = 2;

		public const int UNIT_INCH = 3;

		public const int UNIT_PER_THOUSAND = 4;

		/// <summary>
		/// Used in SingleCoulmnMode.
		/// </summary>
		/// <remarks>
		/// All words are separated by one blank.
		/// </remarks>
		public const int SPACES_NORMAL = 1;

		/// <summary>
		/// Used in SingleCoulmnMode.
		/// </summary>
		/// <remarks>
		/// If the words are separated by a larger distance, a second blank is inserted.
		/// </remarks>
		public const int SPACES_TWOSPACES = 2;

		/// <summary>
		/// Used in SingleCoulmnMode.
		/// </summary>
		/// <remarks>
		/// The OCR tries to insert the correct number of blanks.
		/// </remarks>
		public const int SPACES_EXACT = 3;

		/// <summary>
		/// OCR will process all pages of the given document.
		/// </summary>
		public const int ALL_PAGES = -1;

		/// <summary>
		/// Internal Use only.
		/// </summary>
		/// <remarks>
		/// OCR will process all even pages of the given document.
		/// </remarks>
		public const int EVEN_PAGES = -2;

		/// <summary>
		/// Internal Use only.
		/// </summary>
		/// <remarks>
		/// OCR will process all odd pages of the given document.
		/// </remarks>
		public const int ODD_PAGES = -3;

		public const int ENCODING_UTF8 = 1;

		public const int ENCODING_UTF16 = 2;

		public const int ENCODING_UTF16LE = 3;

		#endregion
		
		
		public static readonly long serialVersionUID = 1068350778L;		
	} // end class
}  // end namespace
