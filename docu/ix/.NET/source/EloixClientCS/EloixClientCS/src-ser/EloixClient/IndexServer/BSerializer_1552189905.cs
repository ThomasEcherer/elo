//
// Serializer for de.elo.ix.client.HttpResponseInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1552189905 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1552189905();
		
		public BSerializer_1552189905()
			: base(1552189905) {}
		
		public BSerializer_1552189905(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			HttpResponseInfo obj = (HttpResponseInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.contentType);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.responseString);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			HttpResponseInfo obj = (HttpResponseInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new HttpResponseInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.contentType = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.responseString = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace
