//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	/// <summary>
	/// Type safe element selector for class Feed.
	/// </summary>
	public class FeedZ : BSerializable
	{
	
		#region Constructors
		
		public FeedZ() {
		}		
		
		public FeedZ(long @bset) {
			this.bsetValue = @bset;
		}		
		
		public FeedZ(FeedZ rhs)
		{
			this.bsetValue = rhs.bsetValue;
		}		
		
		#endregion
		
		#region Properties
		
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
		
		
		public static readonly long serialVersionUID = 126672288L;		
	} // end class
}  // end namespace
