//
// Serializer for de.elo.ix.client.DocInfoDMC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1042422760 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1042422760();
		
		public BSerializer_1042422760()
			: base(1042422760) {}
		
		public BSerializer_1042422760(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			DocInfoDMC obj = (DocInfoDMC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnCreateDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnExt);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnFclip);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnLastAccessIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnLastUpdateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnMd5);
			if (version >= 600000097000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnExtOrig);
				if (version >= 700000026000001L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.lnPreviewExt);
					if (version >= 700000040000006L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.lnFulltextContentTStamp);
						if (version >= 900000000000023L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putInt(obj.lnPreviewSizeL);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putInt(obj.lnSizeL);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putInt(obj.lnSizeOrigL);
							if (version >= 900000030000023L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putInt(obj.lnRelFilePath);
							}
						}
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			DocInfoDMC obj = (DocInfoDMC)(obj1 != null ? obj1 : bin.onObjectCreated(new DocInfoDMC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnCreateDateIso = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnExt = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnFclip = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnLastAccessIso = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnLastUpdateIso = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnMd5 = bbuf.getInt();
			if (version >= 600000097000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnExtOrig = bbuf.getInt();
				if (version >= 700000026000001L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.lnPreviewExt = bbuf.getInt();
					if (version >= 700000040000006L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.lnFulltextContentTStamp = bbuf.getInt();
						if (version >= 900000000000023L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.lnPreviewSizeL = bbuf.getInt();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.lnSizeL = bbuf.getInt();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.lnSizeOrigL = bbuf.getInt();
							if (version >= 900000030000023L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.lnRelFilePath = bbuf.getInt();
							}
						}
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace
