//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_endEditWorkFlowNode
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_551973808 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_551973808();
		
		public BSerializer_551973808()
			: base(551973808) {}
		
		public BSerializer_551973808(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_endEditWorkFlowNode obj = (BRequest_IXServicePortIF_endEditWorkFlowNode)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.bCancelValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.bTerminateValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nFlowIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nNodeIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.sCommentValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.sNameValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.arrEnterNodesIdsValue, false, EloixClient.IndexServer.BSerializer_100361105.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_endEditWorkFlowNode obj = (BRequest_IXServicePortIF_endEditWorkFlowNode)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_endEditWorkFlowNode()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.bCancelValue = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.bTerminateValue = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nFlowIdValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nNodeIdValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sCommentValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sNameValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.arrEnterNodesIdsValue = (int[])bin.readObj(false, EloixClient.IndexServer.BSerializer_100361105.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
