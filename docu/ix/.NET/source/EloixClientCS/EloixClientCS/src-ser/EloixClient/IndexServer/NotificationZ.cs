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
	/// <p>This class encapsulates the constants of <code>NotificationC</code></p>
	/// 
	/// <p>Copyright: Copyright (c) 2015</p>
	/// <p>Organisation: ELO Digital Office GmbH</p>
	/// </summary>
	public class NotificationZ : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public NotificationZ() {
		}		
		
		public NotificationZ(long @bset) {
			this.bsetValue = @bset;
		}		
		
		public NotificationZ(NotificationZ rhs) : base(rhs)
		{
			this.bsetValue = rhs.bsetValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Bitset field for constants from the NotificationC class.
		/// </summary>
		public long bset
		{
			get
			{
				return bsetValue;
			}
			set
			{
				this.bsetValue = value;
			}
		}
		
		
		#endregion
		
		#region Fields
		
		protected long bsetValue;

		#endregion
		
		
		public static readonly new long serialVersionUID = 1624160439L;		
	} // end class
}  // end namespace
