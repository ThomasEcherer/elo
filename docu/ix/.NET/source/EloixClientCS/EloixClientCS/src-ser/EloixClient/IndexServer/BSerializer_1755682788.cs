//
// Serializer for de.elo.ix.client.FindByFulltextCtrlResultItem
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1755682788 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1755682788();
		
		public BSerializer_1755682788()
			: base(1755682788) {}
		
		public BSerializer_1755682788(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			FindByFulltextCtrlResultItem obj = (FindByFulltextCtrlResultItem)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.TStamp);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sord, false, null);
			if (version >= 800000000000003L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.note, false, null);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindByFulltextCtrlResultItem obj = (FindByFulltextCtrlResultItem)(obj1 != null ? obj1 : bin.onObjectCreated(new FindByFulltextCtrlResultItem()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.TStamp = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sord = (EloixClient.IndexServer.Sord)bin.readObj(false, null);
			if (version >= 800000000000003L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.note = (EloixClient.IndexServer.Note)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace
