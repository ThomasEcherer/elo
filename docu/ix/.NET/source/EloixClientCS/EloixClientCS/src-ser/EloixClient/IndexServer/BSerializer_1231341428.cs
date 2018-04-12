//
// Serializer for de.elo.ix.client.WFDiagramC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1231341428 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1231341428();
		
		public BSerializer_1231341428()
			: base(1231341428) {}
		
		public BSerializer_1231341428(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			WFDiagramC obj = (WFDiagramC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnName);
			if (version >= 700000000000010L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnGuid);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnTStamp);
				if (version >= 700000000000015L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.lnProcessOnServerId);
					if (version >= 900000018000005L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.lnNameTranslationKey);
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WFDiagramC obj = (WFDiagramC)(obj1 != null ? obj1 : bin.onObjectCreated(new WFDiagramC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnName = bbuf.getInt();
			if (version >= 700000000000010L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnGuid = bbuf.getInt();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnTStamp = bbuf.getInt();
				if (version >= 700000000000015L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.lnProcessOnServerId = bbuf.getInt();
					if (version >= 900000018000005L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.lnNameTranslationKey = bbuf.getInt();
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace
