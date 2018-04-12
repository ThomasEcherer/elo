//
// Serializer for de.elo.ix.client.ReportOptionsC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2081332891 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_2081332891();
		
		public BSerializer_2081332891()
			: base(2081332891) {}
		
		public BSerializer_2081332891(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ReportOptionsC obj = (ReportOptionsC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ReportOptionsC obj = (ReportOptionsC)(obj1 != null ? obj1 : bin.onObjectCreated(new ReportOptionsC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
