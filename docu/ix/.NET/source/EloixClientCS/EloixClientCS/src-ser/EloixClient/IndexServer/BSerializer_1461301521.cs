//
// Serializer for de.elo.ix.client.MapItem
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1461301521 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1461301521();
		
		public BSerializer_1461301521()
			: base(1461301521) {}
		
		public BSerializer_1461301521(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			MapItem obj = (MapItem)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.contentType);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.key);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.value);
			if (version >= 1000000020000005L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.blobData, false, null);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			MapItem obj = (MapItem)(obj1 != null ? obj1 : bin.onObjectCreated(new MapItem()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.contentType = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.key = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.value = bbuf.getString();
			if (version >= 1000000020000005L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.blobData = (System.IO.Stream)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace
