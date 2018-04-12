//
// Serializer for de.elo.ix.client.OcrWorkerC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_45899817 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_45899817();
		
		public BSerializer_45899817()
			: base(45899817) {}
		
		public BSerializer_45899817(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			OcrWorkerC obj = (OcrWorkerC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			OcrWorkerC obj = (OcrWorkerC)(obj1 != null ? obj1 : bin.onObjectCreated(new OcrWorkerC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
