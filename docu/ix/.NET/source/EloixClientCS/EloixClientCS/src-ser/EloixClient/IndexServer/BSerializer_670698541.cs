//
// Serializer for de.elo.ix.client.ThesaurusC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_670698541 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_670698541();
		
		public BSerializer_670698541()
			: base(670698541) {}
		
		public BSerializer_670698541(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			ThesaurusC obj = (ThesaurusC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnCompare);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnData);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			ThesaurusC obj = (ThesaurusC)(obj1 != null ? obj1 : bin.onObjectCreated(new ThesaurusC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnCompare = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnData = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
