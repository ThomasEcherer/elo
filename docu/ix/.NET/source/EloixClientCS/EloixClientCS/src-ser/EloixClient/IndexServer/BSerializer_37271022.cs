//
// Serializer for de.elo.ix.client.WorkFlowHead
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_37271022 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_37271022();
		
		public BSerializer_37271022()
			: base(37271022) {}
		
		public BSerializer_37271022(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			WorkFlowHead obj = (WorkFlowHead)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.flowId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.guid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.status);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.tStamp);
			if (version >= 700000000000014L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.actServerId);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.type);
				if (version >= 900000030000022L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.parentWorkflow);
					if (version >= 1000000000000004L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.callNodeId);
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WorkFlowHead obj = (WorkFlowHead)(obj1 != null ? obj1 : bin.onObjectCreated(new WorkFlowHead()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flowId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.guid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.status = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tStamp = bbuf.getString();
			if (version >= 700000000000014L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.actServerId = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.type = bbuf.getInt();
				if (version >= 900000030000022L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.parentWorkflow = bbuf.getInt();
					if (version >= 1000000000000004L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.callNodeId = bbuf.getInt();
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace
