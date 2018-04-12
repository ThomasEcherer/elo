//
// Serializer for de.elo.ix.client.EventFilter
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1095275943 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1095275943();
		
		public BSerializer_1095275943()
			: base(1095275943) {}
		
		public BSerializer_1095275943(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			EventFilter obj = (EventFilter)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.busId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.param1);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.param2);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.type);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			EventFilter obj = (EventFilter)(obj1 != null ? obj1 : bin.onObjectCreated(new EventFilter()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.busId = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.param1 = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.param2 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.type = bbuf.getLong();
			
			return obj;
		}
		
	}
} // namespace
