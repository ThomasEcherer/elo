//
// Serializer for de.elo.ix.client.Sord
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1576327931 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1576327931();
		
		public BSerializer_1576327931()
			: base(1576327931) {}
		
		public BSerializer_1576327931(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			Sord obj = (Sord)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.IDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.SReg);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.TStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.XDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.access);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.acl);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.att);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.childCount);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.delDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.deleted);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.desc);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.doc);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.guid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.hiddenText);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.histCount);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.info);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.key);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.kind);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lockId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lockName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.mask);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.ownerId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ownerName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.parentId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.path);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.type);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.vtRep);
			if (version >= 700000000000028L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.maskName);
				if (version >= 900000000000000L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.deleteDateIso);
					if (version >= 900990009000001L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.TStampAcl);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.TStampAclSync);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.TStampSync);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.lockIdDoc);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.lockIdSord);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.lockNameDoc);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.lockNameSord);
						if (version >= 1000000020000012L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putInt(obj.deleteUser);
						}
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.aclItems, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.details, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.docVersion, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.linksComeIn, false, EloixClient.IndexServer.BSerializer_376993407.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.linksGoOut, false, EloixClient.IndexServer.BSerializer_376993407.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.objKeys, false, EloixClient.IndexServer.BSerializer_1628260993.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.parentIds, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.refPaths, false, EloixClient.IndexServer.BSerializer_1192039710.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.replNames, false, EloixClient.IndexServer.BSerializer_884364631.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.replSet, false, null);
			if (version >= 700000040000007L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.attVersion, false, null);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			Sord obj = (Sord)(obj1 != null ? obj1 : bin.onObjectCreated(new Sord()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.IDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.SReg = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.TStamp = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.XDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.access = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.acl = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.att = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.childCount = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.delDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.deleted = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.desc = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.doc = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.guid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.hiddenText = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.histCount = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.info = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.key = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.kind = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.mask = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ownerId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ownerName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.parentId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.path = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.type = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.vtRep = bbuf.getInt();
			if (version >= 700000000000028L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.maskName = bbuf.getString();
				if (version >= 900000000000000L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.deleteDateIso = bbuf.getString();
					if (version >= 900990009000001L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.TStampAcl = bbuf.getString();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.TStampAclSync = bbuf.getString();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.TStampSync = bbuf.getString();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.lockIdDoc = bbuf.getInt();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.lockIdSord = bbuf.getInt();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.lockNameDoc = bbuf.getString();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.lockNameSord = bbuf.getString();
						if (version >= 1000000020000012L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.deleteUser = bbuf.getInt();
						}
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.aclItems = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.details = (EloixClient.IndexServer.SordDetails)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.docVersion = (EloixClient.IndexServer.DocVersion)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.linksComeIn = (EloixClient.IndexServer.SordLink[])bin.readObj(false, EloixClient.IndexServer.BSerializer_376993407.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.linksGoOut = (EloixClient.IndexServer.SordLink[])bin.readObj(false, EloixClient.IndexServer.BSerializer_376993407.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objKeys = (EloixClient.IndexServer.ObjKey[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1628260993.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.parentIds = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.refPaths = (EloixClient.IndexServer.ArcPath[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1192039710.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.replNames = (EloixClient.IndexServer.ReplSetName[])bin.readObj(false, EloixClient.IndexServer.BSerializer_884364631.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.replSet = (EloixClient.IndexServer.ReplSet)bin.readObj(false, null);
			if (version >= 700000040000007L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.attVersion = (EloixClient.IndexServer.DocVersion)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace
