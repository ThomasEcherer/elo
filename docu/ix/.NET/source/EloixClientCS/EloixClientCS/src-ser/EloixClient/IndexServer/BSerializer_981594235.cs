﻿//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutWorkFlow
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_981594235 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_981594235();
		
		public BSerializer_981594235()
			: base(981594235) {}
		
		public BSerializer_981594235(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_checkoutWorkFlow obj = (BRequest_IXServicePortIF_checkoutWorkFlow)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.flowIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.lockZValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.typeZValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.workFlowDiagramZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_checkoutWorkFlow obj = (BRequest_IXServicePortIF_checkoutWorkFlow)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_checkoutWorkFlow()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flowIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.typeZValue = (EloixClient.IndexServer.WFTypeZ)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.workFlowDiagramZValue = (EloixClient.IndexServer.WFDiagramZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
