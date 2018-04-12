//
// Serializer for de.elo.ix.client.FindByFulltextResultItem
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_709720021 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_709720021();
		
		public BSerializer_709720021()
			: base(709720021) {}
		
		public BSerializer_709720021(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			FindByFulltextResultItem obj = (FindByFulltextResultItem)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.relevance);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.summaryDesc);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.summaryFulltext);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.fieldNames, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.sord, false, null);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindByFulltextResultItem obj = (FindByFulltextResultItem)(obj1 != null ? obj1 : bin.onObjectCreated(new FindByFulltextResultItem()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.relevance = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.summaryDesc = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.summaryFulltext = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.fieldNames = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.sord = (EloixClient.IndexServer.Sord)bin.readObj(false, null);
			
			return obj;
		}
		
	}
} // namespace
