//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getWorkflowTemplateVersions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_775523732 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_775523732();
		
		public BSerializer_775523732()
			: base(775523732) {}
		
		public BSerializer_775523732(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_getWorkflowTemplateVersions obj = (BRequest_IXServicePortIF_getWorkflowTemplateVersions)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.flowIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.onlyDeletedValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_getWorkflowTemplateVersions obj = (BRequest_IXServicePortIF_getWorkflowTemplateVersions)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_getWorkflowTemplateVersions()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flowIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.onlyDeletedValue = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
