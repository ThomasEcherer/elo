//
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onAfterEndEditWorkFlowNode
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_812031586 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_812031586();
		
		public BSerializer_812031586()
			: base(812031586) {}
		
		public BSerializer_812031586(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServerEvents_onAfterEndEditWorkFlowNode obj = (BRequest_IXServerEvents_onAfterEndEditWorkFlowNode)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nodeIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ecValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sordValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sordZValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.workflowValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServerEvents_onAfterEndEditWorkFlowNode obj = (BRequest_IXServerEvents_onAfterEndEditWorkFlowNode)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServerEvents_onAfterEndEditWorkFlowNode()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodeIdValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ecValue = (EloixClient.IndexServer.IXServerEventsContext)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sordValue = (EloixClient.IndexServer.Sord)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sordZValue = (EloixClient.IndexServer.SordZ)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.workflowValue = (EloixClient.IndexServer.WFDiagram)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
