//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_collectJobStates
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1479025845 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1479025845();
		
		public BSerializer_1479025845()
			: base(1479025845) {}
		
		public BSerializer_1479025845(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_collectJobStates obj = (BRequest_IXServicePortIF_collectJobStates)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.activeJobsValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.finishedJobsValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.fullInfoValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_collectJobStates obj = (BRequest_IXServicePortIF_collectJobStates)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_collectJobStates()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.activeJobsValue = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.finishedJobsValue = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fullInfoValue = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
