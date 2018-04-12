//
// Serializer for de.elo.ix.client.feed.HashTagRelationDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer.feed
{
	
	public class BSerializer_2035445347 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_2035445347();
		
		public BSerializer_2035445347()
			: base(2035445347) {}
		
		public BSerializer_2035445347(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			HashTagRelationDataC obj = (HashTagRelationDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnActionGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnHashtagGuid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnTStamp);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			HashTagRelationDataC obj = (HashTagRelationDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new HashTagRelationDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnActionGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnHashtagGuid = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnTStamp = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
