//
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onBeforeFindSords
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_384369013 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_384369013();
		
		public BSerializer_384369013()
			: base(384369013) {}
		
		public BSerializer_384369013(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServerEvents_onBeforeFindSords obj = (BRequest_IXServerEvents_onBeforeFindSords)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ecValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.findInfoValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sordZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServerEvents_onBeforeFindSords obj = (BRequest_IXServerEvents_onBeforeFindSords)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServerEvents_onBeforeFindSords()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ecValue = (EloixClient.IndexServer.IXServerEventsContext)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.findInfoValue = (EloixClient.IndexServer.FindInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sordZValue = (EloixClient.IndexServer.SordZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
