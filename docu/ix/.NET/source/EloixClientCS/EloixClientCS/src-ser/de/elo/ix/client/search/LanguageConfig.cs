//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace de.elo.ix.client.search
{
	
	public class LanguageConfig : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public LanguageConfig() {
		}		
		
		public LanguageConfig(String @languages, String @allowedLangs, int @nbOfLangs, String @archiveLang, IDictionary<String,String> @mapLanguageNames) {
			this.languagesValue = @languages;
			this.allowedLangsValue = @allowedLangs;
			this.nbOfLangsValue = @nbOfLangs;
			this.archiveLangValue = @archiveLang;
			this.mapLanguageNamesValue = @mapLanguageNames;
		}		
		
		public LanguageConfig(LanguageConfig rhs) : base(rhs)
		{
			this.languagesValue = rhs.languagesValue;
			this.allowedLangsValue = rhs.allowedLangsValue;
			this.nbOfLangsValue = rhs.nbOfLangsValue;
			this.archiveLangValue = rhs.archiveLangValue;
			this.mapLanguageNamesValue = rhs.mapLanguageNamesValue;
		}		
		
		#endregion
		
		#region Properties
		
		public String languages
		{
			get
			{
				return languagesValue;
			}
			set
			{
				this.languagesValue = value;
			}
		}
		
		
		public String allowedLangs
		{
			get
			{
				return allowedLangsValue;
			}
			set
			{
				this.allowedLangsValue = value;
			}
		}
		
		
		public int nbOfLangs
		{
			get
			{
				return nbOfLangsValue;
			}
			set
			{
				this.nbOfLangsValue = value;
			}
		}
		
		
		public String archiveLang
		{
			get
			{
				return archiveLangValue;
			}
			set
			{
				this.archiveLangValue = value;
			}
		}
		
		
		public IDictionary<String,String> mapLanguageNames
		{
			get
			{
				return mapLanguageNamesValue;
			}
			set
			{
				this.mapLanguageNamesValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String languagesValue;

		protected String allowedLangsValue;

		protected int nbOfLangsValue;

		protected String archiveLangValue;

		protected IDictionary<String,String> mapLanguageNamesValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2005992013L;		
	} // end class
}  // end namespace
