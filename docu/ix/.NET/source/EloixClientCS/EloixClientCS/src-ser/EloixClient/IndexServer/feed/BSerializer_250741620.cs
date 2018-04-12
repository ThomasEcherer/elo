//
// Serializer for de.elo.ix.client.feed.HashTagC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_250741620 : EloixClient.IndexServer.feed.BSerializer_513648569 {
		
		public readonly static new BSerializer instance = new BSerializer_250741620();
		
		public BSerializer_250741620()
			: base(250741620) {}
		
		public BSerializer_250741620(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			HashTagC obj = (HashTagC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			HashTagC obj = (HashTagC)(obj1 != null ? obj1 : bin.onObjectCreated(new HashTagC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
