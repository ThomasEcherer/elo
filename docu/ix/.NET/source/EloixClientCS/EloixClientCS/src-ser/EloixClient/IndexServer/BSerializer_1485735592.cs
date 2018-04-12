//
// Serializer for de.elo.ix.client.UserInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1485735592 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1485735592();
		
		public BSerializer_1485735592()
			: base(1485735592) {}
		
		public BSerializer_1485735592(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			UserInfo obj = (UserInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.desc);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.flags);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.parent);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.pwd);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.type);
			if (version >= 700000000000012L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.guid);
				if (version >= 700000000000013L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.tStamp);
					if (version >= 700000040000011L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.lastLoginIso);
						if (version >= 700000040000017L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putInt(obj.flags2);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putInt(obj.superiorId);
						}
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.groupList, false, EloixClient.IndexServer.BSerializer_100361105.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.keylist, false, EloixClient.IndexServer.BSerializer_100361105.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sessions, false, EloixClient.IndexServer.BSerializer_1376733713.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.userProps, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			if (version >= 900000000000009L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.orgUnitIds, false, EloixClient.IndexServer.BSerializer_100361105.instance);
				if (version >= 900000040000005L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bout.writeObj(obj.ldapProperties, false, EloixClient.IndexServer.BSerializer_1710660846.instance);
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			UserInfo obj = (UserInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new UserInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.desc = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flags = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.parent = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.pwd = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.type = bbuf.getInt();
			if (version >= 700000000000012L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.guid = bbuf.getString();
				if (version >= 700000000000013L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.tStamp = bbuf.getString();
					if (version >= 700000040000011L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.lastLoginIso = bbuf.getString();
						if (version >= 700000040000017L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.flags2 = bbuf.getInt();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.superiorId = bbuf.getInt();
						}
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.groupList = (int[])bin.readObj(false, EloixClient.IndexServer.BSerializer_100361105.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.keylist = (int[])bin.readObj(false, EloixClient.IndexServer.BSerializer_100361105.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sessions = (EloixClient.IndexServer.SessionInfo[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1376733713.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userProps = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			if (version >= 900000000000009L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.orgUnitIds = (int[])bin.readObj(false, EloixClient.IndexServer.BSerializer_100361105.instance);
				if (version >= 900000040000005L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.ldapProperties = (IDictionary<String,String>)bin.readObj(false, null);
				}
			}
			
			return obj;
		}
		
	}
} // namespace
