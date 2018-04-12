//
// Serializer for de.elo.ix.client.WFNodeC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1514069164 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1514069164();
		
		public BSerializer_1514069164()
			: base(1514069164) {}
		
		public BSerializer_1514069164(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			WFNodeC obj = (WFNodeC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnComment);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnCondition);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnOnEnter);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnOnExit);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnYesNoCondition);
			if (version >= 700000000000015L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnProcessOnServerId);
				if (version >= 900000000000029L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.lnFormSpec);
					if (version >= 900000018000007L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.lnCommentTranslationKey);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.lnNameTranslationKey);
						if (version >= 900000022000019L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putInt(obj.lnLabel);
							if (version >= 900000030000021L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putInt(obj.lnLabelTranslationKey);
								if (version >= 900000050000004L) {
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putInt(obj.lnProperties);
								}
							}
						}
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WFNodeC obj = (WFNodeC)(obj1 != null ? obj1 : bin.onObjectCreated(new WFNodeC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnComment = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnCondition = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnName = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnOnEnter = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnOnExit = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnYesNoCondition = bbuf.getInt();
			if (version >= 700000000000015L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnProcessOnServerId = bbuf.getInt();
				if (version >= 900000000000029L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.lnFormSpec = bbuf.getInt();
					if (version >= 900000018000007L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.lnCommentTranslationKey = bbuf.getInt();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.lnNameTranslationKey = bbuf.getInt();
						if (version >= 900000022000019L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.lnLabel = bbuf.getInt();
							if (version >= 900000030000021L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.lnLabelTranslationKey = bbuf.getInt();
								if (version >= 900000050000004L) {
									// checkpoint byps.gen.cs.PrintContext:449
									obj.lnProperties = bbuf.getInt();
								}
							}
						}
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace
