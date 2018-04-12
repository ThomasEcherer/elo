//
// Serializer for de.elo.ix.client.WorkFlowHeadC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_807993720 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_807993720();
		
		public BSerializer_807993720()
			: base(807993720) {}
		
		public BSerializer_807993720(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			WorkFlowHeadC obj = (WorkFlowHeadC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnTStamp);
			if (version >= 700000000000014L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnActServerId);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WorkFlowHeadC obj = (WorkFlowHeadC)(obj1 != null ? obj1 : bin.onObjectCreated(new WorkFlowHeadC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnTStamp = bbuf.getInt();
			if (version >= 700000000000014L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnActServerId = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
