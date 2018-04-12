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
	/// <p>Constants for notes.
	/// </summary>
	/// <remarks>
	/// </p>
	/// </remarks>
	public class NoteC : EloixClient.IndexServer.NoteDataC, BSerializable
	{
	
		#region Constructors
		
		public NoteC() {
		}		
		
		public NoteC(NoteC rhs) : base(rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Member objId.
		/// </summary>
		public const long mbObjId = 2L;

		/// <summary>
		/// Member lockId
		/// </summary>
		public const long mbLockId = 128L;

		/// <summary>
		/// Member noteText
		/// </summary>
		public const long mbNoteText = 512L;

		/// <summary>
		/// Member noteImage
		/// </summary>
		public const long mbNoteImage = 512L;

		/// <summary>
		/// Member noteFreehand
		/// </summary>
		public const long mbNoteFreehand = 512L;

		/// <summary>
		/// All members.
		/// </summary>
		public readonly static EloixClient.IndexServer.NoteZ mbAll = new NoteZ(524287L);

		/// <summary>
		/// All members but without note text.
		/// </summary>
		public readonly static EloixClient.IndexServer.NoteZ mbNoDesc = new NoteZ(523775L);

		/// <summary>
		/// Only remove or set lock.
		/// </summary>
		public readonly static EloixClient.IndexServer.NoteZ mbOnlyLock = new NoteZ(0L);

		public const long mbDeleted = 4096L;

		public const long mbAclItems = 32768L;

		public const long mbCreateDateIso = 256L;

		/// <summary>
		/// Note type: highlighting rectange (filled) on the document.
		/// </summary>
		/// <remarks>
		/// <p>If the note is assigned the colour 0xC0C0C0 the note will be interpreted by ELODM. In this case
		/// a black rectangle will painted on the document, using the note coordinates supplied,
		/// if the note ACL does not contain sufficient read access rights for the current user.
		/// This allows document contact to be blacked out for certain users
		/// The document must be a graphic based document, eg. tiff, bmp etc.</p>
		/// </remarks>
		public const int TYPE_ANNOTATION_MARKER = 10;

		/// <summary>
		/// Use TYPE_ANNOTATION_MARKER
		/// </summary>
		public const int TYPE_ANOTEW_MARKER = 10;

		/// <summary>
		/// Note type: annotation text
		/// </summary>
		public const int TYPE_ANNOTATION_NOTE = 11;

		/// <summary>
		/// Use TYPE_ANNOTATION_NOTE
		/// </summary>
		public const int TYPE_ANOTEWG_NOTE = 11;

		/// <summary>
		/// Note type: freehand line.
		/// </summary>
		public const int TYPE_ANNOTATION_FREEHAND = 12;

		/// <summary>
		/// Note type: reserved
		/// </summary>
		public const int TYPE_ANNOTATION_RECTANGLE = 13;

		/// <summary>
		/// Note type: draws a filled coloured box on the document, over the existing document.
		/// </summary>
		public const int TYPE_ANNOTATION_FILLEDRECTANGLE = 14;

		/// <summary>
		/// Note type: draws a hollow rectangle (frame) on a document.
		/// </summary>
		public const int TYPE_ANNOTATION_HOLLOWRECTANGLE = 15;

		/// <summary>
		/// Note type: reserved
		/// </summary>
		public const int TYPE_ANNOTATION_LINE = 16;

		/// <summary>
		/// Annotation with text but without a rectangle.
		/// </summary>
		/// <remarks>
		/// <p>The font size in the client application has to be computed by FontInfo.height * 3.7 * resolution_in_dpi/100 </p>
		/// </remarks>
		public const int TYPE_ANNOTATION_TEXT = 17;

		/// <summary>
		/// Note type: reserved
		/// </summary>
		public const int TYPE_ANNOTATION_FILETEXT = 18;

		/// <summary>
		/// Adds a stamp, such as a received date for example, to a document.
		/// </summary>
		/// <remarks>
		/// <p>The font size in the client application has to be computed by FontInfo.height * 3.7 * resolution_in_dpi/100 </p>
		/// </remarks>
		public const int TYPE_ANNOTATION_STAMP = 19;

		/// <summary>
		/// Draws a filled rectangular box on a document and displays text in the box.
		/// </summary>
		public const int TYPE_ANNOTATION_NOTE_WITHFONT = 20;

		/// <summary>
		/// Note type: horizontal line.
		/// </summary>
		public const int TYPE_ANNOTATION_HORIZONTAL_LINE = 21;

		/// <summary>
		/// Note type: strike out text
		/// </summary>
		public const int TYPE_ANNOTATION_STRIKEOUT = 22;

		/// <summary>
		/// Note type: adds a stamp, such as a received date for example, to a document.
		/// </summary>
		/// <remarks>
		/// <p>The font size in the client application has to be computed by FontInfo.height * 2.2 * resolution_in_dpi/100 </p>
		/// </remarks>
		public const int TYPE_ANNOTATION_STAMP_NEW = 23;

		/// <summary>
		/// Note type: needed in FindByNotes to indicate typeless filtering
		/// </summary>
		public const int TYPE_NONE = 0;

		/// <summary>
		/// Note type: standard yellow note
		/// </summary>
		public const int TYPE_NORMAL = 1;

		/// <summary>
		/// Note type: standard green note
		/// </summary>
		public const int TYPE_PERSONAL = 2;

		/// <summary>
		/// Note type: standard red note
		/// </summary>
		public const int TYPE_STAMP = 3;

		/// <summary>
		/// Note type: standard ACL
		/// </summary>
		public const int TYPE_NORMAL_ACL = 7;

		/// <summary>
		/// This color is used for notes of type TYPE_ANNOTATION_MARKER
		/// to specify a black rectangle that is painted on the document
		/// by Document Manager.
		/// </summary>
		public const int COLOR_ANNOTATION_MARKER_DM = 12632256;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1319955249L;		
	} // end class
}  // end namespace
