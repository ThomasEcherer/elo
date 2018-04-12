//
// Serializer for de.elo.ix.client.TranslateTermC
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1212336284 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1212336284();
		
		public BSerializer_1212336284()
			: base(1212336284) {}
		
		public BSerializer_1212336284(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			TranslateTermC obj = (TranslateTermC)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.lnTermLang);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			TranslateTermC obj = (TranslateTermC)(obj1 != null ? obj1 : bin.onObjectCreated(new TranslateTermC()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.lnTermLang = bbuf.getInt();
			
			return obj;
		}
		
	}
} // namespace
