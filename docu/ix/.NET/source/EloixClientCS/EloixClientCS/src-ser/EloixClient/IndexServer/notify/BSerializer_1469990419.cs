//
// Serializer for de.elo.ix.client.notify.BRequest_ClientNotification_updateTask
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.notify
{
	
	public class BSerializer_1469990419 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1469990419();
		
		public BSerializer_1469990419()
			: base(1469990419) {}
		
		public BSerializer_1469990419(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_ClientNotification_updateTask obj = (BRequest_ClientNotification_updateTask)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt((int)obj.notifyTypeValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.userTaskValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_ClientNotification_updateTask obj = (BRequest_ClientNotification_updateTask)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_ClientNotification_updateTask()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.notifyTypeValue = (EloixClient.IndexServer.notify.TaskNotifyType)bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userTaskValue = (EloixClient.IndexServer.UserTask)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
