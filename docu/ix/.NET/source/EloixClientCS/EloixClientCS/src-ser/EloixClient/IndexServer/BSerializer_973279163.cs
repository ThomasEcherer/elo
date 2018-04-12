//
// Serializer for de.elo.ix.client.ResolveRightsResult
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_973279163 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_973279163();
		
		public BSerializer_973279163()
			: base(973279163) {}
		
		public BSerializer_973279163(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ResolveRightsResult obj = (ResolveRightsResult)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.right);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.right2);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.type);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.members, false, EloixClient.IndexServer.BSerializer_2123584667.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ResolveRightsResult obj = (ResolveRightsResult)(obj1 != null ? obj1 : bin.onObjectCreated(new ResolveRightsResult()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.right = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.right2 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.type = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.members = (IList<String>)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
