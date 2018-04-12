//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_notifyServer
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1873214498 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1873214498();
		
		public BSerializer_1873214498()
			: base(1873214498) {}
		
		public BSerializer_1873214498(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_notifyServer obj = (BRequest_IXServicePortIF_notifyServer)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.msgValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_notifyServer obj = (BRequest_IXServicePortIF_notifyServer)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_notifyServer()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.msgValue = (EloixClient.IndexServer.NotifyServerInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
