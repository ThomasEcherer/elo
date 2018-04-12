//
// Serializer for de.elo.ix.client.DocMask
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2054753789 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2054753789();
		
		public BSerializer_2054753789()
			: base(2054753789) {}
		
		public BSerializer_2054753789(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			DocMask obj = (DocMask)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.DAcl);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.DKind);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.DPath);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.TStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.acl);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.barcode);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.flowId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.index);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lifetime);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lockId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.text);
			if (version >= 700000000000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.deleted);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.guid);
				if (version >= 700000026000002L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.lockName);
					if (version >= 700000040000016L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.flowId2);
						if (version >= 900000018000005L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.nameTranslationKey);
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.textTranslationKey);
							if (version >= 900000039000001L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putInt(obj.dataOrganisation);
								if (version >= 900990009000001L) {
									// checkpoint byps.gen.cs.PrintContext:494
									bbuf.putString(obj.TStampSync);
								}
							}
						}
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.aclItems, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.details, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.docAclItems, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.lines, false, EloixClient.IndexServer.BSerializer_745804061.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			DocMask obj = (DocMask)(obj1 != null ? obj1 : bin.onObjectCreated(new DocMask()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.DAcl = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.DKind = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.DPath = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.TStamp = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.acl = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.barcode = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flowId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.index = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lifetime = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.text = bbuf.getString();
			if (version >= 700000000000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.deleted = bbuf.getBoolean();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.guid = bbuf.getString();
				if (version >= 700000026000002L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.lockName = bbuf.getString();
					if (version >= 700000040000016L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.flowId2 = bbuf.getInt();
						if (version >= 900000018000005L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.nameTranslationKey = bbuf.getString();
							// checkpoint byps.gen.cs.PrintContext:449
							obj.textTranslationKey = bbuf.getString();
							if (version >= 900000039000001L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.dataOrganisation = bbuf.getInt();
								if (version >= 900990009000001L) {
									// checkpoint byps.gen.cs.PrintContext:449
									obj.TStampSync = bbuf.getString();
								}
							}
						}
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.aclItems = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.details = (EloixClient.IndexServer.DocMaskDetails)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.docAclItems = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lines = (EloixClient.IndexServer.DocMaskLine[])bin.readObj(false, EloixClient.IndexServer.BSerializer_745804061.instance);
			
			return obj;
		}
		
	}
} // namespace
