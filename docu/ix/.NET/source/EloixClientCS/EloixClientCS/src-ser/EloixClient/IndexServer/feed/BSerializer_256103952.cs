//
// Serializer for de.elo.ix.client.feed.FindHashTagInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_256103952 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_256103952();
		
		public BSerializer_256103952()
			: base(256103952) {}
		
		public BSerializer_256103952(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			FindHashTagInfo obj = (FindHashTagInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.createDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.hashtagGuidOrName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lastUsedIso);
			if (version >= 900000030000004L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.minCount);
				if (version >= 900000030000007L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putBoolean(obj.findFeeds);
					if (version >= 900000030000016L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putBoolean(obj.findSubscriptions);
						if (version >= 900000030000020L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putBoolean(obj.findHashTags);
						}
					}
				}
			}
			if (version >= 900000030000007L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.actionZ, false, null);
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.sordZ, false, null);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindHashTagInfo obj = (FindHashTagInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new FindHashTagInfo()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.createDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.hashtagGuidOrName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lastUsedIso = bbuf.getString();
			if (version >= 900000030000004L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.minCount = bbuf.getInt();
				if (version >= 900000030000007L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.findFeeds = bbuf.getBoolean();
					if (version >= 900000030000016L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.findSubscriptions = bbuf.getBoolean();
						if (version >= 900000030000020L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.findHashTags = bbuf.getBoolean();
						}
					}
				}
			}
			if (version >= 900000030000007L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.actionZ = (EloixClient.IndexServer.feed.ActionZ)bin.readObj(false, null);
				// checkpoint byps.gen.cs.PrintContext:449
				obj.sordZ = (EloixClient.IndexServer.SordZ)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace
