//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class HashTagZ : BSerializable
	{
	
		#region Constructors
		
		public HashTagZ() {
		}		
		
		public HashTagZ(long @bset) {
			this.bsetValue = @bset;
		}		
		
		public HashTagZ(HashTagZ rhs)
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
		
		
		public static readonly long serialVersionUID = 1664941037L;		
	} // end class
}  // end namespace
