//
// Serializer for de.elo.ix.client.QueryJobProtocolEvent
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_892520690 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_892520690();
		
		public BSerializer_892520690()
			: base(892520690) {}
		
		public BSerializer_892520690(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			QueryJobProtocolEvent obj = (QueryJobProtocolEvent)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.date);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.level);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.message);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.objId);
			if (version >= 900000000000026L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.eventId);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			QueryJobProtocolEvent obj = (QueryJobProtocolEvent)(obj1 != null ? obj1 : bin.onObjectCreated(new QueryJobProtocolEvent()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.date = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.level = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.message = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getInt();
			if (version >= 900000000000026L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.eventId = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
