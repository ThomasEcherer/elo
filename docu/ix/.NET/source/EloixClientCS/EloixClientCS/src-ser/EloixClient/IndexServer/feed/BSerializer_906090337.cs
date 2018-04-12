//
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_findFirstNotification
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_906090337 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_906090337();
		
		public BSerializer_906090337()
			: base(906090337) {}
		
		public BSerializer_906090337(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_FeedService_findFirstNotification obj = (BRequest_FeedService_findFirstNotification)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.maxValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.findInfoValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_FeedService_findFirstNotification obj = (BRequest_FeedService_findFirstNotification)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_FeedService_findFirstNotification()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.maxValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.findInfoValue = (EloixClient.IndexServer.feed.FindNotificationInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
