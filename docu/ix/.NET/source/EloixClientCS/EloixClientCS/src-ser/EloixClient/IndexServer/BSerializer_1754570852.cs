//
// Serializer for de.elo.ix.client.CheckoutWorkflowHistoryResult
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1754570852 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1754570852();
		
		public BSerializer_1754570852()
			: base(1754570852) {}
		
		public BSerializer_1754570852(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			CheckoutWorkflowHistoryResult obj = (CheckoutWorkflowHistoryResult)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.nodeHistories, false, EloixClient.IndexServer.BSerializer_689498285.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			CheckoutWorkflowHistoryResult obj = (CheckoutWorkflowHistoryResult)(obj1 != null ? obj1 : bin.onObjectCreated(new CheckoutWorkflowHistoryResult()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodeHistories = (IDictionary<int,List<EloixClient.IndexServer.WFNodeHistory>>)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
