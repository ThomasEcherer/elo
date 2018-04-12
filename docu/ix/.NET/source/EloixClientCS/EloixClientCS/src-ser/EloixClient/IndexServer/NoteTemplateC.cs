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
	/// Constants for class NoteTemplate
	/// </summary>
	public class NoteTemplateC : BSerializable
	{
	
		#region Constructors
		
		public NoteTemplateC() {
		}		
		
		public NoteTemplateC(int @lnName, int @lnText) {
			this.lnNameValue = @lnName;
			this.lnTextValue = @lnText;
		}		
		
		public NoteTemplateC(NoteTemplateC rhs)
		{
			this.lnNameValue = rhs.lnNameValue;
			this.lnTextValue = rhs.lnTextValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Length of note template name.
		/// </summary>
		public int lnName
		{
			get
			{
				return lnNameValue;
			}
			set
			{
				this.lnNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Length of text in class NoteText.
		/// </summary>
		public int lnText
		{
			get
			{
				return lnTextValue;
			}
			set
			{
				this.lnTextValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Member bit: id
		/// </summary>
		public const long mbId = 1L;

		/// <summary>
		/// Member bit: name
		/// </summary>
		public const long mbName = 2L;

		/// <summary>
		/// Member bit: UserId
		/// </summary>
		public const long mbUserId = 4L;

		/// <summary>
		/// Member bit: noteText
		/// </summary>
		public const long mbNoteText = 8L;

		/// <summary>
		/// Member bit: noteImage
		/// </summary>
		public const long mbNoteImage = 16L;

		/// <summary>
		/// Member bit: acl, aclItems
		/// </summary>
		public const long mbAcl = 32L;

		/// <summary>
		/// Member bit: all members
		/// </summary>
		public const long mbAllMembers = 63L;

		/// <summary>
		/// Elementselector: mbId
		/// </summary>
		public readonly static EloixClient.IndexServer.NoteTemplateZ mbMin = new NoteTemplateZ(1L);

		/// <summary>
		/// Elementselector: mbAllMembers
		/// </summary>
		public readonly static EloixClient.IndexServer.NoteTemplateZ mbAll = new NoteTemplateZ(63L);

		/// <summary>
		/// Placeholder for user name.
		/// </summary>
		/// <remarks>
		/// This constant can be used in NoteTemplate.textInfo.text as
		/// a placeholder for the current user name.
		/// </remarks>
		public const String PLACEHOLDER_USERNAME = "%u";

		/// <summary>
		/// Placeholder for date.
		/// </summary>
		/// <remarks>
		/// This constant can be used in NoteTemplate.textInfo.text as
		/// a placeholder for the current date.
		/// </remarks>
		public const String PLACEHOLDER_DATE = "%x";

		/// <summary>
		/// Placeholder for time.
		/// </summary>
		/// <remarks>
		/// This constant can be used in NoteTemplate.textInfo.text as
		/// a placeholder for the current time.
		/// </remarks>
		public const String PLACEHOLDER_TIME = "%X";

		/// <summary>
		/// Read/write note template visible for all users
		/// </summary>
		public const String USERID_ALL = "2147483647";

		/// <summary>
		/// Separates the values in the raw data representation.
		/// </summary>
		public const String RAW_ITEM_SEPARATOR = "\u00c3\u00bd\u00c3\u00bd\u00c3\u00bd";

		/// <summary>
		/// Separates the values of the subitems in the raw data representation.
		/// </summary>
		public const String RAW_SUBITEM_SEPARATOR = ",";

		/// <summary>
		/// Separates the values of the name and text in the raw data representation.
		/// </summary>
		public const String RAW_STAMPINFO_SEPARATOR = "(,)";

		protected int lnNameValue;

		protected int lnTextValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 240897408L;		
	} // end class
}  // end namespace
