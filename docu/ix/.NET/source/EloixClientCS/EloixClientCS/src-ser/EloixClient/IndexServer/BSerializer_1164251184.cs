//
// Serializer for de.elo.ix.client.WFTakeNodeC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1164251184 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1164251184();
		
		public BSerializer_1164251184()
			: base(1164251184) {}
		
		public BSerializer_1164251184(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			WFTakeNodeC obj = (WFTakeNodeC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WFTakeNodeC obj = (WFTakeNodeC)(obj1 != null ? obj1 : bin.onObjectCreated(new WFTakeNodeC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
