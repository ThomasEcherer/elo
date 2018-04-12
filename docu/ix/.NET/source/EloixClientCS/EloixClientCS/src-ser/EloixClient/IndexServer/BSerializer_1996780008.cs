//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_importWorkFlow2
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1996780008 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1996780008();
		
		public BSerializer_1996780008()
			: base(1996780008) {}
		
		public BSerializer_1996780008(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_importWorkFlow2 obj = (BRequest_IXServicePortIF_importWorkFlow2)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.flowNameValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.fileDataValue, false, EloixClient.IndexServer.BSerializer_1374008726.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.importOptionsValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_importWorkFlow2 obj = (BRequest_IXServicePortIF_importWorkFlow2)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_importWorkFlow2()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flowNameValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fileDataValue = (byte[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1374008726.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.importOptionsValue = (EloixClient.IndexServer.WorkflowImportOptions)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
