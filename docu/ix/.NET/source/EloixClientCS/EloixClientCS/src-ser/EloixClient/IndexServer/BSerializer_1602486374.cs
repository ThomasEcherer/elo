//
// Serializer for de.elo.ix.client.CheckinUsersC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1602486374 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1602486374();
		
		public BSerializer_1602486374()
			: base(1602486374) {}
		
		public BSerializer_1602486374(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			CheckinUsersC obj = (CheckinUsersC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			CheckinUsersC obj = (CheckinUsersC)(obj1 != null ? obj1 : bin.onObjectCreated(new CheckinUsersC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
