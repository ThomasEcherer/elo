//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class SubscriptionZ : BSerializable
	{
	
		#region Constructors
		
		public SubscriptionZ() {
		}		
		
		public SubscriptionZ(long @bset) {
			this.bsetValue = @bset;
		}		
		
		public SubscriptionZ(SubscriptionZ rhs)
		{
			this.bsetValue = rhs.bsetValue;
		}		
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// Bitset field for constants from the SubscriptionC class.
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
		
		
		public static readonly long serialVersionUID = 1493215896L;		
	} // end class
}  // end namespace
