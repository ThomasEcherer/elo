//
// Serializer for de.elo.ix.client.SearchTermsC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_334358315 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_334358315();
		
		public BSerializer_334358315()
			: base(334358315) {}
		
		public BSerializer_334358315(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			SearchTermsC obj = (SearchTermsC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SearchTermsC obj = (SearchTermsC)(obj1 != null ? obj1 : bin.onObjectCreated(new SearchTermsC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
