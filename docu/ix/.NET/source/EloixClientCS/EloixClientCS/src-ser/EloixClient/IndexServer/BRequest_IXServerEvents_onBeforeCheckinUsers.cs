//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public sealed class BRequest_IXServerEvents_onBeforeCheckinUsers : BMethodRequest, BSerializable
	{
	
		#region Execute
		
		public override int getRemoteId() { return 1938363825; }
		
		public override void execute(BRemote __byps__remote, BAsyncResultIF<Object> __byps__asyncResult) {
			// checkpoint byps.gen.cs.GenApiClass:406
			try {
				IXServerEvents __byps__remoteT = (IXServerEvents)__byps__remote;				
				BAsyncResultSendMethod<EloixClient.IndexServer.UserInfo[]> __byps__outerResult = new BAsyncResultSendMethod<EloixClient.IndexServer.UserInfo[]>(__byps__asyncResult, new BResult_1132956238());				
				__byps__remoteT.onBeforeCheckinUsers(ecValue, userInfosValue, checkinUsersZValue, unlockZValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult(null, e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.IXServerEventsContext ecValue;

		internal EloixClient.IndexServer.UserInfo[] userInfosValue;

		internal EloixClient.IndexServer.CheckinUsersZ checkinUsersZValue;

		internal EloixClient.IndexServer.LockZ unlockZValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1235281358L;		
	} // end class
}  // end namespace
