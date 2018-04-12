//
// Serializer for de.elo.ix.client.FindSubscriptionInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1419135016 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1419135016();
		
		public BSerializer_1419135016()
			: base(1419135016) {}
		
		public BSerializer_1419135016(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FindSubscriptionInfo obj = (FindSubscriptionInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			if (version >= 900000014000005L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.userId);
			}
			if (version >= 900000014000005L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.feedZ, false, null);
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.sordZ, false, null);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindSubscriptionInfo obj = (FindSubscriptionInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new FindSubscriptionInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			if (version >= 900000014000005L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.userId = bbuf.getString();
			}
			if (version >= 900000014000005L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.feedZ = (EloixClient.IndexServer.feed.FeedZ)bin.readObj(false, null);
				// checkpoint byps.gen.cs.PrintContext:449
				obj.sordZ = (EloixClient.IndexServer.SordZ)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace
