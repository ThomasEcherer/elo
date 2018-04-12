//
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onAfterCheckinActivity
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1027171864 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1027171864();
		
		public BSerializer_1027171864()
			: base(1027171864) {}
		
		public BSerializer_1027171864(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServerEvents_onAfterCheckinActivity obj = (BRequest_IXServerEvents_onAfterCheckinActivity)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.isNewValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.actValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ecValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sordValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sordZValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.unlockZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServerEvents_onAfterCheckinActivity obj = (BRequest_IXServerEvents_onAfterCheckinActivity)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServerEvents_onAfterCheckinActivity()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.isNewValue = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.actValue = (EloixClient.IndexServer.Activity)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ecValue = (EloixClient.IndexServer.IXServerEventsContext)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sordValue = (EloixClient.IndexServer.Sord)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sordZValue = (EloixClient.IndexServer.SordZ)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.unlockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
