//
// Serializer for de.elo.ix.client.NoteTemplateC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_240897408 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_240897408();
		
		public BSerializer_240897408()
			: base(240897408) {}
		
		public BSerializer_240897408(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			NoteTemplateC obj = (NoteTemplateC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnText);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			NoteTemplateC obj = (NoteTemplateC)(obj1 != null ? obj1 : bin.onObjectCreated(new NoteTemplateC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnName = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnText = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
