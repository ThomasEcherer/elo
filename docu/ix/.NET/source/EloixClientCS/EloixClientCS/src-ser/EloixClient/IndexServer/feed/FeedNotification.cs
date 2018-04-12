using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	/// <summary>
	/// Callback interface for notifications about a document feed.
	/// </summary>
	/// <remarks>
	/// The client application can register an implementation of this
	/// interface in order to be notified if an action is created or modified.
	/// </remarks>
	// checkpoint byps.gen.cs.GenRemoteClass:93
	public interface FeedNotification : BRemote {
	
		/// <summary>
		/// Called when an action is created or updated.
		/// </summary>
		void updateAction(EloixClient.IndexServer.feed.Action action);
		void updateAction(EloixClient.IndexServer.feed.Action action, BAsyncResult<Object> asyncResult) ;
		
		
	}
}  // end namespace
