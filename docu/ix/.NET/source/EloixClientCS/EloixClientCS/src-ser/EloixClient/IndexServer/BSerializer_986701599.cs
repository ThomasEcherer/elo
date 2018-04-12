//
// Serializer for de.elo.ix.client.FindTranslateTermInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_986701599 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_986701599();
		
		public BSerializer_986701599()
			: base(986701599) {}
		
		public BSerializer_986701599(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			FindTranslateTermInfo obj = (FindTranslateTermInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.inclDeleted);
			if (version >= 700000000000031L) {
				// checkpoint byps.gen.cs.PrintContext:494
				bbuf.putBoolean(obj.inclToBeTranslated);
			}
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.langs, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:494
			bout.writeObj(obj.terms, true, EloixClient.IndexServer.BSerializer_1888107655.instance);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FindTranslateTermInfo obj = (FindTranslateTermInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new FindTranslateTermInfo()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.inclDeleted = bbuf.getBoolean();
			if (version >= 700000000000031L) {
				// checkpoint byps.gen.cs.PrintContext:449
				obj.inclToBeTranslated = bbuf.getBoolean();
			}
			// checkpoint byps.gen.cs.PrintContext:449
			obj.langs = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			// checkpoint byps.gen.cs.PrintContext:449
			obj.terms = (String[])bin.readObj(false, EloixClient.IndexServer.BSerializer_1888107655.instance);
			
			return obj;
		}
		
	}
} // namespace
