//
// Serializer for de.elo.ix.client.ReplSetCombinationC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_897151349 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_897151349();
		
		public BSerializer_897151349()
			: base(897151349) {}
		
		public BSerializer_897151349(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ReplSetCombinationC obj = (ReplSetCombinationC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnCombi);
			if (version >= 900990009000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnCombiGuid);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ReplSetCombinationC obj = (ReplSetCombinationC)(obj1 != null ? obj1 : bin.onObjectCreated(new ReplSetCombinationC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnCombi = bbuf.getInt();
			if (version >= 900990009000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnCombiGuid = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
