//
// Serializer for de.elo.ix.client.CheckinOrgUnitInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_740959052 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_740959052();
		
		public BSerializer_740959052()
			: base(740959052) {}
		
		public BSerializer_740959052(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			CheckinOrgUnitInfo obj = (CheckinOrgUnitInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new CheckinOrgUnitInfo()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
