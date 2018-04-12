//
// Serializer for de.elo.ix.client.ExportExtOptionsC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_162646972 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_162646972();
		
		public BSerializer_162646972()
			: base(162646972) {}
		
		public BSerializer_162646972(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ExportExtOptionsC obj = (ExportExtOptionsC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ExportExtOptionsC obj = (ExportExtOptionsC)(obj1 != null ? obj1 : bin.onObjectCreated(new ExportExtOptionsC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
