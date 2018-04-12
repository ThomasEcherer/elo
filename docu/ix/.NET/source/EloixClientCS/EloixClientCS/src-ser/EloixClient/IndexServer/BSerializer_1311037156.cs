//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_adminMode
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1311037156 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1311037156();
		
		public BSerializer_1311037156()
			: base(1311037156) {}
		
		public BSerializer_1311037156(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_adminMode obj = (BRequest_IXServicePortIF_adminMode)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.modeValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_adminMode obj = (BRequest_IXServicePortIF_adminMode)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_adminMode()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.modeValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
