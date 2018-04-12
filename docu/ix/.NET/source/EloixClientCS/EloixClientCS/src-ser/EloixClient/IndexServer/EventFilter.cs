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
	/// This class describes an event filter.
	/// </summary>
	public class EventFilter : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public EventFilter() {
		}		
		
		public EventFilter(long @busId, long @type, long @param1, String @param2) {
			this.busIdValue = @busId;
			this.typeValue = @type;
			this.param1Value = @param1;
			this.param2Value = @param2;
		}		
		
		public EventFilter(EventFilter rhs) : base(rhs)
		{
			this.busIdValue = rhs.busIdValue;
			this.typeValue = rhs.typeValue;
			this.param1Value = rhs.param1Value;
			this.param2Value = rhs.param2Value;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Event bus ID
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
		/// First event param.
		/// </summary>
		/// <remarks>
		/// Optional. Depends on event type.
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
		/// Second event param.
		/// </summary>
		/// <remarks>
		/// Optional. Depends on event type.
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
		
		
		#endregion
		
		#region Fields
		
		protected long busIdValue;

		protected long typeValue;

		protected long param1Value;

		protected String param2Value;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1095275943L;		
	} // end class
}  // end namespace
