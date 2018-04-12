//
// Serializer for de.elo.ix.client.UserInfoC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_703234555 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_703234555();
		
		public BSerializer_703234555()
			: base(703234555) {}
		
		public BSerializer_703234555(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			UserInfoC obj = (UserInfoC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			if (version >= 600000103000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnDesc);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnName);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnPwd);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnUserProp);
				if (version >= 700000000000012L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.GUID_ADMINISTRATOR);
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.GUID_EVERYONE_GROUP);
					if (version >= 1000170010000008L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.lnLdapPropKey);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.lnLdapPropValue);
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			UserInfoC obj = (UserInfoC)(obj1 != null ? obj1 : bin.onObjectCreated(new UserInfoC()));
			
			BBufferBin bbuf = bin.bbuf;
			if (version >= 600000103000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnDesc = bbuf.getInt();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnName = bbuf.getInt();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnPwd = bbuf.getInt();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnUserProp = bbuf.getInt();
				if (version >= 700000000000012L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.GUID_ADMINISTRATOR = bbuf.getString();
					// checkpoint byps.gen.cs.PrintContext:449
					obj.GUID_EVERYONE_GROUP = bbuf.getString();
					if (version >= 1000170010000008L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.lnLdapPropKey = bbuf.getInt();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.lnLdapPropValue = bbuf.getInt();
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace
