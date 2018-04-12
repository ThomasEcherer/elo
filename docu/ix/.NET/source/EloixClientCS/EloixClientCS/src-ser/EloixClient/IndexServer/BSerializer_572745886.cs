//
// Serializer for de.elo.ix.client.EventBusC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_572745886 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_572745886();
		
		public BSerializer_572745886()
			: base(572745886) {}
		
		public BSerializer_572745886(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			EventBusC obj = (EventBusC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			EventBusC obj = (EventBusC)(obj1 != null ? obj1 : bin.onObjectCreated(new EventBusC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
