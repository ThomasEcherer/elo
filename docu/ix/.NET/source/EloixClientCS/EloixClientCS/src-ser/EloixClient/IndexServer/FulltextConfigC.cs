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
	/// Constants for class FulltextConfig.
	/// </summary>
	public class FulltextConfigC : BSerializable
	{
	
		#region Constructors
		
		public FulltextConfigC() {
		}		
		
		public FulltextConfigC(FulltextConfigC rhs)
		{
		}		
		
		#endregion
		
		#region Properties
		
		#endregion
		
		#region Fields
		
		/// <summary>
		/// Use fulltext information from inverse index stored in the archive database.
		/// </summary>
		public const int SOURCE_CLASSIC = 0;

		/// <summary>
		/// Use fulltext information from Microsoft SQL-Server fulltext catalog.
		/// </summary>
		public const int SOURCE_FTCAT = 1;

		/// <summary>
		/// Use fulltext information from iSearch.
		/// </summary>
		public const int SOURCE_ISEARCH = 2;

		/// <summary>
		/// Use fulltext information from Elasticsearch.
		/// </summary>
		public const int SOURCE_ELASTICSEARCH = 3;

		/// <summary>
		/// Evaluate suggestions for similar terms (= corrections)
		/// </summary>
		public const int FLAG_ISEARCH_DID_YOU_MEAN = 1;

		/// <summary>
		/// Perform a search for each pressed key (= completion)
		/// </summary>
		public const int FLAG_ISEARCH_SEARCH_AS_YOU_TYPE = 2;

		/// <summary>
		/// Retrieve a summary text for each word.
		/// </summary>
		public const int FLAG_ISEARCH_SUMMARY = 4;

		/// <summary>
		/// Use the thesaurus of the company.
		/// </summary>
		public const int FLAG_ISEARCH_COMPANY_THESAURUS = 8;

		/// <summary>
		/// Use the extension "Knowlege Map".
		/// </summary>
		public const int FLAG_ISEARCH_KNOWLEGE_MAP = 16;

		/// <summary>
		/// Use the extension "Ontology Net".
		/// </summary>
		public const int FLAG_ISEARCH_ONTOLOGY_NET = 32;

		/// <summary>
		/// Use thesaurus provided by ELO (= synonyms)
		/// </summary>
		public const int FLAG_ISEARCH_ELO_THESAURUS = 64;

		/// <summary>
		/// Turn off all search options (if 0 or not in db,
		/// a default set of search options (correction,
		/// synonyms, search terms) is turned on).
		/// </summary>
		/// <remarks>
		/// If combined with other flags, the other options
		/// are turned on.
		/// </remarks>
		public const int FLAG_ISEARCH_OPTIONSOFF = 128;

		#endregion
		
		
		public static readonly long serialVersionUID = 2025824562L;		
	} // end class
}  // end namespace
