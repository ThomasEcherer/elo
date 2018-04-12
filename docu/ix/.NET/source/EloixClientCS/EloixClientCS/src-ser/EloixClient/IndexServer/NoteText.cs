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
	/// This class conatins additional information for textual notes.
	/// </summary>
	/// <remarks>
	/// NoteText objects can be used in NoteTemplate and Note objects.
	/// </remarks>
	public class NoteText : BSerializable
	{
	
		#region Constructors
		
		public NoteText() {
		}		
		
		public NoteText(EloixClient.IndexServer.FontInfo @fontInfo, String @text) {
			this.fontInfoValue = @fontInfo;
			this.textValue = @text;
		}		
		
		public NoteText(NoteText rhs)
		{
			this.fontInfoValue = rhs.fontInfoValue;
			this.textValue = rhs.textValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Font.
		/// </summary>
		/// <remarks>
		/// This member is null for type NoteC.TYPE_ANNOTATION_NOTE.
		/// </remarks>
		public EloixClient.IndexServer.FontInfo fontInfo
		{
			get
			{
				return fontInfoValue;
			}
			set
			{
				this.fontInfoValue = value;
			}
		}
		
		
		/// <summary>
		/// Stamp text.
		/// </summary>
		/// <remarks>
		/// The maximum length is NoteDataC.lnDesc - 50, if the NoteText object is used in
		/// a Note object. The length for a text of a NoteTemplate object is defined by
		/// NoteTemplateC.lnText
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
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.FontInfo fontInfoValue;

		protected String textValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 669464920L;		
	} // end class
}  // end namespace
