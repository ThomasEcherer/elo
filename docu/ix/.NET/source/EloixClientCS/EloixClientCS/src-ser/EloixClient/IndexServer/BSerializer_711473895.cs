//
// Serializer for de.elo.ix.client.ObjKeyC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_711473895 : EloixClient.IndexServer.BSerializer_2463451 {
		
		public readonly static new BSerializer instance = new BSerializer_711473895();
		
		public BSerializer_711473895()
			: base(711473895) {}
		
		public BSerializer_711473895(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ObjKeyC obj = (ObjKeyC)(obj1 != null ? obj1 : bin.onObjectCreated(new ObjKeyC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
