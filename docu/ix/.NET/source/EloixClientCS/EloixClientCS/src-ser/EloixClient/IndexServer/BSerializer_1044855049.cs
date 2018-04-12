//
// Serializer for de.elo.ix.client.OcrRect
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1044855049 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1044855049();
		
		public BSerializer_1044855049()
			: base(1044855049) {}
		
		public BSerializer_1044855049(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			OcrRect obj = (OcrRect)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.bottom);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.left);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.right);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.top);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			OcrRect obj = (OcrRect)(obj1 != null ? obj1 : bin.onObjectCreated(new OcrRect()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.bottom = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.left = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.right = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.top = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
