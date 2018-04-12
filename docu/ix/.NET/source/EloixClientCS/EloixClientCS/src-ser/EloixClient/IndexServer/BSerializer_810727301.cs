//
// Serializer for de.elo.ix.client.NotifyServerResult
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_810727301 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_810727301();
		
		public BSerializer_810727301()
			: base(810727301) {}
		
		public BSerializer_810727301(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			NotifyServerResult obj = (NotifyServerResult)(obj1 != null ? obj1 : bin.onObjectCreated(new NotifyServerResult()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
