//
// Serializer for de.elo.ix.client.BResult_1663767661
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1136640270 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1136640270();
		
		public BSerializer_1136640270()
			: base(1136640270) {}
		
		public BSerializer_1136640270(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_1663767661 obj = (BResult_1663767661)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_1663767661 obj = (BResult_1663767661)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_1663767661()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.IndexServer.WFDiagram)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
