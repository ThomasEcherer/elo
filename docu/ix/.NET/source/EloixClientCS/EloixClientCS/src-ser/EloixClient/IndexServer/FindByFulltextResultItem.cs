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
	/// Additional information for an item found
	/// by fulltext search.
	/// </summary>
	public class FindByFulltextResultItem : BSerializable
	{
	
		#region Constructors
		
		public FindByFulltextResultItem() {
		}		
		
		public FindByFulltextResultItem(int @relevance, String @summaryFulltext, String @summaryDesc, String[] @fieldNames, EloixClient.IndexServer.Sord @sord) {
			this.relevanceValue = @relevance;
			this.summaryFulltextValue = @summaryFulltext;
			this.summaryDescValue = @summaryDesc;
			this.fieldNamesValue = @fieldNames;
			this.sordValue = @sord;
		}		
		
		public FindByFulltextResultItem(FindByFulltextResultItem rhs)
		{
			this.relevanceValue = rhs.relevanceValue;
			this.summaryFulltextValue = rhs.summaryFulltextValue;
			this.summaryDescValue = rhs.summaryDescValue;
			this.fieldNamesValue = rhs.fieldNamesValue;
			this.sordValue = rhs.sordValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Relevance in per mill.
		/// </summary>
		public int relevance
		{
			get
			{
				return relevanceValue;
			}
			set
			{
				this.relevanceValue = value;
			}
		}
		
		
		/// <summary>
		/// Textpart from document.
		/// </summary>
		public String summaryFulltext
		{
			get
			{
				return summaryFulltextValue;
			}
			set
			{
				this.summaryFulltextValue = value;
			}
		}
		
		
		/// <summary>
		/// Textpart from memo text.
		/// </summary>
		public String summaryDesc
		{
			get
			{
				return summaryDescValue;
			}
			set
			{
				this.summaryDescValue = value;
			}
		}
		
		
		/// <summary>
		/// List of index field names that contain the query text.
		/// </summary>
		public String[] fieldNames
		{
			get
			{
				return fieldNamesValue;
			}
			set
			{
				this.fieldNamesValue = value;
			}
		}
		
		
		/// <summary>
		/// Sord object.
		/// </summary>
		public EloixClient.IndexServer.Sord sord
		{
			get
			{
				return sordValue;
			}
			set
			{
				this.sordValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int relevanceValue;

		protected String summaryFulltextValue;

		protected String summaryDescValue;

		protected String[] fieldNamesValue;

		protected EloixClient.IndexServer.Sord sordValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 709720021L;		
	} // end class
}  // end namespace
