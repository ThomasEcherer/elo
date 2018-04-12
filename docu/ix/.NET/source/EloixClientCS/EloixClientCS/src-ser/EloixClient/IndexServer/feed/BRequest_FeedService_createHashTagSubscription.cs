//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public sealed class BRequest_FeedService_createHashTagSubscription : BMethodRequest, BSerializable
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
				BAsyncResultSendMethod<EloixClient.IndexServer.Subscription> __byps__outerResult = new BAsyncResultSendMethod<EloixClient.IndexServer.Subscription>(__byps__asyncResult, new EloixClient.IndexServer.BResult_323351719());				
				__byps__remoteT.createHashTagSubscription(ciValue, hashtagGuidOrNameValue, userGuidOrIdValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult(null, e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.ClientInfo ciValue;

		internal String hashtagGuidOrNameValue;

		internal String userGuidOrIdValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1471082196L;		
	} // end class
}  // end namespace
