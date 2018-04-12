//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_copySord
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1944880601 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1944880601();
		
		public BSerializer_1944880601()
			: base(1944880601) {}
		
		public BSerializer_1944880601(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_copySord obj = (BRequest_IXServicePortIF_copySord)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.newParentIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.objIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.copyInfoValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.copySordZValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_copySord obj = (BRequest_IXServicePortIF_copySord)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_copySord()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.newParentIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.objIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.copyInfoValue = (EloixClient.IndexServer.CopyInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.copySordZValue = (EloixClient.IndexServer.CopySordZ)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
