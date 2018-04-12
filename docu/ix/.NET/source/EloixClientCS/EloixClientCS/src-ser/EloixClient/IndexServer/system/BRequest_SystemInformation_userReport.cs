//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.Indexserver.system
{
	
	public sealed class BRequest_SystemInformation_userReport : BMethodRequest, BSerializable
	{
	
		#region Execute
		
		public override int getRemoteId() { return 708455930; }
		
		// checkpoint byps.gen.cs.GenApiClass:472
		public override void setSession(Object __byps__sess) {
			ciValue = (EloixClient.IndexServer.ClientInfo)__byps__sess;
		}
		
		public override void execute(BRemote __byps__remote, BAsyncResultIF<Object> __byps__asyncResult) {
			// checkpoint byps.gen.cs.GenApiClass:406
			try {
				SystemInformation __byps__remoteT = (SystemInformation)__byps__remote;				
				BAsyncResultSendMethod<EloixClient.Indexserver.system.UserReport> __byps__outerResult = new BAsyncResultSendMethod<EloixClient.Indexserver.system.UserReport>(__byps__asyncResult, new EloixClient.IndexServer.BResult_18214274());				
				__byps__remoteT.userReport(ciValue, siValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult(null, e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.ClientInfo ciValue;

		internal EloixClient.Indexserver.system.SystemInfo siValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 2081672491L;		
	} // end class
}  // end namespace
