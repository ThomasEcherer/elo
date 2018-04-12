//
// Serializer for de.elo.ix.client.FileDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1011013570 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1011013570();
		
		public BSerializer_1011013570()
			: base(1011013570) {}
		
		public BSerializer_1011013570(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			FileDataC obj = (FileDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			if (version >= 1000000020000007L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnContentType);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FileDataC obj = (FileDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new FileDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			if (version >= 1000000020000007L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnContentType = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
