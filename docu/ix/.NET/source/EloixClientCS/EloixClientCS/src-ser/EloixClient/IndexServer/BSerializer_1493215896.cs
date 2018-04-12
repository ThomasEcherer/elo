//
// Serializer for de.elo.ix.client.SubscriptionZ
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1493215896 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1493215896();
		
		public BSerializer_1493215896()
			: base(1493215896) {}
		
		public BSerializer_1493215896(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			SubscriptionZ obj = (SubscriptionZ)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.bset);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SubscriptionZ obj = (SubscriptionZ)(obj1 != null ? obj1 : bin.onObjectCreated(new SubscriptionZ()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.bset = bbuf.getLong();
			
			return obj;
		}
		
	}
} // namespace
