//
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_checkinAction
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_1138765790 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1138765790();
		
		public BSerializer_1138765790()
			: base(1138765790) {}
		
		public BSerializer_1138765790(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_FeedService_checkinAction obj = (BRequest_FeedService_checkinAction)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.actionValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.actionZValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_FeedService_checkinAction obj = (BRequest_FeedService_checkinAction)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_FeedService_checkinAction()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.actionValue = (EloixClient.IndexServer.feed.Action)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.actionZValue = (EloixClient.IndexServer.feed.ActionZ)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
