//
// Serializer for de.elo.ix.client.FontInfo
// 
// THIS FILE HAS BEEN GENERATED. DO NOT MODIFY.
//

using System;
using System.Collections.Generic;
using byps;

namespace EloixClient.IndexServer
{
	
	public class BSerializer_1478273890 : BSerializer {
		
		public readonly static BSerializer instance = new BSerializer_1478273890();
		
		public BSerializer_1478273890()
			: base(1478273890) {}
		
		public BSerializer_1478273890(int typeId)
			: base(typeId) {}
		
		
		public override void write(Object obj1, BOutput bout1, long version)
		{
			FontInfo obj = (FontInfo)obj1;			
			BOutputBin bout = (BOutputBin)bout1;
			BBufferBin bbuf = bout.bbuf;
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.RGB);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.bold);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.escapement);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putString(obj.faceName);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putInt(obj.height);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.heightPerCell);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.italic);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.strikeOut);
			// checkpoint byps.gen.cs.PrintContext:494
			bbuf.putBoolean(obj.underline);
		}
		
		public override Object read(Object obj1, BInput bin1, long version)
		{
			BInputBin bin = (BInputBin)bin1;
			FontInfo obj = (FontInfo)(obj1 != null ? obj1 : bin.onObjectCreated(new FontInfo()));
			
			BBufferBin bbuf = bin.bbuf;
			// checkpoint byps.gen.cs.PrintContext:449
			obj.RGB = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.bold = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.escapement = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.faceName = bbuf.getString();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.height = bbuf.getInt();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.heightPerCell = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.italic = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.strikeOut = bbuf.getBoolean();
			// checkpoint byps.gen.cs.PrintContext:449
			obj.underline = bbuf.getBoolean();
			
			return obj;
		}
		
	}
} // namespace
