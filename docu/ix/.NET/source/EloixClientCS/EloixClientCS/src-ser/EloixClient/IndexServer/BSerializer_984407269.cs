//
// Serializer for de.elo.ix.client.DocMaskLineTemplateC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_984407269 : EloixClient.IndexServer.BSerializer_96404005 {
		
		public readonly static new BSerializer instance = new BSerializer_984407269();
		
		public BSerializer_984407269()
			: base(984407269) {}
		
		public BSerializer_984407269(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			DocMaskLineTemplateC obj = (DocMaskLineTemplateC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			if (version >= 700000000000006L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnAcl);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			DocMaskLineTemplateC obj = (DocMaskLineTemplateC)(obj1 != null ? obj1 : bin.onObjectCreated(new DocMaskLineTemplateC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			if (version >= 700000000000006L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnAcl = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
