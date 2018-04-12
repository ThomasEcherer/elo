//
// Serializer for de.elo.ix.client.FindAlertInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_897433042 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_897433042();
		
		public BSerializer_897433042()
			: base(897433042) {}
		
		public BSerializer_897433042(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			FindAlertInfo obj = (FindAlertInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.destId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclAlam);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclAll);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclInTray);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclOthers);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclReminder);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclSubs);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclWorkFlow);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.sourceId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.timeIso);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindAlertInfo obj = (FindAlertInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new FindAlertInfo()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.destId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclAlam = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclAll = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclInTray = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclOthers = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclReminder = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclSubs = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclWorkFlow = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sourceId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.timeIso = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace
