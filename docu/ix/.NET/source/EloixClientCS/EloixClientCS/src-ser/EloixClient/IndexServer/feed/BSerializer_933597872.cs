//
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_findNextActions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_933597872 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_933597872();
		
		public BSerializer_933597872()
			: base(933597872) {}
		
		public BSerializer_933597872(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_FeedService_findNextActions obj = (BRequest_FeedService_findNextActions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.idxValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.maxValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.searchIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.actionZValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_FeedService_findNextActions obj = (BRequest_FeedService_findNextActions)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_FeedService_findNextActions()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.idxValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.maxValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.searchIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.actionZValue = (EloixClient.IndexServer.feed.ActionZ)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
