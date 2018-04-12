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
	/// <p>Constants related to class <code>DocMaskLineTemplate</code>.
	/// </summary>
	public class DocMaskLineTemplateC : EloixClient.IndexServer.DocMaskLineTemplateDataC, BSerializable
	{
	
		#region Constructors
		
		public DocMaskLineTemplateC() {
		}		
		
		public DocMaskLineTemplateC(int @lnAcl) {
			this.lnAclValue = @lnAcl;
		}		
		
		public DocMaskLineTemplateC(DocMaskLineTemplateC rhs) : base(rhs)
		{
			this.lnAclValue = rhs.lnAclValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// ACL length
		/// </summary>
		public int lnAcl
		{
			get
			{
				return lnAclValue;
			}
			set
			{
				this.lnAclValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Member bit: The type of the line information.
		/// </summary>
		/// <remarks>
		/// This can be one of the <code>DocMaskLineC.LINETYPE_*</code> constants.
		/// </remarks>
		public const long mbType = 2L;

		/// <summary>
		/// Member bit: Line flags
		/// </summary>
		public const long mbFlags = 256L;

		/// <summary>
		/// Member bit: ACL
		/// </summary>
		public const long mbAcl = 4096L;

		/// <summary>
		/// Only lock or unlock
		/// </summary>
		public readonly static EloixClient.IndexServer.DocMaskLineTemplateZ mbOnlyLock = new DocMaskLineTemplateZ(0L);

		/// <summary>
		/// Read or write all elements.
		/// </summary>
		public readonly static EloixClient.IndexServer.DocMaskLineTemplateZ mbAll = new DocMaskLineTemplateZ(524287L);

		protected int lnAclValue;

		public const long mbAclItems = 4096L;

		public const long mbHidden = 256L;

		public const long mbOnlyBuzzwords = 256L;

		public const long mbPostfixAsterix = 256L;

		public const long mbPrefixAsterix = 256L;

		public const long mbReadOnly = 256L;

		public const long mbTranslate = 256L;

		public const long mbImportant = 256L;

		public const long mbVersion = 256L;

		#endregion
		
		
		public static readonly new long serialVersionUID = 984407269L;		
	} // end class
}  // end namespace
