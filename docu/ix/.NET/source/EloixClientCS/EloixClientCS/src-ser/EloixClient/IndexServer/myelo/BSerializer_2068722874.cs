//
// Serializer for de.elo.ix.client.myelo.BRequest_MyELOService_checkState
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.myelo
{
	
	public class BSerializer_2068722874 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_2068722874();
		
		public BSerializer_2068722874()
			: base(2068722874) {}
		
		public BSerializer_2068722874(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_MyELOService_checkState obj = (BRequest_MyELOService_checkState)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.sinceDateIsoValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userGuidOrIDValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_MyELOService_checkState obj = (BRequest_MyELOService_checkState)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_MyELOService_checkState()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sinceDateIsoValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userGuidOrIDValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
