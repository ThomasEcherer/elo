//
// Serializer for de.elo.ix.client.AccessC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_384025970 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_384025970();
		
		public BSerializer_384025970()
			: base(384025970) {}
		
		public BSerializer_384025970(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			AccessC obj = (AccessC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			AccessC obj = (AccessC)(obj1 != null ? obj1 : bin.onObjectCreated(new AccessC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
