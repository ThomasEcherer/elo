//
// Serializer for de.elo.ix.client.feed.ActionHistDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_734763371 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_734763371();
		
		public BSerializer_734763371()
			: base(734763371) {}
		
		public BSerializer_734763371(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ActionHistDataC obj = (ActionHistDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnActionGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnCreateDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnText);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ActionHistDataC obj = (ActionHistDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new ActionHistDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnActionGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnCreateDateIso = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnText = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
