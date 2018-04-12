//
// Serializer for de.elo.ix.client.InvalidateCacheInfoParam
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_102205772 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_102205772();
		
		public BSerializer_102205772()
			: base(102205772) {}
		
		public BSerializer_102205772(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			InvalidateCacheInfoParam obj = (InvalidateCacheInfoParam)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.count);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.flag);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.guid);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			InvalidateCacheInfoParam obj = (InvalidateCacheInfoParam)(obj1 != null ? obj1 : bin.onObjectCreated(new InvalidateCacheInfoParam()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.count = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flag = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.guid = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace
