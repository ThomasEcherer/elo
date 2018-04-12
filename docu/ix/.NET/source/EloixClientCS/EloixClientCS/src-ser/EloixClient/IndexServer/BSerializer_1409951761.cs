//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createSubscription
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1409951761 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1409951761();
		
		public BSerializer_1409951761()
			: base(1409951761) {}
		
		public BSerializer_1409951761(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_createSubscription obj = (BRequest_IXServicePortIF_createSubscription)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.watchGuidValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_createSubscription obj = (BRequest_IXServicePortIF_createSubscription)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_createSubscription()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.watchGuidValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
