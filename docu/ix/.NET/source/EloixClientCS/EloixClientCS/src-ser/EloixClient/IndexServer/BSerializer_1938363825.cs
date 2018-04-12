//
// Serializer for de.elo.ix.client.BStub_IXServerEvents
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1938363825 : BSerializer_16 {
		
		public readonly static BSerializer instance = new BSerializer_1938363825();
		
		public BSerializer_1938363825()
			: base(1938363825) {}
		
		protected override BRemote internalCreate(BTransport transport) {
			return new BStub_IXServerEvents(transport);
		}
		
	}
} // namespace
