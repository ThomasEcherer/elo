﻿//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_beginEditWorkFlowNode
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_626823938 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_626823938();
		
		public BSerializer_626823938()
			: base(626823938) {}
		
		public BSerializer_626823938(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_beginEditWorkFlowNode obj = (BRequest_IXServicePortIF_beginEditWorkFlowNode)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nFlowIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nNodeIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.lockZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_beginEditWorkFlowNode obj = (BRequest_IXServicePortIF_beginEditWorkFlowNode)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_beginEditWorkFlowNode()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nFlowIdValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nNodeIdValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
