//
// Serializer for de.elo.ix.client.compatibility.WClientC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.compatibility
{
	
	public class BSerializer_1800529481 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1800529481();
		
		public BSerializer_1800529481()
			: base(1800529481) {}
		
		public BSerializer_1800529481(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			WClientC obj = (WClientC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WClientC obj = (WClientC)(obj1 != null ? obj1 : bin.onObjectCreated(new WClientC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
