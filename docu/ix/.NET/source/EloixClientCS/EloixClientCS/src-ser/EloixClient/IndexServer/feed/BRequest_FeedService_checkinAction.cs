//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public sealed class BRequest_FeedService_checkinAction : BMethodRequest, BSerializable
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
				BAsyncResultSendMethod<String> __byps__outerResult = new BAsyncResultSendMethod<String>(__byps__asyncResult, new EloixClient.IndexServer.BResult_10());				
				__byps__remoteT.checkinAction(ciValue, actionValue, actionZValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult("", e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.ClientInfo ciValue;

		internal EloixClient.IndexServer.feed.Action actionValue;

		internal EloixClient.IndexServer.feed.ActionZ actionZValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1138765790L;		
	} // end class
}  // end namespace
