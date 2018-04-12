//
// Serializer for de.elo.ix.client.KeywordsDynamicResult
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1552114559 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_1552114559();
		
		public BSerializer_1552114559()
			: base(1552114559) {}
		
		public BSerializer_1552114559(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			KeywordsDynamicResult obj = (KeywordsDynamicResult)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.message);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.moreResults);
			if (version >= 900000000000010L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.title);
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.header, false, EloixClient.IndexServer.BSerializer_2123584667.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.keyNames, false, EloixClient.IndexServer.BSerializer_2123584667.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.table, false, EloixClient.IndexServer.BSerializer_1489667803.instance);
			if (version >= 900000016000018L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bout.writeObj(obj.columnProperties, false, EloixClient.IndexServer.BSerializer_1319324274.instance);
			}
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			KeywordsDynamicResult obj = (KeywordsDynamicResult)(obj1 != null ? obj1 : bin.onObjectCreated(new KeywordsDynamicResult()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.message = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.moreResults = bbuf.getBoolean();
			if (version >= 900000000000010L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.title = bbuf.getString();
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.header = (IList<String>)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.keyNames = (IList<String>)bin.readObj(false, null);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.table = (IList<IList<String>>)bin.readObj(false, null);
			if (version >= 900000016000018L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.columnProperties = (IList<IDictionary<String,String>>)bin.readObj(false, null);
			}
			
			return obj;
		}
		
	}
} // namespace
