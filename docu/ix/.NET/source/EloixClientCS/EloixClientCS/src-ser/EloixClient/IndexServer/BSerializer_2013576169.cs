//
// Serializer for de.elo.ix.client.SessionInfoParams
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2013576169 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2013576169();
		
		public BSerializer_2013576169()
			: base(2013576169) {}
		
		public BSerializer_2013576169(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SessionInfoParams obj = (SessionInfoParams)(obj1 != null ? obj1 : bin.onObjectCreated(new SessionInfoParams()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
