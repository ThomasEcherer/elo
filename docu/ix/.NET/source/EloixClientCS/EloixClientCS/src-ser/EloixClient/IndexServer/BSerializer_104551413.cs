//
// Serializer for de.elo.ix.client.RepliHistC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_104551413 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_104551413();
		
		public BSerializer_104551413()
			: base(104551413) {}
		
		public BSerializer_104551413(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			RepliHistC obj = (RepliHistC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnArcDesc);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnArcGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnArcShort);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnTSBegin);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnTSDate);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnTSEnd);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			RepliHistC obj = (RepliHistC)(obj1 != null ? obj1 : bin.onObjectCreated(new RepliHistC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnArcDesc = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnArcGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnArcShort = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnTSBegin = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnTSDate = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnTSEnd = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
