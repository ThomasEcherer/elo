//
// Serializer for de.elo.ix.client.BResult_2015686193
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1749255216 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1749255216();
		
		public BSerializer_1749255216()
			: base(1749255216) {}
		
		public BSerializer_1749255216(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_2015686193 obj = (BResult_2015686193)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_2015686193 obj = (BResult_2015686193)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_2015686193()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.WFNode)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
