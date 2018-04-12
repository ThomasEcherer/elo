//
// Serializer for de.elo.ix.client.ReportC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1285453013 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1285453013();
		
		public BSerializer_1285453013()
			: base(1285453013) {}
		
		public BSerializer_1285453013(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ReportC obj = (ReportC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnText);
			if (version >= 900000016000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnExtra3);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ReportC obj = (ReportC)(obj1 != null ? obj1 : bin.onObjectCreated(new ReportC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnText = bbuf.getInt();
			if (version >= 900000016000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnExtra3 = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
