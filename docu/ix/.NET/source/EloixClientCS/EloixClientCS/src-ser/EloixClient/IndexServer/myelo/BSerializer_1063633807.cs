//
// Serializer for de.elo.ix.client.myelo.BStub_MyELOService
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.myelo
{
	
	public class BSerializer_1063633807 : BSerializer_16 {
		
		public readonly static BSerializer instance = new BSerializer_1063633807();
		
		public BSerializer_1063633807()
			: base(1063633807) {}
		
		protected override BRemote internalCreate(BTransport transport) {
			return new BStub_MyELOService(transport);
		}
		
	}
} // namespace
