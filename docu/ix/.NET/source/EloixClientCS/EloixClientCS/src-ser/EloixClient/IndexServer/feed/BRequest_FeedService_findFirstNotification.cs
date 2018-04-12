//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public sealed class BRequest_FeedService_findFirstNotification : BMethodRequest, BSerializable
	{
	
		#region Execute
		
		public override int getRemoteId() { return 1670701039; }
		
		// checkpoint byps.gen.cs.GenApiClass:472
		public override void setSession(Object __byps__sess) {
			ciValue = (EloixClient.IndexServer.ClientInfo)__byps__sess;
		}
		
		public override void execute(BRemote __byps__remote, BAsyncResultIF<Object> __byps__asyncResult) {
			// checkpoint byps.gen.cs.GenApiClass:406
			try {
				FeedService __byps__remoteT = (FeedService)__byps__remote;				
				BAsyncResultSendMethod<EloixClient.IndexServer.FindResult> __byps__outerResult = new BAsyncResultSendMethod<EloixClient.IndexServer.FindResult>(__byps__asyncResult, new EloixClient.IndexServer.BResult_1301335819());				
				__byps__remoteT.findFirstNotification(ciValue, findInfoValue, maxValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult(null, e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.ClientInfo ciValue;

		internal EloixClient.IndexServer.feed.FindNotificationInfo findInfoValue;

		internal int maxValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 906090337L;		
	} // end class
}  // end namespace
