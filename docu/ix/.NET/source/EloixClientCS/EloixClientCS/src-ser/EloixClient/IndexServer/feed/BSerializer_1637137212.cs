//
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_internalInsertSystemAction
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_1637137212 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1637137212();
		
		public BSerializer_1637137212()
			: base(1637137212) {}
		
		public BSerializer_1637137212(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_FeedService_internalInsertSystemAction obj = (BRequest_FeedService_internalInsertSystemAction)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.actionValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_FeedService_internalInsertSystemAction obj = (BRequest_FeedService_internalInsertSystemAction)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_FeedService_internalInsertSystemAction()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.actionValue = (EloixClient.IndexServer.feed.Action)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
