//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findFirstWorkflows
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_546938477 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_546938477();
		
		public BSerializer_546938477()
			: base(546938477) {}
		
		public BSerializer_546938477(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_findFirstWorkflows obj = (BRequest_IXServicePortIF_findFirstWorkflows)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.maxValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.findInfoValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.wfDiagramZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_findFirstWorkflows obj = (BRequest_IXServicePortIF_findFirstWorkflows)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_findFirstWorkflows()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.maxValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.findInfoValue = (EloixClient.IndexServer.FindWorkflowInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.wfDiagramZValue = (EloixClient.IndexServer.WFDiagramZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
