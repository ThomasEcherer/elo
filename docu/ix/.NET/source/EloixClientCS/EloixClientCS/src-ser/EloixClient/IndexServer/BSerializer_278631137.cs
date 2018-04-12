//
// Serializer for de.elo.ix.client.PhysDelC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_278631137 : EloixClient.IndexServer.BSerializer_448931954 {
		
		public readonly static new BSerializer instance = new BSerializer_278631137();
		
		public BSerializer_278631137()
			: base(278631137) {}
		
		public BSerializer_278631137(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			PhysDelC obj = (PhysDelC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			PhysDelC obj = (PhysDelC)(obj1 != null ? obj1 : bin.onObjectCreated(new PhysDelC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
