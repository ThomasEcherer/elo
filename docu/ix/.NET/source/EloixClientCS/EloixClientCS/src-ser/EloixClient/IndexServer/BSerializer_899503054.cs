//
// Serializer for de.elo.ix.client.RepliHist
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_899503054 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_899503054();
		
		public BSerializer_899503054()
			: base(899503054) {}
		
		public BSerializer_899503054(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			RepliHist obj = (RepliHist)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.arcDesc);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.arcGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.arcShort);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.imEx);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.succ);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.tSBegin);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.tSDate);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.tSEnd);
			if (version >= 900990009000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.arcPriorityLocal);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.arcPriorityRemote);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			RepliHist obj = (RepliHist)(obj1 != null ? obj1 : bin.onObjectCreated(new RepliHist()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.arcDesc = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.arcGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.arcShort = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.imEx = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.succ = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tSBegin = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tSDate = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tSEnd = bbuf.getString();
			if (version >= 900990009000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.arcPriorityLocal = bbuf.getInt();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.arcPriorityRemote = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
