//
// Serializer for de.elo.ix.client.ValuesOfObjKeyOptions
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_958310068 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_958310068();
		
		public BSerializer_958310068()
			: base(958310068) {}
		
		public BSerializer_958310068(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ValuesOfObjKeyOptions obj = (ValuesOfObjKeyOptions)(obj1 != null ? obj1 : bin.onObjectCreated(new ValuesOfObjKeyOptions()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
