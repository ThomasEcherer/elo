using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	/// <summary>
	/// This class provides a skeleton implementation of the interface FeedNotification.
	/// </summary>
	/// <remark>
	/// Your interface implementation class has to be derived from this skeleton.
	/// Either provide an asynchronous or a synchronous function in your subclass.
	/// The framework calls only the asynchronous function.
	/// </remark>
	public class BSkeleton_FeedNotification : BSkeleton, FeedNotification {	
		
		public readonly static long serialVersionUID = 320199695L;
		
		public virtual void updateAction(EloixClient.IndexServer.feed.Action action) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void updateAction(EloixClient.IndexServer.feed.Action action, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				updateAction(action);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		
	}
}
