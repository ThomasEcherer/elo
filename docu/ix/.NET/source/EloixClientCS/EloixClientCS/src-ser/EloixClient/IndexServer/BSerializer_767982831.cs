//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_invalidateCache
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_767982831 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_767982831();
		
		public BSerializer_767982831()
			: base(767982831) {}
		
		public BSerializer_767982831(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_invalidateCache obj = (BRequest_IXServicePortIF_invalidateCache)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.flagsValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_invalidateCache obj = (BRequest_IXServicePortIF_invalidateCache)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_invalidateCache()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flagsValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
