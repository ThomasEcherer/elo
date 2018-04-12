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
	/// This class describes a time limit for a workflow or for a person node of a workflow.
	/// </summary>
	public class WFTimeLimit : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public WFTimeLimit() {
		}		
		
		public WFTimeLimit(int @timeLimit, int @userId, String @userName, String @timeLimitIso, bool @overTimeLimit) {
			this.timeLimitValue = @timeLimit;
			this.userIdValue = @userId;
			this.userNameValue = @userName;
			this.timeLimitIsoValue = @timeLimitIso;
			this.overTimeLimitValue = @overTimeLimit;
		}		
		
		public WFTimeLimit(WFTimeLimit rhs) : base(rhs)
		{
			this.timeLimitValue = rhs.timeLimitValue;
			this.userIdValue = rhs.userIdValue;
			this.userNameValue = rhs.userNameValue;
			this.timeLimitIsoValue = rhs.timeLimitIsoValue;
			this.overTimeLimitValue = rhs.overTimeLimitValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Time-limit in minutes.
		/// </summary>
		public int timeLimit
		{
			get
			{
				return timeLimitValue;
			}
			set
			{
				this.timeLimitValue = value;
			}
		}
		
		
		/// <summary>
		/// The ID of the user that should be informed,
		/// if the time-limit is exceeded.
		/// </summary>
		/// <remarks>
		/// The IndexServer does not send any notification to the
		/// user. The client application is responsible for doing this.
		/// </remarks>
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
		/// User name for timeLimitUserId;
		/// When writing a workflow with checkinWorkFlow, this value has preceedence
		/// before timeLimitUserId.
		/// </summary>
		/// <remarks>
		/// Set timeLimitUserName to an empty string, if
		/// timeLimitUserId should be used.
		/// </remarks>
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
		/// After this date the node exceeds the time-limit for processing.
		/// </summary>
		/// <remarks>
		/// Read-only.
		/// </remarks>
		public String timeLimitIso
		{
			get
			{
				return timeLimitIsoValue;
			}
			set
			{
				this.timeLimitIsoValue = value;
			}
		}
		
		
		/// <summary>
		/// True, if the workflow exceeds the time limit.
		/// </summary>
		/// <remarks>
		/// Read-only.
		/// </remarks>
		public bool overTimeLimit
		{
			get
			{
				return overTimeLimitValue;
			}
			set
			{
				this.overTimeLimitValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected int timeLimitValue;

		protected int userIdValue;

		protected String userNameValue;

		protected String timeLimitIsoValue;

		protected bool overTimeLimitValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 633363356L;		
	} // end class
}  // end namespace
