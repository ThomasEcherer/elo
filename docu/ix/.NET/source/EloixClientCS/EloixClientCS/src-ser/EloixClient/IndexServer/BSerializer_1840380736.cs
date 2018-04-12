//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_encryptStringRsa
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1840380736 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1840380736();
		
		public BSerializer_1840380736()
			: base(1840380736) {}
		
		public BSerializer_1840380736(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_encryptStringRsa obj = (BRequest_IXServicePortIF_encryptStringRsa)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.dataValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.encryptNotDecryptValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.keyValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_encryptStringRsa obj = (BRequest_IXServicePortIF_encryptStringRsa)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_encryptStringRsa()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.dataValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.encryptNotDecryptValue = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.keyValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
