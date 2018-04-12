//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.myelo
{
	
	public sealed class BRequest_MyELOService_readContent : BMethodRequest, BSerializable
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
				BAsyncResultSendMethod<EloixClient.IndexServer.myelo.MyELOContent> __byps__outerResult = new BAsyncResultSendMethod<EloixClient.IndexServer.myelo.MyELOContent>(__byps__asyncResult, new EloixClient.IndexServer.BResult_1585309177());				
				__byps__remoteT.readContent(ciValue, stateValue, infoValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult(null, e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.ClientInfo ciValue;

		internal EloixClient.IndexServer.myelo.MyELOState stateValue;

		internal EloixClient.IndexServer.myelo.MyELOInfo infoValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 261913914L;		
	} // end class
}  // end namespace
