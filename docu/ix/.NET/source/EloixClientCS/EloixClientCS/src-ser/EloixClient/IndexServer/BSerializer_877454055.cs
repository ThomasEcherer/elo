//
// Serializer for de.elo.ix.client.Event
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_877454055 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_877454055();
		
		public BSerializer_877454055()
			: base(877454055) {}
		
		public BSerializer_877454055(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			Event obj = (Event)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.busId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.param1);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.param2);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.senderId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.type);
			if (version >= 800000010000005L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.acl);
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.any, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.data, false, EloixClient.IndexServer.BSerializer_1374008726.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			Event obj = (Event)(obj1 != null ? obj1 : bin.onObjectCreated(new Event()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.busId = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.param1 = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.param2 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.senderId = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.type = bbuf.getLong();
			if (version >= 800000010000005L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.acl = bbuf.getString();
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.any = (EloixClient.IndexServer.Any)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.data = (byte[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1374008726.instance);
			
			return obj;
		}
		
	}
} // namespace
