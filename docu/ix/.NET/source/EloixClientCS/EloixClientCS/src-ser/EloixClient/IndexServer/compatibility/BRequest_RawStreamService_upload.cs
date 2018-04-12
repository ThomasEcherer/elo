//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.compatibility
{
	
	public sealed class BRequest_RawStreamService_upload : BMethodRequest, BSerializable
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
				BAsyncResultSendMethod<String> __byps__outerResult = new BAsyncResultSendMethod<String>(__byps__asyncResult, new EloixClient.IndexServer.BResult_10());				
				__byps__remoteT.upload(ciValue, paramsValue, isValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult("", e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.ClientInfo ciValue;

		internal String[] paramsValue;

		internal System.IO.Stream isValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 527524138L;		
	} // end class
}  // end namespace
