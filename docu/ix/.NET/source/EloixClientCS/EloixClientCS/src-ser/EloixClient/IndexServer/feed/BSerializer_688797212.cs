//
// Serializer for de.elo.ix.client.feed.BRequest_FeedNotification_updateAction
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_688797212 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_688797212();
		
		public BSerializer_688797212()
			: base(688797212) {}
		
		public BSerializer_688797212(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_FeedNotification_updateAction obj = (BRequest_FeedNotification_updateAction)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.actionValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_FeedNotification_updateAction obj = (BRequest_FeedNotification_updateAction)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_FeedNotification_updateAction()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.actionValue = (EloixClient.IndexServer.feed.Action)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
