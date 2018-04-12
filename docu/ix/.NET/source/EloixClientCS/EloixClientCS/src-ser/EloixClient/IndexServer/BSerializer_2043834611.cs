//
// Serializer for de.elo.ix.client.ExportOptionsC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2043834611 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_2043834611();
		
		public BSerializer_2043834611()
			: base(2043834611) {}
		
		public BSerializer_2043834611(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ExportOptionsC obj = (ExportOptionsC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ExportOptionsC obj = (ExportOptionsC)(obj1 != null ? obj1 : bin.onObjectCreated(new ExportOptionsC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
