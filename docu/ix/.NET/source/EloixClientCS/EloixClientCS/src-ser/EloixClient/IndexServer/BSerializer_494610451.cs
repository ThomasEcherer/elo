//
// Serializer for de.elo.ix.client.Notification
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_494610451 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_494610451();
		
		public BSerializer_494610451()
			: base(494610451) {}
		
		public BSerializer_494610451(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			Notification obj = (Notification)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.createDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.watchGuid);
			if (version >= 900000022000003L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.prio);
				if (version >= 900000030000001L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.what);
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			Notification obj = (Notification)(obj1 != null ? obj1 : bin.onObjectCreated(new Notification()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.createDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.watchGuid = bbuf.getString();
			if (version >= 900000022000003L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.prio = bbuf.getInt();
				if (version >= 900000030000001L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.what = bbuf.getInt();
				}
			}
			
			return obj;
		}
		
	}
} // namespace
