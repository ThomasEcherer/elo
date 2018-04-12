//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutMapHistory
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_739067188 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_739067188();
		
		public BSerializer_739067188()
			: base(739067188) {}
		
		public BSerializer_739067188(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_checkoutMapHistory obj = (BRequest_IXServicePortIF_checkoutMapHistory)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.domainNameValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.mapIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.membersZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_checkoutMapHistory obj = (BRequest_IXServicePortIF_checkoutMapHistory)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_checkoutMapHistory()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.domainNameValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.mapIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.membersZValue = (EloixClient.IndexServer.MapHistZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
