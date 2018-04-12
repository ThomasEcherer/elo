//
// Serializer for de.elo.ix.client.OcrInfoC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1068350778 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1068350778();
		
		public BSerializer_1068350778()
			: base(1068350778) {}
		
		public BSerializer_1068350778(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			OcrInfoC obj = (OcrInfoC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			OcrInfoC obj = (OcrInfoC)(obj1 != null ? obj1 : bin.onObjectCreated(new OcrInfoC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
