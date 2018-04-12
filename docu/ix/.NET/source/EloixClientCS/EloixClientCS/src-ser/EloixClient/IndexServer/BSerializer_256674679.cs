//
// Serializer for de.elo.ix.client.Reminder
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_256674679 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_256674679();
		
		public BSerializer_256674679()
			: base(256674679) {}
		
		public BSerializer_256674679(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			Reminder obj = (Reminder)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.createDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.deleted);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.desc);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.dueDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.id);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lockId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.lockName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.name);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.notifyOnDelete);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.notifyOnView);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.objId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.objType);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.prio);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.promptDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.receiverId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.receiverName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.senderId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.senderName);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			Reminder obj = (Reminder)(obj1 != null ? obj1 : bin.onObjectCreated(new Reminder()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.createDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.deleted = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.desc = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dueDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.id = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.name = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.notifyOnDelete = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.notifyOnView = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objType = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.prio = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.promptDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.receiverId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.receiverName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.senderId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.senderName = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace
