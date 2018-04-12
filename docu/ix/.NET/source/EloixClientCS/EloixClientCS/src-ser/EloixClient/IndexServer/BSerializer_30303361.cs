//
// Serializer for de.elo.ix.client.BResult_785380175
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_30303361 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_30303361();
		
		public BSerializer_30303361()
			: base(30303361) {}
		
		public BSerializer_30303361(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_785380175 obj = (BResult_785380175)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_785380175.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_785380175 obj = (BResult_785380175)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_785380175()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.EditInfo[])bin.readObj(false, EloixClient.IndexServer.BSerializer_785380175.instance);
			
			return obj;
		}
		
	}
} // namespace
