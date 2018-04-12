//
// Serializer for de.elo.ix.client.WorkFlowActiveDocC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_509854692 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_509854692();
		
		public BSerializer_509854692()
			: base(509854692) {}
		
		public BSerializer_509854692(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			WorkFlowActiveDocC obj = (WorkFlowActiveDocC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnComment);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnCondition);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnFlowName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnLabelTranslationKey);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnOnActivate);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnOnTerminate);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnUserTerminate);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnYNCondition);
			if (version >= 700000000000008L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnVersionName);
				if (version >= 700000000000014L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.lnNextServerId);
					if (version >= 700000000000018L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.lnVersionTag);
						if (version >= 700000040000012L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putInt(obj.lnFormSpec);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putInt(obj.lnIconId);
							if (version >= 900000018000005L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putInt(obj.lnCommentTranslationKey);
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putInt(obj.lnFlowNameTranslationKey);
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putInt(obj.lnNameTranslationKey);
								if (version >= 900000022000019L) {
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putInt(obj.lnLabel);
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putInt(obj.lnProperties);
									if (version >= 900990009000003L) {
										// checkpoint byps.gen.cs.PrintContext:494
										bbuf.putInt(obj.lnReturnValue);
									}
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
			WorkFlowActiveDocC obj = (WorkFlowActiveDocC)(obj1 != null ? obj1 : bin.onObjectCreated(new WorkFlowActiveDocC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnComment = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnCondition = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnFlowName = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnLabelTranslationKey = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnName = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnOnActivate = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnOnTerminate = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnUserTerminate = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnYNCondition = bbuf.getInt();
			if (version >= 700000000000008L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnVersionName = bbuf.getInt();
				if (version >= 700000000000014L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.lnNextServerId = bbuf.getInt();
					if (version >= 700000000000018L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.lnVersionTag = bbuf.getInt();
						if (version >= 700000040000012L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.lnFormSpec = bbuf.getInt();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.lnIconId = bbuf.getInt();
							if (version >= 900000018000005L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.lnCommentTranslationKey = bbuf.getInt();
								// checkpoint byps.gen.cs.PrintContext:449
								obj.lnFlowNameTranslationKey = bbuf.getInt();
								// checkpoint byps.gen.cs.PrintContext:449
								obj.lnNameTranslationKey = bbuf.getInt();
								if (version >= 900000022000019L) {
									// checkpoint byps.gen.cs.PrintContext:449
									obj.lnLabel = bbuf.getInt();
									// checkpoint byps.gen.cs.PrintContext:449
									obj.lnProperties = bbuf.getInt();
									if (version >= 900990009000003L) {
										// checkpoint byps.gen.cs.PrintContext:449
										obj.lnReturnValue = bbuf.getInt();
									}
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
