//
// Serializer for de.elo.ix.client.StartAdHocWorkflowInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1587514612 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1587514612();
		
		public BSerializer_1587514612()
			: base(1587514612) {}
		
		public BSerializer_1587514612(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			StartAdHocWorkflowInfo obj = (StartAdHocWorkflowInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.breakWorkflowMessage);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.cancelMessage);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.cancelUserId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.finishedMessage);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.finishedScript);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.finishedUserId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.forValidation);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.nodeName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.serialFlow);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.workflowRepeatMessage);
			if (version >= 900000012000004L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.deactivateNodes);
				if (version >= 900000012000006L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.acceptMessage);
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.noticeMessage);
					if (version >= 900000014000006L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.actionRejectMessage);
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putString(obj.successMessage);
						if (version >= 900000016000013L) {
							// checkpoint byps.gen.cs.PrintContext:494
							bbuf.putInt(obj.flags);
						}
					}
				}
			}
			if (version >= 900000012000004L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.userIdsToDeactivate, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
				if (version >= 900000016000009L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bout.writeObj(obj.timeLimit, false, null);
					// checkpoint byps.gen.cs.PrintContext:494
					bout.writeObj(obj.timeLimitEscalations, false, EloixClient.IndexServer.BSerializer_1495941578.instance);
					if (version >= 1000000000000008L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bout.writeObj(obj.nodeInfos, false, EloixClient.IndexServer.BSerializer_1241863010.instance);
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			StartAdHocWorkflowInfo obj = (StartAdHocWorkflowInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new StartAdHocWorkflowInfo()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.breakWorkflowMessage = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.cancelMessage = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.cancelUserId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.finishedMessage = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.finishedScript = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.finishedUserId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.forValidation = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodeName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.serialFlow = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.workflowRepeatMessage = bbuf.getString();
			if (version >= 900000012000004L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.deactivateNodes = bbuf.getBoolean();
				if (version >= 900000012000006L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.acceptMessage = bbuf.getString();
					// checkpoint byps.gen.cs.PrintContext:449
					obj.noticeMessage = bbuf.getString();
					if (version >= 900000014000006L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.actionRejectMessage = bbuf.getString();
						// checkpoint byps.gen.cs.PrintContext:449
						obj.successMessage = bbuf.getString();
						if (version >= 900000016000013L) {
							// checkpoint byps.gen.cs.PrintContext:449
							obj.flags = bbuf.getInt();
						}
					}
				}
			}
			if (version >= 900000012000004L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.userIdsToDeactivate = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
				if (version >= 900000016000009L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.timeLimit = (EloixClient.IndexServer.WFTimeLimit)bin.readObj(false, null);
					// checkpoint byps.gen.cs.PrintContext:449
					obj.timeLimitEscalations = (EloixClient.IndexServer.WFTimeLimit[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1495941578.instance);
					if (version >= 1000000000000008L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.nodeInfos = (IList<EloixClient.IndexServer.ValueClass>)bin.readObj(false, null);
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace
