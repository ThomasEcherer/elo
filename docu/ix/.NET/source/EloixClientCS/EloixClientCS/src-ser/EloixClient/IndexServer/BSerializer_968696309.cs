//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutWorkflowTemplate
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_968696309 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_968696309();
		
		public BSerializer_968696309()
			: base(968696309) {}
		
		public BSerializer_968696309(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_checkoutWorkflowTemplate obj = (BRequest_IXServicePortIF_checkoutWorkflowTemplate)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.flowIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.versionIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.lockZValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.wfZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_checkoutWorkflowTemplate obj = (BRequest_IXServicePortIF_checkoutWorkflowTemplate)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_checkoutWorkflowTemplate()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flowIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.versionIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.wfZValue = (EloixClient.IndexServer.WFDiagramZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
