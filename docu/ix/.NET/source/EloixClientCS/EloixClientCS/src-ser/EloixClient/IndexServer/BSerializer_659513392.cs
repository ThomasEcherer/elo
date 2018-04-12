//
// Serializer for de.elo.ix.client.ProcessInfoC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_659513392 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_659513392();
		
		public BSerializer_659513392()
			: base(659513392) {}
		
		public BSerializer_659513392(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ProcessInfoC obj = (ProcessInfoC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ProcessInfoC obj = (ProcessInfoC)(obj1 != null ? obj1 : bin.onObjectCreated(new ProcessInfoC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
