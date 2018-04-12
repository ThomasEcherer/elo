//
// Serializer for de.elo.ix.client.notify.BStub_ClientNotification
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.notify
{
	
	public class BSerializer_2104055021 : BSerializer_16 {
		
		public readonly static BSerializer instance = new BSerializer_2104055021();
		
		public BSerializer_2104055021()
			: base(2104055021) {}
		
		protected override BRemote internalCreate(BTransport transport) {
			return new BStub_ClientNotification(transport);
		}
		
	}
} // namespace
