//
// Serializer for de.elo.ix.client.ColorData
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1735048729 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1735048729();
		
		public BSerializer_1735048729()
			: base(1735048729) {}
		
		public BSerializer_1735048729(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ColorData obj = (ColorData)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.RGB);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			if (version >= 700000000000003L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.TStamp);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.deleted);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.guid);
				if (version >= 900990009000001L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.TStampSync);
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ColorData obj = (ColorData)(obj1 != null ? obj1 : bin.onObjectCreated(new ColorData()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.RGB = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			if (version >= 700000000000003L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.TStamp = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.deleted = bbuf.getBoolean();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.guid = bbuf.getString();
				if (version >= 900990009000001L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.TStampSync = bbuf.getString();
				}
			}
			
			return obj;
		}
		
	}
} // namespace
