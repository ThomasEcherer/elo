//
// Serializer for de.elo.ix.client.UrlParams
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2007960901 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2007960901();
		
		public BSerializer_2007960901()
			: base(2007960901) {}
		
		public BSerializer_2007960901(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			UrlParams obj = (UrlParams)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.highlightTerms);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.length);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.offset);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			UrlParams obj = (UrlParams)(obj1 != null ? obj1 : bin.onObjectCreated(new UrlParams()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.highlightTerms = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.length = bbuf.getLong();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.offset = bbuf.getLong();
			
			return obj;
		}
		
	}
} // namespace
