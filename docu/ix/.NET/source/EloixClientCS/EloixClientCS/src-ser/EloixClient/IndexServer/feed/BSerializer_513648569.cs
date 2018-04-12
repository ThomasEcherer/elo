//
// Serializer for de.elo.ix.client.feed.HashTagDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_513648569 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_513648569();
		
		public BSerializer_513648569()
			: base(513648569) {}
		
		public BSerializer_513648569(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			HashTagDataC obj = (HashTagDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnCreateDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnHstgGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnHstgName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnLastUsedIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnTStamp);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			HashTagDataC obj = (HashTagDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new HashTagDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnCreateDateIso = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnHstgGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnHstgName = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnLastUsedIso = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnTStamp = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
