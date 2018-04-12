//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getServerInfoDM
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_563195558 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_563195558();
		
		public BSerializer_563195558()
			: base(563195558) {}
		
		public BSerializer_563195558(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_getServerInfoDM obj = (BRequest_IXServicePortIF_getServerInfoDM)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_getServerInfoDM obj = (BRequest_IXServicePortIF_getServerInfoDM)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_getServerInfoDM()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
