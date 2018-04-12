//
// Serializer for de.elo.ix.client.BResult_133130047
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_324094143 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_324094143();
		
		public BSerializer_324094143()
			: base(324094143) {}
		
		public BSerializer_324094143(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_133130047 obj = (BResult_133130047)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_133130047.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_133130047 obj = (BResult_133130047)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_133130047()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.SordType[])bin.readObj(false, EloixClient.IndexServer.BSerializer_133130047.instance);
			
			return obj;
		}
		
	}
} // namespace
