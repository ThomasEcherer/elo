//
// Serializer for de.elo.ix.client.BResult_2062827124
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_59064871 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_59064871();
		
		public BSerializer_59064871()
			: base(59064871) {}
		
		public BSerializer_59064871(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_2062827124 obj = (BResult_2062827124)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_2062827124 obj = (BResult_2062827124)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_2062827124()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.PublicDownload)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
