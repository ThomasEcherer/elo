//
// Serializer for de.elo.ix.client.UserName
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_123879203 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_123879203();
		
		public BSerializer_123879203()
			: base(123879203) {}
		
		public BSerializer_123879203(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			UserName obj = (UserName)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.type);
			if (version >= 700000000000020L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.flags);
				if (version >= 800000000000006L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.flags2);
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			UserName obj = (UserName)(obj1 != null ? obj1 : bin.onObjectCreated(new UserName()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.type = bbuf.getInt();
			if (version >= 700000000000020L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.flags = bbuf.getInt();
				if (version >= 800000000000006L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.flags2 = bbuf.getInt();
				}
			}
			
			return obj;
		}
		
	}
} // namespace
