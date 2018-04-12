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
	/// This class is used to find translations of terms.
	/// </summary>
	public class FindTranslateTermInfo : BSerializable
	{
	
		#region Constructors
		
		public FindTranslateTermInfo() {
		}		
		
		public FindTranslateTermInfo(String[] @terms, String[] @langs, bool @inclDeleted, bool @inclToBeTranslated) {
			this.termsValue = @terms;
			this.langsValue = @langs;
			this.inclDeletedValue = @inclDeleted;
			this.inclToBeTranslatedValue = @inclToBeTranslated;
		}		
		
		public FindTranslateTermInfo(FindTranslateTermInfo rhs)
		{
			this.termsValue = rhs.termsValue;
			this.langsValue = rhs.langsValue;
			this.inclDeletedValue = rhs.inclDeletedValue;
			this.inclToBeTranslatedValue = rhs.inclToBeTranslatedValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Terms for which translations should be selected.
		/// </summary>
		/// <remarks>
		/// Set this element to <code>null</code> or empty, if all terms should be returned.
		/// The given terms have to be in the language specified in <code>langs[0]</code> object.
		/// If <code>langs</code> is <code>null</code> or empty, the terms are assumed to
		/// be in the system language.
		/// </remarks>
		public String[] terms
		{
			get
			{
				return termsValue;
			}
			set
			{
				this.termsValue = value;
			}
		}
		
		
		/// <summary>
		/// Return the terms specified by element <code>terms</code>
		/// for wich translations exist in this languages.
		/// </summary>
		/// <remarks>
		/// If a term is not found in one of the languages, an empty string is
		/// returned.
		/// The languages must be given in ISO 639 2-letter codes, e.g. "en" for English.
		/// The language at the first index specifies the language of the <code>terms</code>.
		/// This element is corresponding to <code>TranslateTerm.termLangs</code>:
		/// <code>termLangs[i]</code> is in language <code>langs[i]</code>
		/// If this element is <code>null</code>, terms in all available languages are returned.
		/// </remarks>
		public String[] langs
		{
			get
			{
				return langsValue;
			}
			set
			{
				this.langsValue = value;
			}
		}
		
		
		/// <summary>
		/// Reserved - Find deleted terms too (currently not implemented).
		/// </summary>
		public bool inclDeleted
		{
			get
			{
				return inclDeletedValue;
			}
			set
			{
				this.inclDeletedValue = value;
			}
		}
		
		
		/// <summary>
		/// Return those terms too, that should be translated into other languages:
		/// e.g.
		/// </summary>
		/// <remarks>
		/// Keywording form names (DocMask.name), index value lables (DocMaskLine.name)
		/// and Keywords.
		/// </remarks>
		public bool inclToBeTranslated
		{
			get
			{
				return inclToBeTranslatedValue;
			}
			set
			{
				this.inclToBeTranslatedValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String[] termsValue;

		protected String[] langsValue;

		protected bool inclDeletedValue;

		protected bool inclToBeTranslatedValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 986701599L;		
	} // end class
}  // end namespace
