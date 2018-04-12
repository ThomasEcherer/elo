//
// Serializer for de.elo.ix.client.SordTypeC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_635922924 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_635922924();
		
		public BSerializer_635922924()
			: base(635922924) {}
		
		public BSerializer_635922924(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			SordTypeC obj = (SordTypeC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SordTypeC obj = (SordTypeC)(obj1 != null ? obj1 : bin.onObjectCreated(new SordTypeC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
