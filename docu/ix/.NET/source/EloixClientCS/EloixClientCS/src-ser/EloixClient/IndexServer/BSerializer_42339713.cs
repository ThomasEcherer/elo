//
// Serializer for de.elo.ix.client.MapDomain
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_42339713 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_42339713();
		
		public BSerializer_42339713()
			: base(42339713) {}
		
		public BSerializer_42339713(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			MapDomain obj = (MapDomain)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.copy);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.replicate);
			if (version >= 800000024000002L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.history);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			MapDomain obj = (MapDomain)(obj1 != null ? obj1 : bin.onObjectCreated(new MapDomain()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.copy = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.replicate = bbuf.getBoolean();
			if (version >= 800000024000002L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.history = bbuf.getBoolean();
			}
			
			return obj;
		}
		
	}
} // namespace
