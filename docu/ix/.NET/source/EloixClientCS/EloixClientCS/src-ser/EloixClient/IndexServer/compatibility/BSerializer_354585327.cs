//
// Serializer for de.elo.ix.client.compatibility.BStub_RawStreamService
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.compatibility
{
	
	public class BSerializer_354585327 : BSerializer_16 {
		
		public readonly static BSerializer instance = new BSerializer_354585327();
		
		public BSerializer_354585327()
			: base(354585327) {}
		
		protected override BRemote internalCreate(BTransport transport) {
			return new BStub_RawStreamService(transport);
		}
		
	}
} // namespace
