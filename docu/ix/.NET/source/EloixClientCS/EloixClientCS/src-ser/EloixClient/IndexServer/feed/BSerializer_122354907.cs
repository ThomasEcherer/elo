//
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_checkoutHashTag
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_122354907 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_122354907();
		
		public BSerializer_122354907()
			: base(122354907) {}
		
		public BSerializer_122354907(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_FeedService_checkoutHashTag obj = (BRequest_FeedService_checkoutHashTag)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.hashtagGuidOrNameValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.hstgZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_FeedService_checkoutHashTag obj = (BRequest_FeedService_checkoutHashTag)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_FeedService_checkoutHashTag()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.hashtagGuidOrNameValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.hstgZValue = (EloixClient.IndexServer.feed.HashTagZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
