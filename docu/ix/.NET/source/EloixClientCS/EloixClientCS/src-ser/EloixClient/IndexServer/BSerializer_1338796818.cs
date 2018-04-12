//
// Serializer for de.elo.ix.client.KeywordC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1338796818 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1338796818();
		
		public BSerializer_1338796818()
			: base(1338796818) {}
		
		public BSerializer_1338796818(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			KeywordC obj = (KeywordC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnRootId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnText);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			KeywordC obj = (KeywordC)(obj1 != null ? obj1 : bin.onObjectCreated(new KeywordC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnRootId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnText = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
