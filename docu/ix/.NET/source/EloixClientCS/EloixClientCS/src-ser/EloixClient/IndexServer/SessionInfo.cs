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
	/// <p>Provides details of the current session with the Index Server</p>
	/// <p>Copyright: Copyright (c) 2003</p>
	/// <p>Organisation: ELO Digital Office GmbH </p>
	/// </summary>
	public class SessionInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public SessionInfo() {
		}		
		
		public SessionInfo(String @clientComputer, int @userId, int @validSeconds, String @ticket, String @userName, String @loginName, String @bestBefore, String @appName, String @appVersion, String @appType, String @runAs) {
			this.clientComputerValue = @clientComputer;
			this.userIdValue = @userId;
			this.validSecondsValue = @validSeconds;
			this.ticketValue = @ticket;
			this.userNameValue = @userName;
			this.loginNameValue = @loginName;
			this.bestBeforeValue = @bestBefore;
			this.appNameValue = @appName;
			this.appVersionValue = @appVersion;
			this.appTypeValue = @appType;
			this.runAsValue = @runAs;
		}		
		
		public SessionInfo(SessionInfo rhs) : base(rhs)
		{
			this.clientComputerValue = rhs.clientComputerValue;
			this.userIdValue = rhs.userIdValue;
			this.validSecondsValue = rhs.validSecondsValue;
			this.ticketValue = rhs.ticketValue;
			this.userNameValue = rhs.userNameValue;
			this.loginNameValue = rhs.loginNameValue;
			this.bestBeforeValue = rhs.bestBeforeValue;
			this.appNameValue = rhs.appNameValue;
			this.appVersionValue = rhs.appVersionValue;
			this.appTypeValue = rhs.appTypeValue;
			this.runAsValue = rhs.runAsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// The client computer connected with the Index Server.
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
		
		
		/// <summary>
		/// The id of the user used for the connection.
		/// </summary>
		public int userId
		{
			get
			{
				return userIdValue;
			}
			set
			{
				this.userIdValue = value;
			}
		}
		
		
		/// <summary>
		/// The length of time the connection is valid for.
		/// </summary>
		public int validSeconds
		{
			get
			{
				return validSecondsValue;
			}
			set
			{
				this.validSecondsValue = value;
			}
		}
		
		
		/// <summary>
		/// The ticket of this session within the Index Server.
		/// </summary>
		public String ticket
		{
			get
			{
				return ticketValue;
			}
			set
			{
				this.ticketValue = value;
			}
		}
		
		
		/// <summary>
		/// The name of the user used for the connection.
		/// </summary>
		public String userName
		{
			get
			{
				return userNameValue;
			}
			set
			{
				this.userNameValue = value;
			}
		}
		
		
		/// <summary>
		/// The name of the user who initialized the runAs connection
		/// </summary>
		public String loginName
		{
			get
			{
				return loginNameValue;
			}
			set
			{
				this.loginNameValue = value;
			}
		}
		
		
		/// <summary>
		/// The time stamp of the session best before date.
		/// </summary>
		public String bestBefore
		{
			get
			{
				return bestBeforeValue;
			}
			set
			{
				this.bestBeforeValue = value;
			}
		}
		
		
		/// <summary>
		/// The name of the client's application connected with the Index Server.
		/// </summary>
		public String appName
		{
			get
			{
				return appNameValue;
			}
			set
			{
				this.appNameValue = value;
			}
		}
		
		
		/// <summary>
		/// The version of the client's application connected with the Index Server.
		/// </summary>
		public String appVersion
		{
			get
			{
				return appVersionValue;
			}
			set
			{
				this.appVersionValue = value;
			}
		}
		
		
		/// <summary>
		/// The type of the client's application connected with the Index Server.
		/// </summary>
		public String appType
		{
			get
			{
				return appTypeValue;
			}
			set
			{
				this.appTypeValue = value;
			}
		}
		
		
		/// <summary>
		/// Session is constrained to this account
		/// </summary>
		public String runAs
		{
			get
			{
				return runAsValue;
			}
			set
			{
				this.runAsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String clientComputerValue;

		protected int userIdValue;

		protected int validSecondsValue;

		protected String ticketValue;

		protected String userNameValue;

		protected String loginNameValue;

		protected String bestBeforeValue;

		protected String appNameValue;

		protected String appVersionValue;

		protected String appTypeValue;

		protected String runAsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 866689803L;		
	} // end class
}  // end namespace
