//
// Serializer for de.elo.ix.client.FindDirect
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1028007046 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1028007046();
		
		public BSerializer_1028007046()
			: base(1028007046) {}
		
		public BSerializer_1028007046(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			FindDirect obj = (FindDirect)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.query);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.searchInFulltext);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.searchInIndex);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.searchInMemo);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.searchInNotes);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.searchInSordName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.searchInVersions);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindDirect obj = (FindDirect)(obj1 != null ? obj1 : bin.onObjectCreated(new FindDirect()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.query = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.searchInFulltext = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.searchInIndex = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.searchInMemo = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.searchInNotes = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.searchInSordName = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.searchInVersions = bbuf.getBoolean();
			
			return obj;
		}
		
	}
} // namespace
