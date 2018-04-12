//
// Serializer for de.elo.ix.client.EventBusParams
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1489333610 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1489333610();
		
		public BSerializer_1489333610()
			: base(1489333610) {}
		
		public BSerializer_1489333610(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			EventBusParams obj = (EventBusParams)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.channelId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ticket);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userId);
			if (version >= 800000032000011L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.noForwardToOtherIxs);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			EventBusParams obj = (EventBusParams)(obj1 != null ? obj1 : bin.onObjectCreated(new EventBusParams()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.channelId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ticket = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userId = bbuf.getString();
			if (version >= 800000032000011L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.noForwardToOtherIxs = bbuf.getBoolean();
			}
			
			return obj;
		}
		
	}
} // namespace
