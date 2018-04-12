//
// Serializer for de.elo.ix.client.ReportOptions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1057373949 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1057373949();
		
		public BSerializer_1057373949()
			: base(1057373949) {}
		
		public BSerializer_1057373949(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ReportOptions obj = (ReportOptions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.erpCodes, false, EloixClient.IndexServer.BSerializer_1004870809.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.mode, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ReportOptions obj = (ReportOptions)(obj1 != null ? obj1 : bin.onObjectCreated(new ReportOptions()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.erpCodes = (EloixClient.IndexServer.ReportErpCode[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1004870809.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.mode = (EloixClient.IndexServer.ReportModeZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
