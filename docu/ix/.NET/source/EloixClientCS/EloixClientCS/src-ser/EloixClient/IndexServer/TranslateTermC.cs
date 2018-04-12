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
	/// Constants for class TranslateTerm.
	/// </summary>
	public class TranslateTermC : BSerializable
	{
	
		#region Constructors
		
		public TranslateTermC() {
		}		
		
		public TranslateTermC(int @lnTermLang) {
			this.lnTermLangValue = @lnTermLang;
		}		
		
		public TranslateTermC(TranslateTermC rhs)
		{
			this.lnTermLangValue = rhs.lnTermLangValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Maximum term length;
		/// </summary>
		public int lnTermLang
		{
			get
			{
				return lnTermLangValue;
			}
			set
			{
				this.lnTermLangValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Use this value in parameter <code>termIds[.]
		/// </summary>
		/// <remarks>
		/// </code> to
		/// retrieve the system languages.
		/// </remarks>
		public const String GUID_SYSTEM_LANGUAGES = "SYSTEM_LANGUAGES";

		/// <summary>
		/// Use this value as parameter <code>termIds</code> to
		/// retrieve the system languages.
		/// </summary>
		public readonly static String[] TASKIDS_FOR_SYSTEM_LANGUAGES = new String[]{"SYSTEM_LANGUAGES"};

		protected int lnTermLangValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1212336284L;		
	} // end class
}  // end namespace
