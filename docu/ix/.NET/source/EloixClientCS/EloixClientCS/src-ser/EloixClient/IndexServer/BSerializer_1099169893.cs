//
// Serializer for de.elo.ix.client.ReminderDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1099169893 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1099169893();
		
		public BSerializer_1099169893()
			: base(1099169893) {}
		
		public BSerializer_1099169893(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ReminderDataC obj = (ReminderDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnDesc);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnName);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ReminderDataC obj = (ReminderDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new ReminderDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnDesc = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnName = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
