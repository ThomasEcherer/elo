//
// Serializer for de.elo.ix.client.BResult_1535847981
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1539142900 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1539142900();
		
		public BSerializer_1539142900()
			: base(1539142900) {}
		
		public BSerializer_1539142900(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_1535847981 obj = (BResult_1535847981)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_1535847981.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_1535847981 obj = (BResult_1535847981)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_1535847981()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (HashSet<EloixClient.IndexServer.feed.HashTag>)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
