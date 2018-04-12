//
// Serializer for de.elo.ix.client.MapHead
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1379783697 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1379783697();
		
		public BSerializer_1379783697()
			: base(1379783697) {}
		
		public BSerializer_1379783697(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			MapHead obj = (MapHead)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.TStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lockId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.objId);
			if (version >= 700000040000013L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.guid);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			MapHead obj = (MapHead)(obj1 != null ? obj1 : bin.onObjectCreated(new MapHead()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.TStamp = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getInt();
			if (version >= 700000040000013L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.guid = bbuf.getString();
			}
			
			return obj;
		}
		
	}
} // namespace
