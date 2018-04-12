//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_closeEventBus
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1579680296 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1579680296();
		
		public BSerializer_1579680296()
			: base(1579680296) {}
		
		public BSerializer_1579680296(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_closeEventBus obj = (BRequest_IXServicePortIF_closeEventBus)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.busIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_closeEventBus obj = (BRequest_IXServicePortIF_closeEventBus)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_closeEventBus()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.busIdValue = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
