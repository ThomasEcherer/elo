//
// Serializer for de.elo.ix.client.OcrWorker
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_730157667 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_730157667();
		
		public BSerializer_730157667()
			: base(730157667) {}
		
		public BSerializer_730157667(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			OcrWorker obj = (OcrWorker)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.busId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.lastUsed);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.state);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.subsId);
			if (version >= 1000170010000006L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putLong(obj.reserved);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			OcrWorker obj = (OcrWorker)(obj1 != null ? obj1 : bin.onObjectCreated(new OcrWorker()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.busId = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lastUsed = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.state = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.subsId = bbuf.getLong();
			if (version >= 1000170010000006L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.reserved = bbuf.getLong();
			}
			
			return obj;
		}
		
	}
} // namespace
