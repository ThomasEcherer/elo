//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public sealed class BRequest_FeedNotification_updateAction : BMethodRequest, BSerializable
	{
	
		#region Execute
		
		public override int getRemoteId() { return 320199695; }
		
		public override void execute(BRemote __byps__remote, BAsyncResultIF<Object> __byps__asyncResult) {
			// checkpoint byps.gen.cs.GenApiClass:406
			try {
				FeedNotification __byps__remoteT = (FeedNotification)__byps__remote;				
				BAsyncResultSendMethod<Object> __byps__outerResult = new BAsyncResultSendMethod<Object>(__byps__asyncResult, new EloixClient.IndexServer.BResult_19());				
				__byps__remoteT.updateAction(actionValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult(null, e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.feed.Action actionValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 688797212L;		
	} // end class
}  // end namespace
