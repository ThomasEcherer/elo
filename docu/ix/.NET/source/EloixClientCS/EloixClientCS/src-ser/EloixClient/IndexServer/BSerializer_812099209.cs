//
// Serializer for de.elo.ix.client.MapHistHeadC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_812099209 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_812099209();
		
		public BSerializer_812099209()
			: base(812099209) {}
		
		public BSerializer_812099209(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			MapHistHeadC obj = (MapHistHeadC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnHistGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnMapGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnTimeStampLocal);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnTimeStampUTC);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnUserName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnWorkStation);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			MapHistHeadC obj = (MapHistHeadC)(obj1 != null ? obj1 : bin.onObjectCreated(new MapHistHeadC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnHistGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnMapGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnTimeStampLocal = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnTimeStampUTC = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnUserName = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnWorkStation = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
