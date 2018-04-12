//
// Serializer for de.elo.ix.client.VtDocC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1585149555 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1585149555();
		
		public BSerializer_1585149555()
			: base(1585149555) {}
		
		public BSerializer_1585149555(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			VtDocC obj = (VtDocC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			VtDocC obj = (VtDocC)(obj1 != null ? obj1 : bin.onObjectCreated(new VtDocC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
