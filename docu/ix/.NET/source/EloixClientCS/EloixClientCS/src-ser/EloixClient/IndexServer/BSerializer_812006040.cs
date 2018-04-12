//
// Serializer for de.elo.ix.client.MapItemC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_812006040 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_812006040();
		
		public BSerializer_812006040()
			: base(812006040) {}
		
		public BSerializer_812006040(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			MapItemC obj = (MapItemC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnContentType);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnKey);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnValue);
			if (version >= 1000000020000005L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnBlobData);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			MapItemC obj = (MapItemC)(obj1 != null ? obj1 : bin.onObjectCreated(new MapItemC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnContentType = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnKey = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnValue = bbuf.getInt();
			if (version >= 1000000020000005L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnBlobData = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
