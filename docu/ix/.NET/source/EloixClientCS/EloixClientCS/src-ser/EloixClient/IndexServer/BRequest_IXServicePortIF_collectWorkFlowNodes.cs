//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public sealed class BRequest_IXServicePortIF_collectWorkFlowNodes : BMethodRequest, BSerializable
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
				BAsyncResultSendMethod<EloixClient.IndexServer.WFCollectNode[]> __byps__outerResult = new BAsyncResultSendMethod<EloixClient.IndexServer.WFCollectNode[]>(__byps__asyncResult, new BResult_2006133032());				
				__byps__remoteT.collectWorkFlowNodes(ciValue, flowNameValue, wfTypeZValue, nodeNameValue, nodeTypeValue, objIdValue, enterDateIsoValue, exitDateIsoValue, userIdsValue, onlyActiveValue, onlyStartNodesValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult(null, e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.ClientInfo ciValue;

		internal String flowNameValue;

		internal EloixClient.IndexServer.WFTypeZ wfTypeZValue;

		internal String nodeNameValue;

		internal int nodeTypeValue;

		internal String objIdValue;

		internal String enterDateIsoValue;

		internal String exitDateIsoValue;

		internal String[] userIdsValue;

		internal bool onlyActiveValue;

		internal bool onlyStartNodesValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 791411518L;		
	} // end class
}  // end namespace
