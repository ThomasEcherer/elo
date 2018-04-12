//
// Serializer for de.elo.ix.client.feed.BRequest_FeedService_registerNotify
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_458959949 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_458959949();
		
		public BSerializer_458959949()
			: base(458959949) {}
		
		public BSerializer_458959949(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_FeedService_registerNotify obj = (BRequest_FeedService_registerNotify)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.feedGuidValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.notifyValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_FeedService_registerNotify obj = (BRequest_FeedService_registerNotify)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_FeedService_registerNotify()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.feedGuidValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.notifyValue = (EloixClient.IndexServer.feed.FeedNotification)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
