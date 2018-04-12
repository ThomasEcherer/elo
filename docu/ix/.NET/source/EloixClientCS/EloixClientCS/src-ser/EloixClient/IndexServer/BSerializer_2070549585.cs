//
// Serializer for de.elo.ix.client.WorkflowExchangeInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2070549585 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2070549585();
		
		public BSerializer_2070549585()
			: base(2070549585) {}
		
		public BSerializer_2070549585(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			WorkflowExchangeInfo obj = (WorkflowExchangeInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.userNames, false, EloixClient.IndexServer.BSerializer_1874463571.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.workflow, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.workflowVersions, false, EloixClient.IndexServer.BSerializer_838894319.instance);
			if (version >= 900000030000022L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.subWorkflowMap, false, EloixClient.IndexServer.BSerializer_1085717935.instance);
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.subWorkflowVersionMap, false, EloixClient.IndexServer.BSerializer_1741591604.instance);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WorkflowExchangeInfo obj = (WorkflowExchangeInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new WorkflowExchangeInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userNames = (IDictionary<int,EloixClient.IndexServer.UserName>)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.workflow = (EloixClient.IndexServer.WFDiagram)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.workflowVersions = (EloixClient.IndexServer.WFDiagram[])bin.readObj(false, EloixClient.IndexServer.BSerializer_838894319.instance);
			if (version >= 900000030000022L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.subWorkflowMap = (IDictionary<int,EloixClient.IndexServer.WFDiagram>)bin.readObj(false, null);
				// checkpoint byps.gen.cs.PrintContext:449
				obj.subWorkflowVersionMap = (IDictionary<int,List<EloixClient.IndexServer.WFDiagram>>)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace
