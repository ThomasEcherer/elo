//
// Serializer for de.elo.ix.client.NoteTemplateDataC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1775437403 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1775437403();
		
		public BSerializer_1775437403()
			: base(1775437403) {}
		
		public BSerializer_1775437403(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			NoteTemplateDataC obj = (NoteTemplateDataC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnOptKey);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnOptValue);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			NoteTemplateDataC obj = (NoteTemplateDataC)(obj1 != null ? obj1 : bin.onObjectCreated(new NoteTemplateDataC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnOptKey = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnOptValue = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
