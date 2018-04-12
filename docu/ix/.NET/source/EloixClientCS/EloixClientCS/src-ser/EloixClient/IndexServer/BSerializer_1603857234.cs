//
// Serializer for de.elo.ix.client.EloFtOptC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1603857234 : EloixClient.IndexServer.BSerializer_1220982870 {
		
		public readonly static new BSerializer instance = new BSerializer_1603857234();
		
		public BSerializer_1603857234()
			: base(1603857234) {}
		
		public BSerializer_1603857234(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			EloFtOptC obj = (EloFtOptC)(obj1 != null ? obj1 : bin.onObjectCreated(new EloFtOptC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
