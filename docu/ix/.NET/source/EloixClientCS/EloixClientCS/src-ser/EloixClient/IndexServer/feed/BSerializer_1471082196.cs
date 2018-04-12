//
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_createHashTagSubscription
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_1471082196 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1471082196();
		
		public BSerializer_1471082196()
			: base(1471082196) {}
		
		public BSerializer_1471082196(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_FeedService_createHashTagSubscription obj = (BRequest_FeedService_createHashTagSubscription)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.hashtagGuidOrNameValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userGuidOrIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_FeedService_createHashTagSubscription obj = (BRequest_FeedService_createHashTagSubscription)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_FeedService_createHashTagSubscription()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.hashtagGuidOrNameValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userGuidOrIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
