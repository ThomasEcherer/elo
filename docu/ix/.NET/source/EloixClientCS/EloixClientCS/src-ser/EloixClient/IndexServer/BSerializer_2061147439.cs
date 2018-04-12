//
// Serializer for de.elo.ix.client.CheckAccessOptions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2061147439 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2061147439();
		
		public BSerializer_2061147439()
			: base(2061147439) {}
		
		public BSerializer_2061147439(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			CheckAccessOptions obj = (CheckAccessOptions)(obj1 != null ? obj1 : bin.onObjectCreated(new CheckAccessOptions()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
