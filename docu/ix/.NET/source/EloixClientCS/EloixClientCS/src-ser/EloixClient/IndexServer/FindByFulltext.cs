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
	/// Performs a fulltext search.
	/// </summary>
	/// <remarks>
	/// It depends on the system configuration, which fulltext engine is used.
	/// The returned list of sords might contain sords with sord.id=0 and no
	/// further data. This happens when the fulltext engine retuns a sord but
	/// the current user does not have read access.
	/// </remarks>
	public class FindByFulltext : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FindByFulltext() {
		}		
		
		public FindByFulltext(String @term) {
			this.termValue = @term;
		}		
		
		public FindByFulltext(FindByFulltext rhs) : base(rhs)
		{
			this.termValue = rhs.termValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Search term to be located in the fulltext database.
		/// </summary>
		/// <remarks>
		/// Can be a single word or a number of words.
		/// Wildcard * is allowed, it matches any number of characters. Term is
		/// interpreted based on the options given by FindOptions in FindInfo.
		/// Exception: FindOptionsC.ONE_TERM is not supported.
		/// </remarks>
		public String term
		{
			get
			{
				return termValue;
			}
			set
			{
				this.termValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String termValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 829543678L;		
	} // end class
}  // end namespace
