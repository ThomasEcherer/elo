//
// Serializer for de.elo.ix.client.FindReportInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_504724737 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_504724737();
		
		public BSerializer_504724737()
			: base(504724737) {}
		
		public BSerializer_504724737(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FindReportInfo obj = (FindReportInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.endDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.orderBy);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.searchId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.startDateIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.timeoutSeconds);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.totalCount);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userId);
			if (version >= 900000016000004L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.extra1);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.findLastEntryBeforeEndDate);
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.erpCodes, false, EloixClient.IndexServer.BSerializer_100361105.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindReportInfo obj = (FindReportInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new FindReportInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.endDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.orderBy = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.searchId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.startDateIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.timeoutSeconds = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.totalCount = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userId = bbuf.getString();
			if (version >= 900000016000004L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.extra1 = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.findLastEntryBeforeEndDate = bbuf.getBoolean();
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.erpCodes = (int[])bin.readObj(false, EloixClient.IndexServer.BSerializer_100361105.instance);
			
			return obj;
		}
		
	}
} // namespace
