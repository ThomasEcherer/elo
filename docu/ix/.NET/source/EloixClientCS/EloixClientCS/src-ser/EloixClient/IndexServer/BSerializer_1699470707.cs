//
// Serializer for de.elo.ix.client.TranslateTermDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1699470707 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1699470707();
		
		public BSerializer_1699470707()
			: base(1699470707) {}
		
		public BSerializer_1699470707(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			TranslateTermDataC obj = (TranslateTermDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnLang1);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnLang2);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnLang3);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnLang4);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnLang5);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnLang6);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnLang7);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnLang8);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnLang9);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnTStamp);
			if (version >= 900990009000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnTStampSync);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			TranslateTermDataC obj = (TranslateTermDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new TranslateTermDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnLang1 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnLang2 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnLang3 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnLang4 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnLang5 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnLang6 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnLang7 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnLang8 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnLang9 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnTStamp = bbuf.getInt();
			if (version >= 900990009000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnTStampSync = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
