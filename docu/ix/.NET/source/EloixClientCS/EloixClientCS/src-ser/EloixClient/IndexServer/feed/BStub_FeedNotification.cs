using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BStub_FeedNotification : BStub, FeedNotification, BSerializable {	
		
		public readonly static long serialVersionUID = 320199695L;
		
		public BStub_FeedNotification(BTransport transport)
			: base(transport) {}			
		
		public virtual void updateAction(EloixClient.IndexServer.feed.Action action) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			updateAction(action, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void updateAction(EloixClient.IndexServer.feed.Action action, BAsyncResult<Object> asyncResult) {
			BRequest_FeedNotification_updateAction req = new BRequest_FeedNotification_updateAction();			
			req.actionValue = action;
			transport.sendMethod(req, asyncResult);
		}
		
		
	}
}
