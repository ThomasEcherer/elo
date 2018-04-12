//
// Serializer for de.elo.ix.client.BResult_809229049
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_681379622 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_681379622();
		
		public BSerializer_681379622()
			: base(681379622) {}
		
		public BSerializer_681379622(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_809229049 obj = (BResult_809229049)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_809229049.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_809229049 obj = (BResult_809229049)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_809229049()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.CryptInfo[])bin.readObj(false, EloixClient.IndexServer.BSerializer_809229049.instance);
			
			return obj;
		}
		
	}
} // namespace
