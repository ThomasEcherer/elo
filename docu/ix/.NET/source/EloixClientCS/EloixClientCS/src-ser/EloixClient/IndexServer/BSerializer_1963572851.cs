//
// Serializer for de.elo.ix.client.IXServerEventsC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1963572851 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1963572851();
		
		public BSerializer_1963572851()
			: base(1963572851) {}
		
		public BSerializer_1963572851(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			IXServerEventsC obj = (IXServerEventsC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			IXServerEventsC obj = (IXServerEventsC)(obj1 != null ? obj1 : bin.onObjectCreated(new IXServerEventsC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
