//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class MapHistZ : EloixClient.IndexServer.ValueClass, BSerializable
	{
	
		#region Constructors
		
		public MapHistZ() {
		}		
		
		public MapHistZ(long @bset) {
			this.bsetValue = @bset;
		}		
		
		public MapHistZ(MapHistZ rhs) : base(rhs)
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
		
		
		public static readonly new long serialVersionUID = 1505340976L;		
	} // end class
}  // end namespace
