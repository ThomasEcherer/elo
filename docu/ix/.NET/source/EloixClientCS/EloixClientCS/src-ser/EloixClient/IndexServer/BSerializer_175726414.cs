//
// Serializer for de.elo.ix.client.ValueClass
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_175726414 : byps.BSerializer_22 {
		
		public readonly static new BSerializer instance = new BSerializer_175726414();
		
		public BSerializer_175726414()
			: base(175726414) {}
		
		public BSerializer_175726414(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ValueClass obj = (ValueClass)(obj1 != null ? obj1 : bin.onObjectCreated(new ValueClass()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
