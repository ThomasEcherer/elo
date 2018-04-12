//
// Serializer for de.elo.ix.client.FindByNotes
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_735083434 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_735083434();
		
		public BSerializer_735083434()
			: base(735083434) {}
		
		public BSerializer_735083434(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FindByNotes obj = (FindByNotes)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.term);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.type);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindByNotes obj = (FindByNotes)(obj1 != null ? obj1 : bin.onObjectCreated(new FindByNotes()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.term = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.type = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
