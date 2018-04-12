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
	/// This class describes additional params for an upload or download URL.
	/// </summary>
	public class UrlParams : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public UrlParams() {
		}		
		
		public UrlParams(long @length, long @offset, String @highlightTerms) {
			this.lengthValue = @length;
			this.offsetValue = @offset;
			this.highlightTermsValue = @highlightTerms;
		}		
		
		public UrlParams(UrlParams rhs) : base(rhs)
		{
			this.lengthValue = rhs.lengthValue;
			this.offsetValue = rhs.offsetValue;
			this.highlightTermsValue = rhs.highlightTermsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Download only length bytes from the resource.
		/// </summary>
		/// <remarks>
		/// Set this value to 0, if all bytes should be read.
		/// </remarks>
		public long length
		{
			get
			{
				return lengthValue;
			}
			set
			{
				this.lengthValue = value;
			}
		}
		
		
		/// <summary>
		/// Download bytes beginning from this offset.
		/// </summary>
		public long offset
		{
			get
			{
				return offsetValue;
			}
			set
			{
				this.offsetValue = value;
			}
		}
		
		
		/// <summary>
		/// Highlight this terms.
		/// </summary>
		/// <remarks>
		/// This value is only valid for fulltext URLs.
		/// Many terms have to be separated by space character.
		/// Each term is enclosed in the HTML tags &lt;b&gt; term &lt;/b&gt;
		/// </remarks>
		public String highlightTerms
		{
			get
			{
				return highlightTermsValue;
			}
			set
			{
				this.highlightTermsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected long lengthValue;

		protected long offsetValue;

		protected String highlightTermsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2007960901L;		
	} // end class
}  // end namespace
