//
// Serializer for de.elo.ix.client.health.BRequest_HealthCheckService_updateDoubleValue
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.health
{
	
	public class BSerializer_677413784 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_677413784();
		
		public BSerializer_677413784()
			: base(677413784) {}
		
		public BSerializer_677413784(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_HealthCheckService_updateDoubleValue obj = (BRequest_HealthCheckService_updateDoubleValue)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putDouble(obj.doubleValueValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.nameValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_HealthCheckService_updateDoubleValue obj = (BRequest_HealthCheckService_updateDoubleValue)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_HealthCheckService_updateDoubleValue()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.doubleValueValue = bbuf.getDouble();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nameValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
