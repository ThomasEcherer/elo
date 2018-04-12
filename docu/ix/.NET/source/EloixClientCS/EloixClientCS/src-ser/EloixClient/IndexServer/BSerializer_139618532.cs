//
// Serializer for de.elo.ix.client.BRequest_IXServicePortIF_loginAdmin
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_139618532 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_139618532();
		
		public BSerializer_139618532()
			: base(139618532) {}
		
		public BSerializer_139618532(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BRequest_IXServicePortIF_loginAdmin obj = (BRequest_IXServicePortIF_loginAdmin)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.clientComputerValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.reportAsUserValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userNameValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userPwdValue);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.ciValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BRequest_IXServicePortIF_loginAdmin obj = (BRequest_IXServicePortIF_loginAdmin)(obj1 != null ? obj1 : bin.onObjectCreated(new BRequest_IXServicePortIF_loginAdmin()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.clientComputerValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.reportAsUserValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userNameValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userPwdValue = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ciValue = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
