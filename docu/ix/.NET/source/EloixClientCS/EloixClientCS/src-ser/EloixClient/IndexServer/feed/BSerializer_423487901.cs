//
// Serializer for de.elo.ix.client.feed.ActionDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_423487901 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_423487901();
		
		public BSerializer_423487901()
			: base(423487901) {}
		
		public BSerializer_423487901(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ActionDataC obj = (ActionDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnCreateDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnDocVersionGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnFeedGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnParentGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnTStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnText);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnUpdateDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnUserGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnWorkflowGuid);
			if (version >= 900000000000034L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnAcl);
				if (version >= 900990009000001L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.lnTStampSync);
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ActionDataC obj = (ActionDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new ActionDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnCreateDateIso = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnDocVersionGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnFeedGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnParentGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnTStamp = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnText = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnUpdateDateIso = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnUserGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnWorkflowGuid = bbuf.getInt();
			if (version >= 900000000000034L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnAcl = bbuf.getInt();
				if (version >= 900990009000001L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.lnTStampSync = bbuf.getInt();
				}
			}
			
			return obj;
		}
		
	}
} // namespace
