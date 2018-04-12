//
// Serializer for de.elo.ix.client.CheckoutOrgUnitInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_948431844 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_948431844();
		
		public BSerializer_948431844()
			: base(948431844) {}
		
		public BSerializer_948431844(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			CheckoutOrgUnitInfo obj = (CheckoutOrgUnitInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new CheckoutOrgUnitInfo()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
