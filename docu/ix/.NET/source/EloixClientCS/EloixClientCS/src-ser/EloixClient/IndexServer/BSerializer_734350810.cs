//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_createDoc
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_734350810 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_734350810();
		
		public BSerializer_734350810()
			: base(734350810) {}
		
		public BSerializer_734350810(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_createDoc obj = (BRequest_IXServicePortIF_createDoc)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.docTemplateValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.maskIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.parentIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.editInfoZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_createDoc obj = (BRequest_IXServicePortIF_createDoc)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_createDoc()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.docTemplateValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.maskIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.parentIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.editInfoZValue = (EloixClient.IndexServer.EditInfoZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
