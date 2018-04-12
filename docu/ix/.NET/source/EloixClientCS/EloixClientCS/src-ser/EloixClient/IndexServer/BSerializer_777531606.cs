//
// Serializer for de.elo.ix.client.LoginResult
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_777531606 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_777531606();
		
		public BSerializer_777531606()
			: base(777531606) {}
		
		public BSerializer_777531606(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			LoginResult obj = (LoginResult)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.ticketLifetime);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.clientInfo, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.user, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			LoginResult obj = (LoginResult)(obj1 != null ? obj1 : bin.onObjectCreated(new LoginResult()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.ticketLifetime = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.clientInfo = (EloixClient.IndexServer.ClientInfo)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.user = (EloixClient.IndexServer.UserInfo)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
