//
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onBeforeCheckinMap
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1578945530 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1578945530();
		
		public BSerializer_1578945530()
			: base(1578945530) {}
		
		public BSerializer_1578945530(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServerEvents_onBeforeCheckinMap obj = (BRequest_IXServerEvents_onBeforeCheckinMap)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.domainNameValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.idValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.objIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.dataValue, false, EloixClient.IndexServer.BSerializer_1826370901.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ecValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.unlockZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServerEvents_onBeforeCheckinMap obj = (BRequest_IXServerEvents_onBeforeCheckinMap)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServerEvents_onBeforeCheckinMap()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.domainNameValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.idValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objIdValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dataValue = (EloixClient.IndexServer.KeyValue[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1826370901.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ecValue = (EloixClient.IndexServer.IXServerEventsContext)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.unlockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
