//
// Serializer for de.elo.ix.client.health.BRequest_HealthCheckService_update
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.health
{
	
	public class BSerializer_1948144488 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1948144488();
		
		public BSerializer_1948144488()
			: base(1948144488) {}
		
		public BSerializer_1948144488(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_HealthCheckService_update obj = (BRequest_HealthCheckService_update)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.hciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_HealthCheckService_update obj = (BRequest_HealthCheckService_update)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_HealthCheckService_update()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.hciValue = (EloixClient.IndexServer.health.HealthCheckInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
