//
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_getUserNames
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1950460032 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1950460032();
		
		public BSerializer_1950460032()
			: base(1950460032) {}
		
		public BSerializer_1950460032(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServerEvents_getUserNames obj = (BRequest_IXServerEvents_getUserNames)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.checkoutUsersZValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ecValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.idsValue, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServerEvents_getUserNames obj = (BRequest_IXServerEvents_getUserNames)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServerEvents_getUserNames()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.checkoutUsersZValue = (EloixClient.IndexServer.CheckoutUsersZ)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ecValue = (EloixClient.IndexServer.IXServerEventsContext)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.idsValue = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			
			return obj;
		}
		
	}
} // namespace
