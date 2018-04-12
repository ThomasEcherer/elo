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
	/// This class is used to describe an OCR worker process.
	/// </summary>
	public class OcrWorker : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public OcrWorker() {
		}		
		
		public OcrWorker(long @busId, long @subsId, int @state, long @lastUsed, long @reserved) {
			this.busIdValue = @busId;
			this.subsIdValue = @subsId;
			this.stateValue = @state;
			this.lastUsedValue = @lastUsed;
			this.reservedValue = @reserved;
		}		
		
		public OcrWorker(OcrWorker rhs) : base(rhs)
		{
			this.busIdValue = rhs.busIdValue;
			this.subsIdValue = rhs.subsIdValue;
			this.stateValue = rhs.stateValue;
			this.lastUsedValue = rhs.lastUsedValue;
			this.reservedValue = rhs.reservedValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// The worker process listens on this bus ID for events of type {@link EventBusC#EVENT_OCR_REQUEST}.
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
		/// The worker process is identified by this subscriber ID on the event bus.
		/// </summary>
		public long subsId
		{
			get
			{
				return subsIdValue;
			}
			set
			{
				this.subsIdValue = value;
			}
		}
		
		
		/// <summary>
		/// Worker state.
		/// </summary>
		public int state
		{
			get
			{
				return stateValue;
			}
			set
			{
				this.stateValue = value;
			}
		}
		
		
		/// <summary>
		/// Reserved.
		/// </summary>
		public long lastUsed
		{
			get
			{
				return lastUsedValue;
			}
			set
			{
				this.lastUsedValue = value;
			}
		}
		
		
		/// <summary>
		/// Reserved.
		/// </summary>
		public long reserved
		{
			get
			{
				return reservedValue;
			}
			set
			{
				this.reservedValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected long busIdValue;

		protected long subsIdValue;

		protected int stateValue;

		protected long lastUsedValue;

		protected long reservedValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 730157667L;		
	} // end class
}  // end namespace
