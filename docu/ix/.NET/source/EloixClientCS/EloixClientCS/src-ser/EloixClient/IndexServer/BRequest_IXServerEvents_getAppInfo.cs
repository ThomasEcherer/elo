﻿//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public sealed class BRequest_IXServerEvents_getAppInfo : BMethodRequest, BSerializable
	{
	
		#region Execute
		
		public override int getRemoteId() { return 1938363825; }
		
		public override void execute(BRemote __byps__remote, BAsyncResultIF<Object> __byps__asyncResult) {
			// checkpoint byps.gen.cs.GenApiClass:406
			try {
				IXServerEvents __byps__remoteT = (IXServerEvents)__byps__remote;				
				BAsyncResultSendMethod<String> __byps__outerResult = new BAsyncResultSendMethod<String>(__byps__asyncResult, new BResult_10());				
				__byps__remoteT.getAppInfo(ecValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult("", e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.IXServerEventsContext ecValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 1887140750L;		
	} // end class
}  // end namespace