//
// Serializer for de.elo.ix.client.MapDomainDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_915355095 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_915355095();
		
		public BSerializer_915355095()
			: base(915355095) {}
		
		public BSerializer_915355095(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			MapDomainDataC obj = (MapDomainDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnName);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			MapDomainDataC obj = (MapDomainDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new MapDomainDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnName = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
