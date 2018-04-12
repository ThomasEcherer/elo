//
// Serializer for de.elo.ix.client.LinkSordInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1427691295 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1427691295();
		
		public BSerializer_1427691295()
			: base(1427691295) {}
		
		public BSerializer_1427691295(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			LinkSordInfo obj = (LinkSordInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.linkPermanent);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			LinkSordInfo obj = (LinkSordInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new LinkSordInfo()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.linkPermanent = bbuf.getBoolean();
			
			return obj;
		}
		
	}
} // namespace
