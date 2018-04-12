//
// Serializer for de.elo.ix.client.myelo.MyELOInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.myelo
{
	
	public class BSerializer_455864090 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_455864090();
		
		public BSerializer_455864090()
			: base(455864090) {}
		
		public BSerializer_455864090(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			MyELOInfo obj = (MyELOInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.date);
			if (version >= 1000000020000002L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.max);
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.notificationInfo, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.taskInfo, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.workflowInfo, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			MyELOInfo obj = (MyELOInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new MyELOInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.date = bbuf.getString();
			if (version >= 1000000020000002L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.max = bbuf.getInt();
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.notificationInfo = (EloixClient.IndexServer.feed.FindNotificationInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.taskInfo = (EloixClient.IndexServer.FindTasksInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.workflowInfo = (EloixClient.IndexServer.FindWorkflowInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
