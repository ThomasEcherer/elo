//
// Serializer for de.elo.ix.client.AlertDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1498169909 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1498169909();
		
		public BSerializer_1498169909()
			: base(1498169909) {}
		
		public BSerializer_1498169909(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			AlertDataC obj = (AlertDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnMemo);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			AlertDataC obj = (AlertDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new AlertDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnMemo = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
