//
// Serializer for de.elo.ix.client.feed.Action
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_736351635 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_736351635();
		
		public BSerializer_736351635()
			: base(736351635) {}
		
		public BSerializer_736351635(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			Action obj = (Action)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.TStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.changeCounter);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.createDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.docVersionGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.feedGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.guid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.parentGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.text);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt((int)obj.type);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.updateDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.userId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.workflowGuid);
			if (version >= 900000000000034L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.acl);
				if (version >= 900990009000001L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.TStampSync);
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.docVersion, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.workflow, false, null);
			if (version >= 900000000000033L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.history, false, EloixClient.IndexServer.BSerializer_1399835671.instance);
				if (version >= 900000000000034L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bout.writeObj(obj.aclItems, false, EloixClient.IndexServer.BSerializer_1944875656.instance);
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			Action obj = (Action)(obj1 != null ? obj1 : bin.onObjectCreated(new Action()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.TStamp = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.changeCounter = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.createDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.docVersionGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.feedGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.guid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.parentGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.text = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.type = (EloixClient.IndexServer.feed.EActionType)bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.updateDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.workflowGuid = bbuf.getString();
			if (version >= 900000000000034L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.acl = bbuf.getString();
				if (version >= 900990009000001L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.TStampSync = bbuf.getString();
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.docVersion = (EloixClient.IndexServer.DocVersion)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.workflow = (EloixClient.IndexServer.WFDiagram)bin.readObj(false, null);
			if (version >= 900000000000033L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.history = (IList<EloixClient.IndexServer.feed.ActionHistory>)bin.readObj(false, null);
				if (version >= 900000000000034L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.aclItems = (EloixClient.IndexServer.AclItem[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1944875656.instance);
				}
			}
			
			return obj;
		}
		
	}
} // namespace
