//
// Serializer for de.elo.ix.client.WFNodeAssoc
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1042649178 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1042649178();
		
		public BSerializer_1042649178()
			: base(1042649178) {}
		
		public BSerializer_1042649178(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			WFNodeAssoc obj = (WFNodeAssoc)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.done);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nodeFrom);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.nodeTo);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.type);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			WFNodeAssoc obj = (WFNodeAssoc)(obj1 != null ? obj1 : bin.onObjectCreated(new WFNodeAssoc()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.done = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodeFrom = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.nodeTo = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.type = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
