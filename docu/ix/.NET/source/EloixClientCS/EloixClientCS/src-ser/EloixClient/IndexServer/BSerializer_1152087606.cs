//
// Serializer for de.elo.ix.client.SubscriptionDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1152087606 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1152087606();
		
		public BSerializer_1152087606()
			: base(1152087606) {}
		
		public BSerializer_1152087606(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			SubscriptionDataC obj = (SubscriptionDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnCreateDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnUserGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnWatchGuid);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SubscriptionDataC obj = (SubscriptionDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new SubscriptionDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnCreateDateIso = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnUserGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnWatchGuid = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
