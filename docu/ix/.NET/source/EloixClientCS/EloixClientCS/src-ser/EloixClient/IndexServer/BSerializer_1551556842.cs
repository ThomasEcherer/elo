//
// Serializer for de.elo.ix.client.SortOrderC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1551556842 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1551556842();
		
		public BSerializer_1551556842()
			: base(1551556842) {}
		
		public BSerializer_1551556842(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			SortOrderC obj = (SortOrderC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SortOrderC obj = (SortOrderC)(obj1 != null ? obj1 : bin.onObjectCreated(new SortOrderC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
