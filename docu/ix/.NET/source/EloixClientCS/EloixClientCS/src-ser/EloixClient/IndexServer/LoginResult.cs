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
	/// <p>Object returned when logging in to the IX.
	/// </summary>
	/// <remarks>
	/// This class contains the
	/// information required after the login has been carried out.</p>
	/// 
	/// <p>Copyright: Copyright (c) 2004</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </remarks>
	public class LoginResult : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public LoginResult() {
		}		
		
		public LoginResult(EloixClient.IndexServer.ClientInfo @clientInfo, int @ticketLifetime, EloixClient.IndexServer.UserInfo @user) {
			this.clientInfoValue = @clientInfo;
			this.ticketLifetimeValue = @ticketLifetime;
			this.userValue = @user;
		}		
		
		public LoginResult(LoginResult rhs) : base(rhs)
		{
			this.clientInfoValue = rhs.clientInfoValue;
			this.ticketLifetimeValue = rhs.ticketLifetimeValue;
			this.userValue = rhs.userValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// <p>ClientInfo object returned by the IX when the login is carried out.
		/// </summary>
		/// <remarks>
		/// Contains information about the client settings.</p>
		/// </remarks>
		public EloixClient.IndexServer.ClientInfo clientInfo
		{
			get
			{
				return clientInfoValue;
			}
			set
			{
				this.clientInfoValue = value;
			}
		}
		
		
		/// <summary>
		/// <p>Contains the lifetime of the ticket in seconds.
		/// </summary>
		/// <remarks>
		/// The connection
		/// is terminated once this lifetime has expired.</p>
		/// </remarks>
		public int ticketLifetime
		{
			get
			{
				return ticketLifetimeValue;
			}
			set
			{
				this.ticketLifetimeValue = value;
			}
		}
		
		
		/// <summary>
		/// <p>Contains the data detailling the user used to login to the IX.
		/// </summary>
		/// <remarks>
		/// </p>
		/// </remarks>
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
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.ClientInfo clientInfoValue;

		protected int ticketLifetimeValue;

		protected EloixClient.IndexServer.UserInfo userValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 777531606L;		
	} // end class
}  // end namespace
