//
// Serializer for de.elo.ix.client.ReplSet
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1124529321 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1124529321();
		
		public BSerializer_1124529321()
			: base(1124529321) {}
		
		public BSerializer_1124529321(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ReplSet obj = (ReplSet)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.objId);
			if (version >= 900990009000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.TStamp);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.TStampSync);
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.dw, false, EloixClient.IndexServer.BSerializer_100361105.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ReplSet obj = (ReplSet)(obj1 != null ? obj1 : bin.onObjectCreated(new ReplSet()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getInt();
			if (version >= 900990009000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.TStamp = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.TStampSync = bbuf.getString();
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dw = (int[])bin.readObj(false, EloixClient.IndexServer.BSerializer_100361105.instance);
			
			return obj;
		}
		
	}
} // namespace
