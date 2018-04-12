//
// Serializer for de.elo.ix.client.Alert
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_280775671 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_280775671();
		
		public BSerializer_280775671()
			: base(280775671) {}
		
		public BSerializer_280775671(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			Alert obj = (Alert)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.dest);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.extra1);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.extra2);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.memo);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.objId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.source);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.time);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.type);
			if (version >= 600000099000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.destName);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.sourceName);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.timeIso);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			Alert obj = (Alert)(obj1 != null ? obj1 : bin.onObjectCreated(new Alert()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dest = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.extra1 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.extra2 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.memo = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.source = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.time = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.type = bbuf.getInt();
			if (version >= 600000099000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.destName = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.sourceName = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.timeIso = bbuf.getString();
			}
			
			return obj;
		}
		
	}
} // namespace
