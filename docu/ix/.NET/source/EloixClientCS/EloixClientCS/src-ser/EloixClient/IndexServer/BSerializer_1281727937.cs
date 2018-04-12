//
// Serializer for de.elo.ix.client.BResult_910482075
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1281727937 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1281727937();
		
		public BSerializer_1281727937()
			: base(1281727937) {}
		
		public BSerializer_1281727937(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_910482075 obj = (BResult_910482075)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, EloixClient.IndexServer.BSerializer_910482075.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_910482075 obj = (BResult_910482075)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_910482075()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.Event[])bin.readObj(false, EloixClient.IndexServer.BSerializer_910482075.instance);
			
			return obj;
		}
		
	}
} // namespace
