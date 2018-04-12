using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BClient_Indexserver : BClient { 
	
		public static BClient_Indexserver createClient(BTransportFactory transportFactory) {
			return new BClient_Indexserver(transportFactory);
		}
		
		public static BClient_Indexserver createClientR(BTransport transport) {
			return new BClient_Indexserver(transport);
		}
		
		public virtual BClient_Indexserver addRemote(BSkeleton_IXEventBusHandler remoteSkeleton) {
			if (serverR == null) throw new BException(BExceptionC.NO_REVERSE_CONNECTIONS, "No reverse connections.");
			serverR.server.addRemote(627994447, remoteSkeleton);
			return this;
		}
		
		public virtual BClient_Indexserver addRemote(BSkeleton_IXServerEvents remoteSkeleton) {
			if (serverR == null) throw new BException(BExceptionC.NO_REVERSE_CONNECTIONS, "No reverse connections.");
			serverR.server.addRemote(1938363825, remoteSkeleton);
			return this;
		}
		
		public virtual BClient_Indexserver addRemote(EloixClient.IndexServer.feed.BSkeleton_FeedNotification remoteSkeleton) {
			if (serverR == null) throw new BException(BExceptionC.NO_REVERSE_CONNECTIONS, "No reverse connections.");
			serverR.server.addRemote(320199695, remoteSkeleton);
			return this;
		}
		
		public virtual BClient_Indexserver addRemote(EloixClient.IndexServer.notify.BSkeleton_ClientNotification remoteSkeleton) {
			if (serverR == null) throw new BException(BExceptionC.NO_REVERSE_CONNECTIONS, "No reverse connections.");
			serverR.server.addRemote(2104055021, remoteSkeleton);
			return this;
		}
		
		public virtual IXEventBusHandler IXEventBusHandler
		{
			get { return iXEventBusHandlerVal; }
		}
		public virtual IXServerEvents IXServerEvents
		{
			get { return iXServerEventsVal; }
		}
		public virtual IXServicePortIFAuth IXServicePortIF
		{
			get { return iXServicePortIFVal; }
		}
		public virtual EloixClient.IndexServer.compatibility.RawStreamServiceAuth RawStreamService
		{
			get { return rawStreamServiceVal; }
		}
		public virtual EloixClient.IndexServer.compatibility.WClientServiceAuth WClientService
		{
			get { return wClientServiceVal; }
		}
		public virtual EloixClient.IndexServer.feed.FeedNotification FeedNotification
		{
			get { return feedNotificationVal; }
		}
		public virtual EloixClient.IndexServer.feed.FeedServiceAuth FeedService
		{
			get { return feedServiceVal; }
		}
		public virtual EloixClient.IndexServer.health.HealthCheckServiceAuth HealthCheckService
		{
			get { return healthCheckServiceVal; }
		}
		public virtual EloixClient.IndexServer.myelo.MyELOServiceAuth MyELOService
		{
			get { return myELOServiceVal; }
		}
		public virtual EloixClient.IndexServer.notify.ClientNotification ClientNotification
		{
			get { return clientNotificationVal; }
		}
		public virtual EloixClient.Indexserver.system.SystemInformationAuth SystemInformation
		{
			get { return systemInformationVal; }
		}
		
		public override BRemote getStub(int remoteId) {
			if (remoteId == 627994447) return iXEventBusHandlerVal;
			if (remoteId == 1938363825) return iXServerEventsVal;
			if (remoteId == 1795705954) return iXServicePortIFVal;
			if (remoteId == 354585327) return rawStreamServiceVal;
			if (remoteId == 1887299447) return wClientServiceVal;
			if (remoteId == 320199695) return feedNotificationVal;
			if (remoteId == 1670701039) return feedServiceVal;
			if (remoteId == 969424915) return healthCheckServiceVal;
			if (remoteId == 1063633807) return myELOServiceVal;
			if (remoteId == 2104055021) return clientNotificationVal;
			if (remoteId == 708455930) return systemInformationVal;
			return null;
		}
		
		protected BClient_Indexserver(BTransportFactory transportFactory)
			: base(
				transportFactory.createClientTransport(), 
				transportFactory.createServerR(
					BServer_Indexserver.createServerR(transportFactory.createServerTransport())
				)
			)
		{
			initStubs(transportVal);
		}
		
		protected BClient_Indexserver(BTransport transport) 
			: base(transport, null)
		{
			initStubs(transportVal);
		}
		
		protected IXEventBusHandler iXEventBusHandlerVal;
		protected IXServerEvents iXServerEventsVal;
		protected IXServicePortIFAuth iXServicePortIFVal;
		protected EloixClient.IndexServer.compatibility.RawStreamServiceAuth rawStreamServiceVal;
		protected EloixClient.IndexServer.compatibility.WClientServiceAuth wClientServiceVal;
		protected EloixClient.IndexServer.feed.FeedNotification feedNotificationVal;
		protected EloixClient.IndexServer.feed.FeedServiceAuth feedServiceVal;
		protected EloixClient.IndexServer.health.HealthCheckServiceAuth healthCheckServiceVal;
		protected EloixClient.IndexServer.myelo.MyELOServiceAuth myELOServiceVal;
		protected EloixClient.IndexServer.notify.ClientNotification clientNotificationVal;
		protected EloixClient.Indexserver.system.SystemInformationAuth systemInformationVal;
		
		private void initStubs(BTransport transport) {
			iXEventBusHandlerVal = new BStub_IXEventBusHandler(transport);
			iXServerEventsVal = new BStub_IXServerEvents(transport);
			iXServicePortIFVal = new BStub_IXServicePortIF(transport);
			rawStreamServiceVal = new EloixClient.IndexServer.compatibility.BStub_RawStreamService(transport);
			wClientServiceVal = new EloixClient.IndexServer.compatibility.BStub_WClientService(transport);
			feedNotificationVal = new EloixClient.IndexServer.feed.BStub_FeedNotification(transport);
			feedServiceVal = new EloixClient.IndexServer.feed.BStub_FeedService(transport);
			healthCheckServiceVal = new EloixClient.IndexServer.health.BStub_HealthCheckService(transport);
			myELOServiceVal = new EloixClient.IndexServer.myelo.BStub_MyELOService(transport);
			clientNotificationVal = new EloixClient.IndexServer.notify.BStub_ClientNotification(transport);
			systemInformationVal = new EloixClient.Indexserver.system.BStub_SystemInformation(transport);
		}
		
	}
}
