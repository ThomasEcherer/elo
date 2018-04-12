using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.notify
{
	
	public class BStub_ClientNotification : BStub, ClientNotification, BSerializable {	
		
		public readonly static long serialVersionUID = 2104055021L;
		
		public BStub_ClientNotification(BTransport transport)
			: base(transport) {}			
		
		public virtual void adminMode(EloixClient.IndexServer.ClientInfo ci, int mode) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			adminMode(ci, mode, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void adminMode(EloixClient.IndexServer.ClientInfo ci, int mode, BAsyncResult<Object> asyncResult) {
			BRequest_ClientNotification_adminMode req = new BRequest_ClientNotification_adminMode();			
			req.ciValue = ci;
			req.modeValue = mode;
			transport.sendMethod(req, asyncResult);
		}
		
		public virtual void updateTask(EloixClient.IndexServer.ClientInfo ci, EloixClient.IndexServer.UserTask userTask, EloixClient.IndexServer.notify.TaskNotifyType notifyType) {
			BSyncResult<Object> asyncResult = new BSyncResult<Object>();			
			updateTask(ci, userTask, notifyType, BAsyncResultHelper.ToDelegate<Object>(asyncResult));
			asyncResult.GetResult();			
		}
		public virtual void updateTask(EloixClient.IndexServer.ClientInfo ci, EloixClient.IndexServer.UserTask userTask, EloixClient.IndexServer.notify.TaskNotifyType notifyType, BAsyncResult<Object> asyncResult) {
			BRequest_ClientNotification_updateTask req = new BRequest_ClientNotification_updateTask();			
			req.ciValue = ci;
			req.userTaskValue = userTask;
			req.notifyTypeValue = notifyType;
			transport.sendMethod(req, asyncResult);
		}
		
		
	}
}
