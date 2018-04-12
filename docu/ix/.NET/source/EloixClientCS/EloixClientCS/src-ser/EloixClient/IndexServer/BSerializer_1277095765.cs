//
// Serializer for de.elo.ix.client.MapDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1277095765 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1277095765();
		
		public BSerializer_1277095765()
			: base(1277095765) {}
		
		public BSerializer_1277095765(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			MapDataC obj = (MapDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnKey);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnValue);
			if (version >= 1000000020000007L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnBlob);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			MapDataC obj = (MapDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new MapDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnKey = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnValue = bbuf.getInt();
			if (version >= 1000000020000007L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnBlob = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
