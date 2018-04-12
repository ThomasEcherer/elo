//
// Serializer for de.elo.ix.client.EloIxOpt_oldC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1148546611 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1148546611();
		
		public BSerializer_1148546611()
			: base(1148546611) {}
		
		public BSerializer_1148546611(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			EloIxOpt_oldC obj = (EloIxOpt_oldC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnOptVal);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnRemark);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			EloIxOpt_oldC obj = (EloIxOpt_oldC)(obj1 != null ? obj1 : bin.onObjectCreated(new EloIxOpt_oldC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnOptVal = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnRemark = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
