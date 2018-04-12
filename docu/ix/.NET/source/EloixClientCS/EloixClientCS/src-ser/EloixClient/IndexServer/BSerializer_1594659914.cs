//
// Serializer for de.elo.ix.client.ReportModeC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1594659914 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1594659914();
		
		public BSerializer_1594659914()
			: base(1594659914) {}
		
		public BSerializer_1594659914(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ReportModeC obj = (ReportModeC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ReportModeC obj = (ReportModeC)(obj1 != null ? obj1 : bin.onObjectCreated(new ReportModeC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
