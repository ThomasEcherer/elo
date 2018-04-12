//
// Serializer for de.elo.ix.client.MoveDocumentsInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_2016315141 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2016315141();
		
		public BSerializer_2016315141()
			: base(2016315141) {}
		
		public BSerializer_2016315141(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			MoveDocumentsInfo obj = (MoveDocumentsInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.sourcePathId);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.targetPathId);
			if (version >= 1000170059000005L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.endDate);
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.startDate);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			MoveDocumentsInfo obj = (MoveDocumentsInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new MoveDocumentsInfo()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sourcePathId = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.targetPathId = bbuf.getString();
			if (version >= 1000170059000005L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.endDate = bbuf.getString();
				// checkpoint byps.gen.cs.PrintContext:449
				obj.startDate = bbuf.getString();
			}
			
			return obj;
		}
		
	}
} // namespace
