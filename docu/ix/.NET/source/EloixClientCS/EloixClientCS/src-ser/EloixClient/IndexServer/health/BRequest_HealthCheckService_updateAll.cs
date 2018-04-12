//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.health
{
	
	public sealed class BRequest_HealthCheckService_updateAll : BMethodRequest, BSerializable
	{
	
		#region Execute
		
		public override int getRemoteId() { return 969424915; }
		
		// checkpoint byps.gen.cs.GenApiClass:472
		public override void setSession(Object __byps__sess) {
			ciValue = (EloixClient.IndexServer.ClientInfo)__byps__sess;
		}
		
		public override void execute(BRemote __byps__remote, BAsyncResultIF<Object> __byps__asyncResult) {
			// checkpoint byps.gen.cs.GenApiClass:406
			try {
				HealthCheckService __byps__remoteT = (HealthCheckService)__byps__remote;				
				BAsyncResultSendMethod<Object> __byps__outerResult = new BAsyncResultSendMethod<Object>(__byps__asyncResult, new EloixClient.IndexServer.BResult_19());				
				__byps__remoteT.updateAll(ciValue, hcisValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult(null, e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.ClientInfo ciValue;

		internal IList<EloixClient.IndexServer.health.HealthCheckInfo> hcisValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 720562919L;		
	} // end class
}  // end namespace
