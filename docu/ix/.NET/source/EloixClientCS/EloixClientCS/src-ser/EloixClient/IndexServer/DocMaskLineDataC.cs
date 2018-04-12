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
	/// <p>Bit constants for members of DocMaskLine</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class DocMaskLineDataC : BSerializable
	{
	
		#region Constructors
		
		public DocMaskLineDataC() {
		}		
		
		public DocMaskLineDataC(int @lnName, int @lnKey, int @lnComment, int @lnExternalData, int @lnInternalAcl, int @lnDefaultValue, int @lnServerScriptName, int @lnNameTranslationKey, int @lnCommentTranslationKey, int @lnValidateExpression) {
			this.lnNameValue = @lnName;
			this.lnKeyValue = @lnKey;
			this.lnCommentValue = @lnComment;
			this.lnExternalDataValue = @lnExternalData;
			this.lnInternalAclValue = @lnInternalAcl;
			this.lnDefaultValueValue = @lnDefaultValue;
			this.lnServerScriptNameValue = @lnServerScriptName;
			this.lnNameTranslationKeyValue = @lnNameTranslationKey;
			this.lnCommentTranslationKeyValue = @lnCommentTranslationKey;
			this.lnValidateExpressionValue = @lnValidateExpression;
		}		
		
		public DocMaskLineDataC(DocMaskLineDataC rhs)
		{
			this.lnNameValue = rhs.lnNameValue;
			this.lnKeyValue = rhs.lnKeyValue;
			this.lnCommentValue = rhs.lnCommentValue;
			this.lnExternalDataValue = rhs.lnExternalDataValue;
			this.lnInternalAclValue = rhs.lnInternalAclValue;
			this.lnDefaultValueValue = rhs.lnDefaultValueValue;
			this.lnServerScriptNameValue = rhs.lnServerScriptNameValue;
			this.lnNameTranslationKeyValue = rhs.lnNameTranslationKeyValue;
			this.lnCommentTranslationKeyValue = rhs.lnCommentTranslationKeyValue;
			this.lnValidateExpressionValue = rhs.lnValidateExpressionValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// DB column: linebez
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
		/// DB column: linekey
		/// </summary>
		public int lnKey
		{
			get
			{
				return lnKeyValue;
			}
			set
			{
				this.lnKeyValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: linecomment
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
		/// Column length: External data.
		/// </summary>
		/// <remarks>
		/// DB column: lineext
		/// </remarks>
		public int lnExternalData
		{
			get
			{
				return lnExternalDataValue;
			}
			set
			{
				this.lnExternalDataValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Internal acl.
		/// </summary>
		/// <remarks>
		/// DB column: lineacl
		/// </remarks>
		public int lnInternalAcl
		{
			get
			{
				return lnInternalAclValue;
			}
			set
			{
				this.lnInternalAclValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: This value is assigned to the ObjKey.data element for a new Sord object.
		/// </summary>
		/// <remarks>
		/// DB column: linedefault
		/// </remarks>
		public int lnDefaultValue
		{
			get
			{
				return lnDefaultValueValue;
			}
			set
			{
				this.lnDefaultValueValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: A script at the server can serve as the data source of a dynamic keyword
		/// DB column: linescript
		/// </summary>
		public int lnServerScriptName
		{
			get
			{
				return lnServerScriptNameValue;
			}
			set
			{
				this.lnServerScriptNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Translation-keyword for {@link DocMaskLine#name}.
		/// </summary>
		/// <remarks>
		/// DB column: linebeztrkey
		/// </remarks>
		public int lnNameTranslationKey
		{
			get
			{
				return lnNameTranslationKeyValue;
			}
			set
			{
				this.lnNameTranslationKeyValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: Translation-keyword for {@link DocMaskLine#comment}.
		/// </summary>
		/// <remarks>
		/// DB column: linecommenttrkey
		/// </remarks>
		public int lnCommentTranslationKey
		{
			get
			{
				return lnCommentTranslationKeyValue;
			}
			set
			{
				this.lnCommentTranslationKeyValue = value;
			}
		}
		
		
		/// <summary>
		/// Column length: RegEx to validate user input for entry.
		/// </summary>
		/// <remarks>
		/// DB column: validateexpression
		/// </remarks>
		public int lnValidateExpression
		{
			get
			{
				return lnValidateExpressionValue;
			}
			set
			{
				this.lnValidateExpressionValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// DB column: maskno
		/// </summary>
		public const long mbMaskId = 1L;

		/// <summary>
		/// DB column: mlineno
		/// </summary>
		public const long mbId = 2L;

		/// <summary>
		/// DB column: linetype
		/// </summary>
		public const long mbRawType = 4L;

		/// <summary>
		/// DB column: linebez
		/// </summary>
		public const long mbName = 8L;

		protected int lnNameValue;

		/// <summary>
		/// DB column: linekey
		/// </summary>
		public const long mbKey = 16L;

		protected int lnKeyValue;

		/// <summary>
		/// DB column: linemin
		/// </summary>
		public const long mbMin = 32L;

		/// <summary>
		/// DB column: linemax
		/// </summary>
		public const long mbMax = 64L;

		/// <summary>
		/// DB column: linelkey
		/// </summary>
		public const long mbLKey = 128L;

		/// <summary>
		/// DB column: lineflags
		/// </summary>
		public const long mbRawFlags = 256L;

		/// <summary>
		/// DB column: linecomment
		/// </summary>
		public const long mbComment = 512L;

		protected int lnCommentValue;

		/// <summary>
		/// Member bit: External data.
		/// </summary>
		/// <remarks>
		/// DB column: lineext
		/// </remarks>
		public const long mbExternalData = 1024L;

		protected int lnExternalDataValue;

		/// <summary>
		/// Member bit: Internal acl.
		/// </summary>
		/// <remarks>
		/// DB column: lineacl
		/// </remarks>
		public const long mbInternalAcl = 2048L;

		protected int lnInternalAclValue;

		/// <summary>
		/// Member bit: This value is assigned to the ObjKey.data element for a new Sord object.
		/// </summary>
		/// <remarks>
		/// DB column: linedefault
		/// </remarks>
		public const long mbDefaultValue = 4096L;

		protected int lnDefaultValueValue;

		/// <summary>
		/// Member bit: This value represents the number of the tab, this line has to appear on.
		/// </summary>
		/// <remarks>
		/// DB column: linetab
		/// </remarks>
		public const long mbTabIndex = 8192L;

		/// <summary>
		/// Member bit: A script at the server can serve as the data source of a dynamic keyword
		/// DB column: linescript
		/// </summary>
		public const long mbServerScriptName = 16384L;

		protected int lnServerScriptNameValue;

		/// <summary>
		/// Member bit: Translation-keyword for {@link DocMaskLine#name}.
		/// </summary>
		/// <remarks>
		/// DB column: linebeztrkey
		/// </remarks>
		public const long mbNameTranslationKey = 32768L;

		protected int lnNameTranslationKeyValue;

		/// <summary>
		/// Member bit: Translation-keyword for {@link DocMaskLine#comment}.
		/// </summary>
		/// <remarks>
		/// DB column: linecommenttrkey
		/// </remarks>
		public const long mbCommentTranslationKey = 65536L;

		protected int lnCommentTranslationKeyValue;

		/// <summary>
		/// Member bit: RegEx to validate user input for entry.
		/// </summary>
		/// <remarks>
		/// DB column: validateexpression
		/// </remarks>
		public const long mbValidateExpression = 131072L;

		protected int lnValidateExpressionValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 262143L;

		#endregion
		
		
		public static readonly long serialVersionUID = 1178569423L;		
	} // end class
}  // end namespace
