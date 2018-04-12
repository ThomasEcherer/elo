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
	/// This class contains information from the HttpServletRequest received by the Indexserver servlet
	/// </summary>
	public class HttpRequestInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public HttpRequestInfo() {
		}		
		
		public HttpRequestInfo(EloixClient.IndexServer.KeyValue[] @headers, EloixClient.IndexServer.KeyValue[] @cookies, EloixClient.IndexServer.KeyValue[] @requestParams, String @requestURI, String @requestURL) {
			this.headersValue = @headers;
			this.cookiesValue = @cookies;
			this.requestParamsValue = @requestParams;
			this.requestURIValue = @requestURI;
			this.requestURLValue = @requestURL;
		}		
		
		public HttpRequestInfo(HttpRequestInfo rhs) : base(rhs)
		{
			this.headersValue = rhs.headersValue;
			this.cookiesValue = rhs.cookiesValue;
			this.requestParamsValue = rhs.requestParamsValue;
			this.requestURIValue = rhs.requestURIValue;
			this.requestURLValue = rhs.requestURLValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// HTTP Headers
		/// </summary>
		public EloixClient.IndexServer.KeyValue[] headers
		{
			get
			{
				return headersValue;
			}
			set
			{
				this.headersValue = value;
			}
		}
		
		
		/// <summary>
		/// HTTP Cookies
		/// </summary>
		public EloixClient.IndexServer.KeyValue[] cookies
		{
			get
			{
				return cookiesValue;
			}
			set
			{
				this.cookiesValue = value;
			}
		}
		
		
		/// <summary>
		/// Request parameters.
		/// </summary>
		public EloixClient.IndexServer.KeyValue[] requestParams
		{
			get
			{
				return requestParamsValue;
			}
			set
			{
				this.requestParamsValue = value;
			}
		}
		
		
		/// <summary>
		/// Value of the request URI.
		/// </summary>
		/// <remarks>
		/// HttpServletRequest.getRequestURI()
		/// </remarks>
		public String requestURI
		{
			get
			{
				return requestURIValue;
			}
			set
			{
				this.requestURIValue = value;
			}
		}
		
		
		/// <summary>
		/// Value of the request URL.
		/// </summary>
		/// <remarks>
		/// HttpServletRequest.getRequestURL()
		/// </remarks>
		public String requestURL
		{
			get
			{
				return requestURLValue;
			}
			set
			{
				this.requestURLValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.KeyValue[] headersValue;

		protected EloixClient.IndexServer.KeyValue[] cookiesValue;

		protected EloixClient.IndexServer.KeyValue[] requestParamsValue;

		protected String requestURIValue;

		protected String requestURLValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1892343155L;		
	} // end class
}  // end namespace
