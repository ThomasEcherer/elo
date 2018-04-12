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
	/// Search query for locating text in the archive.
	/// </summary>
	public class FindDirect : BSerializable
	{
	
		#region Constructors
		
		public FindDirect() {
		}		
		
		public FindDirect(String @query, bool @searchInSordName, bool @searchInMemo, bool @searchInIndex, bool @searchInFulltext, bool @searchInNotes, bool @searchInVersions) {
			this.queryValue = @query;
			this.searchInSordNameValue = @searchInSordName;
			this.searchInMemoValue = @searchInMemo;
			this.searchInIndexValue = @searchInIndex;
			this.searchInFulltextValue = @searchInFulltext;
			this.searchInNotesValue = @searchInNotes;
			this.searchInVersionsValue = @searchInVersions;
		}		
		
		public FindDirect(FindDirect rhs)
		{
			this.queryValue = rhs.queryValue;
			this.searchInSordNameValue = rhs.searchInSordNameValue;
			this.searchInMemoValue = rhs.searchInMemoValue;
			this.searchInIndexValue = rhs.searchInIndexValue;
			this.searchInFulltextValue = rhs.searchInFulltextValue;
			this.searchInNotesValue = rhs.searchInNotesValue;
			this.searchInVersionsValue = rhs.searchInVersionsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Search query.
		/// </summary>
		public String query
		{
			get
			{
				return queryValue;
			}
			set
			{
				this.queryValue = value;
			}
		}
		
		
		public bool searchInSordName
		{
			get
			{
				return searchInSordNameValue;
			}
			set
			{
				this.searchInSordNameValue = value;
			}
		}
		
		
		public bool searchInMemo
		{
			get
			{
				return searchInMemoValue;
			}
			set
			{
				this.searchInMemoValue = value;
			}
		}
		
		
		public bool searchInIndex
		{
			get
			{
				return searchInIndexValue;
			}
			set
			{
				this.searchInIndexValue = value;
			}
		}
		
		
		public bool searchInFulltext
		{
			get
			{
				return searchInFulltextValue;
			}
			set
			{
				this.searchInFulltextValue = value;
			}
		}
		
		
		public bool searchInNotes
		{
			get
			{
				return searchInNotesValue;
			}
			set
			{
				this.searchInNotesValue = value;
			}
		}
		
		
		public bool searchInVersions
		{
			get
			{
				return searchInVersionsValue;
			}
			set
			{
				this.searchInVersionsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String queryValue;

		protected bool searchInSordNameValue;

		protected bool searchInMemoValue;

		protected bool searchInIndexValue;

		protected bool searchInFulltextValue;

		protected bool searchInNotesValue;

		protected bool searchInVersionsValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1028007046L;		
	} // end class
}  // end namespace
