//
// Serializer for de.elo.ix.client.AclAccessResult
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_200528028 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_200528028();
		
		public BSerializer_200528028()
			: base(200528028) {}
		
		public BSerializer_200528028(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			AclAccessResult obj = (AclAccessResult)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.access);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			AclAccessResult obj = (AclAccessResult)(obj1 != null ? obj1 : bin.onObjectCreated(new AclAccessResult()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.access = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
