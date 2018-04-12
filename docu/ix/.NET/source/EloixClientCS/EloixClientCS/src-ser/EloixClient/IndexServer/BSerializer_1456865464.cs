//
// Serializer for de.elo.ix.client.FindActivityInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1456865464 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1456865464();
		
		public BSerializer_1456865464()
			: base(1456865464) {}
		
		public BSerializer_1456865464(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FindActivityInfo obj = (FindActivityInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclDeputy);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclGroup);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.receiverId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.senderId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.senderOrReceiver);
			if (version >= 800000018000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.inclDeleted);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindActivityInfo obj = (FindActivityInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new FindActivityInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclDeputy = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclGroup = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.receiverId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.senderId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.senderOrReceiver = bbuf.getBoolean();
			if (version >= 800000018000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.inclDeleted = bbuf.getBoolean();
			}
			
			return obj;
		}
		
	}
} // namespace
