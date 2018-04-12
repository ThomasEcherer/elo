//
// Serializer for de.elo.ix.client.ResolveRightsResultC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1322441656 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1322441656();
		
		public BSerializer_1322441656()
			: base(1322441656) {}
		
		public BSerializer_1322441656(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ResolveRightsResultC obj = (ResolveRightsResultC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ResolveRightsResultC obj = (ResolveRightsResultC)(obj1 != null ? obj1 : bin.onObjectCreated(new ResolveRightsResultC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
