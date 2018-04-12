//
// Serializer for de.elo.ix.client.ClientInfoC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_847449421 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_847449421();
		
		public BSerializer_847449421()
			: base(847449421) {}
		
		public BSerializer_847449421(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ClientInfoC obj = (ClientInfoC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ClientInfoC obj = (ClientInfoC)(obj1 != null ? obj1 : bin.onObjectCreated(new ClientInfoC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
