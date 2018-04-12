//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class DocVersionC : BSerializable
	{
	
		#region Constructors
		
		public DocVersionC() {
		}		
		
		public DocVersionC(int @lnComment, int @lnVersion, int @lnExt) {
			this.lnCommentValue = @lnComment;
			this.lnVersionValue = @lnVersion;
			this.lnExtValue = @lnExt;
		}		
		
		public DocVersionC(DocVersionC rhs)
		{
			this.lnCommentValue = rhs.lnCommentValue;
			this.lnVersionValue = rhs.lnVersionValue;
			this.lnExtValue = rhs.lnExtValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Length of version comment.
		/// </summary>
		public int lnComment
		{
			get
			{
				return lnCommentValue;
			}
			set
			{
				this.lnCommentValue = value;
			}
		}
		
		
		/// <summary>
		/// Length of version number (like 1.0).
		/// </summary>
		public int lnVersion
		{
			get
			{
				return lnVersionValue;
			}
			set
			{
				this.lnVersionValue = value;
			}
		}
		
		
		/// <summary>
		/// Length of file extension.
		/// </summary>
		public int lnExt
		{
			get
			{
				return lnExtValue;
			}
			set
			{
				this.lnExtValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// This value should be set in DocVersion.uploadResult, if
		/// preview creation fails.
		/// </summary>
		public const String UPLOAD_RESULT_ERROR = "ERROR";

		/// <summary>
		/// URL parameter offset.
		/// </summary>
		/// <remarks>
		/// Used to read a file at a particular offset.
		/// Do not position offset after the length of the file.
		/// Example: String readUrl = docVersion.url + "&" + URL_PARAM_OFFSET + "=" + 123;
		/// </remarks>
		public const String URL_PARAM_OFFSET = "offset";

		/// <summary>
		/// URL parameter length.
		/// </summary>
		/// <remarks>
		/// Used to read length bytes from a file.
		/// Do not read more bytes than the legnth of the file.
		/// Example: String readUrl = docVersion.url + "&" + URL_PARAM_LENGTH + "=" + 123;
		/// </remarks>
		public const String URL_PARAM_LENGTH = "length";

		/// <summary>
		/// URL parameter create date.
		/// </summary>
		/// <remarks>
		/// Used to set the create date of the file.
		/// ISO date in UTC timezone.
		/// Example: String writeUrl = docVersion.url + "&" + URL_PARAM_CREATE_DATE + "=" + 20010203040506;
		/// </remarks>
		public const String URL_PARAM_CREATE_DATE = "createdate";

		/// <summary>
		/// URL parameter last write date.
		/// </summary>
		/// <remarks>
		/// Used to set the last write time of the file.
		/// ISO date in UTC timezone.
		/// Example: String writeUrl = docVersion.url + "&" + URL_PARAM_LAST_UPDATE + "=" + 20010203040506;
		/// </remarks>
		public const String URL_PARAM_LAST_UPDATE = "lastupdate";

		/// <summary>
		/// URL parameter last access date.
		/// </summary>
		/// <remarks>
		/// Used to set the last access time of the file.
		/// ISO date in UTC timezone.
		/// Example: String writeUrl = docVersion.url + "&" + URL_PARAM_LAST_ACCESS + "=" + 20010203040506;
		/// </remarks>
		public const String URL_PARAM_LAST_ACCESS = "lastaccess";

		/// <summary>
		/// Document versions marked with this flag cannot be deleted.
		/// </summary>
		public const int FLAG_MILESTONE = 1;

		public const int TYPE_DOCVERSION = 1;

		public const int TYPE_ATTACHMENT = 2;

		protected int lnCommentValue;

		protected int lnVersionValue;

		protected int lnExtValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 615288749L;		
	} // end class
}  // end namespace
