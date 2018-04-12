//
// Serializer for de.elo.ix.client.feed.HashTagRelationC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_747134350 : EloixClient.IndexServer.feed.BSerializer_2035445347 {
		
		public readonly static new BSerializer instance = new BSerializer_747134350();
		
		public BSerializer_747134350()
			: base(747134350) {}
		
		public BSerializer_747134350(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			HashTagRelationC obj = (HashTagRelationC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			HashTagRelationC obj = (HashTagRelationC)(obj1 != null ? obj1 : bin.onObjectCreated(new HashTagRelationC()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			
			return obj;
		}
		
	}
} // namespace
