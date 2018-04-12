//
// Serializer for de.elo.ix.client.FindChildren
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_752202075 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_752202075();
		
		public BSerializer_752202075()
			: base(752202075) {}
		
		public BSerializer_752202075(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FindChildren obj = (FindChildren)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.mainParent);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.parentId);
			if (version >= 700000000000010L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.endLevel);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindChildren obj = (FindChildren)(obj1 != null ? obj1 : bin.onObjectCreated(new FindChildren()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.mainParent = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.parentId = bbuf.getString();
			if (version >= 700000000000010L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.endLevel = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
