//
// Serializer for de.elo.ix.client.BeginForwardWorkflowNodeInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_823426303 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_823426303();
		
		public BSerializer_823426303()
			: base(823426303) {}
		
		public BSerializer_823426303(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BeginForwardWorkflowNodeInfo obj = (BeginForwardWorkflowNodeInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new BeginForwardWorkflowNodeInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
