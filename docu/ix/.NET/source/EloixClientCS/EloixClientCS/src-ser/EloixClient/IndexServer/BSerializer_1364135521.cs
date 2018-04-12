//
// Serializer for de.elo.ix.client.BResult_1401065069
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1364135521 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1364135521();
		
		public BSerializer_1364135521()
			: base(1364135521) {}
		
		public BSerializer_1364135521(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_1401065069 obj = (BResult_1401065069)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_1401065069 obj = (BResult_1401065069)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_1401065069()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.UserProfile)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
