//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_queryJobState
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_221322822 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_221322822();
		
		public BSerializer_221322822()
			: base(221322822) {}
		
		public BSerializer_221322822(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_queryJobState obj = (BRequest_IXServicePortIF_queryJobState)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.activeJobsValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.finishedJobsValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.fullInfoValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.jobGuidValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_queryJobState obj = (BRequest_IXServicePortIF_queryJobState)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_queryJobState()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.activeJobsValue = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.finishedJobsValue = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fullInfoValue = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.jobGuidValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
