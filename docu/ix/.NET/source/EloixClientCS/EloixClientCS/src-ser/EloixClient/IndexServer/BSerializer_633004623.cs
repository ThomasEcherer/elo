//
// Serializer for de.elo.ix.client.DocVersion
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_633004623 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_633004623();
		
		public BSerializer_633004623()
			: base(633004623) {}
		
		public BSerializer_633004623(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			DocVersion obj = (DocVersion)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.accessDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.comment);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.createDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.deleted);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.encryptionSet);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ext);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.guid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.md5);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.milestone);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.ownerId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ownerName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.pathId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.pathId2);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.physPath);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.previewUrl);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.size);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.tStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.updateDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.uploadResult);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.url);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.version);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.workVersion);
			if (version >= 600000095000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.contentType);
				if (version >= 900000000000000L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.deleteDateIso);
					if (version >= 900000016000002L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putInt(obj.nbOfValidSignatures);
						if (version >= 900000030000023L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.relativeFilePath);
							if (version >= 900990009000001L) {
								// checkpoint byps.gen.cs.PrintContext:494
								bbuf.putString(obj.tStampSync);
							}
						}
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.fileData, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sig, false, null);
			if (version >= 600000087000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.preview, false, null);
				if (version >= 700000020000003L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bout.writeObj(obj.fulltextContent, false, null);
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			DocVersion obj = (DocVersion)(obj1 != null ? obj1 : bin.onObjectCreated(new DocVersion()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.accessDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.comment = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.createDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.deleted = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.encryptionSet = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ext = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.guid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.md5 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.milestone = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ownerId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ownerName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.pathId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.pathId2 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.physPath = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.previewUrl = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.size = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tStamp = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.updateDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.uploadResult = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.url = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.version = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.workVersion = bbuf.getBoolean();
			if (version >= 600000095000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.contentType = bbuf.getString();
				if (version >= 900000000000000L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.deleteDateIso = bbuf.getString();
					if (version >= 900000016000002L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.nbOfValidSignatures = bbuf.getInt();
						if (version >= 900000030000023L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.relativeFilePath = bbuf.getString();
							if (version >= 900990009000001L) {
								// checkpoint byps.gen.cs.PrintContext:449
								obj.tStampSync = bbuf.getString();
							}
						}
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fileData = (EloixClient.IndexServer.FileData)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sig = (EloixClient.IndexServer.DocVersion)bin.readObj(false, null);
			if (version >= 600000087000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.preview = (EloixClient.IndexServer.DocVersion)bin.readObj(false, null);
				if (version >= 700000020000003L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.fulltextContent = (EloixClient.IndexServer.DocVersion)bin.readObj(false, null);
				}
			}
			
			return obj;
		}
		
	}
} // namespace
