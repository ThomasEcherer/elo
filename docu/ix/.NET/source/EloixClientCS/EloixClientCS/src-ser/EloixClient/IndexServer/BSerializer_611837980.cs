//
// Serializer for de.elo.ix.client.NoteFreehand
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_611837980 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_611837980();
		
		public BSerializer_611837980()
			: base(611837980) {}
		
		public BSerializer_611837980(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			NoteFreehand obj = (NoteFreehand)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.width);
			if (version >= 700000000000039L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.strikeoutColor);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.strikeoutWidth);
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.points, false, EloixClient.IndexServer.BSerializer_1853594537.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			NoteFreehand obj = (NoteFreehand)(obj1 != null ? obj1 : bin.onObjectCreated(new NoteFreehand()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.width = bbuf.getInt();
			if (version >= 700000000000039L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.strikeoutColor = bbuf.getInt();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.strikeoutWidth = bbuf.getInt();
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.points = (EloixClient.IndexServer.PointInfo[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1853594537.instance);
			
			return obj;
		}
		
	}
} // namespace
