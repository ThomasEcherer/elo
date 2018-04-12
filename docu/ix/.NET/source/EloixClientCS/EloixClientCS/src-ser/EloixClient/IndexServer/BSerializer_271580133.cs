//
// Serializer for de.elo.ix.client.BResult_206201524
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_271580133 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_271580133();
		
		public BSerializer_271580133()
			: base(271580133) {}
		
		public BSerializer_271580133(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_206201524 obj = (BResult_206201524)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_206201524.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_206201524 obj = (BResult_206201524)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_206201524()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.Keyword[])bin.readObj(false, EloixClient.IndexServer.BSerializer_206201524.instance);
			
			return obj;
		}
		
	}
} // namespace
