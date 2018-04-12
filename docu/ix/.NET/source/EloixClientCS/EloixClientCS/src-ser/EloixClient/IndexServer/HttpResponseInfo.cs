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
	/// This class contains information for the HttpServletResponse object to be sent by the Indexserver servlet.
	/// </summary>
	public class HttpResponseInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public HttpResponseInfo() {
		}		
		
		public HttpResponseInfo(String @contentType, String @responseString) {
			this.contentTypeValue = @contentType;
			this.responseStringValue = @responseString;
		}		
		
		public HttpResponseInfo(HttpResponseInfo rhs) : base(rhs)
		{
			this.contentTypeValue = rhs.contentTypeValue;
			this.responseStringValue = rhs.responseStringValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Content type header.
		/// </summary>
		/// <remarks>
		/// HttpServletResponse.setContentType()
		/// </remarks>
		public String contentType
		{
			get
			{
				return contentTypeValue;
			}
			set
			{
				this.contentTypeValue = value;
			}
		}
		
		
		/// <summary>
		/// Response text.
		/// </summary>
		/// <remarks>
		/// Written to HttpServletResponse.getOutputStream()
		/// </remarks>
		public String responseString
		{
			get
			{
				return responseStringValue;
			}
			set
			{
				this.responseStringValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String contentTypeValue;

		protected String responseStringValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1552189905L;		
	} // end class
}  // end namespace
