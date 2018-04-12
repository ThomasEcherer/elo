//
// Serializer for de.elo.ix.client.search.SearchIndexerConfig
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace de.elo.ix.client.search
{
	
	public class BSerializer_1425319615 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1425319615();
		
		public BSerializer_1425319615()
			: base(1425319615) {}
		
		public BSerializer_1425319615(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			SearchIndexerConfig obj = (SearchIndexerConfig)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.optimizerConfig, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.reindexerConfig, false, null);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.updaterConfig, false, null);
			if (version >= 1000000000000005L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.languageConfig, false, null);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			SearchIndexerConfig obj = (SearchIndexerConfig)(obj1 != null ? obj1 : bin.onObjectCreated(new SearchIndexerConfig()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.optimizerConfig = (de.elo.ix.client.search.OptimizerConfig)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.reindexerConfig = (de.elo.ix.client.search.ReindexerConfig)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.updaterConfig = (de.elo.ix.client.search.UpdaterConfig)bin.readObj(false, null);
			if (version >= 1000000000000005L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.languageConfig = (de.elo.ix.client.search.LanguageConfig)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace
