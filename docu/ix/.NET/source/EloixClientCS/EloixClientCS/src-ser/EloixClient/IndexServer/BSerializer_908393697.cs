//
// Serializer for de.elo.ix.client.AnyC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_908393697 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_908393697();
		
		public BSerializer_908393697()
			: base(908393697) {}
		
		public BSerializer_908393697(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			AnyC obj = (AnyC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			AnyC obj = (AnyC)(obj1 != null ? obj1 : bin.onObjectCreated(new AnyC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
