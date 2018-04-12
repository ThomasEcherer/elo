//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_collectWorkFlowNodes
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_791411518 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_791411518();
		
		public BSerializer_791411518()
			: base(791411518) {}
		
		public BSerializer_791411518(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_collectWorkFlowNodes obj = (BRequest_IXServicePortIF_collectWorkFlowNodes)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.enterDateIsoValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.exitDateIsoValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.flowNameValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.nodeNameValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nodeTypeValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.onlyActiveValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.onlyStartNodesValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.userIdsValue, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.wfTypeZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_collectWorkFlowNodes obj = (BRequest_IXServicePortIF_collectWorkFlowNodes)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_collectWorkFlowNodes()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.enterDateIsoValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.exitDateIsoValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flowNameValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodeNameValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodeTypeValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.onlyActiveValue = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.onlyStartNodesValue = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userIdsValue = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.wfTypeZValue = (EloixClient.IndexServer.WFTypeZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
