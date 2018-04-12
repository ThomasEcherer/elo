//
// Serializer for de.elo.ix.client.Bitset
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1084624222 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1084624222();
		
		public BSerializer_1084624222()
			: base(1084624222) {}
		
		public BSerializer_1084624222(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			Bitset obj = (Bitset)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.v);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			Bitset obj = (Bitset)(obj1 != null ? obj1 : bin.onObjectCreated(new Bitset()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.v = bbuf.getLong();
			
			return obj;
		}
		
	}
} // namespace
