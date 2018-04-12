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
	/// This class describes an event bus listener.
	/// </summary>
	public class EventListener : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public EventListener() {
		}		
		
		public EventListener(EloixClient.IndexServer.EventFilter[] @filters) {
			this.filtersValue = @filters;
		}		
		
		public EventListener(EventListener rhs) : base(rhs)
		{
			this.filtersValue = rhs.filtersValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Array of event filters.
		/// </summary>
		public EloixClient.IndexServer.EventFilter[] filters
		{
			get
			{
				return filtersValue;
			}
			set
			{
				this.filtersValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected EloixClient.IndexServer.EventFilter[] filtersValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1005733106L;		
	} // end class
}  // end namespace
