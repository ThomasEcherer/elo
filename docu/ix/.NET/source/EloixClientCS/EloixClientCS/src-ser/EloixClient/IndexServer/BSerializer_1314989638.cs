//
// Serializer for de.elo.ix.client.MapHistItemC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1314989638 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1314989638();
		
		public BSerializer_1314989638()
			: base(1314989638) {}
		
		public BSerializer_1314989638(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			MapHistItemC obj = (MapHistItemC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnHistGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnKey);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnValue);
			if (version >= 1000000020000011L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnBlobData);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnContentType);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			MapHistItemC obj = (MapHistItemC)(obj1 != null ? obj1 : bin.onObjectCreated(new MapHistItemC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnHistGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnKey = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnValue = bbuf.getInt();
			if (version >= 1000000020000011L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnBlobData = bbuf.getInt();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnContentType = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
