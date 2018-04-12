//
// Serializer for de.elo.ix.client.FulltextConfig
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_239574905 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_239574905();
		
		public BSerializer_239574905()
			: base(239574905) {}
		
		public BSerializer_239574905(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			FulltextConfig obj = (FulltextConfig)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.flags);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.knowlegeMapUrl);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.source);
			if (version >= 900990009000010L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.indexerConfig, false, null);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FulltextConfig obj = (FulltextConfig)(obj1 != null ? obj1 : bin.onObjectCreated(new FulltextConfig()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.flags = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.knowlegeMapUrl = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.source = bbuf.getInt();
			if (version >= 900990009000010L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.indexerConfig = (de.elo.ix.client.search.SearchIndexerConfig)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace
