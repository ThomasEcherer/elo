//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public sealed class BRequest_IXServicePortIF_findNextSubscriptions : BMethodRequest, BSerializable
	{
	
		#region Execute
		
		public override int getRemoteId() { return 1795705954; }
		
		// checkpoint byps.gen.cs.GenApiClass:472
		public override void setSession(Object __byps__sess) {
			ciValue = (EloixClient.IndexServer.ClientInfo)__byps__sess;
		}
		
		public override void execute(BRemote __byps__remote, BAsyncResultIF<Object> __byps__asyncResult) {
			// checkpoint byps.gen.cs.GenApiClass:406
			try {
				IXServicePortIF __byps__remoteT = (IXServicePortIF)__byps__remote;				
				BAsyncResultSendMethod<EloixClient.IndexServer.FindResult> __byps__outerResult = new BAsyncResultSendMethod<EloixClient.IndexServer.FindResult>(__byps__asyncResult, new BResult_1301335819());				
				__byps__remoteT.findNextSubscriptions(ciValue, searchIdValue, idxValue, maxValue, subsZValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult(null, e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.ClientInfo ciValue;

		internal String searchIdValue;

		internal int idxValue;

		internal int maxValue;

		internal EloixClient.IndexServer.SubscriptionZ subsZValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1930960532L;		
	} // end class
}  // end namespace
