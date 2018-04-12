//
// Serializer for de.elo.ix.client.PointInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1225068828 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1225068828();
		
		public BSerializer_1225068828()
			: base(1225068828) {}
		
		public BSerializer_1225068828(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			PointInfo obj = (PointInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.x);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.y);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			PointInfo obj = (PointInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new PointInfo()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.x = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.y = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
