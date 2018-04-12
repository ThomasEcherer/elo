//
// Serializer for de.elo.ix.client.ObjHistKeyC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1013854536 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1013854536();
		
		public BSerializer_1013854536()
			: base(1013854536) {}
		
		public BSerializer_1013854536(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ObjHistKeyC obj = (ObjHistKeyC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnHistGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnKeyData);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnKeyName);
			if (version >= 700000000000018L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnKeyDataDesc);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ObjHistKeyC obj = (ObjHistKeyC)(obj1 != null ? obj1 : bin.onObjectCreated(new ObjHistKeyC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnHistGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnKeyData = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnKeyName = bbuf.getInt();
			if (version >= 700000000000018L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnKeyDataDesc = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
