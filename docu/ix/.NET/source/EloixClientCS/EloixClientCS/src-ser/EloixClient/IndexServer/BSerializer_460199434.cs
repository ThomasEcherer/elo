//
// Serializer for de.elo.ix.client.Activity
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_460199434 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_460199434();
		
		public BSerializer_460199434()
			: base(460199434) {}
		
		public BSerializer_460199434(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			Activity obj = (Activity)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.TStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.backAt);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.backMode);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.comment);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.destination);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.dueDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.fileName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.guid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.prio);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.project);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.receiverId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.receiverName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.revVers);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.senderId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.senderName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.sentAtIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.sentMode);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ud0);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ud1);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ud2);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ud3);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ud4);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ud5);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ud6);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ud7);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ud8);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.ud9);
			if (version >= 800000012000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.transId);
				if (version >= 800000018000001L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.objId);
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.objType);
					if (version >= 900990009000001L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.TStampSync);
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			Activity obj = (Activity)(obj1 != null ? obj1 : bin.onObjectCreated(new Activity()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.TStamp = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.backAt = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.backMode = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.comment = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.destination = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dueDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fileName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.guid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.prio = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.project = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.receiverId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.receiverName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.revVers = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.senderId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.senderName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sentAtIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sentMode = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ud0 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ud1 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ud2 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ud3 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ud4 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ud5 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ud6 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ud7 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ud8 = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ud9 = bbuf.getString();
			if (version >= 800000012000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.transId = bbuf.getString();
				if (version >= 800000018000001L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.objId = bbuf.getInt();
					// checkpoint byps.gen.cs.PrintContext:449
					obj.objType = bbuf.getInt();
					if (version >= 900990009000001L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.TStampSync = bbuf.getString();
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace
