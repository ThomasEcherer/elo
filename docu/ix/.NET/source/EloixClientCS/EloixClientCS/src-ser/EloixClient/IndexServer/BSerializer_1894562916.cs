//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_processTrees
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1894562916 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1894562916();
		
		public BSerializer_1894562916()
			: base(1894562916) {}
		
		public BSerializer_1894562916(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_processTrees obj = (BRequest_IXServicePortIF_processTrees)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.navigationInfoValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.procInfoValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_processTrees obj = (BRequest_IXServicePortIF_processTrees)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_processTrees()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.navigationInfoValue = (EloixClient.IndexServer.NavigationInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.procInfoValue = (EloixClient.IndexServer.ProcessInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
