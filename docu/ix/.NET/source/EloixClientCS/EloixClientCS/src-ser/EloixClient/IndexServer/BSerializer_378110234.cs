//
// Serializer for de.elo.ix.client.RestoreOptions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_378110234 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_378110234();
		
		public BSerializer_378110234()
			: base(378110234) {}
		
		public BSerializer_378110234(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			RestoreOptions obj = (RestoreOptions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.minIDate);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.singleObject);
			if (version >= 900000000000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.minDeleteDate);
				if (version >= 900000000000002L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.parentId);
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			RestoreOptions obj = (RestoreOptions)(obj1 != null ? obj1 : bin.onObjectCreated(new RestoreOptions()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.minIDate = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.singleObject = bbuf.getBoolean();
			if (version >= 900000000000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.minDeleteDate = bbuf.getString();
				if (version >= 900000000000002L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.parentId = bbuf.getString();
				}
			}
			
			return obj;
		}
		
	}
} // namespace
