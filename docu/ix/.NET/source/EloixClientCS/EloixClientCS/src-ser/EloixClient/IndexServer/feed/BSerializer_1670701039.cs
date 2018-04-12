//
// Serializer for de.elo.ix.client.feed.BStub_FeedService
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_1670701039 : BSerializer_16 {
		
		public readonly static BSerializer instance = new BSerializer_1670701039();
		
		public BSerializer_1670701039()
			: base(1670701039) {}
		
		protected override BRemote internalCreate(BTransport transport) {
			return new BStub_FeedService(transport);
		}
		
	}
} // namespace
