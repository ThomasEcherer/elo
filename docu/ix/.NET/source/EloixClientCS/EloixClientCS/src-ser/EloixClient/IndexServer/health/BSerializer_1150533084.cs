//
// Serializer for de.elo.ix.client.health.BRequest_HealthCheckService_updateMeanValue
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.health
{
	
	public class BSerializer_1150533084 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1150533084();
		
		public BSerializer_1150533084()
			: base(1150533084) {}
		
		public BSerializer_1150533084(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_HealthCheckService_updateMeanValue obj = (BRequest_HealthCheckService_updateMeanValue)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putDouble(obj.meanValueValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.nameValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.sampleSizeValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_HealthCheckService_updateMeanValue obj = (BRequest_HealthCheckService_updateMeanValue)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_HealthCheckService_updateMeanValue()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.meanValueValue = bbuf.getDouble();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nameValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sampleSizeValue = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
