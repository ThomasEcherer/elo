//
// Serializer for de.elo.ix.client.ProcessReleaseLock
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1270934212 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1270934212();
		
		public BSerializer_1270934212()
			: base(1270934212) {}
		
		public BSerializer_1270934212(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ProcessReleaseLock obj = (ProcessReleaseLock)(obj1 != null ? obj1 : bin.onObjectCreated(new ProcessReleaseLock()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
