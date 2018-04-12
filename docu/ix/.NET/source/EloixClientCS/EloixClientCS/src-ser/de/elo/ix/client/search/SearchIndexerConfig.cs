//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace de.elo.ix.client.search
{
	
	public class SearchIndexerConfig : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public SearchIndexerConfig() {
		}		
		
		public SearchIndexerConfig(UpdaterConfig @updaterConfig, OptimizerConfig @optimizerConfig, ReindexerConfig @reindexerConfig, LanguageConfig @languageConfig) {
			this.updaterConfigValue = @updaterConfig;
			this.optimizerConfigValue = @optimizerConfig;
			this.reindexerConfigValue = @reindexerConfig;
			this.languageConfigValue = @languageConfig;
		}		
		
		public SearchIndexerConfig(SearchIndexerConfig rhs) : base(rhs)
		{
			this.updaterConfigValue = rhs.updaterConfigValue;
			this.optimizerConfigValue = rhs.optimizerConfigValue;
			this.reindexerConfigValue = rhs.reindexerConfigValue;
			this.languageConfigValue = rhs.languageConfigValue;
		}		
		
		#endregion
		
		#region Properties
		
		public UpdaterConfig updaterConfig
		{
			get
			{
				return updaterConfigValue;
			}
			set
			{
				this.updaterConfigValue = value;
			}
		}
		
		
		public OptimizerConfig optimizerConfig
		{
			get
			{
				return optimizerConfigValue;
			}
			set
			{
				this.optimizerConfigValue = value;
			}
		}
		
		
		public ReindexerConfig reindexerConfig
		{
			get
			{
				return reindexerConfigValue;
			}
			set
			{
				this.reindexerConfigValue = value;
			}
		}
		
		
		public LanguageConfig languageConfig
		{
			get
			{
				return languageConfigValue;
			}
			set
			{
				this.languageConfigValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected UpdaterConfig updaterConfigValue;

		protected OptimizerConfig optimizerConfigValue;

		protected ReindexerConfig reindexerConfigValue;

		protected LanguageConfig languageConfigValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1425319615L;		
	} // end class
}  // end namespace
