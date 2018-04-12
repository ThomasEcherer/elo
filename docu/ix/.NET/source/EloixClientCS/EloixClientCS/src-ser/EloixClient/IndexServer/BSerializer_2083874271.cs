//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_lockArchive
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2083874271 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_2083874271();
		
		public BSerializer_2083874271()
			: base(2083874271) {}
		
		public BSerializer_2083874271(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_lockArchive obj = (BRequest_IXServicePortIF_lockArchive)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.keyIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_lockArchive obj = (BRequest_IXServicePortIF_lockArchive)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_lockArchive()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.keyIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
