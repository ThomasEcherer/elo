//
// Serializer for de.elo.ix.client.WFNodeMatrixC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_171864975 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_171864975();
		
		public BSerializer_171864975()
			: base(171864975) {}
		
		public BSerializer_171864975(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			WFNodeMatrixC obj = (WFNodeMatrixC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WFNodeMatrixC obj = (WFNodeMatrixC)(obj1 != null ? obj1 : bin.onObjectCreated(new WFNodeMatrixC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
