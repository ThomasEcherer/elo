//
// Serializer for de.elo.ix.client.InvalidateCacheInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1441686860 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1441686860();
		
		public BSerializer_1441686860()
			: base(1441686860) {}
		
		public BSerializer_1441686860(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			InvalidateCacheInfo obj = (InvalidateCacheInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.flags);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			if (version >= 900000030000015L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.parameters, false, EloixClient.IndexServer.BSerializer_189813709.instance);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			InvalidateCacheInfo obj = (InvalidateCacheInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new InvalidateCacheInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flags = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			if (version >= 900000030000015L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.parameters = (IList<EloixClient.IndexServer.InvalidateCacheInfoParam>)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace
