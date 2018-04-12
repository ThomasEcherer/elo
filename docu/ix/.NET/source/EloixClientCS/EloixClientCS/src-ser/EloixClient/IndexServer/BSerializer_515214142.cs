//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_provideCryptPassword
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_515214142 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_515214142();
		
		public BSerializer_515214142()
			: base(515214142) {}
		
		public BSerializer_515214142(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_provideCryptPassword obj = (BRequest_IXServicePortIF_provideCryptPassword)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.encryptionSetValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.pwdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_provideCryptPassword obj = (BRequest_IXServicePortIF_provideCryptPassword)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_provideCryptPassword()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.encryptionSetValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.pwdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
