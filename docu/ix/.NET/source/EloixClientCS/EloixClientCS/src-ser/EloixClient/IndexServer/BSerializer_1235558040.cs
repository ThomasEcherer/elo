//
// Serializer for de.elo.ix.client.ReplCode
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1235558040 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1235558040();
		
		public BSerializer_1235558040()
			: base(1235558040) {}
		
		public BSerializer_1235558040(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ReplCode obj = (ReplCode)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ReplCode obj = (ReplCode)(obj1 != null ? obj1 : bin.onObjectCreated(new ReplCode()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
