using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	/// <summary>
	/// This class provides a skeleton implementation of the interface IXEventBusHandler.
	/// </summary>
	/// <remark>
	/// Your interface implementation class has to be derived from this skeleton.
	/// Either provide an asynchronous or a synchronous function in your subclass.
	/// The framework calls only the asynchronous function.
	/// </remark>
	public class BSkeleton_IXEventBusHandler : BSkeleton, IXEventBusHandler {	
		
		public readonly static long serialVersionUID = 627994447L;
		
		public virtual void processEventBusEvents(long subsId, EloixClient.IndexServer.Event[] events) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void processEventBusEvents(long subsId, EloixClient.IndexServer.Event[] events, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				processEventBusEvents(subsId, events);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		
	}
}
