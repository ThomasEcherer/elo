//
// Serializer for de.elo.ix.client.SordHistKeyC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_762601968 : EloixClient.IndexServer.BSerializer_1013854536 {
		
		public readonly static new BSerializer instance = new BSerializer_762601968();
		
		public BSerializer_762601968()
			: base(762601968) {}
		
		public BSerializer_762601968(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			SordHistKeyC obj = (SordHistKeyC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SordHistKeyC obj = (SordHistKeyC)(obj1 != null ? obj1 : bin.onObjectCreated(new SordHistKeyC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
