//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public sealed class BRequest_IXServicePortIF_startAdHocWorkFlow : BMethodRequest, BSerializable
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
				BAsyncResultSendMethod<int> __byps__outerResult = new BAsyncResultSendMethod<int>(__byps__asyncResult, new BResult_5());				
				__byps__remoteT.startAdHocWorkFlow(ciValue, nameValue, objIdValue, arrUserIdsValue, nodeNameValue, forValidationValue, serialFlowValue, cancelUserIdValue, cancelMessageValue, finishedUserIdValue, finishedMessageValue, finishedScriptValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult(0, e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.ClientInfo ciValue;

		internal String nameValue;

		internal String objIdValue;

		internal String[] arrUserIdsValue;

		internal String nodeNameValue;

		internal bool forValidationValue;

		internal bool serialFlowValue;

		internal String cancelUserIdValue;

		internal String cancelMessageValue;

		internal String finishedUserIdValue;

		internal String finishedMessageValue;

		internal String finishedScriptValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1995358580L;		
	} // end class
}  // end namespace
