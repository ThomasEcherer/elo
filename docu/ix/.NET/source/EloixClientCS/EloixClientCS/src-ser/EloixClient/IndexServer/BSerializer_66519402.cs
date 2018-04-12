//
// Serializer for de.elo.ix.client.CombineAclOptions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_66519402 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_66519402();
		
		public BSerializer_66519402()
			: base(66519402) {}
		
		public BSerializer_66519402(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			CombineAclOptions obj = (CombineAclOptions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			if (version >= 700000020000005L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.lhsAclStr);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.rhsAclStr);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			CombineAclOptions obj = (CombineAclOptions)(obj1 != null ? obj1 : bin.onObjectCreated(new CombineAclOptions()));
			
			BBufferBin bbuf = bin.bbuf;
			if (version >= 700000020000005L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lhsAclStr = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.rhsAclStr = bbuf.getString();
			}
			
			return obj;
		}
		
	}
} // namespace
