//
// Serializer for de.elo.ix.client.health.BStub_HealthCheckService
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.health
{
	
	public class BSerializer_969424915 : BSerializer_16 {
		
		public readonly static BSerializer instance = new BSerializer_969424915();
		
		public BSerializer_969424915()
			: base(969424915) {}
		
		protected override BRemote internalCreate(BTransport transport) {
			return new BStub_HealthCheckService(transport);
		}
		
	}
} // namespace
