//
// Serializer for de.elo.ix.client.ColorDataInternC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1208511866 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1208511866();
		
		public BSerializer_1208511866()
			: base(1208511866) {}
		
		public BSerializer_1208511866(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ColorDataInternC obj = (ColorDataInternC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnName);
			if (version >= 700000000000003L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnGuid);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnTStamp);
				if (version >= 900990009000001L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.lnTStampSync);
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ColorDataInternC obj = (ColorDataInternC)(obj1 != null ? obj1 : bin.onObjectCreated(new ColorDataInternC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnName = bbuf.getInt();
			if (version >= 700000000000003L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnGuid = bbuf.getInt();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnTStamp = bbuf.getInt();
				if (version >= 900990009000001L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.lnTStampSync = bbuf.getInt();
				}
			}
			
			return obj;
		}
		
	}
} // namespace
