//
// Serializer for de.elo.ix.client.Note
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_937420667 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_937420667();
		
		public BSerializer_937420667()
			: base(937420667) {}
		
		public BSerializer_937420667(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			Note obj = (Note)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.TStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.XPos);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.YPos);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.acl);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.createDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.deleted);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.desc);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.guid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.height);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lockId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lockName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.ownerId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ownerName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.pageNo);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.type);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.width);
			if (version >= 600000087000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.color);
				if (version >= 700000000000026L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.access);
					if (version >= 900000000000000L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.deleteDateIso);
						if (version >= 900990009000001L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putString(obj.TStampSync);
						}
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.aclItems, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			if (version >= 700000000000023L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.noteFreehand, false, null);
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.noteImage, false, null);
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.noteText, false, null);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			Note obj = (Note)(obj1 != null ? obj1 : bin.onObjectCreated(new Note()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.TStamp = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.XPos = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.YPos = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.acl = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.createDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.deleted = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.desc = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.guid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.height = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ownerId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ownerName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.pageNo = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.type = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.width = bbuf.getInt();
			if (version >= 600000087000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.color = bbuf.getInt();
				if (version >= 700000000000026L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.access = bbuf.getInt();
					if (version >= 900000000000000L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.deleteDateIso = bbuf.getString();
						if (version >= 900990009000001L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.TStampSync = bbuf.getString();
						}
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.aclItems = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
			if (version >= 700000000000023L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.noteFreehand = (EloixClient.IndexServer.NoteFreehand)bin.readObj(false, null);
				// checkpoint byps.gen.cs.PrintContext:449
				obj.noteImage = (EloixClient.IndexServer.NoteImage)bin.readObj(false, null);
				// checkpoint byps.gen.cs.PrintContext:449
				obj.noteText = (EloixClient.IndexServer.NoteText)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace
