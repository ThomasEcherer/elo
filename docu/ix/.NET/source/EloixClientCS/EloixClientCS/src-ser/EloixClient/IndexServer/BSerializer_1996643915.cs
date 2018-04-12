//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_checkinReport
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1996643915 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1996643915();
		
		public BSerializer_1996643915()
			: base(1996643915) {}
		
		public BSerializer_1996643915(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_checkinReport obj = (BRequest_IXServicePortIF_checkinReport)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.lockZValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.reportValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.reservedValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_checkinReport obj = (BRequest_IXServicePortIF_checkinReport)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_checkinReport()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.reportValue = (EloixClient.IndexServer.ReportInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.reservedValue = (EloixClient.IndexServer.CheckinReportInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
