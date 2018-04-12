//
// Serializer for de.elo.ix.client.MapData
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2011132580 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2011132580();
		
		public BSerializer_2011132580()
			: base(2011132580) {}
		
		public BSerializer_2011132580(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			MapData obj = (MapData)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.TStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.domainName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lockId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lockName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.objId);
			if (version >= 800000024000002L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.guid);
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.items, false, EloixClient.IndexServer.BSerializer_1826370901.instance);
			if (version >= 1000000020000007L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.mapItems, false, EloixClient.IndexServer.BSerializer_1129834343.instance);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			MapData obj = (MapData)(obj1 != null ? obj1 : bin.onObjectCreated(new MapData()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.TStamp = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.domainName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getInt();
			if (version >= 800000024000002L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.guid = bbuf.getString();
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.items = (EloixClient.IndexServer.KeyValue[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1826370901.instance);
			if (version >= 1000000020000007L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.mapItems = (IDictionary<String,EloixClient.IndexServer.MapValue>)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace
