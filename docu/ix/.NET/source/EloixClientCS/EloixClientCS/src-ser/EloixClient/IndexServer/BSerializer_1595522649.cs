//
// Serializer for de.elo.ix.client.BResult_892356058
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1595522649 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1595522649();
		
		public BSerializer_1595522649()
			: base(1595522649) {}
		
		public BSerializer_1595522649(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_892356058 obj = (BResult_892356058)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt((int)obj.resultValue);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_892356058 obj = (BResult_892356058)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_892356058()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.InheritKeywordingResult)bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
