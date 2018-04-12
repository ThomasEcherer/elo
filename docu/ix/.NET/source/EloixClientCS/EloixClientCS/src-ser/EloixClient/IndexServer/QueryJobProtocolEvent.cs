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
	/// A {@link QueryJobProtocolEvent} represents a event
	/// </p>
	/// </summary>
	public class QueryJobProtocolEvent : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public QueryJobProtocolEvent() {
		}		
		
		public QueryJobProtocolEvent(String @date, String @message, int @level, int @objId, int @eventId) {
			this.dateValue = @date;
			this.messageValue = @message;
			this.levelValue = @level;
			this.objIdValue = @objId;
			this.eventIdValue = @eventId;
		}		
		
		public QueryJobProtocolEvent(QueryJobProtocolEvent rhs) : base(rhs)
		{
			this.dateValue = rhs.dateValue;
			this.messageValue = rhs.messageValue;
			this.levelValue = rhs.levelValue;
			this.objIdValue = rhs.objIdValue;
			this.eventIdValue = rhs.eventIdValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// The time of generating this event.
		/// </summary>
		public String date
		{
			get
			{
				return dateValue;
			}
			set
			{
				this.dateValue = value;
			}
		}
		
		
		/// <summary>
		/// Message of this LogRow.
		/// </summary>
		public String message
		{
			get
			{
				return messageValue;
			}
			set
			{
				this.messageValue = value;
			}
		}
		
		
		/// <summary>
		/// The level of log messages to query.
		/// </summary>
		/// <remarks>
		/// Use the | operator to select multiple
		/// levels.
		/// </remarks>
		public int level
		{
			get
			{
				return levelValue;
			}
			set
			{
				this.levelValue = value;
			}
		}
		
		
		/// <summary>
		/// The id of the object currently being processed at the time of this events
		/// creation.
		/// </summary>
		/// <remarks>
		/// If the objId is not known/available, its value is set to
		/// {@link QueryJobProtocolC#OBJID_NOT_SET}.
		/// </remarks>
		public int objId
		{
			get
			{
				return objIdValue;
			}
			set
			{
				this.objIdValue = value;
			}
		}
		
		
		/// <summary>
		/// The id of this QueryJobProtocolEvent.
		/// </summary>
		/// <remarks>
		/// The eventId's value is unique for one
		/// background thread. The value of a background thread's first eventId is 0.
		/// The second one is 1 and so on.
		/// </remarks>
		public int eventId
		{
			get
			{
				return eventIdValue;
			}
			set
			{
				this.eventIdValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected String dateValue;

		protected String messageValue;

		protected int levelValue;

		protected int objIdValue;

		protected int eventIdValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 892520690L;		
	} // end class
}  // end namespace
