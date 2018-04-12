//
// Serializer for de.elo.ix.client.InvalidateCacheC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_320503229 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_320503229();
		
		public BSerializer_320503229()
			: base(320503229) {}
		
		public BSerializer_320503229(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			InvalidateCacheC obj = (InvalidateCacheC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			InvalidateCacheC obj = (InvalidateCacheC)(obj1 != null ? obj1 : bin.onObjectCreated(new InvalidateCacheC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
