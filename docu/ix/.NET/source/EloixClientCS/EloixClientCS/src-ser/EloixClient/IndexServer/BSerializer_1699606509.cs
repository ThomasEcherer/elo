//
// Serializer for de.elo.ix.client.ForwardWorkflowNodeResult
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1699606509 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1699606509();
		
		public BSerializer_1699606509()
			: base(1699606509) {}
		
		public BSerializer_1699606509(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ForwardWorkflowNodeResult obj = (ForwardWorkflowNodeResult)(obj1 != null ? obj1 : bin.onObjectCreated(new ForwardWorkflowNodeResult()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
