//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_findActivityProjects
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1955899064 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1955899064();
		
		public BSerializer_1955899064()
			: base(1955899064) {}
		
		public BSerializer_1955899064(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_findActivityProjects obj = (BRequest_IXServicePortIF_findActivityProjects)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.findInfoValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_findActivityProjects obj = (BRequest_IXServicePortIF_findActivityProjects)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_findActivityProjects()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.findInfoValue = (EloixClient.IndexServer.FindActivityProjectsInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
