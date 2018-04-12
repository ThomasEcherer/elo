//
// Serializer for de.elo.ix.client.FindByFulltextCtrl
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_96165507 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_96165507();
		
		public BSerializer_96165507()
			: base(96165507) {}
		
		public BSerializer_96165507(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			FindByFulltextCtrl obj = (FindByFulltextCtrl)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.endTStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.startTStamp);
			if (version >= 900000040000002L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.onlyDocs);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.profileKeyPrefix);
				if (version >= 1000000000000006L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putBoolean(obj.reindex);
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindByFulltextCtrl obj = (FindByFulltextCtrl)(obj1 != null ? obj1 : bin.onObjectCreated(new FindByFulltextCtrl()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.endTStamp = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.startTStamp = bbuf.getString();
			if (version >= 900000040000002L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.onlyDocs = bbuf.getBoolean();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.profileKeyPrefix = bbuf.getString();
				if (version >= 1000000000000006L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.reindex = bbuf.getBoolean();
				}
			}
			
			return obj;
		}
		
	}
} // namespace
