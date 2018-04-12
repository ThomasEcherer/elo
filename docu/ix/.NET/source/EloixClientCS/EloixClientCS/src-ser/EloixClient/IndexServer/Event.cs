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
	/// This class represents an event used by the event bus API functions.
	/// </summary>
	public class Event : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public Event() {
		}		
		
		public Event(long @busId, long @type, long @param1, String @param2, long @id, long @senderId, byte[] @data, EloixClient.IndexServer.Any @any, String @acl) {
			this.busIdValue = @busId;
			this.typeValue = @type;
			this.param1Value = @param1;
			this.param2Value = @param2;
			this.idValue = @id;
			this.senderIdValue = @senderId;
			this.dataValue = @data;
			this.anyValue = @any;
			this.aclValue = @acl;
		}		
		
		public Event(Event rhs) : base(rhs)
		{
			this.busIdValue = rhs.busIdValue;
			this.typeValue = rhs.typeValue;
			this.param1Value = rhs.param1Value;
			this.param2Value = rhs.param2Value;
			this.idValue = rhs.idValue;
			this.senderIdValue = rhs.senderIdValue;
			this.dataValue = rhs.dataValue;
			this.anyValue = rhs.anyValue;
			this.aclValue = rhs.aclValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Bus-ID
		/// </summary>
		public long busId
		{
			get
			{
				return busIdValue;
			}
			set
			{
				this.busIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Event type.
		/// </summary>
		/// <remarks>
		/// Event filters check this value.
		/// This must be one of the predefined event types or an application defined type with a larger value than EventBusC.EVENT_TYPE_MAX_SYSTEM.
		/// </remarks>
		public long type
		{
			get
			{
				return typeValue;
			}
			set
			{
				this.typeValue = value;
			}
		}
		
		
		/// <summary>
		/// Value depends on event type.
		/// </summary>
		/// <remarks>
		/// Event filters check this value.
		/// </remarks>
		public long param1
		{
			get
			{
				return param1Value;
			}
			set
			{
				this.param1Value = value;
			}
		}
		
		
		/// <summary>
		/// Value depends on event type.
		/// </summary>
		/// <remarks>
		/// Event filters check this value.
		/// </remarks>
		public String param2
		{
			get
			{
				return param2Value;
			}
			set
			{
				this.param2Value = value;
			}
		}
		
		
		/// <summary>
		/// Event ID.
		/// </summary>
		/// <remarks>
		/// If the sender awaits a response to this event, it should set a random number in <code>id</code>.
		/// The receiver should use the same number in the response.
		/// </remarks>
		public long id
		{
			get
			{
				return idValue;
			}
			set
			{
				this.idValue = value;
			}
		}
		
		
		/// <summary>
		/// User ID of event sender.
		/// </summary>
		/// <remarks>
		/// Might be used for other IDs in future too.
		/// Read-only.
		/// </remarks>
		public long senderId
		{
			get
			{
				return senderIdValue;
			}
			set
			{
				this.senderIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Event payload data as byte array.
		/// </summary>
		public byte[] data
		{
			get
			{
				return dataValue;
			}
			set
			{
				this.dataValue = value;
			}
		}
		
		
		/// <summary>
		/// Event payload data as Any object.
		/// </summary>
		public EloixClient.IndexServer.Any any
		{
			get
			{
				return anyValue;
			}
			set
			{
				this.anyValue = value;
			}
		}
		
		
		/// <summary>
		/// Access control list.
		/// </summary>
		/// <remarks>
		/// An empty ACL means here, that the event is dispatched to everyone.
		/// </remarks>
		public String acl
		{
			get
			{
				return aclValue;
			}
			set
			{
				this.aclValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected long busIdValue;

		protected long typeValue;

		protected long param1Value;

		protected String param2Value;

		protected long idValue;

		protected long senderIdValue;

		protected byte[] dataValue;

		protected EloixClient.IndexServer.Any anyValue;

		protected String aclValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 877454055L;		
	} // end class
}  // end namespace
