//
// Serializer for de.elo.ix.client.BResult_607287445
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1768200726 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1768200726();
		
		public BSerializer_1768200726()
			: base(1768200726) {}
		
		public BSerializer_1768200726(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_607287445 obj = (BResult_607287445)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_607287445.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_607287445 obj = (BResult_607287445)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_607287445()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.ActivityProject[])bin.readObj(false, EloixClient.IndexServer.BSerializer_607287445.instance);
			
			return obj;
		}
		
	}
} // namespace
