//
// Serializer for de.elo.ix.client.RelationC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1203469035 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1203469035();
		
		public BSerializer_1203469035()
			: base(1203469035) {}
		
		public BSerializer_1203469035(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			RelationC obj = (RelationC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnTStamp);
			if (version >= 700000000000004L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnGuid);
				if (version >= 900990009000001L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.lnTStampSync);
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			RelationC obj = (RelationC)(obj1 != null ? obj1 : bin.onObjectCreated(new RelationC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnTStamp = bbuf.getInt();
			if (version >= 700000000000004L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnGuid = bbuf.getInt();
				if (version >= 900990009000001L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.lnTStampSync = bbuf.getInt();
				}
			}
			
			return obj;
		}
		
	}
} // namespace
