//
// Serializer for de.elo.ix.client.ObjKeyDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2463451 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_2463451();
		
		public BSerializer_2463451()
			: base(2463451) {}
		
		public BSerializer_2463451(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ObjKeyDataC obj = (ObjKeyDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnData);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnSdata);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnUdata);
			if (version >= 900000000000021L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnOdouble);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ObjKeyDataC obj = (ObjKeyDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new ObjKeyDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnData = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnName = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnSdata = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnUdata = bbuf.getInt();
			if (version >= 900000000000021L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnOdouble = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
