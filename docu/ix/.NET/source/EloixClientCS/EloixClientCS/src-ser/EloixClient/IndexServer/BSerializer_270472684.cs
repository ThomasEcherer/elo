//
// Serializer for de.elo.ix.client.BResult_276702696
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_270472684 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_270472684();
		
		public BSerializer_270472684()
			: base(270472684) {}
		
		public BSerializer_270472684(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			BResult_276702696 obj = (BResult_276702696)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.resultValue, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			BResult_276702696 obj = (BResult_276702696)(obj1 != null ? obj1 : bin.onObjectCreated(new BResult_276702696()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.resultValue = (EloixClient.Indexserver.system.SystemReport)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
