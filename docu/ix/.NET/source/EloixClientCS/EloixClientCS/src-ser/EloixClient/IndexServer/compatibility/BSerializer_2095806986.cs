//
// Serializer for de.elo.ix.client.compatibility.BRequest_WClientService_onAfterVersionChanged
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.compatibility
{
	
	public class BSerializer_2095806986 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_2095806986();
		
		public BSerializer_2095806986()
			: base(2095806986) {}
		
		public BSerializer_2095806986(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_WClientService_onAfterVersionChanged obj = (BRequest_WClientService_onAfterVersionChanged)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.docIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.flagsValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.objIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_WClientService_onAfterVersionChanged obj = (BRequest_WClientService_onAfterVersionChanged)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_WClientService_onAfterVersionChanged()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.docIdValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flagsValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objIdValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
