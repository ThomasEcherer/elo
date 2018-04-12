//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_startImport
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1318178737 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1318178737();
		
		public BSerializer_1318178737()
			: base(1318178737) {}
		
		public BSerializer_1318178737(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_startImport obj = (BRequest_IXServicePortIF_startImport)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.filingPathValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.guidMethodValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.optionsValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_startImport obj = (BRequest_IXServicePortIF_startImport)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_startImport()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.filingPathValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.guidMethodValue = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.optionsValue = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
