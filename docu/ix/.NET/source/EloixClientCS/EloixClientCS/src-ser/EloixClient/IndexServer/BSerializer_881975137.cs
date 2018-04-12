//
// Serializer for de.elo.ix.client.ColorDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_881975137 : EloixClient.IndexServer.BSerializer_1208511866 {
		
		public readonly static new BSerializer instance = new BSerializer_881975137();
		
		public BSerializer_881975137()
			: base(881975137) {}
		
		public BSerializer_881975137(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ColorDataC obj = (ColorDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			if (version >= 700000000000003L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.GUID_BLUE);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.GUID_GREEN);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.GUID_RED);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.GUID_SYSTEM);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ColorDataC obj = (ColorDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new ColorDataC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			if (version >= 700000000000003L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.GUID_BLUE = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.GUID_GREEN = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.GUID_RED = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.GUID_SYSTEM = bbuf.getString();
			}
			
			return obj;
		}
		
	}
} // namespace
