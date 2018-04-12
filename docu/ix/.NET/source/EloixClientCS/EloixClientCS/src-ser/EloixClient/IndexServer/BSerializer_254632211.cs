//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_getImportZipUrl
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_254632211 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_254632211();
		
		public BSerializer_254632211()
			: base(254632211) {}
		
		public BSerializer_254632211(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_getImportZipUrl obj = (BRequest_IXServicePortIF_getImportZipUrl)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.importIdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_getImportZipUrl obj = (BRequest_IXServicePortIF_getImportZipUrl)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_getImportZipUrl()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.importIdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
