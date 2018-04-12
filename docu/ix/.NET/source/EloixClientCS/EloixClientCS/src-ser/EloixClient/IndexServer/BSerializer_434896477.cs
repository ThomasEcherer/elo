//
// Serializer for de.elo.ix.client.PhysDelDocsC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_434896477 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_434896477();
		
		public BSerializer_434896477()
			: base(434896477) {}
		
		public BSerializer_434896477(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			PhysDelDocsC obj = (PhysDelDocsC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			PhysDelDocsC obj = (PhysDelDocsC)(obj1 != null ? obj1 : bin.onObjectCreated(new PhysDelDocsC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
