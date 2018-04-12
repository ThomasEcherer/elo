using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.compatibility
{
	
	/// <summary>
	/// This service helps to support the upload and download functions in IXConnection.
	/// </summary>
	// checkpoint byps.gen.cs.GenRemoteClass:93
	public interface RawStreamService : BRemote {
	
		/// <summary>
		/// Upload a stream.
		/// </summary>
		String upload(EloixClient.IndexServer.ClientInfo ci, String[] @params, System.IO.Stream @is);
		void upload(EloixClient.IndexServer.ClientInfo ci, String[] @params, System.IO.Stream @is, BAsyncResult<String> asyncResult) ;
		
		/// <summary>
		/// Download a stream
		/// </summary>
		System.IO.Stream download(EloixClient.IndexServer.ClientInfo ci, String[] @params);
		void download(EloixClient.IndexServer.ClientInfo ci, String[] @params, BAsyncResult<System.IO.Stream> asyncResult) ;
		
		
	}
}  // end namespace
