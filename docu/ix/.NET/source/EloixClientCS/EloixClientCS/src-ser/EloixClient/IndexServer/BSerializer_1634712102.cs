//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_deleteWorkflowTemplate
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1634712102 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1634712102();
		
		public BSerializer_1634712102()
			: base(1634712102) {}
		
		public BSerializer_1634712102(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_deleteWorkflowTemplate obj = (BRequest_IXServicePortIF_deleteWorkflowTemplate)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.flowIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.versionIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.unlockZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_deleteWorkflowTemplate obj = (BRequest_IXServicePortIF_deleteWorkflowTemplate)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_deleteWorkflowTemplate()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flowIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.versionIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.unlockZValue = (EloixClient.IndexServer.LockZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
