//
// Serializer for de.elo.ix.client.EloDmOptC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_605470240 : EloixClient.IndexServer.BSerializer_1218961099 {
		
		public readonly static new BSerializer instance = new BSerializer_605470240();
		
		public BSerializer_605470240()
			: base(605470240) {}
		
		public BSerializer_605470240(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			EloDmOptC obj = (EloDmOptC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			EloDmOptC obj = (EloDmOptC)(obj1 != null ? obj1 : bin.onObjectCreated(new EloDmOptC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
