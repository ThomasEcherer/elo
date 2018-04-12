//
// Serializer for de.elo.ix.client.SordPath
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_544862901 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_544862901();
		
		public BSerializer_544862901()
			: base(544862901) {}
		
		public BSerializer_544862901(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			SordPath obj = (SordPath)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sords, false, EloixClient.IndexServer.BSerializer_2106404937.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SordPath obj = (SordPath)(obj1 != null ? obj1 : bin.onObjectCreated(new SordPath()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sords = (IList<EloixClient.IndexServer.Sord>)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
