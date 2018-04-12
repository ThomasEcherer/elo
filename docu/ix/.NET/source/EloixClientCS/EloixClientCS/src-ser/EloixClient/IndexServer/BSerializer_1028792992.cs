//
// Serializer for de.elo.ix.client.BResult_1005790586
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1028792992 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1028792992();
		
		public BSerializer_1028792992()
			: base(1028792992) {}
		
		public BSerializer_1028792992(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_1005790586 obj = (BResult_1005790586)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_1005790586.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_1005790586 obj = (BResult_1005790586)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_1005790586()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.ContextTerm[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1005790586.instance);
			
			return obj;
		}
		
	}
} // namespace
