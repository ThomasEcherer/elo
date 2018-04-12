//
// Serializer for de.elo.ix.client.LicenseResult
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_545905411 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_545905411();
		
		public BSerializer_545905411()
			: base(545905411) {}
		
		public BSerializer_545905411(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			LicenseResult obj = (LicenseResult)(obj1 != null ? obj1 : bin.onObjectCreated(new LicenseResult()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
