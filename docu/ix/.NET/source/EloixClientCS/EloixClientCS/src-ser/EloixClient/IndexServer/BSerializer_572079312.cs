//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_forwardWorkflowNode
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_572079312 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_572079312();
		
		public BSerializer_572079312()
			: base(572079312) {}
		
		public BSerializer_572079312(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_forwardWorkflowNode obj = (BRequest_IXServicePortIF_forwardWorkflowNode)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.flowIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nodeIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.fwdInfoValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.unlockZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_forwardWorkflowNode obj = (BRequest_IXServicePortIF_forwardWorkflowNode)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_forwardWorkflowNode()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flowIdValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodeIdValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fwdInfoValue = (EloixClient.IndexServer.ForwardWorkflowNodeInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.unlockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
