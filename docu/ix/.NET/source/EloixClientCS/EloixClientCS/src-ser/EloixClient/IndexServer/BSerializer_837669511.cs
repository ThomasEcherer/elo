//
// Serializer for de.elo.ix.client.LockC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_837669511 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_837669511();
		
		public BSerializer_837669511()
			: base(837669511) {}
		
		public BSerializer_837669511(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			LockC obj = (LockC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			LockC obj = (LockC)(obj1 != null ? obj1 : bin.onObjectCreated(new LockC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
