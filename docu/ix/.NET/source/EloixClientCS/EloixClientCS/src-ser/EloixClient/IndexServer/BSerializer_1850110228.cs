//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkoutUsers
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1850110228 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1850110228();
		
		public BSerializer_1850110228()
			: base(1850110228) {}
		
		public BSerializer_1850110228(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_checkoutUsers obj = (BRequest_IXServicePortIF_checkoutUsers)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.checkoutUsersZValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.idsValue, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.lockZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_checkoutUsers obj = (BRequest_IXServicePortIF_checkoutUsers)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_checkoutUsers()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.checkoutUsersZValue = (EloixClient.IndexServer.CheckoutUsersZ)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.idsValue = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
