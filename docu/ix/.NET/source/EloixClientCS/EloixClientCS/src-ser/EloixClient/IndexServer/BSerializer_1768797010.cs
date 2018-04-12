//
// Serializer for de.elo.ix.client.FindWorkflowInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1768797010 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1768797010();
		
		public BSerializer_1768797010()
			: base(1768797010) {}
		
		public BSerializer_1768797010(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FindWorkflowInfo obj = (FindWorkflowInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			if (version >= 600000098000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.completionDateIso);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.inclDeleted);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.name);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.objId);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.overTimeLimit);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.startDateIso);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.templateId);
				if (version >= 900000018000006L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putBoolean(obj.inclHidden);
					if (version >= 1000000000000001L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putBoolean(obj.excludeUserGroups);
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.userIds, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			if (version >= 600000098000000L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.type, false, null);
				if (version >= 700000020000007L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bout.writeObj(obj.activeUserIds, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
					// checkpoint byps.gen.cs.PrintContext:494
					bout.writeObj(obj.ownerIds, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
					if (version >= 900990009000007L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bout.writeObj(obj.sordZ, false, null);
					}
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindWorkflowInfo obj = (FindWorkflowInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new FindWorkflowInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			if (version >= 600000098000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.completionDateIso = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.inclDeleted = bbuf.getBoolean();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.name = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.objId = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.overTimeLimit = bbuf.getBoolean();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.startDateIso = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.templateId = bbuf.getString();
				if (version >= 900000018000006L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.inclHidden = bbuf.getBoolean();
					if (version >= 1000000000000001L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.excludeUserGroups = bbuf.getBoolean();
					}
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userIds = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			if (version >= 600000098000000L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.type = (EloixClient.IndexServer.WFTypeZ)bin.readObj(false, null);
				if (version >= 700000020000007L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.activeUserIds = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
					// checkpoint byps.gen.cs.PrintContext:449
					obj.ownerIds = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
					if (version >= 900990009000007L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.sordZ = (EloixClient.IndexServer.SordZ)bin.readObj(false, null);
					}
				}
			}
			
			return obj;
		}
		
	}
} // namespace
