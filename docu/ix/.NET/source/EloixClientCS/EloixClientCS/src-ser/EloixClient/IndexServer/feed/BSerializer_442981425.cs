//
// Serializer for de.elo.ix.client.feed.ActionHistoryC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_442981425 : EloixClient.IndexServer.feed.BSerializer_734763371 {
		
		public readonly static new BSerializer instance = new BSerializer_442981425();
		
		public BSerializer_442981425()
			: base(442981425) {}
		
		public BSerializer_442981425(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ActionHistoryC obj = (ActionHistoryC)(obj1 != null ? obj1 : bin.onObjectCreated(new ActionHistoryC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
