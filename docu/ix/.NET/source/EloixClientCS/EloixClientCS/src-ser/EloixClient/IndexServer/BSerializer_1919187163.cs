//
// Serializer for de.elo.ix.client.PublicDownloadC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1919187163 : EloixClient.IndexServer.BSerializer_1639180602 {
		
		public readonly static new BSerializer instance = new BSerializer_1919187163();
		
		public BSerializer_1919187163()
			: base(1919187163) {}
		
		public BSerializer_1919187163(int typeId)
			: base(typeId) {}
		
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			PublicDownloadC obj = (PublicDownloadC)(obj1 != null ? obj1 : bin.onObjectCreated(new PublicDownloadC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
