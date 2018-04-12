//
// Serializer for de.elo.ix.client.NoteFreehandC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1034219603 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1034219603();
		
		public BSerializer_1034219603()
			: base(1034219603) {}
		
		public BSerializer_1034219603(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			NoteFreehandC obj = (NoteFreehandC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			NoteFreehandC obj = (NoteFreehandC)(obj1 != null ? obj1 : bin.onObjectCreated(new NoteFreehandC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
