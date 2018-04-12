//
// Serializer for de.elo.ix.client.feed.ActionC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_1988394652 : EloixClient.IndexServer.feed.BSerializer_423487901 {
		
		public readonly static new BSerializer instance = new BSerializer_1988394652();
		
		public BSerializer_1988394652()
			: base(1988394652) {}
		
		public BSerializer_1988394652(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			ActionC obj = (ActionC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ActionC obj = (ActionC)(obj1 != null ? obj1 : bin.onObjectCreated(new ActionC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
