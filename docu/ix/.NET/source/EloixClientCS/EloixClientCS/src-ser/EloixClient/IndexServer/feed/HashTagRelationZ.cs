//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class HashTagRelationZ : BSerializable
	{
	
		#region Constructors
		
		public HashTagRelationZ() {
		}		
		
		public HashTagRelationZ(long @bset) {
			this.bsetValue = @bset;
		}		
		
		public HashTagRelationZ(HashTagRelationZ rhs)
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
		
		
		public static readonly long serialVersionUID = 509234307L;		
	} // end class
}  // end namespace
