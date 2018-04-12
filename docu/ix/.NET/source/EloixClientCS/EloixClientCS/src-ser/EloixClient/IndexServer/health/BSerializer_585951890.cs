//
// Serializer for de.elo.ix.client.health.HealthCheckInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.health
{
	
	public class BSerializer_585951890 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_585951890();
		
		public BSerializer_585951890()
			: base(585951890) {}
		
		public BSerializer_585951890(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			HealthCheckInfo obj = (HealthCheckInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putDouble(obj.doubleValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.sampleSize);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.stringValue);
			if (version >= 1000000020000016L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt((int)obj.operation);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			HealthCheckInfo obj = (HealthCheckInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new HealthCheckInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.doubleValue = bbuf.getDouble();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sampleSize = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.stringValue = bbuf.getString();
			if (version >= 1000000020000016L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.operation = (EloixClient.IndexServer.health.HealthCheckValueOperation)bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
