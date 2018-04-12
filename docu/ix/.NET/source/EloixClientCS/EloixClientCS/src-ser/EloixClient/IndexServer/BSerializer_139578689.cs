//
// Serializer for de.elo.ix.client.BResult_6
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_139578689 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_139578689();
		
		public BSerializer_139578689()
			: base(139578689) {}
		
		public BSerializer_139578689(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_6 obj = (BResult_6)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.resultValue);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_6 obj = (BResult_6)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_6()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = bbuf.getLong();
			
			return obj;
		}
		
	}
} // namespace
