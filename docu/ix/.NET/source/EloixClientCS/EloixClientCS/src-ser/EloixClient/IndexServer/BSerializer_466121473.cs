//
// Serializer for de.elo.ix.client.UserProfileDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_466121473 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_466121473();
		
		public BSerializer_466121473()
			: base(466121473) {}
		
		public BSerializer_466121473(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			UserProfileDataC obj = (UserProfileDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnKey);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnValue);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			UserProfileDataC obj = (UserProfileDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new UserProfileDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnKey = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnValue = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
