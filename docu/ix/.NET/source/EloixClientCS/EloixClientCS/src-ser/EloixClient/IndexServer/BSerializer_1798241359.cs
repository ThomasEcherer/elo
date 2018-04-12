//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createWorkFlow
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1798241359 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1798241359();
		
		public BSerializer_1798241359()
			: base(1798241359) {}
		
		public BSerializer_1798241359(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_createWorkFlow obj = (BRequest_IXServicePortIF_createWorkFlow)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.wfNameValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.typeZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_createWorkFlow obj = (BRequest_IXServicePortIF_createWorkFlow)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_createWorkFlow()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.wfNameValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.typeZValue = (EloixClient.IndexServer.WFTypeZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
