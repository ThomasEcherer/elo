//
// Serializer for de.elo.ix.client.EloIxOptC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_149956656 : EloixClient.IndexServer.BSerializer_1223860309 {
		
		public readonly static new BSerializer instance = new BSerializer_149956656();
		
		public BSerializer_149956656()
			: base(149956656) {}
		
		public BSerializer_149956656(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			EloIxOptC obj = (EloIxOptC)(obj1 != null ? obj1 : bin.onObjectCreated(new EloIxOptC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
