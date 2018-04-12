//
// Serializer for de.elo.ix.client.WorkFlowNodeMatrixC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_813423307 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_813423307();
		
		public BSerializer_813423307()
			: base(813423307) {}
		
		public BSerializer_813423307(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			WorkFlowNodeMatrixC obj = (WorkFlowNodeMatrixC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			if (version >= 900000030000014L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putInt(obj.lnEdgesOrdinals);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WorkFlowNodeMatrixC obj = (WorkFlowNodeMatrixC)(obj1 != null ? obj1 : bin.onObjectCreated(new WorkFlowNodeMatrixC()));
			
			BBufferBin bbuf = bin.bbuf;
			if (version >= 900000030000014L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.lnEdgesOrdinals = bbuf.getInt();
			}
			
			return obj;
		}
		
	}
} // namespace
