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
	/// This class supplies params to control the creation of an event bus ID.
	/// </summary>
	/// <remarks>
	/// Only one of the members ticket, userId and channelId should be set.
	/// </remarks>
	public class EventBusParams : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public EventBusParams() {
		}		
		
		public EventBusParams(String @ticket, String @userId, String @channelId, bool @noForwardToOtherIxs) {
			this.ticketValue = @ticket;
			this.userIdValue = @userId;
			this.channelIdValue = @channelId;
			this.noForwardToOtherIxsValue = @noForwardToOtherIxs;
		}		
		
		public EventBusParams(EventBusParams rhs) : base(rhs)
		{
			this.ticketValue = rhs.ticketValue;
			this.userIdValue = rhs.userIdValue;
			this.channelIdValue = rhs.channelIdValue;
			this.noForwardToOtherIxsValue = rhs.noForwardToOtherIxsValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Create event bus ID based on this ticket.
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
		/// Get the event bus ID for this user.
		/// </summary>
		/// <remarks>
		/// A numeric ID, GUID or user name can be specified.
		/// The returned bus ID is computed as EventBusC.BUSID_USER + uid,
		/// where uid is the numeric user ID.
		/// </remarks>
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
		/// Create an event bus ID based on this string.
		/// </summary>
		/// <remarks>
		/// An arbitary string can be supplied.
		/// </remarks>
		public String channelId
		{
			get
			{
				return channelIdValue;
			}
			set
			{
				this.channelIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Do not open this bus on other Indexservers.
		/// </summary>
		/// <remarks>
		/// In load balancing environments, event busses are opened on each Indexserver
		/// by default. Set this option to true to open this event bus only on
		/// the currently attached Indexserver.
		/// </remarks>
		public bool noForwardToOtherIxs
		{
			get
			{
				return noForwardToOtherIxsValue;
			}
			set
			{
				this.noForwardToOtherIxsValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String ticketValue;

		protected String userIdValue;

		protected String channelIdValue;

		protected bool noForwardToOtherIxsValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1489333610L;		
	} // end class
}  // end namespace
