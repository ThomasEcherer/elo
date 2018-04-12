//
// Serializer for de.elo.ix.client.feed.FindNotificationInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_432579435 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_432579435();
		
		public BSerializer_432579435()
			: base(432579435) {}
		
		public BSerializer_432579435(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			FindNotificationInfo obj = (FindNotificationInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.createDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclImportant);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userGuidOrID);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.what);
			if (version >= 900000030000007L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.findFeeds);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.findHashTags);
				if (version >= 900000030000016L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putBoolean(obj.findSubscriptions);
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sordZ, false, null);
			if (version >= 900000030000007L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.actionZ, false, null);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindNotificationInfo obj = (FindNotificationInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new FindNotificationInfo()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.createDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclImportant = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userGuidOrID = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.what = bbuf.getInt();
			if (version >= 900000030000007L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.findFeeds = bbuf.getBoolean();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.findHashTags = bbuf.getBoolean();
				if (version >= 900000030000016L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.findSubscriptions = bbuf.getBoolean();
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sordZ = (EloixClient.IndexServer.SordZ)bin.readObj(false, null);
			if (version >= 900000030000007L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.actionZ = (EloixClient.IndexServer.feed.ActionZ)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace
