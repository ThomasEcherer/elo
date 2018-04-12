//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_delegateWorkFlowNode
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2095741220 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_2095741220();
		
		public BSerializer_2095741220()
			: base(2095741220) {}
		
		public BSerializer_2095741220(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_delegateWorkFlowNode obj = (BRequest_IXServicePortIF_delegateWorkFlowNode)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.delegateNodeInfoValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.lockZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_delegateWorkFlowNode obj = (BRequest_IXServicePortIF_delegateWorkFlowNode)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_delegateWorkFlowNode()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.delegateNodeInfoValue = (EloixClient.IndexServer.WFDelegateNodeInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
