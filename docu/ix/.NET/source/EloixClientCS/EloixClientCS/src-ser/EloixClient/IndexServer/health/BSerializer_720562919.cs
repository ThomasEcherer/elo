//
// Serializer for de.elo.ix.client.health.BRequest_HealthCheckService_updateAll
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.health
{
	
	public class BSerializer_720562919 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_720562919();
		
		public BSerializer_720562919()
			: base(720562919) {}
		
		public BSerializer_720562919(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_HealthCheckService_updateAll obj = (BRequest_HealthCheckService_updateAll)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.hcisValue, false, EloixClient.IndexServer.BSerializer_1270538819.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_HealthCheckService_updateAll obj = (BRequest_HealthCheckService_updateAll)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_HealthCheckService_updateAll()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.hcisValue = (IList<EloixClient.IndexServer.health.HealthCheckInfo>)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
