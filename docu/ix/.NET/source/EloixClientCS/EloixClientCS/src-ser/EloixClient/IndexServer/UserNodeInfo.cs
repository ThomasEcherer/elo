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
	/// This class contains the information of a user node using to create a
	/// AdHocWorkflow.
	/// </summary>
	/// <remarks>
	/// This class is used by the method
	/// IXServicePortIF.startAdHocWorkFlow2.
	/// </remarks>
	public class UserNodeInfo : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public UserNodeInfo() {
		}		
		
		public UserNodeInfo(String @nodeName, String @userId, EloixClient.IndexServer.WFTimeLimit[] @timeLimitEscalations, int @timeLimit, String @timeLimitIso, int @flags) {
			this.nodeNameValue = @nodeName;
			this.userIdValue = @userId;
			this.timeLimitEscalationsValue = @timeLimitEscalations;
			this.timeLimitValue = @timeLimit;
			this.timeLimitIsoValue = @timeLimitIso;
			this.flagsValue = @flags;
		}		
		
		public UserNodeInfo(UserNodeInfo rhs) : base(rhs)
		{
			this.nodeNameValue = rhs.nodeNameValue;
			this.userIdValue = rhs.userIdValue;
			this.timeLimitEscalationsValue = rhs.timeLimitEscalationsValue;
			this.timeLimitValue = rhs.timeLimitValue;
			this.timeLimitIsoValue = rhs.timeLimitIsoValue;
			this.flagsValue = rhs.flagsValue;
		}		
		
		#endregion
		
		#region Properties
		
		public String nodeName
		{
			get
			{
				return nodeNameValue;
			}
			set
			{
				this.nodeNameValue = value;
			}
		}
		
		
		public String userId
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
		/// Additional definitions for time limits.
		/// </summary>
		/// <remarks>
		/// This member is only valid for person nodes.
		/// </remarks>
		public EloixClient.IndexServer.WFTimeLimit[] timeLimitEscalations
		{
			get
			{
				return timeLimitEscalationsValue;
			}
			set
			{
				this.timeLimitEscalationsValue = value;
			}
		}
		
		
		/// <summary>
		/// The time-limit to process the node.
		/// </summary>
		/// <remarks>
		/// This member is only valid for person nodes.
		/// </remarks>
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
		/// After this date the node exceeds the time-limit for processing.
		/// </summary>
		/// <remarks>
		/// This member is only valid for person nodes.
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
		/// Control flags for the node, a combination of WFNode.C.FLAG_* constants.
		/// </summary>
		public int flags
		{
			get
			{
				return flagsValue;
			}
			set
			{
				this.flagsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String nodeNameValue;

		protected String userIdValue;

		protected EloixClient.IndexServer.WFTimeLimit[] timeLimitEscalationsValue;

		protected int timeLimitValue;

		protected String timeLimitIsoValue;

		protected int flagsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 2059835971L;		
	} // end class
}  // end namespace
