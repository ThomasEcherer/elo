//
// Serializer for de.elo.ix.client.BResult_494610451
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2092431731 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_2092431731();
		
		public BSerializer_2092431731()
			: base(2092431731) {}
		
		public BSerializer_2092431731(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_494610451 obj = (BResult_494610451)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_494610451 obj = (BResult_494610451)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_494610451()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.Notification)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
