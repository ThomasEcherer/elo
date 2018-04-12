//
// Serializer for de.elo.ix.client.CheckoutUsersC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_531758278 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_531758278();
		
		public BSerializer_531758278()
			: base(531758278) {}
		
		public BSerializer_531758278(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			CheckoutUsersC obj = (CheckoutUsersC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			CheckoutUsersC obj = (CheckoutUsersC)(obj1 != null ? obj1 : bin.onObjectCreated(new CheckoutUsersC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
