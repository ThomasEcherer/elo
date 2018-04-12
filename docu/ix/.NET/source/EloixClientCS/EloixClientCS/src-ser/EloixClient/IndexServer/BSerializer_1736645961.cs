//
// Serializer for de.elo.ix.client.BRequest_IXEventBusHandler_processEventBusEvents
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1736645961 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1736645961();
		
		public BSerializer_1736645961()
			: base(1736645961) {}
		
		public BSerializer_1736645961(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXEventBusHandler_processEventBusEvents obj = (BRequest_IXEventBusHandler_processEventBusEvents)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.subsIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.eventsValue, false, EloixClient.IndexServer.BSerializer_910482075.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXEventBusHandler_processEventBusEvents obj = (BRequest_IXEventBusHandler_processEventBusEvents)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXEventBusHandler_processEventBusEvents()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.subsIdValue = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.eventsValue = (EloixClient.IndexServer.Event[])bin.readObj(false, EloixClient.IndexServer.BSerializer_910482075.instance);
			
			return obj;
		}
		
	}
} // namespace
