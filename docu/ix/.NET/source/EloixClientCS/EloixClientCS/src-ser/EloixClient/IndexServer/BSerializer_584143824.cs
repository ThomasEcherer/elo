//
// Serializer for de.elo.ix.client.BResult_1826370901
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_584143824 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_584143824();
		
		public BSerializer_584143824()
			: base(584143824) {}
		
		public BSerializer_584143824(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_1826370901 obj = (BResult_1826370901)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_1826370901.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_1826370901 obj = (BResult_1826370901)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_1826370901()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.KeyValue[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1826370901.instance);
			
			return obj;
		}
		
	}
} // namespace
