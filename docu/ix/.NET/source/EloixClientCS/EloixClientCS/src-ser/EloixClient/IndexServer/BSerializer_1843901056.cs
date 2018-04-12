//
// Serializer for de.elo.ix.client.CounterInfoC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1843901056 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1843901056();
		
		public BSerializer_1843901056()
			: base(1843901056) {}
		
		public BSerializer_1843901056(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			CounterInfoC obj = (CounterInfoC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			CounterInfoC obj = (CounterInfoC)(obj1 != null ? obj1 : bin.onObjectCreated(new CounterInfoC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
