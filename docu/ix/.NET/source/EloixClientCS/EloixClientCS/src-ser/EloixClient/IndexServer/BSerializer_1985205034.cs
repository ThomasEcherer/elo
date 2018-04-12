//
// Serializer for de.elo.ix.client.FindByIndex
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1985205034 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1985205034();
		
		public BSerializer_1985205034()
			: base(1985205034) {}
		
		public BSerializer_1985205034(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FindByIndex obj = (FindByIndex)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.delDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.desc);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.iDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.maskId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ownerId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.xDateIso);
			if (version >= 700000000000010L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.acl);
				if (version >= 700000000000035L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putBoolean(obj.exactName);
					if (version >= 700000000000045L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.pathId);
						if (version >= 800000030000003L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.kind);
							if (version >= 900000000000031L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putString(obj.lockId);
								if (version >= 1000000020000014L) {
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putString(obj.deleteDateIso);
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putString(obj.deleteUser);
								}
							}
						}
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.objKeys, false, EloixClient.IndexServer.BSerializer_1628260993.instance);
			if (version >= 900000040000003L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.maskIds, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindByIndex obj = (FindByIndex)(obj1 != null ? obj1 : bin.onObjectCreated(new FindByIndex()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.delDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.desc = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.iDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.maskId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ownerId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.xDateIso = bbuf.getString();
			if (version >= 700000000000010L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.acl = bbuf.getString();
				if (version >= 700000000000035L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.exactName = bbuf.getBoolean();
					if (version >= 700000000000045L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.pathId = bbuf.getString();
						if (version >= 800000030000003L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.kind = bbuf.getString();
							if (version >= 900000000000031L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.lockId = bbuf.getString();
								if (version >= 1000000020000014L) {
									// checkpoint byps.gen.cs.PrintContext:449
									obj.deleteDateIso = bbuf.getString();
									// checkpoint byps.gen.cs.PrintContext:449
									obj.deleteUser = bbuf.getString();
								}
							}
						}
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objKeys = (EloixClient.IndexServer.ObjKey[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1628260993.instance);
			if (version >= 900000040000003L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.maskIds = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			}
			
			return obj;
		}
		
	}
} // namespace
