//
// Serializer for de.elo.ix.client.CheckinReportInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_279483092 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_279483092();
		
		public BSerializer_279483092()
			: base(279483092) {}
		
		public BSerializer_279483092(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			CheckinReportInfo obj = (CheckinReportInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new CheckinReportInfo()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
