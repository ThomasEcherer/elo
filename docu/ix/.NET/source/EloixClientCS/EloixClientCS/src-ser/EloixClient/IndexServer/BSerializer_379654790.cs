//
// Serializer for de.elo.ix.client.MapHistC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_379654790 : EloixClient.IndexServer.BSerializer_812099209 {
		
		public readonly static new BSerializer instance = new BSerializer_379654790();
		
		public BSerializer_379654790()
			: base(379654790) {}
		
		public BSerializer_379654790(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			MapHistC obj = (MapHistC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			MapHistC obj = (MapHistC)(obj1 != null ? obj1 : bin.onObjectCreated(new MapHistC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
