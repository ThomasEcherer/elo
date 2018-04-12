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
	/// <p>Association between IndexServer URL and archive name.
	/// </summary>
	/// <remarks>
	/// </p>
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH </p>
	/// </remarks>
	public class IndexServerForArchive : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public IndexServerForArchive() {
		}		
		
		public IndexServerForArchive(String @arcName, String @url) {
			this.arcNameValue = @arcName;
			this.urlValue = @url;
		}		
		
		public IndexServerForArchive(IndexServerForArchive rhs) : base(rhs)
		{
			this.arcNameValue = rhs.arcNameValue;
			this.urlValue = rhs.urlValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Archive name.
		/// </summary>
		public String arcName
		{
			get
			{
				return arcNameValue;
			}
			set
			{
				this.arcNameValue = value;
			}
		}
		
		
		/// <summary>
		/// Index Server URL.
		/// </summary>
		public String url
		{
			get
			{
				return urlValue;
			}
			set
			{
				this.urlValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String arcNameValue;

		protected String urlValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 145656220L;		
	} // end class
}  // end namespace
