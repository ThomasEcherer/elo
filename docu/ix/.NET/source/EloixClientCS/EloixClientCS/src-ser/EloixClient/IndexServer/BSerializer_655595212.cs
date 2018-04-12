//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_configureFulltext
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_655595212 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_655595212();
		
		public BSerializer_655595212()
			: base(655595212) {}
		
		public BSerializer_655595212(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_configureFulltext obj = (BRequest_IXServicePortIF_configureFulltext)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.optsValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_configureFulltext obj = (BRequest_IXServicePortIF_configureFulltext)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_configureFulltext()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.optsValue = (EloixClient.IndexServer.FulltextConfig)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
