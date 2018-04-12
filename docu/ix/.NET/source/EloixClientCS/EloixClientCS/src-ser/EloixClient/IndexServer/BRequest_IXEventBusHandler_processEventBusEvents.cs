//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public sealed class BRequest_IXEventBusHandler_processEventBusEvents : BMethodRequest, BSerializable
	{
	
		#region Execute
		
		public override int getRemoteId() { return 627994447; }
		
		public override void execute(BRemote __byps__remote, BAsyncResultIF<Object> __byps__asyncResult) {
			// checkpoint byps.gen.cs.GenApiClass:406
			try {
				IXEventBusHandler __byps__remoteT = (IXEventBusHandler)__byps__remote;				
				BAsyncResultSendMethod<Object> __byps__outerResult = new BAsyncResultSendMethod<Object>(__byps__asyncResult, new BResult_19());				
				__byps__remoteT.processEventBusEvents(subsIdValue, eventsValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult(null, e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal long subsIdValue;

		internal EloixClient.IndexServer.Event[] eventsValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1736645961L;		
	} // end class
}  // end namespace
