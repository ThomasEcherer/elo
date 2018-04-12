//
// Serializer for de.elo.ix.client.feed.FindActionsInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_1747180074 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1747180074();
		
		public BSerializer_1747180074()
			: base(1747180074) {}
		
		public BSerializer_1747180074(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			FindActionsInfo obj = (FindActionsInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.createDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userId);
			if (version >= 900000014000003L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.findNotifications);
				if (version >= 900000022000016L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putBoolean(obj.findHashTags);
					if (version >= 900000030000016L) {
						// checkpoint byps.gen.cs.PrintContext:494
						bbuf.putBoolean(obj.findSubscriptions);
					}
				}
			}
			if (version >= 900000012000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.actionTypes, false, EloixClient.IndexServer.BSerializer_1644858720.instance);
				if (version >= 900000014000003L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bout.writeObj(obj.sordZ, false, null);
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindActionsInfo obj = (FindActionsInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new FindActionsInfo()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.createDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userId = bbuf.getString();
			if (version >= 900000014000003L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.findNotifications = bbuf.getBoolean();
				if (version >= 900000022000016L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.findHashTags = bbuf.getBoolean();
					if (version >= 900000030000016L) {
						// checkpoint byps.gen.cs.PrintContext:449
						obj.findSubscriptions = bbuf.getBoolean();
					}
				}
			}
			if (version >= 900000012000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.actionTypes = (IList<EloixClient.IndexServer.feed.EActionType>)bin.readObj(false, null);
				if (version >= 900000014000003L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.sordZ = (EloixClient.IndexServer.SordZ)bin.readObj(false, null);
				}
			}
			
			return obj;
		}
		
	}
} // namespace
