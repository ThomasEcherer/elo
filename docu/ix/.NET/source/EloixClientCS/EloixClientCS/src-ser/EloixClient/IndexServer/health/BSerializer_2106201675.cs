//
// Serializer for de.elo.ix.client.health.HealthCheckValueNameC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.health
{
	
	public class BSerializer_2106201675 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_2106201675();
		
		public BSerializer_2106201675()
			: base(2106201675) {}
		
		public BSerializer_2106201675(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			HealthCheckValueNameC obj = (HealthCheckValueNameC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			HealthCheckValueNameC obj = (HealthCheckValueNameC)(obj1 != null ? obj1 : bin.onObjectCreated(new HealthCheckValueNameC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
