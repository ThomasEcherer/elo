//
// Serializer for de.elo.ix.client.PreviewImageInfoC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_407268655 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_407268655();
		
		public BSerializer_407268655()
			: base(407268655) {}
		
		public BSerializer_407268655(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			PreviewImageInfoC obj = (PreviewImageInfoC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			PreviewImageInfoC obj = (PreviewImageInfoC)(obj1 != null ? obj1 : bin.onObjectCreated(new PreviewImageInfoC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
