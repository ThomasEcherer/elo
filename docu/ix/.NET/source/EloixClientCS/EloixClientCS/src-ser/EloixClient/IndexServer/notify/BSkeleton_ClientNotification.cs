using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.notify
{
	
	/// <summary>
	/// This class provides a skeleton implementation of the interface ClientNotification.
	/// </summary>
	/// <remark>
	/// Your interface implementation class has to be derived from this skeleton.
	/// Either provide an asynchronous or a synchronous function in your subclass.
	/// The framework calls only the asynchronous function.
	/// </remark>
	public class BSkeleton_ClientNotification : BSkeleton, ClientNotification {	
		
		public readonly static long serialVersionUID = 2104055021L;
		
		public virtual void adminMode(EloixClient.IndexServer.ClientInfo ci, int mode) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void adminMode(EloixClient.IndexServer.ClientInfo ci, int mode, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				adminMode(ci, mode);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		public virtual void updateTask(EloixClient.IndexServer.ClientInfo ci, EloixClient.IndexServer.UserTask userTask, EloixClient.IndexServer.notify.TaskNotifyType notifyType) {
			throw new BException(BExceptionC.UNSUPPORTED_METHOD, "");
		}
		public virtual void updateTask(EloixClient.IndexServer.ClientInfo ci, EloixClient.IndexServer.UserTask userTask, EloixClient.IndexServer.notify.TaskNotifyType notifyType, BAsyncResult<Object> asyncResult) {
			Object __byps__ret = default(Object);
			Exception __byps__ex = null;
			try {
				updateTask(ci, userTask, notifyType);
			}
			catch (Exception e) { __byps__ex = e; }
			asyncResult(__byps__ret, __byps__ex);
		}
		
		
	}
}
