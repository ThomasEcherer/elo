//
// Serializer for de.elo.ix.client.AclItemC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1507233874 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1507233874();
		
		public BSerializer_1507233874()
			: base(1507233874) {}
		
		public BSerializer_1507233874(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			AclItemC obj = (AclItemC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			if (version >= 700000000000013L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.ACL_EVERYONE_RAW);
			}
			if (version >= 700000000000013L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.ACL_EVERYONE, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			AclItemC obj = (AclItemC)(obj1 != null ? obj1 : bin.onObjectCreated(new AclItemC()));
			
			BBufferBin bbuf = bin.bbuf;
			if (version >= 700000000000013L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.ACL_EVERYONE_RAW = bbuf.getString();
			}
			if (version >= 700000000000013L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.ACL_EVERYONE = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			}
			
			return obj;
		}
		
	}
} // namespace
