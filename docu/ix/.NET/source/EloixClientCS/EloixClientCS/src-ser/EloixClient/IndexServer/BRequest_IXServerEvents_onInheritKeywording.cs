//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public sealed class BRequest_IXServerEvents_onInheritKeywording : BMethodRequest, BSerializable
	{
	
		#region Execute
		
		public override int getRemoteId() { return 1938363825; }
		
		public override void execute(BRemote __byps__remote, BAsyncResultIF<Object> __byps__asyncResult) {
			// checkpoint byps.gen.cs.GenApiClass:406
			try {
				IXServerEvents __byps__remoteT = (IXServerEvents)__byps__remote;				
				BAsyncResultSendMethod<EloixClient.IndexServer.InheritKeywordingResult> __byps__outerResult = new BAsyncResultSendMethod<EloixClient.IndexServer.InheritKeywordingResult>(__byps__asyncResult, new BResult_892356058());				
				__byps__remoteT.onInheritKeywording(ecValue, sordValue, parentSordValue, okeyNamesValue, reservedValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult(0, e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.IXServerEventsContext ecValue;

		internal EloixClient.IndexServer.Sord sordValue;

		internal EloixClient.IndexServer.Sord parentSordValue;

		internal String[] okeyNamesValue;

		internal Object reservedValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 53854844L;		
	} // end class
}  // end namespace
