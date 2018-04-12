//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.notify
{
	
	public sealed class BRequest_ClientNotification_updateTask : BMethodRequest, BSerializable
	{
	
		#region Execute
		
		public override int getRemoteId() { return 2104055021; }
		
		public override void execute(BRemote __byps__remote, BAsyncResultIF<Object> __byps__asyncResult) {
			// checkpoint byps.gen.cs.GenApiClass:406
			try {
				ClientNotification __byps__remoteT = (ClientNotification)__byps__remote;				
				BAsyncResultSendMethod<Object> __byps__outerResult = new BAsyncResultSendMethod<Object>(__byps__asyncResult, new EloixClient.IndexServer.BResult_19());				
				__byps__remoteT.updateTask(ciValue, userTaskValue, notifyTypeValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult(null, e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.ClientInfo ciValue;

		internal EloixClient.IndexServer.UserTask userTaskValue;

		internal EloixClient.IndexServer.notify.TaskNotifyType notifyTypeValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1469990419L;		
	} // end class
}  // end namespace
