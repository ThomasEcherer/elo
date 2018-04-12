//
// Serializer for de.elo.ix.client.ObjKeyData
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1508164560 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1508164560();
		
		public BSerializer_1508164560()
			: base(1508164560) {}
		
		public BSerializer_1508164560(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ObjKeyData obj = (ObjKeyData)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.data);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.objId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.sdata);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.udata);
			if (version >= 900000000000021L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putDouble(obj.odouble);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ObjKeyData obj = (ObjKeyData)(obj1 != null ? obj1 : bin.onObjectCreated(new ObjKeyData()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.data = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sdata = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.udata = bbuf.getString();
			if (version >= 900000000000021L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.odouble = bbuf.getDouble();
			}
			
			return obj;
		}
		
	}
} // namespace
