//
// Serializer for de.elo.ix.client.BResult_1701141707
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1830105166 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1830105166();
		
		public BSerializer_1830105166()
			: base(1830105166) {}
		
		public BSerializer_1830105166(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_1701141707 obj = (BResult_1701141707)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_1701141707.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_1701141707 obj = (BResult_1701141707)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_1701141707()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.Reminder[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1701141707.instance);
			
			return obj;
		}
		
	}
} // namespace
