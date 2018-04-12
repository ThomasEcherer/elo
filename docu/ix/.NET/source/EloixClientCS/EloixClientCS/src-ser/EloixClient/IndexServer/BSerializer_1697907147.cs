//
// Serializer for de.elo.ix.client.ActivityProjectC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1697907147 : EloixClient.IndexServer.BSerializer_1946995741 {
		
		public readonly static new BSerializer instance = new BSerializer_1697907147();
		
		public BSerializer_1697907147()
			: base(1697907147) {}
		
		public BSerializer_1697907147(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ActivityProjectC obj = (ActivityProjectC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ActivityProjectC obj = (ActivityProjectC)(obj1 != null ? obj1 : bin.onObjectCreated(new ActivityProjectC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
