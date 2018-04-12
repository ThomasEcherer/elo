//
// Serializer for de.elo.ix.client.ActivityDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_72578008 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_72578008();
		
		public BSerializer_72578008()
			: base(72578008) {}
		
		public BSerializer_72578008(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ActivityDataC obj = (ActivityDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnBackAt);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnBackMode);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnComment);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnDestination);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnDueDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnFileName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnObjGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnProject);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnRevVers);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnSentAtIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnSentMode);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnTStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnUd0);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnUd1);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnUd2);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnUd3);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnUd4);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnUd5);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnUd6);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnUd7);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnUd8);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnUd9);
			if (version >= 800000012000001L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnTransId);
				if (version >= 900990009000001L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.lnTStampSync);
				}
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ActivityDataC obj = (ActivityDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new ActivityDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnBackAt = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnBackMode = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnComment = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnDestination = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnDueDateIso = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnFileName = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnName = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnObjGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnProject = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnRevVers = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnSentAtIso = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnSentMode = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnTStamp = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnUd0 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnUd1 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnUd2 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnUd3 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnUd4 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnUd5 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnUd6 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnUd7 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnUd8 = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnUd9 = bbuf.getInt();
			if (version >= 800000012000001L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnTransId = bbuf.getInt();
				if (version >= 900990009000001L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.lnTStampSync = bbuf.getInt();
				}
			}
			
			return obj;
		}
		
	}
} // namespace
