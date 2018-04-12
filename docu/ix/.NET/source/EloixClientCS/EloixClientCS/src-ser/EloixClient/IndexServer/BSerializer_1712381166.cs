//
// Serializer for de.elo.ix.client.InvalidateCacheResult
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1712381166 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1712381166();
		
		public BSerializer_1712381166()
			: base(1712381166) {}
		
		public BSerializer_1712381166(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			InvalidateCacheResult obj = (InvalidateCacheResult)(obj1 != null ? obj1 : bin.onObjectCreated(new InvalidateCacheResult()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
