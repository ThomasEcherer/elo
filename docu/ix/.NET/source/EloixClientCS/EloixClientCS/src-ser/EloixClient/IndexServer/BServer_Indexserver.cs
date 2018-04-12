using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BServer_Indexserver : BServer { 
	
		public static BServer_Indexserver createServer(BTransportFactory transportFactory) {
			return new BServer_Indexserver(transportFactory);
		}
		
		public static BServer_Indexserver createServerR(BTransport transport) {
			return new BServer_Indexserver(transport);
		}
		
		public BServer_Indexserver(BTransport transport) 
			: base(transport, null)
		{
		}
		
		public BServer_Indexserver(BTransportFactory transportFactory) 
			: base(
				transportFactory.createServerTransport(),
				transportFactory.createClientR(
					BClient_Indexserver.createClientR(
						transportFactory.createClientTransport()
					)
				)
			)
		{
		}
		
		public BServer_Indexserver addRemote(BSkeleton_IXEventBusHandler remoteSkeleton) {
			addRemote(627994447, remoteSkeleton);
			return this;
		}
		
		public BServer_Indexserver addRemote(BSkeleton_IXServerEvents remoteSkeleton) {
			addRemote(1938363825, remoteSkeleton);
			return this;
		}
		
		public BServer_Indexserver addRemote(EloixClient.IndexServer.feed.BSkeleton_FeedNotification remoteSkeleton) {
			addRemote(320199695, remoteSkeleton);
			return this;
		}
		
		public BServer_Indexserver addRemote(EloixClient.IndexServer.notify.BSkeleton_ClientNotification remoteSkeleton) {
			addRemote(2104055021, remoteSkeleton);
			return this;
		}
		
	}
}
