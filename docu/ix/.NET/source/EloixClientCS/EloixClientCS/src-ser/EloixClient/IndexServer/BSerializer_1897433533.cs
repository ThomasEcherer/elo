//
// Serializer for de.elo.ix.client.CheckoutUsersZ
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1897433533 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1897433533();
		
		public BSerializer_1897433533()
			: base(1897433533) {}
		
		public BSerializer_1897433533(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			CheckoutUsersZ obj = (CheckoutUsersZ)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.bset);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			CheckoutUsersZ obj = (CheckoutUsersZ)(obj1 != null ? obj1 : bin.onObjectCreated(new CheckoutUsersZ()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.bset = bbuf.getLong();
			
			return obj;
		}
		
	}
} // namespace
