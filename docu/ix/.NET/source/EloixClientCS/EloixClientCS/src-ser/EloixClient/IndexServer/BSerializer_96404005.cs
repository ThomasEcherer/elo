//
// Serializer for de.elo.ix.client.DocMaskLineTemplateDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_96404005 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_96404005();
		
		public BSerializer_96404005()
			: base(96404005) {}
		
		public BSerializer_96404005(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			DocMaskLineTemplateDataC obj = (DocMaskLineTemplateDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnComment);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnCommentTranslationKey);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnDefaultValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnExternalData);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnInternalAcl);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnKey);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnNameTranslationKey);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnServerScriptName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnTStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnTStampSync);
			if (version >= 1000000020000010L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnValidateExpression);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			DocMaskLineTemplateDataC obj = (DocMaskLineTemplateDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new DocMaskLineTemplateDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnComment = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnCommentTranslationKey = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnDefaultValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnExternalData = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnInternalAcl = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnKey = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnName = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnNameTranslationKey = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnServerScriptName = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnTStamp = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnTStampSync = bbuf.getInt();
			if (version >= 1000000020000010L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnValidateExpression = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
