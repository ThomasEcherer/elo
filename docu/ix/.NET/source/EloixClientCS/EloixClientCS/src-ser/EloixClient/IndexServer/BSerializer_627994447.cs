//
// Serializer for de.elo.ix.client.BStub_IXEventBusHandler
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_627994447 : BSerializer_16 {
		
		public readonly static BSerializer instance = new BSerializer_627994447();
		
		public BSerializer_627994447()
			: base(627994447) {}
		
		protected override BRemote internalCreate(BTransport transport) {
			return new BStub_IXEventBusHandler(transport);
		}
		
	}
} // namespace
