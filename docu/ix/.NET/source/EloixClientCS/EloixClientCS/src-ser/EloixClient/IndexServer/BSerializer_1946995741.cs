//
// Serializer for de.elo.ix.client.ActivityProjectDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1946995741 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1946995741();
		
		public BSerializer_1946995741()
			: base(1946995741) {}
		
		public BSerializer_1946995741(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ActivityProjectDataC obj = (ActivityProjectDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnOptValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnProject);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ActivityProjectDataC obj = (ActivityProjectDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new ActivityProjectDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnOptValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnProject = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
