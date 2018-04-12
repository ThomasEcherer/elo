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
	/// <p>This class defines options used in <code>FindOptions.searchMode</code>.
	/// </summary>
	/// <remarks>
	/// </p>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class SearchModeC : BSerializable
	{
	
		#region Constructors
		
		public SearchModeC() {
		}		
		
		public SearchModeC(SearchModeC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		public const long bsetAND = 0L;

		public const long bsetOR = 1L;

		public const long bsetONE_TERM = 2L;

		public const long bsetEXPRESSION = 3L;

		/// <summary>
		/// The search terms are concatinated with the boolean AND operator.
		/// </summary>
		public readonly static EloixClient.IndexServer.SearchModeZ AND = new SearchModeZ(0L);

		/// <summary>
		/// The search terms are concatinated with the boolean OR operator.
		/// </summary>
		public readonly static EloixClient.IndexServer.SearchModeZ OR = new SearchModeZ(1L);

		/// <summary>
		/// A blank separated list in <code>FindByIndex.name</code> or <code>FindByIndex.desc</code>
		/// is used as a single term.
		/// </summary>
		public readonly static EloixClient.IndexServer.SearchModeZ ONE_TERM = new SearchModeZ(2L);

		/// <summary>
		/// The value of <code>FindByIndex.name</code> or <code>FindByIndex.desc</code>
		/// contains the operators "AND" (&amp;), "OR" (|), "NOT" (!)
		/// </summary>
		/// <remarks>
		/// for concatination.
		/// </remarks>
		public readonly static EloixClient.IndexServer.SearchModeZ EXPRESSION = new SearchModeZ(3L);

		#endregion
		
		
		public static readonly long serialVersionUID = 1758444419L;		
	} // end class
}  // end namespace
