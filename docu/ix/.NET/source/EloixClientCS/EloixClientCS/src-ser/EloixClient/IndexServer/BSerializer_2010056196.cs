//
// Serializer for de.elo.ix.client.NotificationDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2010056196 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_2010056196();
		
		public BSerializer_2010056196()
			: base(2010056196) {}
		
		public BSerializer_2010056196(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			NotificationDataC obj = (NotificationDataC)obj1;			
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
			NotificationDataC obj = (NotificationDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new NotificationDataC()));
			
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
