//
// Serializer for de.elo.ix.client.WFTypeC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1842783874 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1842783874();
		
		public BSerializer_1842783874()
			: base(1842783874) {}
		
		public BSerializer_1842783874(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			WFTypeC obj = (WFTypeC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WFTypeC obj = (WFTypeC)(obj1 != null ? obj1 : bin.onObjectCreated(new WFTypeC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
