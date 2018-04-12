//
// Serializer for de.elo.ix.client.BResult_1376733713
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_98220986 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_98220986();
		
		public BSerializer_98220986()
			: base(98220986) {}
		
		public BSerializer_98220986(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_1376733713 obj = (BResult_1376733713)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_1376733713.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_1376733713 obj = (BResult_1376733713)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_1376733713()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.SessionInfo[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1376733713.instance);
			
			return obj;
		}
		
	}
} // namespace
