﻿//
// Serializer for de.elo.ix.client.ResolveRightsInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1631708942 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1631708942();
		
		public BSerializer_1631708942()
			: base(1631708942) {}
		
		public BSerializer_1631708942(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ResolveRightsInfo obj = (ResolveRightsInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new ResolveRightsInfo()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
