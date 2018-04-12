//
// Serializer for de.elo.ix.client.WFNodeHistoryC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1457412372 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1457412372();
		
		public BSerializer_1457412372()
			: base(1457412372) {}
		
		public BSerializer_1457412372(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			WFNodeHistoryC obj = (WFNodeHistoryC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnFlowGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnUserName);
			if (version >= 900000030000018L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnHistGuid);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WFNodeHistoryC obj = (WFNodeHistoryC)(obj1 != null ? obj1 : bin.onObjectCreated(new WFNodeHistoryC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnFlowGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnUserName = bbuf.getInt();
			if (version >= 900000030000018L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnHistGuid = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
