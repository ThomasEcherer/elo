//
// Serializer for de.elo.ix.client.DocMaskLineC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1453574806 : EloixClient.IndexServer.BSerializer_1178569423 {
		
		public readonly static new BSerializer instance = new BSerializer_1453574806();
		
		public BSerializer_1453574806()
			: base(1453574806) {}
		
		public BSerializer_1453574806(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			DocMaskLineC obj = (DocMaskLineC)obj1;			
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
			DocMaskLineC obj = (DocMaskLineC)(obj1 != null ? obj1 : bin.onObjectCreated(new DocMaskLineC()));
			
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
