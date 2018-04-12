//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.myelo
{
	
	public sealed class BRequest_MyELOService_checkState : BMethodRequest, BSerializable
	{
	
		#region Execute
		
		public override int getRemoteId() { return 1063633807; }
		
		// checkpoint byps.gen.cs.GenApiClass:472
		public override void setSession(Object __byps__sess) {
			ciValue = (EloixClient.IndexServer.ClientInfo)__byps__sess;
		}
		
		public override void execute(BRemote __byps__remote, BAsyncResultIF<Object> __byps__asyncResult) {
			// checkpoint byps.gen.cs.GenApiClass:406
			try {
				MyELOService __byps__remoteT = (MyELOService)__byps__remote;				
				BAsyncResultSendMethod<EloixClient.IndexServer.myelo.MyELOState> __byps__outerResult = new BAsyncResultSendMethod<EloixClient.IndexServer.myelo.MyELOState>(__byps__asyncResult, new EloixClient.IndexServer.BResult_1426941339());				
				__byps__remoteT.checkState(ciValue, userGuidOrIDValue, sinceDateIsoValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult(null, e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.ClientInfo ciValue;

		internal String userGuidOrIDValue;

		internal String sinceDateIsoValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 2068722874L;		
	} // end class
}  // end namespace
