//
// Serializer for de.elo.ix.client.feed.HashTagRelation
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_1313473584 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1313473584();
		
		public BSerializer_1313473584()
			: base(1313473584) {}
		
		public BSerializer_1313473584(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			HashTagRelation obj = (HashTagRelation)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.actionGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.hashtagGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.status);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.tStamp);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			HashTagRelation obj = (HashTagRelation)(obj1 != null ? obj1 : bin.onObjectCreated(new HashTagRelation()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.actionGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.hashtagGuid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.status = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tStamp = bbuf.getString();
			
			return obj;
		}
		
	}
} // namespace
