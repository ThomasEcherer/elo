//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public sealed class BRequest_IXServerEvents_executeRegisteredFunction : BMethodRequest, BSerializable
	{
	
		#region Execute
		
		public override int getRemoteId() { return 1938363825; }
		
		public override void execute(BRemote __byps__remote, BAsyncResultIF<Object> __byps__asyncResult) {
			// checkpoint byps.gen.cs.GenApiClass:406
			try {
				IXServerEvents __byps__remoteT = (IXServerEvents)__byps__remote;				
				BAsyncResultSendMethod<EloixClient.IndexServer.Any> __byps__outerResult = new BAsyncResultSendMethod<EloixClient.IndexServer.Any>(__byps__asyncResult, new BResult_1191976387());				
				__byps__remoteT.executeRegisteredFunction(ecValue, functionNameValue, anyValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult(null, e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.IXServerEventsContext ecValue;

		internal String functionNameValue;

		internal EloixClient.IndexServer.Any anyValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1363890826L;		
	} // end class
}  // end namespace
