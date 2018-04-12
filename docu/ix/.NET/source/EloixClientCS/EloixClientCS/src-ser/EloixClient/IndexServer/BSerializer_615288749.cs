//
// Serializer for de.elo.ix.client.DocVersionC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_615288749 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_615288749();
		
		public BSerializer_615288749()
			: base(615288749) {}
		
		public BSerializer_615288749(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			DocVersionC obj = (DocVersionC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnComment);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnExt);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnVersion);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			DocVersionC obj = (DocVersionC)(obj1 != null ? obj1 : bin.onObjectCreated(new DocVersionC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnComment = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnExt = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnVersion = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
