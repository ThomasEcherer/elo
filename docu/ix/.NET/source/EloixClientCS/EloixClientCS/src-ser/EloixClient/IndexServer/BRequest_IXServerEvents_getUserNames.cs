//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public sealed class BRequest_IXServerEvents_getUserNames : BMethodRequest, BSerializable
	{
	
		#region Execute
		
		public override int getRemoteId() { return 1938363825; }
		
		public override void execute(BRemote __byps__remote, BAsyncResultIF<Object> __byps__asyncResult) {
			// checkpoint byps.gen.cs.GenApiClass:406
			try {
				IXServerEvents __byps__remoteT = (IXServerEvents)__byps__remote;				
				BAsyncResultSendMethod<EloixClient.IndexServer.UserName[]> __byps__outerResult = new BAsyncResultSendMethod<EloixClient.IndexServer.UserName[]>(__byps__asyncResult, new BResult_1001617329());				
				__byps__remoteT.getUserNames(ecValue, idsValue, checkoutUsersZValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult(null, e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.IXServerEventsContext ecValue;

		internal String[] idsValue;

		internal EloixClient.IndexServer.CheckoutUsersZ checkoutUsersZValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1950460032L;		
	} // end class
}  // end namespace
