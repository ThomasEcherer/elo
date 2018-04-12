//
// Serializer for de.elo.ix.client.BResult_460199434
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1768431067 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1768431067();
		
		public BSerializer_1768431067()
			: base(1768431067) {}
		
		public BSerializer_1768431067(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_460199434 obj = (BResult_460199434)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_460199434 obj = (BResult_460199434)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_460199434()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.Activity)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
