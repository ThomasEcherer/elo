//
// Serializer for de.elo.ix.client.BResult_1701204890
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1855130839 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1855130839();
		
		public BSerializer_1855130839()
			: base(1855130839) {}
		
		public BSerializer_1855130839(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_1701204890 obj = (BResult_1701204890)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_1701204890 obj = (BResult_1701204890)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_1701204890()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.ServerInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
