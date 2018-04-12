//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createRsaKeys
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_518307262 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_518307262();
		
		public BSerializer_518307262()
			: base(518307262) {}
		
		public BSerializer_518307262(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_createRsaKeys obj = (BRequest_IXServicePortIF_createRsaKeys)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_createRsaKeys obj = (BRequest_IXServicePortIF_createRsaKeys)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_createRsaKeys()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
