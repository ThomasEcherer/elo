//
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onBeforeTakeWorkFlowNode
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_727945599 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_727945599();
		
		public BSerializer_727945599()
			: base(727945599) {}
		
		public BSerializer_727945599(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServerEvents_onBeforeTakeWorkFlowNode obj = (BRequest_IXServerEvents_onBeforeTakeWorkFlowNode)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.flagsValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ecValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.lockZValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.nodeValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.userValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.workflowValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServerEvents_onBeforeTakeWorkFlowNode obj = (BRequest_IXServerEvents_onBeforeTakeWorkFlowNode)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServerEvents_onBeforeTakeWorkFlowNode()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flagsValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ecValue = (EloixClient.IndexServer.IXServerEventsContext)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodeValue = (EloixClient.IndexServer.WFNode)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userValue = (EloixClient.IndexServer.UserInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.workflowValue = (EloixClient.IndexServer.WFDiagram)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
