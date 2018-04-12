//
// Serializer for de.elo.ix.client.ForwardWorkflowNodeInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_523867474 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_523867474();
		
		public BSerializer_523867474()
			: base(523867474) {}
		
		public BSerializer_523867474(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ForwardWorkflowNodeInfo obj = (ForwardWorkflowNodeInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.terminateWorkflow);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.node, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.successorNodesToActivate, false, EloixClient.IndexServer.BSerializer_181681714.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ForwardWorkflowNodeInfo obj = (ForwardWorkflowNodeInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new ForwardWorkflowNodeInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.terminateWorkflow = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.node = (EloixClient.IndexServer.WFNode)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.successorNodesToActivate = (IList<int>)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
