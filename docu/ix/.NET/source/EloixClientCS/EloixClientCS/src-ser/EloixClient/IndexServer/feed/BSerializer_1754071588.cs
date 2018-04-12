//
// Serializer for de.elo.ix.client.feed.FeedC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_1754071588 : EloixClient.IndexServer.feed.BSerializer_1837685365 {
		
		public readonly static new BSerializer instance = new BSerializer_1754071588();
		
		public BSerializer_1754071588()
			: base(1754071588) {}
		
		public BSerializer_1754071588(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FeedC obj = (FeedC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FeedC obj = (FeedC)(obj1 != null ? obj1 : bin.onObjectCreated(new FeedC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
