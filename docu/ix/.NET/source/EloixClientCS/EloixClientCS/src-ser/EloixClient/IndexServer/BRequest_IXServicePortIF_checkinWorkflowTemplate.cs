//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public sealed class BRequest_IXServicePortIF_checkinWorkflowTemplate : BMethodRequest, BSerializable
	{
	
		#region Execute
		
		public override int getRemoteId() { return 1795705954; }
		
		// checkpoint byps.gen.cs.GenApiClass:472
		public override void setSession(Object __byps__sess) {
			ciValue = (EloixClient.IndexServer.ClientInfo)__byps__sess;
		}
		
		public override void execute(BRemote __byps__remote, BAsyncResultIF<Object> __byps__asyncResult) {
			// checkpoint byps.gen.cs.GenApiClass:406
			try {
				IXServicePortIF __byps__remoteT = (IXServicePortIF)__byps__remote;				
				BAsyncResultSendMethod<int[]> __byps__outerResult = new BAsyncResultSendMethod<int[]>(__byps__asyncResult, new BResult_100361105());				
				__byps__remoteT.checkinWorkflowTemplate(ciValue, wfValue, wfZValue, unlockZValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult(null, e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.ClientInfo ciValue;

		internal EloixClient.IndexServer.WFDiagram wfValue;

		internal EloixClient.IndexServer.WFDiagramZ wfZValue;

		internal EloixClient.IndexServer.LockZ unlockZValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 847491504L;		
	} // end class
}  // end namespace
