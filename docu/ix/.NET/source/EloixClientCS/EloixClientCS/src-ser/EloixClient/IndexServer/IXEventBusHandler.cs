using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	/// <summary>
	/// Handler interface for event bus events.
	/// </summary>
	// checkpoint byps.gen.cs.GenRemoteClass:93
	public interface IXEventBusHandler : BRemote {
	
		void processEventBusEvents(long subsId, EloixClient.IndexServer.Event[] events);
		void processEventBusEvents(long subsId, EloixClient.IndexServer.Event[] events, BAsyncResult<Object> asyncResult) ;
		
		
	}
}  // end namespace
