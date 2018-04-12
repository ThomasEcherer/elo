//
// Serializer for de.elo.ix.client.StoreInfoC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_979653235 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_979653235();
		
		public BSerializer_979653235()
			: base(979653235) {}
		
		public BSerializer_979653235(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			StoreInfoC obj = (StoreInfoC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			StoreInfoC obj = (StoreInfoC)(obj1 != null ? obj1 : bin.onObjectCreated(new StoreInfoC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
