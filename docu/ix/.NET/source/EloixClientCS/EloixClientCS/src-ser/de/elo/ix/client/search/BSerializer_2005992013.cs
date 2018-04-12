//
// Serializer for de.elo.ix.client.search.LanguageConfig
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace de.elo.ix.client.search
{
	
	public class BSerializer_2005992013 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_2005992013();
		
		public BSerializer_2005992013()
			: base(2005992013) {}
		
		public BSerializer_2005992013(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			LanguageConfig obj = (LanguageConfig)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.allowedLangs);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.languages);
			if (version >= 1000000020000021L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.archiveLang);
				if (version >= 1000000020000022L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putInt(obj.nbOfLangs);
				}
			}
			if (version >= 1000170010000003L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.mapLanguageNames, false, EloixClient.IndexServer.BSerializer_1710660846.instance);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			LanguageConfig obj = (LanguageConfig)(obj1 != null ? obj1 : bin.onObjectCreated(new LanguageConfig()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.allowedLangs = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.languages = bbuf.getString();
			if (version >= 1000000020000021L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.archiveLang = bbuf.getString();
				if (version >= 1000000020000022L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.nbOfLangs = bbuf.getInt();
				}
			}
			if (version >= 1000170010000003L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.mapLanguageNames = (IDictionary<String,String>)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace
