//
// Serializer for de.elo.ix.client.WFDelegateNodeInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_20892334 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_20892334();
		
		public BSerializer_20892334()
			: base(20892334) {}
		
		public BSerializer_20892334(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			WFDelegateNodeInfo obj = (WFDelegateNodeInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.backNodeComment);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.backNodeMoveX);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.backNodeMoveY);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.backNodeName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.delegateNodeComment);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.delegateNodeMoveX);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.delegateNodeMoveY);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.delegateNodeName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.delegateToUserId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.flowId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nodeId);
			if (version >= 1000000020000008L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.delegateParallel);
			}
			if (version >= 800000000000004L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.copyMembersToBackNodeZ, false, null);
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.copyMembersToDelegateNodeZ, false, null);
				if (version >= 1000000020000008L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bout.writeObj(obj.delegateToUserIds, false, EloixClient.IndexServer.BSerializer_2123584667.instance);
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WFDelegateNodeInfo obj = (WFDelegateNodeInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new WFDelegateNodeInfo()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.backNodeComment = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.backNodeMoveX = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.backNodeMoveY = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.backNodeName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.delegateNodeComment = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.delegateNodeMoveX = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.delegateNodeMoveY = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.delegateNodeName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.delegateToUserId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flowId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodeId = bbuf.getInt();
			if (version >= 1000000020000008L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.delegateParallel = bbuf.getBoolean();
			}
			if (version >= 800000000000004L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.copyMembersToBackNodeZ = (EloixClient.IndexServer.WFNodeZ)bin.readObj(false, null);
				// checkpoint byps.gen.cs.PrintContext:449
				obj.copyMembersToDelegateNodeZ = (EloixClient.IndexServer.WFNodeZ)bin.readObj(false, null);
				if (version >= 1000000020000008L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.delegateToUserIds = (IList<String>)bin.readObj(false, null);
				}
			}
			
			return obj;
		}
		
	}
} // namespace
