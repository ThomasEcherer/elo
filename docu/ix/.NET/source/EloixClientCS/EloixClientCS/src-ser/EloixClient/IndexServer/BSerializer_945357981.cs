//
// Serializer for de.elo.ix.client.BResult_341056676
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_945357981 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_945357981();
		
		public BSerializer_945357981()
			: base(945357981) {}
		
		public BSerializer_945357981(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_341056676 obj = (BResult_341056676)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_341056676 obj = (BResult_341056676)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_341056676()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.Document)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
