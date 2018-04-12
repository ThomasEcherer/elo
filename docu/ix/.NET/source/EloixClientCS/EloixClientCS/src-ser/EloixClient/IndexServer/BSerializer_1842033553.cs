//
// Serializer for de.elo.ix.client.EloFtStopC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1842033553 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1842033553();
		
		public BSerializer_1842033553()
			: base(1842033553) {}
		
		public BSerializer_1842033553(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			EloFtStopC obj = (EloFtStopC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnStopword);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			EloFtStopC obj = (EloFtStopC)(obj1 != null ? obj1 : bin.onObjectCreated(new EloFtStopC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnStopword = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
