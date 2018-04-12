//
// Serializer for de.elo.ix.client.BResult_884364631
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1628589312 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1628589312();
		
		public BSerializer_1628589312()
			: base(1628589312) {}
		
		public BSerializer_1628589312(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_884364631 obj = (BResult_884364631)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_884364631.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_884364631 obj = (BResult_884364631)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_884364631()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.ReplSetName[])bin.readObj(false, EloixClient.IndexServer.BSerializer_884364631.instance);
			
			return obj;
		}
		
	}
} // namespace
