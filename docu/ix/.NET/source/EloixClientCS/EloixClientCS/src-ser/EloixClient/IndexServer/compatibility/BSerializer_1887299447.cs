//
// Serializer for de.elo.ix.client.compatibility.BStub_WClientService
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.compatibility
{
	
	public class BSerializer_1887299447 : BSerializer_16 {
		
		public readonly static BSerializer instance = new BSerializer_1887299447();
		
		public BSerializer_1887299447()
			: base(1887299447) {}
		
		protected override BRemote internalCreate(BTransport transport) {
			return new BStub_WClientService(transport);
		}
		
	}
} // namespace
