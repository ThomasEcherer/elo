//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_finishExport
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1487849891 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1487849891();
		
		public BSerializer_1487849891()
			: base(1487849891) {}
		
		public BSerializer_1487849891(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_finishExport obj = (BRequest_IXServicePortIF_finishExport)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.exportIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_finishExport obj = (BRequest_IXServicePortIF_finishExport)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_finishExport()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.exportIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
