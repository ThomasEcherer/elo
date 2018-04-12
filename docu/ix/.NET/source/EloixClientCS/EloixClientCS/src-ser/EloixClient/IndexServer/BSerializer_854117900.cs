//
// Serializer for de.elo.ix.client.UserTaskSortOrderC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_854117900 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_854117900();
		
		public BSerializer_854117900()
			: base(854117900) {}
		
		public BSerializer_854117900(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			UserTaskSortOrderC obj = (UserTaskSortOrderC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			UserTaskSortOrderC obj = (UserTaskSortOrderC)(obj1 != null ? obj1 : bin.onObjectCreated(new UserTaskSortOrderC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
