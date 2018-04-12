//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class IXServerEventsContext : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public IXServerEventsContext() {
		}		
		
		public IXServerEventsContext(String @url, EloixClient.IndexServer.ClientInfo @ci, EloixClient.IndexServer.UserInfo @user, IDictionary<String,String> @sessionOptions, String @clientComputer) {
			this.urlValue = @url;
			this.ciValue = @ci;
			this.userValue = @user;
			this.sessionOptionsValue = @sessionOptions;
			this.clientComputerValue = @clientComputer;
		}		
		
		public IXServerEventsContext(IXServerEventsContext rhs) : base(rhs)
		{
			this.urlValue = rhs.urlValue;
			this.ciValue = rhs.ciValue;
			this.userValue = rhs.userValue;
			this.sessionOptionsValue = rhs.sessionOptionsValue;
			this.clientComputerValue = rhs.clientComputerValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// IndexServer URL.
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
		
		
		/// <summary>
		/// ClientInfo object including session ticket
		/// </summary>
		public EloixClient.IndexServer.ClientInfo ci
		{
			get
			{
				return ciValue;
			}
			set
			{
				this.ciValue = value;
			}
		}
		
		
		/// <summary>
		/// Current user
		/// </summary>
		public EloixClient.IndexServer.UserInfo user
		{
			get
			{
				return userValue;
			}
			set
			{
				this.userValue = value;
			}
		}
		
		
		/// <summary>
		/// SessionOptions associated to this connection.
		/// </summary>
		public IDictionary<String,String> sessionOptions
		{
			get
			{
				return sessionOptionsValue;
			}
			set
			{
				this.sessionOptionsValue = value;
			}
		}
		
		
		/// <summary>
		/// Parameter clientComputer from login function.
		/// </summary>
		public String clientComputer
		{
			get
			{
				return clientComputerValue;
			}
			set
			{
				this.clientComputerValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String urlValue;

		protected EloixClient.IndexServer.ClientInfo ciValue;

		protected EloixClient.IndexServer.UserInfo userValue;

		protected IDictionary<String,String> sessionOptionsValue;

		protected String clientComputerValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 956691491L;		
	} // end class
}  // end namespace
