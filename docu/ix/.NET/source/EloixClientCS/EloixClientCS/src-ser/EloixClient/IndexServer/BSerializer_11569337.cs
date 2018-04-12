//
// Serializer for de.elo.ix.client.AclAccessInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_11569337 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_11569337();
		
		public BSerializer_11569337()
			: base(11569337) {}
		
		public BSerializer_11569337(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			AclAccessInfo obj = (AclAccessInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.acl);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objId);
			if (version >= 800000032000010L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.parentId);
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.aclItems, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			AclAccessInfo obj = (AclAccessInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new AclAccessInfo()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.acl = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getString();
			if (version >= 800000032000010L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.parentId = bbuf.getString();
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.aclItems = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			
			return obj;
		}
		
	}
} // namespace
