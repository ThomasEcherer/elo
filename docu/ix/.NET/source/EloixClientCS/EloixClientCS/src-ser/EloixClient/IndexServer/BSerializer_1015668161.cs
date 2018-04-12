//
// Serializer for de.elo.ix.client.ObjLinkC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1015668161 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1015668161();
		
		public BSerializer_1015668161()
			: base(1015668161) {}
		
		public BSerializer_1015668161(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ObjLinkC obj = (ObjLinkC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnLinkId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnParentId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnTStamp);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ObjLinkC obj = (ObjLinkC)(obj1 != null ? obj1 : bin.onObjectCreated(new ObjLinkC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnLinkId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnParentId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnTStamp = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
