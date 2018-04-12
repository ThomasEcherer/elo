//
// Serializer for de.elo.ix.client.SearchModeC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1758444419 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1758444419();
		
		public BSerializer_1758444419()
			: base(1758444419) {}
		
		public BSerializer_1758444419(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			SearchModeC obj = (SearchModeC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SearchModeC obj = (SearchModeC)(obj1 != null ? obj1 : bin.onObjectCreated(new SearchModeC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
