//
// Serializer for de.elo.ix.client.BRequest_IXServerEvents_onCreateSord
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1849307166 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1849307166();
		
		public BSerializer_1849307166()
			: base(1849307166) {}
		
		public BSerializer_1849307166(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServerEvents_onCreateSord obj = (BRequest_IXServerEvents_onCreateSord)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.maskIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.parentIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ecValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.editZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServerEvents_onCreateSord obj = (BRequest_IXServerEvents_onCreateSord)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServerEvents_onCreateSord()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.maskIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.parentIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ecValue = (EloixClient.IndexServer.IXServerEventsContext)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.editZValue = (EloixClient.IndexServer.EditInfoZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
