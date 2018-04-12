//
// Serializer for de.elo.ix.client.SordHistC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_520610723 : EloixClient.IndexServer.BSerializer_1015803641 {
		
		public readonly static new BSerializer instance = new BSerializer_520610723();
		
		public BSerializer_520610723()
			: base(520610723) {}
		
		public BSerializer_520610723(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			SordHistC obj = (SordHistC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SordHistC obj = (SordHistC)(obj1 != null ? obj1 : bin.onObjectCreated(new SordHistC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
