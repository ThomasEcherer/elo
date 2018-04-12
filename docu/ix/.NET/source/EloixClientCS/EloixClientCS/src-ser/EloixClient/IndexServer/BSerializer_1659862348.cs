//
// Serializer for de.elo.ix.client.WorkflowNodeInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1659862348 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1659862348();
		
		public BSerializer_1659862348()
			: base(1659862348) {}
		
		public BSerializer_1659862348(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			WorkflowNodeInfo obj = (WorkflowNodeInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.flags);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.nodeName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.workflow);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WorkflowNodeInfo obj = (WorkflowNodeInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new WorkflowNodeInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flags = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodeName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.workflow = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace
