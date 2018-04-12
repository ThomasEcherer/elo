//
// Serializer for de.elo.ix.client.EloFtOptDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1220982870 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1220982870();
		
		public BSerializer_1220982870()
			: base(1220982870) {}
		
		public BSerializer_1220982870(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			EloFtOptDataC obj = (EloFtOptDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnRemark);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnValue);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			EloFtOptDataC obj = (EloFtOptDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new EloFtOptDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnRemark = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnValue = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
