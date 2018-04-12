//
// Serializer for de.elo.ix.client.ReplSetName
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_755067340 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_755067340();
		
		public BSerializer_755067340()
			: base(755067340) {}
		
		public BSerializer_755067340(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ReplSetName obj = (ReplSetName)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.TStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.desc);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.image);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.mobile);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			if (version >= 900990009000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.TStampSync);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.priority);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ReplSetName obj = (ReplSetName)(obj1 != null ? obj1 : bin.onObjectCreated(new ReplSetName()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.TStamp = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.desc = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.image = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.mobile = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			if (version >= 900990009000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.TStampSync = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.priority = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
