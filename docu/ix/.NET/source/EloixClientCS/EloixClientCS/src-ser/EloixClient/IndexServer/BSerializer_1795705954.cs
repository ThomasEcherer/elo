//
// Serializer for de.elo.ix.client.BStub_IXServicePortIF
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1795705954 : BSerializer_16 {
		
		public readonly static BSerializer instance = new BSerializer_1795705954();
		
		public BSerializer_1795705954()
			: base(1795705954) {}
		
		protected override BRemote internalCreate(BTransport transport) {
			return new BStub_IXServicePortIF(transport);
		}
		
	}
} // namespace
