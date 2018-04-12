//
// Serializer for de.elo.ix.client.EloDmOptDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1218961099 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1218961099();
		
		public BSerializer_1218961099()
			: base(1218961099) {}
		
		public BSerializer_1218961099(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			EloDmOptDataC obj = (EloDmOptDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnRemark);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnValue);
			if (version >= 1000000000000008L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnInstanceName);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			EloDmOptDataC obj = (EloDmOptDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new EloDmOptDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnRemark = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnValue = bbuf.getInt();
			if (version >= 1000000000000008L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnInstanceName = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
