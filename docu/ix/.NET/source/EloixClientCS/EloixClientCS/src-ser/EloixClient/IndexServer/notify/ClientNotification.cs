using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.notify
{
	
	/// <summary>
	/// Callback interface for server-push notifications.
	/// </summary>
	// checkpoint byps.gen.cs.GenRemoteClass:93
	public interface ClientNotification : BRemote {
	
		/// <summary>
		/// Administration mode was changed.
		/// </summary>
		void adminMode(EloixClient.IndexServer.ClientInfo ci, int mode);
		void adminMode(EloixClient.IndexServer.ClientInfo ci, int mode, BAsyncResult<Object> asyncResult) ;
		
		/// <summary>
		/// Reserved.
		/// </summary>
		void updateTask(EloixClient.IndexServer.ClientInfo ci, EloixClient.IndexServer.UserTask userTask, EloixClient.IndexServer.notify.TaskNotifyType notifyType);
		void updateTask(EloixClient.IndexServer.ClientInfo ci, EloixClient.IndexServer.UserTask userTask, EloixClient.IndexServer.notify.TaskNotifyType notifyType, BAsyncResult<Object> asyncResult) ;
		
		
	}
}  // end namespace
