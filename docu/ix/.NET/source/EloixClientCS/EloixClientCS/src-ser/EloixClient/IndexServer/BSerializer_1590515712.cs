//
// Serializer for de.elo.ix.client.BResult_1556767716
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1590515712 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1590515712();
		
		public BSerializer_1590515712()
			: base(1590515712) {}
		
		public BSerializer_1590515712(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_1556767716 obj = (BResult_1556767716)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_1556767716.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_1556767716 obj = (BResult_1556767716)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_1556767716()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (Dictionary<String,EloixClient.IndexServer.feed.HashTag>)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
