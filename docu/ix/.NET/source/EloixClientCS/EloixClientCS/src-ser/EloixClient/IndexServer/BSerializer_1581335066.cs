//
// Serializer for de.elo.ix.client.CountResult
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1581335066 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1581335066();
		
		public BSerializer_1581335066()
			: base(1581335066) {}
		
		public BSerializer_1581335066(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			CountResult obj = (CountResult)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.attBytesCount);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.docAttachCount);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.docBytesCount);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.docCount);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.docVersionsCount);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.structCount);
			if (version >= 700000000000002L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putLong(obj.otherAttVersBytesCount);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.otherAttachVersionsCount);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putLong(obj.otherDocVersBytesCount);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			CountResult obj = (CountResult)(obj1 != null ? obj1 : bin.onObjectCreated(new CountResult()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.attBytesCount = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.docAttachCount = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.docBytesCount = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.docCount = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.docVersionsCount = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.structCount = bbuf.getInt();
			if (version >= 700000000000002L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.otherAttVersBytesCount = bbuf.getLong();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.otherAttachVersionsCount = bbuf.getInt();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.otherDocVersBytesCount = bbuf.getLong();
			}
			
			return obj;
		}
		
	}
} // namespace
