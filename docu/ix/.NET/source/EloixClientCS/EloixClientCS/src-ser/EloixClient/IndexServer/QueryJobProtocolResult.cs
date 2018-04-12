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
	/// <p>
	/// This class contains the results from querying the protocol of a background
	/// thread.
	/// </summary>
	/// <remarks>
	/// </p>
	/// </remarks>
	public class QueryJobProtocolResult : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public QueryJobProtocolResult() {
		}		
		
		public QueryJobProtocolResult(String @downloadUrl, EloixClient.IndexServer.QueryJobProtocolEvent[] @events) {
			this.downloadUrlValue = @downloadUrl;
			this.eventsValue = @events;
		}		
		
		public QueryJobProtocolResult(QueryJobProtocolResult rhs) : base(rhs)
		{
			this.downloadUrlValue = rhs.downloadUrlValue;
			this.eventsValue = rhs.eventsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// This String contains a URL where the whole protocol can be downloaded.
		/// </summary>
		/// <remarks>
		/// Empty, if no protocol file exists.
		/// </remarks>
		public String downloadUrl
		{
			get
			{
				return downloadUrlValue;
			}
			set
			{
				this.downloadUrlValue = value;
			}
		}
		
		
		/// <summary>
		/// Contains the all events by a background job that are cached at the
		/// IndexServer.
		/// </summary>
		public EloixClient.IndexServer.QueryJobProtocolEvent[] events
		{
			get
			{
				return eventsValue;
			}
			set
			{
				this.eventsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String downloadUrlValue;

		protected EloixClient.IndexServer.QueryJobProtocolEvent[] eventsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 222450704L;		
	} // end class
}  // end namespace
