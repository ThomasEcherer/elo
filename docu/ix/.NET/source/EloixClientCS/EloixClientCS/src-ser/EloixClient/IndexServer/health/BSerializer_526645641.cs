//
// Serializer for de.elo.ix.client.health.HealthCheckInfoC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.health
{
	
	public class BSerializer_526645641 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_526645641();
		
		public BSerializer_526645641()
			: base(526645641) {}
		
		public BSerializer_526645641(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			HealthCheckInfoC obj = (HealthCheckInfoC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnDoubleValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnSampleSize);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnStringValue);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			HealthCheckInfoC obj = (HealthCheckInfoC)(obj1 != null ? obj1 : bin.onObjectCreated(new HealthCheckInfoC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnDoubleValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnName = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnSampleSize = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnStringValue = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
