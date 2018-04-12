//
// Serializer for de.elo.ix.client.ObjChangeC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1100272528 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1100272528();
		
		public BSerializer_1100272528()
			: base(1100272528) {}
		
		public BSerializer_1100272528(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ObjChangeC obj = (ObjChangeC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnObjId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnParam2);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnTStamp);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ObjChangeC obj = (ObjChangeC)(obj1 != null ? obj1 : bin.onObjectCreated(new ObjChangeC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnObjId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnParam2 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnTStamp = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
