//
// Serializer for de.elo.ix.client.NotificationC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1070921523 : EloixClient.IndexServer.BSerializer_2010056196 {
		
		public readonly static new BSerializer instance = new BSerializer_1070921523();
		
		public BSerializer_1070921523()
			: base(1070921523) {}
		
		public BSerializer_1070921523(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			NotificationC obj = (NotificationC)(obj1 != null ? obj1 : bin.onObjectCreated(new NotificationC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
