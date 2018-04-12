//
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onAfterCheckinNotes
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1729896360 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1729896360();
		
		public BSerializer_1729896360()
			: base(1729896360) {}
		
		public BSerializer_1729896360(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServerEvents_onAfterCheckinNotes obj = (BRequest_IXServerEvents_onAfterCheckinNotes)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.noteCValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ecValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.notesValue, false, EloixClient.IndexServer.BSerializer_776454091.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sordsValue, false, EloixClient.IndexServer.BSerializer_919539303.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.unlockZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServerEvents_onAfterCheckinNotes obj = (BRequest_IXServerEvents_onAfterCheckinNotes)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServerEvents_onAfterCheckinNotes()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.noteCValue = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ecValue = (EloixClient.IndexServer.IXServerEventsContext)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.notesValue = (EloixClient.IndexServer.Note[])bin.readObj(false, EloixClient.IndexServer.BSerializer_776454091.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sordsValue = (EloixClient.IndexServer.Sord[])bin.readObj(false, EloixClient.IndexServer.BSerializer_919539303.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.unlockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
