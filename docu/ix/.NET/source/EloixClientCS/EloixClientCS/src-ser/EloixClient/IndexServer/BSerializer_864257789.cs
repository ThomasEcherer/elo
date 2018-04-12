//
// Serializer for de.elo.ix.client.OrgUnitInfoC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_864257789 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_864257789();
		
		public BSerializer_864257789()
			: base(864257789) {}
		
		public BSerializer_864257789(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			OrgUnitInfoC obj = (OrgUnitInfoC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnDesc);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnOuProp);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			OrgUnitInfoC obj = (OrgUnitInfoC)(obj1 != null ? obj1 : bin.onObjectCreated(new OrgUnitInfoC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnDesc = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnName = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnOuProp = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
