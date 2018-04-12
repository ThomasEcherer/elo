//
// Serializer for de.elo.ix.client.AclItem
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1255072841 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1255072841();
		
		public BSerializer_1255072841()
			: base(1255072841) {}
		
		public BSerializer_1255072841(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			AclItem obj = (AclItem)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.access);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.type);
			if (version >= 700000000000005L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.andGroups, false, EloixClient.IndexServer.BSerializer_755261279.instance);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			AclItem obj = (AclItem)(obj1 != null ? obj1 : bin.onObjectCreated(new AclItem()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.access = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.type = bbuf.getInt();
			if (version >= 700000000000005L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.andGroups = (EloixClient.IndexServer.IdName[])bin.readObj(false, EloixClient.IndexServer.BSerializer_755261279.instance);
			}
			
			return obj;
		}
		
	}
} // namespace
