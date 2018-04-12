//
// Serializer for de.elo.ix.client.TranslateTerm
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_356302605 : EloixClient.IndexServer.BSerializer_175726414 {
		
		public readonly static new BSerializer instance = new BSerializer_356302605();
		
		public BSerializer_356302605()
			: base(356302605) {}
		
		public BSerializer_356302605(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			base.write(obj1, bout1, version);			
			TranslateTerm obj = (TranslateTerm)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.deleted);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.guid);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.tStamp);
			if (version >= 900000018000008L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putString(obj.translationKey);
				if (version >= 900990009000001L) {
					// checkpoint byps.gen.cs.PrintContext:494
					bbuf.putString(obj.tStampSync);
				}
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.langs, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.termLangs, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			TranslateTerm obj = (TranslateTerm)(obj1 != null ? obj1 : bin.onObjectCreated(new TranslateTerm()));
			
			base.read(obj, bin1, version);			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.deleted = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.guid = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.tStamp = bbuf.getString();
			if (version >= 900000018000008L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.translationKey = bbuf.getString();
				if (version >= 900990009000001L) {
					// checkpoint byps.gen.cs.PrintContext:449
					obj.tStampSync = bbuf.getString();
				}
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.langs = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.termLangs = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			
			return obj;
		}
		
	}
} // namespace
