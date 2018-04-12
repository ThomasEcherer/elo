//
// Serializer for de.elo.ix.client.ContextTerm
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1464223403 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1464223403();
		
		public BSerializer_1464223403()
			: base(1464223403) {}
		
		public BSerializer_1464223403(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ContextTerm obj = (ContextTerm)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.docNum);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.term);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ContextTerm obj = (ContextTerm)(obj1 != null ? obj1 : bin.onObjectCreated(new ContextTerm()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.docNum = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.term = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace
