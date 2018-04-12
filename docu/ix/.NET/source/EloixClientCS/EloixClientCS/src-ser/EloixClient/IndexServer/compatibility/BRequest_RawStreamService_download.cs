//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.compatibility
{
	
	public sealed class BRequest_RawStreamService_download : BMethodRequest, BSerializable
	{
	
		#region Execute
		
		public override int getRemoteId() { return 354585327; }
		
		// checkpoint byps.gen.cs.GenApiClass:472
		public override void setSession(Object __byps__sess) {
			ciValue = (EloixClient.IndexServer.ClientInfo)__byps__sess;
		}
		
		public override void execute(BRemote __byps__remote, BAsyncResultIF<Object> __byps__asyncResult) {
			// checkpoint byps.gen.cs.GenApiClass:406
			try {
				RawStreamService __byps__remoteT = (RawStreamService)__byps__remote;				
				BAsyncResultSendMethod<System.IO.Stream> __byps__outerResult = new BAsyncResultSendMethod<System.IO.Stream>(__byps__asyncResult, new EloixClient.IndexServer.BResult_15());				
				__byps__remoteT.download(ciValue, paramsValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult(null, e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.ClientInfo ciValue;

		internal String[] paramsValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 280725475L;		
	} // end class
}  // end namespace
