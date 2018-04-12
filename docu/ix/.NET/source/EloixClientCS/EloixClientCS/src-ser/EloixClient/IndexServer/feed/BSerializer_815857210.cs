//
// Serializer for de.elo.ix.client.feed.FindActionsInfoC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_815857210 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_815857210();
		
		public BSerializer_815857210()
			: base(815857210) {}
		
		public BSerializer_815857210(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindActionsInfoC obj = (FindActionsInfoC)(obj1 != null ? obj1 : bin.onObjectCreated(new FindActionsInfoC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
