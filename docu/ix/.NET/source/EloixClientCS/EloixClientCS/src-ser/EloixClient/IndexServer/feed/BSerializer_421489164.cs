//
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_findHashTagByActions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_421489164 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_421489164();
		
		public BSerializer_421489164()
			: base(421489164) {}
		
		public BSerializer_421489164(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_FeedService_findHashTagByActions obj = (BRequest_FeedService_findHashTagByActions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.actionGuidsValue, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.hashTagZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_FeedService_findHashTagByActions obj = (BRequest_FeedService_findHashTagByActions)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_FeedService_findHashTagByActions()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.actionGuidsValue = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.hashTagZValue = (EloixClient.IndexServer.feed.HashTagZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
