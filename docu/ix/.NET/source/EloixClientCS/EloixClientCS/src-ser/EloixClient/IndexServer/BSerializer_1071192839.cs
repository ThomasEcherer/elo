//
// Serializer for de.elo.ix.client.ReportInfoC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1071192839 : EloixClient.IndexServer.BSerializer_1285453013 {
		
		public readonly static new BSerializer instance = new BSerializer_1071192839();
		
		public BSerializer_1071192839()
			: base(1071192839) {}
		
		public BSerializer_1071192839(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ReportInfoC obj = (ReportInfoC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ReportInfoC obj = (ReportInfoC)(obj1 != null ? obj1 : bin.onObjectCreated(new ReportInfoC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
