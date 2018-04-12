using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.compatibility
{
	
	// checkpoint byps.gen.cs.GenRemoteClass:93
	public interface WClientService : BRemote {
	
		void onAfterVersionChanged(EloixClient.IndexServer.ClientInfo ci, int objId, int docId, int flags);
		void onAfterVersionChanged(EloixClient.IndexServer.ClientInfo ci, int objId, int docId, int flags, BAsyncResult<Object> asyncResult) ;
		
		
	}
}  // end namespace
