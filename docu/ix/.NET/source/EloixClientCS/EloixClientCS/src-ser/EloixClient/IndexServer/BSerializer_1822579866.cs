//
// Serializer for de.elo.ix.client.WFEditNode
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1822579866 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1822579866();
		
		public BSerializer_1822579866()
			: base(1822579866) {}
		
		public BSerializer_1822579866(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			WFEditNode obj = (WFEditNode)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.flowId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nodeId);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.node, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.succNodes, false, EloixClient.IndexServer.BSerializer_1457843286.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WFEditNode obj = (WFEditNode)(obj1 != null ? obj1 : bin.onObjectCreated(new WFEditNode()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flowId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodeId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.node = (EloixClient.IndexServer.WFNode)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succNodes = (EloixClient.IndexServer.WFNode[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1457843286.instance);
			
			return obj;
		}
		
	}
} // namespace
