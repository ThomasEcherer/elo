//
// Serializer for de.elo.ix.client.ReminderC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1431555044 : EloixClient.IndexServer.BSerializer_1099169893 {
		
		public readonly static new BSerializer instance = new BSerializer_1431555044();
		
		public BSerializer_1431555044()
			: base(1431555044) {}
		
		public BSerializer_1431555044(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ReminderC obj = (ReminderC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ReminderC obj = (ReminderC)(obj1 != null ? obj1 : bin.onObjectCreated(new ReminderC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
