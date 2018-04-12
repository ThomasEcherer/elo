//
// Serializer for de.elo.ix.client.StoreInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_964052256 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_964052256();
		
		public BSerializer_964052256()
			: base(964052256) {}
		
		public BSerializer_964052256(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			StoreInfo obj = (StoreInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.createDateISO);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.dir);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.flags);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.scatter);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.stdPath);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.updateDateISO);
			if (version >= 800000010000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.fulltextDir);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.previewDir);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			StoreInfo obj = (StoreInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new StoreInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.createDateISO = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dir = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flags = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.scatter = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.stdPath = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.updateDateISO = bbuf.getString();
			if (version >= 800000010000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.fulltextDir = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.previewDir = bbuf.getString();
			}
			
			return obj;
		}
		
	}
} // namespace
