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
	/// This class provides information about the configuration of the fulltext database.
	/// </summary>
	public class FulltextConfig : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public FulltextConfig() {
		}		
		
		public FulltextConfig(int @source, int @flags, String @knowlegeMapUrl, de.elo.ix.client.search.SearchIndexerConfig @indexerConfig) {
			this.sourceValue = @source;
			this.flagsValue = @flags;
			this.knowlegeMapUrlValue = @knowlegeMapUrl;
			this.indexerConfigValue = @indexerConfig;
		}		
		
		public FulltextConfig(FulltextConfig rhs) : base(rhs)
		{
			this.sourceValue = rhs.sourceValue;
			this.flagsValue = rhs.flagsValue;
			this.knowlegeMapUrlValue = rhs.knowlegeMapUrlValue;
			this.indexerConfigValue = rhs.indexerConfigValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// One of the FulltextConfigC.SOURCE_* constants.
		/// </summary>
		public int source
		{
			get
			{
				return sourceValue;
			}
			set
			{
				this.sourceValue = value;
			}
		}
		
		
		/// <summary>
		/// A combination of FulltextConfigC.FLAG_* constants.
		/// </summary>
		public int flags
		{
			get
			{
				return flagsValue;
			}
			set
			{
				this.flagsValue = value;
			}
		}
		
		
		/// <summary>
		/// URL of the Knowlege Map service.
		/// </summary>
		/// <remarks>
		/// Only valid for iSearch.
		/// </remarks>
		public String knowlegeMapUrl
		{
			get
			{
				return knowlegeMapUrlValue;
			}
			set
			{
				this.knowlegeMapUrlValue = value;
			}
		}
		
		
		public de.elo.ix.client.search.SearchIndexerConfig indexerConfig
		{
			get
			{
				return indexerConfigValue;
			}
			set
			{
				this.indexerConfigValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int sourceValue;

		protected int flagsValue;

		protected String knowlegeMapUrlValue;

		protected de.elo.ix.client.search.SearchIndexerConfig indexerConfigValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 239574905L;		
	} // end class
}  // end namespace
