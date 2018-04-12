//
// Serializer for de.elo.ix.client.DocMaskLineDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1178569423 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1178569423();
		
		public BSerializer_1178569423()
			: base(1178569423) {}
		
		public BSerializer_1178569423(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			DocMaskLineDataC obj = (DocMaskLineDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnComment);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnKey);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnName);
			if (version >= 700000000000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnExternalData);
				if (version >= 700000000000006L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.lnInternalAcl);
					if (version >= 700000040000016L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.lnDefaultValue);
						if (version >= 900000000000001L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putInt(obj.lnServerScriptName);
							if (version >= 900000018000005L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putInt(obj.lnCommentTranslationKey);
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putInt(obj.lnNameTranslationKey);
								if (version >= 1000000020000010L) {
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putInt(obj.lnValidateExpression);
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
			DocMaskLineDataC obj = (DocMaskLineDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new DocMaskLineDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnComment = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnKey = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnName = bbuf.getInt();
			if (version >= 700000000000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnExternalData = bbuf.getInt();
				if (version >= 700000000000006L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.lnInternalAcl = bbuf.getInt();
					if (version >= 700000040000016L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.lnDefaultValue = bbuf.getInt();
						if (version >= 900000000000001L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.lnServerScriptName = bbuf.getInt();
							if (version >= 900000018000005L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.lnCommentTranslationKey = bbuf.getInt();
								// checkpoint byps.gen.cs.PrintContext:449
								obj.lnNameTranslationKey = bbuf.getInt();
								if (version >= 1000000020000010L) {
									// checkpoint byps.gen.cs.PrintContext:449
									obj.lnValidateExpression = bbuf.getInt();
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
