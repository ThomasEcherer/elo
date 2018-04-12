//
// Serializer for de.elo.ix.client.DocMaskDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1968969939 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1968969939();
		
		public BSerializer_1968969939()
			: base(1968969939) {}
		
		public BSerializer_1968969939(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			DocMaskDataC obj = (DocMaskDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnBarcode);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnDAcl);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnIndex);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnLifetime);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnRawPosInfo);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnTStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnText);
			if (version >= 700000000000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnGuid);
				if (version >= 700000000000006L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.lnInternalAcl);
					if (version >= 900000018000005L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.lnNameTranslationKey);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.lnTextTranslationKey);
						if (version >= 900990009000001L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putInt(obj.lnTStampSync);
						}
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			DocMaskDataC obj = (DocMaskDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new DocMaskDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnBarcode = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnDAcl = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnIndex = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnLifetime = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnName = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnRawPosInfo = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnTStamp = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnText = bbuf.getInt();
			if (version >= 700000000000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnGuid = bbuf.getInt();
				if (version >= 700000000000006L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.lnInternalAcl = bbuf.getInt();
					if (version >= 900000018000005L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.lnNameTranslationKey = bbuf.getInt();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.lnTextTranslationKey = bbuf.getInt();
						if (version >= 900990009000001L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.lnTStampSync = bbuf.getInt();
						}
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace
