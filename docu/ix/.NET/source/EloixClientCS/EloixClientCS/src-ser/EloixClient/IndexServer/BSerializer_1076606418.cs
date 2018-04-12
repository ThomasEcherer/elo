//
// Serializer for de.elo.ix.client.ServerState
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1076606418 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1076606418();
		
		public BSerializer_1076606418()
			: base(1076606418) {}
		
		public BSerializer_1076606418(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ServerState obj = (ServerState)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.action);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.actionId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.subKey);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ServerState obj = (ServerState)(obj1 != null ? obj1 : bin.onObjectCreated(new ServerState()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.action = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.actionId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.subKey = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
