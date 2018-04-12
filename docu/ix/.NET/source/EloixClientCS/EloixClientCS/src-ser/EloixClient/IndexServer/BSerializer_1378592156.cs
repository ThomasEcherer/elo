//
// Serializer for de.elo.ix.client.WFVersionC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1378592156 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1378592156();
		
		public BSerializer_1378592156()
			: base(1378592156) {}
		
		public BSerializer_1378592156(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			WFVersionC obj = (WFVersionC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnComment);
			if (version >= 700000000000018L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnVersion);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WFVersionC obj = (WFVersionC)(obj1 != null ? obj1 : bin.onObjectCreated(new WFVersionC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnComment = bbuf.getInt();
			if (version >= 700000000000018L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnVersion = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
