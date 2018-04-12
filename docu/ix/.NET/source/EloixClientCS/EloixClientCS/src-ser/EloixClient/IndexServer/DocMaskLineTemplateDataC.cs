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
	/// <p>Bit constants for members of DocMaskLineTemplate</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class DocMaskLineTemplateDataC : BSerializable
	{
	
		#region Constructors
		
		public DocMaskLineTemplateDataC() {
		}		
		
		public DocMaskLineTemplateDataC(int @lnName, int @lnKey, int @lnComment, int @lnDefaultValue, int @lnExternalData, int @lnInternalAcl, int @lnCommentTranslationKey, int @lnNameTranslationKey, int @lnServerScriptName, int @lnTStamp, int @lnTStampSync, int @lnValidateExpression) {
			this.lnNameValue = @lnName;
			this.lnKeyValue = @lnKey;
			this.lnCommentValue = @lnComment;
			this.lnDefaultValueValue = @lnDefaultValue;
			this.lnExternalDataValue = @lnExternalData;
			this.lnInternalAclValue = @lnInternalAcl;
			this.lnCommentTranslationKeyValue = @lnCommentTranslationKey;
			this.lnNameTranslationKeyValue = @lnNameTranslationKey;
			this.lnServerScriptNameValue = @lnServerScriptName;
			this.lnTStampValue = @lnTStamp;
			this.lnTStampSyncValue = @lnTStampSync;
			this.lnValidateExpressionValue = @lnValidateExpression;
		}		
		
		public DocMaskLineTemplateDataC(DocMaskLineTemplateDataC rhs)
		{
			this.lnNameValue = rhs.lnNameValue;
			this.lnKeyValue = rhs.lnKeyValue;
			this.lnCommentValue = rhs.lnCommentValue;
			this.lnDefaultValueValue = rhs.lnDefaultValueValue;
			this.lnExternalDataValue = rhs.lnExternalDataValue;
			this.lnInternalAclValue = rhs.lnInternalAclValue;
			this.lnCommentTranslationKeyValue = rhs.lnCommentTranslationKeyValue;
			this.lnNameTranslationKeyValue = rhs.lnNameTranslationKeyValue;
			this.lnServerScriptNameValue = rhs.lnServerScriptNameValue;
			this.lnTStampValue = rhs.lnTStampValue;
			this.lnTStampSyncValue = rhs.lnTStampSyncValue;
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
		/// DB column: linedefault
		/// </summary>
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
		/// DB column: lineext
		/// </summary>
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
		/// DB column: lineacl
		/// </summary>
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
		/// DB column: linecommenttrkey
		/// </summary>
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
		/// DB column: linebeztrkey
		/// </summary>
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
		/// DB column: linetstamp
		/// </summary>
		public int lnTStamp
		{
			get
			{
				return lnTStampValue;
			}
			set
			{
				this.lnTStampValue = value;
			}
		}
		
		
		/// <summary>
		/// DB column: linetstampsync
		/// </summary>
		public int lnTStampSync
		{
			get
			{
				return lnTStampSyncValue;
			}
			set
			{
				this.lnTStampSyncValue = value;
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
		/// DB column: mlineno
		/// </summary>
		public const long mbId = 1L;

		/// <summary>
		/// DB column: linetype
		/// </summary>
		public const long mbRawType = 2L;

		/// <summary>
		/// DB column: linebez
		/// </summary>
		public const long mbName = 4L;

		protected int lnNameValue;

		/// <summary>
		/// DB column: linekey
		/// </summary>
		public const long mbKey = 8L;

		protected int lnKeyValue;

		/// <summary>
		/// DB column: linemin
		/// </summary>
		public const long mbMin = 16L;

		/// <summary>
		/// DB column: linemax
		/// </summary>
		public const long mbMax = 32L;

		/// <summary>
		/// DB column: linelock
		/// </summary>
		public const long mbLockId = 64L;

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
		/// DB column: linedefault
		/// </summary>
		public const long mbDefaultValue = 1024L;

		protected int lnDefaultValueValue;

		/// <summary>
		/// DB column: lineext
		/// </summary>
		public const long mbExternalData = 2048L;

		protected int lnExternalDataValue;

		/// <summary>
		/// DB column: lineacl
		/// </summary>
		public const long mbInternalAcl = 4096L;

		protected int lnInternalAclValue;

		/// <summary>
		/// DB column: linecommenttrkey
		/// </summary>
		public const long mbCommentTranslationKey = 8192L;

		protected int lnCommentTranslationKeyValue;

		/// <summary>
		/// DB column: linebeztrkey
		/// </summary>
		public const long mbNameTranslationKey = 16384L;

		protected int lnNameTranslationKeyValue;

		/// <summary>
		/// DB column: linescript
		/// </summary>
		public const long mbServerScriptName = 32768L;

		protected int lnServerScriptNameValue;

		/// <summary>
		/// DB column: linetstamp
		/// </summary>
		public const long mbTStamp = 65536L;

		protected int lnTStampValue;

		/// <summary>
		/// DB column: linetstampsync
		/// </summary>
		public const long mbTStampSync = 131072L;

		protected int lnTStampSyncValue;

		/// <summary>
		/// Member bit: RegEx to validate user input for entry.
		/// </summary>
		/// <remarks>
		/// DB column: validateexpression
		/// </remarks>
		public const long mbValidateExpression = 262144L;

		protected int lnValidateExpressionValue;

		/// <summary>
		/// All valid member bits.
		/// </summary>
		public const long mbAllMembers = 524287L;

		#endregion
		
		
		public static readonly long serialVersionUID = 96404005L;		
	} // end class
}  // end namespace
