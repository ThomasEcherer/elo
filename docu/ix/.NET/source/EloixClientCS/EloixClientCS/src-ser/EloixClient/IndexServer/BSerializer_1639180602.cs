//
// Serializer for de.elo.ix.client.PublicDownloadDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1639180602 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1639180602();
		
		public BSerializer_1639180602()
			: base(1639180602) {}
		
		public BSerializer_1639180602(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			PublicDownloadDataC obj = (PublicDownloadDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnExpiration);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnTimeStamp);
			if (version >= 900000030000030L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnAttachmentCode);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnFileName);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			PublicDownloadDataC obj = (PublicDownloadDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new PublicDownloadDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnExpiration = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnTimeStamp = bbuf.getInt();
			if (version >= 900000030000030L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnAttachmentCode = bbuf.getInt();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnFileName = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
