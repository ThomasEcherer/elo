//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.compatibility
{
	
	public sealed class BRequest_WClientService_onAfterVersionChanged : BMethodRequest, BSerializable
	{
	
		#region Execute
		
		public override int getRemoteId() { return 1887299447; }
		
		// checkpoint byps.gen.cs.GenApiClass:472
		public override void setSession(Object __byps__sess) {
			ciValue = (EloixClient.IndexServer.ClientInfo)__byps__sess;
		}
		
		public override void execute(BRemote __byps__remote, BAsyncResultIF<Object> __byps__asyncResult) {
			// checkpoint byps.gen.cs.GenApiClass:406
			try {
				WClientService __byps__remoteT = (WClientService)__byps__remote;				
				BAsyncResultSendMethod<Object> __byps__outerResult = new BAsyncResultSendMethod<Object>(__byps__asyncResult, new EloixClient.IndexServer.BResult_19());				
				__byps__remoteT.onAfterVersionChanged(ciValue, objIdValue, docIdValue, flagsValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult(null, e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.ClientInfo ciValue;

		internal int objIdValue;

		internal int docIdValue;

		internal int flagsValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 2095806986L;		
	} // end class
}  // end namespace
