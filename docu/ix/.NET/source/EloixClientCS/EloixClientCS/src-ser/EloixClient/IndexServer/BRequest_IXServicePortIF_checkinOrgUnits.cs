﻿//
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public sealed class BRequest_IXServicePortIF_checkinOrgUnits : BMethodRequest, BSerializable
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
				BAsyncResultSendMethod<IDictionary<int,EloixClient.IndexServer.OrgUnitInfo>> __byps__outerResult = new BAsyncResultSendMethod<IDictionary<int,EloixClient.IndexServer.OrgUnitInfo>>(__byps__asyncResult, new BResult_893011331());				
				__byps__remoteT.checkinOrgUnits(ciValue, orgUnitInfosValue, reservedValue, unlockZValue, BAsyncResultHelper.ToDelegate(__byps__outerResult));
			} catch (Exception e) {
				__byps__asyncResult.setAsyncResult(null, e);
			}
		}		
		
		#endregion
		
		#region Fields
		
		internal EloixClient.IndexServer.ClientInfo ciValue;

		internal EloixClient.IndexServer.OrgUnitInfo[] orgUnitInfosValue;

		internal EloixClient.IndexServer.CheckinOrgUnitInfo reservedValue;

		internal EloixClient.IndexServer.LockZ unlockZValue;

		#endregion
		
		
		public static readonly long serialVersionUID = 656770626L;		
	} // end class
}  // end namespace
