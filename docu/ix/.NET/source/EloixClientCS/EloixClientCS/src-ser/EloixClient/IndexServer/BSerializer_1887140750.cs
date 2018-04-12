//
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_getAppInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1887140750 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1887140750();
		
		public BSerializer_1887140750()
			: base(1887140750) {}
		
		public BSerializer_1887140750(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServerEvents_getAppInfo obj = (BRequest_IXServerEvents_getAppInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ecValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServerEvents_getAppInfo obj = (BRequest_IXServerEvents_getAppInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServerEvents_getAppInfo()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ecValue = (EloixClient.IndexServer.IXServerEventsContext)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
