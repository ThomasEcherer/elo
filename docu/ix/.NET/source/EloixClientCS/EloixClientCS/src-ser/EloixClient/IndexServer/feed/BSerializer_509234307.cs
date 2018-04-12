//
// Serializer for de.elo.ix.client.feed.HashTagRelationZ
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_509234307 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_509234307();
		
		public BSerializer_509234307()
			: base(509234307) {}
		
		public BSerializer_509234307(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			HashTagRelationZ obj = (HashTagRelationZ)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putLong(obj.bset);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			HashTagRelationZ obj = (HashTagRelationZ)(obj1 != null ? obj1 : bin.onObjectCreated(new HashTagRelationZ()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.bset = bbuf.getLong();
			
			return obj;
		}
		
	}
} // namespace
