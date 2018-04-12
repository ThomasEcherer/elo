//
// Serializer for de.elo.ix.client.FindUserInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1847547446 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1847547446();
		
		public BSerializer_1847547446()
			: base(1847547446) {}
		
		public BSerializer_1847547446(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FindUserInfo obj = (FindUserInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.desc);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.onlyGroups);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.onlyUsers);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.returnUserInfoMap);
			if (version >= 1000170010000005L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.hasFlags);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.hasFlags2);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.hasNotFlags);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.hasNotFlags2);
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ldapProperty, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.property, false, null);
			if (version >= 1000170010000004L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.checkoutUsersZ, false, null);
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.userIds, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindUserInfo obj = (FindUserInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new FindUserInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.desc = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.onlyGroups = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.onlyUsers = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.returnUserInfoMap = bbuf.getBoolean();
			if (version >= 1000170010000005L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.hasFlags = bbuf.getInt();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.hasFlags2 = bbuf.getInt();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.hasNotFlags = bbuf.getInt();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.hasNotFlags2 = bbuf.getInt();
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ldapProperty = (EloixClient.IndexServer.KeyValue)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.property = (EloixClient.IndexServer.KeyValue)bin.readObj(false, null);
			if (version >= 1000170010000004L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.checkoutUsersZ = (EloixClient.IndexServer.CheckoutUsersZ)bin.readObj(false, null);
				// checkpoint byps.gen.cs.PrintContext:449
				obj.userIds = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			}
			
			return obj;
		}
		
	}
} // namespace
