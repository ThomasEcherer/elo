//
// Serializer for de.elo.ix.client.WorkflowExportOptionsC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1063132081 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1063132081();
		
		public BSerializer_1063132081()
			: base(1063132081) {}
		
		public BSerializer_1063132081(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			WorkflowExportOptionsC obj = (WorkflowExportOptionsC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WorkflowExportOptionsC obj = (WorkflowExportOptionsC)(obj1 != null ? obj1 : bin.onObjectCreated(new WorkflowExportOptionsC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
