//
// Serializer for de.elo.ix.client.CheckoutSordPathInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_730679282 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_730679282();
		
		public BSerializer_730679282()
			: base(730679282) {}
		
		public BSerializer_730679282(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			CheckoutSordPathInfo obj = (CheckoutSordPathInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclRefPaths);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			CheckoutSordPathInfo obj = (CheckoutSordPathInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new CheckoutSordPathInfo()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclRefPaths = bbuf.getBoolean();
			
			return obj;
		}
		
	}
} // namespace
