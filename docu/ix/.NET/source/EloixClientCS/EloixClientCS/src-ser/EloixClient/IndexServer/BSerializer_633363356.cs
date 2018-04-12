//
// Serializer for de.elo.ix.client.WFTimeLimit
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_633363356 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_633363356();
		
		public BSerializer_633363356()
			: base(633363356) {}
		
		public BSerializer_633363356(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			WFTimeLimit obj = (WFTimeLimit)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.timeLimit);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.timeLimitIso);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.userId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.userName);
			if (version >= 700000000000017L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.overTimeLimit);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WFTimeLimit obj = (WFTimeLimit)(obj1 != null ? obj1 : bin.onObjectCreated(new WFTimeLimit()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.timeLimit = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.timeLimitIso = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userId = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.userName = bbuf.getString();
			if (version >= 700000000000017L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.overTimeLimit = bbuf.getBoolean();
			}
			
			return obj;
		}
		
	}
} // namespace
