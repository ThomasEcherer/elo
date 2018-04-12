using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BStub_IXEventBusHandler : BStub, IXEventBusHandler, BSerializable {	
		
		public readonly static long serialVersionUID = 627994447L;
		
		public BStub_IXEventBusHandler(BTransport transport)
			: base(transport) {}			
		
		public virtual void processEventBusEvents(long subsId, EloixClient.IndexServer.Event[] events) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			processEventBusEvents(subsId, events, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void processEventBusEvents(long subsId, EloixClient.IndexServer.Event[] events, BAsyncResult<Object> asyncResult) {
			BRequest_IXEventBusHandler_processEventBusEvents req = new BRequest_IXEventBusHandler_processEventBusEvents();			
			req.subsIdValue = subsId;
			req.eventsValue = events;
			transport.sendMethod(req, asyncResult);
		}
		
		
	}
}
