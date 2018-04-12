//
// Serializer for de.elo.ix.client.TranslateTermData
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_486835904 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_486835904();
		
		public BSerializer_486835904()
			: base(486835904) {}
		
		public BSerializer_486835904(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			TranslateTermData obj = (TranslateTermData)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.TStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.guid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lang1);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lang2);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lang3);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lang4);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lang5);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lang6);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lang7);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lang8);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lang9);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.status);
			if (version >= 900990009000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.TStampSync);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			TranslateTermData obj = (TranslateTermData)(obj1 != null ? obj1 : bin.onObjectCreated(new TranslateTermData()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.TStamp = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.guid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lang1 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lang2 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lang3 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lang4 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lang5 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lang6 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lang7 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lang8 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lang9 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.status = bbuf.getInt();
			if (version >= 900990009000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.TStampSync = bbuf.getString();
			}
			
			return obj;
		}
		
	}
} // namespace
