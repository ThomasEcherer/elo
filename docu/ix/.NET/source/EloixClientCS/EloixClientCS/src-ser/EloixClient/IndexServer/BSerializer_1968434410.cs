//
// Serializer for de.elo.ix.client.UserProfileC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1968434410 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1968434410();
		
		public BSerializer_1968434410()
			: base(1968434410) {}
		
		public BSerializer_1968434410(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			UserProfileC obj = (UserProfileC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			if (version >= 700000000000036L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnKey);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnValue);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			UserProfileC obj = (UserProfileC)(obj1 != null ? obj1 : bin.onObjectCreated(new UserProfileC()));
			
			BBufferBin bbuf = bin.bbuf;
			if (version >= 700000000000036L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnKey = bbuf.getInt();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnValue = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
