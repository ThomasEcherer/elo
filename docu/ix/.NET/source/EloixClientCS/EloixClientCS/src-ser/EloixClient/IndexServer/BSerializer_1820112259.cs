//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_linkSords2
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1820112259 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1820112259();
		
		public BSerializer_1820112259()
			: base(1820112259) {}
		
		public BSerializer_1820112259(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_linkSords2 obj = (BRequest_IXServicePortIF_linkSords2)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.fromIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.linkSordInfoValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.linkSordZValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.toIdsValue, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_linkSords2 obj = (BRequest_IXServicePortIF_linkSords2)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_linkSords2()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fromIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.linkSordInfoValue = (EloixClient.IndexServer.LinkSordInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.linkSordZValue = (EloixClient.IndexServer.LinkSordZ)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.toIdsValue = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			
			return obj;
		}
		
	}
} // namespace
