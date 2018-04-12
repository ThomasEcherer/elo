//
// Serializer for de.elo.ix.client.BResult_491352407
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_652213248 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_652213248();
		
		public BSerializer_652213248()
			: base(652213248) {}
		
		public BSerializer_652213248(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_491352407 obj = (BResult_491352407)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_491352407.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_491352407 obj = (BResult_491352407)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_491352407()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.SordHist[])bin.readObj(false, EloixClient.IndexServer.BSerializer_491352407.instance);
			
			return obj;
		}
		
	}
} // namespace
