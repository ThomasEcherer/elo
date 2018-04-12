//
// Serializer for de.elo.ix.client.QueryJobProtocolC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1764906979 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1764906979();
		
		public BSerializer_1764906979()
			: base(1764906979) {}
		
		public BSerializer_1764906979(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			QueryJobProtocolC obj = (QueryJobProtocolC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			QueryJobProtocolC obj = (QueryJobProtocolC)(obj1 != null ? obj1 : bin.onObjectCreated(new QueryJobProtocolC()));
			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
