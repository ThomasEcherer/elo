//
// Serializer for de.elo.ix.client.CopySordC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1616091412 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1616091412();
		
		public BSerializer_1616091412()
			: base(1616091412) {}
		
		public BSerializer_1616091412(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			CopySordC obj = (CopySordC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			CopySordC obj = (CopySordC)(obj1 != null ? obj1 : bin.onObjectCreated(new CopySordC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
