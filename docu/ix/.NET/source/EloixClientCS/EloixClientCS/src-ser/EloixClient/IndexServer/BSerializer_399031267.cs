//
// Serializer for de.elo.ix.client.EloIxOpt_old
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_399031267 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_399031267();
		
		public BSerializer_399031267()
			: base(399031267) {}
		
		public BSerializer_399031267(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			EloIxOpt_old obj = (EloIxOpt_old)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.optNo);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.optVal);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.remark);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			EloIxOpt_old obj = (EloIxOpt_old)(obj1 != null ? obj1 : bin.onObjectCreated(new EloIxOpt_old()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.optNo = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.optVal = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.remark = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace
