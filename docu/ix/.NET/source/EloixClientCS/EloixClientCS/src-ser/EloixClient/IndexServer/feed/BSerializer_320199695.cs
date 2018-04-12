//
// Serializer for de.elo.ix.client.feed.BStub_FeedNotification
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_320199695 : BSerializer_16 {
		
		public readonly static BSerializer instance = new BSerializer_320199695();
		
		public BSerializer_320199695()
			: base(320199695) {}
		
		protected override BRemote internalCreate(BTransport transport) {
			return new BStub_FeedNotification(transport);
		}
		
	}
} // namespace
