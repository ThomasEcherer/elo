//
// Serializer for de.elo.ix.client.PhysDel
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_124345500 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_124345500();
		
		public BSerializer_124345500()
			: base(124345500) {}
		
		public BSerializer_124345500(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			PhysDel obj = (PhysDel)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.TStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.guid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.type);
			if (version >= 900990009000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.TStampSync);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			PhysDel obj = (PhysDel)(obj1 != null ? obj1 : bin.onObjectCreated(new PhysDel()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.TStamp = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.guid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.type = bbuf.getInt();
			if (version >= 900990009000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.TStampSync = bbuf.getString();
			}
			
			return obj;
		}
		
	}
} // namespace
