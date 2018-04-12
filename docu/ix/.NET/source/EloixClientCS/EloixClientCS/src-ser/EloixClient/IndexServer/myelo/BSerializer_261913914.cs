//
// Serializer for de.elo.ix.client.myelo.BRequest_MyELOService_readContent
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.myelo
{
	
	public class BSerializer_261913914 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_261913914();
		
		public BSerializer_261913914()
			: base(261913914) {}
		
		public BSerializer_261913914(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_MyELOService_readContent obj = (BRequest_MyELOService_readContent)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.infoValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.stateValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_MyELOService_readContent obj = (BRequest_MyELOService_readContent)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_MyELOService_readContent()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.infoValue = (EloixClient.IndexServer.myelo.MyELOInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.stateValue = (EloixClient.IndexServer.myelo.MyELOState)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
