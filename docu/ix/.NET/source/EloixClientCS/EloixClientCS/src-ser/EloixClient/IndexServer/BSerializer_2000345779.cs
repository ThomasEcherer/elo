//
// Serializer for de.elo.ix.client.SessionOptionsC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2000345779 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_2000345779();
		
		public BSerializer_2000345779()
			: base(2000345779) {}
		
		public BSerializer_2000345779(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			SessionOptionsC obj = (SessionOptionsC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SessionOptionsC obj = (SessionOptionsC)(obj1 != null ? obj1 : bin.onObjectCreated(new SessionOptionsC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
