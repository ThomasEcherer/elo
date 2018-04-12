//
// Serializer for de.elo.ix.client.ServerStateC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1862501863 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1862501863();
		
		public BSerializer_1862501863()
			: base(1862501863) {}
		
		public BSerializer_1862501863(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ServerStateC obj = (ServerStateC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnAction);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ServerStateC obj = (ServerStateC)(obj1 != null ? obj1 : bin.onObjectCreated(new ServerStateC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnAction = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
